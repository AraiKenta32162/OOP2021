using System;
using System.Xml.Linq;

namespace RssReader
{
    internal class ItemData
    {
        public string Title { get; set; }
        public string Link { get; set; }
        public DateTime pubDate { get; set; }
        public string Description { get; set; }
    }
}