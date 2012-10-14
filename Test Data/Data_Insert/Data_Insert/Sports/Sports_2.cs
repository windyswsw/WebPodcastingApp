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

namespace Data_Insert.Sports
{
    public partial class Sports_2 : Form
    {
        public Sports_2()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";

        public Sports_2(string strSelections)
        {
            InitializeComponent();
            UserSlections = strSelections;
        }

        private void Entertainment_btn1_Click(object sender, EventArgs e)
        {
            if (RB1.Checked)
            {
                if (!File.Exists(Watch_fileLoc))
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("In this TED archive video from 1998, paralympic sprinter Aimee Mullins talks about her record-setting career as a runner,and about the amazing carbon-fiber prosthetic legs (then a prototype) that helped her cross the finish line.A record-breaker at the Paralympic Games in 1996, Aimee Mullins has built a career as a model, actor and advocate for women, sports and the next generation of prosthetics");
                    sw.WriteLine("Christopher McDougall explores the mysteries of the human desire to run. How did running help early humans survive -- and what urges from our ancient ancestors spur us on today? McDougall tells the story of the marathoner with a heart of gold, the unlikely ultra-runner, and the hidden tribe in Mexico that runs to live. (Filmed at TEDxPennQuarter.) Christopher McDougall is the author of Born to Run: A Hidden Tribe, Super Athletes, and the Greatest Race the World Has Never Seen.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("In this TED archive video from 1998, paralympic sprinter Aimee Mullins talks about her record-setting career as a runner,and about the amazing carbon-fiber prosthetic legs (then a prototype) that helped her cross the finish line.A record-breaker at the Paralympic Games in 1996, Aimee Mullins has built a career as a model, actor and advocate for women, sports and the next generation of prosthetics");
                    sw.WriteLine("Christopher McDougall explores the mysteries of the human desire to run. How did running help early humans survive -- and what urges from our ancient ancestors spur us on today? McDougall tells the story of the marathoner with a heart of gold, the unlikely ultra-runner, and the hidden tribe in Mexico that runs to live. (Filmed at TEDxPennQuarter.) Christopher McDougall is the author of Born to Run: A Hidden Tribe, Super Athletes, and the Greatest Race the World Has Never Seen.");
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
                    sw.WriteLine("In this TED archive video from 1998, paralympic sprinter Aimee Mullins talks about her record-setting career as a runner,and about the amazing carbon-fiber prosthetic legs (then a prototype) that helped her cross the finish line.A record-breaker at the Paralympic Games in 1996, Aimee Mullins has built a career as a model, actor and advocate for women, sports and the next generation of prosthetics");
                    sw.WriteLine("Christopher McDougall explores the mysteries of the human desire to run. How did running help early humans survive -- and what urges from our ancient ancestors spur us on today? McDougall tells the story of the marathoner with a heart of gold, the unlikely ultra-runner, and the hidden tribe in Mexico that runs to live. (Filmed at TEDxPennQuarter.) Christopher McDougall is the author of Born to Run: A Hidden Tribe, Super Athletes, and the Greatest Race the World Has Never Seen.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("In this TED archive video from 1998, paralympic sprinter Aimee Mullins talks about her record-setting career as a runner,and about the amazing carbon-fiber prosthetic legs (then a prototype) that helped her cross the finish line.A record-breaker at the Paralympic Games in 1996, Aimee Mullins has built a career as a model, actor and advocate for women, sports and the next generation of prosthetics");
                    sw.WriteLine("Christopher McDougall explores the mysteries of the human desire to run. How did running help early humans survive -- and what urges from our ancient ancestors spur us on today? McDougall tells the story of the marathoner with a heart of gold, the unlikely ultra-runner, and the hidden tribe in Mexico that runs to live. (Filmed at TEDxPennQuarter.) Christopher McDougall is the author of Born to Run: A Hidden Tribe, Super Athletes, and the Greatest Race the World Has Never Seen.");
                    sw.Close();
                    aFile.Close();
                }
            }

            Sports_3 frm = new Sports_3(UserSlections);
            frm.Show();
            this.Close();
        }

    }
}
