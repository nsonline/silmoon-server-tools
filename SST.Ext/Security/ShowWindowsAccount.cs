using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Security.AccessControl;

namespace SST.Ext.Security
{
    public partial class ShowWindowsAccount : Form
    {
        GBC _g;
        public ShowWindowsAccount(GBC g)
        {
            _g = g;
            InitializeComponent();
            Show();
        }

        private void ShowWindowsAccount_Load(object sender, EventArgs e)
        {
            RegistryKey k = Registry.LocalMachine.OpenSubKey(@"SAM\SAM", true);
            RegistrySecurity regsec = k.GetAccessControl();
            k.SetAccessControl(regsec);
            k.Close();
            _g.LoggerObj.WriteLogLine("获取SAM读写权限完成...");

            RegistryKey k1 = Registry.LocalMachine.OpenSubKey(@"SAM\SAM\Domains\Account\Users\Names");
            string[] accArr = k1.GetSubKeyNames();
            k1.Close();

            foreach (string acc in accArr)
            {
                listBox1.Items.Add(acc);
            }
        }
    }
}