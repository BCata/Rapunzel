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
        private int arrowCounter = 0;

        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer playWordPlayer = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer instrPlayer = new WMPLib.WindowsMediaPlayer();

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
                this.wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(lets_learn_on_end);
                this.wplayer.URL = audioPath + "lets_learn" + audioExtension;
                this.wplayer.controls.play();
            }
            else
            {
                if (quizNr < 5)
                {
                    this.wplayer.URL = audioPath + "press_speaker" + audioExtension;
                    this.wplayer.controls.play();
                }
            }

            if (quizNr == 2 || quizNr == 14)
            {
                this.speaker.Location = new System.Drawing.Point(550, 50);
            }
        }
        
        private void speaker_Click(object sender, EventArgs e)
        {
            this.wplayer.controls.stop();
            this.wplayer2.controls.stop();
            this.instrPlayer.controls.stop();
            this.playWordPlayer.controls.stop();

            playWord();
            finishQuiz();
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            this.playWordPlayer.controls.stop();
            this.instrPlayer.controls.stop();

            if (quizNr == 6)
            {
                Quiz quiz = new Quiz(1, quizNr + 1);
                quiz.Show();
                this.Close();
            }
            else if (quizNr == 11)
            {
                Quiz quiz = new Quiz(4, quizNr + 1);
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
                this.wplayer2.URL = audioPath + "press_speaker" + audioExtension;
                this.wplayer2.controls.play();
            }
        }

        private void playWord()
        {
            this.playWordPlayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(playInstructions);
            this.playWordPlayer.URL = audioPath + quizNr + audioExtension;
            this.playWordPlayer.controls.play();
        }

        void playInstructions(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded && arrowCounter < 1 && quizNr < 5)
            {
                arrowCounter++;
                this.instrPlayer.URL = audioPath + "arrow_button" + audioExtension;
                this.instrPlayer.controls.play();
            }
        }
    }
}
