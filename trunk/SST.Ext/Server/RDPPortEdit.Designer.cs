namespace SST.Ext.Server
{
    partial class RDPPortEdit
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
            this.RDPPortGroupBox = new System.Windows.Forms.GroupBox();
            this.OpenTS = new System.Windows.Forms.CheckBox();
            this.PortLable = new System.Windows.Forms.Label();
            this.WritePortButton = new System.Windows.Forms.Button();
            this.ReadPortButton = new System.Windows.Forms.Button();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RDPPortGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RDPPortGroupBox
            // 
            this.RDPPortGroupBox.Controls.Add(this.OpenTS);
            this.RDPPortGroupBox.Controls.Add(this.PortLable);
            this.RDPPortGroupBox.Controls.Add(this.WritePortButton);
            this.RDPPortGroupBox.Controls.Add(this.ReadPortButton);
            this.RDPPortGroupBox.Controls.Add(this.PortTextBox);
            this.RDPPortGroupBox.Location = new System.Drawing.Point(12, 12);
            this.RDPPortGroupBox.Name = "RDPPortGroupBox";
            this.RDPPortGroupBox.Size = new System.Drawing.Size(221, 93);
            this.RDPPortGroupBox.TabIndex = 0;
            this.RDPPortGroupBox.TabStop = false;
            this.RDPPortGroupBox.Text = "RDP端口";
            // 
            // OpenTS
            // 
            this.OpenTS.AutoSize = true;
            this.OpenTS.Location = new System.Drawing.Point(15, 66);
            this.OpenTS.Name = "OpenTS";
            this.OpenTS.Size = new System.Drawing.Size(114, 16);
            this.OpenTS.TabIndex = 4;
            this.OpenTS.Text = "开启远程桌面(&O)";
            this.OpenTS.UseVisualStyleBackColor = true;
            this.OpenTS.CheckedChanged += new System.EventHandler(this.OpenTS_CheckedChanged);
            // 
            // PortLable
            // 
            this.PortLable.AutoSize = true;
            this.PortLable.Location = new System.Drawing.Point(13, 17);
            this.PortLable.Name = "PortLable";
            this.PortLable.Size = new System.Drawing.Size(29, 12);
            this.PortLable.TabIndex = 3;
            this.PortLable.Text = "NULL";
            // 
            // WritePortButton
            // 
            this.WritePortButton.Location = new System.Drawing.Point(140, 39);
            this.WritePortButton.Name = "WritePortButton";
            this.WritePortButton.Size = new System.Drawing.Size(75, 23);
            this.WritePortButton.TabIndex = 2;
            this.WritePortButton.Text = "写入(&W)";
            this.WritePortButton.UseVisualStyleBackColor = true;
            this.WritePortButton.Click += new System.EventHandler(this.WritePortButton_Click);
            // 
            // ReadPortButton
            // 
            this.ReadPortButton.Location = new System.Drawing.Point(140, 12);
            this.ReadPortButton.Name = "ReadPortButton";
            this.ReadPortButton.Size = new System.Drawing.Size(75, 23);
            this.ReadPortButton.TabIndex = 1;
            this.ReadPortButton.Text = "读取(&R)";
            this.ReadPortButton.UseVisualStyleBackColor = true;
            this.ReadPortButton.Click += new System.EventHandler(this.ReadPortButton_Click);
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(15, 39);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(119, 21);
            this.PortTextBox.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(239, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 93);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "说明";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "这步是更改服务器远程\r\n桌面的端口，一定要记\r\n住你修改的修改的端口\r\n号，修改完毕使用\r\n\"IP:端口\"远程连接服\r\n务器！";
            // 
            // RDPPortEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 116);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RDPPortGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RDPPortEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RDP默认端口(3389)修改";
            this.Load += new System.EventHandler(this.RDPPortEdit_Load);
            this.RDPPortGroupBox.ResumeLayout(false);
            this.RDPPortGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RDPPortGroupBox;
        private System.Windows.Forms.Label PortLable;
        private System.Windows.Forms.Button WritePortButton;
        private System.Windows.Forms.Button ReadPortButton;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox OpenTS;
    }
}

