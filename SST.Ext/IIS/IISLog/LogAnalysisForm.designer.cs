namespace SST.Ext.IIS.IISLog
{
    partial class LogAnalysisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogAnalysisForm));
            this.ctlLogListView = new Silmoon.Windows.Controls.DoubleBufferListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctlStatusProceBar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ctlOnlySpiderRecordButton = new System.Windows.Forms.ToolStripButton();
            this.ctlOnlyBaiduSpiderButton = new System.Windows.Forms.ToolStripButton();
            this.ctlOnlyGoogleSpiderButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctltOnly4Button = new System.Windows.Forms.ToolStripButton();
            this.ctltOnly3Button = new System.Windows.Forms.ToolStripButton();
            this.ctltOnly2Button = new System.Windows.Forms.ToolStripButton();
            this.ctltOnly5Button = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分析AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.单文件分析SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.指定网站分析WToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.分析过滤器FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlLogListView
            // 
            this.ctlLogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ctlLogListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlLogListView.FullRowSelect = true;
            this.ctlLogListView.HideSelection = false;
            this.ctlLogListView.Location = new System.Drawing.Point(0, 49);
            this.ctlLogListView.MultiSelect = false;
            this.ctlLogListView.Name = "ctlLogListView";
            this.ctlLogListView.Size = new System.Drawing.Size(725, 405);
            this.ctlLogListView.TabIndex = 0;
            this.ctlLogListView.UseCompatibleStateImageBehavior = false;
            this.ctlLogListView.View = System.Windows.Forms.View.Details;
            this.ctlLogListView.VirtualMode = true;
            this.ctlLogListView.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.ctlLogListView_RetrieveVirtualItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "日期/时间";
            this.columnHeader1.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "方法";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "目标";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "客户端IP";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "UA";
            this.columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态代码";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlStatusText,
            this.toolStripStatusLabel2,
            this.ctlStatusProceBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 454);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(725, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlStatusText
            // 
            this.ctlStatusText.Name = "ctlStatusText";
            this.ctlStatusText.Size = new System.Drawing.Size(47, 17);
            this.ctlStatusText.Text = "等待...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(561, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // ctlStatusProceBar
            // 
            this.ctlStatusProceBar.Name = "ctlStatusProceBar";
            this.ctlStatusProceBar.Size = new System.Drawing.Size(100, 16);
            this.ctlStatusProceBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlOnlySpiderRecordButton,
            this.ctlOnlyBaiduSpiderButton,
            this.ctlOnlyGoogleSpiderButton,
            this.toolStripSeparator2,
            this.ctltOnly4Button,
            this.ctltOnly3Button,
            this.ctltOnly2Button,
            this.ctltOnly5Button,
            this.toolStripSeparator1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(725, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ctlOnlySpiderRecordButton
            // 
            this.ctlOnlySpiderRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlOnlySpiderRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("ctlOnlySpiderRecordButton.Image")));
            this.ctlOnlySpiderRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlOnlySpiderRecordButton.Name = "ctlOnlySpiderRecordButton";
            this.ctlOnlySpiderRecordButton.Size = new System.Drawing.Size(93, 22);
            this.ctlOnlySpiderRecordButton.Text = "只显示搜索引擎";
            this.ctlOnlySpiderRecordButton.Click += new System.EventHandler(this.ctlOnlySpiderRecordButton_Click);
            // 
            // ctlOnlyBaiduSpiderButton
            // 
            this.ctlOnlyBaiduSpiderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlOnlyBaiduSpiderButton.Image = ((System.Drawing.Image)(resources.GetObject("ctlOnlyBaiduSpiderButton.Image")));
            this.ctlOnlyBaiduSpiderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlOnlyBaiduSpiderButton.Name = "ctlOnlyBaiduSpiderButton";
            this.ctlOnlyBaiduSpiderButton.Size = new System.Drawing.Size(93, 22);
            this.ctlOnlyBaiduSpiderButton.Text = "只显示百度蜘蛛";
            this.ctlOnlyBaiduSpiderButton.Click += new System.EventHandler(this.ctlOnlyBaiduSpiderButton_Click);
            // 
            // ctlOnlyGoogleSpiderButton
            // 
            this.ctlOnlyGoogleSpiderButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlOnlyGoogleSpiderButton.Image = ((System.Drawing.Image)(resources.GetObject("ctlOnlyGoogleSpiderButton.Image")));
            this.ctlOnlyGoogleSpiderButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlOnlyGoogleSpiderButton.Name = "ctlOnlyGoogleSpiderButton";
            this.ctlOnlyGoogleSpiderButton.Size = new System.Drawing.Size(105, 22);
            this.ctlOnlyGoogleSpiderButton.Text = "只显示Google蜘蛛";
            this.ctlOnlyGoogleSpiderButton.Click += new System.EventHandler(this.ctlOnlyGoogleSpiderButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ctltOnly4Button
            // 
            this.ctltOnly4Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltOnly4Button.Image = ((System.Drawing.Image)(resources.GetObject("ctltOnly4Button.Image")));
            this.ctltOnly4Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltOnly4Button.Name = "ctltOnly4Button";
            this.ctltOnly4Button.Size = new System.Drawing.Size(63, 22);
            this.ctltOnly4Button.Text = "只显示4xx";
            this.ctltOnly4Button.Click += new System.EventHandler(this.ctltOnly4Button_Click);
            // 
            // ctltOnly3Button
            // 
            this.ctltOnly3Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltOnly3Button.Image = ((System.Drawing.Image)(resources.GetObject("ctltOnly3Button.Image")));
            this.ctltOnly3Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltOnly3Button.Name = "ctltOnly3Button";
            this.ctltOnly3Button.Size = new System.Drawing.Size(63, 22);
            this.ctltOnly3Button.Text = "只显示3xx";
            this.ctltOnly3Button.Click += new System.EventHandler(this.ctltOnly3Button_Click);
            // 
            // ctltOnly2Button
            // 
            this.ctltOnly2Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltOnly2Button.Image = ((System.Drawing.Image)(resources.GetObject("ctltOnly2Button.Image")));
            this.ctltOnly2Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltOnly2Button.Name = "ctltOnly2Button";
            this.ctltOnly2Button.Size = new System.Drawing.Size(63, 22);
            this.ctltOnly2Button.Text = "只显示2xx";
            this.ctltOnly2Button.Click += new System.EventHandler(this.ctltOnly2Button_Click);
            // 
            // ctltOnly5Button
            // 
            this.ctltOnly5Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltOnly5Button.Image = ((System.Drawing.Image)(resources.GetObject("ctltOnly5Button.Image")));
            this.ctltOnly5Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltOnly5Button.Name = "ctltOnly5Button";
            this.ctltOnly5Button.Size = new System.Drawing.Size(63, 22);
            this.ctltOnly5Button.Text = "只显示5xx";
            this.ctltOnly5Button.Click += new System.EventHandler(this.ctltOnly5Button_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 175);
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 分析AToolStripMenuItem
            // 
            this.分析AToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.单文件分析SToolStripMenuItem,
            this.指定网站分析WToolStripMenuItem,
            this.分析过滤器FToolStripMenuItem});
            this.分析AToolStripMenuItem.Name = "分析AToolStripMenuItem";
            this.分析AToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.分析AToolStripMenuItem.Text = "分析(&A)";
            // 
            // 单文件分析SToolStripMenuItem
            // 
            this.单文件分析SToolStripMenuItem.Name = "单文件分析SToolStripMenuItem";
            this.单文件分析SToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.单文件分析SToolStripMenuItem.Text = "单文件分析(&S)";
            this.单文件分析SToolStripMenuItem.Click += new System.EventHandler(this.单文件分析SToolStripMenuItem_Click);
            // 
            // 指定网站分析WToolStripMenuItem
            // 
            this.指定网站分析WToolStripMenuItem.Name = "指定网站分析WToolStripMenuItem";
            this.指定网站分析WToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.指定网站分析WToolStripMenuItem.Text = "从网站分析(&W)";
            this.指定网站分析WToolStripMenuItem.Click += new System.EventHandler(this.从网站分析WToolStripMenuItem_Click);
            // 
            // 分析过滤器FToolStripMenuItem
            // 
            this.分析过滤器FToolStripMenuItem.Name = "分析过滤器FToolStripMenuItem";
            this.分析过滤器FToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.分析过滤器FToolStripMenuItem.Text = "分析过滤器(&F)";
            this.分析过滤器FToolStripMenuItem.Click += new System.EventHandler(this.分析过滤器FToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.分析AToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // LogAnalysisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 476);
            this.Controls.Add(this.ctlLogListView);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LogAnalysisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IIS日志分析 预览版本未开发完毕 非最终程序";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Silmoon.Windows.Controls.DoubleBufferListView ctlLogListView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusText;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripProgressBar ctlStatusProceBar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripButton ctlOnlySpiderRecordButton;
        private System.Windows.Forms.ToolStripButton ctltOnly4Button;
        private System.Windows.Forms.ToolStripButton ctltOnly3Button;
        private System.Windows.Forms.ToolStripButton ctltOnly2Button;
        private System.Windows.Forms.ToolStripButton ctltOnly5Button;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 分析AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 单文件分析SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 指定网站分析WToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripButton ctlOnlyBaiduSpiderButton;
        private System.Windows.Forms.ToolStripButton ctlOnlyGoogleSpiderButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 分析过滤器FToolStripMenuItem;
    }
}