using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Silmoon.Media;
using WMPLib;

namespace SST.Controls.Media
{
    public partial class TestControl : MainFormTemplate
    {
        WMPPlayer _player;
        public TestControl()
        {
            InitializeComponent();
        }
        public void StartControl()
        {
            try
            { _player = new WMPPlayer(); }
            catch { _g.ProtectRunAsClass("装载WMP类工厂失败！\r\n在Windows 2008以上的系统可能出现这个错误。"); return; }
            
            _player.OnPlayerStateChange += new WMPPlayerHander(_player_OnWMPPlayerStateChange);
            _player.OnPlayContextChange += new WMPPlayerHander(_player_OnPlayContextChange);
            smTrackBar1.OnPercentageChange += new Silmoon.Windows.Controls.SmTrackBarHander(smTrackBar1_OnPercentageChange);
        }

        void smTrackBar1_OnPercentageChange(double nowValue)
        {
            if (_player.State == PlayerState.Playing || _player.State == PlayerState.Puase)
            {
                _player.CurrentPosition = _player.Duration * smTrackBar1.Value;
            }
        }

        void _player_OnPlayContextChange(object sender, WMPPlayerArgs e)
        {
            smTrackBar1.Value = e.DoublePercentage;
        }
        void _player_OnWMPPlayerStateChange(object sender, WMPPlayerArgs e)
        {
            if (e.State == WMPPlayState.wmppsPlaying)
                OpenDefaultMuisc.Text = "停止音乐播放(&S)";
            else
                OpenDefaultMuisc.Text = "测试音乐播放(&S)";

            _g.StatusLabel.Text = e.State.ToString();
        }

        private void OpenDefaultMuisc_Click(object sender, EventArgs e)
        {
            if (_player == null) return;
            if ((OpenDefaultMuisc.Text == "测试音乐播放(&S)"))
            {
                _player.FilePath = "http://server4.file.silmoon.com/Res/Oh!.mp3";
                ctlPlayTipLabel.Text = "远程文件:少女时代 Oh!.mp3";
                _player.Play();
            }
            else
            {
                ctlPlayTipLabel.Text = "";
                _player.Stop();
            }
        }
    }
}
