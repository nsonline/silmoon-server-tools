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
                MessageBox.Show("û�ж��徵��·��", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (ctitle.Text == "")
            {
                MessageBox.Show("û�ж��屸ע����", "message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string enable = null;
            if (cenable.Checked) enable = "Enabled"; else enable = "Disabled";

            string regData = cimagepath.Text + ":*:" + enable + ":" + ctitle.Text;
            RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SYSTEM\CurrentControlSet\Services\SharedAccess\Parameters\FirewallPolicy\StandardProfile\AuthorizedApplications\List", true);
            k.SetValue(cimagepath.Text, regData);
            k.Close();
            _g.LoggerObj.WriteLogLine("(WSE)�Ѿ���\"" + cimagepath.Text + "\"�ķ���ǽ���Խ���������...");
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
                    MessageBox.Show("����\r\n\r\n     δ�ҵ��", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                k.Close();
            }
            else
                Text = "��ӳ������";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Ӧ�ó���(*.exe)|*.exe|Ӧ�ó�����չ(*.dll)|*.dll|�����ļ�(*.*)|*.*";
            ofd.ShowDialog();
            if (ofd.FileName != "") cimagepath.Text = ofd.FileName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}