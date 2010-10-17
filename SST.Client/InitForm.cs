using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using System.IO;
using System.Security.AccessControl;

namespace SST.Client
{
    public partial class InitForm : Form
    {
        public event InitOK OnInitGBCComplete;
        GBC _g;
        bool Started = false;
        public InitForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            this.Icon = SST.Resource.Resource.SSTIco2;
            Tray.Icon = SST.Resource.Resource.Network;
            OnInitGBCComplete += new InitOK(InitForm_OnInitGBCComplete);
        }

        /// <summary>
        /// 新线程加载GBC
        /// </summary>
        void InitGBC()
        {
            try
            {
                label1.Text = "加载库...";
                Thread.Sleep(100);
                label1.Text = "加载库...等待";
                _g = new GBC();
                label1.Text = "加载库...完成";
                Thread.Sleep(100);
                this.Invoke(OnInitGBCComplete);
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("加载重要库出错：\r\n    " + ex.Message + "\r\n\r\n" + ex.ToString(), "崩溃", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(2);
            }
        }
        /// <summary>
        /// 在加载GBC完成后开始窗口
        /// </summary>
        bool InitMainForm()
        {
            try
            {
                label1.Text = "加载主窗口...";
                _g.MainForm = new MainForm(_g);
                _g.Tray = Tray;

                ((MainForm)_g.MainForm).FormClosed += new FormClosedEventHandler(Form1_FormClosed);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        void InitForm_OnInitGBCComplete()
        {
            if (InitMainForm())
            {
                label1.Text = "加载主窗口...完成";
                ((MainForm)_g.MainForm).Show();
                Thread _th_hide_initForm = new Thread(_proc_hide_initForm);
                _th_hide_initForm.IsBackground = true;
                _th_hide_initForm.Start();
            }
        }
        void _proc_hide_initForm()
        {
            Thread.Sleep(1000);
            this.Visible = false;
        }

        private void InitForm_Shown(object sender, EventArgs e)
        {
            if (Environment.GetCommandLineArgs().Length > 1)
            {
                if (Environment.GetCommandLineArgs()[1] == "login") ctlInitPicButton_Click(this, EventArgs.Empty);
            }
        }

        private void ctlInitPicButton_MouseDown(object sender, MouseEventArgs e)
        {
            ctlInitPicButton.Image = SST.Client.Properties.Resources.InitButton2;
        }
        private void ctlInitPicButton_MouseUp(object sender, MouseEventArgs e)
        {
            if (Started) return;
            ctlInitPicButton.Image = SST.Client.Properties.Resources.InitButton1;
        }

        private void ctlExitPicButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ctlExitPicButton_MouseDown(object sender, MouseEventArgs e)
        {
            ctlExitPicButton.Image = SST.Client.Properties.Resources.Exit2;
        }
        private void ctlExitPicButton_MouseUp(object sender, MouseEventArgs e)
        {
            ctlExitPicButton.Image = SST.Client.Properties.Resources.Exit;
        }

        private void ctlInitPicButton_Click(object sender, EventArgs e)
        {
            Started = true;
            ctlInitPicButton.Enabled = false;
            ctlExitPicButton.Enabled = false;

            ctlInitPicButton.Image = SST.Client.Properties.Resources.InitButton3;
            ctlExitPicButton.Image = SST.Client.Properties.Resources.Exit3;
            label1.Text = "装载中...";
            Thread _th = new Thread(InitGBC);
            _th.IsBackground = true;
            _th.Start();
        }
    }
    public delegate void InitOK();
} 