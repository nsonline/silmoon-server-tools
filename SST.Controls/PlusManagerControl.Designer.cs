namespace SST.Controls
{
    partial class PlusManagerControl
    {
        /// <summary>
        /// ����������������
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// ������������ʹ�õ���Դ��
        /// </summary>
        /// <param name="disposing">���Ӧ�ͷ��й���Դ��Ϊ true������Ϊ false��</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ������������ɵĴ���

        /// <summary>
        /// �����֧������ķ��� - ��Ҫ
        /// ʹ�ô���༭���޸Ĵ˷��������ݡ�
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlPlusListBox = new System.Windows.Forms.ListBox();
            this.ctlRefreshPlusList = new System.Windows.Forms.Button();
            this.ctlStopPlus = new System.Windows.Forms.Button();
            this.ctlConfigPlusButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctlPlusListBox
            // 
            this.ctlPlusListBox.FormattingEnabled = true;
            this.ctlPlusListBox.ItemHeight = 12;
            this.ctlPlusListBox.Location = new System.Drawing.Point(3, 3);
            this.ctlPlusListBox.Name = "ctlPlusListBox";
            this.ctlPlusListBox.Size = new System.Drawing.Size(210, 220);
            this.ctlPlusListBox.TabIndex = 0;
            // 
            // ctlRefreshPlusList
            // 
            this.ctlRefreshPlusList.Location = new System.Drawing.Point(219, 3);
            this.ctlRefreshPlusList.Name = "ctlRefreshPlusList";
            this.ctlRefreshPlusList.Size = new System.Drawing.Size(86, 23);
            this.ctlRefreshPlusList.TabIndex = 1;
            this.ctlRefreshPlusList.Text = "ˢ�²��(&R)";
            this.ctlRefreshPlusList.UseVisualStyleBackColor = true;
            this.ctlRefreshPlusList.Click += new System.EventHandler(this.ctlRefreshPlusList_Click);
            // 
            // ctlStopPlus
            // 
            this.ctlStopPlus.Location = new System.Drawing.Point(219, 60);
            this.ctlStopPlus.Name = "ctlStopPlus";
            this.ctlStopPlus.Size = new System.Drawing.Size(86, 23);
            this.ctlStopPlus.TabIndex = 2;
            this.ctlStopPlus.Text = "ֹͣ���(&T)";
            this.ctlStopPlus.UseVisualStyleBackColor = true;
            this.ctlStopPlus.Click += new System.EventHandler(this.ctlStopPlus_Click);
            // 
            // ctlConfigPlusButton
            // 
            this.ctlConfigPlusButton.Location = new System.Drawing.Point(219, 32);
            this.ctlConfigPlusButton.Name = "ctlConfigPlusButton";
            this.ctlConfigPlusButton.Size = new System.Drawing.Size(86, 23);
            this.ctlConfigPlusButton.TabIndex = 3;
            this.ctlConfigPlusButton.Text = "���ò��(&C)";
            this.ctlConfigPlusButton.UseVisualStyleBackColor = true;
            this.ctlConfigPlusButton.Click += new System.EventHandler(this.ctlConfigPlusButton_Click);
            // 
            // PlusManagerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.Controls.Add(this.ctlConfigPlusButton);
            this.Controls.Add(this.ctlStopPlus);
            this.Controls.Add(this.ctlRefreshPlusList);
            this.Controls.Add(this.ctlPlusListBox);
            this.Name = "PlusManagerControl";
            this.Load += new System.EventHandler(this.PlusManagerControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ctlPlusListBox;
        private System.Windows.Forms.Button ctlRefreshPlusList;
        private System.Windows.Forms.Button ctlStopPlus;
        private System.Windows.Forms.Button ctlConfigPlusButton;
    }
}
