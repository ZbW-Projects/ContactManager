
using System;
using System.Windows.Forms;
using ContactManager.Models;

namespace ContactManager.Presentation.Forms {
    public partial class MitarbeiterEditForm : Form {
        public Mitarbeiter NeuerMitarbeiter { get; private set; }

        public MitarbeiterEditForm() {
            InitializeComponent();
        }

        private void btnSpeichern_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(txtVorname.Text) || string.IsNullOrWhiteSpace(txtNachname.Text)) {
                MessageBox.Show("Vorname und Nachname sind Pflichtfelder.");
                return;
            }

            NeuerMitarbeiter = new Mitarbeiter {
                Vorname = txtVorname.Text,
                Nachname = txtNachname.Text,
                Eintrittsdatum = dtpEintritt.Value,
                Aktiv = chkAktiv.Checked
            };
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
