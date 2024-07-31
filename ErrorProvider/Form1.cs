using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErrorProvider
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullaniciAdiTextBox.Text == string.Empty)
            {

                errorProvider1.SetError(kullaniciAdiTextBox, "Kullanici adi bos birakilamaz");


            }
            else 
            {

                errorProvider1.Clear();
            
            
            }
            if (parolaTextBox.Text == string.Empty)
            {
                errorProvider2.SetError(parolaTextBox, "Parola bos birakilamaz");

            }
            else 
            {

                errorProvider2.Clear();

            }
        }
    }
}
