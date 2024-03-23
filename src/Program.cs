using System;
using System.Windows.Forms;

namespace WbotMgr
{
    internal static class Program
    {
        /// <summary>
        /// App's Entry Point.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new SplashScreenfrm());
        }
    }
}