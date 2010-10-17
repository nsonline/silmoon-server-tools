using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Windows.Forms;
using Silmoon.Windows.Win32.Hooking;

namespace SST.Client.Classes
{
    class BackEvents
    {
        GBC _g;
        bool BeforeShowKeyDown = false;
        GlobalKeyBoardHook HookKey = new GlobalKeyBoardHook();
        public BackEvents(GBC g)
        {
            _g = g;
            InitClass();
        }
        private void InitClass()
        {
            SystemEvents.SessionEnding += new SessionEndingEventHandler(SystemEvents_SessionEnding);
            _g.ServiceCtrl.OnServiceStateChange += new Silmoon.Service.SmServiceEventHandler(ServiceCtrl_OnServiceStateChange);
            _g.OnAppExit += new EventHandler(_g_OnAppExit);
            HookKey.OnKeyDownEvent += new KeyEventHandler(HookKey_OnKeyDownEvent);
            HookKey.OnKeyPressEvent += new KeyPressEventHandler(HookKey_OnKeyPressEvent);
            HookKey.OnKeyUpEvent += new KeyEventHandler(HookKey_OnKeyUpEvent);
            HookKey.Start();
        }

        void HookKey_OnKeyUpEvent(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Control && e.KeyCode.ToString() == "S")
            {
                BeforeShowKeyDown = true;
                _g.Tray.ShowBalloonTip(1, "��ʾ", "����'t'�ص�SST�����ڣ�", ToolTipIcon.Info);
            }
        }
        void HookKey_OnKeyPressEvent(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString().ToLower() == "t" && BeforeShowKeyDown)
            {
                MainForm mf = (MainForm)_g.MainForm as MainForm;
                mf.MainTray_DoubleClick(this, e);
            }
            BeforeShowKeyDown = false;
        }
        void HookKey_OnKeyDownEvent(object sender, KeyEventArgs e)
        {
            
        }

        void _g_OnAppExit(object sender, EventArgs e)
        {
            HookKey.Stop();
        }

        void ServiceCtrl_OnServiceStateChange(object sender, Silmoon.Service.SmServiceEventArgs e)
        {
            _g.Tray.ShowBalloonTip(1000, "�����¼�", "����'" + e.ServiceName + "'����'" + e.ServiceOption.ToString() + "'״̬'" + e.CompleteState.ToString() + "'", ToolTipIcon.Info);
        }
        void SystemEvents_SessionEnding(object sender, SessionEndingEventArgs e)
        {
            _g.LoggerObj.WriteLogLine("�յ�ϵͳ�Ự������Ϣ...");
            _g.LoggerObj.WriteLogLine("����ϵͳ�Ự����������رգ�");
            _g.ExitApp();
        }
    }
}
