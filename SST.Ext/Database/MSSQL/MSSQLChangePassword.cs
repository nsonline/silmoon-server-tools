using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlUtility;

namespace SST.Ext.Database.MSSQL
{
    public partial class MSSQLChangePassword : Form
    {
        MSSQLHelper _MSSQL;
        string _username;
        GBC _g;

        public MSSQLChangePassword(MSSQLHelper MSSQL, string username, GBC g)
        {
            _g = g;
            InitializeComponent();
            _MSSQL = MSSQL;
            _username = username;
            Text = "修改用户" + _username + "密码";
        }

        private void ctlSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctlPasswordTextBox.Text == "")

                    if (MessageBox.Show("你要给用户设置一个空密码？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                if (ctlPasswordTextBox.Text != ctlRepasswordTextBox.Text)
                {
                    MessageBox.Show("两次输入的密码不一样！", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int i = _MSSQL.SetPassword(_username, ctlPasswordTextBox.Text);
                MessageBox.Show("密码修改成功！(" + i + ")", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            { _g.ProtectRunAsClass(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}