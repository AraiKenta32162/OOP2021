using System;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form2 : Form
    {
        Uri url;
        public Form2(string url)
        {
            InitializeComponent();
            this.url = new Uri(url);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            webBrowser1.Url = url;
        }
    }
}
