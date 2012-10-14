using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Data_Insert.Entertainment;
using Data_Insert.Sports;
using System.IO;

namespace Data_Insert
{
    public partial class Category_Selection_Form : Form
    {

        public Category_Selection_Form()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Watch_fileLoc = Program._path + "Watch.txt";
                string Not_Watch_fileLoc = Program._path + "Not_Watch.txt";
                FileStream aFile = new FileStream(Watch_fileLoc, FileMode.Create, FileAccess.Write);
                FileStream nFile = new FileStream(Not_Watch_fileLoc, FileMode.Create, FileAccess.Write);
                aFile.Close();
                nFile.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Error creating intial files at Input Data folder. Make sure there are no files open.");
                Application.Exit();
            }
            

            string selections = "";
            int NumberOfSelections = 0;

            if (Technology.Checked)
            {
                selections = selections + "," + "Technology";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Entertainment.Checked)
            {
                selections = selections + "," + "Entertainment";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Business.Checked)
            {
                selections = selections + "," + "Business";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Religious.Checked)
            {
                selections = selections + "," + "Religious";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Environment.Checked)
            {
                selections = selections + "," + "Environment";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Sports.Checked)
            {
                selections = selections + "," + "Sports";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Politics.Checked)
            {
                selections = selections + "," + "Politics";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Medical.Checked)
            {
                selections = selections + "," + "Medical";
                NumberOfSelections = NumberOfSelections + 1;
            }

            if (Science.Checked)
            {
                selections = selections + "," + "Science";
                NumberOfSelections = NumberOfSelections + 1;
            }



            if (NumberOfSelections > 3)
                MessageBox.Show("Please select only THREE categories");

            else if (NumberOfSelections < 1)
                MessageBox.Show("Please select at least ONE categories");

            else if (Technology.Checked)
            {
                Technology_1 frm = new Technology_1(selections);
                frm.Show();
                this.Close();
            }
             else if (Entertainment.Checked)
            {
                Entertainment_1 frm = new Entertainment_1(selections);
                frm.Show();
                this.Close();
            }
             else if (Business.Checked)
            {
                Business frm = new Business(selections);
                frm.Show();
                this.Close();
            }
             else if (Religious.Checked)
            {
                Religious_1 frm = new Religious_1(selections);
                frm.Show();
                this.Close();
            }
             else if (Environment.Checked)
            {
                Environment frm = new Environment(selections);
                frm.Show();
                this.Close();
            }
             else if (Sports.Checked)
            {
                Sports_1 frm = new Sports_1(selections);
                frm.Show();
                this.Close();
            }
             else if (Politics.Checked)
            {
                Politics frm = new Politics(selections);
                frm.Show();
                this.Close();
            }
            else if (Medical.Checked)
            {
                Medical frm = new Medical(selections);
                frm.Show();
                this.Close();
            }
            else if (Science.Checked)
            {
                Science frm = new Science(selections);
                frm.Show();
                this.Close();
            }

        }
        
    }
}