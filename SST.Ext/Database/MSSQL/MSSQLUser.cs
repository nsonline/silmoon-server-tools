using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlClient;
using Silmoon.Data.SqlUtility;

namespace SST.Ext.Database.MSSQL
{
    public partial class MSSQLUser : Form
    {
        SmMSSQLClient _sql;
        MSSQLHelper _MSSQL;
        int _option;
        GBC _g;

        public MSSQLUser(SmMSSQLClient odbc, MSSQLHelper MSSQL, int options, GBC g)
        {
            _g = g;
            InitializeComponent();
            _sql = odbc;
            _MSSQL = MSSQL;
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

        private void MSSQLUser_Load(object sender, EventArgs e)
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
                        {
                            MessageBox.Show("不允许空的用户名!", "_war", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                            return;
                        }
                        _MSSQL.CreateUser(ctlUsernameTextBox.Text, ctlPasswordTextBox.Text);
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