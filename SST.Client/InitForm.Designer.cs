namespace SST.Client
{
    partial class InitForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitForm));
            this.Tray = new System.Windows.Forms.NotifyIcon(this.components);
            this.ctlInitPicButton = new System.Windows.Forms.PictureBox();
            this.ctlExitPicButton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ctlInitPicButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlExitPicButton)).BeginInit();
            this.SuspendLayout();
            // 
            // Tray
            // 
            this.Tray.Text = "SST状态图标";
            this.Tray.Visible = true;
            // 
            // ctlInitPicButton
            // 
            this.ctlInitPicButton.BackColor = System.Drawing.Color.Transparent;
            this.ctlInitPicButton.Image = global::SST.Client.Properties.Resources.InitButton1;
            this.ctlInitPicButton.Location = new System.Drawing.Point(174, 65);
            this.ctlInitPicButton.Name = "ctlInitPicButton";
            this.ctlInitPicButton.Size = new System.Drawing.Size(77, 30);
            this.ctlInitPicButton.TabIndex = 1;
            this.ctlInitPicButton.TabStop = false;
            this.ctlInitPicButton.Click += new System.EventHandler(this.ctlInitPicButton_Click);
            this.ctlInitPicButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctlInitPicButton_MouseDown);
            this.ctlInitPicButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctlInitPicButton_MouseUp);
            // 
            // ctlExitPicButton
            // 
            this.ctlExitPicButton.BackColor = System.Drawing.Color.Transparent;
            this.ctlExitPicButton.Image = global::SST.Client.Properties.Resources.Exit;
            this.ctlExitPicButton.Location = new System.Drawing.Point(225, 7);
            this.ctlExitPicButton.Name = "ctlExitPicButton";
            this.ctlExitPicButton.Size = new System.Drawing.Size(32, 31);
            this.ctlExitPicButton.TabIndex = 2;
            this.ctlExitPicButton.TabStop = false;
            this.ctlExitPicButton.Click += new System.EventHandler(this.ctlExitPicButton_Click);
            this.ctlExitPicButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ctlExitPicButton_MouseDown);
            this.ctlExitPicButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ctlExitPicButton_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "欢迎使用 银月服务器工具";
            // 
            // InitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(263, 107);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlExitPicButton);
            this.Controls.Add(this.ctlInitPicButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "InitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "银月服务器工具(银月软件)";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.InitForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ctlInitPicButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlExitPicButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon Tray;
        private System.Windows.Forms.PictureBox ctlInitPicButton;
        private System.Windows.Forms.PictureBox ctlExitPicButton;
        private System.Windows.Forms.Label label1;

    }
}

