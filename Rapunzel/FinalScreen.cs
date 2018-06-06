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
    public partial class FinalScreen : Form
    {
        public FinalScreen()
        {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = new Bitmap("images/congrats.jpg");
        }
    }
}
