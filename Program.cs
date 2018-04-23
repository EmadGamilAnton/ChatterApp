using System;
using System.Windows.Forms;

namespace ChattApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        public static string FullName;
        public static int userID;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
        
            Application.Run(new loginForm()); //first form to excute.
        }
    }
}
