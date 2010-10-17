namespace SST.Ext.Security
{
    partial class DriverFileSecurityWizard
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
            this.CDriverACLSetting = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // CDriverACLSetting
            // 
            this.CDriverACLSetting.Location = new System.Drawing.Point(409, 305);
            this.CDriverACLSetting.Name = "CDriverACLSetting";
            this.CDriverACLSetting.Size = new System.Drawing.Size(116, 23);
            this.CDriverACLSetting.TabIndex = 0;
            this.CDriverACLSetting.Text = "一键处理C盘ACL(&S)";
            this.CDriverACLSetting.UseVisualStyleBackColor = true;
            this.CDriverACLSetting.Click += new System.EventHandler(this.CDriverACLSetting_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.Control;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(403, 336);
            this.listBox1.TabIndex = 1;
            // 
            // DriverFileSecurityWizard
            // 
            this.ClientSize = new System.Drawing.Size(529, 336);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CDriverACLSetting);
            this.Name = "DriverFileSecurityWizard";
            this.Text = "驱动器文件导向";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CDriverACLSetting;
        private System.Windows.Forms.ListBox listBox1;
    }
}