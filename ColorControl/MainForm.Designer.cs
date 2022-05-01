﻿namespace ColorControl
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabNVIDIA = new System.Windows.Forms.TabPage();
            this.lblNvPresetName = new System.Windows.Forms.Label();
            this.edtNvPresetName = new System.Windows.Forms.TextBox();
            this.btnAddModesNv = new System.Windows.Forms.Button();
            this.btnNvPresetDelete = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.btnClone = new System.Windows.Forms.Button();
            this.btnNvPresetSave = new System.Windows.Forms.Button();
            this.lblShortcut = new System.Windows.Forms.Label();
            this.edtShortcut = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.mnuNvPresets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miNvApply = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetApplyOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuNvDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPrimaryDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNvPresetsColorSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetColorSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
            this.miRefreshRateIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetDithering = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetApplyDithering = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvPresetDitheringEnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNvDitheringBitDepth = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvDithering6bit = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvDithering8bit = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvDithering10bit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNvDitheringMode = new System.Windows.Forms.ToolStripMenuItem();
            this.spatial1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatial2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatialDynamic2x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spatialStatic2x2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.temporalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvHDR = new System.Windows.Forms.ToolStripMenuItem();
            this.miHDRIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.miToggleHDR = new System.Windows.Forms.ToolStripMenuItem();
            this.miHDREnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.miNvCopyId = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApply = new System.Windows.Forms.Button();
            this.lvNvPresets = new System.Windows.Forms.ListView();
            this.tabAMD = new System.Windows.Forms.TabPage();
            this.lblAmdPresetName = new System.Windows.Forms.Label();
            this.edtAmdPresetName = new System.Windows.Forms.TextBox();
            this.btnAddAmd = new System.Windows.Forms.Button();
            this.lblErrorAMD = new System.Windows.Forms.Label();
            this.btnDeleteAmd = new System.Windows.Forms.Button();
            this.btnCloneAmd = new System.Windows.Forms.Button();
            this.btnAmdPresetSave = new System.Windows.Forms.Button();
            this.lblAmdShortcut = new System.Windows.Forms.Label();
            this.edtAmdShortcut = new System.Windows.Forms.TextBox();
            this.btnChangeAmd = new System.Windows.Forms.Button();
            this.mnuAmdPresets = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miAmdApply = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdPresetApplyOnStartup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAmdDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdPrimaryDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAmdColorSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdColorSettingsIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAmdRefreshRate = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdRefreshRateIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAmdDithering = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdDitheringIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAmdHDR = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdHDRIncluded = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdHDRToggle = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdHDREnabled = new System.Windows.Forms.ToolStripMenuItem();
            this.miAmdCopyId = new System.Windows.Forms.ToolStripMenuItem();
            this.btnApplyAmd = new System.Windows.Forms.Button();
            this.lvAmdPresets = new System.Windows.Forms.ListView();
            this.tabLG = new System.Windows.Forms.TabPage();
            this.scLgController = new System.Windows.Forms.SplitContainer();
            this.cbxLgPcHdmiPort = new System.Windows.Forms.ComboBox();
            this.lblLgPcHdmiPort = new System.Windows.Forms.Label();
            this.edtLgPresetDescription = new System.Windows.Forms.TextBox();
            this.lblLgPresetDescription = new System.Windows.Forms.Label();
            this.btnLgDeviceOptionsHelp = new System.Windows.Forms.Button();
            this.btnLgGameBar = new System.Windows.Forms.Button();
            this.btnLgPresetEditTriggerConditions = new System.Windows.Forms.Button();
            this.edtLgPresetTriggerConditions = new System.Windows.Forms.TextBox();
            this.lblLgPresetExcludedProcesses = new System.Windows.Forms.Label();
            this.edtLgPresetExcludedProcesses = new System.Windows.Forms.TextBox();
            this.lblLgPresetIncludedProcesses = new System.Windows.Forms.Label();
            this.edtLgPresetIncludedProcesses = new System.Windows.Forms.TextBox();
            this.lblLgPresetTriggerCondition = new System.Windows.Forms.Label();
            this.cbxLgPresetTrigger = new System.Windows.Forms.ComboBox();
            this.lblLgPresetTrigger = new System.Windows.Forms.Label();
            this.btnLgExpert = new System.Windows.Forms.Button();
            this.mnuLgExpert = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuLgOLEDMotionPro = new System.Windows.Forms.ToolStripMenuItem();
            this.miLgEnableMotionPro = new System.Windows.Forms.ToolStripMenuItem();
            this.miLgDisableMotionPro = new System.Windows.Forms.ToolStripMenuItem();
            this.miLgExpertSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.chkLgRemoteControlShow = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxLgDevices = new System.Windows.Forms.ComboBox();
            this.btnLgDeviceConvertToCustom = new System.Windows.Forms.Button();
            this.cbxLgApps = new System.Windows.Forms.ComboBox();
            this.lvLgPresets = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxLgPresetDevice = new System.Windows.Forms.ComboBox();
            this.btnDeleteLg = new System.Windows.Forms.Button();
            this.btnApplyLg = new System.Windows.Forms.Button();
            this.lblDeviceFilter = new System.Windows.Forms.Label();
            this.lblLgPresetDevice = new System.Windows.Forms.Label();
            this.btnAddLg = new System.Windows.Forms.Button();
            this.edtShortcutLg = new System.Windows.Forms.TextBox();
            this.edtLgDeviceFilter = new System.Windows.Forms.TextBox();
            this.btnLgRemoveDevice = new System.Windows.Forms.Button();
            this.btnLgRefreshApps = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLgAddDevice = new System.Windows.Forms.Button();
            this.edtNameLg = new System.Windows.Forms.TextBox();
            this.btnSetShortcutLg = new System.Windows.Forms.Button();
            this.edtStepsLg = new System.Windows.Forms.TextBox();
            this.btnLgAddButton = new System.Windows.Forms.Button();
            this.mnuLgButtons = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuLgRcButtons = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLgActions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLgNvPresets = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLgAmdPresets = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloneLg = new System.Windows.Forms.Button();
            this.lblStepsLg = new System.Windows.Forms.Label();
            this.btnLgDeviceFilterRefresh = new System.Windows.Forms.Button();
            this.clbLgPower = new System.Windows.Forms.CheckedListBox();
            this.lblLgError = new System.Windows.Forms.Label();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.grpNvidiaOptions = new System.Windows.Forms.GroupBox();
            this.lblDitheringMode = new System.Windows.Forms.Label();
            this.cbxDitheringMode = new System.Windows.Forms.ComboBox();
            this.lblDitheringBitDepth = new System.Windows.Forms.Label();
            this.cbxDitheringBitDepth = new System.Windows.Forms.ComboBox();
            this.chkDitheringEnabled = new System.Windows.Forms.CheckBox();
            this.pbGradient = new System.Windows.Forms.PictureBox();
            this.grpMiscellaneousOptions = new System.Windows.Forms.GroupBox();
            this.btnSetShortcutScreenSaver = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.edtBlankScreenSaverShortcut = new System.Windows.Forms.TextBox();
            this.lblFixChromeFontsDescription = new System.Windows.Forms.Label();
            this.chkFixChromeFonts = new System.Windows.Forms.CheckBox();
            this.grpLGOptions = new System.Windows.Forms.GroupBox();
            this.lblGameBarShortcut = new System.Windows.Forms.Label();
            this.edtLgGameBarShortcut = new System.Windows.Forms.TextBox();
            this.lblLgOptionShutdownDelayHelp = new System.Windows.Forms.Label();
            this.edtLgOptionShutdownDelay = new System.Windows.Forms.NumericUpDown();
            this.lblLgOptionShutdownDelay = new System.Windows.Forms.Label();
            this.chkLgShowAdvancedActions = new System.Windows.Forms.CheckBox();
            this.btnLGTestPower = new System.Windows.Forms.Button();
            this.lblLgMaxPowerOnRetriesDescription = new System.Windows.Forms.Label();
            this.edtLgMaxPowerOnRetries = new System.Windows.Forms.NumericUpDown();
            this.lblLgMaxPowerOnRetries = new System.Windows.Forms.Label();
            this.grpHDROptions = new System.Windows.Forms.GroupBox();
            this.edtDelayDisplaySettings = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.grpGeneralOptions = new System.Windows.Forms.GroupBox();
            this.chkGdiScaling = new System.Windows.Forms.CheckBox();
            this.chkCheckForUpdates = new System.Windows.Forms.CheckBox();
            this.chkMinimizeToSystemTray = new System.Windows.Forms.CheckBox();
            this.chkMinimizeOnClose = new System.Windows.Forms.CheckBox();
            this.chkStartMinimized = new System.Windows.Forms.CheckBox();
            this.chkStartAfterLogin = new System.Windows.Forms.CheckBox();
            this.tabLog = new System.Windows.Forms.TabPage();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.edtLog = new System.Windows.Forms.TextBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.grpNVIDIAInfo = new System.Windows.Forms.GroupBox();
            this.btnRefreshNVIDIAInfo = new System.Windows.Forms.Button();
            this.tvNVIDIAInfo = new System.Windows.Forms.TreeView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbPlugins = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tcMain.SuspendLayout();
            this.tabNVIDIA.SuspendLayout();
            this.mnuNvPresets.SuspendLayout();
            this.tabAMD.SuspendLayout();
            this.mnuAmdPresets.SuspendLayout();
            this.tabLG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLgController)).BeginInit();
            this.scLgController.Panel1.SuspendLayout();
            this.scLgController.SuspendLayout();
            this.mnuLgExpert.SuspendLayout();
            this.mnuLgButtons.SuspendLayout();
            this.tabOptions.SuspendLayout();
            this.grpNvidiaOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGradient)).BeginInit();
            this.grpMiscellaneousOptions.SuspendLayout();
            this.grpLGOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtLgOptionShutdownDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLgMaxPowerOnRetries)).BeginInit();
            this.grpHDROptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDelayDisplaySettings)).BeginInit();
            this.grpGeneralOptions.SuspendLayout();
            this.tabLog.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.grpNVIDIAInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcMain
            // 
            this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMain.Controls.Add(this.tabNVIDIA);
            this.tcMain.Controls.Add(this.tabAMD);
            this.tcMain.Controls.Add(this.tabLG);
            this.tcMain.Controls.Add(this.tabOptions);
            this.tcMain.Controls.Add(this.tabLog);
            this.tcMain.Controls.Add(this.tabInfo);
            this.tcMain.Location = new System.Drawing.Point(14, 14);
            this.tcMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(1122, 553);
            this.tcMain.TabIndex = 1;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabNVIDIA
            // 
            this.tabNVIDIA.Controls.Add(this.lblNvPresetName);
            this.tabNVIDIA.Controls.Add(this.edtNvPresetName);
            this.tabNVIDIA.Controls.Add(this.btnAddModesNv);
            this.tabNVIDIA.Controls.Add(this.btnNvPresetDelete);
            this.tabNVIDIA.Controls.Add(this.lblError);
            this.tabNVIDIA.Controls.Add(this.btnClone);
            this.tabNVIDIA.Controls.Add(this.btnNvPresetSave);
            this.tabNVIDIA.Controls.Add(this.lblShortcut);
            this.tabNVIDIA.Controls.Add(this.edtShortcut);
            this.tabNVIDIA.Controls.Add(this.btnChange);
            this.tabNVIDIA.Controls.Add(this.btnApply);
            this.tabNVIDIA.Controls.Add(this.lvNvPresets);
            this.tabNVIDIA.Location = new System.Drawing.Point(4, 24);
            this.tabNVIDIA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabNVIDIA.Name = "tabNVIDIA";
            this.tabNVIDIA.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabNVIDIA.Size = new System.Drawing.Size(1114, 525);
            this.tabNVIDIA.TabIndex = 0;
            this.tabNVIDIA.Text = "NVIDIA controller";
            this.tabNVIDIA.UseVisualStyleBackColor = true;
            // 
            // lblNvPresetName
            // 
            this.lblNvPresetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblNvPresetName.AutoSize = true;
            this.lblNvPresetName.Location = new System.Drawing.Point(7, 466);
            this.lblNvPresetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNvPresetName.Name = "lblNvPresetName";
            this.lblNvPresetName.Size = new System.Drawing.Size(42, 15);
            this.lblNvPresetName.TabIndex = 22;
            this.lblNvPresetName.Text = "Name:";
            // 
            // edtNvPresetName
            // 
            this.edtNvPresetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtNvPresetName.Enabled = false;
            this.edtNvPresetName.Location = new System.Drawing.Point(102, 463);
            this.edtNvPresetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtNvPresetName.Name = "edtNvPresetName";
            this.edtNvPresetName.Size = new System.Drawing.Size(233, 23);
            this.edtNvPresetName.TabIndex = 21;
            // 
            // btnAddModesNv
            // 
            this.btnAddModesNv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddModesNv.Location = new System.Drawing.Point(385, 429);
            this.btnAddModesNv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddModesNv.Name = "btnAddModesNv";
            this.btnAddModesNv.Size = new System.Drawing.Size(88, 27);
            this.btnAddModesNv.TabIndex = 9;
            this.btnAddModesNv.Text = "Add modes";
            this.btnAddModesNv.UseVisualStyleBackColor = true;
            this.btnAddModesNv.Click += new System.EventHandler(this.btnAddModesNv_Click);
            // 
            // btnNvPresetDelete
            // 
            this.btnNvPresetDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNvPresetDelete.Enabled = false;
            this.btnNvPresetDelete.Location = new System.Drawing.Point(290, 429);
            this.btnNvPresetDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNvPresetDelete.Name = "btnNvPresetDelete";
            this.btnNvPresetDelete.Size = new System.Drawing.Size(88, 27);
            this.btnNvPresetDelete.TabIndex = 8;
            this.btnNvPresetDelete.Text = "Delete";
            this.btnNvPresetDelete.UseVisualStyleBackColor = true;
            this.btnNvPresetDelete.Click += new System.EventHandler(this.btnNvPresetDelete_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(7, 7);
            this.lblError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(53, 15);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "ErrorText";
            this.lblError.Visible = false;
            // 
            // btnClone
            // 
            this.btnClone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnClone.Enabled = false;
            this.btnClone.Location = new System.Drawing.Point(196, 429);
            this.btnClone.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(88, 27);
            this.btnClone.TabIndex = 6;
            this.btnClone.Text = "Clone";
            this.btnClone.UseVisualStyleBackColor = true;
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // btnNvPresetSave
            // 
            this.btnNvPresetSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNvPresetSave.Enabled = false;
            this.btnNvPresetSave.Location = new System.Drawing.Point(479, 429);
            this.btnNvPresetSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNvPresetSave.Name = "btnNvPresetSave";
            this.btnNvPresetSave.Size = new System.Drawing.Size(88, 27);
            this.btnNvPresetSave.TabIndex = 5;
            this.btnNvPresetSave.Text = "Save";
            this.btnNvPresetSave.UseVisualStyleBackColor = true;
            this.btnNvPresetSave.Click += new System.EventHandler(this.btnSetShortcut_Click);
            // 
            // lblShortcut
            // 
            this.lblShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblShortcut.AutoSize = true;
            this.lblShortcut.Location = new System.Drawing.Point(7, 496);
            this.lblShortcut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblShortcut.Name = "lblShortcut";
            this.lblShortcut.Size = new System.Drawing.Size(55, 15);
            this.lblShortcut.TabIndex = 4;
            this.lblShortcut.Text = "Shortcut:";
            // 
            // edtShortcut
            // 
            this.edtShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtShortcut.Enabled = false;
            this.edtShortcut.Location = new System.Drawing.Point(102, 493);
            this.edtShortcut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtShortcut.Name = "edtShortcut";
            this.edtShortcut.ReadOnly = true;
            this.edtShortcut.Size = new System.Drawing.Size(233, 23);
            this.edtShortcut.TabIndex = 3;
            this.edtShortcut.TextChanged += new System.EventHandler(this.edtShortcut_TextChanged);
            this.edtShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyDown);
            this.edtShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyUp);
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChange.ContextMenuStrip = this.mnuNvPresets;
            this.btnChange.Enabled = false;
            this.btnChange.Location = new System.Drawing.Point(102, 429);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(88, 27);
            this.btnChange.TabIndex = 2;
            this.btnChange.Text = "Change...";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // mnuNvPresets
            // 
            this.mnuNvPresets.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuNvPresets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvApply,
            this.miNvPresetApplyOnStartup,
            this.toolStripSeparator1,
            this.mnuNvDisplay,
            this.mnuNvPresetsColorSettings,
            this.mnuRefreshRate,
            this.miNvPresetDithering,
            this.miNvHDR,
            this.miNvCopyId});
            this.mnuNvPresets.Name = "mnuNvPresets";
            this.mnuNvPresets.Size = new System.Drawing.Size(185, 186);
            this.mnuNvPresets.Opening += new System.ComponentModel.CancelEventHandler(this.mnuNvPresets_Opening);
            // 
            // miNvApply
            // 
            this.miNvApply.Name = "miNvApply";
            this.miNvApply.Size = new System.Drawing.Size(184, 22);
            this.miNvApply.Text = "Apply";
            this.miNvApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // miNvPresetApplyOnStartup
            // 
            this.miNvPresetApplyOnStartup.CheckOnClick = true;
            this.miNvPresetApplyOnStartup.Name = "miNvPresetApplyOnStartup";
            this.miNvPresetApplyOnStartup.Size = new System.Drawing.Size(184, 22);
            this.miNvPresetApplyOnStartup.Text = "Apply on startup";
            this.miNvPresetApplyOnStartup.Click += new System.EventHandler(this.miNvPresetApplyOnStartup_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuNvDisplay
            // 
            this.mnuNvDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvPrimaryDisplay});
            this.mnuNvDisplay.Name = "mnuNvDisplay";
            this.mnuNvDisplay.Size = new System.Drawing.Size(184, 22);
            this.mnuNvDisplay.Text = "Display";
            // 
            // miNvPrimaryDisplay
            // 
            this.miNvPrimaryDisplay.Name = "miNvPrimaryDisplay";
            this.miNvPrimaryDisplay.Size = new System.Drawing.Size(155, 22);
            this.miNvPrimaryDisplay.Text = "Primary display";
            this.miNvPrimaryDisplay.Click += new System.EventHandler(this.displayMenuItem_Click);
            // 
            // mnuNvPresetsColorSettings
            // 
            this.mnuNvPresetsColorSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvPresetColorSettings});
            this.mnuNvPresetsColorSettings.Name = "mnuNvPresetsColorSettings";
            this.mnuNvPresetsColorSettings.Size = new System.Drawing.Size(184, 22);
            this.mnuNvPresetsColorSettings.Text = "Color settings";
            // 
            // miNvPresetColorSettings
            // 
            this.miNvPresetColorSettings.Name = "miNvPresetColorSettings";
            this.miNvPresetColorSettings.Size = new System.Drawing.Size(120, 22);
            this.miNvPresetColorSettings.Text = "Included";
            this.miNvPresetColorSettings.Click += new System.EventHandler(this.miNvPresetColorSettings_Click);
            // 
            // mnuRefreshRate
            // 
            this.mnuRefreshRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRefreshRateIncluded});
            this.mnuRefreshRate.Name = "mnuRefreshRate";
            this.mnuRefreshRate.Size = new System.Drawing.Size(184, 22);
            this.mnuRefreshRate.Text = "Refresh Rate";
            // 
            // miRefreshRateIncluded
            // 
            this.miRefreshRateIncluded.Name = "miRefreshRateIncluded";
            this.miRefreshRateIncluded.Size = new System.Drawing.Size(120, 22);
            this.miRefreshRateIncluded.Text = "Included";
            this.miRefreshRateIncluded.Click += new System.EventHandler(this.includedToolStripMenuItem_Click);
            // 
            // miNvPresetDithering
            // 
            this.miNvPresetDithering.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvPresetApplyDithering,
            this.miNvPresetDitheringEnabled,
            this.mnuNvDitheringBitDepth,
            this.mnuNvDitheringMode});
            this.miNvPresetDithering.Name = "miNvPresetDithering";
            this.miNvPresetDithering.Size = new System.Drawing.Size(184, 22);
            this.miNvPresetDithering.Text = "Dithering";
            // 
            // miNvPresetApplyDithering
            // 
            this.miNvPresetApplyDithering.Name = "miNvPresetApplyDithering";
            this.miNvPresetApplyDithering.Size = new System.Drawing.Size(122, 22);
            this.miNvPresetApplyDithering.Text = "Included";
            this.miNvPresetApplyDithering.Click += new System.EventHandler(this.miNvPresetApplyDithering_Click);
            // 
            // miNvPresetDitheringEnabled
            // 
            this.miNvPresetDitheringEnabled.Name = "miNvPresetDitheringEnabled";
            this.miNvPresetDitheringEnabled.Size = new System.Drawing.Size(122, 22);
            this.miNvPresetDitheringEnabled.Text = "Enabled";
            this.miNvPresetDitheringEnabled.Click += new System.EventHandler(this.miNvPresetDitheringEnabled_Click);
            // 
            // mnuNvDitheringBitDepth
            // 
            this.mnuNvDitheringBitDepth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNvDithering6bit,
            this.miNvDithering8bit,
            this.miNvDithering10bit});
            this.mnuNvDitheringBitDepth.Name = "mnuNvDitheringBitDepth";
            this.mnuNvDitheringBitDepth.Size = new System.Drawing.Size(122, 22);
            this.mnuNvDitheringBitDepth.Text = "Bit depth";
            // 
            // miNvDithering6bit
            // 
            this.miNvDithering6bit.Name = "miNvDithering6bit";
            this.miNvDithering6bit.Size = new System.Drawing.Size(105, 22);
            this.miNvDithering6bit.Tag = "0";
            this.miNvDithering6bit.Text = "6-bit";
            this.miNvDithering6bit.Click += new System.EventHandler(this.miNvDithering6bit_Click);
            // 
            // miNvDithering8bit
            // 
            this.miNvDithering8bit.Name = "miNvDithering8bit";
            this.miNvDithering8bit.Size = new System.Drawing.Size(105, 22);
            this.miNvDithering8bit.Tag = "1";
            this.miNvDithering8bit.Text = "8-bit";
            this.miNvDithering8bit.Click += new System.EventHandler(this.miNvDithering6bit_Click);
            // 
            // miNvDithering10bit
            // 
            this.miNvDithering10bit.Name = "miNvDithering10bit";
            this.miNvDithering10bit.Size = new System.Drawing.Size(105, 22);
            this.miNvDithering10bit.Tag = "2";
            this.miNvDithering10bit.Text = "10-bit";
            this.miNvDithering10bit.Click += new System.EventHandler(this.miNvDithering6bit_Click);
            // 
            // mnuNvDitheringMode
            // 
            this.mnuNvDitheringMode.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spatial1ToolStripMenuItem,
            this.spatial2ToolStripMenuItem,
            this.spatialDynamic2x2ToolStripMenuItem,
            this.spatialStatic2x2ToolStripMenuItem,
            this.temporalToolStripMenuItem});
            this.mnuNvDitheringMode.Name = "mnuNvDitheringMode";
            this.mnuNvDitheringMode.Size = new System.Drawing.Size(122, 22);
            this.mnuNvDitheringMode.Text = "Mode";
            // 
            // spatial1ToolStripMenuItem
            // 
            this.spatial1ToolStripMenuItem.Name = "spatial1ToolStripMenuItem";
            this.spatial1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spatial1ToolStripMenuItem.Tag = "0";
            this.spatial1ToolStripMenuItem.Text = "Spatial Dynamic";
            this.spatial1ToolStripMenuItem.Click += new System.EventHandler(this.spatial1ToolStripMenuItem_Click);
            // 
            // spatial2ToolStripMenuItem
            // 
            this.spatial2ToolStripMenuItem.Name = "spatial2ToolStripMenuItem";
            this.spatial2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spatial2ToolStripMenuItem.Tag = "1";
            this.spatial2ToolStripMenuItem.Text = "Spatial Static";
            this.spatial2ToolStripMenuItem.Click += new System.EventHandler(this.spatial1ToolStripMenuItem_Click);
            // 
            // spatialDynamic2x2ToolStripMenuItem
            // 
            this.spatialDynamic2x2ToolStripMenuItem.Name = "spatialDynamic2x2ToolStripMenuItem";
            this.spatialDynamic2x2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spatialDynamic2x2ToolStripMenuItem.Tag = "2";
            this.spatialDynamic2x2ToolStripMenuItem.Text = "Spatial Dynamic 2x2";
            this.spatialDynamic2x2ToolStripMenuItem.Click += new System.EventHandler(this.spatial1ToolStripMenuItem_Click);
            // 
            // spatialStatic2x2ToolStripMenuItem
            // 
            this.spatialStatic2x2ToolStripMenuItem.Name = "spatialStatic2x2ToolStripMenuItem";
            this.spatialStatic2x2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.spatialStatic2x2ToolStripMenuItem.Tag = "3";
            this.spatialStatic2x2ToolStripMenuItem.Text = "Spatial Static 2x2";
            this.spatialStatic2x2ToolStripMenuItem.Click += new System.EventHandler(this.spatial1ToolStripMenuItem_Click);
            // 
            // temporalToolStripMenuItem
            // 
            this.temporalToolStripMenuItem.Name = "temporalToolStripMenuItem";
            this.temporalToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.temporalToolStripMenuItem.Tag = "4";
            this.temporalToolStripMenuItem.Text = "Temporal";
            this.temporalToolStripMenuItem.Click += new System.EventHandler(this.spatial1ToolStripMenuItem_Click);
            // 
            // miNvHDR
            // 
            this.miNvHDR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHDRIncluded,
            this.miToggleHDR,
            this.miHDREnabled});
            this.miNvHDR.Name = "miNvHDR";
            this.miNvHDR.Size = new System.Drawing.Size(184, 22);
            this.miNvHDR.Text = "HDR";
            // 
            // miHDRIncluded
            // 
            this.miHDRIncluded.Name = "miHDRIncluded";
            this.miHDRIncluded.Size = new System.Drawing.Size(136, 22);
            this.miHDRIncluded.Text = "Included";
            this.miHDRIncluded.Click += new System.EventHandler(this.miHDRIncluded_Click);
            // 
            // miToggleHDR
            // 
            this.miToggleHDR.Name = "miToggleHDR";
            this.miToggleHDR.Size = new System.Drawing.Size(136, 22);
            this.miToggleHDR.Text = "Toggle HDR";
            this.miToggleHDR.Click += new System.EventHandler(this.miToggleHDR_Click);
            // 
            // miHDREnabled
            // 
            this.miHDREnabled.Name = "miHDREnabled";
            this.miHDREnabled.Size = new System.Drawing.Size(136, 22);
            this.miHDREnabled.Text = "Enabled";
            this.miHDREnabled.Click += new System.EventHandler(this.miHDREnabled_Click);
            // 
            // miNvCopyId
            // 
            this.miNvCopyId.Name = "miNvCopyId";
            this.miNvCopyId.Size = new System.Drawing.Size(184, 22);
            this.miNvCopyId.Text = "Copy Id to Clipboard";
            this.miNvCopyId.Click += new System.EventHandler(this.miNvCopyId_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApply.Enabled = false;
            this.btnApply.Location = new System.Drawing.Point(7, 429);
            this.btnApply.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(88, 27);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lvNvPresets
            // 
            this.lvNvPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNvPresets.ContextMenuStrip = this.mnuNvPresets;
            this.lvNvPresets.FullRowSelect = true;
            this.lvNvPresets.Location = new System.Drawing.Point(7, 7);
            this.lvNvPresets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvNvPresets.MultiSelect = false;
            this.lvNvPresets.Name = "lvNvPresets";
            this.lvNvPresets.Size = new System.Drawing.Size(1098, 415);
            this.lvNvPresets.TabIndex = 0;
            this.lvNvPresets.UseCompatibleStateImageBehavior = false;
            this.lvNvPresets.View = System.Windows.Forms.View.Details;
            this.lvNvPresets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvLgPresets_ColumnClick);
            this.lvNvPresets.SelectedIndexChanged += new System.EventHandler(this.lvNvPresets_SelectedIndexChanged);
            this.lvNvPresets.DoubleClick += new System.EventHandler(this.btnApply_Click);
            // 
            // tabAMD
            // 
            this.tabAMD.Controls.Add(this.lblAmdPresetName);
            this.tabAMD.Controls.Add(this.edtAmdPresetName);
            this.tabAMD.Controls.Add(this.btnAddAmd);
            this.tabAMD.Controls.Add(this.lblErrorAMD);
            this.tabAMD.Controls.Add(this.btnDeleteAmd);
            this.tabAMD.Controls.Add(this.btnCloneAmd);
            this.tabAMD.Controls.Add(this.btnAmdPresetSave);
            this.tabAMD.Controls.Add(this.lblAmdShortcut);
            this.tabAMD.Controls.Add(this.edtAmdShortcut);
            this.tabAMD.Controls.Add(this.btnChangeAmd);
            this.tabAMD.Controls.Add(this.btnApplyAmd);
            this.tabAMD.Controls.Add(this.lvAmdPresets);
            this.tabAMD.Location = new System.Drawing.Point(4, 24);
            this.tabAMD.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabAMD.Name = "tabAMD";
            this.tabAMD.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabAMD.Size = new System.Drawing.Size(1114, 525);
            this.tabAMD.TabIndex = 5;
            this.tabAMD.Text = "AMD controller";
            this.tabAMD.UseVisualStyleBackColor = true;
            // 
            // lblAmdPresetName
            // 
            this.lblAmdPresetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmdPresetName.AutoSize = true;
            this.lblAmdPresetName.Location = new System.Drawing.Point(7, 466);
            this.lblAmdPresetName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmdPresetName.Name = "lblAmdPresetName";
            this.lblAmdPresetName.Size = new System.Drawing.Size(42, 15);
            this.lblAmdPresetName.TabIndex = 24;
            this.lblAmdPresetName.Text = "Name:";
            // 
            // edtAmdPresetName
            // 
            this.edtAmdPresetName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtAmdPresetName.Enabled = false;
            this.edtAmdPresetName.Location = new System.Drawing.Point(102, 463);
            this.edtAmdPresetName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtAmdPresetName.Name = "edtAmdPresetName";
            this.edtAmdPresetName.Size = new System.Drawing.Size(233, 23);
            this.edtAmdPresetName.TabIndex = 23;
            // 
            // btnAddAmd
            // 
            this.btnAddAmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddAmd.Location = new System.Drawing.Point(385, 429);
            this.btnAddAmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddAmd.Name = "btnAddAmd";
            this.btnAddAmd.Size = new System.Drawing.Size(88, 27);
            this.btnAddAmd.TabIndex = 18;
            this.btnAddAmd.Text = "Add";
            this.btnAddAmd.UseVisualStyleBackColor = true;
            this.btnAddAmd.Click += new System.EventHandler(this.btnAddAmd_Click);
            // 
            // lblErrorAMD
            // 
            this.lblErrorAMD.AutoSize = true;
            this.lblErrorAMD.Location = new System.Drawing.Point(7, 7);
            this.lblErrorAMD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErrorAMD.Name = "lblErrorAMD";
            this.lblErrorAMD.Size = new System.Drawing.Size(53, 15);
            this.lblErrorAMD.TabIndex = 8;
            this.lblErrorAMD.Text = "ErrorText";
            this.lblErrorAMD.Visible = false;
            // 
            // btnDeleteAmd
            // 
            this.btnDeleteAmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteAmd.Enabled = false;
            this.btnDeleteAmd.Location = new System.Drawing.Point(290, 429);
            this.btnDeleteAmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteAmd.Name = "btnDeleteAmd";
            this.btnDeleteAmd.Size = new System.Drawing.Size(88, 27);
            this.btnDeleteAmd.TabIndex = 17;
            this.btnDeleteAmd.Text = "Delete";
            this.btnDeleteAmd.UseVisualStyleBackColor = true;
            this.btnDeleteAmd.Click += new System.EventHandler(this.btnDeleteAmd_Click);
            // 
            // btnCloneAmd
            // 
            this.btnCloneAmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloneAmd.Enabled = false;
            this.btnCloneAmd.Location = new System.Drawing.Point(196, 429);
            this.btnCloneAmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloneAmd.Name = "btnCloneAmd";
            this.btnCloneAmd.Size = new System.Drawing.Size(88, 27);
            this.btnCloneAmd.TabIndex = 16;
            this.btnCloneAmd.Text = "Clone";
            this.btnCloneAmd.UseVisualStyleBackColor = true;
            this.btnCloneAmd.Click += new System.EventHandler(this.btnCloneAmd_Click);
            // 
            // btnAmdPresetSave
            // 
            this.btnAmdPresetSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAmdPresetSave.Enabled = false;
            this.btnAmdPresetSave.Location = new System.Drawing.Point(479, 429);
            this.btnAmdPresetSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAmdPresetSave.Name = "btnAmdPresetSave";
            this.btnAmdPresetSave.Size = new System.Drawing.Size(88, 27);
            this.btnAmdPresetSave.TabIndex = 15;
            this.btnAmdPresetSave.Text = "Save";
            this.btnAmdPresetSave.UseVisualStyleBackColor = true;
            this.btnAmdPresetSave.Click += new System.EventHandler(this.btnSetAmdShortcut_Click);
            // 
            // lblAmdShortcut
            // 
            this.lblAmdShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAmdShortcut.AutoSize = true;
            this.lblAmdShortcut.Location = new System.Drawing.Point(7, 496);
            this.lblAmdShortcut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAmdShortcut.Name = "lblAmdShortcut";
            this.lblAmdShortcut.Size = new System.Drawing.Size(55, 15);
            this.lblAmdShortcut.TabIndex = 14;
            this.lblAmdShortcut.Text = "Shortcut:";
            // 
            // edtAmdShortcut
            // 
            this.edtAmdShortcut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtAmdShortcut.Enabled = false;
            this.edtAmdShortcut.Location = new System.Drawing.Point(102, 493);
            this.edtAmdShortcut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtAmdShortcut.Name = "edtAmdShortcut";
            this.edtAmdShortcut.ReadOnly = true;
            this.edtAmdShortcut.Size = new System.Drawing.Size(233, 23);
            this.edtAmdShortcut.TabIndex = 13;
            this.edtAmdShortcut.TextChanged += new System.EventHandler(this.edtAmdShortcut_TextChanged);
            this.edtAmdShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyDown);
            this.edtAmdShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyUp);
            // 
            // btnChangeAmd
            // 
            this.btnChangeAmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnChangeAmd.ContextMenuStrip = this.mnuAmdPresets;
            this.btnChangeAmd.Enabled = false;
            this.btnChangeAmd.Location = new System.Drawing.Point(102, 429);
            this.btnChangeAmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnChangeAmd.Name = "btnChangeAmd";
            this.btnChangeAmd.Size = new System.Drawing.Size(88, 27);
            this.btnChangeAmd.TabIndex = 12;
            this.btnChangeAmd.Text = "Change...";
            this.btnChangeAmd.UseVisualStyleBackColor = true;
            this.btnChangeAmd.Click += new System.EventHandler(this.btnChangeAmd_Click);
            // 
            // mnuAmdPresets
            // 
            this.mnuAmdPresets.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuAmdPresets.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAmdApply,
            this.miAmdPresetApplyOnStartup,
            this.toolStripSeparator2,
            this.mnuAmdDisplay,
            this.mnuAmdColorSettings,
            this.mnuAmdRefreshRate,
            this.mnuAmdDithering,
            this.mnuAmdHDR,
            this.miAmdCopyId});
            this.mnuAmdPresets.Name = "mnuNvPresets";
            this.mnuAmdPresets.Size = new System.Drawing.Size(185, 186);
            this.mnuAmdPresets.Opening += new System.ComponentModel.CancelEventHandler(this.mnuAmdPresets_Opening);
            // 
            // miAmdApply
            // 
            this.miAmdApply.Name = "miAmdApply";
            this.miAmdApply.Size = new System.Drawing.Size(184, 22);
            this.miAmdApply.Text = "Apply";
            this.miAmdApply.Click += new System.EventHandler(this.btnApplyAmd_Click);
            // 
            // miAmdPresetApplyOnStartup
            // 
            this.miAmdPresetApplyOnStartup.CheckOnClick = true;
            this.miAmdPresetApplyOnStartup.Name = "miAmdPresetApplyOnStartup";
            this.miAmdPresetApplyOnStartup.Size = new System.Drawing.Size(184, 22);
            this.miAmdPresetApplyOnStartup.Text = "Apply on startup";
            this.miAmdPresetApplyOnStartup.Click += new System.EventHandler(this.miAmdPresetApplyOnStartup_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // mnuAmdDisplay
            // 
            this.mnuAmdDisplay.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAmdPrimaryDisplay});
            this.mnuAmdDisplay.Name = "mnuAmdDisplay";
            this.mnuAmdDisplay.Size = new System.Drawing.Size(184, 22);
            this.mnuAmdDisplay.Text = "Display";
            // 
            // miAmdPrimaryDisplay
            // 
            this.miAmdPrimaryDisplay.Name = "miAmdPrimaryDisplay";
            this.miAmdPrimaryDisplay.Size = new System.Drawing.Size(155, 22);
            this.miAmdPrimaryDisplay.Text = "Primary display";
            this.miAmdPrimaryDisplay.Click += new System.EventHandler(this.displayMenuItemAmd_Click);
            // 
            // mnuAmdColorSettings
            // 
            this.mnuAmdColorSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAmdColorSettingsIncluded});
            this.mnuAmdColorSettings.Name = "mnuAmdColorSettings";
            this.mnuAmdColorSettings.Size = new System.Drawing.Size(184, 22);
            this.mnuAmdColorSettings.Text = "Color settings";
            // 
            // miAmdColorSettingsIncluded
            // 
            this.miAmdColorSettingsIncluded.Name = "miAmdColorSettingsIncluded";
            this.miAmdColorSettingsIncluded.Size = new System.Drawing.Size(120, 22);
            this.miAmdColorSettingsIncluded.Text = "Included";
            this.miAmdColorSettingsIncluded.Click += new System.EventHandler(this.miAmdColorSettingsIncluded_Click);
            // 
            // mnuAmdRefreshRate
            // 
            this.mnuAmdRefreshRate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAmdRefreshRateIncluded});
            this.mnuAmdRefreshRate.Name = "mnuAmdRefreshRate";
            this.mnuAmdRefreshRate.Size = new System.Drawing.Size(184, 22);
            this.mnuAmdRefreshRate.Text = "Refresh Rate";
            // 
            // miAmdRefreshRateIncluded
            // 
            this.miAmdRefreshRateIncluded.Name = "miAmdRefreshRateIncluded";
            this.miAmdRefreshRateIncluded.Size = new System.Drawing.Size(120, 22);
            this.miAmdRefreshRateIncluded.Text = "Included";
            this.miAmdRefreshRateIncluded.Click += new System.EventHandler(this.miAmdRefreshRateIncluded_Click);
            // 
            // mnuAmdDithering
            // 
            this.mnuAmdDithering.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAmdDitheringIncluded});
            this.mnuAmdDithering.Name = "mnuAmdDithering";
            this.mnuAmdDithering.Size = new System.Drawing.Size(184, 22);
            this.mnuAmdDithering.Text = "Dithering";
            // 
            // miAmdDitheringIncluded
            // 
            this.miAmdDitheringIncluded.Name = "miAmdDitheringIncluded";
            this.miAmdDitheringIncluded.Size = new System.Drawing.Size(120, 22);
            this.miAmdDitheringIncluded.Text = "Included";
            this.miAmdDitheringIncluded.Click += new System.EventHandler(this.miAmdDitheringIncluded_Click);
            // 
            // mnuAmdHDR
            // 
            this.mnuAmdHDR.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAmdHDRIncluded,
            this.miAmdHDRToggle,
            this.miAmdHDREnabled});
            this.mnuAmdHDR.Name = "mnuAmdHDR";
            this.mnuAmdHDR.Size = new System.Drawing.Size(184, 22);
            this.mnuAmdHDR.Text = "HDR";
            // 
            // miAmdHDRIncluded
            // 
            this.miAmdHDRIncluded.Name = "miAmdHDRIncluded";
            this.miAmdHDRIncluded.Size = new System.Drawing.Size(136, 22);
            this.miAmdHDRIncluded.Text = "Included";
            this.miAmdHDRIncluded.Click += new System.EventHandler(this.miAmdHDRIncluded_Click);
            // 
            // miAmdHDRToggle
            // 
            this.miAmdHDRToggle.Name = "miAmdHDRToggle";
            this.miAmdHDRToggle.Size = new System.Drawing.Size(136, 22);
            this.miAmdHDRToggle.Text = "Toggle HDR";
            this.miAmdHDRToggle.Click += new System.EventHandler(this.miAmdHDRToggle_Click);
            // 
            // miAmdHDREnabled
            // 
            this.miAmdHDREnabled.Name = "miAmdHDREnabled";
            this.miAmdHDREnabled.Size = new System.Drawing.Size(136, 22);
            this.miAmdHDREnabled.Text = "Enabled";
            this.miAmdHDREnabled.Click += new System.EventHandler(this.miAmdHDREnabled_Click);
            // 
            // miAmdCopyId
            // 
            this.miAmdCopyId.Name = "miAmdCopyId";
            this.miAmdCopyId.Size = new System.Drawing.Size(184, 22);
            this.miAmdCopyId.Text = "Copy Id to Clipboard";
            this.miAmdCopyId.Click += new System.EventHandler(this.miAmdCopyId_Click);
            // 
            // btnApplyAmd
            // 
            this.btnApplyAmd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplyAmd.Enabled = false;
            this.btnApplyAmd.Location = new System.Drawing.Point(7, 429);
            this.btnApplyAmd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApplyAmd.Name = "btnApplyAmd";
            this.btnApplyAmd.Size = new System.Drawing.Size(88, 27);
            this.btnApplyAmd.TabIndex = 11;
            this.btnApplyAmd.Text = "Apply";
            this.btnApplyAmd.UseVisualStyleBackColor = true;
            this.btnApplyAmd.Click += new System.EventHandler(this.btnApplyAmd_Click);
            // 
            // lvAmdPresets
            // 
            this.lvAmdPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvAmdPresets.ContextMenuStrip = this.mnuAmdPresets;
            this.lvAmdPresets.FullRowSelect = true;
            this.lvAmdPresets.Location = new System.Drawing.Point(7, 7);
            this.lvAmdPresets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvAmdPresets.MultiSelect = false;
            this.lvAmdPresets.Name = "lvAmdPresets";
            this.lvAmdPresets.Size = new System.Drawing.Size(1098, 415);
            this.lvAmdPresets.TabIndex = 10;
            this.lvAmdPresets.UseCompatibleStateImageBehavior = false;
            this.lvAmdPresets.View = System.Windows.Forms.View.Details;
            this.lvAmdPresets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvLgPresets_ColumnClick);
            this.lvAmdPresets.SelectedIndexChanged += new System.EventHandler(this.lvAmdPresets_SelectedIndexChanged);
            this.lvAmdPresets.DoubleClick += new System.EventHandler(this.btnApplyAmd_Click);
            // 
            // tabLG
            // 
            this.tabLG.Controls.Add(this.scLgController);
            this.tabLG.Location = new System.Drawing.Point(4, 24);
            this.tabLG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabLG.Name = "tabLG";
            this.tabLG.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabLG.Size = new System.Drawing.Size(1114, 525);
            this.tabLG.TabIndex = 1;
            this.tabLG.Text = "LG controller";
            this.tabLG.UseVisualStyleBackColor = true;
            // 
            // scLgController
            // 
            this.scLgController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scLgController.Location = new System.Drawing.Point(4, 3);
            this.scLgController.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.scLgController.Name = "scLgController";
            // 
            // scLgController.Panel1
            // 
            this.scLgController.Panel1.Controls.Add(this.cbxLgPcHdmiPort);
            this.scLgController.Panel1.Controls.Add(this.lblLgPcHdmiPort);
            this.scLgController.Panel1.Controls.Add(this.edtLgPresetDescription);
            this.scLgController.Panel1.Controls.Add(this.lblLgPresetDescription);
            this.scLgController.Panel1.Controls.Add(this.btnLgDeviceOptionsHelp);
            this.scLgController.Panel1.Controls.Add(this.btnLgGameBar);
            this.scLgController.Panel1.Controls.Add(this.btnLgPresetEditTriggerConditions);
            this.scLgController.Panel1.Controls.Add(this.edtLgPresetTriggerConditions);
            this.scLgController.Panel1.Controls.Add(this.lblLgPresetExcludedProcesses);
            this.scLgController.Panel1.Controls.Add(this.edtLgPresetExcludedProcesses);
            this.scLgController.Panel1.Controls.Add(this.lblLgPresetIncludedProcesses);
            this.scLgController.Panel1.Controls.Add(this.edtLgPresetIncludedProcesses);
            this.scLgController.Panel1.Controls.Add(this.lblLgPresetTriggerCondition);
            this.scLgController.Panel1.Controls.Add(this.cbxLgPresetTrigger);
            this.scLgController.Panel1.Controls.Add(this.lblLgPresetTrigger);
            this.scLgController.Panel1.Controls.Add(this.btnLgExpert);
            this.scLgController.Panel1.Controls.Add(this.chkLgRemoteControlShow);
            this.scLgController.Panel1.Controls.Add(this.label3);
            this.scLgController.Panel1.Controls.Add(this.cbxLgDevices);
            this.scLgController.Panel1.Controls.Add(this.btnLgDeviceConvertToCustom);
            this.scLgController.Panel1.Controls.Add(this.cbxLgApps);
            this.scLgController.Panel1.Controls.Add(this.lvLgPresets);
            this.scLgController.Panel1.Controls.Add(this.label5);
            this.scLgController.Panel1.Controls.Add(this.cbxLgPresetDevice);
            this.scLgController.Panel1.Controls.Add(this.btnDeleteLg);
            this.scLgController.Panel1.Controls.Add(this.btnApplyLg);
            this.scLgController.Panel1.Controls.Add(this.lblDeviceFilter);
            this.scLgController.Panel1.Controls.Add(this.lblLgPresetDevice);
            this.scLgController.Panel1.Controls.Add(this.btnAddLg);
            this.scLgController.Panel1.Controls.Add(this.edtShortcutLg);
            this.scLgController.Panel1.Controls.Add(this.edtLgDeviceFilter);
            this.scLgController.Panel1.Controls.Add(this.btnLgRemoveDevice);
            this.scLgController.Panel1.Controls.Add(this.btnLgRefreshApps);
            this.scLgController.Panel1.Controls.Add(this.label2);
            this.scLgController.Panel1.Controls.Add(this.label1);
            this.scLgController.Panel1.Controls.Add(this.btnLgAddDevice);
            this.scLgController.Panel1.Controls.Add(this.edtNameLg);
            this.scLgController.Panel1.Controls.Add(this.btnSetShortcutLg);
            this.scLgController.Panel1.Controls.Add(this.edtStepsLg);
            this.scLgController.Panel1.Controls.Add(this.btnLgAddButton);
            this.scLgController.Panel1.Controls.Add(this.btnCloneLg);
            this.scLgController.Panel1.Controls.Add(this.lblStepsLg);
            this.scLgController.Panel1.Controls.Add(this.btnLgDeviceFilterRefresh);
            this.scLgController.Panel1.Controls.Add(this.clbLgPower);
            this.scLgController.Panel1.Controls.Add(this.lblLgError);
            this.scLgController.Panel1MinSize = 750;
            this.scLgController.Panel2MinSize = 150;
            this.scLgController.Size = new System.Drawing.Size(1106, 519);
            this.scLgController.SplitterDistance = 894;
            this.scLgController.SplitterWidth = 5;
            this.scLgController.TabIndex = 43;
            // 
            // cbxLgPcHdmiPort
            // 
            this.cbxLgPcHdmiPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLgPcHdmiPort.FormattingEnabled = true;
            this.cbxLgPcHdmiPort.Items.AddRange(new object[] {
            "None",
            "HDMI1",
            "HDMI2",
            "HDMI3",
            "HDMI4"});
            this.cbxLgPcHdmiPort.Location = new System.Drawing.Point(667, 42);
            this.cbxLgPcHdmiPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxLgPcHdmiPort.Name = "cbxLgPcHdmiPort";
            this.cbxLgPcHdmiPort.Size = new System.Drawing.Size(86, 23);
            this.cbxLgPcHdmiPort.TabIndex = 62;
            this.cbxLgPcHdmiPort.SelectedIndexChanged += new System.EventHandler(this.cbxLgPcHdmiPort_SelectedIndexChanged);
            // 
            // lblLgPcHdmiPort
            // 
            this.lblLgPcHdmiPort.AutoSize = true;
            this.lblLgPcHdmiPort.Location = new System.Drawing.Point(577, 45);
            this.lblLgPcHdmiPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgPcHdmiPort.Name = "lblLgPcHdmiPort";
            this.lblLgPcHdmiPort.Size = new System.Drawing.Size(84, 15);
            this.lblLgPcHdmiPort.TabIndex = 61;
            this.lblLgPcHdmiPort.Text = "PC HDMI port:";
            // 
            // edtLgPresetDescription
            // 
            this.edtLgPresetDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtLgPresetDescription.Enabled = false;
            this.edtLgPresetDescription.Location = new System.Drawing.Point(100, 469);
            this.edtLgPresetDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgPresetDescription.Multiline = true;
            this.edtLgPresetDescription.Name = "edtLgPresetDescription";
            this.edtLgPresetDescription.Size = new System.Drawing.Size(694, 43);
            this.edtLgPresetDescription.TabIndex = 60;
            // 
            // lblLgPresetDescription
            // 
            this.lblLgPresetDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLgPresetDescription.AutoSize = true;
            this.lblLgPresetDescription.Location = new System.Drawing.Point(6, 474);
            this.lblLgPresetDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgPresetDescription.Name = "lblLgPresetDescription";
            this.lblLgPresetDescription.Size = new System.Drawing.Size(70, 15);
            this.lblLgPresetDescription.TabIndex = 59;
            this.lblLgPresetDescription.Text = "Description:";
            // 
            // btnLgDeviceOptionsHelp
            // 
            this.btnLgDeviceOptionsHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLgDeviceOptionsHelp.Location = new System.Drawing.Point(867, 70);
            this.btnLgDeviceOptionsHelp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgDeviceOptionsHelp.Name = "btnLgDeviceOptionsHelp";
            this.btnLgDeviceOptionsHelp.Size = new System.Drawing.Size(22, 27);
            this.btnLgDeviceOptionsHelp.TabIndex = 58;
            this.btnLgDeviceOptionsHelp.Text = "?";
            this.btnLgDeviceOptionsHelp.UseVisualStyleBackColor = true;
            this.btnLgDeviceOptionsHelp.Click += new System.EventHandler(this.btnLgDeviceOptionsHelp_Click);
            // 
            // btnLgGameBar
            // 
            this.btnLgGameBar.Location = new System.Drawing.Point(478, 40);
            this.btnLgGameBar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgGameBar.Name = "btnLgGameBar";
            this.btnLgGameBar.Size = new System.Drawing.Size(88, 27);
            this.btnLgGameBar.TabIndex = 55;
            this.btnLgGameBar.Text = "Game Bar";
            this.btnLgGameBar.UseVisualStyleBackColor = true;
            this.btnLgGameBar.Click += new System.EventHandler(this.btnLgGameBar_Click);
            // 
            // btnLgPresetEditTriggerConditions
            // 
            this.btnLgPresetEditTriggerConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLgPresetEditTriggerConditions.Location = new System.Drawing.Point(804, 327);
            this.btnLgPresetEditTriggerConditions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgPresetEditTriggerConditions.Name = "btnLgPresetEditTriggerConditions";
            this.btnLgPresetEditTriggerConditions.Size = new System.Drawing.Size(88, 27);
            this.btnLgPresetEditTriggerConditions.TabIndex = 54;
            this.btnLgPresetEditTriggerConditions.Text = "Edit...";
            this.btnLgPresetEditTriggerConditions.UseVisualStyleBackColor = true;
            this.btnLgPresetEditTriggerConditions.Click += new System.EventHandler(this.btnLgPresetEditTriggerConditions_Click);
            // 
            // edtLgPresetTriggerConditions
            // 
            this.edtLgPresetTriggerConditions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtLgPresetTriggerConditions.Enabled = false;
            this.edtLgPresetTriggerConditions.Location = new System.Drawing.Point(601, 329);
            this.edtLgPresetTriggerConditions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgPresetTriggerConditions.Name = "edtLgPresetTriggerConditions";
            this.edtLgPresetTriggerConditions.ReadOnly = true;
            this.edtLgPresetTriggerConditions.Size = new System.Drawing.Size(194, 23);
            this.edtLgPresetTriggerConditions.TabIndex = 53;
            // 
            // lblLgPresetExcludedProcesses
            // 
            this.lblLgPresetExcludedProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLgPresetExcludedProcesses.AutoSize = true;
            this.lblLgPresetExcludedProcesses.Location = new System.Drawing.Point(475, 394);
            this.lblLgPresetExcludedProcesses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgPresetExcludedProcesses.Name = "lblLgPresetExcludedProcesses";
            this.lblLgPresetExcludedProcesses.Size = new System.Drawing.Size(112, 15);
            this.lblLgPresetExcludedProcesses.TabIndex = 52;
            this.lblLgPresetExcludedProcesses.Text = "Excluded processes:";
            // 
            // edtLgPresetExcludedProcesses
            // 
            this.edtLgPresetExcludedProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtLgPresetExcludedProcesses.Enabled = false;
            this.edtLgPresetExcludedProcesses.Location = new System.Drawing.Point(601, 391);
            this.edtLgPresetExcludedProcesses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgPresetExcludedProcesses.Name = "edtLgPresetExcludedProcesses";
            this.edtLgPresetExcludedProcesses.Size = new System.Drawing.Size(289, 23);
            this.edtLgPresetExcludedProcesses.TabIndex = 51;
            // 
            // lblLgPresetIncludedProcesses
            // 
            this.lblLgPresetIncludedProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLgPresetIncludedProcesses.AutoSize = true;
            this.lblLgPresetIncludedProcesses.Location = new System.Drawing.Point(475, 364);
            this.lblLgPresetIncludedProcesses.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgPresetIncludedProcesses.Name = "lblLgPresetIncludedProcesses";
            this.lblLgPresetIncludedProcesses.Size = new System.Drawing.Size(110, 15);
            this.lblLgPresetIncludedProcesses.TabIndex = 50;
            this.lblLgPresetIncludedProcesses.Text = "Included processes:";
            // 
            // edtLgPresetIncludedProcesses
            // 
            this.edtLgPresetIncludedProcesses.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtLgPresetIncludedProcesses.Enabled = false;
            this.edtLgPresetIncludedProcesses.Location = new System.Drawing.Point(601, 361);
            this.edtLgPresetIncludedProcesses.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgPresetIncludedProcesses.Name = "edtLgPresetIncludedProcesses";
            this.edtLgPresetIncludedProcesses.Size = new System.Drawing.Size(289, 23);
            this.edtLgPresetIncludedProcesses.TabIndex = 49;
            // 
            // lblLgPresetTriggerCondition
            // 
            this.lblLgPresetTriggerCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLgPresetTriggerCondition.AutoSize = true;
            this.lblLgPresetTriggerCondition.Location = new System.Drawing.Point(475, 333);
            this.lblLgPresetTriggerCondition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgPresetTriggerCondition.Name = "lblLgPresetTriggerCondition";
            this.lblLgPresetTriggerCondition.Size = new System.Drawing.Size(63, 15);
            this.lblLgPresetTriggerCondition.TabIndex = 47;
            this.lblLgPresetTriggerCondition.Text = "Condition:";
            // 
            // cbxLgPresetTrigger
            // 
            this.cbxLgPresetTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxLgPresetTrigger.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLgPresetTrigger.Enabled = false;
            this.cbxLgPresetTrigger.FormattingEnabled = true;
            this.cbxLgPresetTrigger.Location = new System.Drawing.Point(601, 298);
            this.cbxLgPresetTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxLgPresetTrigger.Name = "cbxLgPresetTrigger";
            this.cbxLgPresetTrigger.Size = new System.Drawing.Size(289, 23);
            this.cbxLgPresetTrigger.TabIndex = 46;
            // 
            // lblLgPresetTrigger
            // 
            this.lblLgPresetTrigger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLgPresetTrigger.AutoSize = true;
            this.lblLgPresetTrigger.Location = new System.Drawing.Point(475, 301);
            this.lblLgPresetTrigger.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgPresetTrigger.Name = "lblLgPresetTrigger";
            this.lblLgPresetTrigger.Size = new System.Drawing.Size(46, 15);
            this.lblLgPresetTrigger.TabIndex = 45;
            this.lblLgPresetTrigger.Text = "Trigger:";
            // 
            // btnLgExpert
            // 
            this.btnLgExpert.ContextMenuStrip = this.mnuLgExpert;
            this.btnLgExpert.Location = new System.Drawing.Point(368, 39);
            this.btnLgExpert.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgExpert.Name = "btnLgExpert";
            this.btnLgExpert.Size = new System.Drawing.Size(88, 27);
            this.btnLgExpert.TabIndex = 44;
            this.btnLgExpert.Text = "Expert...";
            this.btnLgExpert.UseVisualStyleBackColor = true;
            this.btnLgExpert.Click += new System.EventHandler(this.btnLgExpert_Click);
            // 
            // mnuLgExpert
            // 
            this.mnuLgExpert.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuLgExpert.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLgOLEDMotionPro,
            this.miLgExpertSeparator1});
            this.mnuLgExpert.Name = "mnuLgButtons";
            this.mnuLgExpert.Size = new System.Drawing.Size(321, 32);
            this.mnuLgExpert.Opening += new System.ComponentModel.CancelEventHandler(this.mnuLgExpert_Opening);
            // 
            // mnuLgOLEDMotionPro
            // 
            this.mnuLgOLEDMotionPro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLgEnableMotionPro,
            this.miLgDisableMotionPro});
            this.mnuLgOLEDMotionPro.Name = "mnuLgOLEDMotionPro";
            this.mnuLgOLEDMotionPro.Size = new System.Drawing.Size(320, 22);
            this.mnuLgOLEDMotionPro.Text = "Activate OLED Motion Pro (B9/C9/E9/W9 only)";
            // 
            // miLgEnableMotionPro
            // 
            this.miLgEnableMotionPro.Name = "miLgEnableMotionPro";
            this.miLgEnableMotionPro.Size = new System.Drawing.Size(207, 22);
            this.miLgEnableMotionPro.Text = "Enable OLED Motion Pro";
            this.miLgEnableMotionPro.Click += new System.EventHandler(this.miLgEnableMotionPro_Click);
            // 
            // miLgDisableMotionPro
            // 
            this.miLgDisableMotionPro.Name = "miLgDisableMotionPro";
            this.miLgDisableMotionPro.Size = new System.Drawing.Size(207, 22);
            this.miLgDisableMotionPro.Text = "Disable OLED Motion Pro";
            this.miLgDisableMotionPro.Click += new System.EventHandler(this.miLgDisableMotionPro_Click);
            // 
            // miLgExpertSeparator1
            // 
            this.miLgExpertSeparator1.Name = "miLgExpertSeparator1";
            this.miLgExpertSeparator1.Size = new System.Drawing.Size(317, 6);
            // 
            // chkLgRemoteControlShow
            // 
            this.chkLgRemoteControlShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkLgRemoteControlShow.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkLgRemoteControlShow.AutoSize = true;
            this.chkLgRemoteControlShow.Location = new System.Drawing.Point(788, 8);
            this.chkLgRemoteControlShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkLgRemoteControlShow.Name = "chkLgRemoteControlShow";
            this.chkLgRemoteControlShow.Size = new System.Drawing.Size(101, 25);
            this.chkLgRemoteControlShow.TabIndex = 43;
            this.chkLgRemoteControlShow.Text = "Remote Control";
            this.chkLgRemoteControlShow.UseVisualStyleBackColor = true;
            this.chkLgRemoteControlShow.CheckedChanged += new System.EventHandler(this.chkLgRemoteControlShow_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Device:";
            // 
            // cbxLgDevices
            // 
            this.cbxLgDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLgDevices.DropDownWidth = 400;
            this.cbxLgDevices.FormattingEnabled = true;
            this.cbxLgDevices.Location = new System.Drawing.Point(100, 9);
            this.cbxLgDevices.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxLgDevices.Name = "cbxLgDevices";
            this.cbxLgDevices.Size = new System.Drawing.Size(370, 23);
            this.cbxLgDevices.TabIndex = 30;
            this.cbxLgDevices.SelectedIndexChanged += new System.EventHandler(this.cbxLgDevices_SelectedIndexChanged);
            // 
            // btnLgDeviceConvertToCustom
            // 
            this.btnLgDeviceConvertToCustom.Location = new System.Drawing.Point(667, 8);
            this.btnLgDeviceConvertToCustom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgDeviceConvertToCustom.Name = "btnLgDeviceConvertToCustom";
            this.btnLgDeviceConvertToCustom.Size = new System.Drawing.Size(88, 27);
            this.btnLgDeviceConvertToCustom.TabIndex = 41;
            this.btnLgDeviceConvertToCustom.Text = "To custom...";
            this.btnLgDeviceConvertToCustom.UseVisualStyleBackColor = true;
            this.btnLgDeviceConvertToCustom.Click += new System.EventHandler(this.btnLgDeviceConvertToCustom_Click);
            // 
            // cbxLgApps
            // 
            this.cbxLgApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxLgApps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLgApps.Enabled = false;
            this.cbxLgApps.FormattingEnabled = true;
            this.cbxLgApps.Location = new System.Drawing.Point(100, 360);
            this.cbxLgApps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxLgApps.Name = "cbxLgApps";
            this.cbxLgApps.Size = new System.Drawing.Size(233, 23);
            this.cbxLgApps.TabIndex = 26;
            this.cbxLgApps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbxLgApps_KeyPress);
            // 
            // lvLgPresets
            // 
            this.lvLgPresets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvLgPresets.FullRowSelect = true;
            this.lvLgPresets.Location = new System.Drawing.Point(6, 152);
            this.lvLgPresets.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lvLgPresets.MultiSelect = false;
            this.lvLgPresets.Name = "lvLgPresets";
            this.lvLgPresets.Size = new System.Drawing.Size(883, 106);
            this.lvLgPresets.TabIndex = 8;
            this.lvLgPresets.UseCompatibleStateImageBehavior = false;
            this.lvLgPresets.View = System.Windows.Forms.View.Details;
            this.lvLgPresets.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvLgPresets_ColumnClick);
            this.lvLgPresets.SelectedIndexChanged += new System.EventHandler(this.lvLgPresets_SelectedIndexChanged);
            this.lvLgPresets.DoubleClick += new System.EventHandler(this.lvLgPresets_DoubleClick);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 364);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 25;
            this.label5.Text = "App:";
            // 
            // cbxLgPresetDevice
            // 
            this.cbxLgPresetDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbxLgPresetDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLgPresetDevice.Enabled = false;
            this.cbxLgPresetDevice.FormattingEnabled = true;
            this.cbxLgPresetDevice.Location = new System.Drawing.Point(100, 328);
            this.cbxLgPresetDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxLgPresetDevice.Name = "cbxLgPresetDevice";
            this.cbxLgPresetDevice.Size = new System.Drawing.Size(370, 23);
            this.cbxLgPresetDevice.TabIndex = 40;
            // 
            // btnDeleteLg
            // 
            this.btnDeleteLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDeleteLg.Enabled = false;
            this.btnDeleteLg.Location = new System.Drawing.Point(289, 264);
            this.btnDeleteLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDeleteLg.Name = "btnDeleteLg";
            this.btnDeleteLg.Size = new System.Drawing.Size(88, 27);
            this.btnDeleteLg.TabIndex = 27;
            this.btnDeleteLg.Text = "Delete";
            this.btnDeleteLg.UseVisualStyleBackColor = true;
            this.btnDeleteLg.Click += new System.EventHandler(this.btnDeleteLg_Click);
            // 
            // btnApplyLg
            // 
            this.btnApplyLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnApplyLg.Enabled = false;
            this.btnApplyLg.Location = new System.Drawing.Point(6, 264);
            this.btnApplyLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnApplyLg.Name = "btnApplyLg";
            this.btnApplyLg.Size = new System.Drawing.Size(88, 27);
            this.btnApplyLg.TabIndex = 9;
            this.btnApplyLg.Text = "Apply";
            this.btnApplyLg.UseVisualStyleBackColor = true;
            this.btnApplyLg.Click += new System.EventHandler(this.btnApplyLg_Click);
            // 
            // lblDeviceFilter
            // 
            this.lblDeviceFilter.AutoSize = true;
            this.lblDeviceFilter.Location = new System.Drawing.Point(6, 45);
            this.lblDeviceFilter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeviceFilter.Name = "lblDeviceFilter";
            this.lblDeviceFilter.Size = new System.Drawing.Size(72, 15);
            this.lblDeviceFilter.TabIndex = 24;
            this.lblDeviceFilter.Text = "Device filter:";
            // 
            // lblLgPresetDevice
            // 
            this.lblLgPresetDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblLgPresetDevice.AutoSize = true;
            this.lblLgPresetDevice.Location = new System.Drawing.Point(6, 331);
            this.lblLgPresetDevice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgPresetDevice.Name = "lblLgPresetDevice";
            this.lblLgPresetDevice.Size = new System.Drawing.Size(45, 15);
            this.lblLgPresetDevice.TabIndex = 39;
            this.lblLgPresetDevice.Text = "Device:";
            // 
            // btnAddLg
            // 
            this.btnAddLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddLg.Location = new System.Drawing.Point(195, 264);
            this.btnAddLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAddLg.Name = "btnAddLg";
            this.btnAddLg.Size = new System.Drawing.Size(88, 27);
            this.btnAddLg.TabIndex = 28;
            this.btnAddLg.Text = "Add";
            this.btnAddLg.UseVisualStyleBackColor = true;
            this.btnAddLg.Click += new System.EventHandler(this.btnAddLg_Click);
            // 
            // edtShortcutLg
            // 
            this.edtShortcutLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtShortcutLg.Enabled = false;
            this.edtShortcutLg.Location = new System.Drawing.Point(100, 391);
            this.edtShortcutLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtShortcutLg.Name = "edtShortcutLg";
            this.edtShortcutLg.ReadOnly = true;
            this.edtShortcutLg.Size = new System.Drawing.Size(233, 23);
            this.edtShortcutLg.TabIndex = 11;
            this.edtShortcutLg.TextChanged += new System.EventHandler(this.edtShortcutLg_TextChanged);
            this.edtShortcutLg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyDown);
            this.edtShortcutLg.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyUp);
            // 
            // edtLgDeviceFilter
            // 
            this.edtLgDeviceFilter.Location = new System.Drawing.Point(100, 40);
            this.edtLgDeviceFilter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgDeviceFilter.Name = "edtLgDeviceFilter";
            this.edtLgDeviceFilter.Size = new System.Drawing.Size(165, 23);
            this.edtLgDeviceFilter.TabIndex = 23;
            this.edtLgDeviceFilter.TextChanged += new System.EventHandler(this.edtLgDeviceFilter_TextChanged);
            // 
            // btnLgRemoveDevice
            // 
            this.btnLgRemoveDevice.Location = new System.Drawing.Point(573, 8);
            this.btnLgRemoveDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgRemoveDevice.Name = "btnLgRemoveDevice";
            this.btnLgRemoveDevice.Size = new System.Drawing.Size(88, 27);
            this.btnLgRemoveDevice.TabIndex = 38;
            this.btnLgRemoveDevice.Text = "Remove";
            this.btnLgRemoveDevice.UseVisualStyleBackColor = true;
            this.btnLgRemoveDevice.Click += new System.EventHandler(this.btnLgRemoveDevice_Click);
            // 
            // btnLgRefreshApps
            // 
            this.btnLgRefreshApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLgRefreshApps.Location = new System.Drawing.Point(341, 358);
            this.btnLgRefreshApps.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgRefreshApps.Name = "btnLgRefreshApps";
            this.btnLgRefreshApps.Size = new System.Drawing.Size(88, 27);
            this.btnLgRefreshApps.TabIndex = 29;
            this.btnLgRefreshApps.Text = "Refresh";
            this.btnLgRefreshApps.UseVisualStyleBackColor = true;
            this.btnLgRefreshApps.Click += new System.EventHandler(this.btnLgRefreshApps_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Shortcut:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Name:";
            // 
            // btnLgAddDevice
            // 
            this.btnLgAddDevice.Location = new System.Drawing.Point(478, 8);
            this.btnLgAddDevice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgAddDevice.Name = "btnLgAddDevice";
            this.btnLgAddDevice.Size = new System.Drawing.Size(88, 27);
            this.btnLgAddDevice.TabIndex = 37;
            this.btnLgAddDevice.Text = "Add";
            this.btnLgAddDevice.UseVisualStyleBackColor = true;
            this.btnLgAddDevice.Click += new System.EventHandler(this.btnLgAddDevice_Click);
            // 
            // edtNameLg
            // 
            this.edtNameLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.edtNameLg.Enabled = false;
            this.edtNameLg.Location = new System.Drawing.Point(100, 298);
            this.edtNameLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtNameLg.Name = "edtNameLg";
            this.edtNameLg.Size = new System.Drawing.Size(233, 23);
            this.edtNameLg.TabIndex = 19;
            // 
            // btnSetShortcutLg
            // 
            this.btnSetShortcutLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSetShortcutLg.Enabled = false;
            this.btnSetShortcutLg.Location = new System.Drawing.Point(384, 264);
            this.btnSetShortcutLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetShortcutLg.Name = "btnSetShortcutLg";
            this.btnSetShortcutLg.Size = new System.Drawing.Size(88, 27);
            this.btnSetShortcutLg.TabIndex = 13;
            this.btnSetShortcutLg.Text = "Save";
            this.btnSetShortcutLg.UseVisualStyleBackColor = true;
            this.btnSetShortcutLg.Click += new System.EventHandler(this.btnSetShortcutLg_Click);
            // 
            // edtStepsLg
            // 
            this.edtStepsLg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtStepsLg.Enabled = false;
            this.edtStepsLg.Location = new System.Drawing.Point(100, 420);
            this.edtStepsLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtStepsLg.Multiline = true;
            this.edtStepsLg.Name = "edtStepsLg";
            this.edtStepsLg.Size = new System.Drawing.Size(694, 43);
            this.edtStepsLg.TabIndex = 17;
            // 
            // btnLgAddButton
            // 
            this.btnLgAddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLgAddButton.ContextMenuStrip = this.mnuLgButtons;
            this.btnLgAddButton.Enabled = false;
            this.btnLgAddButton.Location = new System.Drawing.Point(802, 419);
            this.btnLgAddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgAddButton.Name = "btnLgAddButton";
            this.btnLgAddButton.Size = new System.Drawing.Size(88, 27);
            this.btnLgAddButton.TabIndex = 32;
            this.btnLgAddButton.Text = "Add step";
            this.btnLgAddButton.UseVisualStyleBackColor = true;
            this.btnLgAddButton.Click += new System.EventHandler(this.btnLgAddButton_Click);
            // 
            // mnuLgButtons
            // 
            this.mnuLgButtons.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuLgButtons.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLgRcButtons,
            this.mnuLgActions,
            this.mnuLgNvPresets,
            this.mnuLgAmdPresets});
            this.mnuLgButtons.Name = "mnuLgButtons";
            this.mnuLgButtons.Size = new System.Drawing.Size(153, 92);
            this.mnuLgButtons.Opening += new System.ComponentModel.CancelEventHandler(this.mnuLgButtons_Opening);
            // 
            // mnuLgRcButtons
            // 
            this.mnuLgRcButtons.Name = "mnuLgRcButtons";
            this.mnuLgRcButtons.Size = new System.Drawing.Size(152, 22);
            this.mnuLgRcButtons.Text = "Buttons";
            // 
            // mnuLgActions
            // 
            this.mnuLgActions.Name = "mnuLgActions";
            this.mnuLgActions.Size = new System.Drawing.Size(152, 22);
            this.mnuLgActions.Text = "Actions";
            // 
            // mnuLgNvPresets
            // 
            this.mnuLgNvPresets.Name = "mnuLgNvPresets";
            this.mnuLgNvPresets.Size = new System.Drawing.Size(152, 22);
            this.mnuLgNvPresets.Text = "NVIDIA presets";
            // 
            // mnuLgAmdPresets
            // 
            this.mnuLgAmdPresets.Name = "mnuLgAmdPresets";
            this.mnuLgAmdPresets.Size = new System.Drawing.Size(152, 22);
            this.mnuLgAmdPresets.Text = "AMD presets";
            // 
            // btnCloneLg
            // 
            this.btnCloneLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCloneLg.Enabled = false;
            this.btnCloneLg.Location = new System.Drawing.Point(100, 264);
            this.btnCloneLg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCloneLg.Name = "btnCloneLg";
            this.btnCloneLg.Size = new System.Drawing.Size(88, 27);
            this.btnCloneLg.TabIndex = 14;
            this.btnCloneLg.Text = "Clone";
            this.btnCloneLg.UseVisualStyleBackColor = true;
            this.btnCloneLg.Click += new System.EventHandler(this.btnCloneLg_Click);
            // 
            // lblStepsLg
            // 
            this.lblStepsLg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStepsLg.AutoSize = true;
            this.lblStepsLg.Location = new System.Drawing.Point(6, 425);
            this.lblStepsLg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStepsLg.Name = "lblStepsLg";
            this.lblStepsLg.Size = new System.Drawing.Size(38, 15);
            this.lblStepsLg.TabIndex = 16;
            this.lblStepsLg.Text = "Steps:";
            // 
            // btnLgDeviceFilterRefresh
            // 
            this.btnLgDeviceFilterRefresh.Location = new System.Drawing.Point(273, 39);
            this.btnLgDeviceFilterRefresh.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLgDeviceFilterRefresh.Name = "btnLgDeviceFilterRefresh";
            this.btnLgDeviceFilterRefresh.Size = new System.Drawing.Size(88, 27);
            this.btnLgDeviceFilterRefresh.TabIndex = 35;
            this.btnLgDeviceFilterRefresh.Text = "Refresh";
            this.btnLgDeviceFilterRefresh.UseVisualStyleBackColor = true;
            this.btnLgDeviceFilterRefresh.Click += new System.EventHandler(this.btnLgDeviceFilterRefresh_Click);
            // 
            // clbLgPower
            // 
            this.clbLgPower.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbLgPower.CheckOnClick = true;
            this.clbLgPower.ColumnWidth = 380;
            this.clbLgPower.FormattingEnabled = true;
            this.clbLgPower.Items.AddRange(new object[] {
            "Automatically power on after startup",
            "Automatically power on after resume from standby",
            "Automatically power off on shutdown",
            "Automatically power off on standby",
            "Automatically power off/on when screensaver activates/deactivates",
            "Power on even after manual power off",
            "Allow triggers to be fired for this device",
            "Use Windows power settings"});
            this.clbLgPower.Location = new System.Drawing.Point(6, 70);
            this.clbLgPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.clbLgPower.MultiColumn = true;
            this.clbLgPower.Name = "clbLgPower";
            this.clbLgPower.Size = new System.Drawing.Size(856, 76);
            this.clbLgPower.TabIndex = 34;
            this.clbLgPower.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbLgPower_ItemCheck);
            // 
            // lblLgError
            // 
            this.lblLgError.AutoSize = true;
            this.lblLgError.Location = new System.Drawing.Point(6, 9);
            this.lblLgError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgError.Name = "lblLgError";
            this.lblLgError.Size = new System.Drawing.Size(53, 15);
            this.lblLgError.TabIndex = 15;
            this.lblLgError.Text = "ErrorText";
            this.lblLgError.Visible = false;
            // 
            // tabOptions
            // 
            this.tabOptions.Controls.Add(this.grpNvidiaOptions);
            this.tabOptions.Controls.Add(this.grpMiscellaneousOptions);
            this.tabOptions.Controls.Add(this.grpLGOptions);
            this.tabOptions.Controls.Add(this.grpHDROptions);
            this.tabOptions.Controls.Add(this.grpGeneralOptions);
            this.tabOptions.Location = new System.Drawing.Point(4, 24);
            this.tabOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabOptions.Size = new System.Drawing.Size(1114, 525);
            this.tabOptions.TabIndex = 2;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // grpNvidiaOptions
            // 
            this.grpNvidiaOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNvidiaOptions.Controls.Add(this.lblDitheringMode);
            this.grpNvidiaOptions.Controls.Add(this.cbxDitheringMode);
            this.grpNvidiaOptions.Controls.Add(this.lblDitheringBitDepth);
            this.grpNvidiaOptions.Controls.Add(this.cbxDitheringBitDepth);
            this.grpNvidiaOptions.Controls.Add(this.chkDitheringEnabled);
            this.grpNvidiaOptions.Controls.Add(this.pbGradient);
            this.grpNvidiaOptions.Location = new System.Drawing.Point(481, 7);
            this.grpNvidiaOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNvidiaOptions.Name = "grpNvidiaOptions";
            this.grpNvidiaOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNvidiaOptions.Size = new System.Drawing.Size(625, 351);
            this.grpNvidiaOptions.TabIndex = 6;
            this.grpNvidiaOptions.TabStop = false;
            this.grpNvidiaOptions.Text = "NVIDIA options - test dithering";
            // 
            // lblDitheringMode
            // 
            this.lblDitheringMode.AutoSize = true;
            this.lblDitheringMode.Location = new System.Drawing.Point(7, 81);
            this.lblDitheringMode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDitheringMode.Name = "lblDitheringMode";
            this.lblDitheringMode.Size = new System.Drawing.Size(41, 15);
            this.lblDitheringMode.TabIndex = 7;
            this.lblDitheringMode.Text = "Mode:";
            // 
            // cbxDitheringMode
            // 
            this.cbxDitheringMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDitheringMode.FormattingEnabled = true;
            this.cbxDitheringMode.Location = new System.Drawing.Point(75, 75);
            this.cbxDitheringMode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxDitheringMode.Name = "cbxDitheringMode";
            this.cbxDitheringMode.Size = new System.Drawing.Size(136, 23);
            this.cbxDitheringMode.TabIndex = 6;
            this.cbxDitheringMode.SelectedIndexChanged += new System.EventHandler(this.cbxDitheringMode_SelectedIndexChanged);
            // 
            // lblDitheringBitDepth
            // 
            this.lblDitheringBitDepth.AutoSize = true;
            this.lblDitheringBitDepth.Location = new System.Drawing.Point(7, 50);
            this.lblDitheringBitDepth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDitheringBitDepth.Name = "lblDitheringBitDepth";
            this.lblDitheringBitDepth.Size = new System.Drawing.Size(60, 15);
            this.lblDitheringBitDepth.TabIndex = 5;
            this.lblDitheringBitDepth.Text = "Bit-depth:";
            // 
            // cbxDitheringBitDepth
            // 
            this.cbxDitheringBitDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDitheringBitDepth.FormattingEnabled = true;
            this.cbxDitheringBitDepth.Location = new System.Drawing.Point(75, 44);
            this.cbxDitheringBitDepth.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbxDitheringBitDepth.Name = "cbxDitheringBitDepth";
            this.cbxDitheringBitDepth.Size = new System.Drawing.Size(136, 23);
            this.cbxDitheringBitDepth.TabIndex = 4;
            this.cbxDitheringBitDepth.SelectedIndexChanged += new System.EventHandler(this.cbxDitheringBitDepth_SelectedIndexChanged);
            // 
            // chkDitheringEnabled
            // 
            this.chkDitheringEnabled.AutoSize = true;
            this.chkDitheringEnabled.Checked = true;
            this.chkDitheringEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDitheringEnabled.Location = new System.Drawing.Point(7, 22);
            this.chkDitheringEnabled.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkDitheringEnabled.Name = "chkDitheringEnabled";
            this.chkDitheringEnabled.Size = new System.Drawing.Size(120, 19);
            this.chkDitheringEnabled.TabIndex = 3;
            this.chkDitheringEnabled.Text = "Dithering enabled";
            this.chkDitheringEnabled.ThreeState = true;
            this.chkDitheringEnabled.UseVisualStyleBackColor = true;
            this.chkDitheringEnabled.CheckStateChanged += new System.EventHandler(this.chkDitheringEnabled_CheckStateChanged);
            // 
            // pbGradient
            // 
            this.pbGradient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGradient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGradient.Location = new System.Drawing.Point(7, 106);
            this.pbGradient.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbGradient.Name = "pbGradient";
            this.pbGradient.Size = new System.Drawing.Size(611, 236);
            this.pbGradient.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbGradient.TabIndex = 0;
            this.pbGradient.TabStop = false;
            // 
            // grpMiscellaneousOptions
            // 
            this.grpMiscellaneousOptions.Controls.Add(this.btnSetShortcutScreenSaver);
            this.grpMiscellaneousOptions.Controls.Add(this.label11);
            this.grpMiscellaneousOptions.Controls.Add(this.edtBlankScreenSaverShortcut);
            this.grpMiscellaneousOptions.Controls.Add(this.lblFixChromeFontsDescription);
            this.grpMiscellaneousOptions.Controls.Add(this.chkFixChromeFonts);
            this.grpMiscellaneousOptions.Location = new System.Drawing.Point(7, 332);
            this.grpMiscellaneousOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMiscellaneousOptions.Name = "grpMiscellaneousOptions";
            this.grpMiscellaneousOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpMiscellaneousOptions.Size = new System.Drawing.Size(467, 150);
            this.grpMiscellaneousOptions.TabIndex = 5;
            this.grpMiscellaneousOptions.TabStop = false;
            this.grpMiscellaneousOptions.Text = "Miscellaneous";
            // 
            // btnSetShortcutScreenSaver
            // 
            this.btnSetShortcutScreenSaver.Location = new System.Drawing.Point(180, 104);
            this.btnSetShortcutScreenSaver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSetShortcutScreenSaver.Name = "btnSetShortcutScreenSaver";
            this.btnSetShortcutScreenSaver.Size = new System.Drawing.Size(40, 27);
            this.btnSetShortcutScreenSaver.TabIndex = 10;
            this.btnSetShortcutScreenSaver.Text = "Set";
            this.btnSetShortcutScreenSaver.UseVisualStyleBackColor = true;
            this.btnSetShortcutScreenSaver.Click += new System.EventHandler(this.btnSetShortcutScreenSaver_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 85);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 15);
            this.label11.TabIndex = 9;
            this.label11.Text = "Set a shortcut to start the blank screensaver:";
            // 
            // edtBlankScreenSaverShortcut
            // 
            this.edtBlankScreenSaverShortcut.Location = new System.Drawing.Point(7, 106);
            this.edtBlankScreenSaverShortcut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtBlankScreenSaverShortcut.Name = "edtBlankScreenSaverShortcut";
            this.edtBlankScreenSaverShortcut.ReadOnly = true;
            this.edtBlankScreenSaverShortcut.Size = new System.Drawing.Size(165, 23);
            this.edtBlankScreenSaverShortcut.TabIndex = 7;
            this.edtBlankScreenSaverShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyDown);
            this.edtBlankScreenSaverShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtShortcut_KeyUp);
            // 
            // lblFixChromeFontsDescription
            // 
            this.lblFixChromeFontsDescription.AutoSize = true;
            this.lblFixChromeFontsDescription.Location = new System.Drawing.Point(4, 45);
            this.lblFixChromeFontsDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFixChromeFontsDescription.Name = "lblFixChromeFontsDescription";
            this.lblFixChromeFontsDescription.Size = new System.Drawing.Size(427, 15);
            this.lblFixChromeFontsDescription.TabIndex = 6;
            this.lblFixChromeFontsDescription.Text = "This will add the parameter --disable-lcd-text to Chrome and requires elevation.";
            // 
            // chkFixChromeFonts
            // 
            this.chkFixChromeFonts.AutoSize = true;
            this.chkFixChromeFonts.Location = new System.Drawing.Point(7, 22);
            this.chkFixChromeFonts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkFixChromeFonts.Name = "chkFixChromeFonts";
            this.chkFixChromeFonts.Size = new System.Drawing.Size(378, 19);
            this.chkFixChromeFonts.TabIndex = 4;
            this.chkFixChromeFonts.Text = "ClearType: fix bad fonts in Chrome (turn on grayscale anti-aliasing)";
            this.chkFixChromeFonts.UseVisualStyleBackColor = true;
            this.chkFixChromeFonts.CheckedChanged += new System.EventHandler(this.chkFixChromeFonts_CheckedChanged);
            // 
            // grpLGOptions
            // 
            this.grpLGOptions.Controls.Add(this.lblGameBarShortcut);
            this.grpLGOptions.Controls.Add(this.edtLgGameBarShortcut);
            this.grpLGOptions.Controls.Add(this.lblLgOptionShutdownDelayHelp);
            this.grpLGOptions.Controls.Add(this.edtLgOptionShutdownDelay);
            this.grpLGOptions.Controls.Add(this.lblLgOptionShutdownDelay);
            this.grpLGOptions.Controls.Add(this.chkLgShowAdvancedActions);
            this.grpLGOptions.Controls.Add(this.btnLGTestPower);
            this.grpLGOptions.Controls.Add(this.lblLgMaxPowerOnRetriesDescription);
            this.grpLGOptions.Controls.Add(this.edtLgMaxPowerOnRetries);
            this.grpLGOptions.Controls.Add(this.lblLgMaxPowerOnRetries);
            this.grpLGOptions.Location = new System.Drawing.Point(7, 136);
            this.grpLGOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpLGOptions.Name = "grpLGOptions";
            this.grpLGOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpLGOptions.Size = new System.Drawing.Size(470, 190);
            this.grpLGOptions.TabIndex = 4;
            this.grpLGOptions.TabStop = false;
            this.grpLGOptions.Text = "LG controller";
            // 
            // lblGameBarShortcut
            // 
            this.lblGameBarShortcut.AutoSize = true;
            this.lblGameBarShortcut.Location = new System.Drawing.Point(201, 127);
            this.lblGameBarShortcut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGameBarShortcut.Name = "lblGameBarShortcut";
            this.lblGameBarShortcut.Size = new System.Drawing.Size(108, 15);
            this.lblGameBarShortcut.TabIndex = 59;
            this.lblGameBarShortcut.Text = "Game Bar shortcut:";
            // 
            // edtLgGameBarShortcut
            // 
            this.edtLgGameBarShortcut.Location = new System.Drawing.Point(307, 121);
            this.edtLgGameBarShortcut.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgGameBarShortcut.Name = "edtLgGameBarShortcut";
            this.edtLgGameBarShortcut.ReadOnly = true;
            this.edtLgGameBarShortcut.Size = new System.Drawing.Size(128, 23);
            this.edtLgGameBarShortcut.TabIndex = 58;
            this.edtLgGameBarShortcut.TextChanged += new System.EventHandler(this.edtLgGameBarShortcut_TextChanged);
            this.edtLgGameBarShortcut.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtLgGameBarShortcut_KeyDown);
            this.edtLgGameBarShortcut.KeyUp += new System.Windows.Forms.KeyEventHandler(this.edtLgGameBarShortcut_KeyUp);
            // 
            // lblLgOptionShutdownDelayHelp
            // 
            this.lblLgOptionShutdownDelayHelp.AutoSize = true;
            this.lblLgOptionShutdownDelayHelp.Location = new System.Drawing.Point(7, 94);
            this.lblLgOptionShutdownDelayHelp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgOptionShutdownDelayHelp.Name = "lblLgOptionShutdownDelayHelp";
            this.lblLgOptionShutdownDelayHelp.Size = new System.Drawing.Size(385, 15);
            this.lblLgOptionShutdownDelayHelp.TabIndex = 11;
            this.lblLgOptionShutdownDelayHelp.Text = "This delay may prevent the tv from powering off when restarting the pc.";
            // 
            // edtLgOptionShutdownDelay
            // 
            this.edtLgOptionShutdownDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edtLgOptionShutdownDelay.Location = new System.Drawing.Point(349, 68);
            this.edtLgOptionShutdownDelay.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgOptionShutdownDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edtLgOptionShutdownDelay.Name = "edtLgOptionShutdownDelay";
            this.edtLgOptionShutdownDelay.ReadOnly = true;
            this.edtLgOptionShutdownDelay.Size = new System.Drawing.Size(86, 23);
            this.edtLgOptionShutdownDelay.TabIndex = 10;
            this.edtLgOptionShutdownDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtLgOptionShutdownDelay.ValueChanged += new System.EventHandler(this.edtLgOptionShutdownDelay_ValueChanged);
            // 
            // lblLgOptionShutdownDelay
            // 
            this.lblLgOptionShutdownDelay.AutoSize = true;
            this.lblLgOptionShutdownDelay.Location = new System.Drawing.Point(7, 70);
            this.lblLgOptionShutdownDelay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgOptionShutdownDelay.Name = "lblLgOptionShutdownDelay";
            this.lblLgOptionShutdownDelay.Size = new System.Drawing.Size(249, 15);
            this.lblLgOptionShutdownDelay.TabIndex = 9;
            this.lblLgOptionShutdownDelay.Text = "Delay when shutting down/restarting pc (ms):";
            // 
            // chkLgShowAdvancedActions
            // 
            this.chkLgShowAdvancedActions.AutoSize = true;
            this.chkLgShowAdvancedActions.Location = new System.Drawing.Point(8, 155);
            this.chkLgShowAdvancedActions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkLgShowAdvancedActions.Name = "chkLgShowAdvancedActions";
            this.chkLgShowAdvancedActions.Size = new System.Drawing.Size(419, 19);
            this.chkLgShowAdvancedActions.TabIndex = 8;
            this.chkLgShowAdvancedActions.Text = "Show advanced actions under the Expert-button (InStart, Software Update)";
            this.chkLgShowAdvancedActions.UseVisualStyleBackColor = true;
            this.chkLgShowAdvancedActions.CheckedChanged += new System.EventHandler(this.chkLgShowAdvancedActions_CheckedChanged);
            // 
            // btnLGTestPower
            // 
            this.btnLGTestPower.Location = new System.Drawing.Point(8, 121);
            this.btnLGTestPower.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnLGTestPower.Name = "btnLGTestPower";
            this.btnLGTestPower.Size = new System.Drawing.Size(167, 27);
            this.btnLGTestPower.TabIndex = 6;
            this.btnLGTestPower.Text = "Test power off/on";
            this.btnLGTestPower.UseVisualStyleBackColor = true;
            this.btnLGTestPower.Click += new System.EventHandler(this.btnLGTestPower_Click);
            // 
            // lblLgMaxPowerOnRetriesDescription
            // 
            this.lblLgMaxPowerOnRetriesDescription.AutoSize = true;
            this.lblLgMaxPowerOnRetriesDescription.Location = new System.Drawing.Point(7, 46);
            this.lblLgMaxPowerOnRetriesDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgMaxPowerOnRetriesDescription.Name = "lblLgMaxPowerOnRetriesDescription";
            this.lblLgMaxPowerOnRetriesDescription.Size = new System.Drawing.Size(415, 15);
            this.lblLgMaxPowerOnRetriesDescription.TabIndex = 5;
            this.lblLgMaxPowerOnRetriesDescription.Text = "Retries are necessary to wait for the network link of your pc to be established. " +
    "";
            // 
            // edtLgMaxPowerOnRetries
            // 
            this.edtLgMaxPowerOnRetries.Location = new System.Drawing.Point(349, 20);
            this.edtLgMaxPowerOnRetries.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLgMaxPowerOnRetries.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.edtLgMaxPowerOnRetries.Name = "edtLgMaxPowerOnRetries";
            this.edtLgMaxPowerOnRetries.ReadOnly = true;
            this.edtLgMaxPowerOnRetries.Size = new System.Drawing.Size(86, 23);
            this.edtLgMaxPowerOnRetries.TabIndex = 1;
            this.edtLgMaxPowerOnRetries.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtLgMaxPowerOnRetries.ValueChanged += new System.EventHandler(this.edtLgPowerOnAfterResumeDelay_ValueChanged);
            // 
            // lblLgMaxPowerOnRetries
            // 
            this.lblLgMaxPowerOnRetries.AutoSize = true;
            this.lblLgMaxPowerOnRetries.Location = new System.Drawing.Point(7, 22);
            this.lblLgMaxPowerOnRetries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLgMaxPowerOnRetries.Name = "lblLgMaxPowerOnRetries";
            this.lblLgMaxPowerOnRetries.Size = new System.Drawing.Size(340, 15);
            this.lblLgMaxPowerOnRetries.TabIndex = 0;
            this.lblLgMaxPowerOnRetries.Text = "Maximum number of retries powering on after startup/resume:";
            // 
            // grpHDROptions
            // 
            this.grpHDROptions.Controls.Add(this.edtDelayDisplaySettings);
            this.grpHDROptions.Controls.Add(this.label6);
            this.grpHDROptions.Location = new System.Drawing.Point(481, 365);
            this.grpHDROptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpHDROptions.Name = "grpHDROptions";
            this.grpHDROptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpHDROptions.Size = new System.Drawing.Size(467, 83);
            this.grpHDROptions.TabIndex = 3;
            this.grpHDROptions.TabStop = false;
            this.grpHDROptions.Text = "HDR";
            this.grpHDROptions.Visible = false;
            // 
            // edtDelayDisplaySettings
            // 
            this.edtDelayDisplaySettings.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.edtDelayDisplaySettings.Location = new System.Drawing.Point(345, 20);
            this.edtDelayDisplaySettings.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtDelayDisplaySettings.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.edtDelayDisplaySettings.Name = "edtDelayDisplaySettings";
            this.edtDelayDisplaySettings.ReadOnly = true;
            this.edtDelayDisplaySettings.Size = new System.Drawing.Size(86, 23);
            this.edtDelayDisplaySettings.TabIndex = 1;
            this.edtDelayDisplaySettings.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.edtDelayDisplaySettings.ValueChanged += new System.EventHandler(this.edtDelayDisplaySettings_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Delay opening display settings (ms):";
            // 
            // grpGeneralOptions
            // 
            this.grpGeneralOptions.Controls.Add(this.chkGdiScaling);
            this.grpGeneralOptions.Controls.Add(this.chkCheckForUpdates);
            this.grpGeneralOptions.Controls.Add(this.chkMinimizeToSystemTray);
            this.grpGeneralOptions.Controls.Add(this.chkMinimizeOnClose);
            this.grpGeneralOptions.Controls.Add(this.chkStartMinimized);
            this.grpGeneralOptions.Controls.Add(this.chkStartAfterLogin);
            this.grpGeneralOptions.Location = new System.Drawing.Point(7, 7);
            this.grpGeneralOptions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpGeneralOptions.Name = "grpGeneralOptions";
            this.grpGeneralOptions.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpGeneralOptions.Size = new System.Drawing.Size(467, 122);
            this.grpGeneralOptions.TabIndex = 2;
            this.grpGeneralOptions.TabStop = false;
            this.grpGeneralOptions.Text = "General";
            // 
            // chkGdiScaling
            // 
            this.chkGdiScaling.AutoSize = true;
            this.chkGdiScaling.Location = new System.Drawing.Point(238, 75);
            this.chkGdiScaling.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkGdiScaling.Name = "chkGdiScaling";
            this.chkGdiScaling.Size = new System.Drawing.Size(197, 19);
            this.chkGdiScaling.TabIndex = 7;
            this.chkGdiScaling.Text = "Use GDI Scaling (requires restart)";
            this.chkGdiScaling.UseVisualStyleBackColor = true;
            this.chkGdiScaling.CheckedChanged += new System.EventHandler(this.chkGdiScaling_CheckedChanged);
            // 
            // chkCheckForUpdates
            // 
            this.chkCheckForUpdates.AutoSize = true;
            this.chkCheckForUpdates.Location = new System.Drawing.Point(238, 48);
            this.chkCheckForUpdates.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkCheckForUpdates.Name = "chkCheckForUpdates";
            this.chkCheckForUpdates.Size = new System.Drawing.Size(197, 19);
            this.chkCheckForUpdates.TabIndex = 6;
            this.chkCheckForUpdates.Text = "Automatically check for updates";
            this.chkCheckForUpdates.UseVisualStyleBackColor = true;
            this.chkCheckForUpdates.CheckedChanged += new System.EventHandler(this.chkCheckForUpdates_CheckedChanged);
            // 
            // chkMinimizeToSystemTray
            // 
            this.chkMinimizeToSystemTray.AutoSize = true;
            this.chkMinimizeToSystemTray.Location = new System.Drawing.Point(238, 22);
            this.chkMinimizeToSystemTray.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMinimizeToSystemTray.Name = "chkMinimizeToSystemTray";
            this.chkMinimizeToSystemTray.Size = new System.Drawing.Size(152, 19);
            this.chkMinimizeToSystemTray.TabIndex = 5;
            this.chkMinimizeToSystemTray.Text = "Minimize to system tray";
            this.chkMinimizeToSystemTray.UseVisualStyleBackColor = true;
            this.chkMinimizeToSystemTray.CheckedChanged += new System.EventHandler(this.chkMinimizeToSystemTray_CheckedChanged);
            // 
            // chkMinimizeOnClose
            // 
            this.chkMinimizeOnClose.AutoSize = true;
            this.chkMinimizeOnClose.Location = new System.Drawing.Point(7, 75);
            this.chkMinimizeOnClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkMinimizeOnClose.Name = "chkMinimizeOnClose";
            this.chkMinimizeOnClose.Size = new System.Drawing.Size(122, 19);
            this.chkMinimizeOnClose.TabIndex = 4;
            this.chkMinimizeOnClose.Text = "Minimize on close";
            this.chkMinimizeOnClose.UseVisualStyleBackColor = true;
            this.chkMinimizeOnClose.CheckedChanged += new System.EventHandler(this.chkMinimizeOnClose_CheckedChanged);
            // 
            // chkStartMinimized
            // 
            this.chkStartMinimized.AutoSize = true;
            this.chkStartMinimized.Location = new System.Drawing.Point(7, 48);
            this.chkStartMinimized.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkStartMinimized.Name = "chkStartMinimized";
            this.chkStartMinimized.Size = new System.Drawing.Size(109, 19);
            this.chkStartMinimized.TabIndex = 3;
            this.chkStartMinimized.Text = "Start minimized";
            this.chkStartMinimized.UseVisualStyleBackColor = true;
            // 
            // chkStartAfterLogin
            // 
            this.chkStartAfterLogin.AutoSize = true;
            this.chkStartAfterLogin.Location = new System.Drawing.Point(7, 22);
            this.chkStartAfterLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chkStartAfterLogin.Name = "chkStartAfterLogin";
            this.chkStartAfterLogin.Size = new System.Drawing.Size(183, 19);
            this.chkStartAfterLogin.TabIndex = 2;
            this.chkStartAfterLogin.Text = "Automatically start after login";
            this.chkStartAfterLogin.UseVisualStyleBackColor = true;
            this.chkStartAfterLogin.CheckedChanged += new System.EventHandler(this.chkStartAfterLogin_CheckedChanged);
            // 
            // tabLog
            // 
            this.tabLog.Controls.Add(this.btnClearLog);
            this.tabLog.Controls.Add(this.edtLog);
            this.tabLog.Location = new System.Drawing.Point(4, 24);
            this.tabLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabLog.Name = "tabLog";
            this.tabLog.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabLog.Size = new System.Drawing.Size(1114, 525);
            this.tabLog.TabIndex = 3;
            this.tabLog.Text = "Log";
            this.tabLog.UseVisualStyleBackColor = true;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Location = new System.Drawing.Point(7, 7);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(88, 27);
            this.btnClearLog.TabIndex = 2;
            this.btnClearLog.Text = "Clear log";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // edtLog
            // 
            this.edtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.edtLog.Location = new System.Drawing.Point(7, 40);
            this.edtLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.edtLog.MaxLength = 327670;
            this.edtLog.Multiline = true;
            this.edtLog.Name = "edtLog";
            this.edtLog.ReadOnly = true;
            this.edtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.edtLog.Size = new System.Drawing.Size(1098, 478);
            this.edtLog.TabIndex = 0;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.grpNVIDIAInfo);
            this.tabInfo.Controls.Add(this.groupBox3);
            this.tabInfo.Location = new System.Drawing.Point(4, 24);
            this.tabInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabInfo.Size = new System.Drawing.Size(1114, 525);
            this.tabInfo.TabIndex = 4;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // grpNVIDIAInfo
            // 
            this.grpNVIDIAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpNVIDIAInfo.Controls.Add(this.btnRefreshNVIDIAInfo);
            this.grpNVIDIAInfo.Controls.Add(this.tvNVIDIAInfo);
            this.grpNVIDIAInfo.Location = new System.Drawing.Point(463, 7);
            this.grpNVIDIAInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNVIDIAInfo.Name = "grpNVIDIAInfo";
            this.grpNVIDIAInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grpNVIDIAInfo.Size = new System.Drawing.Size(643, 511);
            this.grpNVIDIAInfo.TabIndex = 4;
            this.grpNVIDIAInfo.TabStop = false;
            this.grpNVIDIAInfo.Text = "NVIDIA info";
            // 
            // btnRefreshNVIDIAInfo
            // 
            this.btnRefreshNVIDIAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRefreshNVIDIAInfo.Location = new System.Drawing.Point(7, 478);
            this.btnRefreshNVIDIAInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRefreshNVIDIAInfo.Name = "btnRefreshNVIDIAInfo";
            this.btnRefreshNVIDIAInfo.Size = new System.Drawing.Size(88, 27);
            this.btnRefreshNVIDIAInfo.TabIndex = 1;
            this.btnRefreshNVIDIAInfo.Text = "Refresh";
            this.btnRefreshNVIDIAInfo.UseVisualStyleBackColor = true;
            this.btnRefreshNVIDIAInfo.Click += new System.EventHandler(this.btnRefreshNVIDIAInfo_Click);
            // 
            // tvNVIDIAInfo
            // 
            this.tvNVIDIAInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvNVIDIAInfo.Location = new System.Drawing.Point(7, 22);
            this.tvNVIDIAInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tvNVIDIAInfo.Name = "tvNVIDIAInfo";
            this.tvNVIDIAInfo.Size = new System.Drawing.Size(628, 448);
            this.tvNVIDIAInfo.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbPlugins);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblInfo);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(449, 254);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // lbPlugins
            // 
            this.lbPlugins.FormattingEnabled = true;
            this.lbPlugins.HorizontalScrollbar = true;
            this.lbPlugins.ItemHeight = 15;
            this.lbPlugins.Location = new System.Drawing.Point(10, 77);
            this.lbPlugins.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbPlugins.Name = "lbPlugins";
            this.lbPlugins.Size = new System.Drawing.Size(432, 169);
            this.lbPlugins.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 59);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(267, 15);
            this.label7.TabIndex = 2;
            this.label7.Text = "This app contains the following 3rd party plugins:";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(7, 23);
            this.lblInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(28, 15);
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Info";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1150, 580);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1140, 611);
            this.Name = "MainForm";
            this.Text = "ColorControl";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResizeBegin += new System.EventHandler(this.MainForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.MainForm_ResizeEnd);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tcMain.ResumeLayout(false);
            this.tabNVIDIA.ResumeLayout(false);
            this.tabNVIDIA.PerformLayout();
            this.mnuNvPresets.ResumeLayout(false);
            this.tabAMD.ResumeLayout(false);
            this.tabAMD.PerformLayout();
            this.mnuAmdPresets.ResumeLayout(false);
            this.tabLG.ResumeLayout(false);
            this.scLgController.Panel1.ResumeLayout(false);
            this.scLgController.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scLgController)).EndInit();
            this.scLgController.ResumeLayout(false);
            this.mnuLgExpert.ResumeLayout(false);
            this.mnuLgButtons.ResumeLayout(false);
            this.tabOptions.ResumeLayout(false);
            this.grpNvidiaOptions.ResumeLayout(false);
            this.grpNvidiaOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGradient)).EndInit();
            this.grpMiscellaneousOptions.ResumeLayout(false);
            this.grpMiscellaneousOptions.PerformLayout();
            this.grpLGOptions.ResumeLayout(false);
            this.grpLGOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtLgOptionShutdownDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLgMaxPowerOnRetries)).EndInit();
            this.grpHDROptions.ResumeLayout(false);
            this.grpHDROptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edtDelayDisplaySettings)).EndInit();
            this.grpGeneralOptions.ResumeLayout(false);
            this.grpGeneralOptions.PerformLayout();
            this.tabLog.ResumeLayout(false);
            this.tabLog.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.grpNVIDIAInfo.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabLG;
        private System.Windows.Forms.ListView lvNvPresets;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnNvPresetSave;
        private System.Windows.Forms.Label lblShortcut;
        private System.Windows.Forms.TextBox edtShortcut;
        private System.Windows.Forms.TabPage tabOptions;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.ContextMenuStrip mnuNvPresets;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetDithering;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetApplyDithering;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetDitheringEnabled;
        private System.Windows.Forms.ToolStripMenuItem mnuRefreshRate;
        private System.Windows.Forms.ToolStripMenuItem miRefreshRateIncluded;
        private System.Windows.Forms.ToolStripMenuItem miNvHDR;
        private System.Windows.Forms.ToolStripMenuItem miHDRIncluded;
        private System.Windows.Forms.ToolStripMenuItem miToggleHDR;
        private System.Windows.Forms.ToolStripMenuItem miHDREnabled;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnNvPresetDelete;
        private System.Windows.Forms.Button btnAddModesNv;
        private System.Windows.Forms.ToolStripMenuItem miNvApply;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.GroupBox grpGeneralOptions;
        private System.Windows.Forms.CheckBox chkStartMinimized;
        private System.Windows.Forms.CheckBox chkStartAfterLogin;
        private System.Windows.Forms.GroupBox grpHDROptions;
        private System.Windows.Forms.NumericUpDown edtDelayDisplaySettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem mnuNvDisplay;
        private System.Windows.Forms.ToolStripMenuItem miNvPrimaryDisplay;
        private System.Windows.Forms.TabPage tabLog;
        private System.Windows.Forms.TextBox edtLog;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbPlugins;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.GroupBox grpNVIDIAInfo;
        private System.Windows.Forms.TreeView tvNVIDIAInfo;
        private System.Windows.Forms.Button btnRefreshNVIDIAInfo;
        private System.Windows.Forms.ContextMenuStrip mnuLgButtons;
        private System.Windows.Forms.ToolStripMenuItem mnuNvPresetsColorSettings;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetColorSettings;
        private System.Windows.Forms.GroupBox grpLGOptions;
        private System.Windows.Forms.NumericUpDown edtLgMaxPowerOnRetries;
        private System.Windows.Forms.Label lblLgMaxPowerOnRetries;
        private System.Windows.Forms.Button btnLGTestPower;
        private System.Windows.Forms.Label lblLgMaxPowerOnRetriesDescription;
        private System.Windows.Forms.GroupBox grpMiscellaneousOptions;
        private System.Windows.Forms.CheckBox chkFixChromeFonts;
        private System.Windows.Forms.Label lblFixChromeFontsDescription;
        private System.Windows.Forms.Button btnSetShortcutScreenSaver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox edtBlankScreenSaverShortcut;
        private System.Windows.Forms.CheckBox chkMinimizeOnClose;
        private System.Windows.Forms.TabPage tabNVIDIA;
        private System.Windows.Forms.TabPage tabAMD;
        private System.Windows.Forms.Label lblErrorAMD;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.GroupBox grpNvidiaOptions;
        private System.Windows.Forms.PictureBox pbGradient;
        private System.Windows.Forms.Label lblDitheringMode;
        private System.Windows.Forms.ComboBox cbxDitheringMode;
        private System.Windows.Forms.Label lblDitheringBitDepth;
        private System.Windows.Forms.ComboBox cbxDitheringBitDepth;
        private System.Windows.Forms.CheckBox chkDitheringEnabled;
        private System.Windows.Forms.ToolStripMenuItem mnuNvDitheringBitDepth;
        private System.Windows.Forms.ToolStripMenuItem miNvDithering6bit;
        private System.Windows.Forms.ToolStripMenuItem miNvDithering8bit;
        private System.Windows.Forms.ToolStripMenuItem miNvDithering10bit;
        private System.Windows.Forms.ToolStripMenuItem mnuNvDitheringMode;
        private System.Windows.Forms.ToolStripMenuItem spatial1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spatial2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spatialDynamic2x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spatialStatic2x2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem temporalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miNvPresetApplyOnStartup;
        private System.Windows.Forms.ToolStripMenuItem mnuLgRcButtons;
        private System.Windows.Forms.ToolStripMenuItem mnuLgActions;
        private System.Windows.Forms.Button btnDeleteAmd;
        private System.Windows.Forms.Button btnCloneAmd;
        private System.Windows.Forms.Button btnAmdPresetSave;
        private System.Windows.Forms.Label lblAmdShortcut;
        private System.Windows.Forms.TextBox edtAmdShortcut;
        private System.Windows.Forms.Button btnChangeAmd;
        private System.Windows.Forms.ContextMenuStrip mnuAmdPresets;
        private System.Windows.Forms.ToolStripMenuItem miAmdApply;
        private System.Windows.Forms.ToolStripMenuItem miAmdPresetApplyOnStartup;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAmdDisplay;
        private System.Windows.Forms.ToolStripMenuItem miAmdPrimaryDisplay;
        private System.Windows.Forms.ToolStripMenuItem mnuAmdColorSettings;
        private System.Windows.Forms.ToolStripMenuItem miAmdColorSettingsIncluded;
        private System.Windows.Forms.ToolStripMenuItem mnuAmdRefreshRate;
        private System.Windows.Forms.ToolStripMenuItem miAmdRefreshRateIncluded;
        private System.Windows.Forms.ToolStripMenuItem mnuAmdDithering;
        private System.Windows.Forms.ToolStripMenuItem miAmdDitheringIncluded;
        private System.Windows.Forms.ToolStripMenuItem mnuAmdHDR;
        private System.Windows.Forms.ToolStripMenuItem miAmdHDRIncluded;
        private System.Windows.Forms.ToolStripMenuItem miAmdHDRToggle;
        private System.Windows.Forms.ToolStripMenuItem miAmdHDREnabled;
        private System.Windows.Forms.Button btnApplyAmd;
        private System.Windows.Forms.ListView lvAmdPresets;
        private System.Windows.Forms.Button btnAddAmd;
        private System.Windows.Forms.CheckBox chkMinimizeToSystemTray;
        private System.Windows.Forms.ToolStripMenuItem miNvCopyId;
        private System.Windows.Forms.Label lblNvPresetName;
        private System.Windows.Forms.TextBox edtNvPresetName;
        private System.Windows.Forms.Label lblAmdPresetName;
        private System.Windows.Forms.TextBox edtAmdPresetName;
        private System.Windows.Forms.ToolStripMenuItem miAmdCopyId;
        private System.Windows.Forms.SplitContainer scLgController;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxLgDevices;
        private System.Windows.Forms.Button btnLgDeviceConvertToCustom;
        private System.Windows.Forms.ComboBox cbxLgApps;
        private System.Windows.Forms.ListView lvLgPresets;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxLgPresetDevice;
        private System.Windows.Forms.Button btnDeleteLg;
        private System.Windows.Forms.Button btnApplyLg;
        private System.Windows.Forms.Label lblDeviceFilter;
        private System.Windows.Forms.Label lblLgPresetDevice;
        private System.Windows.Forms.Button btnAddLg;
        private System.Windows.Forms.TextBox edtShortcutLg;
        private System.Windows.Forms.TextBox edtLgDeviceFilter;
        private System.Windows.Forms.Button btnLgRemoveDevice;
        private System.Windows.Forms.Button btnLgRefreshApps;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLgAddDevice;
        private System.Windows.Forms.TextBox edtNameLg;
        private System.Windows.Forms.Button btnSetShortcutLg;
        private System.Windows.Forms.TextBox edtStepsLg;
        private System.Windows.Forms.Button btnLgAddButton;
        private System.Windows.Forms.Button btnCloneLg;
        private System.Windows.Forms.Label lblStepsLg;
        private System.Windows.Forms.Button btnLgDeviceFilterRefresh;
        private System.Windows.Forms.CheckedListBox clbLgPower;
        private System.Windows.Forms.Label lblLgError;
        private System.Windows.Forms.CheckBox chkLgRemoteControlShow;
        private System.Windows.Forms.Button btnLgExpert;
        private System.Windows.Forms.ContextMenuStrip mnuLgExpert;
        private System.Windows.Forms.ToolStripMenuItem mnuLgOLEDMotionPro;
        private System.Windows.Forms.ToolStripMenuItem miLgEnableMotionPro;
        private System.Windows.Forms.ToolStripMenuItem miLgDisableMotionPro;
        private System.Windows.Forms.ToolStripSeparator miLgExpertSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuLgNvPresets;
        private System.Windows.Forms.ToolStripMenuItem mnuLgAmdPresets;
        private System.Windows.Forms.ComboBox cbxLgPresetTrigger;
        private System.Windows.Forms.Label lblLgPresetTrigger;
        private System.Windows.Forms.Label lblLgPresetTriggerCondition;
        private System.Windows.Forms.Label lblLgPresetExcludedProcesses;
        private System.Windows.Forms.TextBox edtLgPresetExcludedProcesses;
        private System.Windows.Forms.Label lblLgPresetIncludedProcesses;
        private System.Windows.Forms.TextBox edtLgPresetIncludedProcesses;
        private System.Windows.Forms.Button btnLgPresetEditTriggerConditions;
        private System.Windows.Forms.TextBox edtLgPresetTriggerConditions;
        private System.Windows.Forms.CheckBox chkCheckForUpdates;
        private System.Windows.Forms.CheckBox chkLgShowAdvancedActions;
        private System.Windows.Forms.Button btnLgGameBar;
        private System.Windows.Forms.CheckBox chkGdiScaling;
        private System.Windows.Forms.Button btnLgDeviceOptionsHelp;
        private System.Windows.Forms.Label lblLgOptionShutdownDelayHelp;
        private System.Windows.Forms.NumericUpDown edtLgOptionShutdownDelay;
        private System.Windows.Forms.Label lblLgOptionShutdownDelay;
        private System.Windows.Forms.TextBox edtLgPresetDescription;
        private System.Windows.Forms.Label lblLgPresetDescription;
        private System.Windows.Forms.Label lblGameBarShortcut;
        private System.Windows.Forms.TextBox edtLgGameBarShortcut;
        private System.Windows.Forms.ComboBox cbxLgPcHdmiPort;
        private System.Windows.Forms.Label lblLgPcHdmiPort;
    }
}

