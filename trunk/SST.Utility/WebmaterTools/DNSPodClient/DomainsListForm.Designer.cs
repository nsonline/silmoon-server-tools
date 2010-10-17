namespace DNSPodClient
{
    partial class DomainsListForm
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("   刷新域名列表中...");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DomainsListForm));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑域名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加域名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除域名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.禁用域名ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlDomainList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ctltAddDomainButton = new System.Windows.Forms.ToolStripButton();
            this.ctltDeleteDomainButton = new System.Windows.Forms.ToolStripButton();
            this.ctltEditDomainButton = new System.Windows.Forms.ToolStripButton();
            this.ctltSetDomainButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctltStateLabel = new System.Windows.Forms.ToolStripLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.域名DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出列表EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入列表IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dNSPodDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新列表ToolStripMenuItem,
            this.编辑域名ToolStripMenuItem,
            this.添加域名ToolStripMenuItem,
            this.删除域名ToolStripMenuItem,
            this.禁用域名ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 114);
            // 
            // 刷新列表ToolStripMenuItem
            // 
            this.刷新列表ToolStripMenuItem.Name = "刷新列表ToolStripMenuItem";
            this.刷新列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新列表ToolStripMenuItem.Text = "刷新列表(&R)";
            this.刷新列表ToolStripMenuItem.Click += new System.EventHandler(this.刷新列表ToolStripMenuItem_Click);
            // 
            // 编辑域名ToolStripMenuItem
            // 
            this.编辑域名ToolStripMenuItem.Enabled = false;
            this.编辑域名ToolStripMenuItem.Name = "编辑域名ToolStripMenuItem";
            this.编辑域名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.编辑域名ToolStripMenuItem.Text = "编辑域名(&E)";
            this.编辑域名ToolStripMenuItem.Click += new System.EventHandler(this.编辑域名ToolStripMenuItem_Click);
            // 
            // 添加域名ToolStripMenuItem
            // 
            this.添加域名ToolStripMenuItem.Name = "添加域名ToolStripMenuItem";
            this.添加域名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加域名ToolStripMenuItem.Text = "添加域名(&A)";
            this.添加域名ToolStripMenuItem.Click += new System.EventHandler(this.添加域名ToolStripMenuItem_Click);
            // 
            // 删除域名ToolStripMenuItem
            // 
            this.删除域名ToolStripMenuItem.Enabled = false;
            this.删除域名ToolStripMenuItem.Name = "删除域名ToolStripMenuItem";
            this.删除域名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除域名ToolStripMenuItem.Text = "删除域名(&D)";
            this.删除域名ToolStripMenuItem.Click += new System.EventHandler(this.删除域名ToolStripMenuItem_Click);
            // 
            // 禁用域名ToolStripMenuItem
            // 
            this.禁用域名ToolStripMenuItem.Enabled = false;
            this.禁用域名ToolStripMenuItem.Name = "禁用域名ToolStripMenuItem";
            this.禁用域名ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.禁用域名ToolStripMenuItem.Text = "禁用域名(&S)";
            this.禁用域名ToolStripMenuItem.Click += new System.EventHandler(this.禁用域名ToolStripMenuItem_Click);
            // 
            // ctlDomainList
            // 
            this.ctlDomainList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.ctlDomainList.ContextMenuStrip = this.contextMenuStrip1;
            this.ctlDomainList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlDomainList.FullRowSelect = true;
            this.ctlDomainList.HideSelection = false;
            this.ctlDomainList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.ctlDomainList.Location = new System.Drawing.Point(0, 49);
            this.ctlDomainList.Name = "ctlDomainList";
            this.ctlDomainList.Size = new System.Drawing.Size(669, 372);
            this.ctlDomainList.TabIndex = 2;
            this.ctlDomainList.UseCompatibleStateImageBehavior = false;
            this.ctlDomainList.View = System.Windows.Forms.View.Details;
            this.ctlDomainList.SelectedIndexChanged += new System.EventHandler(this.ctlDomainList_SelectedIndexChanged);
            this.ctlDomainList.DoubleClick += new System.EventHandler(this.ctlDomainList_DoubleClick);
            this.ctlDomainList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ctlDomainList_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "域名";
            this.columnHeader1.Width = 248;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "状态";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "记录数";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "ID";
            this.columnHeader4.Width = 297;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctltAddDomainButton,
            this.ctltDeleteDomainButton,
            this.ctltEditDomainButton,
            this.ctltSetDomainButton,
            this.toolStripSeparator1,
            this.ctltStateLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ctltAddDomainButton
            // 
            this.ctltAddDomainButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltAddDomainButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltAddDomainButton.Image")));
            this.ctltAddDomainButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltAddDomainButton.Name = "ctltAddDomainButton";
            this.ctltAddDomainButton.Size = new System.Drawing.Size(75, 22);
            this.ctltAddDomainButton.Text = "添加域名(&A)";
            this.ctltAddDomainButton.Click += new System.EventHandler(this.ctltAddDomainButton_Click);
            // 
            // ctltDeleteDomainButton
            // 
            this.ctltDeleteDomainButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltDeleteDomainButton.Enabled = false;
            this.ctltDeleteDomainButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltDeleteDomainButton.Image")));
            this.ctltDeleteDomainButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltDeleteDomainButton.Name = "ctltDeleteDomainButton";
            this.ctltDeleteDomainButton.Size = new System.Drawing.Size(75, 22);
            this.ctltDeleteDomainButton.Text = "删除域名(&D)";
            this.ctltDeleteDomainButton.Click += new System.EventHandler(this.ctltDeleteDomainButton_Click);
            // 
            // ctltEditDomainButton
            // 
            this.ctltEditDomainButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltEditDomainButton.Enabled = false;
            this.ctltEditDomainButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltEditDomainButton.Image")));
            this.ctltEditDomainButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltEditDomainButton.Name = "ctltEditDomainButton";
            this.ctltEditDomainButton.Size = new System.Drawing.Size(75, 22);
            this.ctltEditDomainButton.Text = "编辑域名(&E)";
            this.ctltEditDomainButton.Click += new System.EventHandler(this.ctltEditDomainButton_Click);
            // 
            // ctltSetDomainButton
            // 
            this.ctltSetDomainButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltSetDomainButton.Enabled = false;
            this.ctltSetDomainButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltSetDomainButton.Image")));
            this.ctltSetDomainButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltSetDomainButton.Name = "ctltSetDomainButton";
            this.ctltSetDomainButton.Size = new System.Drawing.Size(75, 22);
            this.ctltSetDomainButton.Text = "禁用域名(&S)";
            this.ctltSetDomainButton.Click += new System.EventHandler(this.ctltSetDomainButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ctltStateLabel
            // 
            this.ctltStateLabel.Name = "ctltStateLabel";
            this.ctltStateLabel.Size = new System.Drawing.Size(167, 22);
            this.ctltStateLabel.Text = "正在从接口服务器获取数据...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "本程序使用SSL(HTTPS)传输数据";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlStatusText
            // 
            this.ctlStatusText.Name = "ctlStatusText";
            this.ctlStatusText.Size = new System.Drawing.Size(47, 17);
            this.ctlStatusText.Text = "等待...";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件FToolStripMenuItem,
            this.域名DToolStripMenuItem,
            this.帮助HToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(669, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件FToolStripMenuItem
            // 
            this.文件FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.退出XToolStripMenuItem});
            this.文件FToolStripMenuItem.Name = "文件FToolStripMenuItem";
            this.文件FToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.文件FToolStripMenuItem.Text = "文件(&F)";
            // 
            // 退出XToolStripMenuItem
            // 
            this.退出XToolStripMenuItem.Name = "退出XToolStripMenuItem";
            this.退出XToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.退出XToolStripMenuItem.Text = "退出(&X)";
            this.退出XToolStripMenuItem.Click += new System.EventHandler(this.退出XToolStripMenuItem_Click);
            // 
            // 域名DToolStripMenuItem
            // 
            this.域名DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导出列表EToolStripMenuItem,
            this.导入列表IToolStripMenuItem});
            this.域名DToolStripMenuItem.Name = "域名DToolStripMenuItem";
            this.域名DToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.域名DToolStripMenuItem.Text = "域名(&D)";
            // 
            // 导出列表EToolStripMenuItem
            // 
            this.导出列表EToolStripMenuItem.Name = "导出列表EToolStripMenuItem";
            this.导出列表EToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.导出列表EToolStripMenuItem.Text = "导出列表(&E)";
            this.导出列表EToolStripMenuItem.Click += new System.EventHandler(this.导出列表EToolStripMenuItem_Click);
            // 
            // 导入列表IToolStripMenuItem
            // 
            this.导入列表IToolStripMenuItem.Name = "导入列表IToolStripMenuItem";
            this.导入列表IToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.导入列表IToolStripMenuItem.Text = "导入列表(&I)";
            this.导入列表IToolStripMenuItem.Click += new System.EventHandler(this.导入列表IToolStripMenuItem_Click);
            // 
            // 帮助HToolStripMenuItem
            // 
            this.帮助HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于AToolStripMenuItem,
            this.dNSPodDToolStripMenuItem});
            this.帮助HToolStripMenuItem.Name = "帮助HToolStripMenuItem";
            this.帮助HToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助HToolStripMenuItem.Text = "帮助(&H)";
            // 
            // 关于AToolStripMenuItem
            // 
            this.关于AToolStripMenuItem.Name = "关于AToolStripMenuItem";
            this.关于AToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.关于AToolStripMenuItem.Text = "关于(&A)";
            this.关于AToolStripMenuItem.Click += new System.EventHandler(this.关于AToolStripMenuItem_Click);
            // 
            // dNSPodDToolStripMenuItem
            // 
            this.dNSPodDToolStripMenuItem.Name = "dNSPodDToolStripMenuItem";
            this.dNSPodDToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.dNSPodDToolStripMenuItem.Text = "DNSPod(&D)";
            this.dNSPodDToolStripMenuItem.Click += new System.EventHandler(this.dNSPodDToolStripMenuItem_Click);
            // 
            // DomainsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 443);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlDomainList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DomainsListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DNSPod Client";
            this.Shown += new System.EventHandler(this.DomainListForm_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑域名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加域名ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除域名ToolStripMenuItem;
        private System.Windows.Forms.ListView ctlDomainList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ToolStripMenuItem 禁用域名ToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ctltAddDomainButton;
        private System.Windows.Forms.ToolStripButton ctltDeleteDomainButton;
        private System.Windows.Forms.ToolStripButton ctltEditDomainButton;
        private System.Windows.Forms.ToolStripButton ctltSetDomainButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel ctltStateLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusText;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 域名DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出列表EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导入列表IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dNSPodDToolStripMenuItem;
    }
}