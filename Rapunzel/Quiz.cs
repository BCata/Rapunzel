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

        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer selectImagePlayer = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
        private WMPLib.WindowsMediaPlayer speakerPlayer = new WMPLib.WindowsMediaPlayer();

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
                this.wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(rapunzel_again_on_end);
                this.wplayer.URL = audioPath + "rapunzel_again" + audioExtension;
                this.wplayer.controls.play();
            }
        }

        void rapunzel_again_on_end(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                this.selectImagePlayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(playInstructions);
                this.selectImagePlayer.URL = audioPath + "press_speaker" + audioExtension;
                this.selectImagePlayer.controls.play();
            }
        }

        void playInstructions(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                this.wplayer2.URL = audioPath + "select_image" + audioExtension;
                this.wplayer2.controls.play();
            }
        }

        private void speaker_Click(object sender, EventArgs e)
        {
            this.wplayer.controls.stop();
            this.selectImagePlayer.controls.stop();
            this.wplayer2.controls.stop();

            this.speakerPlayer.URL = audioPath + "quiz" + quizNr + audioExtension;
            this.speakerPlayer.controls.play();
        }

        private void answer_Click(object sender, EventArgs e)
        {
            this.wplayer.controls.stop();
            this.selectImagePlayer.controls.stop();
            this.wplayer2.controls.stop();
            this.speakerPlayer.controls.stop();

            WMPLib.WindowsMediaPlayer answerPlayer = new WMPLib.WindowsMediaPlayer();
            if (((Button)sender).Name.Equals("answer" + rightAnswer))
            {
                answerPlayer.URL = audioPath + "good_job" + audioExtension;
                answerPlayer.controls.play();
                finishQuiz();
            }
            else
            {
                answerPlayer.URL = audioPath + "wrong" + audioExtension;
                answerPlayer.controls.play();
            }
        }

        private void play_button_Click(object sender, EventArgs e)
        {
            this.wplayer.controls.stop();
            this.selectImagePlayer.controls.stop();
            this.wplayer2.controls.stop();
            this.speakerPlayer.controls.stop();

            if (quizNr == 2)
            {
                QuizWithoutAnswers quiz = new QuizWithoutAnswers(this.quizNr + 1, nextVideo);
                quiz.Show();
                this.Close();
            }
            else if (quizNr == 6)
            {
                PlayStory play = new PlayStory(nextVideo);
                play.Show();
                this.Close();
            }
            else if (quizNr == 8)
            {
                PlayStory play = new PlayStory(nextVideo);
                play.Show();
                this.Close();
            }
            else
            {
                Quiz quiz = new Quiz(this.quizNr + 1, nextVideo);
                quiz.Show();
                this.Close();
            }
        }

        private void finishQuiz()
        {
            this.play_button.Visible = true;
        }
    }
}
