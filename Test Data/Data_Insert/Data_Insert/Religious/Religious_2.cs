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
using Data_Insert.Sports;

namespace Data_Insert.Religious
{
    public partial class Religious_2 : Form
    {
        public Religious_2()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
        String NewUserSlections = "";
        String Next = "";
        int length = 0;

        public Religious_2(string strSelections)
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
                    sw.WriteLine("Pastor Rick Warren, author of The Purpose-Driven Life, reflects on his own crisis of purpose in the wake of his book's wild success. He explains his belief that God's intention is for each of us to use our talents and influence to do good.Pastor Rick Warren is the author of The Purpose-Driven Life, which has sold more than 30 million copies worldwide. His has become an immensely influential voice seeking to apply the values of his faith to issues such as global poverty, HIV/AIDS and injustice.");
                    sw.WriteLine("Speaking at TED in 1998, Rev. Billy Graham marvels at technology's power to improve lives and change the world -- but says the end of evil, suffering and death will come only after the world accepts Christ. A legendary talk from TED's archives. The Rev. Billy Graham is a religious leader with a worldwide reach. In his long career as an evangelist, he has spoken to millions and been an advisor to US presidents");
                    sw.WriteLine("Julia Sweeney (God Said, Ha!) performs the first 15 minutes of her 2006 solo show Letting Go of God. When two young Mormon missionaries knock on her door one day, it touches off a quest to completely rethink her own beliefs. As a solo performer, comic actor Julia Sweeney explores love, cancer, family and faith. Her latest solo show and CD, Letting Go of God, is about the quest for something I could really believe in -- which turns out to be no God at all");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Pastor Rick Warren, author of The Purpose-Driven Life, reflects on his own crisis of purpose in the wake of his book's wild success. He explains his belief that God's intention is for each of us to use our talents and influence to do good.Pastor Rick Warren is the author of The Purpose-Driven Life, which has sold more than 30 million copies worldwide. His has become an immensely influential voice seeking to apply the values of his faith to issues such as global poverty, HIV/AIDS and injustice.");
                    sw.WriteLine("Speaking at TED in 1998, Rev. Billy Graham marvels at technology's power to improve lives and change the world -- but says the end of evil, suffering and death will come only after the world accepts Christ. A legendary talk from TED's archives. The Rev. Billy Graham is a religious leader with a worldwide reach. In his long career as an evangelist, he has spoken to millions and been an advisor to US presidents");
                    sw.WriteLine("Julia Sweeney (God Said, Ha!) performs the first 15 minutes of her 2006 solo show Letting Go of God. When two young Mormon missionaries knock on her door one day, it touches off a quest to completely rethink her own beliefs. As a solo performer, comic actor Julia Sweeney explores love, cancer, family and faith. Her latest solo show and CD, Letting Go of God, is about the quest for something I could really believe in -- which turns out to be no God at all");
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
                    sw.WriteLine("Pastor Rick Warren, author of The Purpose-Driven Life, reflects on his own crisis of purpose in the wake of his book's wild success. He explains his belief that God's intention is for each of us to use our talents and influence to do good.Pastor Rick Warren is the author of The Purpose-Driven Life, which has sold more than 30 million copies worldwide. His has become an immensely influential voice seeking to apply the values of his faith to issues such as global poverty, HIV/AIDS and injustice.");
                    sw.WriteLine("Speaking at TED in 1998, Rev. Billy Graham marvels at technology's power to improve lives and change the world -- but says the end of evil, suffering and death will come only after the world accepts Christ. A legendary talk from TED's archives. The Rev. Billy Graham is a religious leader with a worldwide reach. In his long career as an evangelist, he has spoken to millions and been an advisor to US presidents");
                    sw.WriteLine("Julia Sweeney (God Said, Ha!) performs the first 15 minutes of her 2006 solo show Letting Go of God. When two young Mormon missionaries knock on her door one day, it touches off a quest to completely rethink her own beliefs. As a solo performer, comic actor Julia Sweeney explores love, cancer, family and faith. Her latest solo show and CD, Letting Go of God, is about the quest for something I could really believe in -- which turns out to be no God at all");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Pastor Rick Warren, author of The Purpose-Driven Life, reflects on his own crisis of purpose in the wake of his book's wild success. He explains his belief that God's intention is for each of us to use our talents and influence to do good.Pastor Rick Warren is the author of The Purpose-Driven Life, which has sold more than 30 million copies worldwide. His has become an immensely influential voice seeking to apply the values of his faith to issues such as global poverty, HIV/AIDS and injustice.");
                    sw.WriteLine("Speaking at TED in 1998, Rev. Billy Graham marvels at technology's power to improve lives and change the world -- but says the end of evil, suffering and death will come only after the world accepts Christ. A legendary talk from TED's archives. The Rev. Billy Graham is a religious leader with a worldwide reach. In his long career as an evangelist, he has spoken to millions and been an advisor to US presidents");
                    sw.WriteLine("Julia Sweeney (God Said, Ha!) performs the first 15 minutes of her 2006 solo show Letting Go of God. When two young Mormon missionaries knock on her door one day, it touches off a quest to completely rethink her own beliefs. As a solo performer, comic actor Julia Sweeney explores love, cancer, family and faith. Her latest solo show and CD, Letting Go of God, is about the quest for something I could really believe in -- which turns out to be no God at all");
                    sw.Close();
                    aFile.Close();
                }
            }

            if (length == 4 || length == 3 || length == 1)
            {

                 if (Next == "Environment")
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
