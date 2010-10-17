using System.Windows.Forms;
namespace SST.Ext.Tools
{
    public partial class FileMon : Form
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
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.复制路径FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制行LToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.VisSysFileCheckBox = new System.Windows.Forms.CheckBox();
            this.FormTopCheck = new System.Windows.Forms.CheckBox();
            this.AutoRollCheckBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(627, 412);
            this.listBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.复制路径FToolStripMenuItem,
            this.复制行LToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(161, 48);
            // 
            // 复制路径FToolStripMenuItem
            // 
            this.复制路径FToolStripMenuItem.Name = "复制路径FToolStripMenuItem";
            this.复制路径FToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.复制路径FToolStripMenuItem.Text = "复制选择路径(&F)";
            this.复制路径FToolStripMenuItem.Click += new System.EventHandler(this.复制路径FToolStripMenuItem_Click);
            // 
            // 复制行LToolStripMenuItem
            // 
            this.复制行LToolStripMenuItem.Name = "复制行LToolStripMenuItem";
            this.复制行LToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.复制行LToolStripMenuItem.Text = "复制行(&L)";
            this.复制行LToolStripMenuItem.Click += new System.EventHandler(this.复制行LToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始(&S)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VisSysFileCheckBox
            // 
            this.VisSysFileCheckBox.AutoSize = true;
            this.VisSysFileCheckBox.Location = new System.Drawing.Point(179, 7);
            this.VisSysFileCheckBox.Name = "VisSysFileCheckBox";
            this.VisSysFileCheckBox.Size = new System.Drawing.Size(96, 16);
            this.VisSysFileCheckBox.TabIndex = 2;
            this.VisSysFileCheckBox.Text = "显示系统文件";
            this.VisSysFileCheckBox.UseVisualStyleBackColor = true;
            // 
            // FormTopCheck
            // 
            this.FormTopCheck.AutoSize = true;
            this.FormTopCheck.Location = new System.Drawing.Point(95, 7);
            this.FormTopCheck.Name = "FormTopCheck";
            this.FormTopCheck.Size = new System.Drawing.Size(72, 16);
            this.FormTopCheck.TabIndex = 3;
            this.FormTopCheck.Text = "窗口顶置";
            this.FormTopCheck.UseVisualStyleBackColor = true;
            this.FormTopCheck.CheckedChanged += new System.EventHandler(this.FormTopCheck_CheckedChanged);
            // 
            // AutoRollCheckBox
            // 
            this.AutoRollCheckBox.AutoSize = true;
            this.AutoRollCheckBox.Checked = true;
            this.AutoRollCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.AutoRollCheckBox.Location = new System.Drawing.Point(6, 7);
            this.AutoRollCheckBox.Name = "AutoRollCheckBox";
            this.AutoRollCheckBox.Size = new System.Drawing.Size(72, 16);
            this.AutoRollCheckBox.TabIndex = 5;
            this.AutoRollCheckBox.Text = "自动滚动";
            this.AutoRollCheckBox.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.AutoRollCheckBox);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.FormTopCheck);
            this.panel1.Controls.Add(this.VisSysFileCheckBox);
            this.panel1.Location = new System.Drawing.Point(259, 418);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 29);
            this.panel1.TabIndex = 6;
            // 
            // FileMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 454);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Name = "FileMon";
            this.Text = "文件事件监控";
            this.Resize += new System.EventHandler(this.FileMon_Resize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SmFileMon_FormClosing);
            this.Load += new System.EventHandler(this.FileMon_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox VisSysFileCheckBox;
        private System.Windows.Forms.CheckBox FormTopCheck;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem 复制路径FToolStripMenuItem;
        private CheckBox AutoRollCheckBox;
        private ToolStripMenuItem 复制行LToolStripMenuItem;
        private Panel panel1;
    }
}