namespace SST.Ext.IIS
{
    partial class IISManagerForm
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新网站列表RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开网站目录OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除选定站点DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctlWebsitelv = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlBindingsButton = new System.Windows.Forms.Button();
            this.ctlOpenIISMMC = new System.Windows.Forms.Button();
            this.ctlStartWebsite = new System.Windows.Forms.Button();
            this.ctlStopWebsite = new System.Windows.Forms.Button();
            this.ctlCreateNew = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新网站列表RToolStripMenuItem,
            this.打开网站目录OToolStripMenuItem,
            this.删除选定站点DToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 70);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // 刷新网站列表RToolStripMenuItem
            // 
            this.刷新网站列表RToolStripMenuItem.Name = "刷新网站列表RToolStripMenuItem";
            this.刷新网站列表RToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.刷新网站列表RToolStripMenuItem.Text = "刷新网站列表(&R)";
            this.刷新网站列表RToolStripMenuItem.Click += new System.EventHandler(this.刷新网站列表RToolStripMenuItem_Click);
            // 
            // 打开网站目录OToolStripMenuItem
            // 
            this.打开网站目录OToolStripMenuItem.Name = "打开网站目录OToolStripMenuItem";
            this.打开网站目录OToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.打开网站目录OToolStripMenuItem.Text = "打开网站目录(&O)";
            this.打开网站目录OToolStripMenuItem.Click += new System.EventHandler(this.打开网站目录OToolStripMenuItem_Click);
            // 
            // 删除选定站点DToolStripMenuItem
            // 
            this.删除选定站点DToolStripMenuItem.Name = "删除选定站点DToolStripMenuItem";
            this.删除选定站点DToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.删除选定站点DToolStripMenuItem.Text = "删除选定站点(&D)";
            this.删除选定站点DToolStripMenuItem.Click += new System.EventHandler(this.删除选定站点DToolStripMenuItem_Click);
            // 
            // ctlWebsitelv
            // 
            this.ctlWebsitelv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader1});
            this.ctlWebsitelv.ContextMenuStrip = this.contextMenuStrip1;
            this.ctlWebsitelv.FullRowSelect = true;
            this.ctlWebsitelv.HideSelection = false;
            this.ctlWebsitelv.Location = new System.Drawing.Point(6, 20);
            this.ctlWebsitelv.Name = "ctlWebsitelv";
            this.ctlWebsitelv.Size = new System.Drawing.Size(369, 296);
            this.ctlWebsitelv.TabIndex = 0;
            this.ctlWebsitelv.UseCompatibleStateImageBehavior = false;
            this.ctlWebsitelv.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "名称";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "状态";
            this.columnHeader5.Width = 54;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "所在池";
            this.columnHeader6.Width = 112;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 114;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlBindingsButton);
            this.groupBox1.Controls.Add(this.ctlOpenIISMMC);
            this.groupBox1.Controls.Add(this.ctlStartWebsite);
            this.groupBox1.Controls.Add(this.ctlStopWebsite);
            this.groupBox1.Controls.Add(this.ctlCreateNew);
            this.groupBox1.Controls.Add(this.ctlWebsitelv);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 322);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "维护";
            // 
            // ctlBindingsButton
            // 
            this.ctlBindingsButton.Location = new System.Drawing.Point(381, 180);
            this.ctlBindingsButton.Name = "ctlBindingsButton";
            this.ctlBindingsButton.Size = new System.Drawing.Size(104, 34);
            this.ctlBindingsButton.TabIndex = 5;
            this.ctlBindingsButton.Text = "绑定管理(&B)";
            this.ctlBindingsButton.UseVisualStyleBackColor = true;
            this.ctlBindingsButton.Click += new System.EventHandler(this.ctlBindingsButton_Click);
            // 
            // ctlOpenIISMMC
            // 
            this.ctlOpenIISMMC.Location = new System.Drawing.Point(381, 140);
            this.ctlOpenIISMMC.Name = "ctlOpenIISMMC";
            this.ctlOpenIISMMC.Size = new System.Drawing.Size(104, 34);
            this.ctlOpenIISMMC.TabIndex = 4;
            this.ctlOpenIISMMC.Text = "打开IIS管理器(&I)";
            this.ctlOpenIISMMC.UseVisualStyleBackColor = true;
            this.ctlOpenIISMMC.Click += new System.EventHandler(this.ctlOpenIISMMC_Click);
            // 
            // ctlStartWebsite
            // 
            this.ctlStartWebsite.Location = new System.Drawing.Point(381, 100);
            this.ctlStartWebsite.Name = "ctlStartWebsite";
            this.ctlStartWebsite.Size = new System.Drawing.Size(104, 34);
            this.ctlStartWebsite.TabIndex = 2;
            this.ctlStartWebsite.Text = "启动站点(&S)";
            this.ctlStartWebsite.UseVisualStyleBackColor = true;
            this.ctlStartWebsite.Click += new System.EventHandler(this.ctlStartWebsite_Click);
            // 
            // ctlStopWebsite
            // 
            this.ctlStopWebsite.Location = new System.Drawing.Point(381, 60);
            this.ctlStopWebsite.Name = "ctlStopWebsite";
            this.ctlStopWebsite.Size = new System.Drawing.Size(104, 34);
            this.ctlStopWebsite.TabIndex = 3;
            this.ctlStopWebsite.Text = "停止站点(&T)";
            this.ctlStopWebsite.UseVisualStyleBackColor = true;
            this.ctlStopWebsite.Click += new System.EventHandler(this.ctlStopWebsite_Click);
            // 
            // ctlCreateNew
            // 
            this.ctlCreateNew.Location = new System.Drawing.Point(381, 20);
            this.ctlCreateNew.Name = "ctlCreateNew";
            this.ctlCreateNew.Size = new System.Drawing.Size(104, 34);
            this.ctlCreateNew.TabIndex = 1;
            this.ctlCreateNew.Text = "创建(&N)";
            this.ctlCreateNew.UseVisualStyleBackColor = true;
            this.ctlCreateNew.Click += new System.EventHandler(this.ctlCreateNew_Click);
            // 
            // IISUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 365);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IISUtility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "银月IIS管理 一键化工具(修订4)";
            this.Shown += new System.EventHandler(this.IISUtility_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新网站列表RToolStripMenuItem;
        private System.Windows.Forms.ListView ctlWebsitelv;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem 打开网站目录OToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除选定站点DToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ctlOpenIISMMC;
        private System.Windows.Forms.Button ctlCreateNew;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button ctlStopWebsite;
        private System.Windows.Forms.Button ctlStartWebsite;
        private System.Windows.Forms.Button ctlBindingsButton;

    }
}

