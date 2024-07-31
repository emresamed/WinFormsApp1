using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool isGasOpen = false; 
        private void brakePanel_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = false;
        }

        private void gasPanel_MouseEnter(object sender, EventArgs e)
        {
            isGasOpen = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGasOpen) {
                Car.Location = new Point(Car.Location.X, Car.Location.Y - 3);
            } 
        }
    }
}
