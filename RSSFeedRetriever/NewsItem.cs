using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RSSFeedRetriever
{
    public class NewsItem
    {
        public string title;
        public string link;
        public string description;
        public string URL;
        public DateTime pubDate;

        public static List<string> getDescriptionList(List<NewsItem> inputList)
        {
            List<string> retList = new List<string>();

            foreach (NewsItem item in inputList)
            {
                retList.Add(item.description);
            }

            return retList;
        }
    }    
}
