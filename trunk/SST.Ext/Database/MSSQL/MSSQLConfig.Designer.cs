namespace SST.Ext.Database.MSSQL
{
    partial class MSSQLConfig
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlMemLimitNumUD = new System.Windows.Forms.NumericUpDown();
            this.ctlUnlimitCheckBox = new System.Windows.Forms.CheckBox();
            this.ctlCommitMemButton = new System.Windows.Forms.Button();
            this.ctlDynamicMemCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMemLimitNumUD)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(471, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlStatusText
            // 
            this.ctlStatusText.Name = "ctlStatusText";
            this.ctlStatusText.Size = new System.Drawing.Size(47, 17);
            this.ctlStatusText.Text = "等待...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "性能与资源";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.ctlDynamicMemCheckBox);
            this.groupBox2.Controls.Add(this.ctlCommitMemButton);
            this.groupBox2.Controls.Add(this.ctlUnlimitCheckBox);
            this.groupBox2.Controls.Add(this.ctlMemLimitNumUD);
            this.groupBox2.Location = new System.Drawing.Point(6, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(238, 102);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "允许的使用内存";
            // 
            // ctlMemLimitNumUD
            // 
            this.ctlMemLimitNumUD.Location = new System.Drawing.Point(6, 20);
            this.ctlMemLimitNumUD.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.ctlMemLimitNumUD.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.ctlMemLimitNumUD.Name = "ctlMemLimitNumUD";
            this.ctlMemLimitNumUD.Size = new System.Drawing.Size(138, 21);
            this.ctlMemLimitNumUD.TabIndex = 0;
            this.ctlMemLimitNumUD.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // ctlUnlimitCheckBox
            // 
            this.ctlUnlimitCheckBox.AutoSize = true;
            this.ctlUnlimitCheckBox.Location = new System.Drawing.Point(6, 47);
            this.ctlUnlimitCheckBox.Name = "ctlUnlimitCheckBox";
            this.ctlUnlimitCheckBox.Size = new System.Drawing.Size(60, 16);
            this.ctlUnlimitCheckBox.TabIndex = 1;
            this.ctlUnlimitCheckBox.Text = "不限制";
            this.ctlUnlimitCheckBox.UseVisualStyleBackColor = true;
            this.ctlUnlimitCheckBox.CheckedChanged += new System.EventHandler(this.ctlUnlimitCheckBox_CheckedChanged);
            // 
            // ctlCommitMemButton
            // 
            this.ctlCommitMemButton.Location = new System.Drawing.Point(150, 43);
            this.ctlCommitMemButton.Name = "ctlCommitMemButton";
            this.ctlCommitMemButton.Size = new System.Drawing.Size(68, 23);
            this.ctlCommitMemButton.TabIndex = 2;
            this.ctlCommitMemButton.Text = "提交更改";
            this.ctlCommitMemButton.UseVisualStyleBackColor = true;
            this.ctlCommitMemButton.Click += new System.EventHandler(this.ctlCommitMemButton_Click);
            // 
            // ctlDynamicMemCheckBox
            // 
            this.ctlDynamicMemCheckBox.AutoSize = true;
            this.ctlDynamicMemCheckBox.Enabled = false;
            this.ctlDynamicMemCheckBox.Location = new System.Drawing.Point(72, 47);
            this.ctlDynamicMemCheckBox.Name = "ctlDynamicMemCheckBox";
            this.ctlDynamicMemCheckBox.Size = new System.Drawing.Size(72, 16);
            this.ctlDynamicMemCheckBox.TabIndex = 3;
            this.ctlDynamicMemCheckBox.Text = "动态分配";
            this.ctlDynamicMemCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "MB";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(302, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 154);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "说明";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 60);
            this.label2.TabIndex = 0;
            this.label2.Text = "此窗口显示的是SQL高级配\r\n置除非你非常明白修改的结\r\n果，否则不要动！对于你非\r\n常模糊概念的配置最好不要\r\n动。";
            // 
            // MSSQLConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 205);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MSSQLConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Microsoft SQL Server 2005 银月配置器 (测试版 功能扩充中)";
            this.Load += new System.EventHandler(this.MSSQLConfig_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMemLimitNumUD)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ctlCommitMemButton;
        private System.Windows.Forms.CheckBox ctlUnlimitCheckBox;
        private System.Windows.Forms.NumericUpDown ctlMemLimitNumUD;
        private System.Windows.Forms.CheckBox ctlDynamicMemCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
    }
}