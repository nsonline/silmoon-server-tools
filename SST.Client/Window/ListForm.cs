using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace SST.Client.Window
{
    public partial class ListForm : Form
    {
        GBC _g;
        public ListForm(int o, GBC g)
        {
            _g = g;
            InitializeComponent();
            Show();
            InitOption(o);
        }

        private void InitOption(int o)
        {
            switch (o)
            {
                case 1:
                    ListIP();
                    break;
                default:
                    break;
            }
        }

        private void ListIP()
        {
            this.Text = "当前网卡所有IP列表(用于多IP)";
            IPAddress[] ipArr = Dns.GetHostAddresses(Dns.GetHostName());
            foreach (IPAddress ip in ipArr)
            {
                listBox1.Items.Add(ip.ToString());
            }
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            this.Icon = SST.Resource.Resource.Network;
        }
    }
}