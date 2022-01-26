using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class ToolingData
    {
        [DisplayName("日付")]
        public DateTime Date { get; set; }  //日付
        [DisplayName("記録者")]
        public string Auther { get; set; }  //記録者
        [DisplayName("車名")]
        public string McName { get; set; } //車名
        [DisplayName("走行距離")]
        public string Distance { get; set; } //走行距離
        [DisplayName("目的地")]
        public string Destination { get; set; } //目的地
        [DisplayName("人数")]
        public string People { get; set; } //人数
        [DisplayName("費用")]
        public string Cost { get; set; }   //費用
        [DisplayName("写真")]
        public Image Picture { get; set; }   //写真
                
        public void UpDate(DateTime date,
                            string auther,
                            string mcName,
                            string distance,
                            string destination,
                            string people,
                            string cost,
                            Image picture)
        {
            this.Date = date;
            this.Auther = auther;
            this.McName = mcName;
            this.Distance = distance;
            this.Destination = destination;
            this.People = people;
            this.Cost = cost;
            this.Picture = picture;
        }
    }
}
