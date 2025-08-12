using ContactManager.Presentation.Forms; // falls deine Forms dort liegen
using System;
using System.Windows.Forms;

namespace ContactManager.Presentation
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            global::System.Windows.Forms.Application.EnableVisualStyles();
            global::System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

            using var login = new LoginForm();
            if (login.ShowDialog() == DialogResult.OK)
                global::System.Windows.Forms.Application.Run(new MainForm());
        }
    }
}
