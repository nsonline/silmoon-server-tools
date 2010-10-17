namespace SST.Ext.IIS.Performance
{
    partial class ApplicationPoolManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationPoolManagerForm));
            this.listView1 = new Silmoon.Windows.Controls.DoubleBufferListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新列表RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.结束进程KToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlsStateText = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ctltRefreshListButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctltSplitTmpPoolButton = new System.Windows.Forms.ToolStripButton();
            this.ctltMergeTmpPoolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ctltSplitPoolButton = new System.Windows.Forms.ToolStripButton();
            this.ctltMergePoolButton = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader5});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(684, 357);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "进程ID";
            this.columnHeader1.Width = 78;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "进程名";
            this.columnHeader2.Width = 83;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "应用池名称";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "进程启动时间";
            this.columnHeader4.Width = 131;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "内存";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "% CPU";
            this.columnHeader7.Width = 74;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "描述";
            this.columnHeader5.Width = 89;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新列表RToolStripMenuItem,
            this.结束进程KToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // 刷新列表RToolStripMenuItem
            // 
            this.刷新列表RToolStripMenuItem.Name = "刷新列表RToolStripMenuItem";
            this.刷新列表RToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新列表RToolStripMenuItem.Text = "刷新列表(&R)";
            this.刷新列表RToolStripMenuItem.Click += new System.EventHandler(this.刷新列表RToolStripMenuItem_Click);
            // 
            // 结束进程KToolStripMenuItem
            // 
            this.结束进程KToolStripMenuItem.Name = "结束进程KToolStripMenuItem";
            this.结束进程KToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.结束进程KToolStripMenuItem.Text = "结束进程(&K)";
            this.结束进程KToolStripMenuItem.Click += new System.EventHandler(this.结束进程KToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlsStateText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 382);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(684, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlsStateText
            // 
            this.ctlsStateText.Name = "ctlsStateText";
            this.ctlsStateText.Size = new System.Drawing.Size(59, 17);
            this.ctlsStateText.Text = "Wating...";
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctltRefreshListButton,
            this.toolStripSeparator1,
            this.ctltSplitTmpPoolButton,
            this.ctltMergeTmpPoolButton,
            this.toolStripSeparator2,
            this.ctltSplitPoolButton,
            this.ctltMergePoolButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(684, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ctltRefreshListButton
            // 
            this.ctltRefreshListButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltRefreshListButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltRefreshListButton.Image")));
            this.ctltRefreshListButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltRefreshListButton.Name = "ctltRefreshListButton";
            this.ctltRefreshListButton.Size = new System.Drawing.Size(57, 22);
            this.ctltRefreshListButton.Text = "刷新列表";
            this.ctltRefreshListButton.Click += new System.EventHandler(this.ctltRefreshListButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ctltSplitTmpPoolButton
            // 
            this.ctltSplitTmpPoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltSplitTmpPoolButton.Enabled = false;
            this.ctltSplitTmpPoolButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltSplitTmpPoolButton.Image")));
            this.ctltSplitTmpPoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltSplitTmpPoolButton.Name = "ctltSplitTmpPoolButton";
            this.ctltSplitTmpPoolButton.Size = new System.Drawing.Size(93, 22);
            this.ctltSplitTmpPoolButton.Text = "拆分临时进程池";
            // 
            // ctltMergeTmpPoolButton
            // 
            this.ctltMergeTmpPoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltMergeTmpPoolButton.Enabled = false;
            this.ctltMergeTmpPoolButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltMergeTmpPoolButton.Image")));
            this.ctltMergeTmpPoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltMergeTmpPoolButton.Name = "ctltMergeTmpPoolButton";
            this.ctltMergeTmpPoolButton.Size = new System.Drawing.Size(93, 22);
            this.ctltMergeTmpPoolButton.Text = "合并临时进程池";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ctltSplitPoolButton
            // 
            this.ctltSplitPoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltSplitPoolButton.Enabled = false;
            this.ctltSplitPoolButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltSplitPoolButton.Image")));
            this.ctltSplitPoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltSplitPoolButton.Name = "ctltSplitPoolButton";
            this.ctltSplitPoolButton.Size = new System.Drawing.Size(105, 22);
            this.ctltSplitPoolButton.Text = "拆分为独立进程池";
            this.ctltSplitPoolButton.Click += new System.EventHandler(this.ctltSplitPoolButton_Click);
            // 
            // ctltMergePoolButton
            // 
            this.ctltMergePoolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltMergePoolButton.Enabled = false;
            this.ctltMergePoolButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltMergePoolButton.Image")));
            this.ctltMergePoolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltMergePoolButton.Name = "ctltMergePoolButton";
            this.ctltMergePoolButton.Size = new System.Drawing.Size(105, 22);
            this.ctltMergePoolButton.Text = "合并为一个进程池";
            this.ctltMergePoolButton.Click += new System.EventHandler(this.ctltMergePoolButton_Click);
            // 
            // ApplicationPoolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 404);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ApplicationPoolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "应用程序池性能窗口 预览版本未开发完毕 非最终程序";
            this.Shown += new System.EventHandler(this.ApplicationPoolsForm_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Silmoon.Windows.Controls.DoubleBufferListView listView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlsStateText;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 结束进程KToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ToolStripMenuItem 刷新列表RToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripButton ctltRefreshListButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ctltSplitTmpPoolButton;
        private System.Windows.Forms.ToolStripButton ctltMergeTmpPoolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton ctltSplitPoolButton;
        private System.Windows.Forms.ToolStripButton ctltMergePoolButton;
    }
}