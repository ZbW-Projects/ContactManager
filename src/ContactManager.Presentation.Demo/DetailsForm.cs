using System;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Application.Abstractions.Dtos;
using ContactManager.Application.Abstractions.UseCases;

namespace ContactManager.Presentation.Demo
{
    public class DetailsForm : Form
    {
        private readonly IContactCommands _commands;
        private ContactDetailsDto _model;

        // top-left (person)
        TextBox txtFirst, txtLast, txtEmail, txtPhone, txtStatus, txtType, txtEmpNo;
        DateTimePicker dpEntry, dpLeave;

        // top-right (company)
        TextBox txtCompany, txtCompanyEmail, txtCompanyPhone, txtCompanyCity;

        // bottom – personal OR protocol
        Panel paneBottom;
        // personal (worker/trainee)
        TextBox txtAhv, txtNationality, txtGender;
        DateTimePicker dpBirth;
        // protocol (customer)
        ListBox lstProtocol;
        TextBox txtOwner, txtNote;
        Button btnAddNote;

        Button btnEditSave;
        bool editMode = false;

        public DetailsForm(ContactDetailsDto model, IContactCommands commands)
        {
            _model = model;
            _commands = commands;

            Text = $"Details – {_model.FirstName} {_model.LastName}";
            AutoScaleMode = AutoScaleMode.Font;
            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterParent;

            BuildUi();
            BindModel();
            ToggleEdit(false);
        }

        private void BuildUi()
        {
            var root = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 3, Padding = new Padding(6) };
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Controls.Add(root);

            var top = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Vertical, SplitterDistance = 500 };
            root.Controls.Add(top, 0, 0);

            // Left (person)
            var left = TwoCol();
            txtEmpNo = AddRow(left, "Employee #");
            txtType = AddRow(left, "Type");
            txtStatus = AddRow(left, "Status");
            txtFirst = AddRow(left, "First Name");
            txtLast = AddRow(left, "Last Name");
            txtEmail = AddRow(left, "Email");
            txtPhone = AddRow(left, "Phone");
            dpEntry = AddDateRow(left, "Entry Date");
            dpLeave = AddDateRow(left, "Leave Date");
            top.Panel1.Controls.Add(left);

            // Right (company)
            var right = TwoCol();
            txtCompany = AddRow(right, "Company");
            txtCompanyEmail = AddRow(right, "Company Email");
            txtCompanyPhone = AddRow(right, "Company Phone");
            txtCompanyCity = AddRow(right, "Company City");
            top.Panel2.Controls.Add(right);

            // Bottom swappable panel
            paneBottom = new Panel { Dock = DockStyle.Fill };
            root.Controls.Add(paneBottom, 0, 1);

