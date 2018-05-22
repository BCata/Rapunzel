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
        private int quizNr;

        public VideoQuiz(int quizNr)
        {
            this.quizNr = quizNr;
            InitializeComponent();
        }

        private void VideoQuiz_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PlayStory playStory = new PlayStory(quizNr + 1);
            playStory.Show();
            this.Close();
        }
    }
}
