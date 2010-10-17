namespace SST.Ext.Security
{
    partial class FileSystemACLWizard
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
            this.C_WebWizard = new System.Windows.Forms.Button();
            this.C_DataBaseWizard = new System.Windows.Forms.Button();
            this.C_OtherWizard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // C_WebWizard
            // 
            this.C_WebWizard.Location = new System.Drawing.Point(6, 23);
            this.C_WebWizard.Name = "C_WebWizard";
            this.C_WebWizard.Size = new System.Drawing.Size(120, 23);
            this.C_WebWizard.TabIndex = 0;
            this.C_WebWizard.Text = "WEB目录安全向导(&W)";
            this.C_WebWizard.UseVisualStyleBackColor = true;
            this.C_WebWizard.Click += new System.EventHandler(this.C_WebWizard_Click);
            // 
            // C_DataBaseWizard
            // 
            this.C_DataBaseWizard.Location = new System.Drawing.Point(6, 65);
            this.C_DataBaseWizard.Name = "C_DataBaseWizard";
            this.C_DataBaseWizard.Size = new System.Drawing.Size(151, 23);
            this.C_DataBaseWizard.TabIndex = 1;
            this.C_DataBaseWizard.Text = "数据库目录安全向导(&D)";
            this.C_DataBaseWizard.UseVisualStyleBackColor = true;
            this.C_DataBaseWizard.Click += new System.EventHandler(this.C_DataBaseWizard_Click);
            // 
            // C_OtherWizard
            // 
            this.C_OtherWizard.Location = new System.Drawing.Point(6, 107);
            this.C_OtherWizard.Name = "C_OtherWizard";
            this.C_OtherWizard.Size = new System.Drawing.Size(178, 23);
            this.C_OtherWizard.TabIndex = 2;
            this.C_OtherWizard.Text = "仅用于存储文件的目录导向(&O)";
            this.C_OtherWizard.UseVisualStyleBackColor = true;
            this.C_OtherWizard.Click += new System.EventHandler(this.C_OtherWizard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 120);
            this.label1.TabIndex = 3;
            this.label1.Text = "WEB目录安全导向：这是对整个存有网站数据的目\r\n录或者盘符的设置，而不是单个网站的目录。\r\n!!!设置完以后要单独对网站设置独有的访问权限！\r\n否则网站不能访问" +
                "！\r\n\r\n数据库目录安茜导向：这是对一个存有数据库文件\r\n的目录或者盘符的安全设置\r\n\r\n存储文件的目录导向：这是仅仅对于用于存储文件\r\n的目录或者盘符的设置";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.C_WebWizard);
            this.groupBox1.Controls.Add(this.C_DataBaseWizard);
            this.groupBox1.Controls.Add(this.C_OtherWizard);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 144);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "一键设置目录权限";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(224, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(287, 144);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "说明";
            // 
            // FileSystemACLWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 168);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FileSystemACLWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件系统访问权限 详细设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FileSystemACLWizard_FormClosed);
            this.Load += new System.EventHandler(this.FileSystemACLWizard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button C_WebWizard;
        private System.Windows.Forms.Button C_DataBaseWizard;
        private System.Windows.Forms.Button C_OtherWizard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}