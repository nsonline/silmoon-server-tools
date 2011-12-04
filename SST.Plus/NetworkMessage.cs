using System;
using System.Collections.Generic;
using System.Text;
using SST.Common;
using Silmoon.Net;
using System.Net;
using System.Collections;
using Silmoon;

namespace SST.Plus
{
    public class NetworkMessage : IDisposable, ISSTPlus
    {
        public readonly string _plusName = "NetworkMessage";
        SmTcp _tcp = new SmTcp();
        GBC _g;
        ArrayList _netUnit = new ArrayList();

        public NetworkMessage()
        {
            _tcp.OnReceivedData += new TcpReceiveDataEventHander(_tcp_OnReceivedData);
            _tcp.OnConnectionEvent += new TcpOnConnectionEventHander(_tcp_OnConnectionEvent);
        }

        void _tcp_OnConnectionEvent(TcpStruct localTcpInfo, TcpStruct remoteTcpInfo, ITcpReader tcpReader, int clientID)
        {
            if (tcpReader != null)
            {
                _tcp.SendString("message`needname", tcpReader.ClientID);
            }
        }

        void _tcp_OnReceivedData(TcpStruct localTcpInfo, TcpStruct remoteTcpInfo, byte[] data, ITcpReader tcpReader)
        {
            string dataString = _tcp.DataEncoding.GetString(data);
            string[] cmdArr = dataString.Split(new string[] { "`" }, StringSplitOptions.None);
            foreach (StateFlag unit in _netUnit)
            {
                if (unit.ID == tcpReader.ClientID && unit.BooleanFlag)
                {
                    __message(dataString, cmdArr, tcpReader);
                    return;
                }
            }

            if (cmdArr[0] == "name")
            {
                StateFlag unit = new StateFlag();
                unit.StringFlag = cmdArr[1];
                unit.BooleanFlag = true;
                unit.ID = tcpReader.ClientID;
                _g.LoggerObj.WriteLogLine("检测连接(" + unit.StringFlag + ")登陆");
                _netUnit.Add(unit);
            }
        }

        private void __message(string dataString, string[] cmdArr, ITcpReader tcpReader)
        {
            
        }

        #region IDisposable 成员

        public void Dispose()
        {
            _tcp.Dispose();
        }

        #endregion

        #region ISSTPlus 成员

        public string PlusName
        {
            get { return _plusName; }
        }
        public void InitPlus(GBC g)
        {
            _g = g;
            _tcp.AsyncStartListen(IPAddress.Loopback, 45771);
        }
        public bool RemovePlus()
        {
            StopPlus();
            Dispose();
            return true;
        }
        public void ShowPlus()
        {

        }
        public bool StopPlus()
        {
            Dispose();
            return true;
        }

        #endregion
    }
}