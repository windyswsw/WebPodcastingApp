using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSFeedRetriever;

namespace WebVideoCacheApp
{
    public partial class ViewArticles : Form
    {
        public ViewArticles(List<NewsItem> inputList)
        {
            InitializeComponent();
            loadGrid(inputList);
        }

        private void loadGrid(List<NewsItem> inputList)
        {
            ListViewItem rowNews;
            foreach (NewsItem item in inputList)
            {
                rowNews = new ListViewItem();
                rowNews.Text = item.title;
                rowNews.SubItems.Add(item.link);
                rowNews.SubItems.Add(item.description);
                lstNews.Items.Add(rowNews); 
            }
        }

        private void lstNews_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstNews.SelectedItems.Count > 0)
            {
                ListViewItem temp = lstNews.SelectedItems[0];

                if (temp.SubItems.Count > 2)
                {
                    txtContent.Text = temp.SubItems[2].Text; 
                }
            }
        }
    }
}
