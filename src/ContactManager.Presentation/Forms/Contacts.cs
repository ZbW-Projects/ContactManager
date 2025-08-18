using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.Presentation.Forms
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
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

        }

        //Aktion Neuer Kontakt
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
        //Textbox für die Suche

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
