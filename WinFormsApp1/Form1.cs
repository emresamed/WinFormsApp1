namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Mail = MailGiris.Text;
            string istenilenMail = "emre_samet04@hotmail.com";
            if (Mail == istenilenMail)
            {

                GirisSonuc.Text = "Giris Basarili!";

            }
            else 
            {
            
            GirisSonuc.Text = "Giris Basarisiz!";
            
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void KontrolPaneli_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
