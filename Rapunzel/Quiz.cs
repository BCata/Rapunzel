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
    public partial class Quiz : Form
    {
        private String audioPath = "audio/";
        private String audioExtension = ".mp3";
        private String imagesPath = "images/";
        private int quizNr;
        private int nextVideo;
        private int rightAnswer;

        public Quiz(int quizNr, int nextVideo)
        {
            this.quizNr = quizNr;
            this.nextVideo = nextVideo;
            this.rightAnswer = (quizNr % 3) + 1;
            InitializeComponent();
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap(imagesPath + "quiz_background.jpg");
            this.answer1.BackgroundImage = new Bitmap(imagesPath + "answers/quiz" + quizNr + "a1.jpg");
            this.answer2.BackgroundImage = new Bitmap(imagesPath + "answers/quiz" + quizNr + "a2.jpg");
            this.answer3.BackgroundImage = new Bitmap(imagesPath + "answers/quiz" + quizNr + "a3.jpg");

            if (quizNr == 1)
            {
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(rapunzel_again_on_end);
                wplayer.URL = audioPath + "rapunzel_again" + audioExtension;
                wplayer.controls.play();
            }
        }

        void rapunzel_again_on_end(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
                wplayer.URL = audioPath + "select_image" + audioExtension;
                wplayer.controls.play();
            }
        }

        private void speaker_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = audioPath + "quiz" + quizNr + audioExtension;
            wplayer.controls.play();
        }

        private void answer_Click(object sender, EventArgs e)
        {
            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            if (((Button)sender).Name.Equals("answer" + rightAnswer))
            {
                wplayer.URL = audioPath + "good_job" + audioExtension;
                wplayer.controls.play();
                finishQuiz();
            }
            else
            {
                wplayer.URL = audioPath + "wrong" + audioExtension;
                wplayer.controls.play();
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz(this.quizNr + 1, nextVideo);
            quiz.Show();
            this.Close();
        }

        private void finishQuiz()
        {
            this.play_button.Visible = true;
        }
    }
}
