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
        private Seibi seibi = new Seibi();
        private Tooling tooling = new Tooling();
        private MaintenanceDetails maintenance = new MaintenanceDetails();

        public Selection_screen()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        
            //描画先とするImageオブジェクトを作成する
            Bitmap canvas = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //ImageオブジェクトのGraphicsオブジェクトを作成する
            Graphics g = Graphics.FromImage(canvas);

            string drawString = /*"二輪点検整備・運行記録管理\r\nシステム"*/"MS　Touring ＆ Maintenance note";
            //Fontを作成
            Font fnt = new Font(/*"ＭＳ ゴシック"*/"Stencil", 35);
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

            //this.BackgroundImage = Image.FromFile(@"C:\Windows\desktop\メイン背景.jpg");
            pictureBox1.BackColor = Color.Transparent;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            seibi.ShowDialog();
            this.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            tooling.ShowDialog();
            this.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            maintenance.ShowDialog();
            this.Visible = true;
        }
                        
        private void button6_Click(object sender, EventArgs e)
        {
            setRssTitle("https://news.yahoo.co.jp/rss/topics/top-picks.xml");
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
                    Title = (string)x.Element("title"),
                    Link = (string)x.Element("link"),
                    PubDate = (DateTime)x.Element("pubDate"),
                    Description = (string)x.Element("description")
                    
            });

                foreach (var item in items)
                {
                    listBox1.Items.Add(item.Title);
                    //panel1.Items.Add(item.Title);
                }
            }
        }

        #endregion

        #region  GetProcessesByWindowTitle
        /*------------------------------------------*/
        /*public System.Diagnostics.Process[] GetProcessesByWindowTitle(string windowTitle)
        {
            System.Collections.ArrayList list = new System.Collections.ArrayList();

            //すべてのプロセスを列挙する
            foreach (System.Diagnostics.Process p
                in System.Diagnostics.Process.GetProcesses())
            {
                //指定された文字列がメインウィンドウのタイトルに含まれているか調べる
                if (0 <= p.MainWindowTitle.IndexOf(windowTitle))
                {
                    //含まれていたら、コレクションに追加
                    list.Add(p);
                }
            }

            //コレクションを配列にして返す
            return (System.Diagnostics.Process[])
                list.ToArray(typeof(System.Diagnostics.Process));
        }
         /*-----------------------------------------------------*/
        #endregion
    }
}
