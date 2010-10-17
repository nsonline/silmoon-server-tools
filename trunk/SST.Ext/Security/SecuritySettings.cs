using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SST.Ext.Security
{
    public partial class SecuritySettings : Form
    {
        GBC _g;
        FileSecuritySettingsClass _fileSecurity;
        public SecuritySettings(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            _fileSecurity = new FileSecuritySettingsClass(_g);
            Show();
        }

        private void ctlSethcSecurityButton_Click(object sender, EventArgs e)
        {
            _fileSecurity.SethcFileSecurity();
        }

        private void ctlSethcUnsecurityButton_Click(object sender, EventArgs e)
        {
            _fileSecurity.ResetSethcFileSecurity();
        }

        private void ctlSethcSecurityButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("注意，这将废除当前的粘滞键功能，如果想要恢复，请联系我们！\r\n如果存在Windows文件还原保护，并且免疫去除后，可能会被恢复。\r\n    （在大多数情况下粘滞键没用！）\r\n点击 确定(OK)继续，撤销(CANCLE)撤销", "_war", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                _fileSecurity.SethcFileSecurityHard();
        }
    }
}