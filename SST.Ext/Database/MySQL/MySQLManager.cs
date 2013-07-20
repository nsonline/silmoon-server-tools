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
            ctlsStatusText.Text = "登陆成功...";
        }
        void RefreshData()
        {
            ctlsStatusText.Text = "刷新状态...";
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
                        lineString += "(本机登陆)";
                        break;
                    case "%":
                        break;
                    default:
                        lineString += "(" + row["host"].ToString().ToLower() + ")";
                        break;
                }
                ctlg2UserListBox.Items.Add(lineString);
            }
            ctlsStatusText.Text = "刷新状态...(完成)";
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
                ctlsStatusText.Text = "用户添加成功...";
            }
        }
        private void ctlg2DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctlg2UserListBox.SelectedIndex != -1)
                {
                    string[] usernameArr = ctlg2UserListBox.SelectedItem.ToString().Split(new string[] { "(", ")" }, StringSplitOptions.None);
                    if (MessageBox.Show("你确定要删除用户 " + usernameArr[0] + " 吗？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        if (usernameArr.Length == 1)
                            _mysql.ForceRemoveUser(usernameArr[0]);
                        else
                        {
                            if (usernameArr[1] == "本机登陆")
                                usernameArr[1] = "localhost";
                            _mysql.ForceRemoveUser(usernameArr[0], usernameArr[1]);
                        }
                        RefreshData();
                        ctlsStatusText.Text = "用户删除成功...";
                    }
                }
                else ctlsStatusText.Text = "清选择用户!";
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "_err", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void ctlg2GrantUserDatabaseButton_Click(object sender, EventArgs e)
        {
            if (ctlg2UserListBox.SelectedIndex == -1)
            {
                MessageBox.Show("请选择用户!", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctlsStatusText.Text = "请选择用户!";
                return;
            }
            if (ctlg1DatabaseListBox.SelectedIndex == -1)
            {
                MessageBox.Show("请选择数据库!", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctlsStatusText.Text = "请选择数据库!";
                return;
            }
            string username = ctlg2UserListBox.SelectedItem.ToString().Split(new string[] { "(" }, StringSplitOptions.None)[0];
            string database = ctlg1DatabaseListBox.Items[ctlg1DatabaseListBox.SelectedIndex].ToString();
            if (MessageBox.Show("确认把用户(" + username + ")设置到数据库(" + database + ")嘛？\r\n这会使用户(" + username + ")对数据库(" + database + ")有完全的访问权限!", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _mysql.AddUserToDatabase(username, database);
                ctlsStatusText.Text = "操作完成";
                MessageBox.Show("操作成功!", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ctlg1CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            if (new MySQLDatabase(_odbc, _mysql, _g).ShowDialog() == DialogResult.OK)
            {
                RefreshData();
                ctlsStatusText.Text = "数据库添加成功...";
            }
        }
        private void ctlg1DeleteDatabaseButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ctlg1DatabaseListBox.SelectedIndex != -1)
                {
                    string database = ctlg1DatabaseListBox.SelectedItem.ToString();
                    if (MessageBox.Show("你确定要删除数据库 " + database + " 吗？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _mysql.DropDatabase(database);
                        RefreshData();
                        ctlsStatusText.Text = "删除数据库成功...";
                    }
                }
                else ctlsStatusText.Text = "清选择数据库!";
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