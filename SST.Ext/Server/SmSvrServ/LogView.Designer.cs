namespace SST.Ext.Server.SmSvrServ
{
    partial class LogView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogView));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RefreshLog = new System.Windows.Forms.ToolStripButton();
            this.ClearLog = new System.Windows.Forms.ToolStripButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RefreshLog,
            this.ClearLog});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(500, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RefreshLog
            // 
            this.RefreshLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshLog.Image = ((System.Drawing.Image)(resources.GetObject("RefreshLog.Image")));
            this.RefreshLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshLog.Name = "RefreshLog";
            this.RefreshLog.Size = new System.Drawing.Size(57, 22);
            this.RefreshLog.Text = "刷新日志";
            this.RefreshLog.Click += new System.EventHandler(this.RefreshLog_Click);
            // 
            // ClearLog
            // 
            this.ClearLog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ClearLog.Image = ((System.Drawing.Image)(resources.GetObject("ClearLog.Image")));
            this.ClearLog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearLog.Name = "ClearLog";
            this.ClearLog.Size = new System.Drawing.Size(33, 22);
            this.ClearLog.Text = "清空";
            this.ClearLog.Click += new System.EventHandler(this.ClearLog_Click);
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(500, 292);
            this.listBox1.TabIndex = 1;
            // 
            // LogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 318);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LogView";
            this.Text = "银月服务器服务(SmSvrServ)日志查看";
            this.Load += new System.EventHandler(this.LogView_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogView_FormClosed);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripButton RefreshLog;
        private System.Windows.Forms.ToolStripButton ClearLog;
    }
}