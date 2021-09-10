using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace RssReader
{
    public partial class Form1 : Form
    {
        private IEnumerable<XElement> items;

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
                    lbTitles.Items.Add(item.Element("title").Value);

                   //List<string> link = new List<string>();
                   //wbBrowser.Url = new Uri("https://www.yahoo.co.jp/");
                }
            }
        }

        private void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string link = (items.ToArray())[lbTitles.SelectedIndex].Link;
            wbBrowser.Url = new Uri(link);
        }
    }
}


//https://news.yahoo.co.jp/rss/topics/top-picks.xml
//https://www.yahoo.co.jp/