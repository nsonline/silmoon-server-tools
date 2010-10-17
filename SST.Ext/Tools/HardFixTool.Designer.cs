namespace SST.Ext.Tools
{
    partial class HardFixTool
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
            this.b_FixWindowsInstallCopyFiles = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_FixWindowsInstallCopyFiles
            // 
            this.b_FixWindowsInstallCopyFiles.Location = new System.Drawing.Point(12, 12);
            this.b_FixWindowsInstallCopyFiles.Name = "b_FixWindowsInstallCopyFiles";
            this.b_FixWindowsInstallCopyFiles.Size = new System.Drawing.Size(182, 34);
            this.b_FixWindowsInstallCopyFiles.TabIndex = 0;
            this.b_FixWindowsInstallCopyFiles.Text = "Windows组件安装复制文件文件\r\n明明存在，但总是复制失败修复";
            this.b_FixWindowsInstallCopyFiles.UseVisualStyleBackColor = true;
            this.b_FixWindowsInstallCopyFiles.Click += new System.EventHandler(this.b_FixWindowsInstallCopyFiles_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(379, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "等待添加...";
            // 
            // HardFixTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 230);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_FixWindowsInstallCopyFiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "HardFixTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "疑难杂症工具包";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_FixWindowsInstallCopyFiles;
        private System.Windows.Forms.Label label1;
    }
}