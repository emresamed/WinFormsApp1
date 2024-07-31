using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string data = notifyIconTextBox.Text;   
            notifyIcon1.BalloonTipTitle = "Composer";
            notifyIcon1.BalloonTipText = data;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(30000);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
