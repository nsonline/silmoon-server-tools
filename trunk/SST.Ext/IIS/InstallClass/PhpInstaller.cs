using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Net;
using System.Security.AccessControl;
using System.ComponentModel;

namespace SST.Ext.IIS
{
    public class PhpInstaller:IDisposable
    {
        GBC _g;
        Process _p = new Process();
        WebClient _wclt = new WebClient();
        public event CancelEventHandler InstallerCompleted;

        public PhpInstaller(GBC g)
        {
            _g = g;
        }
        public void Start()
        {
            try
            {
                if (MessageBox.Show("ȷ����װPHP��չ��", "����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _g.LoggerObj.WriteLogLine("(IISExt)��װIIS��չPHP...");
                    StartDownload();
                }
                else if (InstallerCompleted != null) { InstallerCompleted(this, new CancelEventArgs(true)); }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void StartDownload()
        {
            try
            {
                _g.LoggerObj.WriteLogLine("(IISExt)��ʼ���������PHP�ļ�...");
                _wclt.DownloadFileCompleted += new System.ComponentModel.AsyncCompletedEventHandler(_wclt_DownloadFileCompleted);
                _wclt.DownloadProgressChanged += new DownloadProgressChangedEventHandler(_wclt_DownloadProgressChanged);
                _wclt.DownloadFileAsync(new Uri("http://softinstall.client.silmoon.com/soft/php.exe"), "c:\\php.exe");
            }
            catch { }
        }

        void _wclt_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            _g.StatusLabel.Text = "PHP���½��� " + e.ProgressPercentage + "%";
        }
        void _wclt_DownloadFileCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                _g.PopErrorMessage(e.Error.ToString());
                return;
            }
            _g.LoggerObj.WriteLogLine("(IISExt)����PHP��չ�ļ����...");
            StartCopy();
        }

        private void StartCopy()
        {
            _g.LoggerObj.WriteLogLine("(IISExt)����PHP�ļ�C:\\PHP...");
            _p.EnableRaisingEvents = true;
            _p.Exited += new EventHandler(_p_Exited);
            _p.StartInfo.FileName = "c:\\php.exe";
            _p.Start();
        }

        void _p_Exited(object sender, EventArgs e)
        {
            _g.LoggerObj.WriteLogLine("(IISExt)�������C:\\PHP...");
            _g.LoggerObj.WriteLogLine("(IISExt)������ʱ�ļ�PHP...");
            try { File.Delete("c:\\php.exe"); }
            catch { }
            ConfigSystem();
        }
        private void ConfigSystem()
        {
            _g.LoggerObj.WriteLogLine("(IISExt)����ϵͳWINDOWSĿ¼..");

            _g.LoggerObj.WriteLogLine("(IISExt)php.ini..");
            File.Copy(@"c:\php\php.ini", @"c:\windows\php.ini", true);

            _g.LoggerObj.WriteLogLine("(IISExt)php5ts.dll..");
            File.Copy(@"c:\php\php5ts.dll", @"c:\windows\php5ts.dll", true);

            _g.LoggerObj.WriteLogLine("(IISExt)libmysql.dll..");
            File.Copy(@"c:\php\libmysql.dll", @"c:\windows\libmysql.dll", true);

            DirectoryInfo dirinfo = new DirectoryInfo(@"c:\php\");
            DirectorySecurity dirsecurity = dirinfo.GetAccessControl();
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK SERVICE", FileSystemRights.ReadAndExecute, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("NETWORK", FileSystemRights.ReadAndExecute, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("Administrators", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("Administrators", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("SYSTEM", FileSystemRights.FullControl, InheritanceFlags.ContainerInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.AddAccessRule(new FileSystemAccessRule("SYSTEM", FileSystemRights.FullControl, InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow));
            dirsecurity.SetAccessRuleProtection(true, false);
            dirinfo.SetAccessControl(dirsecurity);
            _g.LoggerObj.WriteLogLine("(IISExt)����C:\\PHP �ļ�Ȩ��");

            InitWindow();
        }
        private void InitWindow()
        {
            _g.LoggerObj.WriteLogLine("(IISExt)�ļ��������..");
            MessageBox.Show("���漰����ע������������ Ϊ�˰�ȫ\r\n��������Ҫ����ֶ�������", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            MessageBox.Show("��װ��ɺ�Ҫ�ڰ�װZend��\r\n�Ѿ����㰲װ����Zend3.3.0", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PhpInstallerWindow win = new PhpInstallerWindow();
            win.FormClosed += new FormClosedEventHandler(win_FormClosed);
            Application.Run(win);
        }

        void win_FormClosed(object sender, FormClosedEventArgs e)
        {
            _g.LoggerObj.WriteLogLine("(IISExt)����ر�..");
            _wclt.DownloadFileCompleted -= new System.ComponentModel.AsyncCompletedEventHandler(_wclt_DownloadFileCompleted);
            _wclt.DownloadProgressChanged -= new DownloadProgressChangedEventHandler(_wclt_DownloadProgressChanged);
            if (InstallerCompleted != null) { InstallerCompleted(this, new CancelEventArgs(false)); }
            Dispose();
        }

        #region IDisposable ��Ա

        public void Dispose()
        {
            InstallerCompleted = null;

            if (_p == null)
            {
                _p.Close();
                _p.Dispose();
                _p = null;
            }
            if (_wclt == null)
            {
                _wclt.Dispose();
                _wclt = null;
            }
            InstallerCompleted = null;
        }

        #endregion
    }
}
