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
    public partial class WindowsFirewallEditAppForm : Form
    {
        GBC _g;
        string _imagePath = null;
        public WindowsFirewallEditAppForm(string imagePath,GBC g)
        {
            _imagePath = imagePath;
            InitializeComponent();
            _g = g;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cimagepath.Text == "")
            {
                MessageBox.Show("没有定义镜像路径", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ctitle.Text == "")
            {
                MessageBox.Show("没有定义备注标题", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string enable = null;
            if (cenable.Checked) enable = "Enabled"; else enable = "Disabled";

            string regData = cimagepath.Text + ":*:" + enable + ":" + ctitle.Text;
            RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\AuthorizedApplications\List", true);
            k.SetValue(cimagepath.Text, regData);
            k.Close();
            _g.LoggerObj.WriteLogLine("(WSE)已经对\"" + cimagepath.Text + "\"的防火墙策略进行了配置...");
            Close();
        }

        private void WindowsFirewallEditAppForm_Load(object sender, EventArgs e)
        {
            if (_imagePath != null)
            {
                RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\AuthorizedApplications\List");
                if (SmString.FindFormStringArray(k.GetValueNames(), _imagePath))
                {
                    string regData = k.GetValue(_imagePath).ToString();
                    string[] regArr = regData.Split(new string[] { ":" }, StringSplitOptions.None);
                    cimagepath.Text = regArr[0] + ":" + regArr[1];
                    cenable.Checked = SmString.StringToBool(regArr[3].ToString());
                    ctitle.Text = regArr[4];
                    Text = regArr[4];
                }
                else
                    MessageBox.Show("错误：\r\n\r\n     未找到项！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                k.Close();
            }
            else
                Text = "添加程序规则";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "应用程序(*.exe)|*.exe|应用程序扩展(*.dll)|*.dll|所有文件(*.*)|*.*";
            ofd.ShowDialog();
            if (ofd.FileName != "") cimagepath.Text = ofd.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}