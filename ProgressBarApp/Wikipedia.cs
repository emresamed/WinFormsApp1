using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBarApp
{
    public partial class Wikipedia : Form
    {
        public Wikipedia()
        {
            InitializeComponent();
        }

      

        private void Wikipedia_Load(object sender, EventArgs e)
        {
            InitBrowser();

        }
        private async Task Initizated() 
        {

            await webView21.EnsureCoreWebView2Async(null);
        
        }
        public async void InitBrowser() 
        {

            await Initizated();
            webView21.CoreWebView2.Navigate("https://www.wikipedia.org");
        
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            this.Dispose();
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoBack) 
            {
            
                webView21.GoBack();
            
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (webView21.CanGoForward)
            {

                webView21.GoForward();

            }
        }
    }
}
