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
                if (pstr < 1 || pstr > 65535) { MessageBox.Show("端口号必须大于1并且小于65535！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

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
                if (MessageBox.Show("修改完成，重启后使用新的RDP Tcp端口进行远程访问\r\n\r\n是否将新的远程桌面端口添加到windows防火墙的例外列表里面？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (pstr == 3389)
                        ServiceEnvironment.AddSharedAccessFirewallPort(Convert.ToInt32(pstr), InternetProtocol.TCP, true, "远程桌面");
                    else
                        ServiceEnvironment.AddSharedAccessFirewallPort(Convert.ToInt32(pstr), InternetProtocol.TCP, true, "新的远程桌面端口");
                    MessageBox.Show("完成，端口" + pstr.ToString() + "已经被添加到windows防火墙例外列表中，并且允许网络连接", "哈哈，完成！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("您没有确定程序将新的端口加入到windows防火墙例外中\r\n\r\n如果你已经打开了windows防火墙，确定您能够用新的端口连接！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (MessageBox.Show("如果你取消了这个对勾的话，您将不能连接您服务器的远程桌面！\r\n\r\n    您确定要取消？！！？", "严重警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                    OpenTS.Checked = true;
            }
        }
    }
}