using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages) + "ページ");
            Console.WriteLine("一番高価本は" + books.Max(x => x.Price) + "円");
            Console.WriteLine("一番安価本は" + books.Min(x => x.Price) + "円");
            //（500円以上の本は）何冊
            Console.WriteLine("500円以上の本は" + books.Count(x => 500 < x.Price) + "冊");

            Console.WriteLine();

            //本のタイトルに「物語」と付く本の冊数
            Console.WriteLine("物語」と付く本の冊数は" + books.Count(x => x.Title.Contains("物語")) + "です。");

            Console.WriteLine();

            //本のタイトルに「物語」と付く本の一覧
            var bookDate = books.Where(x => x.Title.Contains("物語"))/*.Take(2)*/;
            foreach (var book in bookDate) {
                Console.WriteLine(book.Title);
            }

            Console.WriteLine();

            //高額書籍ベスト3
            var output = books.OrderByDescending(x => x.Price).Take(3);
            foreach (var item in output) {
                Console.WriteLine(item.Title + " " + item.Price);
            }
            Console.WriteLine();

            //タイトルを表示
            var titles = books.Select(x => x.Title);
            foreach (var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
