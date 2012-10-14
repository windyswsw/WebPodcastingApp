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
    public partial class Technology_3 : Form
    {
        public Technology_3()
        {
            InitializeComponent();
        }

          string UserSlections = "";
          string Watch_fileLoc = Program._path + "Watch.txt";
          string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";

        public Technology_3(string strSelections)
        {
            InitializeComponent();
            UserSlections = strSelections;
        }

        private void Technology_btn1_Click_1(object sender, EventArgs e)
        {
            if (RB1.Checked)
            {
                if (!File.Exists(Watch_fileLoc))
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Create, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Despite multibillion-dollar investments in cybersecurity, one of its root problems has been largely ignored: who are the people who write malicious code? Underworld investigator Misha Glenny profiles several convicted coders from around the world and reaches a startling conclusion. Journalist Misha Glenny leaves no stone unturned (and no failed state unexamined) in his excavation of criminal globalization.");
                    sw.WriteLine("Computer viruses switch from one country to another, from one jurisdiction to another — moving around the world, using the fact that we don't have the capability to globally police operations like this. So the Internet is as if someone [had] given free plane tickets to all the online criminals of the world. It's been 25 years since the first PC virus (Brain A) hit the net, and what was once an annoyance has become a sophisticated tool for crime and espionage. Computer security expert Mikko Hyppönen tells us how we can stop these new viruses from threatening the internet as we know it. As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
                    sw.WriteLine(" The world is becoming increasingly open, and that has implications both bright and dangerous. Marc Goodman paints a portrait of a grave future, in which technology's rapid development could allow crime to take a turn for the worse. Marc Goodman works to prevent future crimes and acts of terrorism, even those security threats not yet invented");
                    sw.WriteLine("The feeling of security and the reality of security don't always match, says computer-security expert Bruce Schneier. In his talk, he explains why we spend billions addressing news story risks, like the security theater now playing at your local airport, while neglecting more probable risks -- and how we can break this pattern. (Filmed at TEDxPSU.) Bruce Schneier thinks hard about security -- as a computer security guru, and as a philosopher of the larger notion of making a safer world ");
                    sw.WriteLine("Cybercrime expert Mikko Hypponen talks us through three types of online attack on our privacy and data -- and only two are considered crimes. Do we blindly trust any future government? Because any right we give away, we give away for good.As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Despite multibillion-dollar investments in cybersecurity, one of its root problems has been largely ignored: who are the people who write malicious code? Underworld investigator Misha Glenny profiles several convicted coders from around the world and reaches a startling conclusion. Journalist Misha Glenny leaves no stone unturned (and no failed state unexamined) in his excavation of criminal globalization.");
                    sw.WriteLine("Computer viruses switch from one country to another, from one jurisdiction to another — moving around the world, using the fact that we don't have the capability to globally police operations like this. So the Internet is as if someone [had] given free plane tickets to all the online criminals of the world. It's been 25 years since the first PC virus (Brain A) hit the net, and what was once an annoyance has become a sophisticated tool for crime and espionage. Computer security expert Mikko Hyppönen tells us how we can stop these new viruses from threatening the internet as we know it. As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
                    sw.WriteLine(" The world is becoming increasingly open, and that has implications both bright and dangerous. Marc Goodman paints a portrait of a grave future, in which technology's rapid development could allow crime to take a turn for the worse. Marc Goodman works to prevent future crimes and acts of terrorism, even those security threats not yet invented");
                    sw.WriteLine("The feeling of security and the reality of security don't always match, says computer-security expert Bruce Schneier. In his talk, he explains why we spend billions addressing news story risks, like the security theater now playing at your local airport, while neglecting more probable risks -- and how we can break this pattern. (Filmed at TEDxPSU.) Bruce Schneier thinks hard about security -- as a computer security guru, and as a philosopher of the larger notion of making a safer world ");
                    sw.WriteLine("Cybercrime expert Mikko Hypponen talks us through three types of online attack on our privacy and data -- and only two are considered crimes. Do we blindly trust any future government? Because any right we give away, we give away for good.As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
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
                    sw.WriteLine("Despite multibillion-dollar investments in cybersecurity, one of its root problems has been largely ignored: who are the people who write malicious code? Underworld investigator Misha Glenny profiles several convicted coders from around the world and reaches a startling conclusion. Journalist Misha Glenny leaves no stone unturned (and no failed state unexamined) in his excavation of criminal globalization.");
                    sw.WriteLine("Computer viruses switch from one country to another, from one jurisdiction to another — moving around the world, using the fact that we don't have the capability to globally police operations like this. So the Internet is as if someone [had] given free plane tickets to all the online criminals of the world. It's been 25 years since the first PC virus (Brain A) hit the net, and what was once an annoyance has become a sophisticated tool for crime and espionage. Computer security expert Mikko Hyppönen tells us how we can stop these new viruses from threatening the internet as we know it. As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
                    sw.WriteLine(" The world is becoming increasingly open, and that has implications both bright and dangerous. Marc Goodman paints a portrait of a grave future, in which technology's rapid development could allow crime to take a turn for the worse. Marc Goodman works to prevent future crimes and acts of terrorism, even those security threats not yet invented");
                    sw.WriteLine("The feeling of security and the reality of security don't always match, says computer-security expert Bruce Schneier. In his talk, he explains why we spend billions addressing news story risks, like the security theater now playing at your local airport, while neglecting more probable risks -- and how we can break this pattern. (Filmed at TEDxPSU.) Bruce Schneier thinks hard about security -- as a computer security guru, and as a philosopher of the larger notion of making a safer world ");
                    sw.WriteLine("Cybercrime expert Mikko Hypponen talks us through three types of online attack on our privacy and data -- and only two are considered crimes. Do we blindly trust any future government? Because any right we give away, we give away for good.As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Despite multibillion-dollar investments in cybersecurity, one of its root problems has been largely ignored: who are the people who write malicious code? Underworld investigator Misha Glenny profiles several convicted coders from around the world and reaches a startling conclusion. Journalist Misha Glenny leaves no stone unturned (and no failed state unexamined) in his excavation of criminal globalization.");
                    sw.WriteLine("Computer viruses switch from one country to another, from one jurisdiction to another — moving around the world, using the fact that we don't have the capability to globally police operations like this. So the Internet is as if someone [had] given free plane tickets to all the online criminals of the world. It's been 25 years since the first PC virus (Brain A) hit the net, and what was once an annoyance has become a sophisticated tool for crime and espionage. Computer security expert Mikko Hyppönen tells us how we can stop these new viruses from threatening the internet as we know it. As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
                    sw.WriteLine(" The world is becoming increasingly open, and that has implications both bright and dangerous. Marc Goodman paints a portrait of a grave future, in which technology's rapid development could allow crime to take a turn for the worse. Marc Goodman works to prevent future crimes and acts of terrorism, even those security threats not yet invented");
                    sw.WriteLine("The feeling of security and the reality of security don't always match, says computer-security expert Bruce Schneier. In his talk, he explains why we spend billions addressing news story risks, like the security theater now playing at your local airport, while neglecting more probable risks -- and how we can break this pattern. (Filmed at TEDxPSU.) Bruce Schneier thinks hard about security -- as a computer security guru, and as a philosopher of the larger notion of making a safer world ");
                    sw.WriteLine("Cybercrime expert Mikko Hypponen talks us through three types of online attack on our privacy and data -- and only two are considered crimes. Do we blindly trust any future government? Because any right we give away, we give away for good.As computer access expands, Mikko Hypponen asks: What's the next killer virus, and will the world be able to cope with it?");
                    sw.Close();
                    aFile.Close();
                }
            }

            Technology_4 frm = new Technology_4(UserSlections);
            frm.Show();
            this.Close();
        }
    }
}
