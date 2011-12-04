using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlUtility;
using Silmoon.Data.SqlClient;

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
            
            MySql.Data.MySqlClient.MySqlConnectionStringBuilder stringBuild = new MySql.Data.MySqlClient.MySqlConnectionStringBuilder();
            stringBuild.Server = ctlServerTextBox.Text;
            stringBuild.UserID = ctlUsernameTextBox.Text;
            stringBuild.Password = ctlPasswordTextBox.Text;
            stringBuild.Database = ctlDatabaseTextBox.Text;
            string constr = stringBuild.GetConnectionString(true);
            SmMySqlClient sql = new SmMySqlClient(constr);
            try
            {
                sql.Open();
                sql.Close();
                ConnectionString = constr;
                Close();
            }
            catch (Exception ex) { MessageBox.Show("µÇÂ½Ê§°Ü£¡\r\n" + ex.Message); }
            sql.Dispose();
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