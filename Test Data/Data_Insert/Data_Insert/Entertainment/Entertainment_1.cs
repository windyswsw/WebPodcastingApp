using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Data_Insert.Entertainment
{
    public partial class Entertainment_1 : Form
    {


        public Entertainment_1()
        {
            InitializeComponent();
        }

        string UserSlections = "";
        string Watch_fileLoc = Program._path + "Watch.txt";
        string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";

        public Entertainment_1(string strSelections)
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
                    sw.WriteLine("Usman Riaz is a 21-year-old whiz at the percussive guitar, a style he learned to play by watching his heroes on YouTube. The TED Fellow plays onstage at TEDGlobal 2012 -- followed by a jawdropping solo from the master of percussive guitar, Preston Reed. And watch these two guitarists take on a very spur-of-the-moment improv. Preston Reed’s hands have an otherworldly coordination. The fingers, nails, thumbs, and palms of both left and right dance, pluck, strum, and slap his guitar, which bursts with a full sound");
                    sw.WriteLine("In this epic overview, Michael Tilson Thomas traces the development of classical music through the development of written notation, the record, and the re-mix.Conductor Michael Tilson Thomas (call him MTT) is an all-around music educator -- connecting with global audiences, young musicians and concertgoers in San Francisco and London");
                    sw.WriteLine("Jackson Browne plays a song he started writing last April aboard Mission Blue Voyage, the Sylvia Earle-inspired trip to brainstorm ways to save the ocean.If I could be anywhere, he sings, anywhere right now, I would be here. (Filmed at TEDxGPGP.) Jackson Browne has written and performed some of the most literate and moving songs in popular music -- and has defined a genre of songwriting charged with honesty, emotion and personal politics.");
                    sw.WriteLine("The three Ahn sisters (cellist Maria, pianist Lucia, violinist Angella) breathe new life into the piano trio with their passionate musicmaking. At TEDWomen, they start with the bright and poppy Skylife, by David Balakrishnan, then play a gorgeous, slinky version of Oblivion, by Astor Piazzolla. With cello, piano and violin, sisters Maria, Lucia and Angella Ahn are constantly redefining the art and architecture of chamber music.");
                    sw.WriteLine("Musical innovator Andrew Bird winds together his trademark violin technique with xylophone, vocals and sophisticated electronic looping. Add in his uncanny ability to whistle anything, and he becomes a riveting one-man orchestra.Andrew Bird is a virtual one-man band -- he’s a singer and songwriter and plays the violin, guitar, glockenspiel.");
                    sw.WriteLine("Cellist Maya Beiser plays a gorgeous eight-part modern etude with seven copies of herself, and segues into a meditative music/video hybrid using tech to create endless possibilities for transformative sound. Music is Steve Reich's Cello Counterpoint, with video from Bill Morrison, then David Lang's World to Come, with video by Irit Batsry. Maya Beiser commissions and performs radical new work for the cello");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Usman Riaz is a 21-year-old whiz at the percussive guitar, a style he learned to play by watching his heroes on YouTube. The TED Fellow plays onstage at TEDGlobal 2012 -- followed by a jawdropping solo from the master of percussive guitar, Preston Reed. And watch these two guitarists take on a very spur-of-the-moment improv. Preston Reed’s hands have an otherworldly coordination. The fingers, nails, thumbs, and palms of both left and right dance, pluck, strum, and slap his guitar, which bursts with a full sound");
                    sw.WriteLine("In this epic overview, Michael Tilson Thomas traces the development of classical music through the development of written notation, the record, and the re-mix.Conductor Michael Tilson Thomas (call him MTT) is an all-around music educator -- connecting with global audiences, young musicians and concertgoers in San Francisco and London");
                    sw.WriteLine("Jackson Browne plays a song he started writing last April aboard Mission Blue Voyage, the Sylvia Earle-inspired trip to brainstorm ways to save the ocean.If I could be anywhere, he sings, anywhere right now, I would be here. (Filmed at TEDxGPGP.) Jackson Browne has written and performed some of the most literate and moving songs in popular music -- and has defined a genre of songwriting charged with honesty, emotion and personal politics.");
                    sw.WriteLine("The three Ahn sisters (cellist Maria, pianist Lucia, violinist Angella) breathe new life into the piano trio with their passionate musicmaking. At TEDWomen, they start with the bright and poppy Skylife, by David Balakrishnan, then play a gorgeous, slinky version of Oblivion, by Astor Piazzolla. With cello, piano and violin, sisters Maria, Lucia and Angella Ahn are constantly redefining the art and architecture of chamber music.");
                    sw.WriteLine("Musical innovator Andrew Bird winds together his trademark violin technique with xylophone, vocals and sophisticated electronic looping. Add in his uncanny ability to whistle anything, and he becomes a riveting one-man orchestra.Andrew Bird is a virtual one-man band -- he’s a singer and songwriter and plays the violin, guitar, glockenspiel.");
                    sw.WriteLine("Cellist Maya Beiser plays a gorgeous eight-part modern etude with seven copies of herself, and segues into a meditative music/video hybrid using tech to create endless possibilities for transformative sound. Music is Steve Reich's Cello Counterpoint, with video from Bill Morrison, then David Lang's World to Come, with video by Irit Batsry. Maya Beiser commissions and performs radical new work for the cello");
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
                    sw.WriteLine("Usman Riaz is a 21-year-old whiz at the percussive guitar, a style he learned to play by watching his heroes on YouTube. The TED Fellow plays onstage at TEDGlobal 2012 -- followed by a jawdropping solo from the master of percussive guitar, Preston Reed. And watch these two guitarists take on a very spur-of-the-moment improv. Preston Reed’s hands have an otherworldly coordination. The fingers, nails, thumbs, and palms of both left and right dance, pluck, strum, and slap his guitar, which bursts with a full sound");
                    sw.WriteLine("In this epic overview, Michael Tilson Thomas traces the development of classical music through the development of written notation, the record, and the re-mix.Conductor Michael Tilson Thomas (call him MTT) is an all-around music educator -- connecting with global audiences, young musicians and concertgoers in San Francisco and London");
                    sw.WriteLine("Jackson Browne plays a song he started writing last April aboard Mission Blue Voyage, the Sylvia Earle-inspired trip to brainstorm ways to save the ocean.If I could be anywhere, he sings, anywhere right now, I would be here. (Filmed at TEDxGPGP.) Jackson Browne has written and performed some of the most literate and moving songs in popular music -- and has defined a genre of songwriting charged with honesty, emotion and personal politics.");
                    sw.WriteLine("The three Ahn sisters (cellist Maria, pianist Lucia, violinist Angella) breathe new life into the piano trio with their passionate musicmaking. At TEDWomen, they start with the bright and poppy Skylife, by David Balakrishnan, then play a gorgeous, slinky version of Oblivion, by Astor Piazzolla. With cello, piano and violin, sisters Maria, Lucia and Angella Ahn are constantly redefining the art and architecture of chamber music.");
                    sw.WriteLine("Musical innovator Andrew Bird winds together his trademark violin technique with xylophone, vocals and sophisticated electronic looping. Add in his uncanny ability to whistle anything, and he becomes a riveting one-man orchestra.Andrew Bird is a virtual one-man band -- he’s a singer and songwriter and plays the violin, guitar, glockenspiel.");
                    sw.WriteLine("Cellist Maya Beiser plays a gorgeous eight-part modern etude with seven copies of herself, and segues into a meditative music/video hybrid using tech to create endless possibilities for transformative sound. Music is Steve Reich's Cello Counterpoint, with video from Bill Morrison, then David Lang's World to Come, with video by Irit Batsry. Maya Beiser commissions and performs radical new work for the cello");
                    sw.Close();
                    aFile.Close();
                }
                else
                {
                    FileStream aFile = new FileStream(Not_Watch_fileLoc, FileMode.Append, FileAccess.Write);
                    StreamWriter sw = new StreamWriter(aFile);
                    sw.WriteLine("Usman Riaz is a 21-year-old whiz at the percussive guitar, a style he learned to play by watching his heroes on YouTube. The TED Fellow plays onstage at TEDGlobal 2012 -- followed by a jawdropping solo from the master of percussive guitar, Preston Reed. And watch these two guitarists take on a very spur-of-the-moment improv. Preston Reed’s hands have an otherworldly coordination. The fingers, nails, thumbs, and palms of both left and right dance, pluck, strum, and slap his guitar, which bursts with a full sound");
                    sw.WriteLine("In this epic overview, Michael Tilson Thomas traces the development of classical music through the development of written notation, the record, and the re-mix.Conductor Michael Tilson Thomas (call him MTT) is an all-around music educator -- connecting with global audiences, young musicians and concertgoers in San Francisco and London");
                    sw.WriteLine("Jackson Browne plays a song he started writing last April aboard Mission Blue Voyage, the Sylvia Earle-inspired trip to brainstorm ways to save the ocean.If I could be anywhere, he sings, anywhere right now, I would be here. (Filmed at TEDxGPGP.) Jackson Browne has written and performed some of the most literate and moving songs in popular music -- and has defined a genre of songwriting charged with honesty, emotion and personal politics.");
                    sw.WriteLine("The three Ahn sisters (cellist Maria, pianist Lucia, violinist Angella) breathe new life into the piano trio with their passionate musicmaking. At TEDWomen, they start with the bright and poppy Skylife, by David Balakrishnan, then play a gorgeous, slinky version of Oblivion, by Astor Piazzolla. With cello, piano and violin, sisters Maria, Lucia and Angella Ahn are constantly redefining the art and architecture of chamber music.");
                    sw.WriteLine("Musical innovator Andrew Bird winds together his trademark violin technique with xylophone, vocals and sophisticated electronic looping. Add in his uncanny ability to whistle anything, and he becomes a riveting one-man orchestra.Andrew Bird is a virtual one-man band -- he’s a singer and songwriter and plays the violin, guitar, glockenspiel.");
                    sw.WriteLine("Cellist Maya Beiser plays a gorgeous eight-part modern etude with seven copies of herself, and segues into a meditative music/video hybrid using tech to create endless possibilities for transformative sound. Music is Steve Reich's Cello Counterpoint, with video from Bill Morrison, then David Lang's World to Come, with video by Irit Batsry. Maya Beiser commissions and performs radical new work for the cello");
                    sw.Close();
                    aFile.Close();
                }
            }

             Entertainment_2 frm = new Entertainment_2(UserSlections);
            frm.Show();

            this.Close();

        }
    }
}
