using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace WebVideoCacheApp
{
    public static class StaticLists
    {
        public static List<string> toBeDownloadList = new List<string>();
        public static List<string> doneDownloadList = new List<string>();

        const string toBeDownsPath = "../../../_data/toBeDowns.txt";
        const string didDownedPath = "../../../_data/didDowned.txt";


        public static void WriteDownsLists()
        {
            using (FileStream aFile = new FileStream(toBeDownsPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(aFile))
                {
                    List<string> FinalRSSList = new List<string>();
                    FinalRSSList.AddRange(toBeDownloadList.ToArray());

                    foreach (string _url in FinalRSSList)
                    {
                        sw.WriteLine(_url);
                    }
                }
            }

            using (FileStream aFile = new FileStream(didDownedPath, FileMode.Create, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(aFile))
                {
                    List<string> FinalRSSList = new List<string>();
                    FinalRSSList.AddRange(doneDownloadList.ToArray());

                    foreach (string _url in FinalRSSList)
                    {
                        sw.WriteLine(_url);
                    }
                }
            }
        }

        public static void ReadDownsLists()
        {
            using (StreamReader r = new StreamReader(toBeDownsPath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    toBeDownloadList.Add(line);
                }
            }

            using (StreamReader r = new StreamReader(didDownedPath))
            {
                string line;
                while ((line = r.ReadLine()) != null)
                {
                    doneDownloadList.Add(line);
                }
            }

        }
    }
}
