using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using Silmoon.IO.SmFile;
using System.Diagnostics;

namespace SST.Ext.Security
{
    public partial class FileSecuritySetupForm : Form
    {
        GBC _g;
        Timer _t;
        FileSecuritySettingsClass fssecClass;
        bool _busy = false;

        public FileSecuritySetupForm(GBC g)
        {
            _g = g;
            InitializeComponent();
            this.Icon = SST.Resource.Resource.SSTIco2;
            _t = new Timer();
            _t.Tick += new EventHandler(_t_Tick);
            _t.Interval = 1000;
            fssecClass = new FileSecuritySettingsClass(_g);
            Show();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        void _t_Tick(object sender, EventArgs e)
        {
            TipStatus.Text = "...";
            _t.Stop();
        }

        private void SetPHPSecurity_Click(object sender, EventArgs e)
        {
            try
            {
                fssecClass.PhpFileSecuritySettings();
                TipStatus.Text = "C:\\PHP 处理完毕";
                _t.Start();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void SetSpecialFileSecurity_Click(object sender, EventArgs e)
        {
            try
            {
                fssecClass.SetSpecialFileSecurity();

                TipStatus.Text = "处理完毕";
                _t.Start();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        private void ResetSpecialFileSecurity_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("恢复设置好的特殊文件权限？", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    fssecClass.ResetSpecialFileSecurity();
                    TipStatus.Text = "处理完毕";
                    _t.Start();
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        private void CWizard_Click(object sender, EventArgs e)
        {
            new DriverFileSecurityWizard(_g);
        }
        private void ResetCACL_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("确定要重置C盘文件的所有权限？\r\n这将导致系统盘的所有目录及文件权限恢复较弱的安全设置！", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Process p = new Process();
                    p.StartInfo.WorkingDirectory = @"C:\windows\system32";
                    p.StartInfo.FileName = @"Secedit";
                    p.StartInfo.Arguments = @" /configure /db C:\windows\security\database\cvtfs.sdb /Cfg ""C:\windows\security\templates\setup security.inf"" /areas filestore";
                    p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    p.EnableRaisingEvents = true;
                    p.Exited += new EventHandler(p_Exited);
                    p.Start();
                    TipStatus.Text = "执行中，等待进程完成...";
                    groupBox1.Enabled = false;
                    _busy = true;
                    _g.LoggerObj.WriteLogLine("重置C盘文件权限开始...");
                }
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }

        void p_Exited(object sender, EventArgs e)
        {
            try
            {
                _g.LoggerObj.WriteLogLine("线程退出，重置C盘完成");
                Control.CheckForIllegalCrossThreadCalls = false;
                groupBox1.Enabled = true;
                TipStatus.Text = "执行完毕...";
                _busy = false;
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
            Process p = (Process)sender;
            p.Exited -= new EventHandler(p_Exited);
            p.Close();
            p.Dispose();
            p = null;
        }

        private void FileSecuritySetupForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (_busy)
                {
                    if (MessageBox.Show("窗口正忙，确定要退出？\r\n建议等待完成工作后关闭窗体", "关闭？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                    { e.Cancel = true; }
                }
            }
        }
        private void FileSecuritySetupForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            fssecClass.Dispose();
        }

        private void ctlServUFileSecurityButton_Click(object sender, EventArgs e)
        {
            int i = fssecClass.RejectIISUser("请指定Serv-U的安装目录!\r\n一定要指定Serv-U的安装目录!\r\n否则IIS运行不正常。");
            if (i == 1) MessageBox.Show("操作完成！", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (i == 2) MessageBox.Show("取消操作！", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("操作错误！", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ctlReServUFileSecurityButton_Click(object sender, EventArgs e)
        {
            int i = fssecClass.ResetRejectIISUser("请指定Serv-U已经设置过的目录");
            if (i == 1) MessageBox.Show("操作完成！", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if (i == 2) MessageBox.Show("取消操作！", "_war", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else MessageBox.Show("操作错误！", "_err", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }
}