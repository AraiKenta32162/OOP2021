using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch {
    public partial class Form1 : Form {
        
        //時間計測のストップウォッチオブジェクト
        Stopwatch sw = new Stopwatch();

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
            //lbTimerDisp.Text = "00:00:00.00";//この記述でも可
        }

        //画面更新用タイマーのタイムアウト
        private void tmDisp_Tick(object sender, EventArgs e) {
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }
        //スタート
        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();　　//ストップウォッチスタート
            tmDisp.Start();//画面更新用のタイマースタート
        }
        //ストップ
        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
            tmDisp.Stop();
        }
        //リセット
        private void btReset_Click(object sender, EventArgs e) {
            sw.Reset();
            lbTimerDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");
        }
        //ラップ
        private void btLap_Click(object sender, EventArgs e) {
            //lbLapDisp.Items.Insert(0, lbTimerDisp.Text);
            lbLapDisp.Items.Insert(0,sw.Elapsed.ToString(@"hh\:mm\:ss\.ff"));
        }
    }
}
