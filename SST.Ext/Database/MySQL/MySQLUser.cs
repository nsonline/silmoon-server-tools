using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.Odbc;
using Silmoon.Data.SqlUtility;

namespace SST.Ext.Database.MySQL
{
    public partial class MySQLUser : Form
    {
        SmOdbcClient _odbc;
        MySQLHelper _mysql;
        int _option;
        GBC _g;
        public MySQLUser(SmOdbcClient odbc, MySQLHelper mysql, int options, GBC g)
        {
            _g = g;
            InitializeComponent();
            _odbc = odbc;
            _mysql = mysql;
            _option = options;
            switch (options)
            {
                case 0:
                    ctlDatabaseTextBox.Enabled = false;
                    Text = "添加用户";
                    break;
                default:
                    break;
            }
        }

        private void MySQLUser_Load(object sender, EventArgs e)
        {

        }

        private void ctlSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (_option)
                {
                    case 0:
                        if (ctlUsernameTextBox.Text == "")
                            if (MessageBox.Show("创建匿名用户？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
                        _mysql.CreateUser(ctlUsernameTextBox.Text, ctlPasswordTextBox.Text);
                        DialogResult = DialogResult.OK;
                        Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            { _g.ProtectRunAsClass(ex.Message); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}