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
    public partial class MySQLViewList : Form
    {
        SmOdbcClient _odbc;
        MySQLHelper _mysql;
        int _option;
        string _name;

        bool edited = false;
        public MySQLViewList(string name,SmOdbcClient odbc, MySQLHelper mysql, int option)
        {
            InitializeComponent();
            _odbc = odbc;
            _mysql = mysql;
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

        private void MySQLViewList_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            listBox1.Items.Clear();
            if (_option == 0)
            {
                DataTable dt = _odbc.GetDataTable("select user,host from mysql.db where db = '" + _name + "'");
                foreach (DataRow row in dt.Rows)
                {
                    string lineString = row["user"].ToString();

                    switch (row["host"].ToString().ToLower())
                    {
                        case "localhost":
                            lineString += "(������½)";
                            break;
                        case "%":
                            break;
                        default:
                            lineString += "(" + row["host"].ToString().ToLower() + ")";
                            break;
                    }
                    listBox1.Items.Add(lineString);
                }
                dt.Dispose();
            }
            else
            {
                DataTable dt = _odbc.GetDataTable("select db from mysql.db where user = '" + _name + "'");
                foreach (DataRow row in dt.Rows)
                {
                    listBox1.Items.Add(row[0].ToString());
                }
                dt.Dispose();
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
                        _mysql.RemoveUserGrant(selectedString, _name);
                        edited = true;
                    }
                }
                else
                {
                    if (MessageBox.Show("��Ҫɾ���û�(" + _name + ")�����ݿ�(" + selectedString + ")�ķ���Ȩ���", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _mysql.RemoveUserGrant(_name, selectedString);
                        edited = true;
                    }
                }
                if (edited)
                    InitData();
            }
        }

        private void MySQLViewList_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (edited) DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Cancel;
        }
    }
}