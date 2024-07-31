using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dialogResult
{
    public partial class Form1 : Form
    {
        Random rRandom = new Random();
        Random gRandom = new Random();
        Random bRandom = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            changeColorButton.Image = Resource.ButtonHover;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            changeColorButton.Image = Resource1.ButtonRegular;
        }

        private void changeColorButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;

        }
    }
}
