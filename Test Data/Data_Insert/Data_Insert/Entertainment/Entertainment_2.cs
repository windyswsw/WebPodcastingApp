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
using Data_Insert.Sports;

namespace Data_Insert.Entertainment
{
    public partial class Entertainment_2 : Form
    {
        public Entertainment_2()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Entertainment_2(string strSelections)
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
                    sw.WriteLine("James Cameron's big-budget (and even bigger-grossing) films create unreal worlds all their own. In this talk, he reveals his childhood fascination with the fantastic  from reading science fiction to deep-sea diving and how it ultimately drove the success of his blockbuster hits Aliens,The Terminator,Titanic and Avatar.James Cameron is the director of Avatar, Titanic, Terminator, The Abyss and many other blockbusters. While his outsize films push the bounds of technology, they're always anchored in human stories with heart and soul.");
                    sw.WriteLine("Film producer Jeff Skoll (An Inconvenient Truth) talks about his film company, Participant Productions, and the people who've inspired him to do good.Jeff Skoll was the first president of eBay; he used his dot-com fortune to found the film house Participant Productions, making movies to inspire social change, including Syriana; Good Night, and Good Luck; Murderball; An Inconvenient Trut");
                    sw.WriteLine("Movies have the power to create a shared narrative experience and to shape memories and worldviews. British film director Beeban Kidron invokes iconic film scenes -- from Miracle in Milan to Boyz n the Hood -- as she shows how her group FILMCLUB shares great films with kids. Beeban Kidron directed Bridget Jones: The Edge of Reason and Oranges Are Not the Only Fruit. She also cofounded FILMCLUB, a charity for students devoted to the art of storytelling through film");
                    sw.WriteLine("Nathaniel Kahn shares clips from his documentary My Architect, about his quest to understand his father, the legendary architect Louis Kahn. It's a film with meaning to anyone who seeks to understand the relationship between art and love. Nathaniel Kahn is an Oscar- and Emmy-nominated maker of documentary films. His journey to understand his distant father -- the legendary modern architect Louis Kahn -- became the film My Architect.");
                    sw.WriteLine("Every act of communication is, in some way, an act of translation. Onstage at TEDxRainier, writer Chris Bliss thinks hard about the way that great comedy can translate deep truths for a mass audience. (Filmed at TEDxRainier.) Chris Bliss explores the inherent challenge of communication, and how comedy opens paths to new perspectives.");
                    sw.WriteLine("At TED2012, filmmaker Karen Bass shares some of the astonishing nature footage she's shot for the BBC and National Geographic -- including brand-new, previously unseen footage of the tube-lipped nectar bat, who feeds in a rather unusual way … Karen Bass has traveled the world to explore and capture footage from every environment across the Earth");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("James Cameron's big-budget (and even bigger-grossing) films create unreal worlds all their own. In this talk, he reveals his childhood fascination with the fantastic  from reading science fiction to deep-sea diving and how it ultimately drove the success of his blockbuster hits Aliens,The Terminator,Titanic and Avatar.James Cameron is the director of Avatar, Titanic, Terminator, The Abyss and many other blockbusters. While his outsize films push the bounds of technology, they're always anchored in human stories with heart and soul.");
                    sw.WriteLine("Film producer Jeff Skoll (An Inconvenient Truth) talks about his film company, Participant Productions, and the people who've inspired him to do good.Jeff Skoll was the first president of eBay; he used his dot-com fortune to found the film house Participant Productions, making movies to inspire social change, including Syriana; Good Night, and Good Luck; Murderball; An Inconvenient Trut");
                    sw.WriteLine("Movies have the power to create a shared narrative experience and to shape memories and worldviews. British film director Beeban Kidron invokes iconic film scenes -- from Miracle in Milan to Boyz n the Hood -- as she shows how her group FILMCLUB shares great films with kids. Beeban Kidron directed Bridget Jones: The Edge of Reason and Oranges Are Not the Only Fruit. She also cofounded FILMCLUB, a charity for students devoted to the art of storytelling through film");
                    sw.WriteLine("Nathaniel Kahn shares clips from his documentary My Architect, about his quest to understand his father, the legendary architect Louis Kahn. It's a film with meaning to anyone who seeks to understand the relationship between art and love. Nathaniel Kahn is an Oscar- and Emmy-nominated maker of documentary films. His journey to understand his distant father -- the legendary modern architect Louis Kahn -- became the film My Architect.");
                    sw.WriteLine("Every act of communication is, in some way, an act of translation. Onstage at TEDxRainier, writer Chris Bliss thinks hard about the way that great comedy can translate deep truths for a mass audience. (Filmed at TEDxRainier.) Chris Bliss explores the inherent challenge of communication, and how comedy opens paths to new perspectives.");
                    sw.WriteLine("At TED2012, filmmaker Karen Bass shares some of the astonishing nature footage she's shot for the BBC and National Geographic -- including brand-new, previously unseen footage of the tube-lipped nectar bat, who feeds in a rather unusual way … Karen Bass has traveled the world to explore and capture footage from every environment across the Earth");
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
                    sw.WriteLine("James Cameron's big-budget (and even bigger-grossing) films create unreal worlds all their own. In this talk, he reveals his childhood fascination with the fantastic  from reading science fiction to deep-sea diving and how it ultimately drove the success of his blockbuster hits Aliens,The Terminator,Titanic and Avatar.James Cameron is the director of Avatar, Titanic, Terminator, The Abyss and many other blockbusters. While his outsize films push the bounds of technology, they're always anchored in human stories with heart and soul.");
                    sw.WriteLine("Film producer Jeff Skoll (An Inconvenient Truth) talks about his film company, Participant Productions, and the people who've inspired him to do good.Jeff Skoll was the first president of eBay; he used his dot-com fortune to found the film house Participant Productions, making movies to inspire social change, including Syriana; Good Night, and Good Luck; Murderball; An Inconvenient Trut");
                    sw.WriteLine("Movies have the power to create a shared narrative experience and to shape memories and worldviews. British film director Beeban Kidron invokes iconic film scenes -- from Miracle in Milan to Boyz n the Hood -- as she shows how her group FILMCLUB shares great films with kids. Beeban Kidron directed Bridget Jones: The Edge of Reason and Oranges Are Not the Only Fruit. She also cofounded FILMCLUB, a charity for students devoted to the art of storytelling through film");
                    sw.WriteLine("Nathaniel Kahn shares clips from his documentary My Architect, about his quest to understand his father, the legendary architect Louis Kahn. It's a film with meaning to anyone who seeks to understand the relationship between art and love. Nathaniel Kahn is an Oscar- and Emmy-nominated maker of documentary films. His journey to understand his distant father -- the legendary modern architect Louis Kahn -- became the film My Architect.");
                    sw.WriteLine("Every act of communication is, in some way, an act of translation. Onstage at TEDxRainier, writer Chris Bliss thinks hard about the way that great comedy can translate deep truths for a mass audience. (Filmed at TEDxRainier.) Chris Bliss explores the inherent challenge of communication, and how comedy opens paths to new perspectives.");
                    sw.WriteLine("At TED2012, filmmaker Karen Bass shares some of the astonishing nature footage she's shot for the BBC and National Geographic -- including brand-new, previously unseen footage of the tube-lipped nectar bat, who feeds in a rather unusual way … Karen Bass has traveled the world to explore and capture footage from every environment across the Earth");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                  sw.WriteLine("James Cameron's big-budget (and even bigger-grossing) films create unreal worlds all their own. In this talk, he reveals his childhood fascination with the fantastic  from reading science fiction to deep-sea diving and how it ultimately drove the success of his blockbuster hits Aliens,The Terminator,Titanic and Avatar.James Cameron is the director of Avatar, Titanic, Terminator, The Abyss and many other blockbusters. While his outsize films push the bounds of technology, they're always anchored in human stories with heart and soul.");
                    sw.WriteLine("Film producer Jeff Skoll (An Inconvenient Truth) talks about his film company, Participant Productions, and the people who've inspired him to do good.Jeff Skoll was the first president of eBay; he used his dot-com fortune to found the film house Participant Productions, making movies to inspire social change, including Syriana; Good Night, and Good Luck; Murderball; An Inconvenient Trut");
                    sw.WriteLine("Movies have the power to create a shared narrative experience and to shape memories and worldviews. British film director Beeban Kidron invokes iconic film scenes -- from Miracle in Milan to Boyz n the Hood -- as she shows how her group FILMCLUB shares great films with kids. Beeban Kidron directed Bridget Jones: The Edge of Reason and Oranges Are Not the Only Fruit. She also cofounded FILMCLUB, a charity for students devoted to the art of storytelling through film");
                    sw.WriteLine("Nathaniel Kahn shares clips from his documentary My Architect, about his quest to understand his father, the legendary architect Louis Kahn. It's a film with meaning to anyone who seeks to understand the relationship between art and love. Nathaniel Kahn is an Oscar- and Emmy-nominated maker of documentary films. His journey to understand his distant father -- the legendary modern architect Louis Kahn -- became the film My Architect.");
                    sw.WriteLine("Every act of communication is, in some way, an act of translation. Onstage at TEDxRainier, writer Chris Bliss thinks hard about the way that great comedy can translate deep truths for a mass audience. (Filmed at TEDxRainier.) Chris Bliss explores the inherent challenge of communication, and how comedy opens paths to new perspectives.");
                    sw.WriteLine("At TED2012, filmmaker Karen Bass shares some of the astonishing nature footage she's shot for the BBC and National Geographic -- including brand-new, previously unseen footage of the tube-lipped nectar bat, who feeds in a rather unusual way … Karen Bass has traveled the world to explore and capture footage from every environment across the Earth");
                    sw.Close();
                    aFile.Close();
                }
            }

             if (length == 4 || length == 3 || length == 1)
             {

                 if (Next == "Business")
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

