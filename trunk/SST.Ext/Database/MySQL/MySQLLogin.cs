using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlUtility;
using Silmoon.Data.Odbc;

namespace SST.Ext.Database.MySQL
{
    public partial class MySQLLogin : Form
    {
        public string ConnectionString = "close";
        public MySQLLogin()
        {
            InitializeComponent();
        }

        private void ctlLoginButton_Click(object sender, EventArgs e)
        {
            string constr = MySQLHelper.MakeConnectionString(ctlServerTextBox.Text, ctlUsernameTextBox.Text, ctlPasswordTextBox.Text, ctlDatabaseTextBox.Text);
            SmOdbcClient odbc = new SmOdbcClient(constr);
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

        private void MySQLLogin_Shown(object sender, EventArgs e)
        {
            ctlPasswordTextBox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}