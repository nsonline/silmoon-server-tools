using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Silmoon.Service.SystemService;
using Silmoon.Service;
using System.IO;
using System.Net;
using System.Diagnostics;
using System.Reflection;
using SST.Ext.IIS;
using SST.Client.Classes;
using SST.Client.Window;
using SST.Ext.Server;
using Silmoon.SmSystem;
using SST.Common;

namespace SST.Client
{
    public partial class MainForm : Form
    {
        GBC _g;
        NotifyIcon _tray;
        #region FormDrawUseClass
        MainFormHelper mainFormHelper;
        #endregion

        public MainForm(GBC g)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            MainTray.Icon = SST.Resource.Resource.ComputerTrayIcon;
            _g = g;
            _tray = _g.Tray;
            _g.StatusLabel = StatusLabel;
            mainFormHelper = new MainFormHelper(_g);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitForm();
        }

        #region װ�ع���
        private void InitForm()
        {
            try
            {
                mainFormHelper = new MainFormHelper(_g);

                InitControls();
                InitEvents();
                mainFormHelper.InitMainFormComponent();
                new Classes.BackEvents(_g);
                InitDLL();
                Application.DoEvents();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void InitControls()
        {
            testControl1._g = _g;
            generalPageControl1._g = _g;

            testControl1.StartControl();
            mainForm_Info1.StartControl(_g);
            mainForm_Info1.OnClickIpListLink += new EventHandler(mainForm_Info1_OnClickIpListLink);
        }
        private void InitEvents()
        {
            _g.ServiceCtrl.OnServiceStateChange += new SmServiceEventHandler(_serviceCtrl_OnServiceStateChange);
            _g.FileWatch.FileEvent += new Silmoon.IO.FileEventHander(FileWatch_FileEvent);
            _g.FileWatch.OnStart += new CancelEventHandler(FileWatch_OnStart);
            _g.FileWatch.OnStop += new CancelEventHandler(FileWatch_OnStop);
            _g.LoggerObj.OnLogRecording += new LogEventHander(LoggerObj_OnLogRecording);
        }
        public void InitDLL()
        {
            try
            {
                ISSTPlus dllManager = new SST.DLLManager.DLLManager();
                _g.plusManager.AddPlus(dllManager);
            }
            catch (Exception ex)
            {
                _g.LoggerObj.WriteLogLine("���� ����DLL����" + ex.Message);
                _g.WriteException(ex.ToString());

                if (MessageBox.Show("��������ͼ����һ�����߶��DLLʱ����\r\n" + ex.ToString() + "\r\n�Ƿ��˳������������п��ܻ����", "Error In DLL Loader", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    _g.LoggerObj.WriteLogLine("��Ϊ����DLL���󣬳���ȷ���˳���");
                    _g.ExitApp();
                }
                else
                    _g.LoggerObj.WriteLogLine("��Ϊ����DLL���󣬸����û����󣬳���������У�");
            }
        }
        #endregion
        #region ��ʼ�� ���� InitEvents()

        void _serviceCtrl_OnServiceStateChange(object sender, SmServiceEventArgs e)
        {
            string optionString = "";
            string resultString = "";
            switch (e.ServiceOption)
            {
                case ServiceOptions.Reset:
                    optionString = "����"; break;
                case ServiceOptions.Start:
                    optionString = "����"; break;
                case ServiceOptions.Stop:
                    optionString = "ֹͣ"; break;
                default: break;
            }

            switch (e.CompleteState)
            {
                case ServiceCompleteStateType.Error:
                    resultString = "����"; break;
                case ServiceCompleteStateType.Trying:
                    resultString = "������"; break;
                case ServiceCompleteStateType.Successfully:
                    resultString = "�ɹ�"; break;
                case ServiceCompleteStateType.NoExist:
                    resultString = "������"; break;
                case ServiceCompleteStateType.Disabled:
                    resultString = "������"; break;
                case ServiceCompleteStateType.UncanStop:
                    resultString = "����"; break;
                default:
                    resultString = e.CompleteState.ToString(); break;
            }
            if (e.CompleteState != ServiceCompleteStateType.Trying)
                _g.LoggerObj.WriteLogLine("�����¼���" + e.ServiceName + " " + resultString + " " + optionString);
            StatusLabel.Text = "�����¼���" + e.ServiceName + " " + resultString + " " + optionString;
        }
        void FileWatch_FileEvent(object sender, Silmoon.IO.FileEventArgs e)
        {
            string showString = "";
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Changed:
                    showString = "�༭";
                    break;
                case WatcherChangeTypes.Created:
                    showString = "����";
                    break;
                case WatcherChangeTypes.Deleted:
                    showString = "ɾ��";
                    break;
                case WatcherChangeTypes.Renamed:
                    showString = "������";
                    break;
                default:
                    break;
            }

            StatusLabel.Text = "�ļ��¼���" + showString + " - " + e.FullPath;
        }
        void FileWatch_OnStart(object sender, CancelEventArgs e)
        {
            ��ʾ�ļ��¼�FToolStripMenuItem1.Checked = true;
            StatusLabel.Text = "����¼����ļ���� ��ʼ";
        }
        void FileWatch_OnStop(object sender, CancelEventArgs e)
        {
            ��ʾ�ļ��¼�FToolStripMenuItem1.Checked = false;
            StatusLabel.Text = "����¼����ļ���� ֹͣ";
        }
        void LoggerObj_OnLogRecording(string[] logArr, string newLine, int logLevel)
        {
            if (logLevel > 5) ctlmLogListBox.Items.Insert(0, "> " + newLine);
        }

        #endregion

        #region �˵���
        private void �˳�XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _g.ExitApp();
        }

        private void ��־LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LogView(_g).Show();
        }
        internal void ������TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (������TToolStripMenuItem.Checked)
            {
                ������TToolStripMenuItem.Checked = false;
                this.Height = this.Height - 25;
            }
            else
            {
                ������TToolStripMenuItem.Checked = true;
                this.Height = this.Height + 25;
            }
            _g.Cfg.WriteConfig("ShowToolBar", ������TToolStripMenuItem.Checked.ToString());
            TopToolMenu.Visible = ������TToolStripMenuItem.Checked;
        }
        private void ��ʾ�ļ��¼�FToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!��ʾ�ļ��¼�FToolStripMenuItem1.Checked) _g.FileWatch.Start();
            else _g.FileWatch.Stop();
        }

        private void ����IISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _g.ServiceCtrl.AsyncService("w3svc", ServiceOptions.Reset);
        }
        private void iISIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ext.ServiceControlForm(_g, "w3svc");
        }
        private void mySQLMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ext.ServiceControlForm(_g, "mysql");
        }
        private void mSSQLSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ext.ServiceControlForm(_g, "mssqlserver");
        }

        private void �ļ����FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ext.FileMon().Show(_g);
        }
        private void �˿��޸�EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RDPPortEdit().Show(_g);
        }
        private void aRP���߹���AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Tools.AntiARP(_g);
        }
        private void ����ϵͳʱ��TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmTime.StaticAsyncLocalTime(false);
        }
        private void ������������֢FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Tools.HardFixTool(_g);
        }
        private void ľ������ɨ��SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Tools.ScanCode(_g);
        }
        private void ����ͼƬ�ļ�ɨ��PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.ImageFileChecker(_g);
        }
        private void �������Ӳ鿴NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.Net.NetworkConnectionViewerForm(_g);
        }
        private void �������ݰ����MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.Net.NetworkMonitorForm(_g);
        }

        private void ϵͳ�ļ���ȫ��FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Security.FileSecuritySetupForm(_g);
        }
        private void �ļ���ϸ��ȫ��SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Security.FileSystemACLWizard(_g);
        }
        private void Windows����ǽ����FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.WindowsFirewall.WindowsFirewallUtility(_g);
        }
        private void ������ȫ����OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Security.SecuritySettings(_g);
        }

        private void ��Σ���HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HServerModule(_g);
        }
        private void ���������CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.ServerPlusDownloader(_g).Show();
        }
        private void һ����װPHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhpInstaller(_g).Start();
        }
        private void ��װ����IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Server.SmSvrServ.SmSvrServForm(_g);
        }
        private void �鿴��־LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Server.SmSvrServ.LogView(_g);
        }
        private void ����LogFilesLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", @"/c del /q /s /f c:\windows\system32\logfiles\*.*");
        }
        private void ����IIS������MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISManagerForm(_g);
        }
        private void nET�汾����VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Tools.DotnetVersionConverter(_g);
        }
        private void iIS���ܼ��PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Performance.IISPerformanceViewList(_g);
        }
        private void iIS������ָ�BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISBackupForm(_g);
        }
        private void iISӦ�óع���AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Performance.ApplicationPoolManagerForm();
        }
        private void iIS��־������LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISLog.LogAnalysisForm();
        }
        private void mSSQL����SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Database.MSSQL.MSSQLManager(_g).Show();
        }
        private void mySQL����YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Database.MySQL.MySQLManager(_g).Show();
        }

        private void ���ó���SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Options.Settings(_g);
        }
        private void ��������RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _g.ResetApp();
        }

        private void ִ����������RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
        private void ���ڱ�����AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Window.AboutForm(_g).ShowDialog();
        }
        private void ʹ���ֲ�GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.GuideForm(_g);
        }
        private void �������UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Classes.UpdateClass(_g);
        }
        private void ������ҳHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.silmoon.com.cn/?come=app_SSTClient");
        }
        private void ��������ZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.silmoon.com/System/Interface/Payment/PayLink.aspx?paylink=1topay&return=False");
        }

        #endregion
        #region ToolMenu
        private void CT_OpenIIS_Click(object sender, EventArgs e)
        {
            _g.TryOpenProcess(@"c:\windows\system32\inetsrv\iis.msc");
        }
        private void CT_SmServLog_Click(object sender, EventArgs e)
        {
            new SST.Ext.Server.SmSvrServ.LogView(_g);
        }
        #endregion

        #region MainTrayMenu
        private void �˳�XToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainTray.Dispose();
            _g.ExitApp();
        }
        #endregion
        #region ����ʹ����¼�
        void mainForm_Info1_OnClickIpListLink(object sender, EventArgs e)
        {
            new ListForm(1, _g);
        }


        public void MainTray_DoubleClick(object sender, EventArgs e)
        {
            this.Visible = true;
            MainTray.Visible = false;
            this.WindowState = FormWindowState.Normal;

            Silmoon.Windows.Win32.API.USER32.setForegroundWindow(this.Handle);
        }

        private void LogListBox_DoubleClick(object sender, EventArgs e)
        {
            ��־LToolStripMenuItem_Click(sender, e);
        }
        private void SecurityWizardButton_Click(object sender, EventArgs e)
        {
            new SST.Ext.Security.SecurityWizardForm(_g);
        }
        private void C_ResetW3svcButton_Click(object sender, EventArgs e)
        {
            _g.ServiceCtrl.AsyncService("w3svc", ServiceOptions.Reset);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                MainTray.Visible = true;
                this.WindowState = FormWindowState.Minimized;
                this.Visible = false;
                MainTray.ShowBalloonTip(1, "��ʾ", "������Ȼ������\r\n\r\n����'alt+ctrl+s'�ص�SST�����ڣ�", ToolTipIcon.Info);
            }
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
            mainFormHelper.MainFormShowed();
        }
        #endregion

        #region page1
        #endregion

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tab = tabControl1.TabPages[tabControl1.SelectedIndex].Text;

            switch (tab)
            {
                case "��ǰ":
                    break;
                default:
                    break;
            }
        }
    }
}