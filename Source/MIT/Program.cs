using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace mit
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            StartForm start_form = new StartForm();
            start_form.ShowDialog();
            Application.Run(new MainForm());

            //StartForm start_form2 = new StartForm();
            //start_form2.ShowDialog();
        }
    }
}
