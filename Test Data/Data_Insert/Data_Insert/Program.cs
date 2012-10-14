using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Data_Insert
{
    static class Program
    {
        internal static string _path = @"../../../Input_Data/";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Data_Insert_Starting_Form());
        }
    }
}
