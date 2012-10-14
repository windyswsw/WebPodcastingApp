using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Data_Insert.Religious;

namespace Data_Insert
{
    public partial class Religious_1 : Form
    {
        public Religious_1()
        {
            InitializeComponent();
        }

         string UserSlections = "";
         string Watch_fileLoc = Program._path + "Watch.txt";
         string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";

        public Religious_1(string strSelections)
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
                    sw.WriteLine("What is happiness, and how can we all get some? Biochemist turned Buddhist monk Matthieu Ricard says we can train our minds in habits of well-being, to generate a true sense of serenity and fulfillment. Sometimes called the happiest man in the world, Matthieu Ricard is a Buddhist monk, author and photographer.");
                    sw.WriteLine("Buddhist roshi Joan Halifax works with people at the last stage of life (in hospice and on death row). She shares what she's learned about compassion in the face of death and dying, and a deep insight into the nature of empathy.Known for her compassionate work with the terminally ill, Joan Halifax is a driving force of socially engaged Buddhism.");
                    sw.WriteLine("It’s hard to always show compassion -- even to the people we love, but Robert Thurman asks that we develop compassion for our enemies. He prescribes a seven-step meditation exercise to extend compassion beyond our inner circle.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace");
                    sw.WriteLine("In our hyperlinked world, we can know anything, anytime. And this mass enlightenment, says Buddhist scholar Bob Thurman, is our first step toward Buddha nature.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace.");
                    sw.WriteLine("The Buddhists think that, because we’ve all had infinite previous lives, we’ve all been each other’s relatives. Therefore all of you, in the Buddhist view, in some previous life … have been my mother — for which I do apologize for the trouble I caused you"); 
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("What is happiness, and how can we all get some? Biochemist turned Buddhist monk Matthieu Ricard says we can train our minds in habits of well-being, to generate a true sense of serenity and fulfillment. Sometimes called the happiest man in the world, Matthieu Ricard is a Buddhist monk, author and photographer.");
                    sw.WriteLine("Buddhist roshi Joan Halifax works with people at the last stage of life (in hospice and on death row). She shares what she's learned about compassion in the face of death and dying, and a deep insight into the nature of empathy.Known for her compassionate work with the terminally ill, Joan Halifax is a driving force of socially engaged Buddhism.");
                    sw.WriteLine("It’s hard to always show compassion -- even to the people we love, but Robert Thurman asks that we develop compassion for our enemies. He prescribes a seven-step meditation exercise to extend compassion beyond our inner circle.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace");
                    sw.WriteLine("In our hyperlinked world, we can know anything, anytime. And this mass enlightenment, says Buddhist scholar Bob Thurman, is our first step toward Buddha nature.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace.");
                    sw.WriteLine("The Buddhists think that, because we’ve all had infinite previous lives, we’ve all been each other’s relatives. Therefore all of you, in the Buddhist view, in some previous life … have been my mother — for which I do apologize for the trouble I caused you"); 
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
                    sw.WriteLine("What is happiness, and how can we all get some? Biochemist turned Buddhist monk Matthieu Ricard says we can train our minds in habits of well-being, to generate a true sense of serenity and fulfillment. Sometimes called the happiest man in the world, Matthieu Ricard is a Buddhist monk, author and photographer.");
                    sw.WriteLine("Buddhist roshi Joan Halifax works with people at the last stage of life (in hospice and on death row). She shares what she's learned about compassion in the face of death and dying, and a deep insight into the nature of empathy.Known for her compassionate work with the terminally ill, Joan Halifax is a driving force of socially engaged Buddhism.");
                    sw.WriteLine("It’s hard to always show compassion -- even to the people we love, but Robert Thurman asks that we develop compassion for our enemies. He prescribes a seven-step meditation exercise to extend compassion beyond our inner circle.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace");
                    sw.WriteLine("In our hyperlinked world, we can know anything, anytime. And this mass enlightenment, says Buddhist scholar Bob Thurman, is our first step toward Buddha nature.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace.");
                    sw.WriteLine("The Buddhists think that, because we’ve all had infinite previous lives, we’ve all been each other’s relatives. Therefore all of you, in the Buddhist view, in some previous life … have been my mother — for which I do apologize for the trouble I caused you"); 
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("What is happiness, and how can we all get some? Biochemist turned Buddhist monk Matthieu Ricard says we can train our minds in habits of well-being, to generate a true sense of serenity and fulfillment. Sometimes called the happiest man in the world, Matthieu Ricard is a Buddhist monk, author and photographer.");
                    sw.WriteLine("Buddhist roshi Joan Halifax works with people at the last stage of life (in hospice and on death row). She shares what she's learned about compassion in the face of death and dying, and a deep insight into the nature of empathy.Known for her compassionate work with the terminally ill, Joan Halifax is a driving force of socially engaged Buddhism.");
                    sw.WriteLine("It’s hard to always show compassion -- even to the people we love, but Robert Thurman asks that we develop compassion for our enemies. He prescribes a seven-step meditation exercise to extend compassion beyond our inner circle.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace");
                    sw.WriteLine("In our hyperlinked world, we can know anything, anytime. And this mass enlightenment, says Buddhist scholar Bob Thurman, is our first step toward Buddha nature.The first American to be ordained a Tibetan Monk by the Dalai Lama, Robert A.F. Thurman is a scholar, author and tireless proponent of peace.");
                    sw.WriteLine("The Buddhists think that, because we’ve all had infinite previous lives, we’ve all been each other’s relatives. Therefore all of you, in the Buddhist view, in some previous life … have been my mother — for which I do apologize for the trouble I caused you"); 
                    sw.Close();
                    aFile.Close();
                }
            }

            Religious_2 frm = new Religious_2(UserSlections);
            frm.Show();

            this.Close();
        }
        }
    }
