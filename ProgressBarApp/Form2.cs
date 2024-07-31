using Microsoft.Web.WebView2.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Youtube form3 = new Youtube();  
            this.Dispose();
            form3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Google google = new Google();

            this.Dispose();
            google.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Twitter twitter = new Twitter();
            this.Dispose();
            twitter.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wikipedia wikipedia = new Wikipedia();
            this.Dispose();
            wikipedia.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Github github = new Github();
            this.Dispose();
            github.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LinkedIn linkedin = new LinkedIn();
            this.Dispose();
            linkedin.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
