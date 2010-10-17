using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace SST.Ext.IIS
{
    public class PhpIniEditClass:IDisposable
    {
        GBC _g;
        Process _p;
        public PhpIniEditClass(GBC g)
        {
            try
            {
                _g = g;
                if (MessageBox.Show("确定编辑php.ini文件？", "提问", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Start()
        {
            if (!File.Exists(@"c:\windows\php.ini"))
                MessageBox.Show("没有找到php配置文件，或者php没有安装！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                _p = new Process();
                _p.EnableRaisingEvents = true;
                _p.Exited += new EventHandler(_p_Exited);
                _p.StartInfo.FileName = @"c:\windows\php.ini";
                _p.StartInfo.WorkingDirectory = @"c:\windows\";
                _p.Start();
            }
        }
        void _p_Exited(object sender, EventArgs e)
        {
            try
            {
                _p.Exited -= new EventHandler(_p_Exited);
                File.Copy(@"c:\windows\php.ini", @"c:\php\php.ini", true);
                _g.LoggerObj.WriteLogLine("处理php.ini完毕...");
                if (MessageBox.Show("需要重启IIS才能生效配置\r\n\r\n重启？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _g.ServiceCtrl.OnServiceStateChange += new Silmoon.Service.SmServiceEventHandler(ServiceCtrl_OnServiceStateChange);
                    _g.ServiceCtrl.AsyncService("w3svc", Silmoon.Service.ServiceOptions.Reset);
                }
                Dispose();
            }
            catch (Exception ex) { _g.ProtectRunAsClass(ex.ToString()); }
        }
        void ServiceCtrl_OnServiceStateChange(object sender, Silmoon.Service.SmServiceEventArgs e)
        {
            _g.ServiceCtrl.OnServiceStateChange -= new Silmoon.Service.SmServiceEventHandler(ServiceCtrl_OnServiceStateChange);
            MessageBox.Show("重启已执行！");
        }

        #region IDisposable 成员

        public void Dispose()
        {
            if (_p != null)
            {
                _p.Close();
                _p.Dispose();
            }
        }

        #endregion
    }
}
