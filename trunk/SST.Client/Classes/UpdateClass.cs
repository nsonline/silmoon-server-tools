using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Net;

namespace SST.Client.Classes
{
    public class UpdateClass
    {
        GBC _g;
        Thread _th;
        NotifyIcon UpdateTray;
        Logger _log;
        public UpdateClass(GBC g)
        {
            _g = g;
            _log = ((Logger)_g.LoggerObj);
            UpdateTray = ((NotifyIcon)_g.Tray);
            _th = new Thread(CheckProcess);
            _th.IsBackground = true;
            _g.LoggerObj.WriteLogLine("升级类启动...");
            _th.Start();
        }
        private void CheckProcess()
        {
            _log.WriteLogLine("开始检查新版本程序...");
            UpdateTray.Visible = true;
            UpdateTray.ShowBalloonTip(1000, "提示", "升级组件启动...", ToolTipIcon.Info);
            Thread.Sleep(2000);
            UpdateTray.Visible = true;

            UpdateTray.ShowBalloonTip(2000, "提示", "本地版本 " + _g.GetAppVersion.ToString() + " 远程版本获取中...", ToolTipIcon.Info);
            Thread.Sleep(1000);
            UpdateTray.Visible = true;

            _log.WriteLogLine("版本:本地 " + _g.GetAppVersion.ToString() + " 远程 " + _g.GetRomoteAppVersion.ToString());

            UpdateTray.ShowBalloonTip(2000, "提示", "本地版本 " + _g.GetAppVersion.ToString() + " 远程版本 " + _g.GetRomoteAppVersion.ToString(), ToolTipIcon.Info);
            UpdateTray.Visible = true;

            if (_g.GetAppVersion == _g.GetRomoteAppVersion)
            {
                _log.WriteLogLine("已经是新版本，检查结束。");
                UpdateTray.ShowBalloonTip(2000, "提示", "版本验证完成！", ToolTipIcon.Info);
                Thread.Sleep(1000);
            }
            else if (string.IsNullOrEmpty(_g.GetRomoteAppVersion))
            {
                _log.WriteLogLine("检查失败，检查结束。");
                UpdateTray.ShowBalloonTip(2000, "提示", "版本验证失败！", ToolTipIcon.Info);
                Thread.Sleep(1000);
            }
            else
                UpdateProcess();
        }

        private void UpdateProcess()
        {
            _log.WriteLogLine("开始有新版本，开始升级过程");

            UpdateTray.ShowBalloonTip(3000, "提示", "开始升级...", ToolTipIcon.Info);
            WebClient _w = new WebClient();
            try
            {
                _w.DownloadFile("http://client.silmoon.com/update/Silmoon.Update.App.exe", Application.StartupPath + "\\Silmoon.Update.App.exe");
                _log.WriteLogLine("初始化完成，开始升级...");
                _log.WriteLogLine("升级过程程序即将退出...");
                UpdateTray.ShowBalloonTip(3000, "提示", "升级过程程序即将退出...", ToolTipIcon.Info);
                Thread.Sleep(2000);
                Process.Start(Application.StartupPath + "\\Silmoon.Update.App.exe", " --version=" + _g.GetAppVersion);
                _g.ExitApp();
            }
            catch { }
        }
    }
}