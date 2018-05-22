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

            WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
            wplayer.URL = audioPath + quizNr + audioExtension;
            wplayer.controls.play();


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PlayStory playStory = new PlayStory(quizNr + 1);
            playStory.Show();
            this.Close();
        }
    }
}
