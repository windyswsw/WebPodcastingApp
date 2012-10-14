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
    public partial class Data_Insert_Starting_Form : Form
    {
        public Data_Insert_Starting_Form()
        {
            InitializeComponent();
        }

        private void Next_btn1_Click(object sender, EventArgs e)
        {
            Category_Selection_Form new_Category_Selection_Form = new Category_Selection_Form();
            new_Category_Selection_Form.Show();
        }
    }
}
