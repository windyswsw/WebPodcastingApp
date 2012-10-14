using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Data_Insert.Entertainment;
using Data_Insert.Main;

namespace Data_Insert.Sports
{
    public partial class Sports_3 : Form
    {
        public Sports_3()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Sports_3(string strSelections)
        {
            InitializeComponent();
            UserSlections = strSelections;

            string[] words = UserSlections.Split(',');
            length = words.Length;

            if (length == 4)
            {
                Next = words[2];
                NewUserSlections = words[3];
            }
            else if (length == 3)
            {
                Next = words[2];
            }
            else if (length == 1)
            {
                Next = words[0];
            }

        }

        private void Entertainment_btn1_Click(object sender, EventArgs e)
        {
            if (RB1.Checked)
            {
                if (!File.Exists(Watch_fileLoc))
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Lewis Pugh talks about his record-breaking swim across the North Pole. He braved the icy waters (in a Speedo) to highlight the melting icecap. Watch for astonishing footage -- and some blunt commentary on the realities of supercold-water swims. Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest.");
                    sw.WriteLine("After he swam the North Pole, Lewis Pugh vowed never to take another cold-water dip. Then he heard of Lake Imja in the Himalayas, created by recent glacial melting, and Lake Pumori, a body of water at an altitude of 5300 m on Everest -- and so began a journey that would teach him a radical new way to approach swimming and think about climate change.Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Lewis Pugh talks about his record-breaking swim across the North Pole. He braved the icy waters (in a Speedo) to highlight the melting icecap. Watch for astonishing footage -- and some blunt commentary on the realities of supercold-water swims. Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest.");
                    sw.WriteLine("After he swam the North Pole, Lewis Pugh vowed never to take another cold-water dip. Then he heard of Lake Imja in the Himalayas, created by recent glacial melting, and Lake Pumori, a body of water at an altitude of 5300 m on Everest -- and so began a journey that would teach him a radical new way to approach swimming and think about climate change.Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest");
                    sw.Close();
                    aFile.Close();
                }
            }

            else if (RB2.Checked)
            {
                if (!File.Exists(Not_Watch_fileLoc))
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Lewis Pugh talks about his record-breaking swim across the North Pole. He braved the icy waters (in a Speedo) to highlight the melting icecap. Watch for astonishing footage -- and some blunt commentary on the realities of supercold-water swims. Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest.");
                    sw.WriteLine("After he swam the North Pole, Lewis Pugh vowed never to take another cold-water dip. Then he heard of Lake Imja in the Himalayas, created by recent glacial melting, and Lake Pumori, a body of water at an altitude of 5300 m on Everest -- and so began a journey that would teach him a radical new way to approach swimming and think about climate change.Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Lewis Pugh talks about his record-breaking swim across the North Pole. He braved the icy waters (in a Speedo) to highlight the melting icecap. Watch for astonishing footage -- and some blunt commentary on the realities of supercold-water swims. Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest.");
                    sw.WriteLine("After he swam the North Pole, Lewis Pugh vowed never to take another cold-water dip. Then he heard of Lake Imja in the Himalayas, created by recent glacial melting, and Lake Pumori, a body of water at an altitude of 5300 m on Everest -- and so began a journey that would teach him a radical new way to approach swimming and think about climate change.Pushing his body through epic cold-water swims, Lewis Gordon Pugh wants to draw attention to our global climate. He's just back from swimming in a meltwater lake on the slopes of Mount Everest");
                    sw.Close();
                    aFile.Close();
                }
            }

            if (length == 4 || length == 3 || length == 1)
            {

                if (Next == "Politics")
                {
                    Politics frm = new Politics(NewUserSlections);
                    frm.Show();
                }

                else if (Next == "Medical")
                {
                    Medical frm = new Medical(NewUserSlections);
                    frm.Show();
                }

                else if (Next == "Science")
                {
                    Science frm = new Science(NewUserSlections);
                    frm.Show();
                }
                else
                {
                    Finish frm = new Finish();
                    frm.Show();
                }

            }
                else
                {
                    Finish frm = new Finish();
                    frm.Show();
                }

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finish frm = new Finish();
            frm.Show();
            this.Close();
        }
    }
}
