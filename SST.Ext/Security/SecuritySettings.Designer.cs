namespace SST.Ext.Security
{
    partial class SecuritySettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctlSethcSecurityButton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ctlSethcUnsecurityButton = new System.Windows.Forms.Button();
            this.ctlSethcSecurityButton1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ctlSethcSecurityButton2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctlSethcUnsecurityButton);
            this.groupBox1.Controls.Add(this.ctlSethcSecurityButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "琐碎安全设置";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "无法反操作,永久性废除粘滞键";
            // 
            // ctlSethcSecurityButton2
            // 
            this.ctlSethcSecurityButton2.Location = new System.Drawing.Point(6, 49);
            this.ctlSethcSecurityButton2.Name = "ctlSethcSecurityButton2";
            this.ctlSethcSecurityButton2.Size = new System.Drawing.Size(194, 23);
            this.ctlSethcSecurityButton2.TabIndex = 3;
            this.ctlSethcSecurityButton2.Text = "粘滞键安全处理(重度处理)";
            this.ctlSethcSecurityButton2.UseVisualStyleBackColor = true;
            this.ctlSethcSecurityButton2.Click += new System.EventHandler(this.ctlSethcSecurityButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "特殊文件设置已包含此功能。";
            // 
            // ctlSethcUnsecurityButton
            // 
            this.ctlSethcUnsecurityButton.Location = new System.Drawing.Point(146, 20);
            this.ctlSethcUnsecurityButton.Name = "ctlSethcUnsecurityButton";
            this.ctlSethcUnsecurityButton.Size = new System.Drawing.Size(54, 23);
            this.ctlSethcUnsecurityButton.TabIndex = 1;
            this.ctlSethcUnsecurityButton.Text = "<-撤销";
            this.ctlSethcUnsecurityButton.UseVisualStyleBackColor = true;
            this.ctlSethcUnsecurityButton.Click += new System.EventHandler(this.ctlSethcUnsecurityButton_Click);
            // 
            // ctlSethcSecurityButton1
            // 
            this.ctlSethcSecurityButton1.Location = new System.Drawing.Point(6, 20);
            this.ctlSethcSecurityButton1.Name = "ctlSethcSecurityButton1";
            this.ctlSethcSecurityButton1.Size = new System.Drawing.Size(134, 23);
            this.ctlSethcSecurityButton1.TabIndex = 0;
            this.ctlSethcSecurityButton1.Text = "粘滞键安全处理(轻度)";
            this.ctlSethcSecurityButton1.UseVisualStyleBackColor = true;
            this.ctlSethcSecurityButton1.Click += new System.EventHandler(this.ctlSethcSecurityButton_Click);
            // 
            // SecuritySettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 155);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SecuritySettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "服务器高级安全";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ctlSethcUnsecurityButton;
        private System.Windows.Forms.Button ctlSethcSecurityButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ctlSethcSecurityButton2;
    }
}