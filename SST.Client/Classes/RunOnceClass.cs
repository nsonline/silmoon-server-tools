using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Configuration;

namespace SST.Client.Classes
{
    public class RunOnceClass
    {
        GBC _g;
        Thread _th;
        Logger _log;
        public RunOnceClass(GBC g)
        {
            _g = g;
            _log = _g.LoggerObj;
            AsyncRun();
        }
        public void AsyncRun()
        {
            _g.LoggerObj.WriteLogLine("初始化线程启动...");
            _th = new Thread(RunProcess);
            _th.IsBackground = true;
            _th.Start();
        }
        public void RunProcess()
        {
            Thread.Sleep(1500);
            try
            {
                _g.Reg.WriteKey("AppPath", Application.ExecutablePath, Microsoft.Win32.RegistryValueKind.String);
                ((MainForm)_g.MainForm).Text += " - " + _g.RConfigIni.ReadInivalue("Config", "SpecialTitle");
                Thread.Sleep(500);
                new UpdateClass(_g);
                new Thread(new DetectSmSvrServ(_g).Start).Start();
                _g.LoggerObj.WriteLogLine("初始化线程完毕！");
                if (_g.Encrydocuments.ReadString("SpecialID") != "0" && _g.Encrydocuments.ReadString("SpecialID") != "")
                    _g.LoggerObj.WriteLogLine("你使用的是 " + _g.RConfigIni.ReadInivalue("Config", "SpecialTitle"));
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
    }
}