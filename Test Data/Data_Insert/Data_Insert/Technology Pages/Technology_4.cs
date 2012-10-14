using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Data_Insert.Main;
using Data_Insert.Entertainment;
using Data_Insert.Sports;

namespace Data_Insert
{
    public partial class Technology_4 : Form
    {
        public Technology_4()
        {
            InitializeComponent();
        }

       string UserSlections = "";
       string Watch_fileLoc = Program._path + "Watch.txt";
       string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
       String NewUserSlections = "";
       String Next = "";
       int length = 0;

        public Technology_4(string strSelections)
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

        private void Technology_btn1_Click(object sender, EventArgs e)
        {
            if (RB1.Checked)
            {
                if (!File.Exists(Watch_fileLoc))
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Researcher Kwabena Boahen is looking for ways to mimic the brain's supercomputing powers in silicon -- because the messy, redundant processes inside our heads actually make for a small, light, superfast computer. Kwabena Boahen wants to understand how brains work -- and to build a computer that works like the brain by reverse-engineering the nervous system. His group at Stanford is developing Neurogrid, a hardware platform that will emulate the cortex’s inner workings");
                    sw.WriteLine("Historian George Dyson tells stories from the birth of the modern computer -- from its 17th-century origins to the hilarious notebooks of some early computer engineers.A historian and philosopher of science, George Dyson takes a clear-eyed and deeply researched view of our recent scientific past -- while showing where it may lead us.");
                    sw.WriteLine(" David McCandless turns complex data sets (like worldwide military spending, media buzz, Facebook status updates) into beautiful, simple diagrams that tease out unseen patterns and connections. Good design, he suggests, is the best way to navigate information glut -- and it may just change the way we see the world. David McCandless draws beautiful conclusions from complex datasets -- thus revealing unexpected insights into our world");
                    sw.WriteLine("With all the intensity and brilliance for which he is known, Alan Kay envisions better techniques for teaching kids by using computers to illustrate experience in ways -– mathematically and scientifically -- that only computers can. One of the true luminaries of personal computing, Alan Kay conceived of laptops and graphical interfaces years before they were realized. At XeroxPARC, Apple, HP and Disney, he has developed tools for improving the mind.");
                    sw.WriteLine("Technology is evolving us, says Amber Case, as we become a screen-staring, button-clicking new version of homo sapiens. We now rely on external brains (cell phones and computers) to communicate, remember, even live out secondary lives. But will these machines ultimately connect or conquer us? Case offers surprising insight into our cyborg selves. Amber Case studies the symbiotic interactions between humans and machines -- and considers how our values and culture are being shaped by living lives increasingly mediated by high technology");
                    sw.WriteLine("Computer science began in the '30s ... the 1830s. John Graham-Cumming tells the story of Charles Babbage's mechanical, steam-powered analytical engine and how Ada Lovelace, mathematician and daughter of Lord Byron, saw beyond its simple computational abilities to imagine the future of computers.  (Recorded at TEDxImperialCollege) Computer programmer John Graham-Cumming keeps geek history alive by raising awareness for it's heroes and their inventions");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Researcher Kwabena Boahen is looking for ways to mimic the brain's supercomputing powers in silicon -- because the messy, redundant processes inside our heads actually make for a small, light, superfast computer. Kwabena Boahen wants to understand how brains work -- and to build a computer that works like the brain by reverse-engineering the nervous system. His group at Stanford is developing Neurogrid, a hardware platform that will emulate the cortex’s inner workings");
                    sw.WriteLine("Historian George Dyson tells stories from the birth of the modern computer -- from its 17th-century origins to the hilarious notebooks of some early computer engineers.A historian and philosopher of science, George Dyson takes a clear-eyed and deeply researched view of our recent scientific past -- while showing where it may lead us.");
                    sw.WriteLine(" David McCandless turns complex data sets (like worldwide military spending, media buzz, Facebook status updates) into beautiful, simple diagrams that tease out unseen patterns and connections. Good design, he suggests, is the best way to navigate information glut -- and it may just change the way we see the world. David McCandless draws beautiful conclusions from complex datasets -- thus revealing unexpected insights into our world");
                    sw.WriteLine("With all the intensity and brilliance for which he is known, Alan Kay envisions better techniques for teaching kids by using computers to illustrate experience in ways -– mathematically and scientifically -- that only computers can. One of the true luminaries of personal computing, Alan Kay conceived of laptops and graphical interfaces years before they were realized. At XeroxPARC, Apple, HP and Disney, he has developed tools for improving the mind.");
                    sw.WriteLine("Technology is evolving us, says Amber Case, as we become a screen-staring, button-clicking new version of homo sapiens. We now rely on external brains (cell phones and computers) to communicate, remember, even live out secondary lives. But will these machines ultimately connect or conquer us? Case offers surprising insight into our cyborg selves. Amber Case studies the symbiotic interactions between humans and machines -- and considers how our values and culture are being shaped by living lives increasingly mediated by high technology");
                    sw.WriteLine("Computer science began in the '30s ... the 1830s. John Graham-Cumming tells the story of Charles Babbage's mechanical, steam-powered analytical engine and how Ada Lovelace, mathematician and daughter of Lord Byron, saw beyond its simple computational abilities to imagine the future of computers.  (Recorded at TEDxImperialCollege) Computer programmer John Graham-Cumming keeps geek history alive by raising awareness for it's heroes and their inventions");
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
                    sw.WriteLine("Researcher Kwabena Boahen is looking for ways to mimic the brain's supercomputing powers in silicon -- because the messy, redundant processes inside our heads actually make for a small, light, superfast computer. Kwabena Boahen wants to understand how brains work -- and to build a computer that works like the brain by reverse-engineering the nervous system. His group at Stanford is developing Neurogrid, a hardware platform that will emulate the cortex’s inner workings");
                    sw.WriteLine("Historian George Dyson tells stories from the birth of the modern computer -- from its 17th-century origins to the hilarious notebooks of some early computer engineers.A historian and philosopher of science, George Dyson takes a clear-eyed and deeply researched view of our recent scientific past -- while showing where it may lead us.");
                    sw.WriteLine(" David McCandless turns complex data sets (like worldwide military spending, media buzz, Facebook status updates) into beautiful, simple diagrams that tease out unseen patterns and connections. Good design, he suggests, is the best way to navigate information glut -- and it may just change the way we see the world. David McCandless draws beautiful conclusions from complex datasets -- thus revealing unexpected insights into our world");
                    sw.WriteLine("With all the intensity and brilliance for which he is known, Alan Kay envisions better techniques for teaching kids by using computers to illustrate experience in ways -– mathematically and scientifically -- that only computers can. One of the true luminaries of personal computing, Alan Kay conceived of laptops and graphical interfaces years before they were realized. At XeroxPARC, Apple, HP and Disney, he has developed tools for improving the mind.");
                    sw.WriteLine("Technology is evolving us, says Amber Case, as we become a screen-staring, button-clicking new version of homo sapiens. We now rely on external brains (cell phones and computers) to communicate, remember, even live out secondary lives. But will these machines ultimately connect or conquer us? Case offers surprising insight into our cyborg selves. Amber Case studies the symbiotic interactions between humans and machines -- and considers how our values and culture are being shaped by living lives increasingly mediated by high technology");
                    sw.WriteLine("Computer science began in the '30s ... the 1830s. John Graham-Cumming tells the story of Charles Babbage's mechanical, steam-powered analytical engine and how Ada Lovelace, mathematician and daughter of Lord Byron, saw beyond its simple computational abilities to imagine the future of computers.  (Recorded at TEDxImperialCollege) Computer programmer John Graham-Cumming keeps geek history alive by raising awareness for it's heroes and their inventions");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Researcher Kwabena Boahen is looking for ways to mimic the brain's supercomputing powers in silicon -- because the messy, redundant processes inside our heads actually make for a small, light, superfast computer. Kwabena Boahen wants to understand how brains work -- and to build a computer that works like the brain by reverse-engineering the nervous system. His group at Stanford is developing Neurogrid, a hardware platform that will emulate the cortex’s inner workings");
                    sw.WriteLine("Historian George Dyson tells stories from the birth of the modern computer -- from its 17th-century origins to the hilarious notebooks of some early computer engineers.A historian and philosopher of science, George Dyson takes a clear-eyed and deeply researched view of our recent scientific past -- while showing where it may lead us.");
                    sw.WriteLine(" David McCandless turns complex data sets (like worldwide military spending, media buzz, Facebook status updates) into beautiful, simple diagrams that tease out unseen patterns and connections. Good design, he suggests, is the best way to navigate information glut -- and it may just change the way we see the world. David McCandless draws beautiful conclusions from complex datasets -- thus revealing unexpected insights into our world");
                    sw.WriteLine("With all the intensity and brilliance for which he is known, Alan Kay envisions better techniques for teaching kids by using computers to illustrate experience in ways -– mathematically and scientifically -- that only computers can. One of the true luminaries of personal computing, Alan Kay conceived of laptops and graphical interfaces years before they were realized. At XeroxPARC, Apple, HP and Disney, he has developed tools for improving the mind.");
                    sw.WriteLine("Technology is evolving us, says Amber Case, as we become a screen-staring, button-clicking new version of homo sapiens. We now rely on external brains (cell phones and computers) to communicate, remember, even live out secondary lives. But will these machines ultimately connect or conquer us? Case offers surprising insight into our cyborg selves. Amber Case studies the symbiotic interactions between humans and machines -- and considers how our values and culture are being shaped by living lives increasingly mediated by high technology");
                    sw.WriteLine("Computer science began in the '30s ... the 1830s. John Graham-Cumming tells the story of Charles Babbage's mechanical, steam-powered analytical engine and how Ada Lovelace, mathematician and daughter of Lord Byron, saw beyond its simple computational abilities to imagine the future of computers.  (Recorded at TEDxImperialCollege) Computer programmer John Graham-Cumming keeps geek history alive by raising awareness for it's heroes and their inventions");
                    sw.Close();
                    aFile.Close();
                }
            }

            if (length == 4 || length == 3 || length == 1)
            {
                if (Next == "Entertainment")
                {
                    Entertainment_1 frm = new Entertainment_1(NewUserSlections);
                    frm.Show();
                }

                else if (Next == "Business")
                {
                    Business frm = new Business(NewUserSlections);
                    frm.Show();
                }

                else if (Next == "Religious")
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
