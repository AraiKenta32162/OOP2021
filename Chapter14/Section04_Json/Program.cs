using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Xml.Linq;

namespace Section04_Json
{
    class Program
    {
        static void Main(string[] args)
        {
            var Keywprd = "算用記";
            var content = GetFromWikipedia(Keywprd);
            Console.WriteLine(content ?? "見つかりませんでした");
        }

        private static object GetFromWikipedia(string keywprd)
        {
            var wc = new WebClient();
            wc.QueryString = new NameValueCollection()
            {
                ["action"] = "query",
                ["prop"] = "revisions",
                ["rvprop"] = "content",
                //["format"] = "xml",
                ["format"] = "json",
                ["titles"] = HttpUtility.UrlEncode(keywprd, Encoding.UTF8),
            };
            wc.Headers.Add("Content-type", "charset=UFT-8");
            var result = wc.DownloadString("https://ja.wikipedia.org/w/api.php");
            var xmldoc = XDocument.Parse(result);
            var rev = xmldoc.Root.Descendants("rev").FirstOrDefault();
            return HttpUtility.HtmlDecode(rev?.Value);
        }
    }

    


}
