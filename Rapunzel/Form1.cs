using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rapunzel {
    public partial class Form1 : Form
    {

        private String audioPath = "audio/";
        private String audioExtension = ".mp3";
        private WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.wplayer.controls.stop();

            PlayStory playStory = new PlayStory(1);
            playStory.Show();
            //VideoQuiz videoQuiz = new VideoQuiz(1);
            //videoQuiz.Show();
            //Quiz quiz = new Quiz(1, 7);
            //quiz.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.wplayer.controls.stop();

            PlayStory playStory = new PlayStory(7);
            playStory.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.wplayer.controls.stop();

            PlayStory playStory = new PlayStory(13);
            playStory.Show();
        }

        private void buttonTestKnowledge_Click(object sender, EventArgs e) {
            this.wplayer.controls.stop();

            VideoQuiz videoQuiz = new VideoQuiz(1, true);
            videoQuiz.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new System.Drawing.Bitmap("images/main_menu_background.jpg");

            wplayer.PlayStateChange += new WMPLib._WMPOCXEvents_PlayStateChangeEventHandler(wplayer_PlayStateChange);
            wplayer.URL = audioPath + "listen_carefully" + audioExtension;
            wplayer.controls.play();
        }

        void wplayer_PlayStateChange(int NewState)
        {
            if (NewState == (int)WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                WMPLib.WindowsMediaPlayer wplayer2 = new WMPLib.WindowsMediaPlayer();
                wplayer2.URL = audioPath + "press_play" + audioExtension;
                wplayer2.controls.play();
            }
        }
    }
}
