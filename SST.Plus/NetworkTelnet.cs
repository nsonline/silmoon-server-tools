using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Silmoon.Service;
using System.Threading;
using System.Diagnostics;
using System.IO;
using Silmoon;
using Silmoon.Net;
using System.ServiceProcess;
using SST.Plus;
using Silmoon.Windows.Win32.API;
using Silmoon.Windows.Systems;

namespace SST.Network
{
    public class NetworkTelnet : MarshalByRefObject, SST.Common.ISSTPlus, IDisposable
    {
        public readonly string _plusName = "NetworkTelnet";
        public bool NetWorked = false;
        GBC _g;
        Silmoon.Service.ServiceControl _ssvc;
        void _ssvc_OnServiceStateChange(object sender, SmServiceEventArgs e)
        {
            if (_tcp.Connected)
            {
                if (e.CompleteState == ServiceCompleteStateType.Trying)
                    _tcp.SendString(e.ServiceName + "|" + e.ServiceOption.ToString() + "...");
                else
                {
                    if (e.Error != null)
                    { _tcp.SendString(e.ServiceName + "|" + e.ServiceOption.ToString() + " error!"); }
                    else
                    { _tcp.SendString(e.ServiceName + "|" + e.ServiceOption.ToString() + " completed"); }
                }
            }
        }

        bool _logined = false;
        string _version = "1";

        SmTcp _tcp = new SmTcp();


        public NetworkTelnet()
        {

        }

        public void Start()
        {
            _ssvc = _g.ServiceCtrl;
            _tcp.AsyncStartListen(IPAddress.Any, int.Parse(_g.ConfigIni.ReadInivalue(PlusName, "NetPort")));
            _tcp.OnTcpEvents += new TcpOptionEventHander(_tcp_OnTcpEvents);
            _tcp.OnReceivedData += new TcpReceiveDataEventHander(_tcp_OnReceivedData);
            _tcp.OnError += new TcpOnErrorEventHander(_tcp_OnError);
            _ssvc.OnServiceStateChange += new SmServiceEventHandler(sc_OnServiceStateChange);
        }
        void sc_OnServiceStateChange(object sender, SmServiceEventArgs e)
        {
            if (_tcp.Connected)
            {
                _tcp.SendString("服务::消息::" + e.ServiceName + "::" + e.ServiceOption.ToString() + "::" + e.CompleteState.ToString());
            }
        }
        void _tcp_OnReceivedData(TcpStruct localTcpInfo, TcpStruct remoteTcpInfo, byte[] data, ITcpReader tcpReader)
        {
            string cmdData = _tcp.DataEncoding.GetString(data);
            if (_logined)
            {
                string[] cmdArr = cmdData.Split(new string[] { " " }, StringSplitOptions.None);
                CmdProcess(cmdData, cmdArr, tcpReader);
            }
            else
                if (cmdData == _g.Reg.ReadKey("Password").ToString())
                {
                    _logined = true;
                    _tcp.SendString("已经登录!", tcpReader.ClientID);
                    _tcp.SendString("协议版本:" + _version, tcpReader.ClientID);
                    _g.LoggerObj.WriteLogLine("(NET)用户密码以正确验证!");
                }
                else
                {
                    _logined = false;
                    _tcp.SendString("请输入密码:", tcpReader.ClientID);
                }
        }
        void _tcp_OnTcpEvents(TcpStruct localTcpInfo, TcpStruct remoteTcpInfo, TcpOptionType type, ITcpReader tcpReader)
        {
            switch (type)
            {
                case TcpOptionType.ClientConnected:
                    _g.LoggerObj.WriteLogLine("(NET)客户连接(" + remoteTcpInfo.IP.ToString() + ":" + remoteTcpInfo.Port.ToString() + ")...");
                    _tcp.SendString("银月服务器工具(NetworkTelnet)插件 已连接", tcpReader.ClientID);
                    _tcp.SendString("请输入连接密码:", tcpReader.ClientID);

                    break;
                case TcpOptionType.Connected:
                    _g.LoggerObj.WriteLogLine("(NET)连接至(" + remoteTcpInfo.IP.ToString() + ":" + remoteTcpInfo.Port.ToString() + ")...");
                    break;
                case TcpOptionType.Disconnected:
                    _logined = false;
                    _g.LoggerObj.WriteLogLine("(NET)客户端丢失连接...");
                    break;
                case TcpOptionType.StartListen:
                    _g.LoggerObj.WriteLogLine("(NET)开始监听(on port " + localTcpInfo.Port.ToString() + ")...");
                    break;
                default:
                    break;
            }
        }
        void _tcp_OnError(TcpStruct localTcpInfo, TcpStruct remoteTcpInfo, TcpError Error, Exception ex, TcpOptionType type, ITcpReader tcpReader)
        {
            _g.LoggerObj.WriteLogLine("(NET)错误：" + Error.ToString());
        }

