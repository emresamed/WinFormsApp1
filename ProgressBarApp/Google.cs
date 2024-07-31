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
    public partial class Google : Form
    {
        public Google()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            this.Dispose();
            form2.Show();
        }
        private async Task Initizated() 
        {
        
            await webView21.EnsureCoreWebView2Async(null);
        
        
        }

        public async void InitBrowser() 
        {

            await Initizated();
            webView21.CoreWebView2.Navigate("https://www.google.com");
        
        
        
        }

        private void Google_Load(object sender, EventArgs e)
        {
            InitBrowser();
        }

        private void webView21_Click(object sender, EventArgs e)
        {

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
