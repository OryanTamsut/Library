using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Sifria2010.GUI;

namespace Sifria2010
{
    public enum statusKind { add, update, delete, show };
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
            Application.Run(new frmMain());
        }
    }
}
