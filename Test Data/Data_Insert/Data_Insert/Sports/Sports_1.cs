using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Data_Insert.Sports
{
    public partial class Sports_1 : Form
    {
        public Sports_1()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";

        public Sports_1(string strSelections)
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
                    sw.WriteLine("The tale of a major global cultural phenomenon: Cricket commentator Harsha Bhogle describes the spectacular arrival of fast-paced 20-20 cricket as it parallels the rise of modern India. He traces the game from its sleepy English roots to the current world of celebrity owners and million-dollar player contracts. Harsha Bhogle can talk about the business side of cricket, the technicalities of play and the psychology of the players with equal authority");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("The tale of a major global cultural phenomenon: Cricket commentator Harsha Bhogle describes the spectacular arrival of fast-paced 20-20 cricket as it parallels the rise of modern India. He traces the game from its sleepy English roots to the current world of celebrity owners and million-dollar player contracts. Harsha Bhogle can talk about the business side of cricket, the technicalities of play and the psychology of the players with equal authority");
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
                    sw.WriteLine("The tale of a major global cultural phenomenon: Cricket commentator Harsha Bhogle describes the spectacular arrival of fast-paced 20-20 cricket as it parallels the rise of modern India. He traces the game from its sleepy English roots to the current world of celebrity owners and million-dollar player contracts. Harsha Bhogle can talk about the business side of cricket, the technicalities of play and the psychology of the players with equal authority");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("The tale of a major global cultural phenomenon: Cricket commentator Harsha Bhogle describes the spectacular arrival of fast-paced 20-20 cricket as it parallels the rise of modern India. He traces the game from its sleepy English roots to the current world of celebrity owners and million-dollar player contracts. Harsha Bhogle can talk about the business side of cricket, the technicalities of play and the psychology of the players with equal authority");
                    sw.Close();
                    aFile.Close();
                }
            }

            Sports_2 frm = new Sports_2(UserSlections);
            frm.Show();
            this.Close();
        }
        }
    }
