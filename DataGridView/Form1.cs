using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Baslik = baslikTextBox.Text;
            string Konu= konuTextBox.Text;  
            string Icerik= icerikRichTextBox.Text;

            dataGridView1.Rows.Add(Baslik,Konu,Icerik);
            MessageBox.Show("Veri eklendi","Bilgilendirme",MessageBoxButtons.OK,MessageBoxIcon.Information);

        }
    }
}
