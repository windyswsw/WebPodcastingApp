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
    public partial class Technology_2 : Form
    {
        public Technology_2()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";

        public Technology_2(string strSelections)
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
                    sw.WriteLine("Inventor Dean Kamen previews the prosthetic arm he’s developing at the request of the US Department of Defense. His quiet commitment to using technology to solve problems -- while honoring the human spirit -- has never been more clear.Dean Kamen landed in the limelight with the Segway, but he has been innovating since high school, with more than 150 patents under his belt. Recent projects include portable energy and water purification for the developing world, and a prosthetic arm for maimed soldiers. Full bio");
                    sw.WriteLine("Two-thirds of the world may not have access to the latest smartphone, but local electronic shops are adept at fixing older tech using low-cost parts. Vinay Venkatraman explains his work in technology crafts, through which a mobile phone, a lunchbox and a flashlight can become a digital projector for a village school, or an alarm clock and a mouse can be melded into a medical device for local triage. Vinay Venkatraman aims to design technological devices for the bottom of the pyramid rather than simply for the affluent");
                    sw.WriteLine(" Tech enthusiast Kevin Kelly asks What does technology want? and discovers that its movement toward ubiquity and complexity is much like the evolution of life. Kevin Kelly has been publisher of the Whole Earth Review, exec editor at WIRED, founder of visionary nonprofits, and writer on biology and business and cool tools.He's admired for his new perspectives on technology and its relevance to history, biology and religion.");
                    sw.WriteLine("Engineer and artist Golan Levin pushes the boundaries of what’s possible with audiovisuals and technology. In an amazing TED display, he shows two programs he wrote to perform his original compositions. Half performance artist, half software engineer, Golan Levin manipulates the computer to create improvised soundscapes with dazzling corresponding visuals. He is at the forefront of defining new parameters for art");
                    sw.WriteLine("Matt Mills and Tamara Roukaerts demonstrate Aurasma, a new augmented reality tool that can seamlessly animate the world as seen through a smartphone. Going beyond previous augmented reality, their auras can do everything from making a painting talk to overlaying live news onto a printed newspaper. Matt Mills comes from Aurasma, a startup that makes augmented-reality technology for mobile phones");
                    sw.WriteLine("At TEDIndia, Pranav Mistry demos several tools that help the physical world interact with the world of data including a deep look at his SixthSense device and a new, paradigm-shifting paper laptop. In an onstage Q&A, Mistry says he'll open-source the software behind SixthSense, to open its possibilities to all.Pranav Mistry is the inventor of SixthSense, a wearable device that enables new interactions between the real world and the world of data"); 
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Inventor Dean Kamen previews the prosthetic arm he’s developing at the request of the US Department of Defense. His quiet commitment to using technology to solve problems -- while honoring the human spirit -- has never been more clear.Dean Kamen landed in the limelight with the Segway, but he has been innovating since high school, with more than 150 patents under his belt. Recent projects include portable energy and water purification for the developing world, and a prosthetic arm for maimed soldiers. Full bio");
                    sw.WriteLine("Two-thirds of the world may not have access to the latest smartphone, but local electronic shops are adept at fixing older tech using low-cost parts. Vinay Venkatraman explains his work in technology crafts, through which a mobile phone, a lunchbox and a flashlight can become a digital projector for a village school, or an alarm clock and a mouse can be melded into a medical device for local triage. Vinay Venkatraman aims to design technological devices for the bottom of the pyramid rather than simply for the affluent");
                    sw.WriteLine(" Tech enthusiast Kevin Kelly asks What does technology want? and discovers that its movement toward ubiquity and complexity is much like the evolution of life. Kevin Kelly has been publisher of the Whole Earth Review, exec editor at WIRED, founder of visionary nonprofits, and writer on biology and business and cool tools.He's admired for his new perspectives on technology and its relevance to history, biology and religion.");
                    sw.WriteLine("Engineer and artist Golan Levin pushes the boundaries of what’s possible with audiovisuals and technology. In an amazing TED display, he shows two programs he wrote to perform his original compositions. Half performance artist, half software engineer, Golan Levin manipulates the computer to create improvised soundscapes with dazzling corresponding visuals. He is at the forefront of defining new parameters for art");
                    sw.WriteLine("Matt Mills and Tamara Roukaerts demonstrate Aurasma, a new augmented reality tool that can seamlessly animate the world as seen through a smartphone. Going beyond previous augmented reality, their auras can do everything from making a painting talk to overlaying live news onto a printed newspaper. Matt Mills comes from Aurasma, a startup that makes augmented-reality technology for mobile phones");
                    sw.WriteLine("At TEDIndia, Pranav Mistry demos several tools that help the physical world interact with the world of data including a deep look at his SixthSense device and a new, paradigm-shifting paper laptop. In an onstage Q&A, Mistry says he'll open-source the software behind SixthSense, to open its possibilities to all.Pranav Mistry is the inventor of SixthSense, a wearable device that enables new interactions between the real world and the world of data"); 
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
                    sw.WriteLine("Inventor Dean Kamen previews the prosthetic arm he’s developing at the request of the US Department of Defense. His quiet commitment to using technology to solve problems -- while honoring the human spirit -- has never been more clear.Dean Kamen landed in the limelight with the Segway, but he has been innovating since high school, with more than 150 patents under his belt. Recent projects include portable energy and water purification for the developing world, and a prosthetic arm for maimed soldiers. Full bio");
                    sw.WriteLine("Two-thirds of the world may not have access to the latest smartphone, but local electronic shops are adept at fixing older tech using low-cost parts. Vinay Venkatraman explains his work in technology crafts, through which a mobile phone, a lunchbox and a flashlight can become a digital projector for a village school, or an alarm clock and a mouse can be melded into a medical device for local triage. Vinay Venkatraman aims to design technological devices for the bottom of the pyramid rather than simply for the affluent");
                    sw.WriteLine(" Tech enthusiast Kevin Kelly asks What does technology want? and discovers that its movement toward ubiquity and complexity is much like the evolution of life. Kevin Kelly has been publisher of the Whole Earth Review, exec editor at WIRED, founder of visionary nonprofits, and writer on biology and business and cool tools.He's admired for his new perspectives on technology and its relevance to history, biology and religion.");
                    sw.WriteLine("Engineer and artist Golan Levin pushes the boundaries of what’s possible with audiovisuals and technology. In an amazing TED display, he shows two programs he wrote to perform his original compositions. Half performance artist, half software engineer, Golan Levin manipulates the computer to create improvised soundscapes with dazzling corresponding visuals. He is at the forefront of defining new parameters for art");
                    sw.WriteLine("Matt Mills and Tamara Roukaerts demonstrate Aurasma, a new augmented reality tool that can seamlessly animate the world as seen through a smartphone. Going beyond previous augmented reality, their auras can do everything from making a painting talk to overlaying live news onto a printed newspaper. Matt Mills comes from Aurasma, a startup that makes augmented-reality technology for mobile phones");

                    sw.WriteLine("At TEDIndia, Pranav Mistry demos several tools that help the physical world interact with the world of data including a deep look at his SixthSense device and a new, paradigm-shifting paper laptop. In an onstage Q&A, Mistry says he'll open-source the software behind SixthSense, to open its possibilities to all.Pranav Mistry is the inventor of SixthSense, a wearable device that enables new interactions between the real world and the world of data"); sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Inventor Dean Kamen previews the prosthetic arm he’s developing at the request of the US Department of Defense. His quiet commitment to using technology to solve problems -- while honoring the human spirit -- has never been more clear.Dean Kamen landed in the limelight with the Segway, but he has been innovating since high school, with more than 150 patents under his belt. Recent projects include portable energy and water purification for the developing world, and a prosthetic arm for maimed soldiers. Full bio");
                    sw.WriteLine("Two-thirds of the world may not have access to the latest smartphone, but local electronic shops are adept at fixing older tech using low-cost parts. Vinay Venkatraman explains his work in technology crafts, through which a mobile phone, a lunchbox and a flashlight can become a digital projector for a village school, or an alarm clock and a mouse can be melded into a medical device for local triage. Vinay Venkatraman aims to design technological devices for the bottom of the pyramid rather than simply for the affluent");
                    sw.WriteLine(" Tech enthusiast Kevin Kelly asks What does technology want? and discovers that its movement toward ubiquity and complexity is much like the evolution of life. Kevin Kelly has been publisher of the Whole Earth Review, exec editor at WIRED, founder of visionary nonprofits, and writer on biology and business and cool tools.He's admired for his new perspectives on technology and its relevance to history, biology and religion.");
                    sw.WriteLine("Engineer and artist Golan Levin pushes the boundaries of what’s possible with audiovisuals and technology. In an amazing TED display, he shows two programs he wrote to perform his original compositions. Half performance artist, half software engineer, Golan Levin manipulates the computer to create improvised soundscapes with dazzling corresponding visuals. He is at the forefront of defining new parameters for art");
                    sw.WriteLine("Matt Mills and Tamara Roukaerts demonstrate Aurasma, a new augmented reality tool that can seamlessly animate the world as seen through a smartphone. Going beyond previous augmented reality, their auras can do everything from making a painting talk to overlaying live news onto a printed newspaper. Matt Mills comes from Aurasma, a startup that makes augmented-reality technology for mobile phones");
                    sw.WriteLine("At TEDIndia, Pranav Mistry demos several tools that help the physical world interact with the world of data including a deep look at his SixthSense device and a new, paradigm-shifting paper laptop. In an onstage Q&A, Mistry says he'll open-source the software behind SixthSense, to open its possibilities to all.Pranav Mistry is the inventor of SixthSense, a wearable device that enables new interactions between the real world and the world of data"); 
                    sw.Close();
                    aFile.Close();
                }
            }

            Technology_3 frm = new Technology_3(UserSlections);
            frm.Show();
            this.Close();
        }
    }
}
