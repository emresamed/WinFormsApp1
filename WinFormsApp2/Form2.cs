using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        string totalstring = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void teknolojiCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (erkekRadioButton.Checked)
            {

                totalstring += "Cinsiyet: Erkek\n";

            }
            else if (kadinRadioButton.Checked)
            {

                totalstring += "Cinsiyet: Kadin\n";


            }
            else if (digerRadioButton.Checked) 
            {
                totalstring += "Cinsiyet: Diger\n";
            
            
            
            }

            if (teknolojiCheckBox.Checked) 
            {
                totalstring += "-Teknoloji\n";
            }
            if (muzikCheckBox.Checked) 
            {
                totalstring += "-Muzik\n";
            }
            if (resimCheckBox.Checked) 
            {

                totalstring += "-Resim";
            
            }
            MessageBox.Show(totalstring,"-Genel Bilgilendirme");
            
        }
    }
}
