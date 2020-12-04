using System;
using System.Windows.Forms;

namespace FileConfigurator
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  Desarrollado por Johan Valerio Mitma Huaccha
        ///  UNMSM 2020
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FramePrincipal());
        }
    }
}
