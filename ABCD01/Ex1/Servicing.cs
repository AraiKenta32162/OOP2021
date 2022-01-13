using Ex1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex1
{
    public partial class Seibi : Form
    {
        private Setting setting = Setting.getInstance();
        BindingList<Ms> listMS = new BindingList<Ms>();

        public Seibi()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            //Selection_screen s1 = new Selection_screen();
            //s1.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("入力されていません");
                return;
            }

            Ms carReport = new Ms
            {
                Date = dateTimePicker1.Value,//記入日
                Auther = textBox5.Text,　　　//記入者
                CarName = comboBox1.Text,　　//車両名
                Distance = textBox2.Text,    //走行距離
                Exhaust = textBox4.Text,     //排気量
                Inspection = textBox3.Text,　//車検日
                Maker = selectedGroup(),　　 //メーカー
                Outline = comboBox2.Text,    //整備概要
                Details = textBox1.Text,     //整備詳細
            };
            listMS.Add(carReport);   //１レコード追加

            //コンボボックスの履歴登録
            setCbAuthor(textBox5.Text);
            setCbCarName(comboBox1.Text);

            if (!Setting.Set || String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("追加しました");
                return;
            }
        }

        private void setCbAuthor(object text)
        {
            
        }
        private void setCbCarName(object text)
        {
            
        }

        

        private Ms.MakerGroup selectedGroup()
        {

            foreach (var rb in groupBox1.Controls)
            {
                if (((RadioButton)rb).Checked)
                {
                    return (Ms.MakerGroup)int.Parse(((string)((RadioButton)rb).Tag));
                }
            }
            return Ms.MakerGroup.その他;
        }
    }
}
