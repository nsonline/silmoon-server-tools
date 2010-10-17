namespace SST.Ext.IIS
{
    partial class IISBackupForm
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
            this.ctlWebSiteListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.ctlLoadIISSitesButton = new System.Windows.Forms.Button();
            this.ctlWebSitesBackupFileButton = new System.Windows.Forms.Button();
            this.ctlLoadBackupFileButton = new System.Windows.Forms.Button();
            this.ctlCreateAllListSitesButton = new System.Windows.Forms.Button();
            this.ctlCreateNotExistSitesButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ctlsStateText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ctlCreateSelectedSitesButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctlWebSiteListView
            // 
            this.ctlWebSiteListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.ctlWebSiteListView.FullRowSelect = true;
            this.ctlWebSiteListView.HideSelection = false;
            this.ctlWebSiteListView.Location = new System.Drawing.Point(12, 12);
            this.ctlWebSiteListView.Name = "ctlWebSiteListView";
            this.ctlWebSiteListView.Size = new System.Drawing.Size(591, 415);
            this.ctlWebSiteListView.TabIndex = 0;
            this.ctlWebSiteListView.UseCompatibleStateImageBehavior = false;
            this.ctlWebSiteListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "站点名称";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "站点ID";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "主目录";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "进程池";
            this.columnHeader4.Width = 80;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "状态";
            this.columnHeader5.Width = 70;
            // 
            // ctlLoadIISSitesButton
            // 
            this.ctlLoadIISSitesButton.Location = new System.Drawing.Point(6, 20);
            this.ctlLoadIISSitesButton.Name = "ctlLoadIISSitesButton";
            this.ctlLoadIISSitesButton.Size = new System.Drawing.Size(143, 37);
            this.ctlLoadIISSitesButton.TabIndex = 1;
            this.ctlLoadIISSitesButton.Text = "载入当前IIS站点";
            this.ctlLoadIISSitesButton.UseVisualStyleBackColor = true;
            this.ctlLoadIISSitesButton.Click += new System.EventHandler(this.ctlLoadIISSitesButton_Click);
            // 
            // ctlWebSitesBackupFileButton
            // 
            this.ctlWebSitesBackupFileButton.Location = new System.Drawing.Point(6, 63);
            this.ctlWebSitesBackupFileButton.Name = "ctlWebSitesBackupFileButton";
            this.ctlWebSitesBackupFileButton.Size = new System.Drawing.Size(143, 37);
            this.ctlWebSitesBackupFileButton.TabIndex = 2;
            this.ctlWebSitesBackupFileButton.Text = "将列表中的站点备份成文件";
            this.ctlWebSitesBackupFileButton.UseVisualStyleBackColor = true;
            this.ctlWebSitesBackupFileButton.Click += new System.EventHandler(this.ctlWebSitesBackupFileButton_Click);
            // 
            // ctlLoadBackupFileButton
            // 
            this.ctlLoadBackupFileButton.Location = new System.Drawing.Point(6, 106);
            this.ctlLoadBackupFileButton.Name = "ctlLoadBackupFileButton";
            this.ctlLoadBackupFileButton.Size = new System.Drawing.Size(143, 37);
            this.ctlLoadBackupFileButton.TabIndex = 3;
            this.ctlLoadBackupFileButton.Text = "导入备份文件";
            this.ctlLoadBackupFileButton.UseVisualStyleBackColor = true;
            this.ctlLoadBackupFileButton.Click += new System.EventHandler(this.ctlLoadBackupFileButton_Click);
            // 
            // ctlCreateAllListSitesButton
            // 
            this.ctlCreateAllListSitesButton.Location = new System.Drawing.Point(6, 20);
            this.ctlCreateAllListSitesButton.Name = "ctlCreateAllListSitesButton";
            this.ctlCreateAllListSitesButton.Size = new System.Drawing.Size(143, 37);
            this.ctlCreateAllListSitesButton.TabIndex = 4;
            this.ctlCreateAllListSitesButton.Text = "创建列表中所有站点";
            this.ctlCreateAllListSitesButton.UseVisualStyleBackColor = true;
            this.ctlCreateAllListSitesButton.Click += new System.EventHandler(this.ctlCreateAllListSitesButton_Click);
            // 
            // ctlCreateNotExistSitesButton
            // 
            this.ctlCreateNotExistSitesButton.Location = new System.Drawing.Point(6, 63);
            this.ctlCreateNotExistSitesButton.Name = "ctlCreateNotExistSitesButton";
            this.ctlCreateNotExistSitesButton.Size = new System.Drawing.Size(143, 37);
            this.ctlCreateNotExistSitesButton.TabIndex = 5;
            this.ctlCreateNotExistSitesButton.Text = "创建列表中未创建的站点";
            this.ctlCreateNotExistSitesButton.UseVisualStyleBackColor = true;
            this.ctlCreateNotExistSitesButton.Click += new System.EventHandler(this.ctlCreateNotExistSitesButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctlsStateText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 434);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(776, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ctlsStateText
            // 
            this.ctlsStateText.Name = "ctlsStateText";
            this.ctlsStateText.Size = new System.Drawing.Size(47, 17);
            this.ctlsStateText.Text = "就绪...";
            // 
            // ctlCreateSelectedSitesButton
            // 
            this.ctlCreateSelectedSitesButton.Location = new System.Drawing.Point(6, 106);
            this.ctlCreateSelectedSitesButton.Name = "ctlCreateSelectedSitesButton";
            this.ctlCreateSelectedSitesButton.Size = new System.Drawing.Size(143, 37);
            this.ctlCreateSelectedSitesButton.TabIndex = 7;
            this.ctlCreateSelectedSitesButton.Text = "创建选中的网站";
            this.ctlCreateSelectedSitesButton.UseVisualStyleBackColor = true;
            this.ctlCreateSelectedSitesButton.Click += new System.EventHandler(this.ctlCreateSelectedSitesButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlLoadIISSitesButton);
            this.groupBox1.Controls.Add(this.ctlWebSitesBackupFileButton);
            this.groupBox1.Controls.Add(this.ctlLoadBackupFileButton);
            this.groupBox1.Location = new System.Drawing.Point(609, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(155, 154);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlCreateAllListSitesButton);
            this.groupBox2.Controls.Add(this.ctlCreateSelectedSitesButton);
            this.groupBox2.Controls.Add(this.ctlCreateNotExistSitesButton);
            this.groupBox2.Location = new System.Drawing.Point(609, 172);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(155, 155);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "创建";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(609, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(155, 94);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "说明";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "备份站点会将站点目录、\r\n站点名、站点ID、进程\r\n池、日志目录这些配置\r\n进行备份，其他设置会\r\n忽略！";
            // 
            // IISBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 456);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ctlWebSiteListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "IISBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "银月IIS备份工具";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ctlWebSiteListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button ctlLoadIISSitesButton;
        private System.Windows.Forms.Button ctlWebSitesBackupFileButton;
        private System.Windows.Forms.Button ctlLoadBackupFileButton;
        private System.Windows.Forms.Button ctlCreateAllListSitesButton;
        private System.Windows.Forms.Button ctlCreateNotExistSitesButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ctlsStateText;
        private System.Windows.Forms.Button ctlCreateSelectedSitesButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
    }
}

