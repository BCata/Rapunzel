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
    public partial class VideoQuiz : Form
    {
        private String audioPath = "audio/";
        private String audioExtension = ".mp3";
        private String imagePath = "images/";
        private String imageExtension = ".png";
        private int quizNr;

        public VideoQuiz(int quizNr)
        {
            this.quizNr = quizNr;
            InitializeComponent();
        }

        private void VideoQuiz_Load(object sender, EventArgs e)
        {
            Image myimage = new Bitmap(imagePath + quizNr + imageExtension);
            this.BackgroundImage = myimage;

            if (quizNr == 1)
            {
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(lets_learn_on_end);
                wplayer.URL = audioPath + "lets_learn" + audioExtension;
                wplayer.controls.play();
            }
            else
            {
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = audioPath + "press_speaker" + audioExtension;
                wplayer.controls.play();
            }

            if (quizNr == 2)
            {
                this.speaker.Location = new System.Drawing.Point(550, 50);
            }
        }
        
        private void speaker_Click(object sender, EventArgs e)
        {
            playWord();
            finishQuiz();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (quizNr == 6)
            {
                Quiz quiz = new Quiz(1, quizNr + 1);
                quiz.Show();
                this.Close();
            }
            else
            {
                PlayStory playStory = new PlayStory(quizNr + 1);
                playStory.Show();
                this.Close();
            }
        }

        private void finishQuiz()
        {
            this.play_button.Visible = true;
        }

        void lets_learn_on_end(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
                wplayer2.URL = audioPath + "press_speaker" + audioExtension;
                wplayer2.controls.play();
            }
        }

        private void playWord()
        {
            WMPLib.WindowsMediaPlayer wplayer1 = new WMPLib.WindowsMediaPlayer();
            wplayer1.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(playInstructions);
            wplayer1.URL = audioPath + quizNr + audioExtension;
            wplayer1.controls.play();
        }

        void playInstructions(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
                wplayer2.URL = audioPath + "arrow_button" + audioExtension;
                wplayer2.controls.play();
            }
        }
    }
}
