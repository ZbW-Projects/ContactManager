
using System;
using System.Windows.Forms;
using ContactManager.Models;

namespace ContactManager.Presentation.Forms {
    public partial class KundenEditForm : Form
    {
        public Kunde NeuerKunde { get; private set; }

        public KundenEditForm()
        {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            NeuerKunde = new Kunde
            {
                Vorname = txtVorname.Text,
                Nachname = txtNachname.Text,
                Firmenname = txtFirma.Text,
                Aktiv = chkAktiv.Checked
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void txtNachname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
