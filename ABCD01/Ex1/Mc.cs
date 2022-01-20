using System;
using System.ComponentModel;

namespace Ex1
{
    [Serializable]
    class Mc
    {
        [DisplayName("日付")]
        public DateTime Date { get; set; }  //日付
        [DisplayName("記録者")]
        public string Auther { get; set; }  //記録者
        [DisplayName("車名")]
        public string CarName { get; set; } //車名
        [DisplayName("走行距離")]
        public string Distance { get; set; } //走行距離
        [DisplayName("排気量")]
        public string Exhaust { get; set; } //排気量
        [DisplayName("車検日")]
        public string Inspection { get; set; } //車検日
        [DisplayName("メーカー")]
        public MakerGroup Maker { get; set; }   //メーカー
        [DisplayName("整備概要")]
        public string Outline { get; set; }   //整備概要
        [DisplayName("整備詳細")]
        public string Details { get; set; }   //整備詳細

        public enum MakerGroup
        {
            HONDA,
            YAMAHA,
            SUZUKI,
            KAWASAKI,
            その他,
        }
        public void UpDate(DateTime date,
                            string auther,
                            string carName,
                            string distance,
                            string exhaust,
                            string inspection,
                            MakerGroup maker,
                            string outline,
                            string details)
        {
            this.Date = date;
            this.Auther = auther;
            this.CarName = carName;
            this.Distance = distance;
            this.Exhaust = exhaust;
            this.Inspection = inspection;
            this.Maker = maker;
            this.Outline = outline;
            this.Details = details; 
        }
    }
}
