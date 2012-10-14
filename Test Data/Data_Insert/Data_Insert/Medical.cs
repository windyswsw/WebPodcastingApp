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

namespace Data_Insert
{
    public partial class Medical : Form
    {
        public Medical()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Medical(string strSelections)
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
                    sw.WriteLine("Eva Vertes -- only 19 when she gave this talk -- discusses her journey toward studying medicine and her drive to understand the roots of cancer and Alzheimer’s.Eva Vertes is a microbiology prodigy. Her discovery, at age 17, of a compound that stops fruit-fly brain cells from dying was regarded as a step toward curing Alzheimer's. Now she aims to find better ways to treat -- and avoid -- cancer");
                    sw.WriteLine("Every doctor makes mistakes. But, says physician Brian Goldman, medicine's culture of denial (and shame) keeps doctors from ever talking about those mistakes, or using them to learn and improve. Telling stories from his own long practice, he calls on doctors to start talking about being wrong. (Filmed at TEDxToronto.)Brian Goldman is an emergency-room physician in Toronto, and the host of CBC Radio’s White Coat, Black Art");
                    sw.WriteLine("Modern medicine is in danger of losing a powerful, old-fashioned tool: human touch. Physician and writer Abraham Verghese describes our strange new world where patients are merely data points, and calls for a return to the traditional one-on-one physical exam. In our era of the patient-as-data-point, Abraham Verghese believes in the old-fashioned physical exam, the bedside chat, the power of informed observation");
                    sw.WriteLine("Daniel Kraft offers a fast-paced look at the next few years of innovations in medicine, powered by new tools, tests and apps that bring diagnostic information right to the patient's bedside. (Filmed at TEDxMaastricht.) Daniel Kraft is a physician-scientist, inventor and innovator. He chairs the FutureMed program at Singularity University, exploring the impact and potential of rapidly developing technologies as applied to health and medicine.");
                    sw.WriteLine("Alan Russell studies regenerative medicine -- a breakthrough way of thinking about disease and injury, using a process that can signal the body to rebuild itself. In the fight against disease, defect and injury, Alan Russell has a novel argument: Why not engineer new tissue and organs to replace sick ones?");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Eva Vertes -- only 19 when she gave this talk -- discusses her journey toward studying medicine and her drive to understand the roots of cancer and Alzheimer’s.Eva Vertes is a microbiology prodigy. Her discovery, at age 17, of a compound that stops fruit-fly brain cells from dying was regarded as a step toward curing Alzheimer's. Now she aims to find better ways to treat -- and avoid -- cancer");
                    sw.WriteLine("Every doctor makes mistakes. But, says physician Brian Goldman, medicine's culture of denial (and shame) keeps doctors from ever talking about those mistakes, or using them to learn and improve. Telling stories from his own long practice, he calls on doctors to start talking about being wrong. (Filmed at TEDxToronto.)Brian Goldman is an emergency-room physician in Toronto, and the host of CBC Radio’s White Coat, Black Art");
                    sw.WriteLine("Modern medicine is in danger of losing a powerful, old-fashioned tool: human touch. Physician and writer Abraham Verghese describes our strange new world where patients are merely data points, and calls for a return to the traditional one-on-one physical exam. In our era of the patient-as-data-point, Abraham Verghese believes in the old-fashioned physical exam, the bedside chat, the power of informed observation");
                    sw.WriteLine("Daniel Kraft offers a fast-paced look at the next few years of innovations in medicine, powered by new tools, tests and apps that bring diagnostic information right to the patient's bedside. (Filmed at TEDxMaastricht.) Daniel Kraft is a physician-scientist, inventor and innovator. He chairs the FutureMed program at Singularity University, exploring the impact and potential of rapidly developing technologies as applied to health and medicine.");
                    sw.WriteLine("Alan Russell studies regenerative medicine -- a breakthrough way of thinking about disease and injury, using a process that can signal the body to rebuild itself. In the fight against disease, defect and injury, Alan Russell has a novel argument: Why not engineer new tissue and organs to replace sick ones?");
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
                    sw.WriteLine("Eva Vertes -- only 19 when she gave this talk -- discusses her journey toward studying medicine and her drive to understand the roots of cancer and Alzheimer’s.Eva Vertes is a microbiology prodigy. Her discovery, at age 17, of a compound that stops fruit-fly brain cells from dying was regarded as a step toward curing Alzheimer's. Now she aims to find better ways to treat -- and avoid -- cancer");
                    sw.WriteLine("Every doctor makes mistakes. But, says physician Brian Goldman, medicine's culture of denial (and shame) keeps doctors from ever talking about those mistakes, or using them to learn and improve. Telling stories from his own long practice, he calls on doctors to start talking about being wrong. (Filmed at TEDxToronto.)Brian Goldman is an emergency-room physician in Toronto, and the host of CBC Radio’s White Coat, Black Art");
                    sw.WriteLine("Modern medicine is in danger of losing a powerful, old-fashioned tool: human touch. Physician and writer Abraham Verghese describes our strange new world where patients are merely data points, and calls for a return to the traditional one-on-one physical exam. In our era of the patient-as-data-point, Abraham Verghese believes in the old-fashioned physical exam, the bedside chat, the power of informed observation");
                    sw.WriteLine("Daniel Kraft offers a fast-paced look at the next few years of innovations in medicine, powered by new tools, tests and apps that bring diagnostic information right to the patient's bedside. (Filmed at TEDxMaastricht.) Daniel Kraft is a physician-scientist, inventor and innovator. He chairs the FutureMed program at Singularity University, exploring the impact and potential of rapidly developing technologies as applied to health and medicine.");
                    sw.WriteLine("Alan Russell studies regenerative medicine -- a breakthrough way of thinking about disease and injury, using a process that can signal the body to rebuild itself. In the fight against disease, defect and injury, Alan Russell has a novel argument: Why not engineer new tissue and organs to replace sick ones?");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Eva Vertes -- only 19 when she gave this talk -- discusses her journey toward studying medicine and her drive to understand the roots of cancer and Alzheimer’s.Eva Vertes is a microbiology prodigy. Her discovery, at age 17, of a compound that stops fruit-fly brain cells from dying was regarded as a step toward curing Alzheimer's. Now she aims to find better ways to treat -- and avoid -- cancer");
                    sw.WriteLine("Every doctor makes mistakes. But, says physician Brian Goldman, medicine's culture of denial (and shame) keeps doctors from ever talking about those mistakes, or using them to learn and improve. Telling stories from his own long practice, he calls on doctors to start talking about being wrong. (Filmed at TEDxToronto.)Brian Goldman is an emergency-room physician in Toronto, and the host of CBC Radio’s White Coat, Black Art");
                    sw.WriteLine("Modern medicine is in danger of losing a powerful, old-fashioned tool: human touch. Physician and writer Abraham Verghese describes our strange new world where patients are merely data points, and calls for a return to the traditional one-on-one physical exam. In our era of the patient-as-data-point, Abraham Verghese believes in the old-fashioned physical exam, the bedside chat, the power of informed observation");
                    sw.WriteLine("Daniel Kraft offers a fast-paced look at the next few years of innovations in medicine, powered by new tools, tests and apps that bring diagnostic information right to the patient's bedside. (Filmed at TEDxMaastricht.) Daniel Kraft is a physician-scientist, inventor and innovator. He chairs the FutureMed program at Singularity University, exploring the impact and potential of rapidly developing technologies as applied to health and medicine.");
                    sw.WriteLine("Alan Russell studies regenerative medicine -- a breakthrough way of thinking about disease and injury, using a process that can signal the body to rebuild itself. In the fight against disease, defect and injury, Alan Russell has a novel argument: Why not engineer new tissue and organs to replace sick ones?");
                    sw.Close();
                    aFile.Close();
                }
            }

            if (length == 4 || length == 3 || length == 1)
            {

                if (Next == "Science")
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
