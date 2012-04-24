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
            _g.LoggerObj.WriteLogLine("����������...");
            _th.Start();
        }
        private void CheckProcess()
        {
            _log.WriteLogLine("��ʼ����°汾����...");
            UpdateTray.Visible = true;
            UpdateTray.ShowBalloonTip(1000, "��ʾ", "�����������...", ToolTipIcon.Info);
            Thread.Sleep(2000);
            UpdateTray.Visible = true;

            UpdateTray.ShowBalloonTip(2000, "��ʾ", "���ذ汾 " + _g.GetAppVersion.ToString() + " Զ�̰汾��ȡ��...", ToolTipIcon.Info);
            Thread.Sleep(1000);
            UpdateTray.Visible = true;

            _log.WriteLogLine("�汾:���� " + _g.GetAppVersion.ToString() + " Զ�� " + _g.GetRomoteAppVersion.ToString());

            UpdateTray.ShowBalloonTip(2000, "��ʾ", "���ذ汾 " + _g.GetAppVersion.ToString() + " Զ�̰汾 " + _g.GetRomoteAppVersion.ToString(), ToolTipIcon.Info);
            UpdateTray.Visible = true;

            if (_g.GetAppVersion == _g.GetRomoteAppVersion)
            {
                _log.WriteLogLine("�Ѿ����°汾����������");
                UpdateTray.ShowBalloonTip(2000, "��ʾ", "�汾��֤��ɣ�", ToolTipIcon.Info);
                Thread.Sleep(1000);
            }
            else if (string.IsNullOrEmpty(_g.GetRomoteAppVersion))
            {
                _log.WriteLogLine("���ʧ�ܣ���������");
                UpdateTray.ShowBalloonTip(2000, "��ʾ", "�汾��֤ʧ�ܣ�", ToolTipIcon.Info);
                Thread.Sleep(1000);
            }
            else
                UpdateProcess();
        }

        private void UpdateProcess()
        {
            _log.WriteLogLine("��ʼ���°汾����ʼ��������");

            UpdateTray.ShowBalloonTip(3000, "��ʾ", "��ʼ����...", ToolTipIcon.Info);
            WebClient _w = new WebClient();
            try
            {
                _w.DownloadFile("http://client.silmoon.com/update/Silmoon.Update.App.exe", Application.StartupPath + "\\Silmoon.Update.App.exe");
                _log.WriteLogLine("��ʼ����ɣ���ʼ����...");
                _log.WriteLogLine("�������̳��򼴽��˳�...");
                UpdateTray.ShowBalloonTip(3000, "��ʾ", "�������̳��򼴽��˳�...", ToolTipIcon.Info);
                Thread.Sleep(2000);
                Process.Start(Application.StartupPath + "\\Silmoon.Update.App.exe", " --version=" + _g.GetAppVersion);
                _g.ExitApp();
            }
            catch { }
        }
    }
}