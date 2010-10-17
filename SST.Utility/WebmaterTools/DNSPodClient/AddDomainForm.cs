using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DNSPodClient
{
    public partial class AddDomainForm : Form
    {
        GBC _g;
        public AddDomainForm(GBC g)
        {
            _g = g;
            InitializeComponent();
            ////this.Icon = DNSPodClient.Properties.Resources.DNSPod_1_Red;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ctlAddButton_Click(object sender, EventArgs e)
        {
            if (_g._dnspod.CreateDomain(ctlDomainTextBox.Text).DoubleStateFlag)
                DialogResult = DialogResult.OK;
            else MessageBox.Show("ÃÌº” ß∞‹£°", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}