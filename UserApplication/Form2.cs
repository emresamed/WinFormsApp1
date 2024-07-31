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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();

            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int usernameLineFound = 0;
            int passwordLineFound = 0;  
            
            bool IsUsernameCorrect = false;
            bool IsPasswordCorrect = false;

            string Username = usernameTextBox.Text;
            string Password = passwordTextBox.Text;

            for (int i=0;i<Form1.userIndex;i++) {
                if (Username == Form1.usernames[i])
                {

                    usernameLineFound = i;
                    IsUsernameCorrect = true;
                    break;

                }
            }
            for (int i = 0; i < Form1.userIndex; i++)
            {
                if (Password == Form1.passwords[i])
                {

                    passwordLineFound = i;
                    IsPasswordCorrect = true;
                    break;
                }
            }
            if (IsUsernameCorrect && IsPasswordCorrect)
            {
                if (usernameLineFound == passwordLineFound)
                {

                    richTextBox1.Text = "Kullanici sisteme tanimlidir.";
                    MessageBox.Show("Kullanici sisteme tanimlidir.", "Basarili", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
                else 
                {

                    richTextBox1.Text = "Kullanici sisteme tanimli degildir.";
                    MessageBox.Show("Kullanici sisteme tanimli degildir.", "Basarisiz", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else 
            {

                richTextBox1.Text = "Kullanici sisteme tanimli degildir.";
                MessageBox.Show("Kullanici sisteme tanimli degildir.", "Basarisiz", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }
    }
}
