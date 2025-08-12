using ContactManager.Presentation.Demo.Models;
using ContactManager.Presentation.Demo.Services;
using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace ContactManager.Presentation.Demo.Forms
{
    public class MainForm : Form
    {
        private readonly IContacts _contacts;
        private TextBox _txtSearch;
        private Button _btnSearch, _btnAdd;
        private DataGridView _grid;
        private BindingList<Contact> _view = new BindingList<Contact>();

        public MainForm(IContacts contacts)
        {
            _contacts = contacts;
            Text = "Contact Manager";
            Width = 800; Height = 520; StartPosition = FormStartPosition.CenterScreen;
            InitializeUi();
            BindData(_contacts.GetAll());
        }

        private void InitializeUi()
        {
            var root = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 2 };
            root.RowStyles.Add(new RowStyle(SizeType.Absolute, 56));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
            Controls.Add(root);

            // Header
            var header = new FlowLayoutPanel { Dock = DockStyle.Fill, Padding = new Padding(12) };
            _txtSearch = new TextBox { Width = 320 };
            _btnSearch = new Button { Text = "Suchen", AutoSize = true };
            _btnAdd = new Button { Text = "Kontakt hinzufügen", AutoSize = true };
            _btnSearch.Click += (_, __) => BindData(_contacts.Search(_txtSearch.Text));
            _btnAdd.Click += BtnAdd_Click;
            header.Controls.AddRange(new Control[] { _txtSearch, _btnSearch, _btnAdd });
            root.Controls.Add(header, 0, 0);

            // Grid
            _grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = false,
                AllowUserToAddRows = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Vorname", DataPropertyName = "Surname", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Nachname", DataPropertyName = "Lastname", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 20 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Typ", DataPropertyName = "Type", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status", AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "E-Mail", DataPropertyName = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, FillWeight = 40 });
            _grid.DoubleClick += Grid_DoubleClick;

            _grid.DataSource = _view;
            root.Controls.Add(_grid, 0, 1);
        }

        private void BindData(BindingList<Contact> list)
        {
            _view.RaiseListChangedEvents = false;
            _view.Clear();
            foreach (var x in list) _view.Add(x);
            _view.RaiseListChangedEvents = true;
            _view.ResetBindings();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using var dlg = new AddForm();
            if (dlg.ShowDialog(this) == DialogResult.OK && dlg.Result != null)
            {
                _contacts.Add(dlg.Result);
                BindData(_contacts.Search(_txtSearch.Text));
            }
        }

        private void Grid_DoubleClick(object sender, EventArgs e)
        {
            if (_grid.CurrentRow?.DataBoundItem is Contact row)
            {
                using var details = new DetailsForm(_contacts, row.Id);
                details.ShowDialog(this);
                BindData(_contacts.Search(_txtSearch.Text));
            }
        }
    }
}
