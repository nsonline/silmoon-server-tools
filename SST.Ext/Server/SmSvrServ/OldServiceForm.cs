using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Service;
using System.Diagnostics;

namespace SST.Ext.Server.SmSvrServ
{
    public partial class OldServiceForm : Form
    {
        GBC _g;
        public OldServiceForm(GBC g)
        {
            _g = g;
            InitializeComponent();
        }

        private void OldServiceForm_Shown(object sender, EventArgs e)
        {
            if (ServiceControl.IsExisted("SmServr"))
            {
                ctlStatusLabel.Text = "已经找到旧版服务,请删除";
                linkLabel1.Enabled = true;
            }
            else
                linkLabel1.Enabled = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _g.ServiceCtrl.AsyncService("smservr", ServiceOptions.Stop);
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = @"c:\windows\system32\sc.exe";
            start.Arguments = "delete smservr";
            start.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(start);
            MessageBox.Show("删除完毕", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}