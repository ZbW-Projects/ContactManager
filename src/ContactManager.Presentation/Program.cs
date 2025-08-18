using ContactManager.Application.Abstractions.UseCases;
using ContactManager.Application.Fakes;
using ContactManager.Presentation.Forms;
using System;
using WinApp = System.Windows.Forms.Application;

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

            WinApp.Run(new Contacts(queries, commands));
        }
    }
}
