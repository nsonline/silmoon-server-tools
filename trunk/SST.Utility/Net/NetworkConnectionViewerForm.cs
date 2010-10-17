using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Net.NetworkInformation;
using Silmoon.Net;
using System.Threading;

namespace SST.Utility.Net
{
    public partial class NetworkConnectionViewerForm : Form
    {
        Thread _th;
        GBC _g;
        ConnectionsInformation _netInfo;
        bool _autoRefresh = true;
        TcpConnectExInfo _tcpInfo;

        bool _work = false;
        public NetworkConnectionViewerForm(GBC g)
        {
            _g = g;
            InitializeComponent();
            Icon = SST.Resource.Resource.Network;
            Show();
        }

        private void NetworkConnectionViewerForm_Shown(object sender, EventArgs e)
        {
            _netInfo = new ConnectionsInformation();
            _th = new Thread(RefreshTcpInfo);
            _th.IsBackground = true;
            _work = true;
            _th.Start();
        }

        private void RefreshTcpInfo()
        {
            while (_work)
            {
                if (!_autoRefresh) continue;
                _tcpInfo = _netInfo.GetExTcpConnexions();
                listView1.VirtualListSize = _tcpInfo.dwNumEntries;
                Thread.Sleep(1000);
            }
        }
        public string getintroString(string stateString)
        {
            switch (stateString.ToLower())
            {
                case "listen":
                    return "监听";
                case "estab":
                    return "已连接";
                case "close_wait":
                    return "关闭等待";
                case "fin_wait2":
                    return "完成等待2";
                case "closing":
                    return "关闭中";
                case "syn_sent":
                    return "同步发送";
                case "last_ack":
                    return "最后应答";
                case "fin_wait1":
                    return "完成等待1";
                case "time_wait":
                    return "等待释放";
                default:
                    return stateString;
            }
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            e.Item = new ListViewItem(new string[] { NetworkAddressFormat.GetIPPortString(_tcpInfo.table[e.ItemIndex].Local), NetworkAddressFormat.GetIPPortString(_tcpInfo.table[e.ItemIndex].Remote), getintroString(_tcpInfo.table[e.ItemIndex].StrgState), _tcpInfo.table[e.ItemIndex].dwProcessId.ToString(), _tcpInfo.table[e.ItemIndex].ProcessName });
        }

        private void NetworkConnectionViewerForm_Resize(object sender, EventArgs e)
        {
            listView1.Height = this.Height - 77;
        }

        private void NetworkConnectionViewerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_th != null)
            {
                if (_th.ThreadState == ThreadState.Background || _th.ThreadState == ThreadState.Running)
                    _th.Abort();
            }
            _work = false;
        }

        private void ctltStopAutoRefresh_Click(object sender, EventArgs e)
        {
            if (ctltStopAutoRefresh.Text == "禁用自动刷新")
            {
                _autoRefresh = false;
                ctltStopAutoRefresh.Text = "启用自动刷新";
            }
            else
            {
                _autoRefresh = true;
                ctltStopAutoRefresh.Text = "禁用自动刷新";
            }
        }
    }
}