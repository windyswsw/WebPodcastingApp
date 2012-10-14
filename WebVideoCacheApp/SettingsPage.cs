using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WebVideoCacheApp
{
    public partial class SettingsPage : Form
    {
        public SettingsPage()
        {
            InitializeComponent();
        }

        private void SettingsPage_Load(object sender, EventArgs e)
        {
            InitializeBandwidthControls();
            RefreshRSSListView();          
        }

        private void InitializeBandwidthControls()
        {
            trkUsage.Value = (trkUsage.Maximum > Program.belowUloadDload) ? Program.belowUloadDload : trkUsage.Maximum;
            txtUsage.Text = trkUsage.Value.ToString();
            trkDuration.Value = (trkDuration.Maximum > Program.waitSeconds) ? Program.waitSeconds : trkDuration.Maximum;
            txtDuration.Text = trkDuration.Value.ToString();
        }

        private void trkUsage_Scroll(object sender, EventArgs e)
        {
            Program.belowUloadDload = trkUsage.Value;
            txtUsage.Text = Program.belowUloadDload.ToString();
        }

        private void trkDuration_Scroll(object sender, EventArgs e)
        {
            Program.waitSeconds = trkDuration.Value;
            txtDuration.Text = Program.waitSeconds.ToString();
        }
        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Program.RSSList.Add(textBox1.Text.Trim());
            RefreshRSSListView();
        }

        private void RefreshRSSListView()
        {
            lstRSS.DataSource = null;
            lstRSS.DataSource = Program.RSSList;
        }

        private void lstRSS_MouseHover(object sender, EventArgs e)
        {
            lblSettingsRSS.Text = "Double click on a link in the list to delete it from the list.";
        }
        private void resetInformationLabel(object sender, EventArgs e)
        {
            lblSettingsRSS.Text = "RSS List will be evaluated and used in download process.";
        }

        private void btnEvaluate_MouseHover(object sender, EventArgs e)
        {
            lblSettingsRSS.Text = "Evaluate now to speed up the download process.";
        }

        private void lstRSS_DoubleClick(object sender, EventArgs e)
        {
            int i = lstRSS.SelectedIndex;
            Program.RSSList.RemoveAt(i);
            RefreshRSSListView();
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            EvaluatorForm ef = new EvaluatorForm();
            ef.ShowDialog();
        }
    }
}
