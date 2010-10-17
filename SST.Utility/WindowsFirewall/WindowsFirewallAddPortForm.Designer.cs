namespace SST.Utility.WindowsFirewall
{
    partial class WindowsFirewallAddPortForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ziptb = new System.Windows.Forms.TextBox();
            this.zipbt = new System.Windows.Forms.Button();
            this.zsubnetbt = new System.Windows.Forms.Button();
            this.zsubnettb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.zsubnetmask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "确认(&A)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "所有IP";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 25);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "指定IP";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 47);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(71, 16);
            this.radioButton3.TabIndex = 3;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "指定子网";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 69);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(71, 16);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "本地子网";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton4);
            this.panel1.Controls.Add(this.radioButton3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(76, 91);
            this.panel1.TabIndex = 6;
            // 
            // ziptb
            // 
            this.ziptb.Location = new System.Drawing.Point(94, 36);
            this.ziptb.Name = "ziptb";
            this.ziptb.Size = new System.Drawing.Size(140, 21);
            this.ziptb.TabIndex = 7;
            this.ziptb.Visible = false;
            // 
            // zipbt
            // 
            this.zipbt.Location = new System.Drawing.Point(240, 34);
            this.zipbt.Name = "zipbt";
            this.zipbt.Size = new System.Drawing.Size(49, 23);
            this.zipbt.TabIndex = 8;
            this.zipbt.Text = "OK";
            this.zipbt.UseVisualStyleBackColor = true;
            this.zipbt.Visible = false;
            this.zipbt.Click += new System.EventHandler(this.zipbt_Click);
            // 
            // zsubnetbt
            // 
            this.zsubnetbt.Location = new System.Drawing.Point(240, 56);
            this.zsubnetbt.Name = "zsubnetbt";
            this.zsubnetbt.Size = new System.Drawing.Size(49, 23);
            this.zsubnetbt.TabIndex = 9;
            this.zsubnetbt.Text = "OK";
            this.zsubnetbt.UseVisualStyleBackColor = true;
            this.zsubnetbt.Visible = false;
            this.zsubnetbt.Click += new System.EventHandler(this.zsubnetbt_Click);
            // 
            // zsubnettb
            // 
            this.zsubnettb.Location = new System.Drawing.Point(94, 58);
            this.zsubnettb.Name = "zsubnettb";
            this.zsubnettb.Size = new System.Drawing.Size(104, 21);
            this.zsubnettb.TabIndex = 10;
            this.zsubnettb.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "选择此项会删除目前列表里面所有的规则。";
            this.label2.Visible = false;
            // 
            // zsubnetmask
            // 
            this.zsubnetmask.Location = new System.Drawing.Point(199, 58);
            this.zsubnetmask.Name = "zsubnetmask";
            this.zsubnetmask.Size = new System.Drawing.Size(35, 21);
            this.zsubnetmask.TabIndex = 12;
            this.zsubnetmask.Visible = false;
            this.zsubnetmask.Enter += new System.EventHandler(this.zsubnetmask_Enter);
            this.zsubnetmask.Leave += new System.EventHandler(this.zsubnetmask_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(224, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 14;
            this.label4.Text = "子网位数";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "选择此项会删除目前列表里面所有的规则。";
            this.label3.Visible = false;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(142, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "x";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // WindowsFirewallAddPortForm
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(350, 138);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.zsubnetmask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zsubnettb);
            this.Controls.Add(this.zsubnetbt);
            this.Controls.Add(this.zipbt);
            this.Controls.Add(this.ziptb);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowsFirewallAddPortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加规则";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ziptb;
        private System.Windows.Forms.Button zipbt;
        private System.Windows.Forms.Button zsubnetbt;
        private System.Windows.Forms.TextBox zsubnettb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox zsubnetmask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}