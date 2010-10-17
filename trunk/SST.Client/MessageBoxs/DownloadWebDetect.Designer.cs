namespace SST.Client.MessageBoxs
{
    partial class DownloadWebDetect
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
            this.ASP = new System.Windows.Forms.Button();
            this.ASPNET = new System.Windows.Forms.Button();
            this.PHP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ASP
            // 
            this.ASP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ASP.Location = new System.Drawing.Point(35, 23);
            this.ASP.Name = "ASP";
            this.ASP.Size = new System.Drawing.Size(75, 23);
            this.ASP.TabIndex = 0;
            this.ASP.Text = "ASP探针";
            this.ASP.UseVisualStyleBackColor = true;
            this.ASP.Click += new System.EventHandler(this.ASP_Click);
            // 
            // ASPNET
            // 
            this.ASPNET.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ASPNET.Location = new System.Drawing.Point(135, 23);
            this.ASPNET.Name = "ASPNET";
            this.ASPNET.Size = new System.Drawing.Size(81, 23);
            this.ASPNET.TabIndex = 1;
            this.ASPNET.Text = "ASP.net探针";
            this.ASPNET.UseVisualStyleBackColor = true;
            this.ASPNET.Click += new System.EventHandler(this.ASPNET_Click);
            // 
            // PHP
            // 
            this.PHP.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.PHP.Location = new System.Drawing.Point(238, 23);
            this.PHP.Name = "PHP";
            this.PHP.Size = new System.Drawing.Size(75, 23);
            this.PHP.TabIndex = 2;
            this.PHP.Text = "PHP探针";
            this.PHP.UseVisualStyleBackColor = true;
            this.PHP.Click += new System.EventHandler(this.PHP_Click);
            // 
            // DownloadWebDetect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 76);
            this.Controls.Add(this.PHP);
            this.Controls.Add(this.ASPNET);
            this.Controls.Add(this.ASP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DownloadWebDetect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "下载SST服务器上提供的探针";
            this.Load += new System.EventHandler(this.DownloadWebDetect_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ASP;
        private System.Windows.Forms.Button ASPNET;
        private System.Windows.Forms.Button PHP;
    }
}