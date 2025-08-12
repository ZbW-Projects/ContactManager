using System;
using System.Windows.Forms;
using WinFormsApp = System.Windows.Forms.Application;

using ContactManager.Presentation.Demo.Forms;
using ContactManager.Presentation.Demo.Services;

namespace ContactManager.Presentation.Demo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            WinFormsApp.EnableVisualStyles();
            WinFormsApp.SetCompatibleTextRenderingDefault(false);
            WinFormsApp.SetHighDpiMode(HighDpiMode.SystemAware);

            var service = new InMemoryContacts(); // later: swap with real service
            WinFormsApp.Run(new MainForm(service));
        }
    }
}
