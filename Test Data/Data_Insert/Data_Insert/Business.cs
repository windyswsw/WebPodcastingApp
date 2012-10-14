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
using Data_Insert.Sports;

namespace Data_Insert
{
    public partial class Business : Form
    {
        public Business()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Business(string strSelections)
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
                    sw.WriteLine("At TED@MotorCity, Lisa Gansky, author of The Mesh, talks about a future of business that's about sharing all kinds of stuff, either via smart and tech-enabled rental or, more boldly, peer-to-peer. Examples across industries -- from music to cars -- show how close we are to this meshy future.Lisa Gansky is the author of The Mesh: Why the Future of Business Is Sharing, and the instigator behind the Mesh Directory (www.meshing.it).");
                    sw.WriteLine("At his carpet company, Ray Anderson has increased sales and doubled profits while turning the traditional take / make / waste. industrial system on its head. In a gentle, understated way, he shares a powerful vision for sustainable commerce.Ray Anderson founded the company that makes covetable Flor carpeting. But behind the fresh design is a decades-deep commitment to sustainable ways of doing business -- culminating in the Mission Zero plan. ");
                    sw.WriteLine("When the dotcom bubble burst, hotelier Chip Conley went in search of a business model based on happiness. In an old friendship with an employee and in the wisdom of a Buddhist king, he learned that success comes from what you count. Chip Conley creates joyful hotels, where he hopes his employees, customers and investors alike can realize their full potential. His books share that philosophy with the wider world");
                    sw.WriteLine("John Gerzema says there's an upside to the recent financial crisis -- the opportunity for positive change. In talk talk, he identifies four major cultural shifts driving new consumer behavior and shows how businesses are evolving to connect with thoughtful spending. (Filmed at TEDxKC.) John Gerzema uses data, analysis and decades of experience to identify trends and develop daring new approaches to advertising");
                    sw.WriteLine("Ten percent of American businesses disappear every year. … It’s far higher than the failure rate of, say, Americans. Ten percent of Americans don’t disappear every year. Which leads us to conclude American businesses fail faster than Americans, and therefore American businesses are evolving faster than Americans");
                    sw.WriteLine("Economics writer Tim Harford studies complex systems -- and finds a surprising link among the successful ones: they were built through trial and error. In this sparkling talk from TEDGlobal 2011, he asks us to embrace our randomness and start making better mistakes.Tim Harford's writings reveal the economic ideas behind everyday experiences");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("At TED@MotorCity, Lisa Gansky, author of The Mesh, talks about a future of business that's about sharing all kinds of stuff, either via smart and tech-enabled rental or, more boldly, peer-to-peer. Examples across industries -- from music to cars -- show how close we are to this meshy future.Lisa Gansky is the author of The Mesh: Why the Future of Business Is Sharing, and the instigator behind the Mesh Directory (www.meshing.it).");
                    sw.WriteLine("At his carpet company, Ray Anderson has increased sales and doubled profits while turning the traditional take / make / waste. industrial system on its head. In a gentle, understated way, he shares a powerful vision for sustainable commerce.Ray Anderson founded the company that makes covetable Flor carpeting. But behind the fresh design is a decades-deep commitment to sustainable ways of doing business -- culminating in the Mission Zero plan. ");
                    sw.WriteLine("When the dotcom bubble burst, hotelier Chip Conley went in search of a business model based on happiness. In an old friendship with an employee and in the wisdom of a Buddhist king, he learned that success comes from what you count. Chip Conley creates joyful hotels, where he hopes his employees, customers and investors alike can realize their full potential. His books share that philosophy with the wider world");
                    sw.WriteLine("John Gerzema says there's an upside to the recent financial crisis -- the opportunity for positive change. In talk talk, he identifies four major cultural shifts driving new consumer behavior and shows how businesses are evolving to connect with thoughtful spending. (Filmed at TEDxKC.) John Gerzema uses data, analysis and decades of experience to identify trends and develop daring new approaches to advertising");
                    sw.WriteLine("Ten percent of American businesses disappear every year. … It’s far higher than the failure rate of, say, Americans. Ten percent of Americans don’t disappear every year. Which leads us to conclude American businesses fail faster than Americans, and therefore American businesses are evolving faster than Americans");
                    sw.WriteLine("Economics writer Tim Harford studies complex systems -- and finds a surprising link among the successful ones: they were built through trial and error. In this sparkling talk from TEDGlobal 2011, he asks us to embrace our randomness and start making better mistakes.Tim Harford's writings reveal the economic ideas behind everyday experiences");
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
                    sw.WriteLine("At TED@MotorCity, Lisa Gansky, author of The Mesh, talks about a future of business that's about sharing all kinds of stuff, either via smart and tech-enabled rental or, more boldly, peer-to-peer. Examples across industries -- from music to cars -- show how close we are to this meshy future.Lisa Gansky is the author of The Mesh: Why the Future of Business Is Sharing, and the instigator behind the Mesh Directory (www.meshing.it).");
                    sw.WriteLine("At his carpet company, Ray Anderson has increased sales and doubled profits while turning the traditional take / make / waste. industrial system on its head. In a gentle, understated way, he shares a powerful vision for sustainable commerce.Ray Anderson founded the company that makes covetable Flor carpeting. But behind the fresh design is a decades-deep commitment to sustainable ways of doing business -- culminating in the Mission Zero plan. ");
                    sw.WriteLine("When the dotcom bubble burst, hotelier Chip Conley went in search of a business model based on happiness. In an old friendship with an employee and in the wisdom of a Buddhist king, he learned that success comes from what you count. Chip Conley creates joyful hotels, where he hopes his employees, customers and investors alike can realize their full potential. His books share that philosophy with the wider world");
                    sw.WriteLine("John Gerzema says there's an upside to the recent financial crisis -- the opportunity for positive change. In talk talk, he identifies four major cultural shifts driving new consumer behavior and shows how businesses are evolving to connect with thoughtful spending. (Filmed at TEDxKC.) John Gerzema uses data, analysis and decades of experience to identify trends and develop daring new approaches to advertising");
                    sw.WriteLine("Ten percent of American businesses disappear every year. … It’s far higher than the failure rate of, say, Americans. Ten percent of Americans don’t disappear every year. Which leads us to conclude American businesses fail faster than Americans, and therefore American businesses are evolving faster than Americans");
                    sw.WriteLine("Economics writer Tim Harford studies complex systems -- and finds a surprising link among the successful ones: they were built through trial and error. In this sparkling talk from TEDGlobal 2011, he asks us to embrace our randomness and start making better mistakes.Tim Harford's writings reveal the economic ideas behind everyday experiences");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("At TED@MotorCity, Lisa Gansky, author of The Mesh, talks about a future of business that's about sharing all kinds of stuff, either via smart and tech-enabled rental or, more boldly, peer-to-peer. Examples across industries -- from music to cars -- show how close we are to this meshy future.Lisa Gansky is the author of The Mesh: Why the Future of Business Is Sharing, and the instigator behind the Mesh Directory (www.meshing.it).");
                    sw.WriteLine("At his carpet company, Ray Anderson has increased sales and doubled profits while turning the traditional take / make / waste. industrial system on its head. In a gentle, understated way, he shares a powerful vision for sustainable commerce.Ray Anderson founded the company that makes covetable Flor carpeting. But behind the fresh design is a decades-deep commitment to sustainable ways of doing business -- culminating in the Mission Zero plan. ");
                    sw.WriteLine("When the dotcom bubble burst, hotelier Chip Conley went in search of a business model based on happiness. In an old friendship with an employee and in the wisdom of a Buddhist king, he learned that success comes from what you count. Chip Conley creates joyful hotels, where he hopes his employees, customers and investors alike can realize their full potential. His books share that philosophy with the wider world");
                    sw.WriteLine("John Gerzema says there's an upside to the recent financial crisis -- the opportunity for positive change. In talk talk, he identifies four major cultural shifts driving new consumer behavior and shows how businesses are evolving to connect with thoughtful spending. (Filmed at TEDxKC.) John Gerzema uses data, analysis and decades of experience to identify trends and develop daring new approaches to advertising");
                    sw.WriteLine("Ten percent of American businesses disappear every year. … It’s far higher than the failure rate of, say, Americans. Ten percent of Americans don’t disappear every year. Which leads us to conclude American businesses fail faster than Americans, and therefore American businesses are evolving faster than Americans");
                    sw.WriteLine("Economics writer Tim Harford studies complex systems -- and finds a surprising link among the successful ones: they were built through trial and error. In this sparkling talk from TEDGlobal 2011, he asks us to embrace our randomness and start making better mistakes.Tim Harford's writings reveal the economic ideas behind everyday experiences");
                    sw.Close();
                    aFile.Close();
                }
            }

            if (length == 4 || length == 3 || length == 1)
            {
                if (Next == "Religious")
                {
                    Religious_1 frm = new Religious_1(NewUserSlections);
                    frm.Show();
                }

                else if (Next == "Environment")
                {
                    Environment frm = new Environment(NewUserSlections);
                    frm.Show();
                }

                else if (Next == "Sports")
                {
                    Sports_1 frm = new Sports_1(NewUserSlections);
                    frm.Show();
                }

                else if (Next == "Politics")
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
