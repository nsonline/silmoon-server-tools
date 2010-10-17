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
            catch { _g.ProtectRunAsClass("װ��WMP�๤��ʧ�ܣ�\r\n��Windows 2008���ϵ�ϵͳ���ܳ����������"); return; }
            
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
                OpenDefaultMuisc.Text = "ֹͣ���ֲ���(&S)";
            else
                OpenDefaultMuisc.Text = "�������ֲ���(&S)";

            _g.StatusLabel.Text = e.State.ToString();
        }

        private void OpenDefaultMuisc_Click(object sender, EventArgs e)
        {
            if (_player == null) return;
            if ((OpenDefaultMuisc.Text == "�������ֲ���(&S)"))
            {
                _player.FilePath = "http://server4.file.silmoon.com/Res/Oh!.mp3";
                ctlPlayTipLabel.Text = "Զ���ļ�:��Ůʱ�� Oh!.mp3";
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
