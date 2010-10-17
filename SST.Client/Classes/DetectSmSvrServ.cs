using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Silmoon.Service;
using Silmoon.Net;
using Silmoon.Configure;
using System.Net;
using System.Windows.Forms;
using System.ServiceProcess;
using Silmoon;

namespace SST.Client.Classes
{
    class DetectSmSvrServ:IDisposable
    {
        SmTcp _tcp;
        GBC _g;
        Silmoon.Security.CSEncrypt sce = new Silmoon.Security.CSEncrypt();
        string receivedString = "";
        public DetectSmSvrServ(GBC g)
        {
            _g = g;
        }
        public void Start()
        {
            try
            {
                Thread.Sleep(4000);
                if (!ServiceControl.IsExisted("smsvrserv"))
                    return;
                ServiceController sc = new ServiceController("smsvrserv");
                if (sc.Status != ServiceControllerStatus.Running)
                    return;

                IniFile ini = new IniFile(@"c:\windows\system32\smsvrserv.ini");
                if (!SmString.StringToBool(ini.ReadInivalue("Server", "NetCmdEnable")))
                    return;

                _tcp = new SmTcp();
                _tcp.OnReceivedData += new TcpReceiveDataEventHander(_tcp_OnReceivedData);
                int port = int.Parse(ini.ReadInivalue("Server", "NetCmdPort"));
                TcpResult result = _tcp.ConnectTo(IPAddress.Loopback, port);
                Thread.Sleep(1000);
                if (GetReceived() != "system`smsvrserv_connected")
                {
                    _g.LoggerObj.WriteLogLine("(SVR)不可识别的SmSvrServ,请升级到最新版本!");
                    _g.LoggerObj.WriteLogLine("(WAR)请先卸载SmSvrServ重新点击安装!");
                    _tcp.CloseConnect();
                    Dispose();
                    return;
                }
                _g.LoggerObj.WriteLogLine("(SVR)检查SmSvrServ的版本与安全性.");
                _tcp.SendString("system`loginsmsvrserv`" + sce.Decrypto(ini.ReadInivalue("Server", "NetCmdPassword")));
                Thread.Sleep(1000);

                string s = GetReceived();
                if (s == "system`systemmessage`requireversion`6")
                {
                    _g.LoggerObj.WriteLogLine("(SVR)检查到版本6的SmSvrServ.");
                }
            }
            catch { }
            Dispose();
        }

        void _tcp_OnReceivedData(TcpStruct localTcpInfo, TcpStruct remoteTcpInfo, byte[] data, ITcpReader tcpReader)
        {
            receivedString = _tcp.DataEncoding.GetString(data);
        }
        string GetReceived()
        {
            string s = receivedString;
            receivedString = "";
            return s;
        }

        #region IDisposable 成员

        public void Dispose()
        {
            _tcp.OnReceivedData -= new TcpReceiveDataEventHander(_tcp_OnReceivedData);
            _tcp.CloseConnect();
            _tcp.Dispose();
        }

        #endregion
    }
}
