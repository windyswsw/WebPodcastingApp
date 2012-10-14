using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;

namespace RSSFeedRetriever
{
    public class RetrieveRSSviaXML
    {
        XmlTextReader rssReader;
        XmlDocument rssDoc;
        XmlNode nodeRss;
        XmlNode nodeChannel;
        XmlNode nodeItem;

        List<NewsItem> listOfNews = new List<NewsItem>();

        public List<NewsItem> readRSSforXML(string URL)
        {
            listOfNews.Clear();
            // Create a new XmlTextReader from the specified URL (RSS feed)
            rssReader = new XmlTextReader(URL);
            rssDoc = new XmlDocument();
            // Load the XML content into a XmlDocument
            rssDoc.Load(rssReader);

            // Loop for the <rss> tag
            for (int i = 0; i < rssDoc.ChildNodes.Count; i++)
            {
                // If it is the rss tag
                if (rssDoc.ChildNodes[i].Name == "rss")
                {
                    // <rss> tag found
                    nodeRss = rssDoc.ChildNodes[i];
                }
            }

            // Loop for the <channel> tag
            for (int i = 0; i < nodeRss.ChildNodes.Count; i++)
            {
                // If it is the channel tag
                if (nodeRss.ChildNodes[i].Name == "channel")
                {
                    // <channel> tag found
                    nodeChannel = nodeRss.ChildNodes[i];
                }
            }

            // Loop for the <title>, <link>, <description> and all the other tags
            for (int i = 0; i < nodeChannel.ChildNodes.Count; i++)
            {
                // If it is the item tag, then it has children tags which we will add as items to the ListView
                if (nodeChannel.ChildNodes[i].Name == "item")
                {
                    nodeItem = nodeChannel.ChildNodes[i];
                    XmlNode XEnclosure = nodeItem["enclosure"];
                    DateTime XpubDate = new DateTime();
                    DateTime.TryParse(nodeItem["pubDate"].InnerText, out XpubDate);
                    if (XEnclosure == null)
                    {
                        continue;
                    }
                    
                    listOfNews.Add(new NewsItem(){
                    title = nodeItem["title"].InnerText,
                    link = nodeItem["link"].InnerText,
                    description = nodeItem["description"].InnerText,
                    URL = XEnclosure.Attributes["url"].InnerText,
                    pubDate = XpubDate
                    });
                }
            }
            
            return listOfNews;
        }
    }
}
