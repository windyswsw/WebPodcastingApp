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
    public partial class Politics : Form
    {
        public Politics()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Politics(string strSelections)
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
                    sw.WriteLine("Politicians are strange creatures, says politician Omar Ahmad. And the best way to engage them on your pet issue is a monthly handwritten letter. Ahmad shows why old-fashioned correspondence is more effective than email, phone or even writing a check -- and shares the four simple steps to writing a letter that works.An internet infrastructure maven and activist, Omar Ahmad was the mayor of San Carlos, California");
                    sw.WriteLine("Noah Feldman makes a searing case that both politics and religion -- whatever their differences -- are similar technologies, designed to efficiently connect and manage any group of people. Noah Feldman studies the intersection of religion, politics and law -- with a focus on how Islam meshes with modern democracy.");
                    sw.WriteLine("Political prisoners aren't the only ones being tortured -- the vast majority of judicial torture happens in ordinary cases, even in 'functioning' legal systems. Social activist Karen Tse shows how we can, and should, stand up and end the use of routine torture.In too many countries, it's still normal to torture prisoners for confessions and information. Karen Tse works to end that");
                    sw.WriteLine("Nate Silver has answers to controversial questions about race in politics: Did Obama's race hurt his votes in some places? Stats and myths collide in this fascinating talk that ends with a remarkable insight on how town planning can promote tolerance.Math whiz and baseball fan Nate Silver was mainly known for predicting outcomes in fantasy ballgames -- until his technique hit a home run calling the outcome of the 2008 election primaries");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Politicians are strange creatures, says politician Omar Ahmad. And the best way to engage them on your pet issue is a monthly handwritten letter. Ahmad shows why old-fashioned correspondence is more effective than email, phone or even writing a check -- and shares the four simple steps to writing a letter that works.An internet infrastructure maven and activist, Omar Ahmad was the mayor of San Carlos, California");
                    sw.WriteLine("Noah Feldman makes a searing case that both politics and religion -- whatever their differences -- are similar technologies, designed to efficiently connect and manage any group of people. Noah Feldman studies the intersection of religion, politics and law -- with a focus on how Islam meshes with modern democracy.");
                    sw.WriteLine("Political prisoners aren't the only ones being tortured -- the vast majority of judicial torture happens in ordinary cases, even in 'functioning' legal systems. Social activist Karen Tse shows how we can, and should, stand up and end the use of routine torture.In too many countries, it's still normal to torture prisoners for confessions and information. Karen Tse works to end that");
                    sw.WriteLine("Nate Silver has answers to controversial questions about race in politics: Did Obama's race hurt his votes in some places? Stats and myths collide in this fascinating talk that ends with a remarkable insight on how town planning can promote tolerance.Math whiz and baseball fan Nate Silver was mainly known for predicting outcomes in fantasy ballgames -- until his technique hit a home run calling the outcome of the 2008 election primaries");
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
                    sw.WriteLine("Politicians are strange creatures, says politician Omar Ahmad. And the best way to engage them on your pet issue is a monthly handwritten letter. Ahmad shows why old-fashioned correspondence is more effective than email, phone or even writing a check -- and shares the four simple steps to writing a letter that works.An internet infrastructure maven and activist, Omar Ahmad was the mayor of San Carlos, California");
                    sw.WriteLine("Noah Feldman makes a searing case that both politics and religion -- whatever their differences -- are similar technologies, designed to efficiently connect and manage any group of people. Noah Feldman studies the intersection of religion, politics and law -- with a focus on how Islam meshes with modern democracy.");
                    sw.WriteLine("Political prisoners aren't the only ones being tortured -- the vast majority of judicial torture happens in ordinary cases, even in 'functioning' legal systems. Social activist Karen Tse shows how we can, and should, stand up and end the use of routine torture.In too many countries, it's still normal to torture prisoners for confessions and information. Karen Tse works to end that");
                    sw.WriteLine("Nate Silver has answers to controversial questions about race in politics: Did Obama's race hurt his votes in some places? Stats and myths collide in this fascinating talk that ends with a remarkable insight on how town planning can promote tolerance.Math whiz and baseball fan Nate Silver was mainly known for predicting outcomes in fantasy ballgames -- until his technique hit a home run calling the outcome of the 2008 election primaries");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Politicians are strange creatures, says politician Omar Ahmad. And the best way to engage them on your pet issue is a monthly handwritten letter. Ahmad shows why old-fashioned correspondence is more effective than email, phone or even writing a check -- and shares the four simple steps to writing a letter that works.An internet infrastructure maven and activist, Omar Ahmad was the mayor of San Carlos, California");
                    sw.WriteLine("Noah Feldman makes a searing case that both politics and religion -- whatever their differences -- are similar technologies, designed to efficiently connect and manage any group of people. Noah Feldman studies the intersection of religion, politics and law -- with a focus on how Islam meshes with modern democracy.");
                    sw.WriteLine("Political prisoners aren't the only ones being tortured -- the vast majority of judicial torture happens in ordinary cases, even in 'functioning' legal systems. Social activist Karen Tse shows how we can, and should, stand up and end the use of routine torture.In too many countries, it's still normal to torture prisoners for confessions and information. Karen Tse works to end that");
                    sw.WriteLine("Nate Silver has answers to controversial questions about race in politics: Did Obama's race hurt his votes in some places? Stats and myths collide in this fascinating talk that ends with a remarkable insight on how town planning can promote tolerance.Math whiz and baseball fan Nate Silver was mainly known for predicting outcomes in fantasy ballgames -- until his technique hit a home run calling the outcome of the 2008 election primaries");
                    sw.Close();
                    aFile.Close();
                }
            }

            if (length == 4 || length == 3 || length == 1)
            {

                if (Next == "Medical")
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
