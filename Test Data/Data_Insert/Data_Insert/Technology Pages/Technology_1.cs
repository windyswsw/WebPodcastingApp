using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Data_Insert
{
    public partial class Technology_1 : Form
    {
        public Technology_1()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";

        public Technology_1(string strSelections)
        {
            InitializeComponent();
            UserSlections = strSelections;
        }


        private void Technology_btn1_Click(object sender, EventArgs e)
        {
            if (RB1.Checked)
            {
                if (!File.Exists(Watch_fileLoc))
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Peter Molyneux demos Milo, a hotly anticipated video game for Microsoft's Kinect controller. Perceptive and impressionable like a real 11-year-old, the virtual boy watches, listens and learns -- recognizing and responding to you. The head of Microsoft's European games division, Peter Molyneux is building an astonishing new virtual friend who interacts with you");
                    sw.WriteLine("Educator Roy Gould and researcher Curtis Wong show a sneak preview of Microsoft’s WorldWide Telescope, which compiles images from telescopes and satellites to build a comprehensive, interactive view of our universe. A researcher at the Harvard Center for Astrophysics, Roy Gould gives the first public demo of the World Wide Telescope, a powerful new web-based tool for exploring the universe, developed by TEDster Curtis Wong and his team at Microsoft");
                    sw.WriteLine(" Daniel Makoski from Microsoft’s User Experience Studio within Microsoft u2019s Advanced Technology Center in Beijing is going to be talking about the death of the mouse and keyboard at Spark09 in Beijing this month. I think this is a great step, since the cost of production will drop signficantly once the Chinese grab hold of it. Also, since the Chinese language is based on pictorials, not characteris, this kind of touch technology could really benefit them more than the West.");
                    sw.WriteLine("Microsoft's Stephen Lawler gives a whirlwind tour of Virtual Earth, moving up, down and through its hyper-real cityscapes with dazzlingly fluidity, a remarkable feat that requires staggering amounts of data to bring into focus. Stephen Lawler and the Virtual Earth team have created an addictively interactive 3D world that is poised to reinvent our view of advertising, gaming, weather/traffic reporting, instant messaging and more");
                    sw.WriteLine("In a demo that drew gasps at TED2010, Blaise Aguera y Arcas demos new augmented-reality  mapping technology from Microsoft. Blaise Agüera y Arcas is the architect of Bing Maps at Microsoft, building augmented reality into searchable maps. He's also the co-creator of Photosynth, software that assembles static photos into a synergy of zoomable, navigatable spaces.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Peter Molyneux demos Milo, a hotly anticipated video game for Microsoft's Kinect controller. Perceptive and impressionable like a real 11-year-old, the virtual boy watches, listens and learns -- recognizing and responding to you. The head of Microsoft's European games division, Peter Molyneux is building an astonishing new virtual friend who interacts with you");
                    sw.WriteLine("Educator Roy Gould and researcher Curtis Wong show a sneak preview of Microsoft’s WorldWide Telescope, which compiles images from telescopes and satellites to build a comprehensive, interactive view of our universe. A researcher at the Harvard Center for Astrophysics, Roy Gould gives the first public demo of the World Wide Telescope, a powerful new web-based tool for exploring the universe, developed by TEDster Curtis Wong and his team at Microsoft");
                    sw.WriteLine(" Daniel Makoski from Microsoft’s User Experience Studio within Microsoft u2019s Advanced Technology Center in Beijing is going to be talking about the death of the mouse and keyboard at Spark09 in Beijing this month. I think this is a great step, since the cost of production will drop signficantly once the Chinese grab hold of it. Also, since the Chinese language is based on pictorials, not characteris, this kind of touch technology could really benefit them more than the West.");
                    sw.WriteLine("Microsoft's Stephen Lawler gives a whirlwind tour of Virtual Earth, moving up, down and through its hyper-real cityscapes with dazzlingly fluidity, a remarkable feat that requires staggering amounts of data to bring into focus. Stephen Lawler and the Virtual Earth team have created an addictively interactive 3D world that is poised to reinvent our view of advertising, gaming, weather/traffic reporting, instant messaging and more");
                    sw.WriteLine("In a demo that drew gasps at TED2010, Blaise Aguera y Arcas demos new augmented-reality  mapping technology from Microsoft. Blaise Agüera y Arcas is the architect of Bing Maps at Microsoft, building augmented reality into searchable maps. He's also the co-creator of Photosynth, software that assembles static photos into a synergy of zoomable, navigatable spaces.");
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
                    sw.WriteLine("Peter Molyneux demos Milo, a hotly anticipated video game for Microsoft's Kinect controller. Perceptive and impressionable like a real 11-year-old, the virtual boy watches, listens and learns -- recognizing and responding to you. The head of Microsoft's European games division, Peter Molyneux is building an astonishing new virtual friend who interacts with you");
                    sw.WriteLine("Educator Roy Gould and researcher Curtis Wong show a sneak preview of Microsoft’s WorldWide Telescope, which compiles images from telescopes and satellites to build a comprehensive, interactive view of our universe. A researcher at the Harvard Center for Astrophysics, Roy Gould gives the first public demo of the World Wide Telescope, a powerful new web-based tool for exploring the universe, developed by TEDster Curtis Wong and his team at Microsoft");
                    sw.WriteLine(" Daniel Makoski from Microsoft’s User Experience Studio within Microsoft u2019s Advanced Technology Center in Beijing is going to be talking about the death of the mouse and keyboard at Spark09 in Beijing this month. I think this is a great step, since the cost of production will drop signficantly once the Chinese grab hold of it. Also, since the Chinese language is based on pictorials, not characteris, this kind of touch technology could really benefit them more than the West.");
                    sw.WriteLine("Microsoft's Stephen Lawler gives a whirlwind tour of Virtual Earth, moving up, down and through its hyper-real cityscapes with dazzlingly fluidity, a remarkable feat that requires staggering amounts of data to bring into focus. Stephen Lawler and the Virtual Earth team have created an addictively interactive 3D world that is poised to reinvent our view of advertising, gaming, weather/traffic reporting, instant messaging and more");
                    sw.WriteLine("In a demo that drew gasps at TED2010, Blaise Aguera y Arcas demos new augmented-reality  mapping technology from Microsoft. Blaise Agüera y Arcas is the architect of Bing Maps at Microsoft, building augmented reality into searchable maps. He's also the co-creator of Photosynth, software that assembles static photos into a synergy of zoomable, navigatable spaces.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Peter Molyneux demos Milo, a hotly anticipated video game for Microsoft's Kinect controller. Perceptive and impressionable like a real 11-year-old, the virtual boy watches, listens and learns -- recognizing and responding to you. The head of Microsoft's European games division, Peter Molyneux is building an astonishing new virtual friend who interacts with you");
                    sw.WriteLine("Educator Roy Gould and researcher Curtis Wong show a sneak preview of Microsoft’s WorldWide Telescope, which compiles images from telescopes and satellites to build a comprehensive, interactive view of our universe. A researcher at the Harvard Center for Astrophysics, Roy Gould gives the first public demo of the World Wide Telescope, a powerful new web-based tool for exploring the universe, developed by TEDster Curtis Wong and his team at Microsoft");
                    sw.WriteLine(" Daniel Makoski from Microsoft’s User Experience Studio within Microsoft u2019s Advanced Technology Center in Beijing is going to be talking about the death of the mouse and keyboard at Spark09 in Beijing this month. I think this is a great step, since the cost of production will drop signficantly once the Chinese grab hold of it. Also, since the Chinese language is based on pictorials, not characteris, this kind of touch technology could really benefit them more than the West.");
                    sw.WriteLine("Microsoft's Stephen Lawler gives a whirlwind tour of Virtual Earth, moving up, down and through its hyper-real cityscapes with dazzlingly fluidity, a remarkable feat that requires staggering amounts of data to bring into focus. Stephen Lawler and the Virtual Earth team have created an addictively interactive 3D world that is poised to reinvent our view of advertising, gaming, weather/traffic reporting, instant messaging and more");
                    sw.WriteLine("In a demo that drew gasps at TED2010, Blaise Aguera y Arcas demos new augmented-reality  mapping technology from Microsoft. Blaise Agüera y Arcas is the architect of Bing Maps at Microsoft, building augmented reality into searchable maps. He's also the co-creator of Photosynth, software that assembles static photos into a synergy of zoomable, navigatable spaces.");
                    sw.Close();
                    aFile.Close();
                }
            }

                Technology_2 frm = new Technology_2(UserSlections);
                frm.Show();
                this.Close();
            }

        }
    }

