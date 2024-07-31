using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Location
{
    public partial class Form1 : Form
    {
        Random randomX = new Random();
        Random randomY = new Random();
        

        int MaxX = 300;
        int MaxY = 300;

        Point buttonLocation;
        public Form1()
        {
            InitializeComponent();
        }
        int i = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (i != 5)
            {

                button1.Location = new Point(randomX.Next(MaxX), randomY.Next(MaxY));
                buttonLocation = button1.Location;
                i++;
            }
            else 
            {
            
                
                this.Controls.Remove(button1);  
                button2.Location = new Point(220, 200);
            
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();
            form2.Show();
        }
    }
}
