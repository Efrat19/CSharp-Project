using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SemesterFinalProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Data.OpenData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Data.SaveData();
        }
    }
}
