namespace SST.Ext.Tools
{
    partial class ScanCode
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
            this.ctlSelectDirectoryButton = new System.Windows.Forms.Button();
            this.ctlDirectoryTextBox = new System.Windows.Forms.TextBox();
            this.ctlAnalysebutton = new System.Windows.Forms.Button();
            this.ctlAnalyseStatusLabel = new System.Windows.Forms.Label();
            this.ctlExtNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlStart = new System.Windows.Forms.Button();
            this.ctlLoadCodeButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ctlOptionsButton = new System.Windows.Forms.Button();
            this.ctlCountFileLabel = new System.Windows.Forms.Label();
            this.ctlResultFileListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.ctlResultListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.记事本打开TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开文件目录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlProcessFileLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctl2CodeTextBox = new System.Windows.Forms.TextBox();
            this.ctl2CodeTypeTextBox = new System.Windows.Forms.TextBox();
            this.ctl2WriteCodeButton = new System.Windows.Forms.Button();
            this.ctl2SaveButton = new System.Windows.Forms.Button();
            this.ctl2OpenCodeBoxButton = new System.Windows.Forms.Button();
            this.ctl2FilePathLabel = new System.Windows.Forms.Label();
            this.ctl2CodeBoxListView = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.ctl2ListViewMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctl_status_Text = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctl_status_process = new System.Windows.Forms.ToolStripProgressBar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.ctlResultListViewMenu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.ctl2ListViewMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlSelectDirectoryButton
            // 
            this.ctlSelectDirectoryButton.Location = new System.Drawing.Point(602, 4);
            this.ctlSelectDirectoryButton.Name = "ctlSelectDirectoryButton";
            this.ctlSelectDirectoryButton.Size = new System.Drawing.Size(75, 23);
            this.ctlSelectDirectoryButton.TabIndex = 0;
            this.ctlSelectDirectoryButton.Text = "浏览(&B)";
            this.ctlSelectDirectoryButton.UseVisualStyleBackColor = true;
            this.ctlSelectDirectoryButton.Click += new System.EventHandler(this.ctlSelectDirectoryButton_Click);
            // 
            // ctlDirectoryTextBox
            // 
            this.ctlDirectoryTextBox.Location = new System.Drawing.Point(8, 6);
            this.ctlDirectoryTextBox.Name = "ctlDirectoryTextBox";
            this.ctlDirectoryTextBox.Size = new System.Drawing.Size(578, 21);
            this.ctlDirectoryTextBox.TabIndex = 1;
            // 
            // ctlAnalysebutton
            // 
            this.ctlAnalysebutton.Enabled = false;
            this.ctlAnalysebutton.Location = new System.Drawing.Point(521, 33);
            this.ctlAnalysebutton.Name = "ctlAnalysebutton";
            this.ctlAnalysebutton.Size = new System.Drawing.Size(75, 23);
            this.ctlAnalysebutton.TabIndex = 2;
            this.ctlAnalysebutton.Text = "分析递归";
            this.ctlAnalysebutton.UseVisualStyleBackColor = true;
            this.ctlAnalysebutton.Click += new System.EventHandler(this.ctlAnalysebutton_Click);
            // 
            // ctlAnalyseStatusLabel
            // 
            this.ctlAnalyseStatusLabel.AutoSize = true;
            this.ctlAnalyseStatusLabel.Location = new System.Drawing.Point(6, 38);
            this.ctlAnalyseStatusLabel.Name = "ctlAnalyseStatusLabel";
            this.ctlAnalyseStatusLabel.Size = new System.Drawing.Size(113, 12);
            this.ctlAnalyseStatusLabel.TabIndex = 3;
            this.ctlAnalyseStatusLabel.Text = "等待分析递归信息。";
            // 
            // ctlExtNameTextBox
            // 
            this.ctlExtNameTextBox.Location = new System.Drawing.Point(89, 62);
            this.ctlExtNameTextBox.Name = "ctlExtNameTextBox";
            this.ctlExtNameTextBox.Size = new System.Drawing.Size(588, 21);
            this.ctlExtNameTextBox.TabIndex = 4;
            this.ctlExtNameTextBox.Text = "asp,php,aspx";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "针对文件类型";
            // 
            // ctlStart
            // 
            this.ctlStart.Enabled = false;
            this.ctlStart.Location = new System.Drawing.Point(521, 89);
            this.ctlStart.Name = "ctlStart";
            this.ctlStart.Size = new System.Drawing.Size(75, 23);
            this.ctlStart.TabIndex = 6;
            this.ctlStart.Text = "扫描(&S)";
            this.ctlStart.UseVisualStyleBackColor = true;
            this.ctlStart.Click += new System.EventHandler(this.ctlStart_Click);
            // 
            // ctlLoadCodeButton
            // 
            this.ctlLoadCodeButton.Enabled = false;
            this.ctlLoadCodeButton.Location = new System.Drawing.Point(602, 33);
            this.ctlLoadCodeButton.Name = "ctlLoadCodeButton";
            this.ctlLoadCodeButton.Size = new System.Drawing.Size(75, 23);
            this.ctlLoadCodeButton.TabIndex = 8;
            this.ctlLoadCodeButton.Text = "加载病毒库";
            this.ctlLoadCodeButton.UseVisualStyleBackColor = true;
            this.ctlLoadCodeButton.Click += new System.EventHandler(this.ctlLoadCodeButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 458);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ctlOptionsButton);
            this.tabPage1.Controls.Add(this.ctlCountFileLabel);
            this.tabPage1.Controls.Add(this.ctlResultFileListView);
            this.tabPage1.Controls.Add(this.ctlProcessFileLabel);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ctlDirectoryTextBox);
            this.tabPage1.Controls.Add(this.ctlSelectDirectoryButton);
            this.tabPage1.Controls.Add(this.ctlLoadCodeButton);
            this.tabPage1.Controls.Add(this.ctlAnalysebutton);
            this.tabPage1.Controls.Add(this.ctlAnalyseStatusLabel);
            this.tabPage1.Controls.Add(this.ctlStart);
            this.tabPage1.Controls.Add(this.ctlExtNameTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 433);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "代码扫描";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ctlOptionsButton
            // 
            this.ctlOptionsButton.Location = new System.Drawing.Point(602, 89);
            this.ctlOptionsButton.Name = "ctlOptionsButton";
            this.ctlOptionsButton.Size = new System.Drawing.Size(75, 23);
            this.ctlOptionsButton.TabIndex = 16;
            this.ctlOptionsButton.Text = "选项(&O)";
            this.ctlOptionsButton.UseVisualStyleBackColor = true;
            this.ctlOptionsButton.Click += new System.EventHandler(this.ctlOptionsButton_Click);
            // 
            // ctlCountFileLabel
            // 
            this.ctlCountFileLabel.AutoSize = true;
            this.ctlCountFileLabel.Location = new System.Drawing.Point(77, 145);
            this.ctlCountFileLabel.Name = "ctlCountFileLabel";
            this.ctlCountFileLabel.Size = new System.Drawing.Size(0, 12);
            this.ctlCountFileLabel.TabIndex = 15;
            // 
            // ctlResultFileListView
            // 
            this.ctlResultFileListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.ctlResultFileListView.ContextMenuStrip = this.ctlResultListViewMenu;
            this.ctlResultFileListView.FullRowSelect = true;
            this.ctlResultFileListView.HideSelection = false;
            this.ctlResultFileListView.Location = new System.Drawing.Point(0, 160);
            this.ctlResultFileListView.Name = "ctlResultFileListView";
            this.ctlResultFileListView.Size = new System.Drawing.Size(692, 267);
            this.ctlResultFileListView.TabIndex = 14;
            this.ctlResultFileListView.UseCompatibleStateImageBehavior = false;
            this.ctlResultFileListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "代码代号";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "等级";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "路径";
            this.columnHeader3.Width = 518;
            // 
            // ctlResultListViewMenu
            // 
            this.ctlResultListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.记事本打开TToolStripMenuItem,
            this.打开文件目录DToolStripMenuItem});
            this.ctlResultListViewMenu.Name = "ctlResultListViewMenu";
            this.ctlResultListViewMenu.Size = new System.Drawing.Size(161, 48);
            this.ctlResultListViewMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ctlResultListViewMenu_Opening);
            // 
            // 记事本打开TToolStripMenuItem
            // 
            this.记事本打开TToolStripMenuItem.Name = "记事本打开TToolStripMenuItem";
            this.记事本打开TToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.记事本打开TToolStripMenuItem.Text = "记事本打开(&T)";
            this.记事本打开TToolStripMenuItem.Click += new System.EventHandler(this.记事本打开TToolStripMenuItem_Click);
            // 
            // 打开文件目录DToolStripMenuItem
            // 
            this.打开文件目录DToolStripMenuItem.Name = "打开文件目录DToolStripMenuItem";
            this.打开文件目录DToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开文件目录DToolStripMenuItem.Text = "打开文件目录(&D)";
            this.打开文件目录DToolStripMenuItem.Click += new System.EventHandler(this.打开文件目录DToolStripMenuItem_Click);
            // 
            // ctlProcessFileLabel
            // 
            this.ctlProcessFileLabel.AutoSize = true;
            this.ctlProcessFileLabel.Location = new System.Drawing.Point(77, 120);
            this.ctlProcessFileLabel.Name = "ctlProcessFileLabel";
            this.ctlProcessFileLabel.Size = new System.Drawing.Size(23, 12);
            this.ctlProcessFileLabel.TabIndex = 13;
            this.ctlProcessFileLabel.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "当前文件：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "结果列表：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctl2CodeTextBox);
            this.tabPage2.Controls.Add(this.ctl2CodeTypeTextBox);
            this.tabPage2.Controls.Add(this.ctl2WriteCodeButton);
            this.tabPage2.Controls.Add(this.ctl2SaveButton);
            this.tabPage2.Controls.Add(this.ctl2OpenCodeBoxButton);
            this.tabPage2.Controls.Add(this.ctl2FilePathLabel);
            this.tabPage2.Controls.Add(this.ctl2CodeBoxListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 433);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "特征码管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctl2CodeTextBox
            // 
            this.ctl2CodeTextBox.Location = new System.Drawing.Point(118, 35);
            this.ctl2CodeTextBox.Name = "ctl2CodeTextBox";
            this.ctl2CodeTextBox.Size = new System.Drawing.Size(496, 21);
            this.ctl2CodeTextBox.TabIndex = 12;
            // 
            // ctl2CodeTypeTextBox
            // 
            this.ctl2CodeTypeTextBox.Location = new System.Drawing.Point(3, 35);
            this.ctl2CodeTypeTextBox.Name = "ctl2CodeTypeTextBox";
            this.ctl2CodeTypeTextBox.Size = new System.Drawing.Size(116, 21);
            this.ctl2CodeTypeTextBox.TabIndex = 11;
            // 
            // ctl2WriteCodeButton
            // 
            this.ctl2WriteCodeButton.Enabled = false;
            this.ctl2WriteCodeButton.Location = new System.Drawing.Point(620, 35);
            this.ctl2WriteCodeButton.Name = "ctl2WriteCodeButton";
            this.ctl2WriteCodeButton.Size = new System.Drawing.Size(75, 21);
            this.ctl2WriteCodeButton.TabIndex = 13;
            this.ctl2WriteCodeButton.Text = "修改";
            this.ctl2WriteCodeButton.UseVisualStyleBackColor = true;
            this.ctl2WriteCodeButton.Click += new System.EventHandler(this.ctlWriteCodeButton_Click);
            // 
            // ctl2SaveButton
            // 
            this.ctl2SaveButton.Enabled = false;
            this.ctl2SaveButton.Location = new System.Drawing.Point(620, 14);
            this.ctl2SaveButton.Name = "ctl2SaveButton";
            this.ctl2SaveButton.Size = new System.Drawing.Size(75, 21);
            this.ctl2SaveButton.TabIndex = 14;
            this.ctl2SaveButton.Text = "保存！";
            this.ctl2SaveButton.UseVisualStyleBackColor = true;
            this.ctl2SaveButton.Click += new System.EventHandler(this.ctlSaveButton_Click);
            // 
            // ctl2OpenCodeBoxButton
            // 
            this.ctl2OpenCodeBoxButton.Location = new System.Drawing.Point(8, 6);
            this.ctl2OpenCodeBoxButton.Name = "ctl2OpenCodeBoxButton";
            this.ctl2OpenCodeBoxButton.Size = new System.Drawing.Size(75, 23);
            this.ctl2OpenCodeBoxButton.TabIndex = 10;
            this.ctl2OpenCodeBoxButton.Text = "打开文件";
            this.ctl2OpenCodeBoxButton.UseVisualStyleBackColor = true;
            this.ctl2OpenCodeBoxButton.Click += new System.EventHandler(this.ctlOpenCodeBoxButton_Click);
            // 
            // ctl2FilePathLabel
            // 
            this.ctl2FilePathLabel.AutoSize = true;
            this.ctl2FilePathLabel.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ctl2FilePathLabel.ForeColor = System.Drawing.Color.Red;
            this.ctl2FilePathLabel.Location = new System.Drawing.Point(89, 12);
            this.ctl2FilePathLabel.Name = "ctl2FilePathLabel";
            this.ctl2FilePathLabel.Size = new System.Drawing.Size(122, 12);
            this.ctl2FilePathLabel.TabIndex = 9;
            this.ctl2FilePathLabel.Text = "请选择文件并打开！";
            // 
            // ctl2CodeBoxListView
            // 
            this.ctl2CodeBoxListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7});
            this.ctl2CodeBoxListView.ContextMenuStrip = this.ctl2ListViewMenu;
            this.ctl2CodeBoxListView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctl2CodeBoxListView.FullRowSelect = true;
            this.ctl2CodeBoxListView.HideSelection = false;
            this.ctl2CodeBoxListView.Location = new System.Drawing.Point(3, 62);
            this.ctl2CodeBoxListView.Name = "ctl2CodeBoxListView";
            this.ctl2CodeBoxListView.Size = new System.Drawing.Size(689, 368);
            this.ctl2CodeBoxListView.TabIndex = 8;
            this.ctl2CodeBoxListView.UseCompatibleStateImageBehavior = false;
            this.ctl2CodeBoxListView.View = System.Windows.Forms.View.Details;
            this.ctl2CodeBoxListView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "代码类型";
            this.columnHeader6.Width = 115;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "代码内容";
            this.columnHeader7.Width = 570;
            // 
            // ctl2ListViewMenu
            // 
            this.ctl2ListViewMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除RToolStripMenuItem,
            this.添加AToolStripMenuItem});
            this.ctl2ListViewMenu.Name = "contextMenuStrip1";
            this.ctl2ListViewMenu.Size = new System.Drawing.Size(113, 48);
            // 
            // 删除RToolStripMenuItem
            // 
            this.删除RToolStripMenuItem.Name = "删除RToolStripMenuItem";
            this.删除RToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.删除RToolStripMenuItem.Text = "删除(&R)";
            this.删除RToolStripMenuItem.Click += new System.EventHandler(this.删除RToolStripMenuItem_Click);
            // 
            // 添加AToolStripMenuItem
            // 
            this.添加AToolStripMenuItem.Name = "添加AToolStripMenuItem";
            this.添加AToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.添加AToolStripMenuItem.Text = "添加(&A)";
            this.添加AToolStripMenuItem.Click += new System.EventHandler(this.添加AToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctl_status_Text,
            this.toolStripStatusLabel1,
            this.ctl_status_process});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(703, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctl_status_Text
            // 
            this.ctl_status_Text.Name = "ctl_status_Text";
            this.ctl_status_Text.Size = new System.Drawing.Size(71, 17);
            this.ctl_status_Text.Text = "Stand by...";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(515, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // ctl_status_process
            // 
            this.ctl_status_process.Name = "ctl_status_process";
            this.ctl_status_process.Size = new System.Drawing.Size(100, 16);
            this.ctl_status_process.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // ScanCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 480);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ScanCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "恶意代码管理与特征代码搜索器 (发布版)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ScanCode_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ctlResultListViewMenu.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ctl2ListViewMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ctlSelectDirectoryButton;
        private System.Windows.Forms.TextBox ctlDirectoryTextBox;
        private System.Windows.Forms.Button ctlAnalysebutton;
        private System.Windows.Forms.Label ctlAnalyseStatusLabel;
        private System.Windows.Forms.TextBox ctlExtNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ctlStart;
        private System.Windows.Forms.Button ctlLoadCodeButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctl_status_Text;
        private System.Windows.Forms.ToolStripProgressBar ctl_status_process;
        private System.Windows.Forms.Label ctlProcessFileLabel;
        private System.Windows.Forms.ListView ctlResultFileListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView ctl2CodeBoxListView;
        private System.Windows.Forms.TextBox ctl2CodeTextBox;
        private System.Windows.Forms.TextBox ctl2CodeTypeTextBox;
        private System.Windows.Forms.Button ctl2WriteCodeButton;
        private System.Windows.Forms.Button ctl2SaveButton;
        private System.Windows.Forms.Button ctl2OpenCodeBoxButton;
        private System.Windows.Forms.Label ctl2FilePathLabel;
        private System.Windows.Forms.ContextMenuStrip ctl2ListViewMenu;
        private System.Windows.Forms.ToolStripMenuItem 删除RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加AToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label ctlCountFileLabel;
        private System.Windows.Forms.Button ctlOptionsButton;
        private System.Windows.Forms.ContextMenuStrip ctlResultListViewMenu;
        private System.Windows.Forms.ToolStripMenuItem 记事本打开TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开文件目录DToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}