using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Silmoon.Net;
using Silmoon.Service.SystemService;
using Silmoon;

namespace SST.Utility
{
    public partial class RDPPortEdit : Form
    {
        GBC _g;
        public RDPPortEdit()
        {
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco;
        }
        public void Show(GBC g)
        {
            _g = g;
            Show();
        }

        private void ReadPortButton_Click(object sender, EventArgs e)
        {
            RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp");
            PortLable.Text = k.GetValue("PortNumber").ToString();
            k.Close();
            if (PortTextBox.Text == "") { PortTextBox.Text = PortLable.Text; }
            RegistryKey k1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server");
            string constr = k1.GetValue("fDenyTSConnections").ToString();
            if (!SmString.StringToBool(constr)) OpenTS.Checked = true;
            else OpenTS.Checked = false;
            k1.Close();
        }
        private void WritePortButton_Click(object sender, EventArgs e)
        {
            try
            {
                int pstr = Convert.ToInt32(PortTextBox.Text);
                if (pstr < 1 || pstr > 65535) { MessageBox.Show("�˿ںű������1����С��65535��", "����", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

                RegistryKey k0 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server", true);
                if (OpenTS.Checked) k0.SetValue("fDenyTSConnections", 0, RegistryValueKind.DWord);
                else k0.SetValue("fDenyTSConnections", 1, RegistryValueKind.DWord);
                k0.Close();

                RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\Wds\rdpwd\Tds\tcp", true);
                RegistryKey k1 = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Control\Terminal Server\WinStations\RDP-Tcp", true);
                k.SetValue("PortNumber", pstr.ToString(), RegistryValueKind.DWord);
                k1.SetValue("PortNumber", pstr.ToString(), RegistryValueKind.DWord);
                k.Close();
                k1.Close();
                if (MessageBox.Show("�޸���ɣ�������ʹ���µ�RDP Tcp�˿ڽ���Զ�̷���\r\n\r\n�Ƿ��µ�Զ������˿���ӵ�windows����ǽ�������б����棿", "��ʾ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pstr == 3389)
                        ServiceEnvironment.AddSharedAccessFirewallPort(Convert.ToInt32(pstr), InternetProtocol.TCP, true, "Զ������");
                    else
                        ServiceEnvironment.AddSharedAccessFirewallPort(Convert.ToInt32(pstr), InternetProtocol.TCP, true, "�µ�Զ������˿�");
                    MessageBox.Show("��ɣ��˿�" + pstr.ToString() + "�Ѿ�����ӵ�windows����ǽ�����б��У�����������������", "��������ɣ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("��û��ȷ�������µĶ˿ڼ��뵽windows����ǽ������\r\n\r\n������Ѿ�����windows����ǽ��ȷ�����ܹ����µĶ˿����ӣ�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void RDPPortEdit_Load(object sender, EventArgs e)
        {
            ReadPortButton_Click(this, EventArgs.Empty);
        }

        private void OpenTS_CheckedChanged(object sender, EventArgs e)
        {
            if (!OpenTS.Checked)
            {
                if (MessageBox.Show("�����ȡ��������Թ��Ļ�������������������������Զ�����棡\r\n\r\n    ��ȷ��Ҫȡ����������", "���ؾ���", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    OpenTS.Checked = true;
            }
        }
    }
}