        private void CmdProcess(string cmdText, string[] cmdArr, ITcpReader tcpReader)
        {
            if (cmdArr.Length > 1)
            {
                switch (cmdArr[0])
                {
                    case "service":
                        Cmd_Service(cmdText, cmdArr, tcpReader);
                        break;
                    case "system":
                        Cmd_System(cmdText, cmdArr, tcpReader);
                        break;
                    default:
                        break;
                }
            }
            else
                NetworkTelnetCmd(cmdText);
        }

        private void NetworkTelnetCmd(string cmdText)
        {
            switch (cmdText.ToLower())
            {
                case "noop":
                    _tcp.SendString("command error");
                    break;
                case "exit":
                    _tcp.CloseConnect();
                    break;
                default:
                    break;
            }
        }


        private void Cmd_Service(string cmdText, string[] cmdArr, ITcpReader tcpReader)
        {
            if (cmdArr.Length < 2)
            {
                _tcp.SendString("服务命令错误!");
                return;
            }

            switch (cmdArr[1])
            {
                case "start":
                    _ssvc.AsyncService(cmdArr[2], ServiceOptions.Start);
                    break;
                case "stop":
                    _ssvc.AsyncService(cmdArr[2], ServiceOptions.Stop);
                    break;
                case "restart":
                    _ssvc.AsyncService(cmdArr[2], ServiceOptions.Reset);
                    break;
                case "getlist":
                    Cmd_Service_GetList(tcpReader);
                    break;
                default:
                    break;
            }
        }
        private void Cmd_Service_GetList(ITcpReader tcpReader)
        {
            ServiceController[] svcArr = ServiceController.GetServices();
            _tcp.SendString("服务::开始列表");
            foreach (ServiceController svc in svcArr)
            {
                _tcp.SendString("服务::服务名::" + svc.ServiceName);
            }
            _tcp.SendString("服务::结束列表");
        }
        private void Cmd_System(string cmdText, string[] cmdArr, ITcpReader tcpReader)
        {
            if (cmdArr.Length < 2)
            {
                _tcp.SendString("系统命令错误!");
                return;
            }

            switch (cmdArr[1])
            {
                case "shutdown":
                    Cmd_System_Shutdown(cmdText, cmdArr, tcpReader); break;
                case "getprocesslist":
                    Cmd_System_GetProcessList(cmdText, cmdArr, tcpReader); break;
                default:
                    break;
            }
        }
        private void Cmd_System_Shutdown(string cmdText, string[] cmdArr, ITcpReader tcpReader)
        {
            switch (cmdArr[2])
            {
                case "shutdown":
                    SystemController.ShutdownLocalhost(ShutdownEnum.ExitWindows.Force | ShutdownEnum.ExitWindows.ShutDown, ShutdownEnum.ShutdownReason.MinorTermSrv);
                    break;
                case "reboot":
                    SystemController.ShutdownLocalhost(ShutdownEnum.ExitWindows.Force | ShutdownEnum.ExitWindows.Reboot, ShutdownEnum.ShutdownReason.MinorTermSrv);
                    break;
                default:
                    break;
            }
        }
        private void Cmd_System_GetProcessList(string cmdText, string[] cmdArr, ITcpReader tcpReader)
        {
            Process[] pArr = Process.GetProcesses();
            _tcp.SendString("系统::进程::开始列表");
            foreach (Process p in pArr)
            {
                _tcp.SendString("系统::进程::名称::" + p.ProcessName);
            }
            _tcp.SendString("系统::进程::结束列表");
        }


        #region IDisposable 成员

        public void Dispose()
        {
            GC.ReRegisterForFinalize(this);
            _ssvc.OnServiceStateChange -= new SmServiceEventHandler(sc_OnServiceStateChange);
            _tcp.Dispose();
        }

        #endregion

        #region ISSTPlus 成员

        public void InitPlus(GBC g)
        {
            _g = g;
            Start();
        }

        public bool StopPlus()
        {
            return false;
        }

        public void ShowPlus()
        {
            new NetworkTelnetForm(PlusName, _version, _tcp.LocalTcpStruct.Port.ToString(), _g);
        }

        public bool RemovePlus()
        {
            _g.LoggerObj.WriteLogLine("(NET)" + PlusName + " 遭到卸载!");
            Dispose();
            return true;
        }

        public string PlusName
        {
            get { return _plusName; }
        }

        #endregion
    }
}