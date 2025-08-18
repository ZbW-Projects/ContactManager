using System;
using System.Windows.Forms;

namespace ContactManager.Presentation
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.Contacts()); // Startet das Contacts-Formular
        }
    }
}
