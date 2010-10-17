namespace SST.Ext.IIS.IISLog
{
    partial class LogSelectSiteFilesForm
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
            this.ctlWebSiteListBox = new System.Windows.Forms.ListBox();
            this.ctlLogFileListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlConfirmButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlWebSiteListBox
            // 
            this.ctlWebSiteListBox.FormattingEnabled = true;
            this.ctlWebSiteListBox.ItemHeight = 12;
            this.ctlWebSiteListBox.Items.AddRange(new object[] {
            "加载网站中..."});
            this.ctlWebSiteListBox.Location = new System.Drawing.Point(12, 12);
            this.ctlWebSiteListBox.Name = "ctlWebSiteListBox";
            this.ctlWebSiteListBox.Size = new System.Drawing.Size(221, 376);
            this.ctlWebSiteListBox.TabIndex = 0;
            this.ctlWebSiteListBox.SelectedIndexChanged += new System.EventHandler(this.ctlWebSiteListBox_SelectedIndexChanged);
            // 
            // ctlLogFileListBox
            // 
            this.ctlLogFileListBox.FormattingEnabled = true;
            this.ctlLogFileListBox.ItemHeight = 12;
            this.ctlLogFileListBox.Location = new System.Drawing.Point(239, 12);
            this.ctlLogFileListBox.Name = "ctlLogFileListBox";
            this.ctlLogFileListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ctlLogFileListBox.Size = new System.Drawing.Size(214, 376);
            this.ctlLogFileListBox.TabIndex = 1;
            this.ctlLogFileListBox.SelectedIndexChanged += new System.EventHandler(this.ctlLogFileListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "全部文件大小";
            // 
            // ctlConfirmButton
            // 
            this.ctlConfirmButton.Location = new System.Drawing.Point(342, 400);
            this.ctlConfirmButton.Name = "ctlConfirmButton";
            this.ctlConfirmButton.Size = new System.Drawing.Size(111, 34);
            this.ctlConfirmButton.TabIndex = 3;
            this.ctlConfirmButton.Text = "分析选中文件(&E)";
            this.ctlConfirmButton.UseVisualStyleBackColor = true;
            this.ctlConfirmButton.Click += new System.EventHandler(this.ctlConfirmButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogSelectSiteFilesForm
            // 
            this.AcceptButton = this.ctlConfirmButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(465, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ctlConfirmButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlLogFileListBox);
            this.Controls.Add(this.ctlWebSiteListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "LogSelectSiteFilesForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "从网站选择日志文件";
            this.Shown += new System.EventHandler(this.LogSelectSiteFiles_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogSelectSiteFiles_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ctlWebSiteListBox;
        private System.Windows.Forms.ListBox ctlLogFileListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctlConfirmButton;
        private System.Windows.Forms.Button button1;
    }
}