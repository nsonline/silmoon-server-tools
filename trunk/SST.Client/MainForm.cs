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

        #region 装载过程
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
                _g.LoggerObj.WriteLogLine("错误 加载DLL错误！" + ex.Message);
                _g.WriteException(ex.ToString());

                if (MessageBox.Show("程序在试图加载一个或者多个DLL时出错：\r\n" + ex.ToString() + "\r\n是否退出？（继续运行可能会出错）", "Error In DLL Loader", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    _g.LoggerObj.WriteLogLine("因为加载DLL错误，程序确认退出！");
                    _g.ExitApp();
                }
                else
                    _g.LoggerObj.WriteLogLine("因为加载DLL错误，根据用户请求，程序继续运行！");
            }
        }
        #endregion
        #region 初始化 来自 InitEvents()

        void _serviceCtrl_OnServiceStateChange(object sender, SmServiceEventArgs e)
        {
            string optionString = "";
            string resultString = "";
            switch (e.ServiceOption)
            {
                case ServiceOptions.Reset:
                    optionString = "重启"; break;
                case ServiceOptions.Start:
                    optionString = "启动"; break;
                case ServiceOptions.Stop:
                    optionString = "停止"; break;
                default: break;
            }

            switch (e.CompleteState)
            {
                case ServiceCompleteStateType.Error:
                    resultString = "错误"; break;
                case ServiceCompleteStateType.Trying:
                    resultString = "尝试中"; break;
                case ServiceCompleteStateType.Successfully:
                    resultString = "成功"; break;
                case ServiceCompleteStateType.NoExist:
                    resultString = "不存在"; break;
                case ServiceCompleteStateType.Disabled:
                    resultString = "被禁用"; break;
                case ServiceCompleteStateType.UncanStop:
                    resultString = "不能"; break;
                default:
                    resultString = e.CompleteState.ToString(); break;
            }
            if (e.CompleteState != ServiceCompleteStateType.Trying)
                _g.LoggerObj.WriteLogLine("服务事件：" + e.ServiceName + " " + resultString + " " + optionString);
            StatusLabel.Text = "服务事件：" + e.ServiceName + " " + resultString + " " + optionString;
        }
        void FileWatch_FileEvent(object sender, Silmoon.IO.FileEventArgs e)
        {
            string showString = "";
            switch (e.ChangeType)
            {
                case WatcherChangeTypes.Changed:
                    showString = "编辑";
                    break;
                case WatcherChangeTypes.Created:
                    showString = "创建";
                    break;
                case WatcherChangeTypes.Deleted:
                    showString = "删除";
                    break;
                case WatcherChangeTypes.Renamed:
                    showString = "重命名";
                    break;
                default:
                    break;
            }

            StatusLabel.Text = "文件事件：" + showString + " - " + e.FullPath;
        }
        void FileWatch_OnStart(object sender, CancelEventArgs e)
        {
            显示文件事件FToolStripMenuItem1.Checked = true;
            StatusLabel.Text = "组件事件：文件监控 开始";
        }
        void FileWatch_OnStop(object sender, CancelEventArgs e)
        {
            显示文件事件FToolStripMenuItem1.Checked = false;
            StatusLabel.Text = "组件事件：文件监控 停止";
        }
        void LoggerObj_OnLogRecording(string[] logArr, string newLine, int logLevel)
        {
            if (logLevel > 5) ctlmLogListBox.Items.Insert(0, "> " + newLine);
        }

        #endregion

        #region 菜单栏
        private void 退出XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _g.ExitApp();
        }

        private void 日志LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LogView(_g).Show();
        }
        internal void 工具栏TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (工具栏TToolStripMenuItem.Checked)
            {
                工具栏TToolStripMenuItem.Checked = false;
                this.Height = this.Height - 25;
            }
            else
            {
                工具栏TToolStripMenuItem.Checked = true;
                this.Height = this.Height + 25;
            }
            _g.Cfg.WriteConfig("ShowToolBar", 工具栏TToolStripMenuItem.Checked.ToString());
            TopToolMenu.Visible = 工具栏TToolStripMenuItem.Checked;
        }
        private void 显示文件事件FToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!显示文件事件FToolStripMenuItem1.Checked) _g.FileWatch.Start();
            else _g.FileWatch.Stop();
        }

        private void 重启IISIToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void 文件监控FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Ext.FileMon().Show(_g);
        }
        private void 端口修改EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new RDPPortEdit().Show(_g);
        }
        private void aRP免疫工具AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Tools.AntiARP(_g);
        }
        private void 更新系统时间TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SmTime.StaticAsyncLocalTime(false);
        }
        private void 服务器疑难杂症FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Tools.HardFixTool(_g);
        }
        private void 木马及代码扫描SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Tools.ScanCode(_g);
        }
        private void 可疑图片文件扫描PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.ImageFileChecker(_g);
        }
        private void 网络连接查看NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.Net.NetworkConnectionViewerForm(_g);
        }
        private void 网络数据包监控MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.Net.NetworkMonitorForm(_g);
        }

        private void 系统文件安全向导FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Security.FileSecuritySetupForm(_g);
        }
        private void 文件详细安全向导SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Security.FileSystemACLWizard(_g);
        }
        private void Windows防火墙设置FToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.WindowsFirewall.WindowsFirewallUtility(_g);
        }
        private void 其他安全设置OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Security.SecuritySettings(_g);
        }

        private void 高危组件HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new HServerModule(_g);
        }
        private void 组件下载器CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Utility.ServerPlusDownloader(_g).Show();
        }
        private void 一键安装PHPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new PhpInstaller(_g).Start();
        }
        private void 安装服务IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Server.SmSvrServ.SmSvrServForm(_g);
        }
        private void 查看日志LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Server.SmSvrServ.LogView(_g);
        }
        private void 清理LogFilesLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("cmd", @"/c del /q /s /f c:\windows\system32\logfiles\*.*");
        }
        private void 银月IIS管理器MToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISManagerForm(_g);
        }
        private void nET版本控制VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Tools.DotnetVersionConverter(_g);
        }
        private void iIS性能监控PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Performance.IISPerformanceViewList(_g);
        }
        private void iIS备份与恢复BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISBackupForm(_g);
        }
        private void iIS应用池管理AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.Performance.ApplicationPoolManagerForm();
        }
        private void iIS日志分析器LToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.IIS.IISLog.LogAnalysisForm();
        }
        private void mSSQL管理SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Database.MSSQL.MSSQLManager(_g).Show();
        }
        private void mySQL管理YToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.Database.MySQL.MySQLManager(_g).Show();
        }

        private void 设置程序SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Options.Settings(_g);
        }
        private void 重启程序RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _g.ResetApp();
        }

        private void 执行垃圾回收RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
        }
        private void 关于本程序AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Window.AboutForm(_g).ShowDialog();
        }
        private void 使用手册GToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SST.Ext.GuideForm(_g);
        }
        private void 检查升级UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Classes.UpdateClass(_g);
        }
        private void 程序主页HToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.silmoon.com.cn/?come=app_SSTClient");
        }
        private void 赞助链接ZToolStripMenuItem_Click(object sender, EventArgs e)
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
        private void 退出XToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MainTray.Dispose();
            _g.ExitApp();
        }
        #endregion
        #region 窗体和窗体事件
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
            日志LToolStripMenuItem_Click(sender, e);
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
                MainTray.ShowBalloonTip(1, "提示", "程序依然在运行\r\n\r\n按下'alt+ctrl+s'回到SST主窗口！", ToolTipIcon.Info);
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
                case "当前":
                    break;
                default:
                    break;
            }
        }
    }
}