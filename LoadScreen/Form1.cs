﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoadScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {

            timer1.Start();
            
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (i != 100)
            {

                i++;

            }
            else 
            {
                Form2 form2 = new Form2();

                form2.Show();

                this.Hide();

                timer1.Stop();
            
            }

        }
    }
}
