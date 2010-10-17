using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Silmoon;
using Silmoon.Windows.Server.IIS;
using System.Collections;
using Silmoon.Security;
using Silmoon.Windows;
using System.Threading;
using Silmoon.IO.SmFile;
using System.IO;

namespace SST.Ext.IIS
{
    public partial class CreateWebsiteForm : Form
    {
        GBC _g;
        int _userSec = 0;
        int _scripts = 0;
        public event IISHander WebsiteCreated;

        public int UserSec
        {
            get { return _userSec; }
            set { _userSec = value; }
        }
        public int Scripts
        {
            get { return _scripts; }
            set { _scripts = value; }
        }

        IISManager _iisMgr;
        public CreateWebsiteForm(GBC g, IISManager iisMgr)
        {
            _iisMgr = iisMgr;
            _g = g;
            InitializeComponent();
            Show();
            this.Height = 364;
            Location = new Point(Location.X, Location.Y + 58);
        }

        private void ctlPort_Enter(object sender, EventArgs e)
        {
            lablePortTip.Visible = true;
        }
        private void ctlPort_Leave(object sender, EventArgs e)
        {
            lablePortTip.Visible = false;
        }

        private void ctlIPList_Enter(object sender, EventArgs e)
        {
            labelIPTip.Visible = true;
        }
        private void ctlIPList_Leave(object sender, EventArgs e)
        {
            labelIPTip.Visible = false;
        }

