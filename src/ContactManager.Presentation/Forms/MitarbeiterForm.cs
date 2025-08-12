
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ContactManager.Models;

namespace ContactManager.Presentation.Forms
{
    public partial class MitarbeiterForm : Form
    {
        private List<Mitarbeiter> mitarbeiterListe = new();

        public MitarbeiterForm()
        {
            InitializeComponent();
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            var dlg = new MitarbeiterEditForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                mitarbeiterListe.Add(dlg.NeuerMitarbeiter);
                RefreshGrid();
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var index = dataGridView.SelectedRows[0].Index;
                mitarbeiterListe.RemoveAt(index);
                RefreshGrid();
            }
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            string suchbegriff = txtSuche.Text.ToLower();
            var gefiltert = mitarbeiterListe.Where(m =>
                m.Vorname.ToLower().Contains(suchbegriff) ||
                m.Nachname.ToLower().Contains(suchbegriff) ||
                m.MitarbeitendenNummer.ToString().Contains(suchbegriff)).ToList();

            dataGridView.DataSource = null;
            dataGridView.DataSource = gefiltert;
        }

        private void RefreshGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = mitarbeiterListe;
        }
    }
}
