using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon;

namespace SST.Client.Options
{
    public partial class Settings : Form
    {
        GBC _g;
        public Settings(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            Show();
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            Dispose(true);
        }

        private void Apply_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                _g.Reg.WriteKey("Password", ctlgPassword.Text, Microsoft.Win32.RegistryValueKind.String);
                MessageBox.Show("写入配置成功\r\n\r\n部分设置生效需要重启程序！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidateInput()
        {
            try
            {
                if (ctlgPassword.Text == "")
                {
                    MessageBox.Show("密码不能为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            ReadConfig();
            DrawForm();
        }
        private void ReadConfig()
        {
            ctlgPassword.Text = SmString.FixNullString(_g.Reg.ReadKey("Password"));
        }
        private void DrawForm()
        {

        }
    }
}