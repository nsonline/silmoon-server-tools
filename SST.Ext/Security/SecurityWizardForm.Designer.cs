namespace SST.Ext.Security
{
    partial class SecurityWizardForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.停止设置终止线程SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始导向SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(525, 420);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.停止设置终止线程SToolStripMenuItem,
            this.重新开始导向SToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(197, 48);
            // 
            // 停止设置终止线程SToolStripMenuItem
            // 
            this.停止设置终止线程SToolStripMenuItem.Name = "停止设置终止线程SToolStripMenuItem";
            this.停止设置终止线程SToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.停止设置终止线程SToolStripMenuItem.Text = "停止设置(终止线程)(&T)";
            this.停止设置终止线程SToolStripMenuItem.Click += new System.EventHandler(this.停止设置终止线程SToolStripMenuItem_Click);
            // 
            // 重新开始导向SToolStripMenuItem
            // 
            this.重新开始导向SToolStripMenuItem.Name = "重新开始导向SToolStripMenuItem";
            this.重新开始导向SToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.重新开始导向SToolStripMenuItem.Text = "重新开始导向(&S)";
            this.重新开始导向SToolStripMenuItem.Click += new System.EventHandler(this.重新开始导向SToolStripMenuItem_Click);
            // 
            // SecurityWizardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 420);
            this.Controls.Add(this.textBox1);
            this.Name = "SecurityWizardForm";
            this.Text = "安全导向";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SecurityWizardForm_FormClosed);
            this.Shown += new System.EventHandler(this.SettingsWizardForm_Shown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 停止设置终止线程SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始导向SToolStripMenuItem;
    }
}