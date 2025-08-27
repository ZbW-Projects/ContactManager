using ContactManager.View.Forms;
using ContactManager.Core.Services;

namespace ContactManager.View
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Controller.SpinData();
            ApplicationConfiguration.Initialize();
            Application.Run(new Contacts());

            // Test 
            var p = Path.Combine(AppContext.BaseDirectory, "Data", "Storage", "contacts.json");
            MessageBox.Show(File.Exists(p) ? $"Gefunden:\n{p}" : $"FEHLT:\n{p}");

        }
    }
}