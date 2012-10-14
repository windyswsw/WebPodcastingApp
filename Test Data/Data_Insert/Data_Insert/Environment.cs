using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data_Insert.Entertainment;
using Data_Insert.Main;
using System.IO;
using Data_Insert.Sports;

namespace Data_Insert
{
    public partial class Environment : Form
    {
        public Environment()
        {
            InitializeComponent();
        }

         string UserSlections = "";
         string Watch_fileLoc = Program._path + "Watch.txt";
         string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Environment(string strSelections)
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
                    sw.WriteLine("Human growth has strained the Earth's resources, but as Johan Rockstrom reminds us, our advances also give us the science to recognize this and change behavior. His research has found nine planetary boundaries that can guide us in protecting our planet's many overlapping ecosystems. If Earth is a self-regulating system, it's clear that human activity is capable of disrupting it. Johan Rockstrom has led a team of scientists to define the nine Earth systems that need to be kept within bounds for Earth to keep itself in balance");
                    sw.WriteLine("Louise Fresco shows us why we should celebrate mass-produced, supermarket-style white bread. She says environmentally sound mass production will feed the world, yet leave a role for small bakeries and traditional methods. A powerful thinker and globe-trotting advisor on sustainability, Louise Fresco says it's time to think of food as a topic of social and economic importance on par with oil -- that responsible agriculture and food consumption are crucial to world stability");
                    sw.WriteLine("In James Howard Kunstler's view, public spaces should be inspired centers of civic life and the physical manifestation of the common good. Instead, he argues, what we have in America is a nation of places not worth caring about. James Howard Kunstler may be the world’s most outspoken critic of suburban sprawl. He believes the end of the fossil fuels era will soon force a return to smaller-scale, agrarian communities -- and an overhaul of the most destructive features of postwar society.");
                    sw.WriteLine("Here's a powerful provocation from artist Jae Rhim Lee. Can we commit our bodies to a cleaner, greener Earth, even after death? Naturally -- using a special burial suit seeded with pollution-gobbling mushrooms. Yes, this just might be the strangest TEDTalk you'll ever see ... Artist and TED Fellow Jae Rhim Lee re-imagines the relationships between the body and the world");
                    sw.WriteLine("The gharial and king cobra are two of India's most iconic reptiles, and they're endangered because of polluted waterways. Conservationist Romulus Whitaker shows rare footage of these magnificent animals and urges us to save the rivers that sustain their lives and our own.Romulus Whitaker is a scientist and conservationist who slings around the globe to study and protect reptiles. ");
                    sw.WriteLine("Speaking as both an astronomer and a concerned member of the human race, Sir Martin Rees examines our planet and its future from a cosmic perspective. He urges action to prevent dark consequences from our scientific and technological development. Martin Rees, one of the world's most eminent astronomers, is a professor of cosmology and astrophysics at the University of Cambridge and the UK's Astronomer Royal. He is one of our key thinkers on the future of humanity in the cosmos.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Human growth has strained the Earth's resources, but as Johan Rockstrom reminds us, our advances also give us the science to recognize this and change behavior. His research has found nine planetary boundaries that can guide us in protecting our planet's many overlapping ecosystems. If Earth is a self-regulating system, it's clear that human activity is capable of disrupting it. Johan Rockstrom has led a team of scientists to define the nine Earth systems that need to be kept within bounds for Earth to keep itself in balance");
                    sw.WriteLine("Louise Fresco shows us why we should celebrate mass-produced, supermarket-style white bread. She says environmentally sound mass production will feed the world, yet leave a role for small bakeries and traditional methods. A powerful thinker and globe-trotting advisor on sustainability, Louise Fresco says it's time to think of food as a topic of social and economic importance on par with oil -- that responsible agriculture and food consumption are crucial to world stability");
                    sw.WriteLine("In James Howard Kunstler's view, public spaces should be inspired centers of civic life and the physical manifestation of the common good. Instead, he argues, what we have in America is a nation of places not worth caring about. James Howard Kunstler may be the world’s most outspoken critic of suburban sprawl. He believes the end of the fossil fuels era will soon force a return to smaller-scale, agrarian communities -- and an overhaul of the most destructive features of postwar society.");
                    sw.WriteLine("Here's a powerful provocation from artist Jae Rhim Lee. Can we commit our bodies to a cleaner, greener Earth, even after death? Naturally -- using a special burial suit seeded with pollution-gobbling mushrooms. Yes, this just might be the strangest TEDTalk you'll ever see ... Artist and TED Fellow Jae Rhim Lee re-imagines the relationships between the body and the world");
                    sw.WriteLine("The gharial and king cobra are two of India's most iconic reptiles, and they're endangered because of polluted waterways. Conservationist Romulus Whitaker shows rare footage of these magnificent animals and urges us to save the rivers that sustain their lives and our own.Romulus Whitaker is a scientist and conservationist who slings around the globe to study and protect reptiles. ");
                    sw.WriteLine("Speaking as both an astronomer and a concerned member of the human race, Sir Martin Rees examines our planet and its future from a cosmic perspective. He urges action to prevent dark consequences from our scientific and technological development. Martin Rees, one of the world's most eminent astronomers, is a professor of cosmology and astrophysics at the University of Cambridge and the UK's Astronomer Royal. He is one of our key thinkers on the future of humanity in the cosmos.");
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
                    sw.WriteLine("Human growth has strained the Earth's resources, but as Johan Rockstrom reminds us, our advances also give us the science to recognize this and change behavior. His research has found nine planetary boundaries that can guide us in protecting our planet's many overlapping ecosystems. If Earth is a self-regulating system, it's clear that human activity is capable of disrupting it. Johan Rockstrom has led a team of scientists to define the nine Earth systems that need to be kept within bounds for Earth to keep itself in balance");
                    sw.WriteLine("Louise Fresco shows us why we should celebrate mass-produced, supermarket-style white bread. She says environmentally sound mass production will feed the world, yet leave a role for small bakeries and traditional methods. A powerful thinker and globe-trotting advisor on sustainability, Louise Fresco says it's time to think of food as a topic of social and economic importance on par with oil -- that responsible agriculture and food consumption are crucial to world stability");
                    sw.WriteLine("In James Howard Kunstler's view, public spaces should be inspired centers of civic life and the physical manifestation of the common good. Instead, he argues, what we have in America is a nation of places not worth caring about. James Howard Kunstler may be the world’s most outspoken critic of suburban sprawl. He believes the end of the fossil fuels era will soon force a return to smaller-scale, agrarian communities -- and an overhaul of the most destructive features of postwar society.");
                    sw.WriteLine("Here's a powerful provocation from artist Jae Rhim Lee. Can we commit our bodies to a cleaner, greener Earth, even after death? Naturally -- using a special burial suit seeded with pollution-gobbling mushrooms. Yes, this just might be the strangest TEDTalk you'll ever see ... Artist and TED Fellow Jae Rhim Lee re-imagines the relationships between the body and the world");
                    sw.WriteLine("The gharial and king cobra are two of India's most iconic reptiles, and they're endangered because of polluted waterways. Conservationist Romulus Whitaker shows rare footage of these magnificent animals and urges us to save the rivers that sustain their lives and our own.Romulus Whitaker is a scientist and conservationist who slings around the globe to study and protect reptiles. ");
                    sw.WriteLine("Speaking as both an astronomer and a concerned member of the human race, Sir Martin Rees examines our planet and its future from a cosmic perspective. He urges action to prevent dark consequences from our scientific and technological development. Martin Rees, one of the world's most eminent astronomers, is a professor of cosmology and astrophysics at the University of Cambridge and the UK's Astronomer Royal. He is one of our key thinkers on the future of humanity in the cosmos.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Human growth has strained the Earth's resources, but as Johan Rockstrom reminds us, our advances also give us the science to recognize this and change behavior. His research has found nine planetary boundaries that can guide us in protecting our planet's many overlapping ecosystems. If Earth is a self-regulating system, it's clear that human activity is capable of disrupting it. Johan Rockstrom has led a team of scientists to define the nine Earth systems that need to be kept within bounds for Earth to keep itself in balance");
                    sw.WriteLine("Louise Fresco shows us why we should celebrate mass-produced, supermarket-style white bread. She says environmentally sound mass production will feed the world, yet leave a role for small bakeries and traditional methods. A powerful thinker and globe-trotting advisor on sustainability, Louise Fresco says it's time to think of food as a topic of social and economic importance on par with oil -- that responsible agriculture and food consumption are crucial to world stability");
                    sw.WriteLine("In James Howard Kunstler's view, public spaces should be inspired centers of civic life and the physical manifestation of the common good. Instead, he argues, what we have in America is a nation of places not worth caring about. James Howard Kunstler may be the world’s most outspoken critic of suburban sprawl. He believes the end of the fossil fuels era will soon force a return to smaller-scale, agrarian communities -- and an overhaul of the most destructive features of postwar society.");
                    sw.WriteLine("Here's a powerful provocation from artist Jae Rhim Lee. Can we commit our bodies to a cleaner, greener Earth, even after death? Naturally -- using a special burial suit seeded with pollution-gobbling mushrooms. Yes, this just might be the strangest TEDTalk you'll ever see ... Artist and TED Fellow Jae Rhim Lee re-imagines the relationships between the body and the world");
                    sw.WriteLine("The gharial and king cobra are two of India's most iconic reptiles, and they're endangered because of polluted waterways. Conservationist Romulus Whitaker shows rare footage of these magnificent animals and urges us to save the rivers that sustain their lives and our own.Romulus Whitaker is a scientist and conservationist who slings around the globe to study and protect reptiles. ");
                    sw.WriteLine("Speaking as both an astronomer and a concerned member of the human race, Sir Martin Rees examines our planet and its future from a cosmic perspective. He urges action to prevent dark consequences from our scientific and technological development. Martin Rees, one of the world's most eminent astronomers, is a professor of cosmology and astrophysics at the University of Cambridge and the UK's Astronomer Royal. He is one of our key thinkers on the future of humanity in the cosmos.");
                    sw.Close();
                    aFile.Close();
                }
            }

            if (length == 4 || length == 3 || length == 1)
            {
                if (Next == "Sports")
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
