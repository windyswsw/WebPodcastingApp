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

namespace Data_Insert
{
    public partial class Science : Form
    {
        public Science()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Science(string strSelections)
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
                    sw.WriteLine("Questions of good and evil, right and wrong are commonly thought unanswerable by science. But Sam Harris argues that science can -- and should -- be an authority on moral issues, shaping human values and setting out what constitutes a good life. Adored by secularists, feared by the pious, Sam Harris' best-selling books argue that religion is ruinous and, worse, stupid -- and that questioning religious faith might just save civilization.");
                    sw.WriteLine("Does science ruin the magic of life? In this grumpy but charming monologue, Robin Ince makes the argument against. The more we learn about the astonishing behavior of the universe -- the more we stand in awe.The rational-minded Robin Ince conducts live experiments in comedy.");
                    sw.WriteLine("In a zippy demo at TED U, AnnMarie Thomas shows how two different kinds of homemade play dough can be used to demonstrate electrical properties -- by lighting up LEDs, spinning motors, and turning little kids into circuit designers. AnnMarie Thomas works on the playful side of engineering -- using cool tools to teach and help others.");
                    sw.WriteLine("What if every scientist could share their data as easily as they tweet about their lunch? Michael Nielsen calls for scientists to embrace new tools for collaboration that will enable discoveries to happen at the speed of Twitter. (Filmed at TEDxWaterloo.) A physicist turned writer, Michael Nielsen believes online communication and collaboration tools are revolutionizing the way we make scientific discoveries.");
                    sw.WriteLine("In tough economic times, our exploratory science programs -- from space probes to the LHC -- are first to suffer budget cuts. Brian Cox explains how curiosity-driven science pays for itself, powering innovation and a profound appreciation of our existence.Physicist Brian Cox has two jobs: working with the Large Hadron Collider at CERN, and explaining big science to the general public. He's a professor at the University of Manchester.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Questions of good and evil, right and wrong are commonly thought unanswerable by science. But Sam Harris argues that science can -- and should -- be an authority on moral issues, shaping human values and setting out what constitutes a good life. Adored by secularists, feared by the pious, Sam Harris' best-selling books argue that religion is ruinous and, worse, stupid -- and that questioning religious faith might just save civilization.");
                    sw.WriteLine("Does science ruin the magic of life? In this grumpy but charming monologue, Robin Ince makes the argument against. The more we learn about the astonishing behavior of the universe -- the more we stand in awe.The rational-minded Robin Ince conducts live experiments in comedy.");
                    sw.WriteLine("In a zippy demo at TED U, AnnMarie Thomas shows how two different kinds of homemade play dough can be used to demonstrate electrical properties -- by lighting up LEDs, spinning motors, and turning little kids into circuit designers. AnnMarie Thomas works on the playful side of engineering -- using cool tools to teach and help others.");
                    sw.WriteLine("What if every scientist could share their data as easily as they tweet about their lunch? Michael Nielsen calls for scientists to embrace new tools for collaboration that will enable discoveries to happen at the speed of Twitter. (Filmed at TEDxWaterloo.) A physicist turned writer, Michael Nielsen believes online communication and collaboration tools are revolutionizing the way we make scientific discoveries.");
                    sw.WriteLine("In tough economic times, our exploratory science programs -- from space probes to the LHC -- are first to suffer budget cuts. Brian Cox explains how curiosity-driven science pays for itself, powering innovation and a profound appreciation of our existence.Physicist Brian Cox has two jobs: working with the Large Hadron Collider at CERN, and explaining big science to the general public. He's a professor at the University of Manchester.");
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
                    sw.WriteLine("Questions of good and evil, right and wrong are commonly thought unanswerable by science. But Sam Harris argues that science can -- and should -- be an authority on moral issues, shaping human values and setting out what constitutes a good life. Adored by secularists, feared by the pious, Sam Harris' best-selling books argue that religion is ruinous and, worse, stupid -- and that questioning religious faith might just save civilization.");
                    sw.WriteLine("Does science ruin the magic of life? In this grumpy but charming monologue, Robin Ince makes the argument against. The more we learn about the astonishing behavior of the universe -- the more we stand in awe.The rational-minded Robin Ince conducts live experiments in comedy.");
                    sw.WriteLine("In a zippy demo at TED U, AnnMarie Thomas shows how two different kinds of homemade play dough can be used to demonstrate electrical properties -- by lighting up LEDs, spinning motors, and turning little kids into circuit designers. AnnMarie Thomas works on the playful side of engineering -- using cool tools to teach and help others.");
                    sw.WriteLine("What if every scientist could share their data as easily as they tweet about their lunch? Michael Nielsen calls for scientists to embrace new tools for collaboration that will enable discoveries to happen at the speed of Twitter. (Filmed at TEDxWaterloo.) A physicist turned writer, Michael Nielsen believes online communication and collaboration tools are revolutionizing the way we make scientific discoveries.");
                    sw.WriteLine("In tough economic times, our exploratory science programs -- from space probes to the LHC -- are first to suffer budget cuts. Brian Cox explains how curiosity-driven science pays for itself, powering innovation and a profound appreciation of our existence.Physicist Brian Cox has two jobs: working with the Large Hadron Collider at CERN, and explaining big science to the general public. He's a professor at the University of Manchester.");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Questions of good and evil, right and wrong are commonly thought unanswerable by science. But Sam Harris argues that science can -- and should -- be an authority on moral issues, shaping human values and setting out what constitutes a good life. Adored by secularists, feared by the pious, Sam Harris' best-selling books argue that religion is ruinous and, worse, stupid -- and that questioning religious faith might just save civilization.");
                    sw.WriteLine("Does science ruin the magic of life? In this grumpy but charming monologue, Robin Ince makes the argument against. The more we learn about the astonishing behavior of the universe -- the more we stand in awe.The rational-minded Robin Ince conducts live experiments in comedy.");
                    sw.WriteLine("In a zippy demo at TED U, AnnMarie Thomas shows how two different kinds of homemade play dough can be used to demonstrate electrical properties -- by lighting up LEDs, spinning motors, and turning little kids into circuit designers. AnnMarie Thomas works on the playful side of engineering -- using cool tools to teach and help others.");
                    sw.WriteLine("What if every scientist could share their data as easily as they tweet about their lunch? Michael Nielsen calls for scientists to embrace new tools for collaboration that will enable discoveries to happen at the speed of Twitter. (Filmed at TEDxWaterloo.) A physicist turned writer, Michael Nielsen believes online communication and collaboration tools are revolutionizing the way we make scientific discoveries.");
                    sw.WriteLine("In tough economic times, our exploratory science programs -- from space probes to the LHC -- are first to suffer budget cuts. Brian Cox explains how curiosity-driven science pays for itself, powering innovation and a profound appreciation of our existence.Physicist Brian Cox has two jobs: working with the Large Hadron Collider at CERN, and explaining big science to the general public. He's a professor at the University of Manchester.");
                    sw.Close();
                    aFile.Close();
                }
            }

                    Finish frm = new Finish();
                    frm.Show();
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
