namespace SST.Plus
{
    partial class NetworkTelnetForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctlListenPort = new System.Windows.Forms.Label();
            this.ctlVersionLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ctlConfirmConfig = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlPortTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "协议版本：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "监听端口：";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctlListenPort);
            this.groupBox1.Controls.Add(this.ctlVersionLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(156, 68);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "状态";
            // 
            // ctlListenPort
            // 
            this.ctlListenPort.AutoSize = true;
            this.ctlListenPort.Location = new System.Drawing.Point(68, 38);
            this.ctlListenPort.Name = "ctlListenPort";
            this.ctlListenPort.Size = new System.Drawing.Size(41, 12);
            this.ctlListenPort.TabIndex = 3;
            this.ctlListenPort.Text = "label5";
            // 
            // ctlVersionLabel
            // 
            this.ctlVersionLabel.AutoSize = true;
            this.ctlVersionLabel.Location = new System.Drawing.Point(68, 17);
            this.ctlVersionLabel.Name = "ctlVersionLabel";
            this.ctlVersionLabel.Size = new System.Drawing.Size(41, 12);
            this.ctlVersionLabel.TabIndex = 2;
            this.ctlVersionLabel.Text = "label4";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ctlConfirmConfig);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.ctlPortTextBox);
            this.groupBox2.Location = new System.Drawing.Point(174, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 68);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "配置";
            // 
            // ctlConfirmConfig
            // 
            this.ctlConfirmConfig.Location = new System.Drawing.Point(119, 38);
            this.ctlConfirmConfig.Name = "ctlConfirmConfig";
            this.ctlConfirmConfig.Size = new System.Drawing.Size(75, 23);
            this.ctlConfirmConfig.TabIndex = 2;
            this.ctlConfirmConfig.Text = "应用(&A)";
            this.ctlConfirmConfig.UseVisualStyleBackColor = true;
            this.ctlConfirmConfig.Click += new System.EventHandler(this.ctlConfirmConfig_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "监听端口：";
            // 
            // ctlPortTextBox
            // 
            this.ctlPortTextBox.Location = new System.Drawing.Point(77, 14);
            this.ctlPortTextBox.Name = "ctlPortTextBox";
            this.ctlPortTextBox.Size = new System.Drawing.Size(117, 21);
            this.ctlPortTextBox.TabIndex = 0;
            // 
            // NetworkTelnetForm
            // 
            this.AcceptButton = this.ctlConfirmConfig;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 96);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NetworkTelnetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetworkTelnetForm";
            this.Load += new System.EventHandler(this.NetworkTelnetForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ctlListenPort;
        private System.Windows.Forms.Label ctlVersionLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ctlConfirmConfig;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctlPortTextBox;
    }
}