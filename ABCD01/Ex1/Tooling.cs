using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Tooling : Form
    {
        BindingList<ToolingData> listTooling = new BindingList<ToolingData>();
        public Tooling()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void TouringClosebt_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btPictureOpen_Click(object sender, EventArgs e)
        {
            if (ofdPictureOpen.ShowDialog() == DialogResult.OK){
                pbPicture.Image = Image.FromFile(ofdPictureOpen.FileName);
            }
        }

        private void btPictureDelete_Click(object sender, EventArgs e)
        {
            pbPicture.Image = null;
        }

        public void TouringAddbt_Click(object sender, EventArgs e)
        {       //同じ言葉が保存されてしまう。
            Namecb.Items.Add(Namecb.Text);

            if (tbAuthor.Text == "" || Namecb.Text == "")
            {
                MessageBox.Show("入力されていません");
                return;
            }

            ToolingData carReport = new ToolingData
            {
                Date = dtpDate.Value,   　　　　　//記入日
                Auther = tbAuthor.Text,　　　　　 //記入者
                McName = Namecb.Text,  　 　　　　//車両名
                Distance = Distancetb.Text,　　   //距離
                Destination = Destinationtb.Text, //目的地
                People = Peopletb.Text,           //人数
                Cost = Costtb.Text,               //費用
                Picture = pbPicture.Image         //写真
            };
            listTooling.Add(carReport);   //１レコード追加

            //コンボボックスの履歴登録
            setTbAuthor(tbAuthor.Text);
            setNameCb(Namecb.Text);

            try
            {
                if (sfdFileSave.ShowDialog() == DialogResult.OK)
                {
                    //バイナリー形式でシリアル化
                    var bf = new BinaryFormatter();

                    using (FileStream fs = File.Open(sfdFileSave.FileName, FileMode.Create))
                    {
                        bf.Serialize(fs, listTooling);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("保存できませんでした");

            }
        }

        public void setTbAuthor(string author)
        {
            if (!tbAuthor.Text.Contains(author))
                tbAuthor.Text.Contains(author);
        }

        public void setNameCb(string text)
        {
            if (!Namecb.Items.Contains(text)){
                Namecb.Items.Add(text);
            }
        }
    }
}
