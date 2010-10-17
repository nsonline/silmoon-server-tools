using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;

namespace SST.Ext.IIS.Tools
{
    public partial class DotnetVersionConverter : Form
    {
        GBC _g = new GBC();
        public DotnetVersionConverter(GBC g)
        {
            if (!File.Exists(@"C:\WINDOWS\system32\inetsrv\MetaBase.xml"))
            {
                MessageBox.Show("没有找到IIS服务的配置数据库文件。");
                Close();
                return;
            }
            _g = g;
            InitializeComponent();
            Icon = SST.Resource.Resource.SSTIco1;
            Show();
        }

        private void DotnetVersionConverter_Load(object sender, EventArgs e)
        {
            string[] dnetDirs = Directory.GetDirectories(@"C:\WINDOWS\Microsoft.NET\Framework\");
            foreach (string dir in dnetDirs)
            {
                if (Regex.Match(dir.ToLower(), "v\\d.").Success)
                    listBox1.Items.Add(Path.GetFileName(dir));
            }
        }

        private void ctlApplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("这将会你本机的所有网站.NET版本更改成" + listBox1.Text + "，你想继续吗？", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                string fileContent = File.ReadAllText(@"C:\WINDOWS\system32\inetsrv\MetaBase.xml");
                string selectedVer = listBox1.SelectedItem.ToString();
                foreach (string itemText in listBox1.Items)
                    fileContent = fileContent.Replace(itemText, selectedVer);
                try
                {
                    File.WriteAllText(@"C:\WINDOWS\system32\inetsrv\MetaBase.xml", fileContent);
                    _g.LoggerObj.WriteLogLine("(IIS)已将所有站点.NET更换成" + listBox1.Text + "版本");
                    if (MessageBox.Show("写配置成功，重启服务？\r\n(操作中会本程序出现假死)", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Text = ".NET版本控制工具 (请稍等...工作中)";
                        _g.ServiceCtrl.StopService("iisadmin");
                        _g.ServiceCtrl.StartService("w3svc");
                        this.Text = ".NET版本控制工具";
                    }
                }
                catch
                {
                    if (MessageBox.Show("写配置失败，是否尝试停止IIS再进行写入配置？\r\n(操作中会本程序出现假死)", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Text = ".NET版本控制工具 (请稍等...工作中)";
                        _g.ServiceCtrl.StopService("iisadmin");
                        File.WriteAllText(@"C:\WINDOWS\system32\inetsrv\MetaBase.xml", fileContent);
                        _g.LoggerObj.WriteLogLine("(IIS)已将所有站点.NET更换成" + listBox1.Text + "版本");
                        MessageBox.Show("写完成，开始启动服务！", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _g.ServiceCtrl.StartService("w3svc");
                        this.Text = ".NET版本控制工具";
                    }
                }
            }
            catch (Exception ex) { _g.PopErrorMessage(ex.ToString()); }
        }
    }
}