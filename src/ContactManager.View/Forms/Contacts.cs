using ContactManager.Core.Data;
using ContactManager.View.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Core.Services;

namespace ContactManager.View.Forms
{
    public partial class Contacts : Form
    {
        private readonly BindingSource _binding = new();
        public Contacts()
        {
            InitializeComponent();
            ConfigureGrid();
            WireEvents();
        }

        private void Contacts_Load(object sender, EventArgs e)
        {
            ReloadGrid();
        }

        private void ConfigureGrid()
        {
            grdContacts.AutoGenerateColumns = false;
            grdContacts.AllowUserToAddRows = false;
            grdContacts.ReadOnly = true;
            grdContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdContacts.MultiSelect = false;

            grdContacts.Columns.Clear();

            grdContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Vorname",
                DataPropertyName = "FirstName",   // MUSS exakt dem DTO entsprechen
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25
            });
            grdContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nachname",
                DataPropertyName = "LastName",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill,
                FillWeight = 25
            });
            grdContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Typ",
                DataPropertyName = "Type",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            grdContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "Status",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            grdContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Geschäftsnummer",
                DataPropertyName = "PhoneNumberBuisness",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            grdContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });


            grdContacts.DataSource = _binding;
        }

        private void WireEvents()
        {
            this.Load += Contacts_Load;

            // Buttons suche
            btnSearch.Click += (s, e) => DoSearch();
            txtSearch.TextChanged += (s, e) => {/* Für live filtern DoSearch() */};

            //Doppelklick: Detail öffnen
            grdContacts.CellDoubleClick += (s, e) => OpenSelected();
        }

        private void ReloadGrid()
        {
            // UseCase anbindung
            var rows = Controller.GetList();
            _binding.DataSource = rows;
            grdContacts.ClearSelection();
        }

        private void DoSearch()
        {
            var term = txtSearch.Text?.Trim();
            // UseCase Search
            var rows = Controller.Search(term);
            _binding.DataSource = rows;
            grdContacts.ClearSelection();
        }

        private void OpenSelected()
        {
            if (grdContacts.CurrentRow?.DataBoundItem is DTOPersonRow row)
            {
                // Hier wäre möglich Details-Form öffnen
                var detailsForm = new Details(/* row.Id falls benötigt übergeben*/);
                detailsForm.ShowDialog();
            }
        }
        private void GrdContacts_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
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
            OpenSelected();
        }


        //Aktion Neuer Kontakt
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }
        //Textbox für die Suche

        private void txtSearch_TextChanged_1(object sender, EventArgs e)
        {
            // wenn du live filtern willst:
            // DoSearch();
        }

        //Aktion (Wenn ausgewählt löschen)
        private void btnloeschen_Click(object sender, EventArgs e)
        {
            // optional: hier später Delete-Use-Case aufrufen
        }
    }
}