        private void ctlBindingsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctlBindingsList.SelectedIndex != -1)
                ctlRemoveBindings.Visible = true;
            else ctlRemoveBindings.Visible = false;
        }

        private void CreateWebsite_Load(object sender, EventArgs e)
        {
            try
            {
                IPAddress[] iparr = Dns.GetHostAddresses(Dns.GetHostName());
                ctlIPList.Items.Add("*");
                foreach (IPAddress ip in iparr)
                    ctlIPList.Items.Add(ip);
                ctlIPList.SelectedIndex = 0;

                AppPoolBaseInfo[] appArr = _iisMgr.AppPoolList;

                foreach (AppPoolBaseInfo app in appArr)
                    ctlAppList.Items.Add(app.PoolName);
                ctlAppList.Text = "DefaultAppPool";
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void ctlAddBindings_Click(object sender, EventArgs e)
        {
            try
            {
                SmInt.ControlIntValue(int.Parse(ctlPort.Text), 1, 65535, true);
                string ip = null;
                if (ctlIPList.Text == "*")
                    ip = "";
                else
                    ip = ctlIPList.Text;
                string bindingsString = ip + ":" + ctlPort.Text + ":" + ctlDomain.Text;
                ctlDomain.Text = "";
                ctlBindingsList.Items.Add(bindingsString);
            }
            catch (Exception ex) { _g.PopErrorMessage(ex.Message); }
        }
        private void ctlRemoveBindings_Click(object sender, EventArgs e)
        {
            ctlBindingsList.Items.Remove(ctlBindingsList.Items[ctlBindingsList.SelectedIndex]);
            if (ctlBindingsList.Items.Count == 0)
                ctlRemoveBindings.Visible = false;
        }
        private void ctlSelectDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "清选择一个目录作为网站的运行的根目录";
            if (ctlDirectory.Text != "")
                fbd.SelectedPath = ctlDirectory.Text;
            fbd.ShowDialog();
            if (fbd.SelectedPath != null || fbd.SelectedPath != "")
                ctlDirectory.Text = fbd.SelectedPath;
        }

        private void ctlUserSec_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Enabled = ctlUserSec.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ctlUserPanel.Visible = !ctlAutoUserSec.Checked;
        }

        #region 安全用户的设置操作
        private void ctlAutoUserSec_CheckedChanged(object sender, EventArgs e)
        {
            if (ctlAutoUserSec.Checked)
            {
                UserSec = 1;
                ctlUserPanel.Enabled = false;
            }
        }
        private void ctlManualUserSec_CheckedChanged(object sender, EventArgs e)
        {
            if (ctlManualUserSec.Checked)
            {
                UserSec = 2;
                ctlUserTip.Text = "新用户";
                ctlUserPanel.Enabled = true;
            }
        }
        private void ctlSetUserSec_CheckedChanged(object sender, EventArgs e)
        {
            if (ctlSetUserSec.Checked)
            {
                UserSec = 3;
                ctlUserTip.Text = "用户名";
                ctlUserPanel.Enabled = true;
            }

        }
        #endregion

        #region 脚本设置的操作
        private void ctlRb1_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) Scripts = 0;
        }
        private void ctlRb2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) Scripts = 1;
        }
        private void ctlRb3_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) Scripts = 2;
        }
        private void ctlRb4_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) Scripts = 3;
        }
        private void ctlRb5_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked) Scripts = 4;
        }
        #endregion

        private void ctlConfirm_Click(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            Thread _th_create = new Thread(_proc_th_create);
            _th_create.IsBackground = true;
            _th_create.Start();
        }
        void _proc_th_create()
        {
            ctlConfirm.Enabled = false;
            if (ctlSiteName.Text == "")
            {
                MessageBox.Show("网站名称不能为空！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctlConfirm.Enabled = true;
                return;
            }
            if (!Directory.Exists(ctlDirectory.Text))
            {
                MessageBox.Show("网站目录不存在！", "提示！", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ctlConfirm.Enabled = true;
                return;
            }
            if (ctlBindingsList.Items.Count == 0)
            {
                if (MessageBox.Show("你没有绑定域名，要绑定域名只要在域名栏填写域名添加即可。\r\n你确认不绑定域名吗？\r\n没有绑定的站点可能会无法启动！", "que_", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    ctlConfirm.Enabled = true;
                    return;
                }
            }

            ctlStatus.Text = "开始...";
            NewWebSiteInfo wsinfo = new NewWebSiteInfo();
            IdentityAuthInfo secUser = new IdentityAuthInfo();
            int siteNum = _iisMgr.MakeupNewWebsiteID();

            if (ctlUserSec.Checked)
            {
                switch (UserSec)
                {
                    case 1:
                        secUser.IdentityString = "IUSR_SMIISMgr_" + siteNum.ToString();
                        secUser.PasswordCode = new Random().Next(100000, 999999).ToString();
                        break;
                    case 2:
                        secUser.IdentityString = ctlSecUser.Text;
                        secUser.PasswordCode = ctlSecPassword.Text;
                        break;
                    case 3:
                        secUser.IdentityString = ctlSecUser.Text;
                        secUser.PasswordCode = ctlSecPassword.Text;
                        break;
                    default:
                        MessageBox.Show("清选择[安全]设置中的选项！", "Info_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        ctlConfirm.Enabled = true;
                        return;
                }
            }

            if (ctlSetDirectorySec.Checked) ctlStatus.Text += "处理目录安全...";
            ///////////////////////////////////////////创建用户和组
            if (UserSec == 1 || UserSec == 2)
            {
                if (string.IsNullOrEmpty(secUser.IdentityString) || string.IsNullOrEmpty(secUser.PasswordCode))
                {
                    MessageBox.Show("清选择[安全]设置中指定的用户名密码不能为空！", "Info_", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ctlConfirm.Enabled = true;
                    return;
                }

                ctlStatus.Text += "创建用户...";
                SAM sam = new SAM();
                if (!sam.ExistIdentity("SmIISMgrGroup"))
                {
                    try
                    {
                        sam.CreateGroup("SmIISMgrGroup", "银月IIS工具创建的用户组");
                        _g.LoggerObj.WriteLogLine("(IIS)创建系统组 SmIISMgrGroup");
                    }
                    catch (Exception ex)
                    {
                        _g.LoggerObj.WriteLogLine("(IIS)错误:" + ex.Message);
                        ctlStatus.Text += "有错误发生，中止！";
                        ctlConfirm.Enabled = true;
                        return;
                    }
                }
                NTUserInfo userinfo = new NTUserInfo();
                userinfo.Description = "银月IIS工具创建 " + ctlSiteName.Text + "(" + siteNum.ToString() + ")站点的账户";
                userinfo.Username = secUser.IdentityString;
                userinfo.Password = secUser.PasswordCode;
                try
                {
                    sam.CreateUser(userinfo);
                    _g.LoggerObj.WriteLogLine("(IIS)创建系统用户(" + userinfo.Username + ")");
                    sam.AddUserToGroup(secUser.IdentityString, "SmIISMgrGroup");

                    //设置用户到目录
                    if (ctlSecUserSetToDirectory.Checked)
                    {
                        ctlStatus.Text += "设置用户目录安全...";
                        ACL.AddAccessRule(ctlDirectory.Text, secUser.IdentityString);
                    }
                }
                catch (Exception ex)
                {
                    _g.LoggerObj.WriteLogLine("(IIS)错误:" + ex.Message);
                    ctlStatus.Text += "有错误发生，中止！";
                    ctlConfirm.Enabled = true;
                    return;
                }

            }
            else if (UserSec == 3)
            {
                try
                {
                    if (ctlSecUserSetToDirectory.Checked)
                    {
                        ctlStatus.Text += "设置用户目录安全...";
                        ACL.AddAccessRule(ctlDirectory.Text, secUser.IdentityString);
                    }
                }
                catch (Exception ex)
                {
                    _g.LoggerObj.WriteLogLine("(IIS)错误:" + ex.Message);
                    ctlStatus.Text += "有错误发生，中止！";
                    ctlConfirm.Enabled = true;
                    return;
                }

            }
            ///////////////////////////////////////////创建用户和组 end

            ctlStatus.Text += "实例...";
            if (ctlUserSec.Checked) wsinfo.AccessUser = secUser;
            wsinfo.SiteName = ctlSiteName.Text;
            wsinfo.DirectoryPath = ctlDirectory.Text;

            ArrayList bindingsArray = new ArrayList();
            for (int i = 0; i < ctlBindingsList.Items.Count; i++)
            { bindingsArray.Add(ctlBindingsList.Items[i].ToString()); }
            object bindingsObj = (object)bindingsArray.ToArray(typeof(object));

            wsinfo.Bindings = bindingsObj;
            wsinfo.AppPoolName = ctlAppList.Text;
            wsinfo.LogFileLocaltimeRollover = ctlLogUseLocalTime.Checked;
            if (ctlLogSetToD.Checked) wsinfo.LogFileDirectory = @"D:\LogFiles\";

            ctlStatus.Text += "创建...";

            _iisMgr.CreateNewWebSite(wsinfo);
            ctlStatus.Text += "完成....";
            MessageBox.Show("创建完成，如果 您选择了安全设置，请放心，已经帮你设置好了。\r\n\r\n更多操作请到IIS管理器中设置。\r\n 注意：用本工具创建的网站最好也用本工具删除！");
            if (WebsiteCreated != null) { WebsiteCreated(wsinfo.SiteName); }
            Thread.Sleep(1000);
            Close();
        }

        private void ctlSecUser_DoubleClick(object sender, EventArgs e)
        {
            if (ctlSecUser.Text == "")
                ctlSecUser.Text = "IUSR_";
        }

        private void CreateWebsite_FormClosing(object sender, FormClosingEventArgs e)
        {
            WebsiteCreated = null;
        }

        private void ctlMoreOptionsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ctlMoreOptionsCheckBox.Checked) this.Height = 480;
            else this.Height = 364;
        }
    }
    public delegate void IISHander(string webSiteName);
}