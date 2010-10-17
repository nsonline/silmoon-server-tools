using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Windows.Server.IIS;
using Silmoon.Configure;
using System.IO;
using Silmoon.Windows;
using Silmoon.IO.SmFile;
using Silmoon.Security;
using System.Collections;
using Silmoon;
using System.Threading;

namespace SST.Ext.IIS
{
    public partial class IISBackupForm : Form
    {
        IISManager _iisMgr = new IISManager();
        IISActionClass _iisac;
        bool isLoadIIS = false;
        string loadedFile = "";
        GBC _g;
        public IISBackupForm(GBC g)
        {
            _g = g;
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            _iisac = new IISActionClass(_iisMgr);
            Show();
        }

        private void ctlLoadIISSitesButton_Click(object sender, EventArgs e)
        {
            try
            {
                isLoadIIS = true;
                WebSiteBaseInfo[] binfoArr = _iisMgr.WebSiteList;
                ctlWebSiteListView.Items.Clear();
                ctlWebSiteListView.BeginUpdate();
                foreach (WebSiteBaseInfo binfo in binfoArr)
                {
                    WebSiteInfo winfo = _iisMgr.GetWebsiteInfo(binfo.SiteID);
                    ctlWebSiteListView.Items.Add(new ListViewItem(new string[] { winfo.SiteName, binfo.SiteID, winfo.DirectoryPath, winfo.AppPoolName, winfo.State.ToString() }));
                }
                ctlWebSiteListView.EndUpdate();
                MessageBox.Show("����ɹ�", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void ctlWebSitesBackupFileButton_Click(object sender, EventArgs e)
        {
            if (ctlWebSiteListView.Items.Count == 0)
            {
                MessageBox.Show("û����վ�ɹ����ݣ�");
                return;
            }
            if (!isLoadIIS)
            {
                MessageBox.Show("���Ǵ�IIS�е�����б��޷����ݣ�");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "���ñ���(*.ini)|*.ini";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName)) File.Delete(sfd.FileName);

                IniFile ini = new IniFile(sfd.FileName);
                ini.StringBufferSize = 65535;
                string[] websiteIDArray = new string[ctlWebSiteListView.Items.Count];
                ini.WriteInivalue("info", "total", websiteIDArray.Length.ToString());
                for (int i = 0; i < websiteIDArray.Length; i++)
                {
                    string countStr = ((int)i + 1).ToString();
                    websiteIDArray[i] = ctlWebSiteListView.Items[i].SubItems[1].Text;
                    WebSiteInfo winfo = _iisMgr.GetWebsiteInfo(websiteIDArray[i]);
                    ini.WriteInivalue(countStr, "ID", SmString.CutString(websiteIDArray[i], 5));
                    ini.WriteInivalue(countStr, "SiteName", winfo.SiteName);
                    ini.WriteInivalue(countStr, "DirectoryPath", winfo.DirectoryPath);
                    ini.WriteInivalue(countStr, "AppPoolName", winfo.AppPoolName);
                    ini.WriteInivalue(countStr, "LogFileLocaltimeRollover", winfo.LogFileLocaltimeRollover.ToString());
                    ini.WriteInivalue(countStr, "LogFileDirectory", winfo.LogFileDirectory);
                    string bindingsString = null;
                    string[] bindingsArray = IISManager.GetIISConfigObjectArray(winfo.Bindings);

                    foreach (string s in bindingsArray)
                    { bindingsString += s + ","; }
                    ini.WriteInivalue(countStr, "Bindings", bindingsString);
                }
                MessageBox.Show("�������", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void ctlLoadBackupFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                isLoadIIS = false;
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "���ñ���(*.ini)|*.ini";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    IniFile ini = new IniFile(ofd.FileName);
                    ini.StringBufferSize = 65535;
                    loadedFile = ofd.FileName;
                    int inFileSiteTotal = int.Parse(ini.ReadInivalue("info", "total"));

                    ctlWebSiteListView.Items.Clear();
                    for (int i = 0; i < inFileSiteTotal; i++)
                    {
                        string idString = ((int)(i + 1)).ToString();
                        string id = ini.ReadInivalue(idString, "ID");
                        string stateString = "δ����";
                        if (_iisMgr.IsExistWebSite(id)) stateString = "�Ѵ���";
                        ctlWebSiteListView.Items.Add(new ListViewItem(new string[] { ini.ReadInivalue(idString, "SiteName"), id, ini.ReadInivalue(idString, "DirectoryPath"), ini.ReadInivalue(idString, "AppPoolName"), stateString }));
                    }
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void ctlCreateAllListSitesButton_Click(object sender, EventArgs e)
        {
            _ExecAsync(createAllListSites);
        }
        private void createAllListSites()
        {
            if (_CheckLoadFile())
            {
                RefInt32Array[] siteIDArray = new RefInt32Array[ctlWebSiteListView.Items.Count];
                for (int i = 0; i < siteIDArray.Length; i++)
                {
                    siteIDArray[i] = new RefInt32Array();
                    siteIDArray[i].parameter = int.Parse(ctlWebSiteListView.Items[i].SubItems[1].Text);
                    siteIDArray[i].index = i;
                }
                _CreateWebSites(siteIDArray);
            }
        }

        private void ctlCreateNotExistSitesButton_Click(object sender, EventArgs e)
        {
            _ExecAsync(createNotExistSites);
        }
        private void createNotExistSites()
        {
            if (_CheckLoadFile())
            {
                IniFile ini = new IniFile(loadedFile);
                ini.StringBufferSize = 65535;
                ArrayList array = new ArrayList();
                for (int i = 0; i < ctlWebSiteListView.Items.Count; i++)
                {
                    if (ctlWebSiteListView.Items[i].SubItems[4].Text == "δ����")
                    {
                        RefInt32Array siteIDInfo = new RefInt32Array();
                        siteIDInfo.parameter = int.Parse(ctlWebSiteListView.Items[i].SubItems[1].Text);
                        siteIDInfo.index = i;
                        array.Add(siteIDInfo);
                    }
                }
                RefInt32Array[] siteIDArray = (RefInt32Array[])array.ToArray(typeof(RefInt32Array));
                _CreateWebSites(siteIDArray);
            }
        }

        private void ctlCreateSelectedSitesButton_Click(object sender, EventArgs e)
        {
            _ExecAsync(createSelectedSites);
        }
        private void createSelectedSites()
        {
            if (_CheckLoadFile())
            {
                IniFile ini = new IniFile(loadedFile);
                ArrayList array = new ArrayList();
                for (int i = 0; i < ctlWebSiteListView.Items.Count; i++)
                {
                    if (ctlWebSiteListView.Items[i].Selected)
                    {
                        RefInt32Array siteIDInfo = new RefInt32Array();
                        siteIDInfo.parameter = int.Parse(ctlWebSiteListView.Items[i].SubItems[1].Text);
                        siteIDInfo.index = i;
                        array.Add(siteIDInfo);
                    }
                }
                RefInt32Array[] siteIDArray = (RefInt32Array[])array.ToArray(typeof(RefInt32Array));
                _CreateWebSites(siteIDArray);
            }
        }
        
        void _CreateWebSites(RefInt32Array[] siteIDArray)
        {
            bool isCreateSecurity = false;
            if (MessageBox.Show("��ÿ����վ���������İ�ȫ��", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                isCreateSecurity = true;

            bool isExistSiteRecreate = false;
            if (MessageBox.Show("���ڴ��ڵ�վ���Ƿ����´�����", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                isExistSiteRecreate = true;

            for (int i = 0; i < siteIDArray.Length; i++)
            {
                string id = siteIDArray[i].parameter.ToString();
                int index = siteIDArray[i].index;
                if (_iisMgr.IsExistWebSite(id))
                {
                    if (isExistSiteRecreate)
                    {
                        ctlWebSiteListView.Items[index].BackColor = Color.Gray;
                        ctlsStateText.Text = "ɾ��վ��...";
                        _iisac.DeleteWebSite(id);
                    }
                    else
                    {
                        ctlWebSiteListView.Items[index].BackColor = Color.Cyan;
                        ctlWebSiteListView.Items[index].SubItems[4].Text = "��������";
                        continue;
                    }
                }

                ctlWebSiteListView.Items[index].BackColor = Color.Yellow;

                if (_CreateWebSite(((int)(index+1)).ToString(), isCreateSecurity, i))
                {
                    ctlWebSiteListView.Items[index].BackColor = Color.GreenYellow;
                    ctlWebSiteListView.Items[index].SubItems[4].Text = "�������";
                }
                else
                {
                    ctlWebSiteListView.Items[index].BackColor = Color.Red;
                    ctlWebSiteListView.Items[index].SubItems[4].Text = "��������";
                }
            }
            ctlsStateText.Text = "�������";
        }
        bool _CreateWebSite(string sectionID, bool createSecurity, int listViewIndex)
        {
            if (_iisMgr.IsExistWebSite(sectionID)) return false;

            IniFile ini = new IniFile();
            ini.StringBufferSize = 65535;

            if (File.Exists(loadedFile))
                ini.FilePath = loadedFile;
            else return false;

            string siteID = ini.ReadInivalue(sectionID, "ID");

            NewWebSiteInfo wsinfo = new NewWebSiteInfo();
            IdentityAuthInfo secUser = new IdentityAuthInfo();

            if (createSecurity)
            {
                secUser.IdentityString = "IUSR_SMIISMgr_" + siteID;
                secUser.PasswordCode = new Random().Next(100000, 999999).ToString();

                SAM sam = new SAM();
                if (!sam.ExistIdentity("SmIISMgrGroup"))
                {
                    ctlsStateText.Text = "����ϵͳ��...";
                    try
                    { sam.CreateGroup("SmIISMgrGroup", "����IIS���ߴ������û���"); }
                    catch { return false; }
                }
                NTUserInfo userinfo = new NTUserInfo();
                userinfo.Description = "����IIS���ߴ��� " + ini.ReadInivalue(sectionID, "SiteName") + "(" + siteID + ")վ����˻�";
                userinfo.Username = secUser.IdentityString;
                userinfo.Password = secUser.PasswordCode;
                userinfo.Fullname = secUser.IdentityString;
                try
                {
                    ctlsStateText.Text = "����ϵͳ�û�...";
                    sam.CreateUser(userinfo);
                    sam.AddUserToGroup(secUser.IdentityString, "SmIISMgrGroup");
                    ctlsStateText.Text = "������Ŀ¼��ȫ��...";
                    ACL.AddAccessRule(ini.ReadInivalue(sectionID, "DirectoryPath"), secUser.IdentityString);
                }
                catch { return false; }
            }

            ctlsStateText.Text = "�����㹻����Ϣ...";
            wsinfo.AccessUser = secUser;
            wsinfo.SiteName = ini.ReadInivalue(sectionID, "SiteName");
            wsinfo.DirectoryPath = ini.ReadInivalue(sectionID, "DirectoryPath");
            wsinfo.Bindings = ini.ReadInivalue(sectionID, "Bindings").Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            wsinfo.AppPoolName = ini.ReadInivalue(sectionID, "AppPoolName");
            wsinfo.LogFileLocaltimeRollover = SmString.StringToBool(ini.ReadInivalue(sectionID, "LogFileLocaltimeRollover"));
            wsinfo.LogFileDirectory = ini.ReadInivalue(sectionID, "LogFileDirectory");

            ctlsStateText.Text = "����վ��...";
            _iisMgr.CreateNewWebSite(wsinfo, int.Parse(siteID));
            return true;
        }

        bool _CheckLoadFile()
        {
            IniFile ini = new IniFile();
            ini.StringBufferSize = 65535;
            if (File.Exists(loadedFile))
            {
                ini.FilePath = loadedFile;
                return true;
            }
            else
            {
                MessageBox.Show("��δ���뱸���ļ�!");
                return false;
            }
        }
        void _ExecAsync(ThreadStart start)
        {
            Thread _th = new Thread(start);
            _th.IsBackground = true;
            _th.Start();
        }
        class RefInt32Array
        {
            public int index = -1;
            public int parameter = 0;
        }
    }
}