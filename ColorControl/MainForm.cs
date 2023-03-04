﻿using ColorControl.Common;
using ColorControl.Forms;
using ColorControl.Native;
using ColorControl.Services.AMD;
using ColorControl.Services.Common;
using ColorControl.Services.GameLauncher;
using ColorControl.Services.LG;
using ColorControl.Services.NVIDIA;
using ColorControl.Svc;
using LgTv;
using Microsoft.Extensions.DependencyInjection;
using NLog;
using NStandard;
using NvAPIWrapper.Display;
using NWin32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorControl
{
    public partial class MainForm : Form
    {
        private static bool SystemShutdown = false;
        private static bool EndSession = false;
        private static bool UserExit = false;
        private static int SHORTCUTID_SCREENSAVER = -100;
        private static int SHORTCUTID_GAMEBAR = -101;
        private static int SHORTCUTID_NVQA = -200;
        private static int SHORTCUTID_AMDQA = -201;
        private static int SHORTCUTID_LGQA = -202;
        private static int SHORTCUTID_GAMEQA = -203;

        private static readonly Logger Logger = LogManager.GetCurrentClassLogger();

        private string _dataDir;

        private NvService _nvService;
        private NvPanel _nvPanel;
        private string _lastDisplayRefreshRates = string.Empty;

        private NotifyIcon _trayIcon;
        private bool _initialized = false;
        private bool _disableEvents = false;
        private Config _config;
        private bool _setVisibleCalled = false;

        private LgService _lgService;

        private ToolStripMenuItem _nvTrayMenu;
        private ToolStripMenuItem _amdTrayMenu;
        private ToolStripMenuItem _lgTrayMenu;
        private ToolStripMenuItem _gameTrayMenu;

        private StartUpParams StartUpParams { get; }
        public string _lgTabMessage { get; private set; }

        private AmdService _amdService;
        private AmdPanel _amdPanel;
        private bool _skipResize;
        private FileVersionInfo _currentVersionInfo;
        private bool _checkedForUpdates = false;
        private string _updateHtmlUrl;
        private bool _updatingDitherSettings;
        private string _downloadUrl;

        private LgGameBar _gameBarForm;

        private GameService _gameService;

        //private KeyboardHookManager _keyboardHookManager;
        private IntPtr _screenStateNotify;

        private Dictionary<int, Action> _shortcuts = new();

        public MainForm(AppContext appContext)
        {
            InitializeComponent();
            StartUpParams = appContext.StartUpParams;

            _dataDir = Program.DataDir;
            _config = Program.Config;

            LoadConfig();

            MessageForms.MainForm = this;

            _nvTrayMenu = new ToolStripMenuItem("NVIDIA presets");
            _amdTrayMenu = new ToolStripMenuItem("AMD presets");
            _lgTrayMenu = new ToolStripMenuItem("LG presets");
            _gameTrayMenu = new ToolStripMenuItem("Game Launcher");
            _trayIcon = new NotifyIcon()
            {
                Icon = Icon,
                ContextMenuStrip = new ContextMenuStrip(),
                Visible = _config.MinimizeToTray,
                Text = Text
            };

            _trayIcon.ContextMenuStrip.Items.AddRange(new ToolStripItem[] {
                    _nvTrayMenu,
                    _amdTrayMenu,
                    _lgTrayMenu,
                    _gameTrayMenu,
                    new ToolStripSeparator(),
                    new ToolStripMenuItem("Open", null, OpenForm),
                    new ToolStripSeparator(),
                    new ToolStripMenuItem("Restart", null, Restart),
                    new ToolStripMenuItem("Exit", null, Exit)
                });

            _trayIcon.MouseDoubleClick += trayIcon_MouseDoubleClick;
            _trayIcon.ContextMenuStrip.Opened += trayIconContextMenu_Popup;
            _trayIcon.BalloonTipClicked += trayIconBalloonTip_Clicked;

            chkStartAfterLogin.Checked = Utils.TaskExists(Program.TS_TASKNAME);

            chkFixChromeFonts.Enabled = Utils.IsChromeInstalled();
            if (chkFixChromeFonts.Enabled)
            {
                var fixInstalled = Utils.IsChromeFixInstalled();
                if (_config.FixChromeFonts && !fixInstalled)
                {
                    Utils.ExecuteElevated(StartUpParams.ActivateChromeFontFixParam);
                }
                chkFixChromeFonts.Checked = Utils.IsChromeFixInstalled();
            }

            _shortcuts.Add(SHORTCUTID_SCREENSAVER, StartScreenSaver);

            //Utils.StartService();

            InitLgService();
            InitNvService();
            InitAmdService();
            InitGameService();

            InitInfo();
            UpdateServiceInfo();

            UserSessionInfo.Install();
            _screenStateNotify = WinApi.RegisterPowerSettingNotification(Handle, ref Utils.GUID_CONSOLE_DISPLAY_STATE, 0);

            //Scale(new SizeF(1.25F, 1.25F));

            _initialized = true;

            //Task.Run(() => Utils.StartPipeAsync());

            AfterInitialized();
        }

        private void UpdateServiceInfo()
        {
            var text = "Use Windows Service";
            btnStartStopService.Enabled = true;

            if (Utils.IsServiceRunning())
            {
                text += " (running)";
                btnStartStopService.Text = "Stop";
            }
            else if (Utils.IsServiceInstalled())
            {
                text += " (installed, not running)";
                btnStartStopService.Text = "Start";
            }
            else
            {
                text += " (not installed)";
                btnStartStopService.Text = "Start";
                btnStartStopService.Enabled = false;
            }

            rbElevationService.Text = text;
        }

        private void InitNvService()
        {
            try
            {
                //throw new Exception("bla");
                Logger.Debug("Initializing NVIDIA...");
                var appContextProvider = Program.ServiceProvider.GetRequiredService<AppContextProvider>();
                _nvService = new NvService(appContextProvider);
                Logger.Debug("Initializing NVIDIA...Done.");

                _nvPanel = new NvPanel(_nvService, _trayIcon, Handle);
                _nvPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                tabNVIDIA.Controls.Add(_nvPanel);

                InitShortcut(SHORTCUTID_NVQA, _config.NvQuickAccessShortcut, _nvService.ToggleQuickAccessForm);
            }
            catch (Exception ex)
            {
                //Logger.Error("Error initializing NvService: " + e.ToLogString());
                Logger.Debug($"No NVIDIA device detected: {ex.ToLogString()}");
                tcMain.TabPages.Remove(tabNVIDIA);
            }
        }

        private void InitAmdService()
        {
            try
            {
                var appContextProvider = Program.ServiceProvider.GetRequiredService<AppContextProvider>();
                _amdService = new AmdService(appContextProvider);

                _amdPanel = new AmdPanel(_amdService, _trayIcon, Handle);
                _amdPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

                tabAMD.Controls.Add(_amdPanel);

                InitShortcut(SHORTCUTID_AMDQA, _config.AmdQuickAccessShortcut, _amdService.ToggleQuickAccessForm);
            }
            catch (Exception)
            {
                //Logger.Error("Error initializing AmdService: " + e.ToLogString());
                Logger.Debug("No AMD device detected");
                tcMain.TabPages.Remove(tabAMD);
            }
        }

        private void InitGameService()
        {
            try
            {
                var appContextProvider = Program.ServiceProvider.GetRequiredService<AppContextProvider>();
                _gameService = new GameService(appContextProvider, HandleExternalServiceForLgDevice);
                FillGamePresets();

                FormUtils.InitSortState(lvGamePresets, _config.GamePresetsSortState);

                InitShortcut(SHORTCUTID_GAMEQA, _config.GameQuickAccessShortcut, _gameService.ToggleQuickAccessForm);
            }
            catch (Exception e)
            {
                Logger.Error("Error initializing GameService: " + e.ToLogString());
                tcMain.TabPages.Remove(tabGameLauncher);
            }
        }

        private void InitShortcut(int shortcutId, string shortcut, Action action)
        {
            _shortcuts.Add(shortcutId, action);

            if (!string.IsNullOrEmpty(shortcut))
            {
                Utils.RegisterShortcut(Handle, shortcutId, shortcut);
            }
        }

        private void InitLgService()
        {
            try
            {
                var appContextProvider = Program.ServiceProvider.GetRequiredService<AppContextProvider>();

                _lgService = new LgService(appContextProvider, StartUpParams.RunningFromScheduledTask);
                _lgService.RefreshDevices(afterStartUp: true).ContinueWith((_) => BeginInvoke(() => AfterLgServiceRefreshDevices()));
                _lgService.SelectedDeviceChangedEvent += _lgService_SelectedDeviceChangedEvent;

                FillLgPresets();

                edtLgMaxPowerOnRetries.Value = _lgService.Config.PowerOnRetries;
                edtLgOptionShutdownDelay.Value = _lgService.Config.ShutdownDelay;
                edtLgDeviceFilter.Text = _lgService.Config.DeviceSearchKey;
                chkLgShowAdvancedActions.Checked = _lgService.Config.ShowAdvancedActions;
                chkLgSetSelectedDeviceByPowerOn.Checked = _lgService.Config.SetSelectedDeviceByPowerOn;

                FormUtils.InitSortState(lvLgPresets, _config.LgPresetsSortState);

                var values = Enum.GetValues(typeof(ButtonType));
                foreach (var button in values)
                {
                    var text = button.ToString();
                    if (text[0] == '_')
                    {
                        text = text.Substring(1);
                    }

                    var item = mnuLgRcButtons.DropDownItems.Add(text);
                    item.Click += miLgAddButton_Click;
                }

                _lgService.InstallEventHandlers();

                LgDevice.ExternalServiceHandler = HandleExternalServiceForLgDevice;

                InitShortcut(SHORTCUTID_GAMEBAR, _lgService.Config.GameBarShortcut, ToggleGameBar);
                InitShortcut(SHORTCUTID_LGQA, _config.LgQuickAccessShortcut, _lgService.ToggleQuickAccessForm);

                if (!string.IsNullOrEmpty(_lgService.Config.GameBarShortcut))
                {
                    // New shortcut manager, not working yet
                    //if (_keyboardHookManager == null)
                    //{
                    //    _keyboardHookManager = new KeyboardHookManager();
                    //    _keyboardHookManager.Start();
                    //}
                    //_keyboardHookManager.RegisterHotkey(NonInvasiveKeyboardHookLibrary.ModifierKeys.Control | NonInvasiveKeyboardHookLibrary.ModifierKeys.Alt, (int)Keys.F9, new Action(TestKey));

                    edtLgGameBarShortcut.Text = _lgService.Config.GameBarShortcut;
                }
            }
            catch (Exception e)
            {
                Logger.Error("Error initializing LgService: " + e.ToLogString());
            }
        }

        private void TestKey()
        {
            BeginInvoke(async () =>
            {
                var preset = _lgService.GetPresets().FirstOrDefault(p => p.name == "Backlight 20");

                await _lgService.ApplyPreset(preset);
            });
        }

        private void _lgService_SelectedDeviceChangedEvent(object sender, EventArgs e)
        {
            BeginInvoke(() => SetLgDevicesSelectedIndex(sender));
        }

        private void SetLgDevicesSelectedIndex(object sender)
        {
            if (sender == null)
            {
                cbxLgDevices.SelectedIndex = -1;
                return;
            }

            cbxLgDevices.SelectedIndex = cbxLgDevices.Items.IndexOf(sender);
        }

        private void AfterLgServiceRefreshDevices()
        {
            FillLgDevices();

            if (StartUpParams.ExecuteLgPreset)
            {
                var _ = _lgService.ApplyPreset(StartUpParams.LgPresetName);
            }
        }

        private bool HandleExternalServiceForLgDevice(string serviceName, string[] parameters)
        {
            if (string.IsNullOrEmpty(serviceName) || parameters.Length == 0)
            {
                return false;
            }

            if (_nvService != null && serviceName.Equals("NvPreset", StringComparison.OrdinalIgnoreCase))
            {
                return _nvService.ApplyPreset(parameters[0]);
            }
            if (_nvService != null && serviceName.Equals("GsyncEnabled", StringComparison.OrdinalIgnoreCase))
            {
                return _nvService.IsGsyncEnabled();
            }
            if (_amdService != null && serviceName.Equals("AmdPreset", StringComparison.OrdinalIgnoreCase))
            {
                return _amdService.ApplyPreset(parameters[0]);
            }
            if (_lgService != null && serviceName.Equals("LgPreset", StringComparison.OrdinalIgnoreCase))
            {
                Utils.WaitForTask(_lgService.ApplyPreset(parameters[0]));

                return true;
            }

            if (serviceName.Equals("StartProgram", StringComparison.OrdinalIgnoreCase))
            {
                Utils.StartProcess(parameters[0], parameters.Length > 1 ? string.Join(" ", parameters.Skip(1)) : null, setWorkingDir: true);

                return true;
            }

            return false;
        }

        private void InitInfo()
        {
            _currentVersionInfo = FileVersionInfo.GetVersionInfo(Path.GetFileName(Application.ExecutablePath));

            //if (ApplicationDeployment.IsNetworkDeployed)
            //{
            //    Text = Application.ProductName + " " + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            //}
            //else
            //{
            Text = Application.ProductName + " " + Application.ProductVersion;
            //}

            if (Utils.IsAdministrator())
            {
                Text += " (administrator)";
            }

            lblInfo.Text = Text + " - " + _currentVersionInfo.LegalCopyright;

            lbPlugins.Items.Add("lgtv.net by gr4b4z");
            lbPlugins.Items.Add("Newtonsoft.Json by James Newton-King");
            lbPlugins.Items.Add("NLog by Jarek Kowalski, Kim Christensen, Julian Verdurmen");
            lbPlugins.Items.Add("NvAPIWrapper.Net by Soroush Falahati");
            lbPlugins.Items.Add("NWin32 by zmjack");
            lbPlugins.Items.Add("TaskScheduler by David Hall");
            lbPlugins.Items.Add("NVIDIA Profile Inspector by Orbmu2k");
        }

        private void OpenForm(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
            Activate();
        }

        void Exit(object sender, EventArgs e)
        {
            UserExit = true;
            Close();
        }

        void Restart(object sender, EventArgs e)
        {
            Program.Restart();
        }

        private void trayIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void trayIconBalloonTip_Clicked(object sender, EventArgs e)
        {
            if (_updateHtmlUrl != null)
            {
                Utils.StartProcess(_updateHtmlUrl);
            }
        }

        private void FillGamePresets()
        {
            FormUtils.InitListView(lvGamePresets, GamePreset.GetColumnNames());

            foreach (var preset in _gameService.GetPresets())
            {
                AddOrUpdateItemGame(preset);
                Utils.RegisterShortcut(Handle, preset.id, preset.shortcut);
            }
        }

        private void AddOrUpdateItemGame(GamePreset preset = null)
        {
            FormUtils.AddOrUpdateListItem(lvGamePresets, _gameService.GetPresets(), _config, preset);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!(SystemShutdown || EndSession || UserExit) && _config.MinimizeOnClose)
            {
                e.Cancel = true;
                WindowState = FormWindowState.Minimized;
                UserExit = false;
                return;
            }

            GlobalSave();

            if (SystemShutdown && _lgService != null)
            {
                Logger.Debug($"MainForm_FormClosing: SystemShutdown");

                var devices = _lgService.Devices.Where(d => d.PowerOffOnShutdown);

                _lgService.PowerOffDevices(devices);
            }
        }

        private void GlobalSave()
        {
            _nvService?.GlobalSave();
            _amdService?.GlobalSave();
            _lgService?.GlobalSave();
            _gameService?.GlobalSave();

            _nvPanel?.Save();
            _amdPanel?.Save();

            FormUtils.SaveSortState(lvLgPresets.ListViewItemSorter, _config.LgPresetsSortState);
            FormUtils.SaveSortState(lvGamePresets.ListViewItemSorter, _config.GamePresetsSortState);

            SaveConfig();
        }

        private Control FindFocusedControl()
        {
            ContainerControl container = this;
            Control control = null;
            while (container != null)
            {
                control = container.ActiveControl;
                container = control as ContainerControl;
            }

            return control;
        }

        private bool IsShortcutControlFocused()
        {
            if (Form.ActiveForm?.GetType().Name.Equals("MessageForm") == true)
            {
                return true;
            }
            var control = FindFocusedControl();
            return control?.Name.Contains("Shortcut") ?? false;
        }

        protected override void WndProc(ref Message m)
        {
            // 5. Catch when a HotKey is pressed !
            if (m.Msg == NativeConstants.WM_HOTKEY && !IsShortcutControlFocused())
            {
                var id = m.WParam.ToInt32();

                if (_shortcuts.TryGetValue(id, out var action))
                {
                    action();
                }
                // 6. Handle what will happen once a respective hotkey is pressed
                else
                {
                    var preset = _nvService?.GetPresets().FirstOrDefault(x => x.id == id);
                    if (preset != null)
                    {
                        _nvPanel?.ApplyNvPreset(preset);
                    }

                    var amdPreset = _amdService?.GetPresets().FirstOrDefault(x => x.id == id);
                    if (amdPreset != null)
                    {
                        _amdPanel?.ApplyAmdPreset(amdPreset);
                    }

                    var lgPreset = _lgService?.GetPresets().FirstOrDefault(x => x.id == id);
                    if (lgPreset != null)
                    {
                        ApplyLgPreset(lgPreset);
                    }
                }
            }
            else if (m.Msg == NativeConstants.WM_QUERYENDSESSION)
            {
                SystemShutdown = true;
            }
            else if (m.Msg == NativeConstants.WM_ENDSESSION)
            {
                EndSession = true;
            }
            else if (m.Msg == Utils.WM_BRINGTOFRONT)
            {
                Logger.Debug("WM_BRINGTOFRONT message received, opening form");
                OpenForm(this, EventArgs.Empty);
            }
            else if (m.Msg == NativeConstants.WM_SYSCOMMAND)
            {
                //Logger.Debug($"WM_SYSCOMMAND: {m.WParam.ToInt32()}");

                if (m.WParam.ToInt32() == NativeConstants.SC_MONITORPOWER)
                {

                }
            }
            else if (m.Msg == NativeConstants.WM_POWERBROADCAST)
            {
                if (m.WParam.ToInt32() == WinApi.PBT_POWERSETTINGCHANGE)
                {
                    var ps = Marshal.PtrToStructure<WinApi.POWERBROADCAST_SETTING>(m.LParam);

                    Logger.Debug($"PBT_POWERSETTINGCHANGE: {ps.Data}");

                    _lgService?.PowerSettingChanged((LgService.WindowsPowerSetting)ps.Data);
                }
            }

            base.WndProc(ref m);
        }

        private void StartScreenSaver()
        {
            var screenSaver = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "scrnsave.scr");
            Process.Start("explorer.exe", screenSaver);
        }

        private void edtShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = Utils.FormatKeyboardShortcut(e);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Hide tray icon, otherwise it will remain shown until user mouses over it
            _trayIcon.Visible = false;

            if (_screenStateNotify != IntPtr.Zero)
            {
                WinApi.UnregisterPowerSettingNotification(_screenStateNotify);
                _screenStateNotify = IntPtr.Zero;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (_skipResize)
            {
                return;
            }

            if (WindowState == FormWindowState.Minimized)
            {
                if (_config.MinimizeToTray)
                {
                    Hide();
                }
            }
            else if (WindowState == FormWindowState.Normal && _config != null)
            {
                _config.FormWidth = Width;
                _config.FormHeight = Height;
            }
        }

        private void chkStartAfterLogin_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }
            var enabled = chkStartAfterLogin.Checked;
            RegisterScheduledTask(enabled);

            rbElevationAdmin.Enabled = enabled;
            if (!enabled && rbElevationAdmin.Checked)
            {
                rbElevationNone.Checked = true;
            }
        }

        private void LoadConfig()
        {
            chkStartMinimized.Checked = _config.StartMinimized;
            chkMinimizeOnClose.Checked = _config.MinimizeOnClose;
            chkMinimizeToSystemTray.Checked = _config.MinimizeToTray;
            chkCheckForUpdates.Checked = _config.CheckForUpdates;
            chkAutoInstallUpdates.Checked = _config.AutoInstallUpdates;
            chkAutoInstallUpdates.Enabled = _config.CheckForUpdates && _config.ElevationMethod == ElevationMethod.UseService;
            edtBlankScreenSaverShortcut.Text = _config.ScreenSaverShortcut;
            chkGdiScaling.Checked = _config.UseGdiScaling;

            if (!string.IsNullOrEmpty(_config.ScreenSaverShortcut))
            {
                Utils.RegisterShortcut(Handle, SHORTCUTID_SCREENSAVER, _config.ScreenSaverShortcut);
            }

            _skipResize = true;
            try
            {
                Width = _config.FormWidth;
                Height = _config.FormHeight;
            }
            finally
            {
                _skipResize = false;
            }
        }

        private void SaveConfig()
        {
            _config.StartMinimized = chkStartMinimized.Checked;
            if (WindowState != FormWindowState.Minimized)
            {
                _config.FormWidth = Width;
                _config.FormHeight = Height;
            }

            Utils.WriteObject(Program.ConfigFilename, _config);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (_nvService == null)
            {
                //FormUtils.ShowControls(tabNVIDIA, false, lblError);

                //lblError.Text = "Error while initializing the NVIDIA-wrapper. You either don't have a NVIDIA GPU or it is disabled. NVIDIA controls will not be available.";
                //lblError.Visible = true;
            }

            if (_amdService == null)
            {
                //FormUtils.ShowControls(tabAMD, false, lblErrorAMD);

                //lblErrorAMD.Text = "Error while initializing the ADL-wrapper. You either don't have a AMD GPU or it is disabled. AMD controls will not be available.";
                //lblErrorAMD.Visible = true;
            }

            if (_lgService == null)
            {
                FormUtils.ShowControls(tabLG, false, lblLgError);
                lblLgError.Text = "Error while initializing the LG-controller. You either don't have a LG TV, it is disabled or a configuration file is corrupt.";
                lblLgError.Visible = true;
            }

            InitSelectedTab();
            CheckForUpdates();

            CheckElevationMethod();
        }

        private void CheckElevationMethod()
        {
            if (Utils.IsAdministrator())
            {
                return;
            }

            if (_config.ElevationMethodAsked)
            {
                if (Debugger.IsAttached)
                {
                    return;
                }

                if (_config.ElevationMethod == ElevationMethod.UseService && !Utils.IsServiceInstalled() &&
                    (MessageForms.QuestionYesNo("The elevation method is set to Windows Service but it is not installed. Do you want to install it now?") == DialogResult.Yes))
                {
                    Utils.InstallService();
                }
                else if (_config.ElevationMethod == ElevationMethod.UseService && !Utils.IsServiceRunning() &&
                    (MessageForms.QuestionYesNo("The elevation method is set to Windows Service but it is not running. Do you want to start it now?") == DialogResult.Yes))
                {
                    Utils.StartService();
                }

                return;
            }

            var result = MessageForms.QuestionYesNo(Utils.ELEVATION_MSG + @"

Do you want to install and start the Windows Service now? You can always change this on the Options-tab page.

NOTE: installing the service may cause a User Account Control popup.");
            if (result == DialogResult.Yes)
            {
                SetElevationMethod(ElevationMethod.UseService);
            }

            _config.ElevationMethodAsked = true;
        }

        protected override void SetVisibleCore(bool value)
        {
            if (!_setVisibleCalled && _config.StartMinimized)
            {
                _setVisibleCalled = true;
                if (_config.MinimizeToTray)
                {
                    value = false;
                }
                else
                {
                    WindowState = FormWindowState.Minimized;
                }
            }
            if (!IsDisposed)
            {
                base.SetVisibleCore(value);
            }
        }

        private void edtShortcut_KeyUp(object sender, KeyEventArgs e)
        {
            Utils.HandleKeyboardShortcutUp(e);
        }

        private GamePreset GetSelectedGamePreset()
        {
            if (lvGamePresets.SelectedItems.Count > 0)
            {
                var item = lvGamePresets.SelectedItems[0];
                return (GamePreset)item.Tag;
            }
            else
            {
                return null;
            }
        }

        private void FillLgPresets()
        {
            FormUtils.InitListView(lvLgPresets, LgPreset.GetColumnNames());

            foreach (var preset in _lgService.GetPresets())
            {
                AddOrUpdateItemLg(preset);
                Utils.RegisterShortcut(Handle, preset.id, preset.shortcut);
            }
        }

        private void AddOrUpdateItemLg(LgPreset preset = null, ListViewItem specItem = null)
        {
            FormUtils.AddOrUpdateListItem(lvLgPresets, _lgService.GetPresets(), _config, preset, specItem);
        }

        private void btnCloneLg_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedLgPreset();

            var newPreset = preset.Clone();
            AddOrUpdateItemLg(newPreset);
        }

        private LgPreset GetSelectedLgPreset()
        {
            if (lvLgPresets.SelectedItems.Count > 0)
            {
                var item = lvLgPresets.SelectedItems[0];
                return (LgPreset)item.Tag;
            }
            else
            {
                return null;
            }
        }

        private void lvLgPresets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var enabled = lvLgPresets.SelectedItems.Count > 0;
            btnApplyLg.Enabled = enabled;
            btnCloneLg.Enabled = enabled;
            edtNameLg.Enabled = enabled;
            chkLgQuickAccess.Enabled = enabled;
            edtLgPresetDescription.Enabled = enabled;
            cbxLgPresetDevice.Enabled = enabled;
            edtShortcutLg.Enabled = enabled;
            btnSetShortcutLg.Enabled = enabled;
            edtStepsLg.Enabled = enabled;
            btnLgAddButton.Enabled = enabled;
            cbxLgApps.Enabled = enabled;
            btnLgRefreshApps.Enabled = enabled;
            btnDeleteLg.Enabled = enabled;
            cbxLgPresetTrigger.Enabled = enabled;
            edtLgPresetTriggerConditions.Enabled = enabled;
            btnLgPresetEditTriggerConditions.Enabled = enabled;
            edtLgPresetIncludedProcesses.Enabled = enabled;
            edtLgPresetExcludedProcesses.Enabled = enabled;

            var preset = GetSelectedLgPreset();

            if (preset != null)
            {
                edtNameLg.Text = preset.name;
                chkLgQuickAccess.Checked = preset.ShowInQuickAccess;
                edtLgPresetDescription.Text = preset.Description;
                var lgApps = _lgService?.GetApps();
                cbxLgApps.SelectedIndex = lgApps == null ? -1 : lgApps.FindIndex(x => x.appId.Equals(preset.appId));
                edtShortcutLg.Text = preset.shortcut;
                edtStepsLg.Text = preset.steps.Aggregate("", (a, b) => (string.IsNullOrEmpty(a) ? "" : a + ", ") + b);

                var index = -1;

                for (var i = 0; i < cbxLgPresetDevice.Items.Count; i++)
                {
                    var pnpDev = (LgDevice)cbxLgPresetDevice.Items[i];
                    if ((string.IsNullOrEmpty(preset.DeviceMacAddress) && string.IsNullOrEmpty(pnpDev.MacAddress)) || pnpDev.MacAddress.Equals(preset.DeviceMacAddress, StringComparison.OrdinalIgnoreCase))
                    {
                        index = i;
                        break;
                    }
                }

                cbxLgPresetDevice.SelectedIndex = index;

                var trigger = preset.Triggers.FirstOrDefault();

                FormUtils.SetComboBoxEnumIndex(cbxLgPresetTrigger, (int)(trigger?.Trigger ?? PresetTriggerType.None));

                edtLgPresetTriggerConditions.Text = Utils.GetDescriptions<PresetConditionType>(trigger != null ? (int)trigger.Conditions : 0).Join(", ");
                edtLgPresetTriggerConditions.Tag = trigger != null ? (int)trigger.Conditions : 0;

                edtLgPresetIncludedProcesses.Text = trigger?.IncludedProcesses?.Join(", ") ?? string.Empty;
                edtLgPresetExcludedProcesses.Text = trigger?.ExcludedProcesses?.Join(", ") ?? string.Empty;
            }
            else
            {
                edtNameLg.Text = string.Empty;
                chkLgQuickAccess.Checked = false;
                edtLgPresetDescription.Text = string.Empty;
                cbxLgApps.SelectedIndex = -1;
                edtShortcutLg.Text = string.Empty;
                edtStepsLg.Text = string.Empty;
                cbxLgPresetDevice.SelectedIndex = -1;
                cbxLgPresetTrigger.SelectedIndex = -1;
                edtLgPresetTriggerConditions.Text = string.Empty;
                edtLgPresetTriggerConditions.Tag = 0;
                edtLgPresetIncludedProcesses.Text = string.Empty;
                edtLgPresetExcludedProcesses.Text = string.Empty;
            }
        }

        private void btnApplyLg_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedLgPreset();

            ApplyLgPreset(preset);
        }

        private void btnSetShortcutLg_Click(object sender, EventArgs e)
        {
            var shortcut = edtShortcutLg.Text.Trim();
            if (!Utils.ValidateShortcut(shortcut))
            {
                return;
            }

            var preset = GetSelectedLgPreset();

            var name = edtNameLg.Text.Trim();

            if (name.Length == 0 || _lgService.GetPresets().Any(x => x.id != preset.id && x.name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageForms.WarningOk("The name can not be empty and must be unique.");
                return;
            }

            var clear = !string.IsNullOrEmpty(preset.shortcut);

            preset.name = name;
            preset.ShowInQuickAccess = chkLgQuickAccess.Checked;
            preset.Description = edtLgPresetDescription.Text.Trim();

            if (cbxLgPresetDevice.SelectedIndex == -1)
            {
                preset.DeviceMacAddress = string.Empty;
            }
            else
            {
                var device = (LgDevice)cbxLgPresetDevice.SelectedItem;
                preset.DeviceMacAddress = device.MacAddress;
            }

            if (cbxLgApps.SelectedIndex == -1)
            {
                preset.appId = string.Empty;
            }
            else
            {
                var lgApp = (LgApp)cbxLgApps.SelectedItem;
                preset.appId = lgApp.appId;
            }

            var triggerType = FormUtils.GetComboBoxEnumItem<PresetTriggerType>(cbxLgPresetTrigger);
            preset.UpdateTrigger(triggerType,
                                 (PresetConditionType)edtLgPresetTriggerConditions.Tag,
                                 edtLgPresetIncludedProcesses.Text,
                                 edtLgPresetExcludedProcesses.Text);

            if (triggerType != PresetTriggerType.None)
            {
                _lgService.InstallEventHandlers();
            }

            var shortcutChanged = !shortcut.Equals(preset.shortcut);
            if (shortcutChanged)
            {
                preset.shortcut = shortcut;
            }

            var text = edtStepsLg.Text;

            Utils.ParseWords(preset.steps, text);

            AddOrUpdateItemLg();

            if (shortcutChanged)
            {
                Utils.RegisterShortcut(Handle, preset.id, preset.shortcut, clear);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitSelectedTab();
        }

        private void InitSelectedTab()
        {
            if (tcMain.SelectedTab == tabLG)
            {
                InitLgTab();
            }
            else if (tcMain.SelectedTab == tabLog)
            {
                LoadLog();
            }
            else if (tcMain.SelectedTab == tabInfo)
            {
                LoadInfo();
            }
            else if (tcMain.SelectedTab == tabOptions)
            {
                InitOptionsTab();
            }
            else if (tcMain.SelectedTab == tabNVIDIA)
            {
                _nvPanel?.UpdateInfo();
            }
            else if (tcMain.SelectedTab == tabGameLauncher)
            {
                UpdateGameLauncherTab();
            }
        }

        private void UpdateGameLauncherTab()
        {
            if (cbxGameStepType.Items.Count == 0)
            {
                cbxGameStepType.Items.AddRange(Utils.GetDescriptions<GameStepType>().ToArray());
                cbxGameStepType.SelectedIndex = 0;
            }
        }

        private void InitLgTab()
        {
            if (_lgService == null)
            {
                return;
            }

            if (scLgController.Panel2.Controls.Count == 0)
            {
                var rcPanel = new RemoteControlPanel(_lgService, _lgService.GetRemoteControlButtons());
                rcPanel.Parent = scLgController.Panel2;
                rcPanel.Dock = DockStyle.Fill;
            }
            chkLgRemoteControlShow.Checked = _lgService.Config.ShowRemoteControl;
            scLgController.Panel2Collapsed = !_lgService.Config.ShowRemoteControl;

            FormUtils.BuildComboBox(cbxLgPresetTrigger, PresetTriggerType.Resume, PresetTriggerType.Shutdown, PresetTriggerType.Standby, PresetTriggerType.Startup, PresetTriggerType.Reserved5, PresetTriggerType.ScreensaverStart, PresetTriggerType.ScreensaverStop);

            if (!string.IsNullOrEmpty(_lgTabMessage))
            {
                MessageForms.WarningOk(_lgTabMessage);
                _lgTabMessage = null;
            }
        }

        private void InitOptionsTab()
        {
            grpNvidiaOptions.Visible = _nvService != null;
            if (grpNvidiaOptions.Visible)
            {
                if (cbxDitheringBitDepth.Items.Count == 0)
                {
                    cbxDitheringBitDepth.Items.AddRange(Utils.GetDescriptions<NvDitherBits>().ToArray());
                    cbxDitheringMode.Items.AddRange(Utils.GetDescriptions<NvDitherMode>().ToArray());
                    FillGradient();
                }

                if (cbxDitheringDisplay.Items.Count == 0)
                {
                    var displays = _nvService.GetDisplayInfos();
                    var primaryDisplay = _nvService.GetPrimaryDisplay();
                    var primaryDisplayInfo = displays.FirstOrDefault(d => d.Display == primaryDisplay);
                    var index = primaryDisplayInfo != null ? displays.IndexOf(primaryDisplayInfo) : 0;

                    cbxDitheringDisplay.Items.AddRange(displays.ToArray());

                    cbxDitheringDisplay.SelectedIndex = index;
                }

                UpdateDitherSettings();
            }

            _initialized = false;
            try
            {
                var _ = _config.ElevationMethod switch
                {
                    ElevationMethod.None => rbElevationNone.Checked = true,
                    ElevationMethod.RunAsAdmin => rbElevationAdmin.Checked = true,
                    ElevationMethod.UseService => rbElevationService.Checked = true,
                    ElevationMethod.UseElevatedProcess => rbElevationProcess.Checked = true,
                    _ => false
                };
            }
            finally
            {
                _initialized = true;
            }

            UpdateServiceInfo();
        }

        private void UpdateDitherSettings()
        {
            var display = ((NvDisplayInfo)cbxDitheringDisplay.SelectedItem)?.Display;
            var ditherInfo = _nvService.GetDithering(display);

            if (ditherInfo.state == -1)
            {
                MessageForms.ErrorOk("Error retrieving dithering settings. See log for details.");
                return;
            }

            var state = (NvDitherState)ditherInfo.state;

            _updatingDitherSettings = true;
            try
            {
                chkDitheringEnabled.CheckState = state switch { NvDitherState.Enabled => CheckState.Checked, NvDitherState.Disabled => CheckState.Unchecked, _ => CheckState.Indeterminate };
                cbxDitheringBitDepth.SelectedIndex = ditherInfo.bits;
                cbxDitheringMode.SelectedIndex = ditherInfo.mode;

                cbxDitheringBitDepth.Enabled = state == NvDitherState.Enabled;
                cbxDitheringMode.Enabled = state == NvDitherState.Enabled;
            }
            finally
            {
                _updatingDitherSettings = false;
            }
        }

        private void FillLgDevices()
        {
            var devices = _lgService.Devices;

            cbxLgDevices.Items.Clear();
            cbxLgDevices.Items.AddRange(devices.ToArray());

            cbxLgPresetDevice.Items.Clear();
            cbxLgPresetDevice.Items.AddRange(devices.ToArray());
            var globalDevice = new LgDevice("Globally selected device", string.Empty, string.Empty, true, true);
            cbxLgPresetDevice.Items.Insert(0, globalDevice);

            var device = _lgService.SelectedDevice;

            if (device != null)
            {
                cbxLgDevices.SelectedIndex = cbxLgDevices.Items.IndexOf(device);
            }

            if (!devices.Any())
            {
                var message = "It seems there's no LG TV available! Please make sure it's connected to the same network as this PC.";

                if (tcMain.SelectedTab == tabLG)
                {
                    MessageForms.WarningOk(message);
                }
                else
                {
                    _lgTabMessage = message;
                }
            }

            if (cbxLgApps.Items.Count == 0 && device != null)
            {
                _lgService.RefreshApps().ContinueWith((task) => BeginInvoke(() => FillLgApps(false)));
            }

            btnLgDeviceConvertToCustom.Enabled = devices.Any();
            btnLgExpert.Enabled = devices.Any();
            btnLgGameBar.Enabled = devices.Any();

            cbxLgDevices_SelectedIndexChanged(cbxLgDevices, null);

            SetLgDevicePowerOptions();
        }

        private void SetLgDevicePowerOptions()
        {
            var device = _lgService.SelectedDevice;
            clbLgPower.Enabled = device != null;

            _disableEvents = true;
            try
            {
                clbLgPower.SetItemChecked(0, device?.PowerOnAfterStartup ?? false);
                clbLgPower.SetItemChecked(1, device?.PowerOnAfterResume ?? false);
                clbLgPower.SetItemChecked(2, device?.PowerOffOnShutdown ?? false);
                clbLgPower.SetItemChecked(3, device?.PowerOffOnStandby ?? false);
                clbLgPower.SetItemChecked(4, device?.PowerOffOnScreenSaver ?? false);
                clbLgPower.SetItemChecked(5, device?.PowerOnAfterScreenSaver ?? false);
                clbLgPower.SetItemChecked(6, device?.PowerOnAfterManualPowerOff ?? false);
                clbLgPower.SetItemChecked(7, device?.TriggersEnabled ?? true);
                clbLgPower.SetItemChecked(8, device?.PowerOffByWindows ?? false);
                clbLgPower.SetItemChecked(9, device?.PowerOnByWindows ?? false);
                clbLgPower.SetItemChecked(10, device?.UseSecureConnection ?? false);
            }
            finally
            {
                _disableEvents = false;
            }
        }

        private void FillLgApps(bool forced)
        {
            var lgApps = _lgService?.GetApps();
            if (forced && (lgApps == null || !lgApps.Any()))
            {
                MessageForms.WarningOk("Could not refresh the apps. Check the log for details.");
                return;
            }
            InitLgApps();
        }

        private void InitLgApps()
        {
            var lgApps = _lgService?.GetApps();

            cbxLgApps.Items.Clear();
            if (lgApps != null)
            {
                cbxLgApps.Items.AddRange(lgApps.ToArray());
            }

            for (var i = 0; i < lvLgPresets.Items.Count; i++)
            {
                var item = lvLgPresets.Items[i];
                AddOrUpdateItemLg((LgPreset)item.Tag, item);
            }

            var preset = GetSelectedLgPreset();
            if (preset != null)
            {
                cbxLgApps.SelectedIndex = lgApps == null ? -1 : lgApps.FindIndex(x => x.appId.Equals(preset.appId));
            }
        }

        private void UpdateTrayMenu(ToolStripMenuItem menu, IEnumerable<PresetBase> presets, EventHandler eventHandler)
        {
            menu.DropDownItems.Clear();

            foreach (var preset in presets)
            {
                var name = preset.GetTextForMenuItem();
                var keys = Keys.None;

                if (!string.IsNullOrEmpty(preset.shortcut))
                {
                    name += "        " + preset.shortcut;
                    //keys = Utils.ShortcutToKeys(preset.shortcut);
                }

                var item = new ToolStripMenuItem(name, null, null, keys);
                item.Tag = preset;
                item.Click += eventHandler;
                menu.DropDownItems.Add(item);
            }
        }

        private void TrayMenuItemNv_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            var preset = (NvPreset)item.Tag;

            _nvPanel?.ApplyNvPreset(preset);
        }

        private void TrayMenuItemAmd_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            var preset = (AmdPreset)item.Tag;

            _amdPanel?.ApplyAmdPreset(preset);
        }

        private void TrayMenuItemGame_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            var preset = (GamePreset)item.Tag;

            ApplyGamePreset(preset);
        }

        private void trayIconContextMenu_Popup(object sender, EventArgs e)
        {
            _nvTrayMenu.Visible = _nvService != null;
            if (_nvTrayMenu.Visible)
            {
                var presets = _nvService.GetPresets().Where(x => x.applyColorData || x.applyDithering || x.applyHDR || x.applyRefreshRate || x.applyResolution || x.applyDriverSettings);

                UpdateTrayMenu(_nvTrayMenu, presets, TrayMenuItemNv_Click);
            }

            _amdTrayMenu.Visible = _amdService != null;
            if (_amdTrayMenu.Visible)
            {
                var presets = _amdService.GetPresets().Where(x => x.applyColorData || x.applyDithering || x.applyHDR || x.applyRefreshRate);

                UpdateTrayMenu(_amdTrayMenu, presets, TrayMenuItemAmd_Click);
            }

            _lgTrayMenu.Visible = _lgService != null;
            if (_lgTrayMenu.Visible)
            {
                var presets = _lgService.GetPresets().Where(x => !string.IsNullOrEmpty(x.appId) || x.steps.Any());

                _lgTrayMenu.DropDownItems.Clear();

                UpdateTrayMenu(_lgTrayMenu, presets, TrayMenuItemLg_Click);
            }

            _gameTrayMenu.Visible = _gameService != null;
            if (_gameTrayMenu.Visible)
            {
                var presets = _gameService.GetPresets();

                _gameTrayMenu.DropDownItems.Clear();

                UpdateTrayMenu(_gameTrayMenu, presets, TrayMenuItemGame_Click);
            }
        }

        private void TrayMenuItemLg_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripMenuItem;
            var preset = (LgPreset)item.Tag;

            ApplyLgPreset(preset);
        }

        private void ApplySelectedGamePreset()
        {
            var preset = GetSelectedGamePreset();
            ApplyGamePreset(preset);
        }

        private void btnDeleteLg_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedLgPreset();

            if (preset == null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(preset.shortcut))
            {
                WinApi.UnregisterHotKey(Handle, preset.id);
            }

            _lgService.GetPresets().Remove(preset);

            var item = lvLgPresets.SelectedItems[0];
            lvLgPresets.Items.Remove(item);
        }

        private void btnAddLg_Click(object sender, EventArgs e)
        {
            AddOrUpdateItemLg(_lgService.CreateNewPreset());
        }

        private void ApplyLgPreset(LgPreset preset, bool reconnect = false, bool wait = false)
        {
            if (preset == null)
            {
                return;
            }

            var applyTask = _lgService.ApplyPreset(preset, reconnect).ContinueWith((task) => BeginInvoke(() => LgPresetApplied(task)));
            if (wait)
            {
                Utils.WaitForTask(applyTask);
            }
        }

        private void LgPresetApplied(Task<bool> task)
        {
            var result = task.Result;
            if (!result)
            {
                MessageForms.WarningOk("Could not apply the preset (entirely). Check the log for details.");
            }
        }

        private bool ApplyGamePreset(GamePreset preset)
        {
            if (preset == null || _gameService == null)
            {
                return false;
            }
            try
            {
                var result = _gameService.ApplyPreset(preset, Program.AppContext);
                if (!result)
                {
                    throw new Exception("Error while applying Game-preset. At least one setting could not be applied. Check the log for details.");
                }

                return true;
            }
            catch (Exception e)
            {
                MessageForms.ErrorOk($"Error applying Game-preset ({e.TargetSite.Name}): {e.Message}");
                return false;
            }
        }

        private void LoadLog()
        {
            var logType = cbxLogType.SelectedIndex;

            if (logType == -1)
            {
                cbxLogType.SelectedIndex = 0;
                return;
            }

            string text;

            if (logType == 0)
            {
                var filename = Path.Combine(_dataDir, "LogFile.txt");

                text = Utils.ReadText(filename);

                text ??= "No log file found";
            }
            else
            {
                if (Utils.IsServiceRunning())
                {
                    var message = new SvcMessage { MessageType = SvcMessageType.GetLog };

                    var result = PipeUtils.SendMessage(message);

                    text = result?.Data ?? "Cannot get log from service";
                }
                else
                {
                    text = "The service is not installed or not running";
                }
            }

            edtLog.Text = text;

            edtLog.SelectionStart = text.Length;
            edtLog.ScrollToCaret();
        }

        private void LoadInfo()
        {
            grpNVIDIAInfo.Visible = _nvService != null;
        }

        private void btnLgRefreshApps_Click(object sender, EventArgs e)
        {
            _lgService.RefreshApps(true).ContinueWith((task) => BeginInvoke(() => FillLgApps(true)));
        }

        private void cbxLgDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxLgPcHdmiPort.Enabled = cbxLgDevices.SelectedIndex > -1;
            if (cbxLgDevices.SelectedIndex == -1)
            {
                _lgService.SelectedDevice = null;
                cbxLgPcHdmiPort.SelectedIndex = 0;
            }
            else
            {
                _lgService.SelectedDevice = (LgDevice)cbxLgDevices.SelectedItem;
                cbxLgPcHdmiPort.SelectedIndex = _lgService.SelectedDevice.HDMIPortNumber;
            }
            chkLgRemoteControlShow.Enabled = _lgService.SelectedDevice != null;
            btnLgRemoveDevice.Enabled = _lgService.SelectedDevice != null && _lgService.SelectedDevice.IsCustom;
            btnLgDeviceConvertToCustom.Enabled = _lgService.SelectedDevice != null && !_lgService.SelectedDevice.IsCustom;

            SetLgDevicePowerOptions();
        }

        private void lvLgPresets_DoubleClick(object sender, EventArgs e)
        {
            ApplySelectedLgPreset();
        }

        private void ApplySelectedLgPreset()
        {
            var preset = GetSelectedLgPreset();
            ApplyLgPreset(preset);
        }

        private void btnRefreshNVIDIAInfo_Click(object sender, EventArgs e)
        {
            if (_nvService != null)
            {
                tvNVIDIAInfo.Nodes.Clear();
                var displays = Display.GetDisplays();
                for (var i = 0; i < displays.Length; i++)
                {
                    var display = displays[i];
                    var node = TreeNodeBuilder.CreateTree(display, $"Display[{i}]");
                    tvNVIDIAInfo.Nodes.Add(node);
                }
            }
        }

        private void btnLgAddButton_Click(object sender, EventArgs e)
        {
            mnuLgButtons.Show(btnLgAddButton, btnLgAddButton.PointToClient(Cursor.Position));
        }

        private void miLgAddButton_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;

            FormUtils.AddStepToTextBox(edtStepsLg, item.Text);
        }

        private void miLgAddAction_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var action = item.Tag as LgDevice.InvokableAction;

            var value = ShowLgActionForm(action);

            if (!string.IsNullOrEmpty(value))
            {
                var text = $"{action.Name}({value})";

                FormUtils.AddStepToTextBox(edtStepsLg, text);
            }
        }

        private string ShowLgActionForm(LgDevice.InvokableAction action)
        {
            var text = action.Name;
            var title = action.Title ?? action.Name;

            var value = string.Empty;

            if (action.EnumType == null)
            {
                if (action.MinValue != action.MaxValue)
                {
                    List<MessageForms.FieldDefinition> fields = new();

                    if (action.NumberOfValues == 1)
                    {
                        fields.Add(new MessageForms.FieldDefinition
                        {
                            Label = "Enter desired " + title,
                            FieldType = MessageForms.FieldType.Numeric,
                            MinValue = action.MinValue,
                            MaxValue = action.MaxValue,
                        });
                    }
                    else
                    {
                        var array = Enumerable.Range(0, action.NumberOfValues);

                        fields.AddRange(array.Select(i => new MessageForms.FieldDefinition
                        {
                            Label = "Value for " + i,
                            FieldType = MessageForms.FieldType.Numeric,
                            MinValue = action.MinValue,
                            MaxValue = action.MaxValue,
                        }));
                    }

                    var values = MessageForms.ShowDialog($"Enter value for {title}", fields);

                    if (!values.Any())
                    {
                        return null;
                    }

                    if (values.Count > 1)
                    {
                        value = string.Join("; ", values.Select(v => v.Value));
                    }
                    else
                    {
                        value = values.First().Value.ToString();
                    }
                }
            }
            else
            {
                var dropDownValues = new List<string>();
                foreach (var enumValue in Enum.GetValues(action.EnumType))
                {
                    var description = Utils.GetDescription(action.EnumType, enumValue as IConvertible) ?? enumValue.ToString().Replace("_", "");
                    dropDownValues.Add(description);
                }

                var values = MessageForms.ShowDialog("Choose value", new[] {
                    new MessageForms.FieldDefinition
                    {
                        Label = "Choose desired " + title,
                        FieldType = MessageForms.FieldType.DropDown,
                        Values = dropDownValues
                    }
                });

                if (!values.Any())
                {
                    return null;
                }

                value = values.First().Value.ToString();
                var enumName = Utils.GetEnumNameByDescription(action.EnumType, value);
                if (enumName != null)
                {
                    value = enumName;
                }
            }

            return value;
        }

        private void miLgAddNvPreset_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var preset = item.Tag as NvPreset;

            var text = $"NvPreset({preset.name})";

            FormUtils.AddStepToTextBox(edtStepsLg, text);
        }

        private void miLgAddAmdPreset_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var preset = item.Tag as AmdPreset;

            var text = $"AmdPreset({preset.name})";

            FormUtils.AddStepToTextBox(edtStepsLg, text);
        }

        private void clbLgPower_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (!_initialized || _disableEvents)
            {
                return;
            }

            var device = _lgService?.SelectedDevice;
            if (device == null)
            {
                return;
            }

            if (e.Index is 0 or 1 or 4 or 7 && !(device.PowerOnAfterResume || device.PowerOnAfterStartup || device.PowerOnAfterScreenSaver || device.PowerOnByWindows))
            {
                MessageForms.InfoOk(
@"Be sure to activate the following setting on the TV, or the app will not be able to wake the TV:

Connection > Mobile TV On > Turn on via Wi-Fi (Networked Standby Mode)

See Options to test this functionality.
You can also activate this option by using the Expert-button and selecting Wake-On-LAN > Enabled."
                );
            }

            BeginInvoke(() =>
            {
                device.PowerOnAfterStartup = clbLgPower.GetItemChecked(0);
                device.PowerOnAfterResume = clbLgPower.GetItemChecked(1);
                device.PowerOffOnShutdown = clbLgPower.GetItemChecked(2);
                device.PowerOffOnStandby = clbLgPower.GetItemChecked(3);
                device.PowerOffOnScreenSaver = clbLgPower.GetItemChecked(4);
                device.PowerOnAfterScreenSaver = clbLgPower.GetItemChecked(5);
                device.PowerOnAfterManualPowerOff = clbLgPower.GetItemChecked(6);
                device.TriggersEnabled = clbLgPower.GetItemChecked(7);
                device.PowerOffByWindows = clbLgPower.GetItemChecked(8);
                device.PowerOnByWindows = clbLgPower.GetItemChecked(9);
                device.UseSecureConnection = clbLgPower.GetItemChecked(10);

                _lgService.InstallEventHandlers();

                if (e.Index == 10)
                {
                    _lgService.RefreshDevices().ContinueWith((_) => BeginInvoke(() => FillLgDevices()));
                }
            });
        }

        private void edtLgPowerOnAfterResumeDelay_ValueChanged(object sender, EventArgs e)
        {
            _lgService.Config.PowerOnRetries = (int)edtLgMaxPowerOnRetries.Value;
        }

        private void chkFixChromeFonts_CheckedChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                _config.FixChromeFonts = chkFixChromeFonts.Checked;
                if (chkFixChromeFonts.Checked)
                {
                    Utils.ExecuteElevated(StartUpParams.ActivateChromeFontFixParam);
                }
                else
                {
                    Utils.ExecuteElevated(StartUpParams.DeactivateChromeFontFixParam);
                }
            }
        }

        private void btnLGTestPower_Click(object sender, EventArgs e)
        {
            var text =
@"The TV will now power off. Please wait for the TV to be powered off completely (relay click) and press ENTER to wake it again.
For waking up to work, you need to activate the following setting on the TV:

Connection > Mobile TV On > Turn on via Wi-Fi

It will also work over a wired connection.
You can also activate this option by using the Expert-button and selecting Wake-On-LAN > Enabled.

Do you want to continue?";

            if (MessageForms.QuestionYesNo(text) == DialogResult.Yes)
            {
                Utils.WaitForTask(_lgService.PowerOff());

                MessageForms.InfoOk("Press ENTER to wake the TV.");

                _lgService.WakeSelectedDevice();
            }
        }

        private void btnSetShortcutScreenSaver_Click(object sender, EventArgs e)
        {
            var shortcut = edtBlankScreenSaverShortcut.Text.Trim();

            if (!Utils.ValidateShortcut(shortcut))
            {
                return;
            }

            var oldShortcut = _config.ScreenSaverShortcut;

            var clear = !string.IsNullOrEmpty(oldShortcut);

            _config.ScreenSaverShortcut = shortcut;

            Utils.RegisterShortcut(Handle, SHORTCUTID_SCREENSAVER, shortcut, clear);
        }

        private void chkMinimizeOnClose_CheckedChanged(object sender, EventArgs e)
        {
            _config.MinimizeOnClose = chkMinimizeOnClose.Checked;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (tcMain.SelectedTab == tabNVIDIA)
            {
                _nvPanel?.UpdateInfo();
            }
            else if (tcMain.SelectedTab == tabAMD)
            {
                _amdPanel?.UpdateInfo();
            }
            else if (tcMain.SelectedTab == tabLog)
            {
                LoadLog();
            }
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            var logType = cbxLogType.SelectedIndex;

            if (logType == -1)
            {
                return;
            }

            if (logType == 0)
            {
                var filename = Program.LogFilename;
                if (File.Exists(filename))
                {
                    File.Delete(filename);
                }
            }
            else
            {
                PipeUtils.SendMessage(SvcMessageType.ClearLog);
            }
            edtLog.Clear();
        }

        private void edtLgDeviceFilter_TextChanged(object sender, EventArgs e)
        {
            if (_lgService != null)
            {
                _lgService.Config.DeviceSearchKey = edtLgDeviceFilter.Text;
            }
        }

        private void btnLgDeviceFilterRefresh_Click(object sender, EventArgs e)
        {
            RefreshLgDevices();
        }

        private void RefreshLgDevices()
        {
            _lgService.RefreshDevices(false).ContinueWith((task) => BeginInvoke(() => FillLgDevices()));
        }

        private void FillGradient()
        {
            if (pbGradient.Image == null)
            {
                pbGradient.Image = Utils.GenerateGradientBitmap(pbGradient.Width, pbGradient.Height);
            }
        }

        private void ApplyDitheringOptions()
        {
            if (_updatingDitherSettings)
            {
                return;
            }

            var state = chkDitheringEnabled.CheckState switch { CheckState.Checked => NvDitherState.Enabled, CheckState.Unchecked => NvDitherState.Disabled, _ => NvDitherState.Auto };
            var bitDepth = cbxDitheringBitDepth.SelectedIndex;
            var mode = cbxDitheringMode.SelectedIndex;
            var display = ((NvDisplayInfo)cbxDitheringDisplay.SelectedItem)?.Display;

            if (_nvService.SetDithering(state, (uint)bitDepth, (uint)(mode > -1 ? mode : (int)NvDitherMode.Temporal), currentDisplay: display) && state == NvDitherState.Auto)
            {
                UpdateDitherSettings();
            }
        }

        private void cbxDitheringBitDepth_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyDitheringOptions();
        }

        private void cbxDitheringMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyDitheringOptions();
        }

        private void AfterInitialized()
        {
            _nvPanel?.AfterInitialized();
            _amdPanel?.AfterInitialized();
            if (_trayIcon.Visible)
            {
                CheckForUpdates();
            }
        }

        private void CheckForUpdates()
        {
            if (!_config.CheckForUpdates || _checkedForUpdates || Debugger.IsAttached)
            {
                return;
            }

            _checkedForUpdates = true;

            var _ = Utils.GetRestJsonAsync("https://api.github.com/repos/maassoft/colorcontrol/releases/latest", InitHandleCheckForUpdates);
        }

        private void InitHandleCheckForUpdates(dynamic latest)
        {
            BeginInvoke(() => HandleCheckForUpdates(latest));
        }

        private void HandleCheckForUpdates(dynamic latest)
        {
            if (latest?.tag_name == null)
            {
                return;
            }

            var currentVersion = Application.ProductVersion;

            var newVersion = latest.tag_name.Value.Substring(1);
            if (newVersion.CompareTo(currentVersion) > 0)
            {
                _updateHtmlUrl = latest.html_url.Value;

                if (latest.assets != null && Utils.IsServiceRunning())
                {
                    var asset = latest.assets[0];
                    _downloadUrl = asset.browser_download_url.Value;

                    if (_config.AutoInstallUpdates)
                    {
                        InstallUpdate(_downloadUrl);

                        return;
                    }

                    btnUpdate.Visible = true;

                    if (_trayIcon.Visible)
                    {
                        _trayIcon.ShowBalloonTip(5000, "Update available", $"Version {newVersion} is available. Click on the Update-button to update", ToolTipIcon.Info);
                    }
                    else
                    {
                        MessageForms.InfoOk($"New version {newVersion} is available. Click on the Update-button to update", "Update available", $"https://github.com/Maassoft/ColorControl/releases/tag/v{newVersion}");
                    }

                    return;
                }

                if (_trayIcon.Visible)
                {
                    _trayIcon.ShowBalloonTip(5000, "Update available", $"Version {newVersion} is available. Click to open the GitHub page", ToolTipIcon.Info);
                }
                else
                {
                    MessageForms.InfoOk($"New version {newVersion} is available. Click on the Help-button to open the GitHub page.", "Update available", $"https://github.com/Maassoft/ColorControl/releases/tag/v{newVersion}");
                }
            }
        }

        private void InstallUpdate(string downloadUrl)
        {
            var message = new SvcInstallUpdateMessage
            {
                DownloadUrl = downloadUrl,
                ClientPath = new FileInfo(Application.ExecutablePath).Directory.FullName
            };

            var result = PipeUtils.SendMessage(message, 10000);

            if (result != null && !result.Result)
            {
                MessageForms.ErrorOk($"Error while updating: {result.ErrorMessage}");

                return;
            }

            PipeUtils.SendMessage(SvcMessageType.RestartAfterUpdate);

            if (MessageForms.QuestionYesNo("Update installed successfully. Do you want to restart the application?") == DialogResult.Yes)
            {
                Program.Restart();
            }
            else
            {
                _downloadUrl = null;
                btnUpdate.Visible = true;
            }
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            GlobalSave();
        }

        private bool ShortCutExists(string shortcut, int presetId = 0)
        {
            return
                (_nvService?.GetPresets().Any(x => x.id != presetId && shortcut.Equals(x.shortcut)) ?? false) ||
                (_amdService?.GetPresets().Any(x => x.id != presetId && shortcut.Equals(x.shortcut)) ?? false) ||
                (_lgService?.GetPresets().Any(x => x.id != presetId && shortcut.Equals(x.shortcut)) ?? false);
        }

        private void edtShortcutLg_TextChanged(object sender, EventArgs e)
        {
            var text = edtShortcutLg.Text;

            var preset = GetSelectedLgPreset();

            if (preset == null || string.IsNullOrEmpty(text))
            {
                edtShortcutLg.ForeColor = SystemColors.WindowText;
            }
            else
            {
                edtShortcutLg.ForeColor = ShortCutExists(text, preset.id) ? Color.Red : SystemColors.WindowText;
            }
        }

        private void chkMinimizeToSystemTray_CheckedChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                _config.MinimizeToTray = chkMinimizeToSystemTray.Checked;
                _trayIcon.Visible = _config.MinimizeToTray;
            }
        }

        private void btnLgAddDevice_Click(object sender, EventArgs e)
        {
            var values = MessageForms.ShowDialog("Add tv", new[] { "Name", "Ip-address", "MAC-address" }, ValidateAddDevice);
            if (values.Any())
            {
                var device = new LgDevice(values[0].Value.ToString(), values[1].Value.ToString(), values[2].Value.ToString());

                var form = MessageForms.ShowProgress("Connecting to device...");

                var result = false;
                Enabled = false;
                try
                {
                    var task = device.TestConnection();

                    result = Utils.WaitForTask(task);
                }
                finally
                {
                    form.Close();
                    Enabled = true;
                }

                if (!result && MessageForms.QuestionYesNo("Unable to connect to the device. Are you sure you want to add it?") != DialogResult.Yes)
                {
                    return;
                }

                _lgService.AddCustomDevice(device);

                FillLgDevices();
            }
        }

        private string ValidateAddDevice(IEnumerable<MessageForms.FieldDefinition> values)
        {
            if (values.Any(v => string.IsNullOrEmpty(v.Value?.ToString())))
            {
                return "Please fill in all the fields";
            }

            return null;
        }

        private void btnLgRemoveDevice_Click(object sender, EventArgs e)
        {
            if (MessageForms.QuestionYesNo("Are you sure you want to remove this device?") != DialogResult.Yes)
            {
                return;
            }

            var device = _lgService.SelectedDevice;

            if (device != null)
            {
                _lgService.RemoveCustomDevice(device);

                FillLgDevices();
            }
        }

        private void mnuLgButtons_Opening(object sender, CancelEventArgs e)
        {
            mnuLgActions.DropDownItems.Clear();

            var preset = GetSelectedLgPreset();

            if (preset == null)
            {
                return;
            }

            var device = _lgService.GetPresetDevice(preset);

            BuildLgActionMenu(device, mnuLgActions.DropDownItems, mnuLgActions.Name, miLgAddAction_Click);
            FormUtils.BuildServicePresetsMenu(mnuLgNvPresets, _nvService, "NVIDIA", miLgAddNvPreset_Click);
            FormUtils.BuildServicePresetsMenu(mnuLgAmdPresets, _amdService, "AMD", miLgAddAmdPreset_Click);
        }

        private void btnLgDeviceConvertToCustom_Click(object sender, EventArgs e)
        {
            if (MessageForms.QuestionYesNo(
@"This will convert the automatically detected device to a custom variant.
This means that the device will remain here even if it is not detected anymore.
Do you want to continue?"
               ) != DialogResult.Yes)
            {
                return;
            }

            _lgService.SelectedDevice.ConvertToCustom();

            FillLgDevices();
        }

        private void chkLgRemoteControlShow_CheckedChanged(object sender, EventArgs e)
        {
            scLgController.Panel2Collapsed = !chkLgRemoteControlShow.Checked;
            _lgService.Config.ShowRemoteControl = chkLgRemoteControlShow.Checked;
        }

        private void mnuLgExpert_Opening(object sender, CancelEventArgs e)
        {
            var device = _lgService.SelectedDevice;

            var eligibleModels = new[] { "B9", "C9", "E9", "W9", "C2", "G2" };
            var eligibleModelsEnable = new[] { "B9", "C9", "E9", "W9" };

            var visible = eligibleModels.Any(m => device?.ModelName?.Contains(m) == true);
            var enableVisible = eligibleModelsEnable.Any(m => device?.ModelName?.Contains(m) == true);
            mnuLgOLEDMotionPro.Visible = visible;
            miLgEnableMotionPro.Visible = enableVisible;
            miLgExpertSeparator1.Visible = visible;

            BuildLgActionMenu(device, mnuLgExpert.Items, mnuLgExpert.Name, btnLgExpertColorGamut_Click, _lgService.Config.ShowAdvancedActions, true);
        }

        private void BuildLgActionMenu(LgDevice device, ToolStripItemCollection parent, string parentName, EventHandler clickEvent, bool showAdvanced = false, bool showGameBar = false)
        {
            if (device == null)
            {
                return;
            }

            var actions = device.GetInvokableActions(showAdvanced);
            var gameBarActions = device.GetInvokableActionsForGameBar();
            var activatedGameBarActions = device.GetActionsForGameBar();

            const string gameBarName = "miGameBar";

            var expertActions = actions.Where(a => a.EnumType != null || a.MaxValue > a.MinValue).ToList();

            var categories = expertActions.Select(a => a.Category ?? "misc").Where(c => !string.IsNullOrEmpty(c)).Distinct();

            foreach (var category in categories)
            {
                var catMenuItem = FormUtils.BuildDropDownMenuEx(parent, parentName, Utils.FirstCharUpperCase(category), null, null, category);

                foreach (var action in expertActions.Where(a => (a.Category ?? "misc") == category))
                {
                    if (!showGameBar)
                    {
                        var text = action.Title ?? action.Name;

                        var item = catMenuItem.DropDownItems.Add(text);
                        item.Tag = action;
                        item.Click += clickEvent;
                        continue;
                    }

                    var menu = FormUtils.BuildDropDownMenuEx(catMenuItem.DropDownItems, catMenuItem.Name, action.Title, action.EnumType, clickEvent, action, (int)action.MinValue, (int)action.MaxValue, action.NumberOfValues > 1);

                    if (!gameBarActions.Contains(action))
                    {
                        continue;
                    }

                    var itemName = $"{menu.Name}_{gameBarName}";
                    var gameBarItem = (ToolStripMenuItem)menu.DropDownItems.Find(itemName, false).FirstOrDefault();

                    if (gameBarItem == null)
                    {
                        var separator = new ToolStripSeparator();
                        menu.DropDownItems.Add(separator);

                        gameBarItem = (ToolStripMenuItem)menu.DropDownItems.Add("Show in Game Bar", null, miLgGameBarToggle_Click);
                        gameBarItem.CheckOnClick = true;
                        gameBarItem.Checked = activatedGameBarActions.Contains(action);
                        gameBarItem.Name = itemName;
                        gameBarItem.Tag = action.Name;
                    }
                }
            }

            if (!showAdvanced)
            {
                return;
            }

            var presetActions = actions.Where(a => a.Preset != null);

            if (presetActions.Any() && parent.Find("miLgExpertActionsSeparator", false).Length == 0)
            {
                parent.Add(new ToolStripSeparator
                {
                    Name = "miLgExpertActionsSeparator"
                });
            }

            foreach (var presetAction in presetActions)
            {
                var menu = FormUtils.BuildDropDownMenuEx(parent, parentName, presetAction.Name, null, btnLgExpertPresetAction_Click, presetAction.Preset);
            }
        }

        private void miLgGameBarToggle_Click(object sender, EventArgs e)
        {
            var device = _lgService.SelectedDevice;

            if (device == null)
            {
                return;
            }

            var item = sender as ToolStripMenuItem;
            if (item.Checked)
            {
                device.AddGameBarAction((string)item.Tag);
            }
            else
            {
                device.RemoveGameBarAction((string)item.Tag);
            }
        }

        private void btnLgExpert_Click(object sender, EventArgs e)
        {
            mnuLgExpert.Show(btnLgExpert, btnLgExpert.PointToClient(Cursor.Position));
        }

        private void btnLgExpertColorGamut_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var action = item.Tag as LgDevice.InvokableAction;
            var value = item.AccessibleName ?? item.Text;

            if (action.NumberOfValues > 1)
            {
                ApplyLgExpertValueRange(action);
                return;
            }

            try
            {
                _lgService.SelectedDevice?.ExecuteAction(action, new[] { value });
            }
            catch (InvalidOperationException ex)
            {
                Logger.Error(ex);

                MessageForms.ErrorOk("Error exectuting action: " + ex.Message);
            }
        }

        private void ApplyLgExpertValueRange(LgDevice.InvokableAction action)
        {
            var value = ShowLgActionForm(action);

            if (value == null)
            {
                return;
            }

            var values = value.Split(";");

            _lgService.SelectedDevice?.ExecuteAction(action, values);
        }

        private void btnLgExpertPresetAction_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var preset = (LgPreset)item.Tag;

            _lgService.ApplyPreset(preset).ConfigureAwait(false);
        }

        private void miLgEnableMotionPro_Click(object sender, EventArgs e)
        {
            if (MessageForms.QuestionYesNo("Are you sure you want to enable OLED Motion Pro? This app and its creator are in no way accountable for any damages it may cause to your tv.") == DialogResult.Yes)
            {
                _lgService.SelectedDevice?.SetOLEDMotionPro("OLED Motion Pro");

                MessageForms.InfoOk("Setting applied.");
            }
        }

        private void miLgDisableMotionPro_Click(object sender, EventArgs e)
        {
            _lgService.SelectedDevice?.SetOLEDMotionPro("OLED Motion");

            MessageForms.InfoOk("Setting applied.");
        }

        private void cbxLgApps_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ((char)Keys.Back))
            {
                cbxLgApps.SelectedIndex = -1;
            }
        }

        private void btnLgPresetEditTriggerConditions_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedLgPreset();

            if (preset == null)
            {
                return;
            }

            var dropDownValues = Utils.GetDescriptions<PresetConditionType>(fromValue: 1);

            var values = MessageForms.ShowDialog("Set trigger conditions", new[] {
                    new MessageForms.FieldDefinition
                    {
                        Label = "Set desired trigger conditions",
                        FieldType = MessageForms.FieldType.Flags,
                        Values = dropDownValues,
                        Value = edtLgPresetTriggerConditions.Tag ?? 0
                    }
                });

            if (!values.Any())
            {
                return;
            }

            var value = (PresetConditionType)values.First().Value;
            edtLgPresetTriggerConditions.Tag = (PresetConditionType)values.First().Value;
            edtLgPresetTriggerConditions.Text = Utils.GetDescriptions<PresetConditionType>((int)value).Join(", ");
        }

        private void chkCheckForUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                _config.CheckForUpdates = chkCheckForUpdates.Checked;
                chkAutoInstallUpdates.Enabled = _config.CheckForUpdates && _config.ElevationMethod == ElevationMethod.UseService;
            }
        }

        private void chkLgShowAdvancedActions_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }

            if (chkLgShowAdvancedActions.Checked)
            {
                if (MessageForms.QuestionYesNo(
@"Are you sure you want to enable the advanced actions under the Expert-button?
These actions include:
- InStart service menu
- EzAdjust service menu
- Software Update-app with firmware downgrade functionality enabled

These features may cause irreversible damage to your tv and will void your warranty.
This app and its creator are in no way accountable for any damages it may cause to your tv."
                ) != DialogResult.Yes)
                {
                    chkLgShowAdvancedActions.Checked = false;
                    return;
                }
                MessageForms.InfoOk(
@"Advanced actions activated.
The InStart and Software Update items are now visible under the Expert-button."
                );
            }

            _lgService.Config.ShowAdvancedActions = chkLgShowAdvancedActions.Checked;
        }

        private void ToggleGameBar()
        {
            if (_gameBarForm == null || !_gameBarForm.Visible)
            {
                if (_gameBarForm == null || _gameBarForm.IsDisposed)
                {
                    if (_lgService?.SelectedDevice == null)
                    {
                        return;
                    }

                    _gameBarForm = new LgGameBar(_lgService);
                }

                _gameBarForm.Show();
                _gameBarForm.Activate();
            }
            else
            {
                _gameBarForm?.Hide();
            }
        }

        private void btnLgGameBar_Click(object sender, EventArgs e)
        {
            ToggleGameBar();
        }

        private void edtLgGameBarShortcut_KeyDown(object sender, KeyEventArgs e)
        {
            ((TextBox)sender).Text = Utils.FormatKeyboardShortcut(e);
        }

        private void edtLgGameBarShortcut_KeyUp(object sender, KeyEventArgs e)
        {
            Utils.HandleKeyboardShortcutUp(e);
        }

        private void edtLgGameBarShortcut_TextChanged(object sender, EventArgs e)
        {
            var text = edtLgGameBarShortcut.Text;

            var blnOk = string.IsNullOrEmpty(text) || !ShortCutExists(text);
            edtLgGameBarShortcut.ForeColor = blnOk ? Color.Red : SystemColors.WindowText;

            if (blnOk)
            {
                _lgService.Config.GameBarShortcut = text;

                if (string.IsNullOrEmpty(text))
                {
                    WinApi.UnregisterHotKey(Handle, SHORTCUTID_GAMEBAR);
                }
                else
                {
                    Utils.RegisterShortcut(Handle, SHORTCUTID_GAMEBAR, text);
                }
            }
        }

        private void chkGdiScaling_CheckedChanged(object sender, EventArgs e)
        {
            _config.UseGdiScaling = chkGdiScaling.Checked;
        }

        private void MainForm_ResizeBegin(object sender, EventArgs e)
        {
            SuspendLayout();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e)
        {
            ResumeLayout(true);
        }

        private void chkDitheringEnabled_CheckStateChanged(object sender, EventArgs e)
        {
            cbxDitheringBitDepth.Enabled = chkDitheringEnabled.CheckState == CheckState.Checked;
            cbxDitheringMode.Enabled = chkDitheringEnabled.CheckState == CheckState.Checked;

            ApplyDitheringOptions();
        }

        private void btnLgDeviceOptionsHelp_Click(object sender, EventArgs e)
        {
            MessageForms.InfoOk(
@"Notes:
- power on after startup requires ""Automatically start after login"" - see Options
- power on after resume from standby may need some retries for waking TV - see Options
- power off on shutdown: because this app cannot detect a restart, restarting could also trigger this. Hold down Ctrl on restart to prevent power off.
- Use Windows power settings: powering on/off of TV will follow Windows settings. If activated, it's better to disable all other power options except power off on shutdown.
");
        }

        private void edtLgOptionShutdownDelay_ValueChanged(object sender, EventArgs e)
        {
            _lgService.Config.ShutdownDelay = (int)edtLgOptionShutdownDelay.Value;
        }

        private void cbxLgPcHdmiPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_lgService?.SelectedDevice == null)
            {
                return;
            }

            _lgService.SelectedDevice.HDMIPortNumber = cbxLgPcHdmiPort.SelectedIndex;
        }

        private void lvLgPresets_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            FormUtils.ListViewSort(sender, e);
        }

        private void mnuLgProgram_Click(object sender, EventArgs e)
        {
            var file = Utils.SelectFile();

            if (file != null)
            {
                FormUtils.AddStepToTextBox(edtStepsLg, $"StartProgram({file.FullName})");
            }
        }

        private void lvGamePresets_SelectedIndexChanged(object sender, EventArgs _)
        {
            var preset = GetSelectedGamePreset();
            var enabled = preset != null;

            FormUtils.EnableControls(tabGameLauncher, enabled, new List<Control> { lvGamePresets, btnGameAdd });

            if (preset != null)
            {
                edtGameName.Text = preset.name;
                edtGamePath.Text = preset.Path;
                edtGameParameters.Text = preset.Parameters;
                chkGameRunAsAdmin.Checked = preset.RunAsAdministrator;
                chkGameQuickAccess.Checked = preset.ShowInQuickAccess;
                ShowGameSteps();
            }
            else
            {
                edtGameName.Text = string.Empty;
                edtGamePath.Text = string.Empty;
                edtGameParameters.Text = string.Empty;
                chkGameRunAsAdmin.Checked = false;
                chkGameQuickAccess.Checked = false;
                edtGamePrelaunchSteps.Text = string.Empty;
            }
        }

        private void lvGamePresets_DoubleClick(object sender, EventArgs e)
        {
            ApplySelectedGamePreset();
        }

        private void btnGameLaunch_Click(object sender, EventArgs e)
        {
            ApplySelectedGamePreset();
        }

        private void btnGameClone_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedGamePreset();

            var newPreset = preset.Clone();

            AddOrUpdateItemGame(newPreset);
        }

        private void btnGameAdd_Click(object sender, EventArgs e)
        {
            var file = Utils.SelectFile();

            AddGamePreset(file);
        }

        private void AddGamePreset(FileInfo file)
        {
            var preset = _gameService.CreateNewPreset();

            if (file != null)
            {
                var versionInfo = FileVersionInfo.GetVersionInfo(file.FullName);

                preset.Path = file.FullName;

                var fileName = Path.GetFileNameWithoutExtension(preset.Path);

                preset.name = !string.IsNullOrEmpty(versionInfo.FileDescription) ? versionInfo.FileDescription :
                    !string.IsNullOrEmpty(versionInfo.ProductName) ? versionInfo.ProductName : fileName;
            }

            AddOrUpdateItemGame(preset);
        }

        private void btnGameSave_Click(object sender, EventArgs e)
        {
            SaveGamePreset();
        }

        private void SaveGamePreset()
        {
            var shortcut = string.Empty;
            if (!Utils.ValidateShortcut(shortcut))
            {
                return;
            }

            var preset = GetSelectedGamePreset();

            var name = edtGameName.Text.Trim();

            if (name.Length == 0 || _gameService.GetPresets().Any(x => x.id != preset.id && x.name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageForms.WarningOk("The name can not be empty and must be unique.");
                return;
            }

            preset.name = name;
            preset.Path = edtGamePath.Text;
            preset.Parameters = edtGameParameters.Text;
            preset.RunAsAdministrator = chkGameRunAsAdmin.Checked;
            preset.ShowInQuickAccess = chkGameQuickAccess.Checked;

            var clear = !string.IsNullOrEmpty(preset.shortcut);

            var shortcutChanged = !shortcut.Equals(preset.shortcut);
            if (shortcutChanged)
            {
                preset.shortcut = shortcut;
            }

            var text = edtGamePrelaunchSteps.Text;

            var stepsList = (GameStepType)cbxGameStepType.SelectedIndex switch
            {
                GameStepType.PreLaunch => preset.PreLaunchSteps,
                GameStepType.PostLaunch => preset.PostLaunchSteps,
                GameStepType.Finalize => preset.FinalizeSteps,
                _ => throw new InvalidOperationException("Invalid game step type")
            };

            Utils.ParseWords(stepsList, text);

            AddOrUpdateItemGame();

            if (shortcutChanged)
            {
                Utils.RegisterShortcut(Handle, preset.id, preset.shortcut, clear);
            }
        }

        private void btnGameBrowse_Click(object sender, EventArgs e)
        {
            var file = Utils.SelectFile();

            if (file == null)
            {
                return;
            }

            var preset = GetSelectedGamePreset();

            preset.Path = file.FullName;

            edtGamePath.Text = preset.Path;

            if (string.IsNullOrEmpty(preset.name) || preset.name.StartsWith("New preset", StringComparison.OrdinalIgnoreCase))
            {
                var fileName = Path.GetFileNameWithoutExtension(preset.Path);

                edtGameName.Text = fileName;
                preset.name = fileName;
            }

            AddOrUpdateItemGame();
        }

        private void btnGameDelete_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedGamePreset();

            if (preset == null)
            {
                return;
            }

            if (!string.IsNullOrEmpty(preset.shortcut))
            {
                WinApi.UnregisterHotKey(Handle, preset.id);
            }

            _gameService.GetPresets().Remove(preset);

            var item = lvGamePresets.SelectedItems[0];
            lvGamePresets.Items.Remove(item);
        }

        private void mnuGameAddStep_Opening(object sender, CancelEventArgs e)
        {
            FormUtils.BuildServicePresetsMenu(mnuGameNvidiaPresets, _nvService, "NVIDIA", miGameAddPreset_Click);
            FormUtils.BuildServicePresetsMenu(mnuGameAmdPresets, _amdService, "AMD", miGameAddPreset_Click);
            FormUtils.BuildServicePresetsMenu(mnuGameLgPresets, _lgService, "LG", miGameAddPreset_Click);
        }

        private void miGameAddPreset_Click(object sender, EventArgs e)
        {
            var item = sender as ToolStripItem;
            var preset = item.Tag as PresetBase;

            var text = $"{preset.GetType().Name}({preset.name})";

            FormUtils.AddStepToTextBox(edtGamePrelaunchSteps, text);
        }

        private void btnGameAddStep_Click(object sender, EventArgs e)
        {
            mnuGameAddStep.Show(btnGameAddStep, btnGameAddStep.PointToClient(Cursor.Position));
        }

        private void mnuGameStartProgram_Click(object sender, EventArgs e)
        {
            var file = Utils.SelectFile();

            if (file != null)
            {
                FormUtils.AddStepToTextBox(edtGamePrelaunchSteps, $"StartProgram({file.FullName})");
            }
        }

        private void lvGamePresets_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);
                var file = new FileInfo(files.First());

                AddGamePreset(file);
            }
        }

        private void lvGamePresets_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void btnGameActions_Click(object sender, EventArgs e)
        {
            mnuGameActions.Show(btnGameSettings, btnGameSettings.PointToClient(Cursor.Position));
        }

        private void mnuGameNvInspector_Click(object sender, EventArgs e)
        {
            _nvPanel?.StartNvProfileInspector();
        }

        private void miGameSetQuickAccessShortcut_Click(object sender, EventArgs e)
        {
            var shortcut = FormUtils.EditShortcut(_config.GameQuickAccessShortcut);

            if (shortcut == null)
            {
                return;
            }

            var clear = !string.IsNullOrEmpty(_config.GameQuickAccessShortcut);

            _config.GameQuickAccessShortcut = shortcut;

            Utils.RegisterShortcut(Handle, SHORTCUTID_GAMEQA, _config.GameQuickAccessShortcut, clear);
        }

        private void btnLgSettings_Click(object sender, EventArgs e)
        {
            var shortcut = FormUtils.EditShortcut(_config.LgQuickAccessShortcut, "Quick Access shortcut", "LG controller settings");

            if (shortcut == null)
            {
                return;
            }

            var clear = !string.IsNullOrEmpty(_config.LgQuickAccessShortcut);

            _config.LgQuickAccessShortcut = shortcut;

            Utils.RegisterShortcut(Handle, SHORTCUTID_LGQA, _config.LgQuickAccessShortcut, clear);
        }

        private void mnuGameActions_Opening(object sender, CancelEventArgs e)
        {
            mnuGameNvInspector.Visible = _nvService != null;
        }

        private void lvGamePresets_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            FormUtils.ListViewItemChecked<GamePreset>(lvGamePresets, e);
        }

        private void lvLgPresets_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            FormUtils.ListViewItemChecked<LgPreset>(lvLgPresets, e);
        }

        private void lvNvPresets_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var listView = sender as ListView;

            if (!listView.Focused)
            {
                return;
            }


            var point = listView.PointToClient(Cursor.Position);

            if (point.X >= 20)
            {
                return;
            }

            var listItem = listView.Items[e.Index];

            if (listItem.Tag == null)
            {
                MessageForms.WarningOk("Quick Access cannot be enabled for this item.");
                e.NewValue = e.CurrentValue;
            }

            if (e.NewValue == CheckState.Checked && string.IsNullOrEmpty(listItem.Text))
            {
                MessageForms.WarningOk("A name must be entered before enabling Quick Access.");
                e.NewValue = e.CurrentValue;
            }
        }

        private void btnAmdSettings_Click(object sender, EventArgs e)
        {
            var shortcut = FormUtils.EditShortcut(_config.AmdQuickAccessShortcut, "Quick Access shortcut", "AMD controller settings");

            if (shortcut == null)
            {
                return;
            }

            var clear = !string.IsNullOrEmpty(_config.AmdQuickAccessShortcut);

            _config.AmdQuickAccessShortcut = shortcut;

            Utils.RegisterShortcut(Handle, SHORTCUTID_AMDQA, _config.AmdQuickAccessShortcut, clear);
        }

        private void btnGameProcessAffinity_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedGamePreset();

            if (preset == null)
            {
                return;
            }

            var numberOfProcessors = Environment.ProcessorCount;

            var options = Enumerable.Range(0, numberOfProcessors).Select(i => $"CPU #{i}");

            var values = MessageForms.ShowDialog("Set processor affinity", new[] {
                    new MessageForms.FieldDefinition
                    {
                        Label = "Set desired processors which are allowed to run program",
                        FieldType = MessageForms.FieldType.Flags,
                        Values = options,
                        Value = preset.ProcessAffinityMask
                    }
                });

            if (!values.Any())
            {
                return;
            }

            var value = values.First().Value;

            preset.ProcessAffinityMask = (uint)(int)value;
        }

        private void btnGameOptions_Click(object sender, EventArgs e)
        {
            mnuGameOptions.Show(btnGameOptions, btnGameOptions.PointToClient(Cursor.Position));
        }

        private void miGameProcessPriority_Click(object sender, EventArgs e)
        {
            var preset = GetSelectedGamePreset();

            if (preset == null)
            {
                return;
            }

            var dropDownValues = Utils.GetDescriptions<GamePriorityClass>();

            var values = MessageForms.ShowDialog("Set process priority", new[] {
                    new MessageForms.FieldDefinition
                    {
                        Label = "Set desired process priority",
                        FieldType = MessageForms.FieldType.DropDown,
                        Values = dropDownValues,
                        Value = preset.ProcessPriorityClass > 0 ? ((GamePriorityClass)preset.ProcessPriorityClass).GetDescription() : GamePriorityClass.Normal.GetDescription()
                    }
                });

            if (!values.Any())
            {
                return;
            }

            var value = values.First().Value.ToString();
            var enumName = Utils.GetEnumNameByDescription(typeof(GamePriorityClass), value);
            if (enumName != null)
            {
                value = enumName;
            }

            var enumValue = Enum.Parse(typeof(GamePriorityClass), value);

            preset.ProcessPriorityClass = (uint)(int)enumValue;
        }

        private void rbElevationNone_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }


            if (sender is not RadioButton button || !button.Checked)
            {
                return;
            }

            SetElevationMethod((ElevationMethod)Utils.ParseInt((string)button.Tag));
        }

        private void SetElevationMethod(ElevationMethod elevationMethod)
        {
            _config.ElevationMethod = elevationMethod;

            Utils.UseDedicatedElevatedProcess = _config.ElevationMethod == ElevationMethod.UseElevatedProcess;

            var _ = _config.ElevationMethod switch
            {
                ElevationMethod.None => SetElevationMethodNone(),
                ElevationMethod.RunAsAdmin => SetElevationMethodRunAsAdmin(),
                ElevationMethod.UseService => SetElevationMethodUseService(),
                ElevationMethod.UseElevatedProcess => SetElevationMethodUseElevatedProcess(),
                _ => true
            };

            UpdateServiceInfo();
        }

        private bool SetElevationMethodNone()
        {
            if (chkStartAfterLogin.Enabled)
            {
                RegisterScheduledTask();
            }

            Utils.UninstallService();

            return true;
        }

        private bool SetElevationMethodRunAsAdmin()
        {
            if (chkStartAfterLogin.Enabled)
            {
                RegisterScheduledTask(false);
                RegisterScheduledTask();
            }

            Utils.UninstallService();

            return true;
        }

        private bool SetElevationMethodUseService()
        {
            Utils.InstallService();

            if (Utils.IsServiceInstalled())
            {
                MessageForms.InfoOk("Service installed successfully.");
                return true;
            }

            MessageForms.ErrorOk("Service could not be installed. Check the logs.");

            return false;
        }

        private bool SetElevationMethodUseElevatedProcess()
        {
            if (chkStartAfterLogin.Enabled)
            {
                RegisterScheduledTask();
            }

            Utils.UninstallService();

            return true;
        }

        private void RegisterScheduledTask(bool enabled = true)
        {
            Utils.RegisterTask(Program.TS_TASKNAME, enabled, _config.ElevationMethod == ElevationMethod.RunAsAdmin ? Microsoft.Win32.TaskScheduler.TaskRunLevel.Highest : Microsoft.Win32.TaskScheduler.TaskRunLevel.LUA);
        }

        private void btnElevationInfo_Click(object sender, EventArgs e)
        {
            MessageForms.InfoOk(Utils.ELEVATION_MSG + @$"

NOTE: if ColorControl itself already runs as administrator this is indicated in the title: ColorControl {Application.ProductVersion} (administrator).

Currently ColorControl is {(Utils.IsAdministrator() ? "" : "not ")}running as administrator.
");
        }

        private void btnStartStopService_Click(object sender, EventArgs e)
        {
            btnStartStopService.Enabled = false;
            try
            {
                var start = btnStartStopService.Text == "Start";

                if (start)
                {
                    Utils.StartService();
                }
                else
                {
                    Utils.StopService();
                }

                var wait = 1000;

                while (wait > 0)
                {
                    Utils.WaitForTask(Task.Delay(100));

                    if (start == Utils.IsServiceRunning())
                    {
                        break;
                    }

                    wait -= 100;
                }
            }
            finally
            {
                btnStartStopService.Enabled = true;
            }

            UpdateServiceInfo();
        }

        private void cbxLogType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadLog();
        }

        private void cbxGameStepType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGameSteps();
        }

        private void ShowGameSteps()
        {
            var preset = GetSelectedGamePreset();

            if (preset == null)
            {
                return;
            }

            switch ((GameStepType)cbxGameStepType.SelectedIndex)
            {
                case GameStepType.PreLaunch:
                    edtGamePrelaunchSteps.Text = string.Join(", ", preset.PreLaunchSteps);
                    break;
                case GameStepType.PostLaunch:
                    edtGamePrelaunchSteps.Text = string.Join(", ", preset.PostLaunchSteps);
                    break;
                case GameStepType.Finalize:
                    edtGamePrelaunchSteps.Text = string.Join(", ", preset.FinalizeSteps);
                    break;
            }
        }

        private void edtGamePrelaunchSteps_Leave(object sender, EventArgs e)
        {
            SaveGamePreset();
        }

        private void MainForm_Click(object sender, EventArgs e)
        {
            //PipeUtils.SendMessage(SvcMessageType.RestartAfterUpdate);
            //Program.Restart();
            //Environment.Exit(0);
            //InstallUpdate("");
        }

        private void chkAutoInstallUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if (_initialized)
            {
                _config.AutoInstallUpdates = chkAutoInstallUpdates.Checked;
            }
        }

        private void chkLgSetSelectedDeviceByWol_CheckedChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }

            _lgService.Config.SetSelectedDeviceByPowerOn = chkLgSetSelectedDeviceByPowerOn.Checked;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (_downloadUrl != null)
            {
                InstallUpdate(_downloadUrl);

                return;
            }

            Program.Restart();
        }

        internal void CloseForRestart()
        {
            Hide();
            _trayIcon.Visible = false;
        }

        private void cbxDitheringDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!_initialized)
            {
                return;
            }

            UpdateDitherSettings();
        }
    }
}