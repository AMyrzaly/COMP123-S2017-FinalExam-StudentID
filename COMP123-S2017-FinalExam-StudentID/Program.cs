using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Abubakir Myrzaly
 * Date: 8/17/2017
 * StudentID: 300931945
 * Description: Drive Class
 * Version: 0.1 Just creat form
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashForm());
        }
    }
}
