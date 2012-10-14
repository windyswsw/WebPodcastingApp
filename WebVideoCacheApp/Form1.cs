using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using URLDownloader;

namespace WebVideoCacheApp
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Timer Update (every 1 sec)
        /// </summary>
        private const double timerUpdate = 1000;
        private int timeSpan = 0;

        /// <summary>
        /// Interface Storage
        /// </summary>
        private NetworkInterface[] nicArr;

        /// <summary>
        /// Main Timer Object 
        /// (we could use something more efficient such 
        /// as interop calls to HighPerformanceTimers)
        /// </summary>
        public Timer timer;

        private long sentBytes = 0;
        private long recvBytes = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeNetworkInterface();
            InitializeTimer();
        }

        /// <summary>
        /// Initialize all network interfaces on this computer
        /// </summary>
        private void InitializeNetworkInterface()
        {
            // Grab all local interfaces to this computer
            nicArr = NetworkInterface.GetAllNetworkInterfaces();

            // Add each interface name to the combo box
            for (int i = 0; i < nicArr.Length; i++)
                cmbInterface.Items.Add(nicArr[i].Name);

            // Change the initial selection to the first interface
            cmbInterface.SelectedIndex = 0;
        }

        /// <summary>
        /// Initialize the Timer
        /// </summary>
        private void InitializeTimer()
        {
            timer = new Timer();
            timer.Interval = (int)timerUpdate;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }

        /// <summary>
        /// Update GUI components for the network interfaces
        /// </summary>
        private void UpdateNetworkInterface()
        {
            // Grab NetworkInterface object that describes the current interface
            NetworkInterface nic = nicArr[cmbInterface.SelectedIndex];

            // Grab the stats for that interface
            IPv4InterfaceStatistics interfaceStats = nic.GetIPv4Statistics();

            // Calculate the speed of bytes going in and out
            // NOTE: we could use something faster and more reliable than Windows Forms Tiemr
            //       such as HighPerformanceTimer http://www.m0interactive.com/archives/2006/12/21/high_resolution_timer_in_net_2_0.html
            int bytesSentSpeed = (int)(interfaceStats.BytesSent - sentBytes) / 1024;
            int bytesReceivedSpeed = (int)(interfaceStats.BytesReceived - recvBytes) / 1024;

            if (bytesReceivedSpeed + bytesSentSpeed < Program.belowUloadDload)
            {
                timeSpan++;
            }
            else
            {
                timeSpan = 0;
            }

            // Update the labels
            recvBytes = interfaceStats.BytesReceived;
            sentBytes = interfaceStats.BytesSent;
            lblUpload.Text = bytesSentSpeed.ToString() + " KB/s";
            lblDownload.Text = bytesReceivedSpeed.ToString() + " KB/s";

        }

        /// <summary>
        /// The Timer event for each Tick (second) to update the UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void timer_Tick(object sender, EventArgs e)
        {
            UpdateNetworkInterface();
            UpdateTimedProcesses();
        }

        private void UpdateTimedProcesses()
        {
            string configMsg = "Current configuration starts download when usage is \nbelow " + Program.belowUloadDload.ToString() +
                " kb/s for consecutive " + Program.waitSeconds.ToString() + " seconds.";
            lblConfig.Text = configMsg;
            if (timeSpan <= Program.waitSeconds)
            {
                prgTimeSpan.Value = (timeSpan * 100 / Program.waitSeconds);
            }
            else
            {
                timeSpan = 0;
                timer.Stop();
                stopMonitoring("Download Mode");

                #region OldMSGBox
                //DialogResult dr = MessageBox.Show("Download starts now! Press OK to go back to monitor mode.", "Downloading...", MessageBoxButtons.OK);
                //if (dr == System.Windows.Forms.DialogResult.OK)
                //{
                //    timer.Start();
                //} 
                #endregion

                string chosenURL = StaticLists.toBeDownloadList[0];

                DownloadForm df = new DownloadForm(chosenURL);
                df.ShowDialog();

                StaticLists.toBeDownloadList.Remove(chosenURL);
                StaticLists.doneDownloadList.Add(chosenURL);

                startMonitoring();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsPage sp = new SettingsPage();
            sp.ShowDialog();
            startMonitoring();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopMonitoring("Data Survey");
            Data_Insert.Data_Insert_Starting_Form dif = new Data_Insert.Data_Insert_Starting_Form();
            dif.ShowDialog();
            startMonitoring();
        }

        internal void stopMonitoring(string reason)
        {
            timer.Stop();
            lblMonitor.Image = Properties.Resources.flashing_red;
            lblMonitor.Text = "    Monitoring Off : " + reason;
        }

        internal void startMonitoring()
        {
            if(lblMonitor.Text == "    Monitoring ON")
            {
                return; 
            }
            timer.Start();
            timeSpan = 0;
            lblMonitor.Image = Properties.Resources.blinking_green_light;
            lblMonitor.Text = "    Monitoring ON";
        }
    }
}
