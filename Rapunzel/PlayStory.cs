using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapunzel
{
    public partial class PlayStory : Form
    {
        private String videoPath = "video/";
        private String videoExtension = ".mp4";
        private int videoNr;

        public PlayStory(int videoNr)
        {
            this.videoNr = videoNr;
            InitializeComponent();
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            play_the_story(videoNr);
        }

        private void play_the_story(int videoNr)
        {
            this.axWindowsMediaPlayer1.URL = videoPath + videoNr + videoExtension;
            this.axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (e.newState == 8)
            {
                if (this.videoNr == 11)
                {
                    PlayStory videoQuiz = new PlayStory(12);
                    videoQuiz.Show();
                    this.Close();
                }
                else
                {
                    VideoQuiz videoQuiz = new VideoQuiz(this.videoNr);
                    videoQuiz.Show();
                    this.Close();
                }
            }
        }

        private void PlayStory_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }
    }
}
