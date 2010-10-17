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
    public partial class MSSQLManager : Form
    {
        public MSSQLLogin loginForm;
        SmMSSQLClient _sql;
        MSSQLHelper _MSSQL;
        GBC _g;
        public MSSQLManager(GBC g)
        {
            _g = g;
            InitializeComponent();
        }

        private void MSSQLManager_Shown(object sender, EventArgs e)
        {
            loginForm = new MSSQLLogin();
            loginForm.FormClosed += new FormClosedEventHandler(loginForm_FormClosed);
            loginForm.ShowDialog();
        }

        void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginForm.ConnectionString == "close")
                this.Close();
            else
                RefreshData();
            ctlsStatusText.Text = "登陆成功...";
        }
        void RefreshData()
        {
            ctlsStatusText.Text = "刷新状态...";
            if (_sql != null)
                _sql.Dispose();

            _sql = new SmMSSQLClient(loginForm.ConnectionString);
            _sql.Open();
            _MSSQL = new MSSQLHelper(_sql);

            DataTable databaseList = _sql.GetDataTable("Select Name FROM Master.dbo.SysDatabases ORDER BY Name");
            ctlg1DatabaseListBox.Items.Clear();
            foreach (DataRow row in databaseList.Rows)
                ctlg1DatabaseListBox.Items.Add(row["Name"]);

            databaseList.Dispose();

            DataTable userList = _sql.GetDataTable("select Name from syslogins where isntname=0");
            ctlg2UserListBox.Items.Clear();
            foreach (DataRow row in userList.Rows)
            {
                ctlg2UserListBox.Items.Add(row["Name"].ToString());
            }
            ctlsStatusText.Text = "刷新状态...(完成)";
            userList.Dispose();
        }

        private void MSSQLManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_sql != null) _sql.Dispose();
        }

        private void ctlg2CreateUserButton_Click(object sender, EventArgs e)
        {
            if (new MSSQLUser(_sql, _MSSQL, 0, _g).ShowDialog() == DialogResult.OK)
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
                    string username = ctlg2UserListBox.SelectedItem.ToString().Split(new string[] { "(" }, StringSplitOptions.None)[0];
                    if (MessageBox.Show("你确定要删除用户 " + username + " 吗？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        _MSSQL.RemoveUser(username);
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
                try
                {
                    _MSSQL.AddUserToDatabase(username, database);
                    ctlsStatusText.Text = "操作完成";
                    MessageBox.Show("操作成功!", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "_err", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

        private void ctlg1CreateDatabaseButton_Click(object sender, EventArgs e)
        {
            if (new MSSQLDatabase(_sql, _MSSQL, _g).ShowDialog() == DialogResult.OK)
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
                        _MSSQL.DropDatabase(database);
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
                if (new MSSQLViewList(ctlg1DatabaseListBox.Items[ctlg1DatabaseListBox.SelectedIndex].ToString(), _sql, _MSSQL, 0).ShowDialog() == DialogResult.OK)
                { }
            }
        }
        private void ctlg2ViewUserGrantButton_Click(object sender, EventArgs e)
        {
            if (ctlg2UserListBox.SelectedIndex != -1)
            {
                if (new MSSQLViewList(ctlg2UserListBox.Items[ctlg2UserListBox.SelectedIndex].ToString(), _sql, _MSSQL, 1).ShowDialog() == DialogResult.OK)
                { }
            }
        }

        private void ctlg2ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (ctlg2UserListBox.SelectedIndex != -1)
            {
                new MSSQLChangePassword(_MSSQL, ctlg2UserListBox.Items[ctlg2UserListBox.SelectedIndex].ToString(), _g).ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new MSSQLConfig(_sql).Show();
        }
    }
}