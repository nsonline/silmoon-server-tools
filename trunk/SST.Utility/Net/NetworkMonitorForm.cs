using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Net;
using System.Net;
using System.Collections;

namespace SST.Utility.Net
{
    public partial class NetworkMonitorForm : Form
    {
        ArrayList _n = new ArrayList();
        ArrayList _array = new ArrayList();
        GBC _g;

        public NetworkMonitorForm(GBC g)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            _g = g;
            InitializeComponent();
            Icon = SST.Resource.Resource.Network;
            Show();
        }

        private void NetworkMonitorForm_Shown(object sender, EventArgs e)
        {
            foreach (IPAddress ip in Dns.GetHostAddresses(Dns.GetHostName()))
            {
                Monitor m = new Monitor(ip);
                m.NewPacket += new Monitor.NewPacketEventHandler(m_NewPacket);
                _n.Add(m);
            }
        }

        void m_NewPacket(Monitor m, Packet p)
        {
            ListViewUnit a = new ListViewUnit();
            a.source = p.Source;
            a.dustination = p.Destination;
            a.packet = p.Protocol.ToString();
            a.lenght = p.TotalLength.ToString();
            _array.Insert(0, a);
            listView1.VirtualListSize = _array.Count;
        }

        private void listView1_RetrieveVirtualItem(object sender, RetrieveVirtualItemEventArgs e)
        {
            if (_array.Count < e.ItemIndex + 1)
            {
                e.Item = new ListViewItem(new string[] { "", "", "", "" });
            }
            else if (_array[e.ItemIndex] == null) { e.Item = new ListViewItem(new string[] { "", "", "", "" }); }
            else
            {
                ListViewUnit a = (ListViewUnit)_array[e.ItemIndex];
                e.Item = new ListViewItem(new string[] { a.source, a.dustination, a.packet, a.lenght });
            }
        }
        public struct ListViewUnit
        {
            public string source;
            public string dustination;
            public string packet;
            public string lenght;
        }

        private void NetworkMonitorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (object var in _n)
            {
                ((Monitor)var).Stop();
            }
        }

        private void ctltClearButton_Click(object sender, EventArgs e)
        {
            _array.Clear();
            listView1.VirtualListSize = _array.Count;
        }

        private void ctltStartButton_Click(object sender, EventArgs e)
        {
            if (ctltStartButton.Text == "开始")
            {
                ctltStartButton.Text = "停止";
                foreach (Silmoon.Net.Monitor var in _n)
                {

                    if (var.IP.ToString().Contains(":"))
                        continue;
                    else
                    {
                        ((Monitor)var).Start();
                    }
                }
            }
            else
            {
                foreach (object var in _n)
                    ((Monitor)var).Stop();
                ctltStartButton.Text = "开始";
            }
        }
    }
}