using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Data.SqlClient;
using Silmoon.Data.SqlUtility;
using System.Collections;

namespace SST.Ext.Database.MSSQL
{
    public partial class MSSQLViewList : Form
    {
        SmMSSQLClient _sql;
        MSSQLHelper _MSSQL;
        int _option;
        string _name;

        bool edited = false;
        public MSSQLViewList(string name,SmMSSQLClient sql, MSSQLHelper MSSQL, int option)
        {
            InitializeComponent();
            _sql = sql;
            _MSSQL = MSSQL;
            _option = option;
            _name = name;

            if (option == 0)
            {
                Text = "���ݿ�(" + name + ")�ķ����û�";
                label1.Text = "�����û���Ȩ�����ݿ�(" + name + ")����";
                ctlDeleteButton.Text = "ɾ��ѡ���û��ķ���Ȩ(&D)";
            }
            else
            {
                Text = "�û�(" + name + ")�����ݿ����Ȩ��";
                label1.Text = "�û�(" + name + ")���������ݿ��в���Ȩ";
                ctlDeleteButton.Text = "ɾ��ѡ�����ݿ�ķ���Ȩ(&D)";
            }
        }

        private void MSSQLViewList_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            listBox1.Items.Clear();
            if (_option == 0)
            {
                DataTable dt = _sql.GetDataTable("use " + _name + ";select Name from sysusers where islogin=1;use master");
                foreach (DataRow row in dt.Rows)
                {
                    listBox1.Items.Add(row["Name"].ToString());
                }
                dt.Dispose();
            }
            else
            {
                DataTable namedt = _sql.GetDataTable("Select Name FROM Master.dbo.SysDatabases ORDER BY Name");
                foreach (DataRow row in namedt.Rows)
                {
                    DataTable dt = _sql.GetDataTable("use " + row["Name"].ToString() + ";select Name from sysusers where islogin=1;use master");
                    foreach (DataRow namesrow in dt.Rows)
                        if (namesrow["Name"].ToString() == _name)
                            listBox1.Items.Add(row["Name"].ToString());
                }
                namedt.Dispose();
            }
        }

        private void ctlDeleteButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedString = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (_option == 0)
                {
                    if (MessageBox.Show("��Ҫɾ���û�(" + selectedString + ")�����ݿ�(" + _name + ")�ķ���Ȩ���", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _MSSQL.RemoveUserGrant(selectedString, _name);
                        edited = true;
                    }
                }
                else
                {
                    if (MessageBox.Show("��Ҫɾ���û�(" + _name + ")�����ݿ�(" + selectedString + ")�ķ���Ȩ���", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _MSSQL.RemoveUserGrant(_name, selectedString);
                        edited = true;
                    }
                }
                if (edited)
                    InitData();
            }
        }

        private void MSSQLViewList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited) DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }
    }
}