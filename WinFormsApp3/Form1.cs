namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number1 = Convert.ToInt32(number1MaskedTextBox.Text);
                int number2 = Convert.ToInt32(number2MaskedTextBox.Text);
                char pickedOperator = Convert.ToChar(operatorComboBox.Text);
                double result = 0.0;
                if (pickedOperator == '+')
                {
                    result = number1 + number2;

                }
                else if (pickedOperator == '-')
                {

                    result = number1 - number2;

                }
                else if (pickedOperator == '*')
                {

                    result = number1 * number2;


                }
                else if (pickedOperator == '/')
                {
                    result = number1 / number2;
                }
                resultsListBox.Items.Add(result);
            }
            catch(Exception )
            {

             MessageBox.Show("Lutfen bir operator seciniz.","HATA!");
            
            }
            
        }
    }
}
