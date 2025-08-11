
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ContactManager.Models;

namespace ContactManager.Presentation.Forms {
    public partial class KundenForm : Form
    {
        private List<Kunde> kundenListe = new();

        public KundenForm()
        {
            InitializeComponent();
        }

        private void btnNeu_Click(object sender, EventArgs e)
        {
            var dlg = new KundenEditForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                kundenListe.Add(dlg.NeuerKunde);
                RefreshGrid();
            }
        }

        private void btnLoeschen_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                var index = dataGridView.SelectedRows[0].Index;
                kundenListe.RemoveAt(index);
                RefreshGrid();
            }
        }

        private void btnSuchen_Click(object sender, EventArgs e)
        {
            string suchbegriff = txtSuche.Text.ToLower();
            var gefiltert = kundenListe.Where(k =>
                k.Vorname.ToLower().Contains(suchbegriff) ||
                k.Nachname.ToLower().Contains(suchbegriff) ||
                k.Firmenname.ToLower().Contains(suchbegriff)).ToList();

            dataGridView.DataSource = null;
            dataGridView.DataSource = gefiltert.Select(k => new
            {
                k.Firmenname,
                k.Vorname,
                k.Nachname,
                Notizen = k.Notizen.Count,
                Status = k.Aktiv ? "Aktiv" : "Passiv"
            }).ToList();
        }

        private void RefreshGrid()
        {
            dataGridView.DataSource = null;
            dataGridView.DataSource = kundenListe.Select(k => new
            {
                k.Firmenname,
                k.Vorname,
                k.Nachname,
                Notizen = k.Notizen.Count,
                Status = k.Aktiv ? "Aktiv" : "Passiv"
            }).ToList();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
