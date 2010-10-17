using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using Silmoon;

namespace SST.Utility.WindowsFirewall
{
    public partial class WindowsFirewallEditPortForm : Form
    {
        int _port = 0;
        string _protocol = null;
        GBC _g;
        public WindowsFirewallEditPortForm(int port, string protocol,GBC g)
        {
            _port = port;
            _protocol = protocol;
            InitializeComponent();
            _g = g;
            Text = "端口：" + _port + "  协议：" + _protocol;
        }

        private void WindowsFirewallEditForm_Load(object sender, EventArgs e)
        {
            if (_port != 0)
            {
                RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\GloballyOpenPorts\List");
                string regName = _port.ToString() + ":" + _protocol;
                if (SmString.FindFormStringArray(k.GetValueNames(), regName))
                {
                    string regData = k.GetValue(regName).ToString();
                    string[] regDataArr = regData.Split(new string[] { ":" }, StringSplitOptions.None);
                    cport.Text = regDataArr[0];
                    if (regDataArr[1] == "TCP") cprotocol.SelectedIndex = 0; else cprotocol.SelectedIndex = 1;
                    cenable.Checked = SmString.StringToBool(regDataArr[3]);
                    ctitle.Text = regDataArr[4].ToString();

                    string[] ipArr = regDataArr[2].Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < ipArr.Length; i++)
                    {
                        ciplist.Items.Add(ipArr[i].ToString());
                    }

                }
                else
                    MessageBox.Show("错误：\r\n\r\n     未找到项！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                k.Close();
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (ciplist.Items.Count == 0)
                {
                    MessageBox.Show("没有定义IP规则", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cport.Text == "")
                {
                    MessageBox.Show("端口不能为空", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (cprotocol.Text == "")
                {
                    MessageBox.Show("没有定义协议", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (ctitle.Text == "")
                {
                    MessageBox.Show("备注标题不能为空", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string iplist = null;
                string enable = null;

                for (int i = 0; i < ciplist.Items.Count; i++)
                {
                    iplist += ciplist.Items[i].ToString();
                    if (ciplist.Items.Count > i + 1) iplist += ",";
                }

                if (cenable.Checked) enable = "Enabled"; else enable = "Disabled";

                string regData = SmInt.ControlIntValue(int.Parse(cport.Text), 0, 65535, true).ToString() + ":" + cprotocol.Text + ":" + iplist + ":" + enable + ":" + ctitle.Text;


                RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\GloballyOpenPorts\List", true);
                if (_port != 0)
                {
                    k.DeleteValue(_port.ToString() + ":" + _protocol);
                }
                k.SetValue(cport.Text + ":" + cprotocol.Text, regData, RegistryValueKind.String);
                k.Close();
                _g.LoggerObj.WriteLogLine("(WSE)已经对\"" + cport.Text + "\"端口进行了防火墙策略配置...");
                Close();
            }
            catch (Exception ex) { _g.PopErrorMessage(ex.Message); }
        }
        private void bpat_Click(object sender, EventArgs e)
        {
            if (ciplist.SelectedIndex != -1)
                ciplist.Items.RemoveAt(ciplist.SelectedIndex);
        }

        private void badd_Click(object sender, EventArgs e)
        {
            WindowsFirewallAddPortForm addform = new WindowsFirewallAddPortForm(_g);
            addform.OnAddIpStringOk += new _add_hander(addform_OnAddIpStringOk);
            addform.ShowDialog();
        }

        void addform_OnAddIpStringOk(string ip)
        {
            if (ip == "*" || ip == "LocalSubNet") ciplist.Items.Clear();
            else
            {
                ciplist.Items.Remove("*");
            }
            for (int i = 0; i < ciplist.Items.Count; i++)
            {
                if (ciplist.Items[i].ToString() == ip)
                    return;
            }
            ciplist.Items.Add(ip);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}