using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace WebVideoCacheApp
{
    static class Program
    {
        public static int waitSeconds = 30;
        public static int belowUloadDload = 5;
        public static List<string> RSSList = new List<string>();
        const string RSSListPath = "../../../_data/RSSList.txt";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            ReadRSSList();
            StaticLists.ReadDownsLists();

            Application.Run(new Form1());
            
            WriteRSSList();
            StaticLists.WriteDownsLists();
        }

        private static void WriteRSSList()
        {
            using (FileStream aFile = new FileStream(RSSListPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(aFile))
                {
                    List<string> FinalRSSList = new List<string>();
                    FinalRSSList.AddRange(Program.RSSList.ToArray());

                    foreach (string _url in FinalRSSList)
                    {
                        sw.WriteLine(_url);
                    }
                }
            }
        }

        private static void ReadRSSList()
        {

            using (StreamReader r = new StreamReader(RSSListPath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    RSSList.Add(line);
                }
            }
            int count = RSSList.Count;
        }
    }
}
