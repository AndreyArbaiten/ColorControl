﻿using ColorControl.Shared.Common;
using ColorControl.Shared.Forms;
using ColorControl.Shared.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Threading.Tasks;

namespace ColorControl.Services.EventDispatcher
{
    public class ProcessChangedEventArgs : EventArgs
    {
        public IList<Process> StartedProcesses { get; set; }
        public IList<Process> StoppedProcesses { get; set; }
        public IList<Process> RunningProcesses { get; set; }
        public bool IsNotificationDisabled { get; set; }
        public Process ForegroundProcess { get; set; }
        public bool ForegroundProcessIsFullScreen { get; set; }
        public string LastFullScreenProcessName = string.Empty;
        public bool StoppedFullScreen { get; set; }
        public bool IsScreenSaverActive { get; set; }
    }


    public class ProcessEventDispatcher : EventDispatcher<ProcessChangedEventArgs>
    {
        public const string Event_ProcessChanged = "ProcessChanged";
        public bool IsRunning { get; set; }
        public ProcessChangedEventArgs MonitorContext { get; private set; }

        protected static readonly NLog.Logger Logger = NLog.LogManager.GetCurrentClassLogger();

        private AppContextProvider _appContextProvider { get; }

        public ProcessEventDispatcher(AppContextProvider appContextProvider)
        {
            _appContextProvider = appContextProvider;

            IsRunning = true;

            //Task.Run(async () => await CheckProcesses());

            var _ = CheckProcesses();
        }

        private async Task CheckProcesses()
        {
            await Task.Delay(2000);

            //var startWatch = new ManagementEventWatcher("SELECT * FROM Win32_ProcessStartTrace");
            //startWatch.EventArrived += startWatch_EventArrived;
            //startWatch.Start();

            MonitorContext ??= new ProcessChangedEventArgs();

            while (IsRunning)
            {
                await Task.Delay(_appContextProvider.GetAppContext().Config.ProcessMonitorPollingInterval);

                if (!HasHandlers(Event_ProcessChanged))
                {
                    continue;
                }

                try
                {
                    FillContext(MonitorContext);

                    // Ignore if own process has the foreground
                    if (MonitorContext.ForegroundProcess?.Id == Environment.ProcessId)
                    {
                        continue;
                    }

                    await DispatchEventAsync(Event_ProcessChanged, MonitorContext);
                    DispatchEvent(Event_ProcessChanged, MonitorContext);
                }
                catch (Exception ex)
                {
                    Logger.Error("CheckProcesses: " + ex.ToLogString());
                }
            }
        }

        private void FillContext(ProcessChangedEventArgs context)
        {
            var processes = Process.GetProcesses();

            context.StartedProcesses = processes.Where(p => context.RunningProcesses?.Any(rp => rp.Id == p.Id) == false).ToList();
            context.StoppedProcesses = context.RunningProcesses?.Where(p => processes.Any(rp => rp.Id == p.Id) == false).ToList();
            context.RunningProcesses = processes;

            context.IsNotificationDisabled = FormUtils.IsNotificationDisabled();

            var (processId, isFullScreen) = FormUtils.GetForegroundProcessIdAndIfFullScreen();

            if (processId > 0)
            {
                var process = context.RunningProcesses.FirstOrDefault(p => p.Id == processId);

                context.IsScreenSaverActive = process?.ProcessName?.Contains(".scr") == true;
                context.ForegroundProcess = process;
                context.ForegroundProcessIsFullScreen = isFullScreen;

                if (isFullScreen)
                {
                    context.LastFullScreenProcessName = context.ForegroundProcess.ProcessName;
                    //Logger.Debug($"Foreground fullscreen app detected: {context.ForegroundProcess.ProcessName}");
                }
            }
            else
            {
                context.StoppedFullScreen = context.ForegroundProcessIsFullScreen;
                context.ForegroundProcess = null;
                context.ForegroundProcessIsFullScreen = false;
                context.LastFullScreenProcessName = string.Empty;
            }
        }

        private void startWatch_EventArrived(object sender, EventArrivedEventArgs e)
        {
            //Logger.Debug("Process started: " + e.NewEvent.Properties["ProcessName"].Value);
        }
    }
}
