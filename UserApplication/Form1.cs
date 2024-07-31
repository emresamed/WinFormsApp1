using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserApplication
{
    
    public partial class Form1 : Form
    {
        public static string[] usernames = new string[128];
        public static string[] passwords = new string[128];
        public static int userIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = usernameTextBox.Text;
            string Parola = passwordTextBox.Text;
            dataGridView1.Rows.Add(kullaniciAdi,Parola,DateTime.Now);
            usernames[userIndex] = kullaniciAdi;
            passwords[userIndex] = Parola;
            userIndex++;
            MessageBox.Show($"Kullanici basariyla eklendi, [Kullanici No:{userIndex.ToString()}]","Basarili",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Hide();

            form2.Show();
        }
    }
}
