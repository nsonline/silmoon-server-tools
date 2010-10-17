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
    public partial class MSSQLDatabase : Form
    {
        SmMSSQLClient _sql;
        MSSQLHelper _MSSQL;
        GBC _g;

        public MSSQLDatabase(SmMSSQLClient odbc, MSSQLHelper MSSQL, GBC g)
        {
            _g = g;
            InitializeComponent();
            _sql = odbc;
            _MSSQL = MSSQL;
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
                _MSSQL.CreateDatabase(ctlDatabaseTextBox.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}