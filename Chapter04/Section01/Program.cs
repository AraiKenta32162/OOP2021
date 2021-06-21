using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            //int count = 0;

            //Console.WriteLine($"後置:{count++}");
            //Console.WriteLine($"前置:{++count}");

            //var str = "123";
            ////int height;
            //if (int.TryParse(str,out var height)) {
            //    Console.WriteLine(height);
            //} else {
            //    Console.WriteLine("変換できません");
            //}
            var Session = new Dictionary<string, object>();
            Session["MyProduct"] = new Product();

            var product = Session["MyProduct"] as Product;
            if(product == null) {
                //productが取得できなかった時の処理
                Console.WriteLine("productが取得できなかった");
            } else {
                //productが取得できた時の処理
                Console.WriteLine("productが取得できた");
            }
        }
        
        private static Product GetProductA() {
            Sale sale = new Sale();
            return sale?.Product;//null条件演算子
        }

    }
    class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }
}
