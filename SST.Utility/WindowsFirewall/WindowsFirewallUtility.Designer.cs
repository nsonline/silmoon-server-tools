namespace SST.Utility.WindowsFirewall
{
    partial class WindowsFirewallUtility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFirewallUtility));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.P1_RemovePort = new System.Windows.Forms.Button();
            this.P1_AddPort = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.端口 = new System.Windows.Forms.ColumnHeader();
            this.协议 = new System.Windows.Forms.ColumnHeader();
            this.状态 = new System.Windows.Forms.ColumnHeader();
            this.允许IP = new System.Windows.Forms.ColumnHeader();
            this.备注名称 = new System.Windows.Forms.ColumnHeader();
            this.P1_LoadList = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.P2_RemoveApp = new System.Windows.Forms.Button();
            this.P2_AddApp = new System.Windows.Forms.Button();
            this.P2_LoadList = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader8 = new System.Windows.Forms.ColumnHeader();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(435, 406);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.P1_RemovePort);
            this.tabPage1.Controls.Add(this.P1_AddPort);
            this.tabPage1.Controls.Add(this.listView1);
            this.tabPage1.Controls.Add(this.P1_LoadList);
            this.tabPage1.Location = new System.Drawing.Point(4, 21);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(427, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "端口列表";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // P1_RemovePort
            // 
            this.P1_RemovePort.Location = new System.Drawing.Point(336, 321);
            this.P1_RemovePort.Name = "P1_RemovePort";
            this.P1_RemovePort.Size = new System.Drawing.Size(85, 23);
            this.P1_RemovePort.TabIndex = 4;
            this.P1_RemovePort.Text = "移除端口(&R)";
            this.P1_RemovePort.UseVisualStyleBackColor = true;
            this.P1_RemovePort.Click += new System.EventHandler(this.P1_RemovePort_Click);
            // 
            // P1_AddPort
            // 
            this.P1_AddPort.Location = new System.Drawing.Point(336, 292);
            this.P1_AddPort.Name = "P1_AddPort";
            this.P1_AddPort.Size = new System.Drawing.Size(85, 23);
            this.P1_AddPort.TabIndex = 3;
            this.P1_AddPort.Text = "添加端口(&A)";
            this.P1_AddPort.UseVisualStyleBackColor = true;
            this.P1_AddPort.Click += new System.EventHandler(this.P1_AddPort_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.端口,
            this.协议,
            this.状态,
            this.允许IP,
            this.备注名称});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(3, 3);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(324, 375);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // 端口
            // 
            this.端口.Text = "端口";
            // 
            // 协议
            // 
            this.协议.Text = "协议";
            // 
            // 状态
            // 
            this.状态.Text = "状态";
            // 
            // 允许IP
            // 
            this.允许IP.Text = "允许IP";
            this.允许IP.Width = 67;
            // 
            // 备注名称
            // 
            this.备注名称.Text = "备注名称";
            this.备注名称.Width = 73;
            // 
            // P1_LoadList
            // 
            this.P1_LoadList.Location = new System.Drawing.Point(336, 350);
            this.P1_LoadList.Name = "P1_LoadList";
            this.P1_LoadList.Size = new System.Drawing.Size(85, 23);
            this.P1_LoadList.TabIndex = 1;
            this.P1_LoadList.Text = "载入列表(&L)";
            this.P1_LoadList.UseVisualStyleBackColor = true;
            this.P1_LoadList.Click += new System.EventHandler(this.P1_LoadList_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.P2_RemoveApp);
            this.tabPage2.Controls.Add(this.P2_AddApp);
            this.tabPage2.Controls.Add(this.P2_LoadList);
            this.tabPage2.Controls.Add(this.listView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 21);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(427, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "程序列表";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // P2_RemoveApp
            // 
            this.P2_RemoveApp.Location = new System.Drawing.Point(336, 321);
            this.P2_RemoveApp.Name = "P2_RemoveApp";
            this.P2_RemoveApp.Size = new System.Drawing.Size(85, 23);
            this.P2_RemoveApp.TabIndex = 6;
            this.P2_RemoveApp.Text = "移除程序(&R)";
            this.P2_RemoveApp.UseVisualStyleBackColor = true;
            this.P2_RemoveApp.Click += new System.EventHandler(this.P2_RemoveApp_Click);
            // 
            // P2_AddApp
            // 
            this.P2_AddApp.Location = new System.Drawing.Point(336, 292);
            this.P2_AddApp.Name = "P2_AddApp";
            this.P2_AddApp.Size = new System.Drawing.Size(85, 23);
            this.P2_AddApp.TabIndex = 5;
            this.P2_AddApp.Text = "添加程序(&A)";
            this.P2_AddApp.UseVisualStyleBackColor = true;
            this.P2_AddApp.Click += new System.EventHandler(this.P2_AddApp_Click);
            // 
            // P2_LoadList
            // 
            this.P2_LoadList.Location = new System.Drawing.Point(336, 350);
            this.P2_LoadList.Name = "P2_LoadList";
            this.P2_LoadList.Size = new System.Drawing.Size(85, 23);
            this.P2_LoadList.TabIndex = 4;
            this.P2_LoadList.Text = "载入列表(&L)";
            this.P2_LoadList.UseVisualStyleBackColor = true;
            this.P2_LoadList.Click += new System.EventHandler(this.P2_LoadList_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView2.FullRowSelect = true;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(324, 375);
            this.listView2.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            this.listView2.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView2_ColumnClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "备注名";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "状态";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "映像路径";
            this.columnHeader8.Width = 199;
            // 
            // WindowsFirewallUtility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 406);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowsFirewallUtility";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows防火墙实用工具";
            this.Load += new System.EventHandler(this.WindowsFirewallUtility_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button P1_LoadList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 端口;
        private System.Windows.Forms.ColumnHeader 协议;
        private System.Windows.Forms.ColumnHeader 状态;
        private System.Windows.Forms.ColumnHeader 允许IP;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader 备注名称;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button P2_LoadList;
        private System.Windows.Forms.Button P1_AddPort;
        private System.Windows.Forms.Button P1_RemovePort;
        private System.Windows.Forms.Button P2_RemoveApp;
        private System.Windows.Forms.Button P2_AddApp;
    }
}