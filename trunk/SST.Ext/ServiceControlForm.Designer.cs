namespace SST.Ext
{
    partial class ServiceControlForm
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
            this.C_11 = new System.Windows.Forms.Button();
            this.C_12 = new System.Windows.Forms.Button();
            this.C_13 = new System.Windows.Forms.Button();
            this.C_21 = new System.Windows.Forms.Button();
            this.C_22 = new System.Windows.Forms.Button();
            this.C_23 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.C_RunStatus = new System.Windows.Forms.Label();
            this.C_SetStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // C_11
            // 
            this.C_11.Enabled = false;
            this.C_11.Location = new System.Drawing.Point(59, 12);
            this.C_11.Name = "C_11";
            this.C_11.Size = new System.Drawing.Size(75, 23);
            this.C_11.TabIndex = 0;
            this.C_11.Text = "开始(&S)";
            this.C_11.UseVisualStyleBackColor = true;
            this.C_11.Click += new System.EventHandler(this.C_11_Click);
            // 
            // C_12
            // 
            this.C_12.Enabled = false;
            this.C_12.Location = new System.Drawing.Point(140, 12);
            this.C_12.Name = "C_12";
            this.C_12.Size = new System.Drawing.Size(75, 23);
            this.C_12.TabIndex = 1;
            this.C_12.Text = "停止(&T)";
            this.C_12.UseVisualStyleBackColor = true;
            this.C_12.Click += new System.EventHandler(this.C_12_Click);
            // 
            // C_13
            // 
            this.C_13.Enabled = false;
            this.C_13.Location = new System.Drawing.Point(221, 12);
            this.C_13.Name = "C_13";
            this.C_13.Size = new System.Drawing.Size(75, 23);
            this.C_13.TabIndex = 2;
            this.C_13.Text = "重启(&R)";
            this.C_13.UseVisualStyleBackColor = true;
            this.C_13.Click += new System.EventHandler(this.C_13_Click);
            // 
            // C_21
            // 
            this.C_21.Enabled = false;
            this.C_21.Location = new System.Drawing.Point(59, 41);
            this.C_21.Name = "C_21";
            this.C_21.Size = new System.Drawing.Size(75, 23);
            this.C_21.TabIndex = 3;
            this.C_21.Text = "自启动(&A)";
            this.C_21.UseVisualStyleBackColor = true;
            this.C_21.Click += new System.EventHandler(this.C_21_Click);
            // 
            // C_22
            // 
            this.C_22.Enabled = false;
            this.C_22.Location = new System.Drawing.Point(140, 41);
            this.C_22.Name = "C_22";
            this.C_22.Size = new System.Drawing.Size(75, 23);
            this.C_22.TabIndex = 4;
            this.C_22.Text = "手动(&M)";
            this.C_22.UseVisualStyleBackColor = true;
            this.C_22.Click += new System.EventHandler(this.C_22_Click);
            // 
            // C_23
            // 
            this.C_23.Enabled = false;
            this.C_23.Location = new System.Drawing.Point(221, 41);
            this.C_23.Name = "C_23";
            this.C_23.Size = new System.Drawing.Size(75, 23);
            this.C_23.TabIndex = 5;
            this.C_23.Text = "禁用(&D)";
            this.C_23.UseVisualStyleBackColor = true;
            this.C_23.Click += new System.EventHandler(this.C_23_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "控制：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "设置：";
            // 
            // C_RunStatus
            // 
            this.C_RunStatus.AutoSize = true;
            this.C_RunStatus.Location = new System.Drawing.Point(57, 67);
            this.C_RunStatus.Name = "C_RunStatus";
            this.C_RunStatus.Size = new System.Drawing.Size(11, 12);
            this.C_RunStatus.TabIndex = 8;
            this.C_RunStatus.Text = ".";
            // 
            // C_SetStatus
            // 
            this.C_SetStatus.AutoSize = true;
            this.C_SetStatus.Location = new System.Drawing.Point(104, 67);
            this.C_SetStatus.Name = "C_SetStatus";
            this.C_SetStatus.Size = new System.Drawing.Size(11, 12);
            this.C_SetStatus.TabIndex = 9;
            this.C_SetStatus.Text = ".";
            // 
            // ServiceControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 85);
            this.Controls.Add(this.C_SetStatus);
            this.Controls.Add(this.C_RunStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C_23);
            this.Controls.Add(this.C_22);
            this.Controls.Add(this.C_21);
            this.Controls.Add(this.C_13);
            this.Controls.Add(this.C_12);
            this.Controls.Add(this.C_11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ServiceControlForm";
            this.Text = "ServiceControlForm";
            this.Load += new System.EventHandler(this.ServiceControlForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button C_11;
        private System.Windows.Forms.Button C_12;
        private System.Windows.Forms.Button C_13;
        private System.Windows.Forms.Button C_21;
        private System.Windows.Forms.Button C_22;
        private System.Windows.Forms.Button C_23;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label C_RunStatus;
        private System.Windows.Forms.Label C_SetStatus;
    }
}