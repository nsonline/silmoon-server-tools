namespace SST.Client.FormControls
{
    partial class GeneralPageControl
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.EditPhpini = new System.Windows.Forms.Button();
            this.DlDetect = new System.Windows.Forms.Button();
            this.SmSvrServLog = new System.Windows.Forms.Button();
            this.SmSvrServOptions = new System.Windows.Forms.Button();
            this.ctlCreateWebsiteButton = new System.Windows.Forms.Button();
            this.ctlIISPerfCountViewButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlIISManagerButton = new System.Windows.Forms.Button();
            this.ctlIISBackupButton = new System.Windows.Forms.Button();
            this.ctlAppPoolManagerButton = new System.Windows.Forms.Button();
            this.ctlIISLogButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // EditPhpini
            // 
            this.EditPhpini.Location = new System.Drawing.Point(6, 20);
            this.EditPhpini.Name = "EditPhpini";
            this.EditPhpini.Size = new System.Drawing.Size(109, 30);
            this.EditPhpini.TabIndex = 1;
            this.EditPhpini.Text = "编辑PHP.INI";
            this.EditPhpini.UseVisualStyleBackColor = true;
            this.EditPhpini.Click += new System.EventHandler(this.EditPhpini_Click);
            // 
            // DlDetect
            // 
            this.DlDetect.Location = new System.Drawing.Point(6, 56);
            this.DlDetect.Name = "DlDetect";
            this.DlDetect.Size = new System.Drawing.Size(109, 30);
            this.DlDetect.TabIndex = 2;
            this.DlDetect.Text = "下载探针";
            this.DlDetect.UseVisualStyleBackColor = true;
            this.DlDetect.Click += new System.EventHandler(this.DlDetect_Click);
            // 
            // SmSvrServLog
            // 
            this.SmSvrServLog.Location = new System.Drawing.Point(6, 128);
            this.SmSvrServLog.Name = "SmSvrServLog";
            this.SmSvrServLog.Size = new System.Drawing.Size(109, 30);
            this.SmSvrServLog.TabIndex = 3;
            this.SmSvrServLog.Text = "银月服务日志";
            this.SmSvrServLog.UseVisualStyleBackColor = true;
            this.SmSvrServLog.Click += new System.EventHandler(this.SmSvrServLog_Click);
            // 
            // SmSvrServOptions
            // 
            this.SmSvrServOptions.Location = new System.Drawing.Point(6, 92);
            this.SmSvrServOptions.Name = "SmSvrServOptions";
            this.SmSvrServOptions.Size = new System.Drawing.Size(109, 30);
            this.SmSvrServOptions.TabIndex = 4;
            this.SmSvrServOptions.Text = "银月服务器服务";
            this.SmSvrServOptions.UseVisualStyleBackColor = true;
            this.SmSvrServOptions.Click += new System.EventHandler(this.SmSvrServOptions_Click);
            // 
            // ctlCreateWebsiteButton
            // 
            this.ctlCreateWebsiteButton.Location = new System.Drawing.Point(6, 20);
            this.ctlCreateWebsiteButton.Name = "ctlCreateWebsiteButton";
            this.ctlCreateWebsiteButton.Size = new System.Drawing.Size(109, 30);
            this.ctlCreateWebsiteButton.TabIndex = 5;
            this.ctlCreateWebsiteButton.Text = "创建网站";
            this.ctlCreateWebsiteButton.UseVisualStyleBackColor = true;
            this.ctlCreateWebsiteButton.Click += new System.EventHandler(this.ctlCreateWebsiteButton_Click);
            // 
            // ctlIISPerfCountViewButton
            // 
            this.ctlIISPerfCountViewButton.Location = new System.Drawing.Point(6, 56);
            this.ctlIISPerfCountViewButton.Name = "ctlIISPerfCountViewButton";
            this.ctlIISPerfCountViewButton.Size = new System.Drawing.Size(109, 30);
            this.ctlIISPerfCountViewButton.TabIndex = 6;
            this.ctlIISPerfCountViewButton.Text = "IIS性能查看";
            this.ctlIISPerfCountViewButton.UseVisualStyleBackColor = true;
            this.ctlIISPerfCountViewButton.Click += new System.EventHandler(this.ctlIISPerfCountViewButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.EditPhpini);
            this.groupBox1.Controls.Add(this.DlDetect);
            this.groupBox1.Controls.Add(this.SmSvrServLog);
            this.groupBox1.Controls.Add(this.SmSvrServOptions);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(126, 173);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "杂项";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlIISLogButton);
            this.groupBox2.Controls.Add(this.ctlAppPoolManagerButton);
            this.groupBox2.Controls.Add(this.ctlIISManagerButton);
            this.groupBox2.Controls.Add(this.ctlIISBackupButton);
            this.groupBox2.Controls.Add(this.ctlCreateWebsiteButton);
            this.groupBox2.Controls.Add(this.ctlIISPerfCountViewButton);
            this.groupBox2.Location = new System.Drawing.Point(135, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(126, 237);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "IIS";
            // 
            // ctlIISManagerButton
            // 
            this.ctlIISManagerButton.Location = new System.Drawing.Point(6, 128);
            this.ctlIISManagerButton.Name = "ctlIISManagerButton";
            this.ctlIISManagerButton.Size = new System.Drawing.Size(109, 30);
            this.ctlIISManagerButton.TabIndex = 8;
            this.ctlIISManagerButton.Text = "银月IIS管理器";
            this.ctlIISManagerButton.UseVisualStyleBackColor = true;
            this.ctlIISManagerButton.Click += new System.EventHandler(this.ctlIISManagerButton_Click);
            // 
            // ctlIISBackupButton
            // 
            this.ctlIISBackupButton.Location = new System.Drawing.Point(6, 92);
            this.ctlIISBackupButton.Name = "ctlIISBackupButton";
            this.ctlIISBackupButton.Size = new System.Drawing.Size(109, 30);
            this.ctlIISBackupButton.TabIndex = 7;
            this.ctlIISBackupButton.Text = "IIS备份与恢复";
            this.ctlIISBackupButton.UseVisualStyleBackColor = true;
            this.ctlIISBackupButton.Click += new System.EventHandler(this.ctlIISBackupButton_Click);
            // 
            // ctlAppPoolManagerButton
            // 
            this.ctlAppPoolManagerButton.Location = new System.Drawing.Point(6, 162);
            this.ctlAppPoolManagerButton.Name = "ctlAppPoolManagerButton";
            this.ctlAppPoolManagerButton.Size = new System.Drawing.Size(109, 30);
            this.ctlAppPoolManagerButton.TabIndex = 9;
            this.ctlAppPoolManagerButton.Text = "IIS进程池管理";
            this.ctlAppPoolManagerButton.UseVisualStyleBackColor = true;
            this.ctlAppPoolManagerButton.Click += new System.EventHandler(this.ctlAppPoolManagerButton_Click);
            // 
            // ctlIISLogButton
            // 
            this.ctlIISLogButton.Location = new System.Drawing.Point(6, 198);
            this.ctlIISLogButton.Name = "ctlIISLogButton";
            this.ctlIISLogButton.Size = new System.Drawing.Size(109, 30);
            this.ctlIISLogButton.TabIndex = 10;
            this.ctlIISLogButton.Text = "IIS日志分析";
            this.ctlIISLogButton.UseVisualStyleBackColor = true;
            this.ctlIISLogButton.Click += new System.EventHandler(this.ctlIISLogButton_Click);
            // 
            // GeneralPageControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "GeneralPageControl";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button EditPhpini;
        private System.Windows.Forms.Button DlDetect;
        private System.Windows.Forms.Button SmSvrServLog;
        private System.Windows.Forms.Button SmSvrServOptions;
        private System.Windows.Forms.Button ctlCreateWebsiteButton;
        private System.Windows.Forms.Button ctlIISPerfCountViewButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ctlIISManagerButton;
        private System.Windows.Forms.Button ctlIISBackupButton;
        private System.Windows.Forms.Button ctlIISLogButton;
        private System.Windows.Forms.Button ctlAppPoolManagerButton;
    }
}
