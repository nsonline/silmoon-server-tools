namespace DNSPodClient
{
    partial class RecordListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordListForm));
            this.ctlRecordList = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新列表RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑记录EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加记录AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除记录DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.禁用记录SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ctltAddRecordButton = new System.Windows.Forms.ToolStripButton();
            this.ctltDeleteRecordButton = new System.Windows.Forms.ToolStripButton();
            this.ctleEditRecordButton = new System.Windows.Forms.ToolStripButton();
            this.ctltSetRecordButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ctlImportRecordsButton = new System.Windows.Forms.ToolStripButton();
            this.ctlExportRecordsButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlStatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlRecordList
            // 
            this.ctlRecordList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.ctlRecordList.ContextMenuStrip = this.contextMenuStrip1;
            this.ctlRecordList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlRecordList.FullRowSelect = true;
            this.ctlRecordList.HideSelection = false;
            this.ctlRecordList.Location = new System.Drawing.Point(0, 25);
            this.ctlRecordList.Name = "ctlRecordList";
            this.ctlRecordList.Size = new System.Drawing.Size(669, 396);
            this.ctlRecordList.TabIndex = 0;
            this.ctlRecordList.UseCompatibleStateImageBehavior = false;
            this.ctlRecordList.View = System.Windows.Forms.View.Details;
            this.ctlRecordList.SelectedIndexChanged += new System.EventHandler(this.ctlRecordList_SelectedIndexChanged);
            this.ctlRecordList.DoubleClick += new System.EventHandler(this.ctlRecordList_DoubleClick);
            this.ctlRecordList.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ctlRecordList_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "域名";
            this.columnHeader1.Width = 115;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "类型";
            this.columnHeader2.Width = 50;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "线路";
            this.columnHeader3.Width = 50;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "记录值";
            this.columnHeader4.Width = 167;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "MX优先级";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "TTL";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "启用？";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "ID";
            this.columnHeader8.Width = 80;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新列表RToolStripMenuItem,
            this.编辑记录EToolStripMenuItem,
            this.添加记录AToolStripMenuItem,
            this.删除记录DToolStripMenuItem,
            this.禁用记录SToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 114);
            // 
            // 刷新列表RToolStripMenuItem
            // 
            this.刷新列表RToolStripMenuItem.Name = "刷新列表RToolStripMenuItem";
            this.刷新列表RToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.刷新列表RToolStripMenuItem.Text = "刷新列表(&R)";
            this.刷新列表RToolStripMenuItem.Click += new System.EventHandler(this.刷新列表RToolStripMenuItem_Click);
            // 
            // 编辑记录EToolStripMenuItem
            // 
            this.编辑记录EToolStripMenuItem.Enabled = false;
            this.编辑记录EToolStripMenuItem.Name = "编辑记录EToolStripMenuItem";
            this.编辑记录EToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.编辑记录EToolStripMenuItem.Text = "编辑记录(&E)";
            this.编辑记录EToolStripMenuItem.Click += new System.EventHandler(this.编辑记录EToolStripMenuItem_Click);
            // 
            // 添加记录AToolStripMenuItem
            // 
            this.添加记录AToolStripMenuItem.Name = "添加记录AToolStripMenuItem";
            this.添加记录AToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加记录AToolStripMenuItem.Text = "添加记录(&A)";
            this.添加记录AToolStripMenuItem.Click += new System.EventHandler(this.添加记录AToolStripMenuItem_Click);
            // 
            // 删除记录DToolStripMenuItem
            // 
            this.删除记录DToolStripMenuItem.Enabled = false;
            this.删除记录DToolStripMenuItem.Name = "删除记录DToolStripMenuItem";
            this.删除记录DToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除记录DToolStripMenuItem.Text = "删除记录(&D)";
            this.删除记录DToolStripMenuItem.Click += new System.EventHandler(this.删除记录DToolStripMenuItem_Click);
            // 
            // 禁用记录SToolStripMenuItem
            // 
            this.禁用记录SToolStripMenuItem.Enabled = false;
            this.禁用记录SToolStripMenuItem.Name = "禁用记录SToolStripMenuItem";
            this.禁用记录SToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.禁用记录SToolStripMenuItem.Text = "禁用记录(&S)";
            this.禁用记录SToolStripMenuItem.Click += new System.EventHandler(this.禁用记录SToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctltAddRecordButton,
            this.ctltDeleteRecordButton,
            this.ctleEditRecordButton,
            this.ctltSetRecordButton,
            this.toolStripSeparator1,
            this.ctlImportRecordsButton,
            this.ctlExportRecordsButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ctltAddRecordButton
            // 
            this.ctltAddRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltAddRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltAddRecordButton.Image")));
            this.ctltAddRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltAddRecordButton.Name = "ctltAddRecordButton";
            this.ctltAddRecordButton.Size = new System.Drawing.Size(75, 22);
            this.ctltAddRecordButton.Text = "添加记录(&A)";
            this.ctltAddRecordButton.Click += new System.EventHandler(this.ctltAddRecordButton_Click);
            // 
            // ctltDeleteRecordButton
            // 
            this.ctltDeleteRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltDeleteRecordButton.Enabled = false;
            this.ctltDeleteRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltDeleteRecordButton.Image")));
            this.ctltDeleteRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltDeleteRecordButton.Name = "ctltDeleteRecordButton";
            this.ctltDeleteRecordButton.Size = new System.Drawing.Size(75, 22);
            this.ctltDeleteRecordButton.Text = "删除记录(&D)";
            this.ctltDeleteRecordButton.Click += new System.EventHandler(this.ctltDeleteRecordButton_Click);
            // 
            // ctleEditRecordButton
            // 
            this.ctleEditRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctleEditRecordButton.Enabled = false;
            this.ctleEditRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("ctleEditRecordButton.Image")));
            this.ctleEditRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctleEditRecordButton.Name = "ctleEditRecordButton";
            this.ctleEditRecordButton.Size = new System.Drawing.Size(75, 22);
            this.ctleEditRecordButton.Text = "修改记录(&E)";
            this.ctleEditRecordButton.Click += new System.EventHandler(this.ctltEditRecordButton_Click);
            // 
            // ctltSetRecordButton
            // 
            this.ctltSetRecordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltSetRecordButton.Enabled = false;
            this.ctltSetRecordButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltSetRecordButton.Image")));
            this.ctltSetRecordButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltSetRecordButton.Name = "ctltSetRecordButton";
            this.ctltSetRecordButton.Size = new System.Drawing.Size(75, 22);
            this.ctltSetRecordButton.Text = "禁用记录(&S)";
            this.ctltSetRecordButton.Click += new System.EventHandler(this.ctltSetRecordButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ctlImportRecordsButton
            // 
            this.ctlImportRecordsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlImportRecordsButton.Image = ((System.Drawing.Image)(resources.GetObject("ctlImportRecordsButton.Image")));
            this.ctlImportRecordsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlImportRecordsButton.Name = "ctlImportRecordsButton";
            this.ctlImportRecordsButton.Size = new System.Drawing.Size(81, 22);
            this.ctlImportRecordsButton.Text = "导入域名纪录";
            this.ctlImportRecordsButton.Click += new System.EventHandler(this.ctlImportRecordsButton_Click);
            // 
            // ctlExportRecordsButton
            // 
            this.ctlExportRecordsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctlExportRecordsButton.Image = ((System.Drawing.Image)(resources.GetObject("ctlExportRecordsButton.Image")));
            this.ctlExportRecordsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctlExportRecordsButton.Name = "ctlExportRecordsButton";
            this.ctlExportRecordsButton.Size = new System.Drawing.Size(81, 22);
            this.ctlExportRecordsButton.Text = "导出域名纪录";
            this.ctlExportRecordsButton.Click += new System.EventHandler(this.ctlExportRecordsButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlStatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 421);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(669, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlStatusText
            // 
            this.ctlStatusText.Name = "ctlStatusText";
            this.ctlStatusText.Size = new System.Drawing.Size(23, 17);
            this.ctlStatusText.Text = "...";
            // 
            // RecordListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 443);
            this.Controls.Add(this.ctlRecordList);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "RecordListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordListForm";
            this.Shown += new System.EventHandler(this.RecordListForm_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ctlRecordList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新列表RToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加记录AToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ctltAddRecordButton;
        private System.Windows.Forms.ToolStripButton ctltDeleteRecordButton;
        private System.Windows.Forms.ToolStripButton ctleEditRecordButton;
        private System.Windows.Forms.ToolStripButton ctltSetRecordButton;
        private System.Windows.Forms.ToolStripMenuItem 编辑记录EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除记录DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 禁用记录SToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlStatusText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ctlImportRecordsButton;
        private System.Windows.Forms.ToolStripButton ctlExportRecordsButton;
    }
}