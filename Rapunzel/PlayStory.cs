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
        private String imagesPath = "images/";
        private String videoExtension = ".mp4";
        private int videoNr;
        private int state;

        public PlayStory(int videoNr)
        {
            this.videoNr = videoNr;
            InitializeComponent();
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(axWindowsMediaPlayer1_PlayStateChange);
            play_the_story(videoNr);

            pictureBoxPlayPause.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPlayPause.BackColor = Color.Transparent;
            pictureBoxPlayPause.Image = new Bitmap("images/buttons/pause_btn.png");
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
                if (this.videoNr == 12)
                {
                    PlayStory videoQuiz = new PlayStory(13);
                    videoQuiz.Show();
                    this.Close();
                }
                else if (this.videoNr == 16)
                {
                    Quiz quiz = new Quiz(7, 17);
                    quiz.Show();
                    this.Close();
                }
                else if (this.videoNr == 17)
                {
                    FinalScreen final = new FinalScreen();
                    final.Show();
                    this.Close();
                }
                else
                {
                    VideoQuiz videoQuiz = new VideoQuiz(this.videoNr);
                    videoQuiz.Show();
                    this.Close();
                }
            } else if (e.newState == 2)
            {
                this.state = 2;
            }
            else if (e.newState == 3)
            {
                this.state = 3;
            }
        }

        private void PlayStory_Load(object sender, EventArgs e)
        {

        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBoxPlayPause_Click(object sender, EventArgs e) {
            if(this.state == 2) {
                this.axWindowsMediaPlayer1.Ctlcontrols.play();
                pictureBoxPlayPause.Image = new Bitmap("images/buttons/pause_btn.png");
            } else if(this.state == 3) {
                this.axWindowsMediaPlayer1.Ctlcontrols.pause();
                pictureBoxPlayPause.Image = new Bitmap("images/buttons/play_btn.png");
            }
        }
    }
}