            // Footer
            var footer = new FlowLayoutPanel { Dock = DockStyle.Fill, AutoSize = true, FlowDirection = FlowDirection.RightToLeft };
            btnEditSave = new Button { Text = "Edit", AutoSize = true };
            btnEditSave.Click += async (_, __) => await OnEditSaveAsync();
            footer.Controls.Add(btnEditSave);
            root.Controls.Add(footer, 0, 2);
        }

        private TableLayoutPanel TwoCol()
        {
            var t = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
            t.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            return t;
        }

        private TextBox AddRow(TableLayoutPanel tl, string label)
        {
            tl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var lbl = new Label { Text = label, AutoSize = true, Anchor = AnchorStyles.Left, Padding = new Padding(0, 6, 0, 0) };
            var tb = new TextBox { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 260 };
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(tb, 1, tl.RowCount);
            tl.RowCount++;
            return tb;
        }

        private DateTimePicker AddDateRow(TableLayoutPanel tl, string label)
        {
            tl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var lbl = new Label { Text = label, AutoSize = true, Anchor = AnchorStyles.Left, Padding = new Padding(0, 6, 0, 0) };
            var dp = new DateTimePicker { Format = DateTimePickerFormat.Short, Anchor = AnchorStyles.Left };
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(dp, 1, tl.RowCount);
            tl.RowCount++;
            return dp;
        }

        private void BindModel()
        {
            txtEmpNo.Text = _model.EmployeeNumber;
            txtType.Text = _model.Type;
            txtStatus.Text = _model.Status;
            txtFirst.Text = _model.FirstName;
            txtLast.Text = _model.LastName;
            txtEmail.Text = _model.Email;
            txtPhone.Text = _model.PhoneNumber;
            dpEntry.Value = _model.EntryDate == default ? DateTime.Today : _model.EntryDate;
            dpLeave.Value = _model.LeaveDate ?? DateTime.Today;

            txtCompany.Text = _model.Company?.Name;
            txtCompanyEmail.Text = _model.Company?.Email;
            txtCompanyPhone.Text = _model.Company?.PhoneNumber;
            txtCompanyCity.Text = _model.Company?.Address?.City;

            paneBottom.Controls.Clear();

            if (string.Equals(_model.Type, "Customer", StringComparison.OrdinalIgnoreCase))
            {
                var bottom = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2 };
                bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                lstProtocol = new ListBox { Dock = DockStyle.Fill };
                var items = (_model.Protocol ?? Enumerable.Empty<ProtocolDto>())
                    .OrderByDescending(p => p.Date)
                    .Select(p => $"{p.Date:yyyy-MM-dd}  {p.Author}: {p.Message}")
                    .ToArray();
                lstProtocol.Items.AddRange(items);
                bottom.Controls.Add(lstProtocol, 0, 0);

                var notePane = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 3 };
                notePane.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                notePane.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                notePane.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                txtOwner = new TextBox { PlaceholderText = "Owner (Author)" };
                txtNote = new TextBox { Multiline = true, Height = 120, Dock = DockStyle.Fill, PlaceholderText = "Write a protocol note…" };
                btnAddNote = new Button { Text = "Save Note" };
                btnAddNote.Click += async (_, __) =>
                {
                    var dto = new ProtocolDto
                    {
                        Author = string.IsNullOrWhiteSpace(txtOwner.Text) ? "System" : txtOwner.Text.Trim(),
                        Message = txtNote.Text
                    };
                    var res = await _commands.AddNoteAsync(_model.Id, dto);
                    if (res.Success)
                    {
                        lstProtocol.Items.Insert(0, $"{DateTime.UtcNow:yyyy-MM-dd}  {dto.Author}: {dto.Message}");
                        txtNote.Clear();
                    }
                    else MessageBox.Show(this, res.Error, "Add note failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                };
                notePane.Controls.Add(txtOwner, 0, 0);
                notePane.Controls.Add(txtNote, 0, 1);
                notePane.Controls.Add(btnAddNote, 0, 2);

                bottom.Controls.Add(notePane, 1, 0);
                paneBottom.Controls.Add(bottom);
            }
            else
            {
                var grid = TwoCol();
                txtAhv = AddRow(grid, "AHV");
                txtNationality = AddRow(grid, "Nationality");
                txtGender = AddRow(grid, "Gender");
                dpBirth = AddDateRow(grid, "Birth Date");

                txtAhv.Text = _model.PersonalData?.AHVNumber;
                txtNationality.Text = _model.PersonalData?.Nationality;
                txtGender.Text = _model.PersonalData?.Gender;
                dpBirth.Value = _model.PersonalData?.BirthDate ?? DateTime.Today;

                paneBottom.Controls.Add(grid);
            }
        }

        private void ToggleEdit(bool on)
        {
            editMode = on;
            foreach (var tb in new[] { txtFirst, txtLast, txtEmail, txtPhone, txtStatus, txtCompany, txtCompanyEmail, txtCompanyPhone, txtCompanyCity })
                if (tb != null) tb.ReadOnly = !on;
            dpEntry.Enabled = on;
            dpLeave.Enabled = on;

            btnEditSave.Text = on ? "Save" : "Edit";
        }

        private async Task OnEditSaveAsync()
        {
            if (!editMode)
            {
                ToggleEdit(true);
                return;
            }

            var update = new ContactDetailsDto
            {
                FirstName = txtFirst.Text,
                LastName = txtLast.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Status = txtStatus.Text,
                EntryDate = dpEntry.Value.Date,
                LeaveDate = dpLeave.Value.Date,
                Company = new CompanyDto
                {
                    Id = _model.Company?.Id ?? 0,
                    Name = txtCompany.Text,
                    Email = txtCompanyEmail.Text,
                    PhoneNumber = txtCompanyPhone.Text,
                    Address = new AddressDto
                    {
                        City = txtCompanyCity.Text,
                        Street = _model.Company?.Address?.Street,
                        HouseNumber = _model.Company?.Address?.HouseNumber,
                        ZipCode = _model.Company?.Address?.ZipCode,
                        State = _model.Company?.Address?.State,
                        Country = _model.Company?.Address?.Country
                    }
                }
            };

            var res = await _commands.UpdateContactAsync(_model.Id, update);
            if (!res.Success)
            {
                MessageBox.Show(this, res.Error, "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // refresh local model minimally
            _model.FirstName = update.FirstName;
            _model.LastName = update.LastName;
            _model.Email = update.Email;
            _model.PhoneNumber = update.PhoneNumber;
            _model.Status = update.Status;
            _model.EntryDate = update.EntryDate;
            _model.LeaveDate = update.LeaveDate;
            _model.Company = update.Company;

            ToggleEdit(false);
            Close(); // UX: close after save
        }
    }
}
