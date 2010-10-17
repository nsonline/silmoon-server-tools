using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlClient;
using Silmoon;

namespace SST.Ext.Database.MSSQL
{
    public partial class MSSQLConfig : Form
    {
        SmMSSQLClient _sql;
        public MSSQLConfig(SmMSSQLClient sql)
        {
            _sql = sql;
            InitializeComponent();
        }

        private void MSSQLConfig_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            ctlStatusText.Text = "ˢ����������...";
            DataTable dt = _sql.GetDataTable("SELECT value, is_dynamic, maximum, minimum FROM sys.configurations where Name='max server memory (MB)'");
            DataRow dr = dt.Rows[0];
            ctlMemLimitNumUD.Maximum = int.Parse(dr["maximum"].ToString());
            ctlMemLimitNumUD.Minimum = int.Parse(dr["minimum"].ToString());

            ctlMemLimitNumUD.Value = int.Parse(dr["value"].ToString());
            ctlUnlimitCheckBox.Checked = (int.Parse(dr["value"].ToString()) == int.Parse(dr["maximum"].ToString()));
            ctlDynamicMemCheckBox.Checked = SmString.StringToBool(dr["is_dynamic"].ToString());
            ctlStatusText.Text += "���";
        }

        private void ctlUnlimitCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            ctlMemLimitNumUD.Enabled = !ctlUnlimitCheckBox.Checked;
            if (ctlUnlimitCheckBox.Checked) { ctlMemLimitNumUD.Value = ctlMemLimitNumUD.Maximum; }
        }

        private void ctlCommitMemButton_Click(object sender, EventArgs e)
        {
            ctlStatusText.Text = "�ύ���ò�ѯ...";
            _sql.ExecNonQuery("EXEC sys.sp_configure N'show advanced options', N'1'  RECONFIGURE WITH OVERRIDE");
            _sql.ExecNonQuery("EXEC sys.sp_configure N'max server memory (MB)', N'" + ctlMemLimitNumUD.Value + "'");
            _sql.ExecNonQuery("EXEC sys.sp_configure N'show advanced options', N'0'  RECONFIGURE WITH OVERRIDE");
            ctlStatusText.Text += "���";
            MessageBox.Show("��ѯ��ϣ��ύ��ɣ�û�д��󷵻أ����ĳɹ���", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}