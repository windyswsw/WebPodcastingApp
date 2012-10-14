using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RSSFeedRetriever;
using BayesianProbabiltyDetector;
using System.Threading;

namespace WebVideoCacheApp
{
    public partial class EvaluatorForm : Form
    {
        private delegate void updateTxtLogCallBack(string msg);
        private delegate void updatelblLogCallBack();

        double evalutaionCriteria = 0.1;

        List<string> AllRSSURLs = new List<string>();
        List<NewsItem> AllNewsItems = new List<NewsItem>();
        List<NewsItem> passedItems = new List<NewsItem>();
        List<NewsItem> failedItems = new List<NewsItem>();

        public EvaluatorForm()
        {
            InitializeComponent();
        }

        private void EvaluatorForm_Load(object sender, EventArgs e)
        {
            Form1 lf = Application.OpenForms.OfType<Form1>().ToArray()[0];
            lf.stopMonitoring("Evalutaion");

            Thread evalThread = new Thread(EvaluateRSSList);
            evalThread.Start();
        }

        private void EvaluateRSSList()
        {
            AllRSSURLs.AddRange(Program.RSSList.ToArray());
            CallBackUpdateErrorLog("Found " + AllRSSURLs.Count.ToString() + " RSS URLs.\r\n");
            CallBackUpdateLabelFields();

            RetrieveRSSviaXML RSS_Feeder = new RetrieveRSSviaXML();

            foreach (string url in AllRSSURLs)
            {
                CallBackUpdateErrorLog("Extracting articles from " + url);
                try
                {
                    List<NewsItem> tempList = RSS_Feeder.readRSSforXML(url);
                    AllNewsItems.AddRange(tempList.GetRange(0, (tempList.Count>9)?10:tempList.Count).ToArray());
                    CallBackUpdateErrorLog(tempList.Count.ToString() + " articles extracted.");
                }
                catch (Exception ex)
                {
                    string errorCode = "Extraction failed. " + ex.Message;
                    CallBackUpdateErrorLog(errorCode);                   
                }
            }

            CallBackUpdateErrorLog("\r\nExtracted total of " + AllNewsItems.Count.ToString() + " news articles.\r\n");
            CallBackUpdateLabelFields();

            CallBackUpdateErrorLog("Loading Bayesian Probabilty Statistics from Survey Data...");
            BInterface BI_Algo = new BInterface();

            double temp_Double = 0;

            foreach (NewsItem item in AllNewsItems)
            {
                try
                {
                    temp_Double = BI_Algo.TestString(item.description);
                }
                catch (Exception)
                {
                    continue;
                }
                if (temp_Double <= evalutaionCriteria)
                {
                    passedItems.Add(item);
                }
                else
                {
                    failedItems.Add(item);
                }

                CallBackUpdateLabelFields();
            }

            CallBackUpdateErrorLog("Evaluation Done.");

            foreach (NewsItem item in passedItems)
            {
                List<string> tempCheckList = new List<string>();
                tempCheckList.AddRange(StaticLists.toBeDownloadList.ToArray());
                tempCheckList.AddRange(StaticLists.doneDownloadList.ToArray());

                string _url = item.URL.Trim();

                if (!tempCheckList.Contains(_url))
                {
                    StaticLists.toBeDownloadList.Add(_url);
                }
            }
        }

        #region ThreadMgt
        private void CallBackUpdateErrorLog(string errorCode)
        {
            try
            {
                this.Invoke(new updateTxtLogCallBack(this.updateTxtLog), new object[] { errorCode });
            }
            catch (Exception)
            {
                txtEvalLog.Text += "Internal Error. \r\n";
            }
        }

        private void CallBackUpdateLabelFields()
        {
            try
            {
                this.Invoke(new updatelblLogCallBack(this.updateLabels));
            }
            catch (Exception)
            {
                txtEvalLog.Text += "Internal Error. \r\n";
            }
        }

        private void updateTxtLog(string msg)
        {
            txtEvalLog.Text += msg + "\r\n";
        }

        private void updateLabels()
        {
            lblAllURLs.Text = AllRSSURLs.Count.ToString();
            lblAllArticles.Text = AllNewsItems.Count.ToString();
            lblPassed.Text = passedItems.Count.ToString();
            lblFailed.Text = failedItems.Count.ToString();
        }
        #endregion

        private void btnPassed_Click(object sender, EventArgs e)
        {
            if (passedItems.Count > 0)
            {
                ViewArticles va = new ViewArticles(passedItems);
                va.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("No passed items from Evalutaion.");
            }
        }

        private void btnFailed_Click(object sender, EventArgs e)
        {
            if (failedItems.Count > 0)
            {
                ViewArticles va = new ViewArticles(failedItems);
                va.ShowDialog();
            }
            else
            {
                MessageBox.Show("No failed items from Evalutaion.");
            }
        }
    }
}
