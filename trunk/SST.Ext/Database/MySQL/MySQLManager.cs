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
    public partial class MySQLManager : Form
    {
        public MySQLLogin loginForm;
        SmMySqlClient _odbc;
        MySQLHelper _mysql;
        GBC _g;
        public MySQLManager(GBC g)
        {
            _g = g;
            InitializeComponent();
        }

        private void MySQLManager_Shown(object sender, EventArgs e)
        {
            loginForm = new MySQLLogin();
            loginForm.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
            loginForm.ShowDialog();
        }

        void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginForm.ConnectionString == "close")
            {
                this.Close();
                _g.MainForm.Focus();
            }
            else
                RefreshData();
            ctlsStatusText.Text = "��½�ɹ�...";
        }
        void RefreshData()
        {
            ctlsStatusText.Text = "ˢ��״̬...";
            if (_odbc != null)
                _odbc.Dispose();

            _odbc = new SmMySqlClient(loginForm.ConnectionString);
            _odbc.Open();
            _mysql = new MySQLHelper(_odbc);

            DataTable databaseList = _odbc.GetDataTable("show databases");
            ctlg1DatabaseListBox.Items.Clear();
            foreach (DataRow row in databaseList.Rows)
                ctlg1DatabaseListBox.Items.Add(row["database"]);

            databaseList.Dispose();

            DataTable userList = _odbc.GetDataTable("select * from mysql.user");
            ctlg2UserListBox.Items.Clear();
            foreach (DataRow row in userList.Rows)
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
                ctlg2UserListBox.Items.Add(lineString);
            }
            ctlsStatusText.Text = "ˢ��״̬...(���)";
            userList.Dispose();
        }

        private void MySQLManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_odbc != null) _odbc.Dispose();
        }

        private void ctlg2CreateUserButton_Click(object sender, EventArgs e)
        {
            if (new MySQLUser(_odbc, _mysql, 0, _g).ShowDialog() == DialogResult.OK)
            {
                RefreshData();
                ctlsStatusText.Text = "�û���ӳɹ�...";
            }
        }
        private void ctlg2DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctlg2UserListBox.SelectedIndex != -1)
                {
                    string[] usernameArr = ctlg2UserListBox.SelectedItem.ToString().Split(new string[] { "(", ")" }, StringSplitOptions.None);
                    if (MessageBox.Show("��ȷ��Ҫɾ���û� " + usernameArr[0] + " ��", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (usernameArr.Length == 1)
                            _mysql.ForceRemoveUser(usernameArr[0]);
                        else
                        {
                            if (usernameArr[1] == "������½")
                                usernameArr[1] = "localhost";
                            _mysql.ForceRemoveUser(usernameArr[0], usernameArr[1]);
                        }
                        RefreshData();
                        ctlsStatusText.Text = "�û�ɾ���ɹ�...";
                    }
                }
                else ctlsStatusText.Text = "��ѡ���û�!";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "_err", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ctlg2GrantUserDatabaseButton_Click(object sender, EventArgs e)
        {
            if (ctlg2UserListBox.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ���û�!", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctlsStatusText.Text = "��ѡ���û�!";
                return;
            }
            if (ctlg1DatabaseListBox.SelectedIndex == -1)
            {
                MessageBox.Show("��ѡ�����ݿ�!", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctlsStatusText.Text = "��ѡ�����ݿ�!";
                return;
            }
            string username = ctlg2UserListBox.SelectedItem.ToString().Split(new string[] { "(" }, StringSplitOptions.None)[0];
            string database = ctlg1DatabaseListBox.Items[ctlg1DatabaseListBox.SelectedIndex].ToString();
            if (MessageBox.Show("ȷ�ϰ��û�(" + username + ")���õ����ݿ�(" + database + ")�\r\n���ʹ�û�(" + username + ")�����ݿ�(" + database + ")����ȫ�ķ���Ȩ��!", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mysql.AddUserToDatabase(username, database);
                ctlsStatusText.Text = "�������";
                MessageBox.Show("�����ɹ�!", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ctlg1CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            if (new MySQLDatabase(_odbc, _mysql, _g).ShowDialog() == DialogResult.OK)
            {
                RefreshData();
                ctlsStatusText.Text = "���ݿ���ӳɹ�...";
            }
        }
        private void ctlg1DeleteDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctlg1DatabaseListBox.SelectedIndex != -1)
                {
                    string database = ctlg1DatabaseListBox.SelectedItem.ToString();
                    if (MessageBox.Show("��ȷ��Ҫɾ�����ݿ� " + database + " ��", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _mysql.DropDatabase(database);
                        RefreshData();
                        ctlsStatusText.Text = "ɾ�����ݿ�ɹ�...";
                    }
                }
                else ctlsStatusText.Text = "��ѡ�����ݿ�!";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "_err", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ctlg1ViewDatabaseGrantButton_Click(object sender, EventArgs e)
        {
            if (ctlg1DatabaseListBox.SelectedIndex != -1)
            {
                if (new MySQLViewList(ctlg1DatabaseListBox.Items[ctlg1DatabaseListBox.SelectedIndex].ToString(), _odbc, _mysql, 0).ShowDialog() == DialogResult.OK)
                { }
            }
        }
        private void ctlg2ViewUserGrantButton_Click(object sender, EventArgs e)
        {
            if (ctlg2UserListBox.SelectedIndex != -1)
            {
                if (new MySQLViewList(ctlg2UserListBox.Items[ctlg2UserListBox.SelectedIndex].ToString(), _odbc, _mysql, 1).ShowDialog() == DialogResult.OK)
                { }
            }
        }

        private void ctlg2ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (ctlg2UserListBox.SelectedIndex != -1)
            {
                new MySQLChangePassword(_mysql, ctlg2UserListBox.Items[ctlg2UserListBox.SelectedIndex].ToString(), _g).ShowDialog();
            }
        }
    }
}