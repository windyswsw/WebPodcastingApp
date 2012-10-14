using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            if (General.Checked = true)
            {
                MessageBox.Show("General");
            }

        }

        
    }
}
