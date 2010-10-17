namespace SST.Ext
{
    partial class GuideForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.WBMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新RToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.后退BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.前进FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助首页HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.WBMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.webBrowser1);
            this.splitContainer1.Size = new System.Drawing.Size(695, 372);
            this.splitContainer1.SplitterDistance = 231;
            this.splitContainer1.TabIndex = 0;
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(231, 372);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "加载列表中...";
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.WBMenu;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(460, 372);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            this.webBrowser1.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.webBrowser1_Navigating);
            // 
            // WBMenu
            // 
            this.WBMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新RToolStripMenuItem1,
            this.后退BToolStripMenuItem,
            this.前进FToolStripMenuItem,
            this.帮助首页HToolStripMenuItem});
            this.WBMenu.Name = "WBMenu";
            this.WBMenu.Size = new System.Drawing.Size(138, 92);
            // 
            // 刷新RToolStripMenuItem1
            // 
            this.刷新RToolStripMenuItem1.Name = "刷新RToolStripMenuItem1";
            this.刷新RToolStripMenuItem1.Size = new System.Drawing.Size(137, 22);
            this.刷新RToolStripMenuItem1.Text = "刷新(&R)";
            this.刷新RToolStripMenuItem1.Click += new System.EventHandler(this.刷新RToolStripMenuItem1_Click);
            // 
            // 后退BToolStripMenuItem
            // 
            this.后退BToolStripMenuItem.Name = "后退BToolStripMenuItem";
            this.后退BToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.后退BToolStripMenuItem.Text = "后退(&B)";
            this.后退BToolStripMenuItem.Click += new System.EventHandler(this.后退BToolStripMenuItem_Click);
            // 
            // 前进FToolStripMenuItem
            // 
            this.前进FToolStripMenuItem.Name = "前进FToolStripMenuItem";
            this.前进FToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.前进FToolStripMenuItem.Text = "前进(&F)";
            this.前进FToolStripMenuItem.Click += new System.EventHandler(this.前进FToolStripMenuItem_Click);
            // 
            // 帮助首页HToolStripMenuItem
            // 
            this.帮助首页HToolStripMenuItem.Name = "帮助首页HToolStripMenuItem";
            this.帮助首页HToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.帮助首页HToolStripMenuItem.Text = "帮助首页(&H)";
            this.帮助首页HToolStripMenuItem.Click += new System.EventHandler(this.帮助首页HToolStripMenuItem_Click);
            // 
            // GuideForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 372);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GuideForm";
            this.Text = "SST使用手册以及导向";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GuideForm_FormClosed);
            this.Load += new System.EventHandler(this.GuideForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.WBMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip WBMenu;
        private System.Windows.Forms.ToolStripMenuItem 刷新RToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 后退BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 前进FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助首页HToolStripMenuItem;
    }
}