using ContactManager.Application.Abstractions.UseCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Application.Abstractions.Dtos;

namespace ContactManager.Presentation.Forms
{
    public partial class Contacts : Form
    {

        private readonly IContactQueries _queries;
        private readonly IContactCommands _commands;
        public Contacts(IContactQueries queries, IContactCommands commands)
        {
            _queries = queries;
            _commands = commands;

            InitializeComponent();
        }

        //Aktion Neuer Kontakt 2. Formular öffnen
        private void btnSearch1_Click(object sender, EventArgs e)
        {
            // Instanz vom Form "Details" erstellen
            Details detailsForm = new Details();

            // Modal öffnen
            detailsForm.ShowDialog();
        }

        //Grid mit Datensatz
        private void grdContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //Bearbeiten 
            // Instanz vom Form "Details" erstellen
            Details detailsForm = new Details();

            // Modal öffnen
            detailsForm.ShowDialog();
        }

        //Aktion Neuer Kontakt
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        //Textbox für die Suche

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }

        //Aktion (Wenn ausgewählt löschen)
        private void btnloeschen_Click(object sender, EventArgs e)
        {

        }
    }
}
