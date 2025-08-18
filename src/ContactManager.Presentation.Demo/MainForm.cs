using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Application.Abstractions.Dtos;
using ContactManager.Application.Abstractions.UseCases;

namespace ContactManager.Presentation.Demo
{
    public class MainForm : Form
    {
        private readonly IContactQueries _queries;
        private readonly IContactCommands _commands;

        private TextBox _txtSearch;
        private Button _btnSearch;
        private Button _btnNew;
        private DataGridView _grid;

        public MainForm(IContactQueries queries, IContactCommands commands)
        {
            _queries = queries;
            _commands = commands;

            Text = "Contact Manager – Demo";
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleMode = AutoScaleMode.Font;
            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(900, 600);

            BuildUi();
            Shown += async (_, __) => await LoadDataAsync();
        }

        private void BuildUi()
        {
            var root = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3
            };
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));       // header
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 100));   // grid
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));       // footer
            Controls.Add(root);

            // ---- Header (no squished button)
            var header = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                AutoSize = true,
                Padding = new Padding(6)
            };
            header.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100)); // stretch search
            header.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));     // button natural

            _txtSearch = new TextBox { Dock = DockStyle.Fill, PlaceholderText = "Search name, company, email, employee no…" };
            _btnSearch = new Button { Text = "Search", AutoSize = true, Margin = new Padding(6, 0, 0, 0) };
            _btnSearch.Click += async (_, __) => await LoadDataAsync(_txtSearch.Text);

            header.Controls.Add(_txtSearch, 0, 0);
            header.Controls.Add(_btnSearch, 1, 0);
            root.Controls.Add(header, 0, 0);

            // ---- Grid
            _grid = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoGenerateColumns = false,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                AllowUserToAddRows = false
            };
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Employee #", DataPropertyName = "EmployeeNumber", Width = 140 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Type", DataPropertyName = "Type", Width = 100 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "First Name", DataPropertyName = "FirstName", Width = 140 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Last Name", DataPropertyName = "LastName", Width = 140 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Status", DataPropertyName = "Status", Width = 80 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Email", DataPropertyName = "Email", Width = 200 });
            _grid.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Company", DataPropertyName = "CompanyName", Width = 140 });

            _grid.CellDoubleClick += async (_, e) =>
            {
                if (e.RowIndex < 0) return;
                if (_grid.Rows[e.RowIndex].DataBoundItem is not ContactListItemDto item) return;

                var details = await _queries.GetByIdAsync(item.Id);
                using (var dlg = new DetailsForm(details, _commands))
                {
                    dlg.ShowDialog(this);
                }
                await LoadDataAsync(_txtSearch.Text);
            };

            root.Controls.Add(_grid, 0, 1);

            // ---- Footer
            var footer = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, Padding = new Padding(6) };
            _btnNew = new Button { Text = "New", AutoSize = true };
            _btnNew.Click += async (_, __) =>
            {
                using var dlg = new NewContactForm();
                if (dlg.ShowDialog(this) != DialogResult.OK) return;

                var dto = dlg.AsContactDetailsDto();
                var res = await _commands.CreateContactAsync(dto);
                if (!res.Success)
                {
                    MessageBox.Show(this, res.Error, "Create failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                await LoadDataAsync(_txtSearch.Text);

                // Select the newly created contact
                var list = (_grid.DataSource as BindingList<ContactListItemDto>)?.ToList();
                if (list is not null)
                {
                    var idx = list.FindIndex(x => x.Id == res.Value);
                    if (idx >= 0)
                    {
                        _grid.ClearSelection();
                        _grid.CurrentCell = _grid.Rows[idx].Cells[0];
                        _grid.Rows[idx].Selected = true;
                    }
                }
            };
            footer.Controls.Add(_btnNew);
            root.Controls.Add(footer, 0, 2);
        }

        private async Task LoadDataAsync(string search = "")
        {
            var filter = new ContactFilterDto { Search = search ?? "" };
            var data = await _queries.GetContactsAsync(filter);
            _grid.DataSource = new BindingList<ContactListItemDto>(data.ToList());
        }
    }
}
