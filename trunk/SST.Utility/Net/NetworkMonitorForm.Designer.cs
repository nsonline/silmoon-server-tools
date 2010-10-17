namespace SST.Utility.Net
{
    partial class NetworkMonitorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NetworkMonitorForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.ctlClearListView = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ctltStartButton = new System.Windows.Forms.ToolStripButton();
            this.ctltClearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 25);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(592, 448);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.VirtualMode = true;
            this.listView1.RetrieveVirtualItem += new System.Windows.Forms.RetrieveVirtualItemEventHandler(this.listView1_RetrieveVirtualItem);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "源";
            this.columnHeader1.Width = 159;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "目标";
            this.columnHeader2.Width = 148;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "协议";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "包大小";
            this.columnHeader4.Width = 93;
            // 
            // ctlClearListView
            // 
            this.ctlClearListView.Location = new System.Drawing.Point(505, 437);
            this.ctlClearListView.Name = "ctlClearListView";
            this.ctlClearListView.Size = new System.Drawing.Size(75, 23);
            this.ctlClearListView.TabIndex = 2;
            this.ctlClearListView.Text = "清空(&C)";
            this.ctlClearListView.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctltStartButton,
            this.ctltClearButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(592, 25);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ctltStartButton
            // 
            this.ctltStartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltStartButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltStartButton.Image")));
            this.ctltStartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltStartButton.Name = "ctltStartButton";
            this.ctltStartButton.Size = new System.Drawing.Size(33, 22);
            this.ctltStartButton.Text = "开始";
            this.ctltStartButton.Click += new System.EventHandler(this.ctltStartButton_Click);
            // 
            // ctltClearButton
            // 
            this.ctltClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ctltClearButton.Image = ((System.Drawing.Image)(resources.GetObject("ctltClearButton.Image")));
            this.ctltClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ctltClearButton.Name = "ctltClearButton";
            this.ctltClearButton.Size = new System.Drawing.Size(33, 22);
            this.ctltClearButton.Text = "清空";
            this.ctltClearButton.Click += new System.EventHandler(this.ctltClearButton_Click);
            // 
            // NetworkMonitorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 473);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.ctlClearListView);
            this.Name = "NetworkMonitorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "网络数据包流量监控";
            this.Shown += new System.EventHandler(this.NetworkMonitorForm_Shown);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NetworkMonitorForm_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button ctlClearListView;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ctltStartButton;
        private System.Windows.Forms.ToolStripButton ctltClearButton;
    }
}