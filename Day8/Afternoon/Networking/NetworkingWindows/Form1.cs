using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetworkingWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = getResponse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Enabled = false;
            richTextBox1.Text = "You are on a slow connection. Please wait while we process your request...";

            Task<string> fetch  = new Task<string>(() => getResponse(textBox1.Text));            
            fetch.ContinueWith(t => { richTextBox1.Text = t.Result; richTextBox1.Enabled = true; }, TaskScheduler.FromCurrentSynchronizationContext());
            fetch.Start();
        }

        private string getResponse(string url){
        
        HttpWebRequest httpReq = WebRequest.CreateHttp(url);
            httpReq.Method = "GET";
            httpReq.Accept = "text/html";
            string response;
            using (StreamReader reader = new StreamReader(httpReq.GetResponse().GetResponseStream()))
            {
                response = reader.ReadToEnd();
            }
            return response;
        }
    }
}
