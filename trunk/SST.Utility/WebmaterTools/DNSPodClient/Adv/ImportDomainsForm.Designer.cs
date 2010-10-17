namespace DNSPodClient.Adv
{
    partial class ImportDomainsForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctlImportButton = new System.Windows.Forms.Button();
            this.ctlExecButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(244, 280);
            this.listBox1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 302);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(425, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlStatusText
            // 
            this.ctlStatusText.Name = "ctlStatusText";
            this.ctlStatusText.Size = new System.Drawing.Size(161, 17);
            this.ctlStatusText.Text = "就绪...等待导入列表文件...";
            // 
            // ctlImportButton
            // 
            this.ctlImportButton.Location = new System.Drawing.Point(13, 20);
            this.ctlImportButton.Name = "ctlImportButton";
            this.ctlImportButton.Size = new System.Drawing.Size(110, 31);
            this.ctlImportButton.TabIndex = 2;
            this.ctlImportButton.Text = "载入域名列表(&I)";
            this.ctlImportButton.UseVisualStyleBackColor = true;
            this.ctlImportButton.Click += new System.EventHandler(this.ctlImportButton_Click);
            // 
            // ctlExecButton
            // 
            this.ctlExecButton.Location = new System.Drawing.Point(13, 57);
            this.ctlExecButton.Name = "ctlExecButton";
            this.ctlExecButton.Size = new System.Drawing.Size(110, 31);
            this.ctlExecButton.TabIndex = 9;
            this.ctlExecButton.Text = "执行导入！(&S)";
            this.ctlExecButton.UseVisualStyleBackColor = true;
            this.ctlExecButton.Click += new System.EventHandler(this.ctlExecButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlImportButton);
            this.groupBox1.Controls.Add(this.ctlExecButton);
            this.groupBox1.Location = new System.Drawing.Point(262, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 97);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "常规";
            // 
            // ImportDomainsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 324);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportDomainsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入域名列表";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusText;
        private System.Windows.Forms.Button ctlImportButton;
        private System.Windows.Forms.Button ctlExecButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}