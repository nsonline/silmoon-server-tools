using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Silmoon;

namespace SST.Utility.WindowsFirewall
{
    public partial class WindowsFirewallAddPortForm : Form
    {
        GBC _g;
        public WindowsFirewallAddPortForm(GBC g)
        {
            InitializeComponent();
            _g = g;
        }
        public event _add_hander OnAddIpStringOk;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                label2.Visible = true;
                label1.Text = "*";
            }
            else
                label2.Visible = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                label1.Text = "";
                zipbt.Visible = true;
                ziptb.Visible = true;
            }
            else
            {
                zipbt.Visible = false;
                ziptb.Visible = false;
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                label1.Text = "";
                zsubnetbt.Visible = true;
                zsubnettb.Visible = true;
                zsubnetmask.Visible = true;
            }
            else
            {
                zsubnetbt.Visible = false;
                zsubnettb.Visible = false;
                zsubnetmask.Visible = false;
            }
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                label1.Text = "LocalSubNet";
                label3.Visible = true;
            }
            else label3.Visible = false;
        }

        private void zipbt_Click(object sender, EventArgs e)
        {
            try
            { label1.Text = IPAddress.Parse(ziptb.Text).ToString() + "/255.255.255.255"; }
            catch (Exception ex) { _g.PopErrorMessage(ex.Message); }
        }
        private void zsubnetbt_Click(object sender, EventArgs e)
        {
            try
            {
                int i = SmInt.ControlIntValue(int.Parse(zsubnetmask.Text), 8, 32, true);
                label1.Text = IPAddress.Parse(zsubnettb.Text).ToString() + "/" + Silmoon.Net.NetworkAddressFormat.GetIPv4SubNetAddress(int.Parse(zsubnetmask.Text)).ToString();
            }
            catch (Exception ex) { _g.PopErrorMessage(ex.Message); }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "")
                MessageBox.Show("πÊ‘Ú¥ÌŒÛ", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (OnAddIpStringOk != null) OnAddIpStringOk(label1.Text);
                Close();
            }
        }

        private void zsubnetmask_Enter(object sender, EventArgs e)
        {
            label4.Visible = true;
        }
        private void zsubnetmask_Leave(object sender, EventArgs e)
        {
            label4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    public delegate void _add_hander(string ip);
}