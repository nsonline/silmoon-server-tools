namespace DNSPodClient
{
    partial class RecordForm
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
            this.ctlSubDomainTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctlRecordTypeDropDownList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctlISPDropDownList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ctlValueTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ctlMxLevelUpDown = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ctlTTLUpDown = new System.Windows.Forms.NumericUpDown();
            this.ctlSubmitButton = new System.Windows.Forms.Button();
            this.ctlMainDomainLabel = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ctlMxLevelUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTTLUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ctlSubDomainTextBox
            // 
            this.ctlSubDomainTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlSubDomainTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlSubDomainTextBox.Location = new System.Drawing.Point(96, 12);
            this.ctlSubDomainTextBox.Name = "ctlSubDomainTextBox";
            this.ctlSubDomainTextBox.Size = new System.Drawing.Size(132, 30);
            this.ctlSubDomainTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "域名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "记录类型";
            // 
            // ctlRecordTypeDropDownList
            // 
            this.ctlRecordTypeDropDownList.DisplayMember = "2";
            this.ctlRecordTypeDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlRecordTypeDropDownList.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlRecordTypeDropDownList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlRecordTypeDropDownList.FormattingEnabled = true;
            this.ctlRecordTypeDropDownList.Items.AddRange(new object[] {
            "1,A(IP指向)",
            "2,CNAME(别名记录)",
            "3,MX(邮件交换记录)",
            "4,URL(URL转向)",
            "5,NS(域名服务器)",
            "6,TXT(文本记录)",
            "7,AAAA(IPv6指向)"});
            this.ctlRecordTypeDropDownList.Location = new System.Drawing.Point(96, 48);
            this.ctlRecordTypeDropDownList.Name = "ctlRecordTypeDropDownList";
            this.ctlRecordTypeDropDownList.Size = new System.Drawing.Size(366, 32);
            this.ctlRecordTypeDropDownList.TabIndex = 4;
            this.ctlRecordTypeDropDownList.SelectedIndexChanged += new System.EventHandler(this.ctlRecordTypeDropDownList_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "线路类型";
            // 
            // ctlISPDropDownList
            // 
            this.ctlISPDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlISPDropDownList.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlISPDropDownList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlISPDropDownList.FormattingEnabled = true;
            this.ctlISPDropDownList.Items.AddRange(new object[] {
            "1,None(通用)",
            "2,CTC(电信)",
            "3,CNC(网通,联通)",
            "4,EDU(教育网)"});
            this.ctlISPDropDownList.Location = new System.Drawing.Point(96, 86);
            this.ctlISPDropDownList.Name = "ctlISPDropDownList";
            this.ctlISPDropDownList.Size = new System.Drawing.Size(366, 32);
            this.ctlISPDropDownList.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "记录值";
            // 
            // ctlValueTextBox
            // 
            this.ctlValueTextBox.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlValueTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlValueTextBox.Location = new System.Drawing.Point(96, 124);
            this.ctlValueTextBox.Name = "ctlValueTextBox";
            this.ctlValueTextBox.Size = new System.Drawing.Size(366, 30);
            this.ctlValueTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "MX优先级";
            // 
            // ctlMxLevelUpDown
            // 
            this.ctlMxLevelUpDown.Enabled = false;
            this.ctlMxLevelUpDown.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlMxLevelUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlMxLevelUpDown.Location = new System.Drawing.Point(96, 160);
            this.ctlMxLevelUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ctlMxLevelUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctlMxLevelUpDown.Name = "ctlMxLevelUpDown";
            this.ctlMxLevelUpDown.Size = new System.Drawing.Size(366, 30);
            this.ctlMxLevelUpDown.TabIndex = 10;
            this.ctlMxLevelUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "TTL";
            // 
            // ctlTTLUpDown
            // 
            this.ctlTTLUpDown.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlTTLUpDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlTTLUpDown.Increment = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.ctlTTLUpDown.Location = new System.Drawing.Point(96, 200);
            this.ctlTTLUpDown.Maximum = new decimal(new int[] {
            43200,
            0,
            0,
            0});
            this.ctlTTLUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctlTTLUpDown.Name = "ctlTTLUpDown";
            this.ctlTTLUpDown.Size = new System.Drawing.Size(366, 30);
            this.ctlTTLUpDown.TabIndex = 12;
            this.ctlTTLUpDown.Value = new decimal(new int[] {
            3600,
            0,
            0,
            0});
            // 
            // ctlSubmitButton
            // 
            this.ctlSubmitButton.Enabled = false;
            this.ctlSubmitButton.Location = new System.Drawing.Point(326, 236);
            this.ctlSubmitButton.Name = "ctlSubmitButton";
            this.ctlSubmitButton.Size = new System.Drawing.Size(136, 34);
            this.ctlSubmitButton.TabIndex = 13;
            this.ctlSubmitButton.Text = "提交";
            this.ctlSubmitButton.UseVisualStyleBackColor = true;
            this.ctlSubmitButton.Click += new System.EventHandler(this.ctlSubmitButton_Click);
            // 
            // ctlMainDomainLabel
            // 
            this.ctlMainDomainLabel.BackColor = System.Drawing.SystemColors.Control;
            this.ctlMainDomainLabel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ctlMainDomainLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ctlMainDomainLabel.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.ctlMainDomainLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(130)))), ((int)(((byte)(237)))));
            this.ctlMainDomainLabel.FormattingEnabled = true;
            this.ctlMainDomainLabel.Location = new System.Drawing.Point(234, 10);
            this.ctlMainDomainLabel.Name = "ctlMainDomainLabel";
            this.ctlMainDomainLabel.Size = new System.Drawing.Size(228, 32);
            this.ctlMainDomainLabel.TabIndex = 14;
            // 
            // RecordForm
            // 
            this.AcceptButton = this.ctlSubmitButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 286);
            this.Controls.Add(this.ctlMainDomainLabel);
            this.Controls.Add(this.ctlSubmitButton);
            this.Controls.Add(this.ctlTTLUpDown);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ctlMxLevelUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ctlValueTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ctlISPDropDownList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ctlRecordTypeDropDownList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ctlSubDomainTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RecordForm";
            this.Shown += new System.EventHandler(this.RecordForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ctlMxLevelUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctlTTLUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ctlSubDomainTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ctlRecordTypeDropDownList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ctlISPDropDownList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctlValueTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ctlMxLevelUpDown;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown ctlTTLUpDown;
        private System.Windows.Forms.Button ctlSubmitButton;
        private System.Windows.Forms.ComboBox ctlMainDomainLabel;
    }
}