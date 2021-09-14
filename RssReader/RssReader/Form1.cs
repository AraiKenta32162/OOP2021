using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
//using System.Drawing;
using System.Linq;
using System.Net;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Xml;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        IEnumerable<ItemData> items = null;
        List<String> link = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
            
        }
        //指定したURL先からXMLデータを取得し、title要素を取得し、リストボックスへセットする
        private void setRssTitle(string uri)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");

                var stream = wc.OpenRead(uri);
                XDocument xdoc = XDocument.Load(stream);
                items = xdoc.Root.Descendants("item").Select(x => new ItemData
                {
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    pubDate = (DateTime)x.Element("pubData"),
                    Description = (string)x.Element("description")
                });

                foreach (var item in items)
                {
                    lbTitles.Items.Add(item.Title);
                }
            }
        }
        //
        private void lbTitles_Click(object sender, EventArgs e)
        {
            string link = (items.ToArray())[lbTitles.SelectedIndex].Link;
            //wbBrowser.Url = new Uri(link);

            lbDescription.Text = "概要\n";
            lbDescription.Text += (items.ToArray())[lbTitles.SelectedIndex].pubDate + "\n";
            lbDescription.Text += (items.ToArray())[lbTitles.SelectedIndex].Description;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tbUrl.Text = "https://news.yahoo.co.jp/rss/topics/top-picks.xml";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wbForm = new Form2((items.ToArray())[lbTitles.SelectedIndex].Link);
            wbForm.Show();
        }
    }
}


//https://news.yahoo.co.jp/rss/topics/top-picks.xml
//https://www.yahoo.co.jp/