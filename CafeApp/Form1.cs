using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeApp
{
    public partial class Form1 : Form
    {
        /* Money */
        int money = 1000;
        /* Food Prices */
        int cheese = 100;
        int hamburger = 120;
        int hotdog = 60;
        int pancake = 70;
        int pizza = 220;
        int cupcake = 50;

        /* Total Price */
        int totalPrice = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            moneyLabel.Text = money.ToString()+"TL"; 

        }

        private void CheesePictureBox_Click(object sender, EventArgs e)
        {
            totalPrice = +cheese;
            cartListBox.Items.Add("Cheese");
        }

        private void HamburgerPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += hamburger;
            cartListBox.Items.Add("Hamburger");
        }

        private void HotDogPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += hotdog;
            cartListBox.Items.Add("Hot Dog");

        }

        private void PancakePictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += pancake;
            cartListBox.Items.Add("Pancake");
        }

        private void PizzaPictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += pizza;
            cartListBox.Items.Add("Pizza");
        }

        private void CupcakePictureBox_Click(object sender, EventArgs e)
        {
            totalPrice += cupcake;
            cartListBox.Items.Add("Cupcake");
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            if (totalPrice <= money)
            {

                money-= totalPrice;

                moneyLabel.Text = money.ToString() + "TL";
                MessageBox.Show("Odemeniz basariyla gerceklesmistir,bizi tercih ettiginiz icin tesekkur ederiz!","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else 
            {

                MessageBox.Show("Bakiyeniz yetersizdir.","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
            
            }
        }
    }
}
