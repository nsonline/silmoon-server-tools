namespace SST.Utility.WindowsFirewall
{
    partial class WindowsFirewallEditPortForm
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
            this.cport = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cprotocol = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ctitle = new System.Windows.Forms.TextBox();
            this.cenable = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ciplist = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.badd = new System.Windows.Forms.Button();
            this.bpat = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "端口：";
            // 
            // cport
            // 
            this.cport.Location = new System.Drawing.Point(82, 12);
            this.cport.Name = "cport";
            this.cport.Size = new System.Drawing.Size(140, 21);
            this.cport.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "协议：";
            // 
            // cprotocol
            // 
            this.cprotocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cprotocol.FormattingEnabled = true;
            this.cprotocol.Items.AddRange(new object[] {
            "TCP",
            "UDP"});
            this.cprotocol.Location = new System.Drawing.Point(82, 39);
            this.cprotocol.Name = "cprotocol";
            this.cprotocol.Size = new System.Drawing.Size(140, 20);
            this.cprotocol.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "启用：";
            // 
            // ctitle
            // 
            this.ctitle.Location = new System.Drawing.Point(82, 191);
            this.ctitle.Name = "ctitle";
            this.ctitle.Size = new System.Drawing.Size(138, 21);
            this.ctitle.TabIndex = 7;
            // 
            // cenable
            // 
            this.cenable.AutoSize = true;
            this.cenable.Location = new System.Drawing.Point(82, 67);
            this.cenable.Name = "cenable";
            this.cenable.Size = new System.Drawing.Size(60, 16);
            this.cenable.TabIndex = 3;
            this.cenable.Text = "启用？";
            this.cenable.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "IP范围：";
            // 
            // ciplist
            // 
            this.ciplist.FormattingEnabled = true;
            this.ciplist.ItemHeight = 12;
            this.ciplist.Location = new System.Drawing.Point(82, 92);
            this.ciplist.Name = "ciplist";
            this.ciplist.Size = new System.Drawing.Size(219, 64);
            this.ciplist.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 9;
            this.label5.Text = "名称备注：";
            // 
            // badd
            // 
            this.badd.Location = new System.Drawing.Point(82, 162);
            this.badd.Name = "badd";
            this.badd.Size = new System.Drawing.Size(27, 23);
            this.badd.TabIndex = 5;
            this.badd.Text = "+";
            this.badd.UseVisualStyleBackColor = true;
            this.badd.Click += new System.EventHandler(this.badd_Click);
            // 
            // bpat
            // 
            this.bpat.Location = new System.Drawing.Point(115, 162);
            this.bpat.Name = "bpat";
            this.bpat.Size = new System.Drawing.Size(27, 23);
            this.bpat.TabIndex = 6;
            this.bpat.Text = "-";
            this.bpat.UseVisualStyleBackColor = true;
            this.bpat.Click += new System.EventHandler(this.bpat_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(239, 221);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "提交(&A)";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(130, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "x";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // WindowsFirewallEditPortForm
            // 
            this.AcceptButton = this.Submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(326, 257);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.bpat);
            this.Controls.Add(this.badd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ciplist);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cenable);
            this.Controls.Add(this.ctitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cprotocol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WindowsFirewallEditPortForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WindowsFirewallEditForm";
            this.Load += new System.EventHandler(this.WindowsFirewallEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cprotocol;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctitle;
        private System.Windows.Forms.CheckBox cenable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox ciplist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button badd;
        private System.Windows.Forms.Button bpat;
        internal System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
    }
}