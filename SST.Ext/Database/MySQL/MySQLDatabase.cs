using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlClient;
using Silmoon.Data.SqlUtility;

namespace SST.Ext.Database.MySQL
{
    public partial class MySQLDatabase : Form
    {
        SmMySqlClient _odbc;
        MySQLHelper _mysql;
        GBC _g;

        public MySQLDatabase(SmMySqlClient odbc, MySQLHelper mysql, GBC g)
        {
            _g = g;
            InitializeComponent();
            _odbc = odbc;
            _mysql = mysql;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ctlSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctlDatabaseTextBox.Text == "")
                {
                    MessageBox.Show("数据库名不能为空!", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _mysql.CreateDatabase(ctlDatabaseTextBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            { _g.ProtectRunAsClass(ex.Message); }
        }
    }
}