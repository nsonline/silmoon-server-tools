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
            if (MessageBox.Show("ע�⣬�⽫�ϳ���ǰ��ճ�ͼ����ܣ������Ҫ�ָ�������ϵ���ǣ�\r\n�������Windows�ļ���ԭ��������������ȥ���󣬿��ܻᱻ�ָ���\r\n    ���ڴ���������ճ�ͼ�û�ã���\r\n��� ȷ��(OK)����������(CANCLE)����", "_war", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                _fileSecurity.SethcFileSecurityHard();
        }
    }
}