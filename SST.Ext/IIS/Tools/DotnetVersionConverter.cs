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
                MessageBox.Show("û���ҵ�IIS������������ݿ��ļ���");
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
                if (MessageBox.Show("�⽫���㱾����������վ.NET�汾���ĳ�" + listBox1.Text + "�����������", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    return;

                string fileContent = File.ReadAllText(@"C:\WINDOWS\system32\inetsrv\MetaBase.xml");
                string selectedVer = listBox1.SelectedItem.ToString();
                foreach (string itemText in listBox1.Items)
                    fileContent = fileContent.Replace(itemText, selectedVer);
                try
                {
                    File.WriteAllText(@"C:\WINDOWS\system32\inetsrv\MetaBase.xml", fileContent);
                    _g.LoggerObj.WriteLogLine("(IIS)�ѽ�����վ��.NET������" + listBox1.Text + "�汾");
                    if (MessageBox.Show("д���óɹ�����������\r\n(�����л᱾������ּ���)", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Text = ".NET�汾���ƹ��� (���Ե�...������)";
                        _g.ServiceCtrl.StopService("iisadmin");
                        _g.ServiceCtrl.StartService("w3svc");
                        this.Text = ".NET�汾���ƹ���";
                    }
                }
                catch
                {
                    if (MessageBox.Show("д����ʧ�ܣ��Ƿ���ֹͣIIS�ٽ���д�����ã�\r\n(�����л᱾������ּ���)", "_que", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Text = ".NET�汾���ƹ��� (���Ե�...������)";
                        _g.ServiceCtrl.StopService("iisadmin");
                        File.WriteAllText(@"C:\WINDOWS\system32\inetsrv\MetaBase.xml", fileContent);
                        _g.LoggerObj.WriteLogLine("(IIS)�ѽ�����վ��.NET������" + listBox1.Text + "�汾");
                        MessageBox.Show("д��ɣ���ʼ��������", "_msg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _g.ServiceCtrl.StartService("w3svc");
                        this.Text = ".NET�汾���ƹ���";
                    }
                }
            }
            catch (Exception ex) { _g.PopErrorMessage(ex.ToString()); }
        }
    }
}