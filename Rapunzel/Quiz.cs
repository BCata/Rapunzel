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
        private int quizNr;
        private int nextVideo;

        public Quiz(int quizNr, int nextVideo)
        {
            this.quizNr = quizNr;
            this.nextVideo = nextVideo;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new System.Drawing.Bitmap("images/quiz_background.jpg");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
