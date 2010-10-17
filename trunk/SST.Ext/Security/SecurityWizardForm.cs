using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SST.Ext.Security;
using System.Threading;

namespace SST.Ext.Security
{
    public partial class SecurityWizardForm : Form
    {
        GBC _g;
        Thread _th;
        FileSecuritySettingsClass filesecClass;
        ModuleSecuritySettingsClass modulesecClass;
        //ISynchronizeInvoke thisAsync;
        delegate void StepOK(int step);
        bool settingsRunning = false;

        public SecurityWizardForm(GBC g)
        {
            _g = g;
            _g.LoggerObj.OnLogRecording += new LogEventHander(LoggerObj_OnLogRecording);
            filesecClass = new FileSecuritySettingsClass(_g);
            modulesecClass = new ModuleSecuritySettingsClass(_g);
            InitializeComponent();
            Show();
            //thisAsync = this;
        }

        void LoggerObj_OnLogRecording(string[] logArr, string newLine, int logLevel)
        {
            if (logLevel == 0)
                WriteLine(newLine);
        }
        private void SettingsWizardForm_Shown(object sender, EventArgs e)
        {
            this.Icon = SST.Resource.Resource.SSTIco2;
            Startsettings();
        }
        private void SecurityWizardForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            filesecClass.Dispose();
            modulesecClass.Dispose();
            _g.LoggerObj.OnLogRecording -= new LogEventHander(LoggerObj_OnLogRecording);
            Dispose(true);
        }

        private void Startsettings()
        {
            textBox1.Text = "";
            if (MessageBox.Show("开始设置服务器？", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _th = new Thread(_th_setwizard_thread);
                _th.IsBackground = true;
                settingsRunning = true;
                _th.Start();
            }
            else Write("你取消了服务器的设置导向...");
        }

        #region 过程
        private void _th_setwizard_thread()
        {
            Write("确认开始服务器设置...");
            if (MessageBox.Show("安装PHP？", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteLine("开始安装...");
                SST.Ext.IIS.PhpInstaller phpInstall = new SST.Ext.IIS.PhpInstaller(_g);
                phpInstall.InstallerCompleted += new CancelEventHandler(SecurityWizardForm_InstallerCompleted);
                phpInstall.Start();
            }
            else StepChange(2);
        }
        void SecurityWizardForm_InstallerCompleted(object sender, CancelEventArgs e)
        {
            Write("完成");

            if (!e.Cancel)
            {
                WriteLine("设置PHP文件夹安全...");
                filesecClass.PhpFileSecuritySettings();
                Write("完成");
            }

            StepChange(2);
        }

        private void SettingsStep2()
        {
            if (MessageBox.Show("让程序帮助你设置系统盘（C:）的安全？", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteLine("设置系统盘安全中...");
                new Security.CDriverWizardClass(_g, true).OnSetAccessRuleStatusChange += new SST.Ext.Security.AccessRuleSetHander(SettingsWizardForm_SetAccessRuleStatusChange);
            }
            else
            {
                WriteLine("你取消了设置系统盘安全...");
                StepChange(3);
            }

        }
        void SettingsWizardForm_SetAccessRuleStatusChange(object sender, SST.Ext.Security.AccessRuleSetArgs e)
        {
            if (e.Type == Security.AccessRuleSetType.Finished)
            {
                WriteLine("系统盘工作 完成");
                //thisAsync.Invoke(new StepOK(StepChange), new object[] { 3 });
                this.Invoke(new StepOK(StepChange), new object[] { 3 });
            }
            else
            {
                if (e.Type == Security.AccessRuleSetType.Appling)
                    WriteLine("设置 " + e.FilePath + "...");
                else if (e.Type == Security.AccessRuleSetType.ProcessFile)
                    WriteLine("操作 " + e.FilePath + "...");
                else if (e.Type == Security.AccessRuleSetType.Applied)
                    Write("完成");
            }
        }

        private void SettingsStep3()
        {
            if (MessageBox.Show("设置特殊文件的安全性？", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteLine("设置特殊文件安全中...");
                filesecClass.SetSpecialFileSecurity();
                Write("完成");
            }
            else WriteLine("你取消了设置特殊文件的安全性设置");
            StepChange(4);
        }
        private void SettingsStep4()
        {
            if (MessageBox.Show("卸载高危组件？", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                modulesecClass.UninstallUnSecurityMobule();
            else
                WriteLine("你取消了卸载高危组件");
            StepChange(5);
        }
        private void SettingsStep5()
        {
            WriteLine("基础安全导向完毕！");
        }
        #endregion

        public void WriteLine(string s)
        {
            textBox1.Text += "\r\n" + s;
        }
        public void Write(string s)
        {
            textBox1.Text += s;
        }


        private void 停止设置终止线程SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsRunning = false;
        }
        private void 重新开始导向SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!settingsRunning) { Startsettings(); }
        }

        void StepChange(int step)
        {
            if (!settingsRunning)
            {
                WriteLine("线程终止！");
                this.Text = "安全导向";
                if (_th != null)
                {
                    if (_th.ThreadState == ThreadState.Background) _th.Abort();
                }

                return;
            }
            this.Text = "安全导向 " + step.ToString();

            switch (step)
            {
                case 2:
                    SettingsStep2();
                    break;
                case 3:
                    Thread _th = new Thread(SettingsStep3);
                    _th.IsBackground = true;
                    _th.Start();
                    break;
                case 4:
                    SettingsStep4();
                    break;
                case 5:
                    SettingsStep5();
                    settingsRunning = false;
                    break;
                default:
                    break;
            }
        }
    }
}