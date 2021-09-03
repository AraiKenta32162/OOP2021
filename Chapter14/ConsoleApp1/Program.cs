using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Section04
{
    class Program
    {
        Dictionary<string, int> Area = new Dictionary<string, int>()
        {
            {"前橋", 4210},
            {"みなかみ", 4220},
            {"宇都宮", 4110},
            {"水戸", 4010}
        };
        static void Main(string[] args)
        {
            new Program();
        }

        //コンストラクタ
        public Program()
        {
            Console.WriteLine("yahoo!週間天気予報");
            Console.WriteLine();//改行
            Console.WriteLine("地域コードを入力してください");
            for (int i = 0; i < Area.Count; i++)
            {
                Console.WriteLine("{0}:{1}", i + 1, );
            }
            Console.WriteLine("");
            Console.WriteLine("1:前橋");　　　//4210
            Console.WriteLine("2:みなかみ");　//4220
            Console.WriteLine("3:宇都宮");　　//4110
            Console.WriteLine("4:水戸");　　　//4010
            Console.WriteLine("9:その他(直接入力)");
            Console.WriteLine();//改行

            Console.Write(">");
            //文字列として数字を取り込む
            var selectArea = Console.ReadLine();

            if (true)
            {
                int a = int.Parse();
            }
            
            var results = GetWeatherReportFromYahoo(4210);//前橋
            foreach (var s in results)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();//入力待ち
        }

        //リスト14.19
        private static IEnumerable<string> GetWeatherReportFromYahoo(int cityCode)
        {
            using (var wc = new WebClient())
            {
                wc.Headers.Add("Content-type", "charset=UTF-8");
                var uriString = string.Format(
                    @"http://rss.weather.yahoo.co.jp/rss/days/{0}.xml", cityCode);
                var url = new Uri(uriString);
                var stream = wc.OpenRead(url);

                XDocument xdoc = XDocument.Load(stream);
                var nodes = xdoc.Root.Descendants("title");
                foreach (var node in nodes)
                {
                    string s = Regex.Replace(node.Value, "【|】", "");
                    yield return s;
                }
            }
        }
    }
}
