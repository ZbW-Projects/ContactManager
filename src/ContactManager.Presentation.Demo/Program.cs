using System;
using WinApp = System.Windows.Forms.Application;
using ContactManager.Application.Abstractions.UseCases;
using ContactManager.Application.Fakes;

namespace ContactManager.Presentation.Demo
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            IContactQueries queries = new FakeContactsService();
            IContactCommands commands = (IContactCommands)queries;

            WinApp.Run(new MainForm(queries, commands));
        }
    }
}
