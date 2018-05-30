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
    public partial class QuizWithoutAnswers : Form
    {
        private String audioPath = "audio/";
        private String audioExtension = ".mp3";
        private String imagesPath = "images/";
        private int quizNr;
        private int nextVideo;

        public QuizWithoutAnswers(int quizNr, int nextVideo)
        {
            this.quizNr = quizNr;
            this.nextVideo = nextVideo;
            InitializeComponent();
        }

        private void QuizWithoutAnswers_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(imagesPath + "quiz_background.jpg");
            this.center_image.BackgroundImage = new Bitmap(imagesPath + "answers/quiz" + quizNr + ".jpg");
        }

        private void speaker_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(audio_end);
            wplayer.URL = audioPath + "quiz" + quizNr + audioExtension;
            wplayer.controls.play();
        }

        void audio_end(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                this.play_button.Visible = true;
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            if (quizNr == 3)
            {
                PlayStory playStory = new PlayStory(nextVideo);
                playStory.Show();
                this.Close();
            }
            else
            {
                QuizWithoutAnswers quiz = new QuizWithoutAnswers(this.quizNr + 1, nextVideo);
                quiz.Show();
                this.Close();
            }
        }
    }
}
