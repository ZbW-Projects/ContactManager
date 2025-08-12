using System;
using System.Windows.Forms;
using ContactManager.Presentation.Demo.Forms;
using ContactManager.Presentation.Demo.Services;

namespace ContactManager.Presentation.Demo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // composition root

            var service = new InMemoryContacts(); // later : swap with real service
            Application.Run(new MainForm(service));
        }
    }
}
