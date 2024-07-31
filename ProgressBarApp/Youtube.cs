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
    public partial class Youtube : Form
    {
        public Youtube()
        {
            InitializeComponent();
        }

      
        private async Task Initizated() 
        {
        

            await webView21.EnsureCoreWebView2Async(null);
        
        
        
        }
        public async void initBrowser() 
        {
        
            await Initizated();
            webView21.CoreWebView2.Navigate("https://www.youtube.com");

        
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            initBrowser();

        }

        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 form2 = new Form2();
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
