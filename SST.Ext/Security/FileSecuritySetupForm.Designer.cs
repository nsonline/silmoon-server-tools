namespace SST.Ext.Security
{
    partial class FileSecuritySetupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileSecuritySetupForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlReServUFileSecurityButton = new System.Windows.Forms.Button();
            this.ctlServUFileSecurityButton = new System.Windows.Forms.Button();
            this.CWizard = new System.Windows.Forms.Button();
            this.ResetCACL = new System.Windows.Forms.Button();
            this.TipStatus = new System.Windows.Forms.Label();
            this.ResetSpecialFileSecurity = new System.Windows.Forms.Button();
            this.SetSpecialFileSecurity = new System.Windows.Forms.Button();
            this.SetPHPSecurity = new System.Windows.Forms.Button();
            this.TipGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.TipGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlReServUFileSecurityButton);
            this.groupBox1.Controls.Add(this.ctlServUFileSecurityButton);
            this.groupBox1.Controls.Add(this.CWizard);
            this.groupBox1.Controls.Add(this.ResetCACL);
            this.groupBox1.Controls.Add(this.TipStatus);
            this.groupBox1.Controls.Add(this.ResetSpecialFileSecurity);
            this.groupBox1.Controls.Add(this.SetSpecialFileSecurity);
            this.groupBox1.Controls.Add(this.SetPHPSecurity);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 249);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "单独文件权限设置";
            // 
            // ctlReServUFileSecurityButton
            // 
            this.ctlReServUFileSecurityButton.Location = new System.Drawing.Point(161, 107);
            this.ctlReServUFileSecurityButton.Name = "ctlReServUFileSecurityButton";
            this.ctlReServUFileSecurityButton.Size = new System.Drawing.Size(77, 23);
            this.ctlReServUFileSecurityButton.TabIndex = 7;
            this.ctlReServUFileSecurityButton.Text = "<-恢复";
            this.ctlReServUFileSecurityButton.UseVisualStyleBackColor = true;
            this.ctlReServUFileSecurityButton.Click += new System.EventHandler(this.ctlReServUFileSecurityButton_Click);
            // 
            // ctlServUFileSecurityButton
            // 
            this.ctlServUFileSecurityButton.Location = new System.Drawing.Point(6, 107);
            this.ctlServUFileSecurityButton.Name = "ctlServUFileSecurityButton";
            this.ctlServUFileSecurityButton.Size = new System.Drawing.Size(151, 23);
            this.ctlServUFileSecurityButton.TabIndex = 6;
            this.ctlServUFileSecurityButton.Text = "Serv-U目录安全设置(&U)";
            this.ctlServUFileSecurityButton.UseVisualStyleBackColor = true;
            this.ctlServUFileSecurityButton.Click += new System.EventHandler(this.ctlServUFileSecurityButton_Click);
            // 
            // CWizard
            // 
            this.CWizard.Location = new System.Drawing.Point(6, 78);
            this.CWizard.Name = "CWizard";
            this.CWizard.Size = new System.Drawing.Size(151, 23);
            this.CWizard.TabIndex = 5;
            this.CWizard.Text = "C盘文件权限导向(&S)...";
            this.CWizard.UseVisualStyleBackColor = true;
            this.CWizard.Click += new System.EventHandler(this.CWizard_Click);
            // 
            // ResetCACL
            // 
            this.ResetCACL.Location = new System.Drawing.Point(161, 78);
            this.ResetCACL.Name = "ResetCACL";
            this.ResetCACL.Size = new System.Drawing.Size(77, 23);
            this.ResetCACL.TabIndex = 4;
            this.ResetCACL.Text = "<-(!)重置";
            this.ResetCACL.UseVisualStyleBackColor = true;
            this.ResetCACL.Click += new System.EventHandler(this.ResetCACL_Click);
            // 
            // TipStatus
            // 
            this.TipStatus.AutoSize = true;
            this.TipStatus.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TipStatus.ForeColor = System.Drawing.Color.Red;
            this.TipStatus.Location = new System.Drawing.Point(6, 234);
            this.TipStatus.Name = "TipStatus";
            this.TipStatus.Size = new System.Drawing.Size(12, 12);
            this.TipStatus.TabIndex = 3;
            this.TipStatus.Text = ".";
            // 
            // ResetSpecialFileSecurity
            // 
            this.ResetSpecialFileSecurity.Location = new System.Drawing.Point(163, 49);
            this.ResetSpecialFileSecurity.Name = "ResetSpecialFileSecurity";
            this.ResetSpecialFileSecurity.Size = new System.Drawing.Size(75, 23);
            this.ResetSpecialFileSecurity.TabIndex = 2;
            this.ResetSpecialFileSecurity.Text = "<-恢复";
            this.ResetSpecialFileSecurity.UseVisualStyleBackColor = true;
            this.ResetSpecialFileSecurity.Click += new System.EventHandler(this.ResetSpecialFileSecurity_Click);
            // 
            // SetSpecialFileSecurity
            // 
            this.SetSpecialFileSecurity.Location = new System.Drawing.Point(6, 49);
            this.SetSpecialFileSecurity.Name = "SetSpecialFileSecurity";
            this.SetSpecialFileSecurity.Size = new System.Drawing.Size(151, 23);
            this.SetSpecialFileSecurity.TabIndex = 1;
            this.SetSpecialFileSecurity.Text = "设置特殊文件安全(&S)";
            this.SetSpecialFileSecurity.UseVisualStyleBackColor = true;
            this.SetSpecialFileSecurity.Click += new System.EventHandler(this.SetSpecialFileSecurity_Click);
            // 
            // SetPHPSecurity
            // 
            this.SetPHPSecurity.Location = new System.Drawing.Point(6, 20);
            this.SetPHPSecurity.Name = "SetPHPSecurity";
            this.SetPHPSecurity.Size = new System.Drawing.Size(151, 23);
            this.SetPHPSecurity.TabIndex = 0;
            this.SetPHPSecurity.Text = "PHP文件夹安全设置(&P)";
            this.SetPHPSecurity.UseVisualStyleBackColor = true;
            this.SetPHPSecurity.Click += new System.EventHandler(this.SetPHPSecurity_Click);
            // 
            // TipGroupBox
            // 
            this.TipGroupBox.Controls.Add(this.label1);
            this.TipGroupBox.Location = new System.Drawing.Point(276, 12);
            this.TipGroupBox.Name = "TipGroupBox";
            this.TipGroupBox.Size = new System.Drawing.Size(200, 249);
            this.TipGroupBox.TabIndex = 1;
            this.TipGroupBox.TabStop = false;
            this.TipGroupBox.Text = "说明";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // FileSecuritySetupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 273);
            this.Controls.Add(this.TipGroupBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FileSecuritySetupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件系统访问安全设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileSecuritySetupForm_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FileSecuritySetupForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TipGroupBox.ResumeLayout(false);
            this.TipGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetPHPSecurity;
        private System.Windows.Forms.Button SetSpecialFileSecurity;
        private System.Windows.Forms.Button ResetSpecialFileSecurity;
        private System.Windows.Forms.GroupBox TipGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TipStatus;
        private System.Windows.Forms.Button ResetCACL;
        private System.Windows.Forms.Button CWizard;
        private System.Windows.Forms.Button ctlReServUFileSecurityButton;
        private System.Windows.Forms.Button ctlServUFileSecurityButton;
    }
}