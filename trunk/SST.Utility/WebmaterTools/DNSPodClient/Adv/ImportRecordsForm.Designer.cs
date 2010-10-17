namespace DNSPodClient.Adv
{
    partial class ImportRecordsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlRecordsTotalLabel = new System.Windows.Forms.Label();
            this.ctlListTypeLabe = new System.Windows.Forms.Label();
            this.ctlExecButton = new System.Windows.Forms.Button();
            this.ctlJumpButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlDomainLabel = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ctlJumpCombo = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.ctlImportButton.Text = "载入列表纪录(&I)";
            this.ctlImportButton.UseVisualStyleBackColor = true;
            this.ctlImportButton.Click += new System.EventHandler(this.ctlImportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "纪录数量:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "来源域名:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "资源类型:";
            // 
            // ctlRecordsTotalLabel
            // 
            this.ctlRecordsTotalLabel.AutoSize = true;
            this.ctlRecordsTotalLabel.Location = new System.Drawing.Point(76, 18);
            this.ctlRecordsTotalLabel.Name = "ctlRecordsTotalLabel";
            this.ctlRecordsTotalLabel.Size = new System.Drawing.Size(11, 12);
            this.ctlRecordsTotalLabel.TabIndex = 6;
            this.ctlRecordsTotalLabel.Text = "0";
            // 
            // ctlListTypeLabe
            // 
            this.ctlListTypeLabe.AutoSize = true;
            this.ctlListTypeLabe.Location = new System.Drawing.Point(76, 52);
            this.ctlListTypeLabe.Name = "ctlListTypeLabe";
            this.ctlListTypeLabe.Size = new System.Drawing.Size(47, 12);
            this.ctlListTypeLabe.TabIndex = 8;
            this.ctlListTypeLabe.Text = "Unknown";
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
            // ctlJumpButton
            // 
            this.ctlJumpButton.Location = new System.Drawing.Point(13, 20);
            this.ctlJumpButton.Name = "ctlJumpButton";
            this.ctlJumpButton.Size = new System.Drawing.Size(110, 31);
            this.ctlJumpButton.TabIndex = 10;
            this.ctlJumpButton.Text = "跨域(&Y)";
            this.ctlJumpButton.UseVisualStyleBackColor = true;
            this.ctlJumpButton.Click += new System.EventHandler(this.ctlJumpButton_Click);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlDomainLabel);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.ctlListTypeLabe);
            this.groupBox2.Controls.Add(this.ctlRecordsTotalLabel);
            this.groupBox2.Location = new System.Drawing.Point(262, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 73);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "域信息";
            // 
            // ctlDomainLabel
            // 
            this.ctlDomainLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ctlDomainLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ctlDomainLabel.Location = new System.Drawing.Point(76, 35);
            this.ctlDomainLabel.Name = "ctlDomainLabel";
            this.ctlDomainLabel.Size = new System.Drawing.Size(57, 14);
            this.ctlDomainLabel.TabIndex = 9;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ctlJumpCombo);
            this.groupBox3.Controls.Add(this.ctlJumpButton);
            this.groupBox3.Location = new System.Drawing.Point(262, 194);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(139, 92);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "跨域选项";
            // 
            // ctlJumpCombo
            // 
            this.ctlJumpCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlJumpCombo.Enabled = false;
            this.ctlJumpCombo.FormattingEnabled = true;
            this.ctlJumpCombo.Location = new System.Drawing.Point(13, 57);
            this.ctlJumpCombo.Name = "ctlJumpCombo";
            this.ctlJumpCombo.Size = new System.Drawing.Size(110, 20);
            this.ctlJumpCombo.TabIndex = 11;
            // 
            // ImportRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 324);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ImportRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ImportRecords";
            this.Shown += new System.EventHandler(this.ImportRecordsForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusText;
        private System.Windows.Forms.Button ctlImportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ctlRecordsTotalLabel;
        private System.Windows.Forms.Label ctlListTypeLabe;
        private System.Windows.Forms.Button ctlExecButton;
        private System.Windows.Forms.Button ctlJumpButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ctlJumpCombo;
        private System.Windows.Forms.TextBox ctlDomainLabel;
    }
}