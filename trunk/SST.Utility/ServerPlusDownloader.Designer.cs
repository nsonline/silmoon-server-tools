namespace SST.Utility
{
    partial class ServerPlusDownloader
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
            this.C_ResourceListListBox = new System.Windows.Forms.ListBox();
            this.C_StartButton = new System.Windows.Forms.Button();
            this.C_CancelButton = new System.Windows.Forms.Button();
            this.C_OpenButton = new System.Windows.Forms.Button();
            this.C_StatusProcBar = new System.Windows.Forms.ProgressBar();
            this.C_ReadResourceButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空临时文件CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // C_ResourceListListBox
            // 
            this.C_ResourceListListBox.FormattingEnabled = true;
            this.C_ResourceListListBox.ItemHeight = 12;
            this.C_ResourceListListBox.Location = new System.Drawing.Point(12, 37);
            this.C_ResourceListListBox.Name = "C_ResourceListListBox";
            this.C_ResourceListListBox.Size = new System.Drawing.Size(255, 220);
            this.C_ResourceListListBox.TabIndex = 0;
            this.C_ResourceListListBox.SelectedIndexChanged += new System.EventHandler(this.C_ResourceListListBox_SelectedIndexChanged);
            // 
            // C_StartButton
            // 
            this.C_StartButton.Enabled = false;
            this.C_StartButton.Location = new System.Drawing.Point(275, 37);
            this.C_StartButton.Name = "C_StartButton";
            this.C_StartButton.Size = new System.Drawing.Size(164, 43);
            this.C_StartButton.TabIndex = 1;
            this.C_StartButton.Text = "开始(&S)";
            this.C_StartButton.UseVisualStyleBackColor = true;
            this.C_StartButton.Click += new System.EventHandler(this.C_StartButton_Click);
            // 
            // C_CancelButton
            // 
            this.C_CancelButton.Enabled = false;
            this.C_CancelButton.Location = new System.Drawing.Point(275, 86);
            this.C_CancelButton.Name = "C_CancelButton";
            this.C_CancelButton.Size = new System.Drawing.Size(164, 43);
            this.C_CancelButton.TabIndex = 2;
            this.C_CancelButton.Text = "停止(&T)";
            this.C_CancelButton.UseVisualStyleBackColor = true;
            this.C_CancelButton.Click += new System.EventHandler(this.C_CancelButton_Click);
            // 
            // C_OpenButton
            // 
            this.C_OpenButton.Enabled = false;
            this.C_OpenButton.Location = new System.Drawing.Point(275, 135);
            this.C_OpenButton.Name = "C_OpenButton";
            this.C_OpenButton.Size = new System.Drawing.Size(164, 43);
            this.C_OpenButton.TabIndex = 3;
            this.C_OpenButton.Text = "打开(&O)";
            this.C_OpenButton.UseVisualStyleBackColor = true;
            this.C_OpenButton.Click += new System.EventHandler(this.C_OpenButton_Click);
            // 
            // C_StatusProcBar
            // 
            this.C_StatusProcBar.Location = new System.Drawing.Point(12, 263);
            this.C_StatusProcBar.Name = "C_StatusProcBar";
            this.C_StatusProcBar.Size = new System.Drawing.Size(427, 23);
            this.C_StatusProcBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.C_StatusProcBar.TabIndex = 4;
            // 
            // C_ReadResourceButton
            // 
            this.C_ReadResourceButton.Location = new System.Drawing.Point(275, 183);
            this.C_ReadResourceButton.Name = "C_ReadResourceButton";
            this.C_ReadResourceButton.Size = new System.Drawing.Size(164, 43);
            this.C_ReadResourceButton.TabIndex = 5;
            this.C_ReadResourceButton.Text = "读取资源列表(&R)";
            this.C_ReadResourceButton.UseVisualStyleBackColor = true;
            this.C_ReadResourceButton.Click += new System.EventHandler(this.C_ReadResourceButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ready";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空临时文件CToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 清空临时文件CToolStripMenuItem
            // 
            this.清空临时文件CToolStripMenuItem.Name = "清空临时文件CToolStripMenuItem";
            this.清空临时文件CToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.清空临时文件CToolStripMenuItem.Text = "清空临时文件(&C)";
            this.清空临时文件CToolStripMenuItem.Click += new System.EventHandler(this.清空临时文件CToolStripMenuItem_Click);
            // 
            // ServerPlusDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C_ReadResourceButton);
            this.Controls.Add(this.C_StatusProcBar);
            this.Controls.Add(this.C_OpenButton);
            this.Controls.Add(this.C_CancelButton);
            this.Controls.Add(this.C_StartButton);
            this.Controls.Add(this.C_ResourceListListBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "ServerPlusDownloader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "组件下载器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox C_ResourceListListBox;
        public System.Windows.Forms.ProgressBar C_StatusProcBar;
        public System.Windows.Forms.Button C_StartButton;
        public System.Windows.Forms.Button C_CancelButton;
        public System.Windows.Forms.Button C_OpenButton;
        public System.Windows.Forms.Button C_ReadResourceButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空临时文件CToolStripMenuItem;
    }
}