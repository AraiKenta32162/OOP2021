using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Ex1
{
    public partial class Selection_screen : Form
    {
        IEnumerable<ItemData> items = null;
        List<string> link = new List<string>();
        

        //設定画面
        private Maintenance seibi = new Maintenance();
        private Tooling tooling = new Tooling();
        private MaintenanceDetails maintenance = new MaintenanceDetails();
        private TouringReport touring = new TouringReport();

        public Selection_screen()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            string drawString = "MC　Touring ＆ Maintenance note";
            //Fontを作成
            Font fnt = new Font("Stencil", 35);
            //線形グラデーション（横にライムグリーンから薄青）を作成
            LinearGradientBrush b = new LinearGradientBrush(
                                        pictureBox1.ClientRectangle,
                                        Color.LawnGreen,
                                        Color.LightBlue,
                                        LinearGradientMode.Horizontal);
            
            //StringFormatを作成
            StringFormat sf = new StringFormat();
            //文字を真ん中に表示
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;
            //文字を書く
            g.DrawString(drawString, fnt, b,
                pictureBox1.ClientRectangle, sf);

            //リソースを解放する
            fnt.Dispose();
            b.Dispose();
            g.Dispose();

            //PictureBox1に表示する
            pictureBox1.Image = canvas;
                        
            pictureBox1.BackColor = Color.Transparent;

            setRssTitle("https://news.yahoo.co.jp/rss/media/bikeno/all.xml");
            //setRssTitle("https://news.yahoo.co.jp/rss/media/autoby/all.xml");
        }

        private void Maintenancebt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seibi.ShowDialog();
            this.Visible = true;
        }

        private void Touringbt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            tooling.ShowDialog();
            this.Visible = true;
        }

        private void Closebt_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void Logbt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            maintenance.ShowDialog();
            this.Visible = true;
        }

        private void Reportbt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            touring.ShowDialog();
            this.Visible = true;
        }

        #region  RSS
        private void setRssTitle(string uri)
        {            
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var stream = wc.OpenRead(uri);
                XDocument xdoc = XDocument.Load(stream);

                items = xdoc.Root.Descendants("item").Select(x => new ItemData
                {
                    Title = (string)x.Element("title"),//.Replace("バイクのニュース"," ")
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description")
                    
            });
                
                foreach (var item in items)
                {                    
                    listBox1.Items.Add(item.Title);
                }
            }
        }





        #endregion
    }
}
