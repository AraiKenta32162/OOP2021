using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            setRssTitle(tbUrl.Text);
            Console.ReadLine();
        }
        //指定したURL先からXMLデータを取得し、title要素を取得し、リストボックスへセットする
        private void setRssTitle(string url)
        {
            var uriString = string.Format(, url);

            var rssXml = new XmlDocument();
            rssXml.Load(url);
            XmlElement rssElem = rssXml.DocumentElement;
            String rssRootNodeTag = rssElem.Name;

            
        }        
    }
}


//https://www.yahoo.co.jp/
