using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void btAction_Click(object sender, EventArgs e) {
            //var today = DateTime.Today;
            var today = new DateTime((int)nudYear.Value,(int)nudMonth.Value,(int)nudDay.Value);
            DayOfWeek dayOfWeek = today.DayOfWeek;

            string dow = "";
            //曜日
            switch (dayOfWeek) {
                case DayOfWeek.Sunday:
                    dow = "日曜日";
                    break;
                case DayOfWeek.Monday:
                    dow = "月曜日";
                    break;
                case DayOfWeek.Tuesday:
                    dow = "火曜日";
                    break;
                case DayOfWeek.Wednesday:
                    dow = "水曜日";
                    break;
                case DayOfWeek.Thursday:
                    dow = "木曜日";
                    break;
                case DayOfWeek.Friday:
                    dow = "金曜日";
                    break;
                case DayOfWeek.Saturday:
                    dow = "土曜日";
                    break;
            }
            tbOutput.Text = dow　+　"です。";
            
            //閏年判定
            var isLeapYear = DateTime.IsLeapYear((int)nudYear.Value);
            if (isLeapYear) {
                tbLeapYear.Text = ("閏年です");
            } else {
                tbLeapYear.Text = ("閏年ではありません");
            }
            //指定日から今日までの日付

            
        }
        //指定日から今日までの年数
        public static int GetAge(DateTime birthday,DateTime targetday) {
            var age = targetday.Year - birthday.Year;
            if (targetday < birthday.AddYears(age)) {
                age--;
            }
            return age;
        }
    }
}
