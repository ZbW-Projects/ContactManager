using ContactManager.Core.Services;
using ContactManager.View.Forms.Components;
using System.ComponentModel;

namespace ContactManager.View.Forms
{
    public partial class Contacts : Form
    {
        // Zentrale Binding-Quelle für das Grid
        private readonly BindingSource _binding = new();
        public Contacts()
        {
            InitializeComponent();
            ConfigureGrid();
            WireEvents();
        }
        private void Contacts_Load(object sender, EventArgs e)
        {
            ReloadGrid();  // Starte Datenladung
        }

        #region Visuelles Design der Tabelle
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

            // Meta Daten

            grdContacts.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Id",
                DataPropertyName = "Id",
                Visible = false
            });

            grdContacts.DataSource = _binding;
        }
        #endregion

        #region Events für die Tabelle (Zeilen)
        private void WireEvents()
        {
            this.Load += Contacts_Load;

            // Buttons suche
            btnSearch.Click += (s, e) => DoSearch();
            txtSearch.TextChanged += (s, e) => {/* Für live filtern DoSearch() */};

            //Doppelklick: Detail öffnen
            grdContacts.CellDoubleClick += (s, e) => OpenSelected();
        }

        #endregion

        #region Aktionen (Use Cases Aufrufe und UI Updates)
        private void ReloadGrid()
        {
            var rows = Controller.GetList().ToList();
            _binding.DataSource = new BindingList<DtoPersonRow>(rows);
            _binding.ResetBindings(false);
            grdContacts.ClearSelection();
            grdContacts.Refresh();
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
            if (grdContacts.CurrentRow?.DataBoundItem is not DtoPersonRow row)
            { InputBox.Error("Die Daten enthalten einen Fehler oder sind unvollständig."); return; }

            using var detailsForm = new Details(row.Id, row.Type);
            detailsForm.ShowDialog(this);
            ReloadGrid();
        }

        #endregion

        #region Window Designer generiertes code

        //Öffnet das Detail-Form für Neue Kontakte
        private void btnSearch1_Click(object sender, EventArgs e)
        {
            // Instanz vom Form "Details" erstellen
            Details detailsForm = new Details();
            // Modal öffnen
            detailsForm.ShowDialog(this);
            ReloadGrid();
        }

        //Grid Zellklick triggert Methode OpenSelected
        private void grdContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenSelected();
        }

        // Suche Button 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DoSearch();
        }

        //Aktion (Wenn ausgewählt löschen)
        private void btnloeschen_Click(object sender, EventArgs e)
        {
            if (grdContacts.CurrentRow?.DataBoundItem is not DtoPersonRow row)
            {
                InputBox.Warning("Bitte zuerst einen Kontakt auswählen.");
                return;
            }

            var name = $"{row.FirstName} {row.LastName}";
            var ask = MessageBox.Show(
                $"Kontakt {name} ({row.Type}) wirklich löschen?",
                "Löschen bestätigen",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (ask != DialogResult.Yes) return;

            // KISS: ein Controller-Call, der intern je nach Type löscht
            var (ok, msg) = Controller.DeleteContact(row.Id);

            if (!ok) { InputBox.Error(msg); return; }

            InputBox.Info("Kontakt wurde gelöscht.");
            ReloadGrid();
        }

        #endregion
    }
}
