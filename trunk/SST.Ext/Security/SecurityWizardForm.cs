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
            if (MessageBox.Show("��ʼ���÷�������", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _th = new Thread(_th_setwizard_thread);
                _th.IsBackground = true;
                settingsRunning = true;
                _th.Start();
            }
            else Write("��ȡ���˷����������õ���...");
        }

        #region ����
        private void _th_setwizard_thread()
        {
            Write("ȷ�Ͽ�ʼ����������...");
            if (MessageBox.Show("��װPHP��", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteLine("��ʼ��װ...");
                SST.Ext.IIS.PhpInstaller phpInstall = new SST.Ext.IIS.PhpInstaller(_g);
                phpInstall.InstallerCompleted += new CancelEventHandler(SecurityWizardForm_InstallerCompleted);
                phpInstall.Start();
            }
            else StepChange(2);
        }
        void SecurityWizardForm_InstallerCompleted(object sender, CancelEventArgs e)
        {
            Write("���");

            if (!e.Cancel)
            {
                WriteLine("����PHP�ļ��а�ȫ...");
                filesecClass.PhpFileSecuritySettings();
                Write("���");
            }

            StepChange(2);
        }

        private void SettingsStep2()
        {
            if (MessageBox.Show("�ó������������ϵͳ�̣�C:���İ�ȫ��", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteLine("����ϵͳ�̰�ȫ��...");
                new Security.CDriverWizardClass(_g, true).OnSetAccessRuleStatusChange += new SST.Ext.Security.AccessRuleSetHander(SettingsWizardForm_SetAccessRuleStatusChange);
            }
            else
            {
                WriteLine("��ȡ��������ϵͳ�̰�ȫ...");
                StepChange(3);
            }

        }
        void SettingsWizardForm_SetAccessRuleStatusChange(object sender, SST.Ext.Security.AccessRuleSetArgs e)
        {
            if (e.Type == Security.AccessRuleSetType.Finished)
            {
                WriteLine("ϵͳ�̹��� ���");
                //thisAsync.Invoke(new StepOK(StepChange), new object[] { 3 });
                this.Invoke(new StepOK(StepChange), new object[] { 3 });
            }
            else
            {
                if (e.Type == Security.AccessRuleSetType.Appling)
                    WriteLine("���� " + e.FilePath + "...");
                else if (e.Type == Security.AccessRuleSetType.ProcessFile)
                    WriteLine("���� " + e.FilePath + "...");
                else if (e.Type == Security.AccessRuleSetType.Applied)
                    Write("���");
            }
        }

        private void SettingsStep3()
        {
            if (MessageBox.Show("���������ļ��İ�ȫ�ԣ�", "?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                WriteLine("���������ļ���ȫ��...");
                filesecClass.SetSpecialFileSecurity();
                Write("���");
            }
            else WriteLine("��ȡ�������������ļ��İ�ȫ������");
            StepChange(4);
        }
        private void SettingsStep4()
        {
            if (MessageBox.Show("ж�ظ�Σ�����", "ѯ��", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                modulesecClass.UninstallUnSecurityMobule();
            else
                WriteLine("��ȡ����ж�ظ�Σ���");
            StepChange(5);
        }
        private void SettingsStep5()
        {
            WriteLine("������ȫ������ϣ�");
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


        private void ֹͣ������ֹ�߳�SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsRunning = false;
        }
        private void ���¿�ʼ����SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!settingsRunning) { Startsettings(); }
        }

        void StepChange(int step)
        {
            if (!settingsRunning)
            {
                WriteLine("�߳���ֹ��");
                this.Text = "��ȫ����";
                if (_th != null)
                {
                    if (_th.ThreadState == ThreadState.Background) _th.Abort();
                }

                return;
            }
            this.Text = "��ȫ���� " + step.ToString();

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