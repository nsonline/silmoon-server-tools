using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlUtility;
using Silmoon.Data.SqlClient;

namespace SST.Ext.Database.MSSQL
{
    public partial class MSSQLLogin : Form
    {
        public string ConnectionString = "close";
        public MSSQLLogin()
        {
            InitializeComponent();
        }

        private void ctlLoginButton_Click(object sender, EventArgs e)
        {
            string constr = "";
            if (ctlUseWindowsAuth.Checked)
                constr = "server=(local);database=master;Integrated Security=SSPI";
            else
                constr = "server=(local);database=master;uid=" + ctlUsernameTextBox.Text + ";pwd=" + ctlPasswordTextBox.Text;
            SmMSSQLClient odbc = new SmMSSQLClient(constr);
            try
            {
                odbc.Open();
                odbc.Close();
                ConnectionString = constr;
                Close();
            }
            catch (Exception ex) { MessageBox.Show("µÇÂ½Ê§°Ü£¡\r\n" + ex.Message); }
            odbc.Dispose();
        }

        private void MSSQLLogin_Shown(object sender, EventArgs e)
        {
            ctlPasswordTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctlUseWindowsAuth_CheckedChanged(object sender, EventArgs e)
        {
            ctlUsernameTextBox.Enabled = ctlPasswordTextBox.Enabled = !ctlUseWindowsAuth.Checked;
        }
    }
}