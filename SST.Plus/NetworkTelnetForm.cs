using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon;

namespace SST.Plus
{
    public partial class NetworkTelnetForm : Form
    {
        GBC _g;
        string _plusName;
        public NetworkTelnetForm(string plusName,string ver, string port,GBC g)
        {
            _g = g;
            InitializeComponent();
            ctlVersionLabel.Text = ver;
            ctlListenPort.Text = port;
            _plusName = plusName;
            Show();
        }

        private void NetworkTelnetForm_Load(object sender, EventArgs e)
        {
            ctlPortTextBox.Text = _g.ConfigIni.ReadInivalue(_plusName, "NetPort");
        }

        private void ctlConfirmConfig_Click(object sender, EventArgs e)
        {
            try
            {
                _g.ConfigIni.WriteInivalue(_plusName, "NetPort", SmInt.CheckIntValue(int.Parse(ctlPortTextBox.Text), 1, 65535, true).ToString());
                MessageBox.Show("成功提交到全局配置！", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { _g.PopErrorMessage(ex.Message); }
        }
    }
}