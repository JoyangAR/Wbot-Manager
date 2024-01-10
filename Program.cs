using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WbotMgr
{
    internal static class Program
    {
        /// <summary>
        /// App's Entry Point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
