using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ContactManager.Application.Abstractions.Dtos;
using ContactManager.Application.Abstractions.UseCases;

namespace ContactManager.Presentation.Demo
{
    public class DetailsForm : Form
    {
        private readonly IContactCommands _commands;
        private ContactDetailsDto _model;

        // Person (oben links)
        TextBox txtFirst, txtLast, txtEmail, txtPhone, txtStatus, txtType, txtEmpNo, txtDept, txtRole;
        DateTimePicker dpEntry, dpLeave; // optional mit ShowCheckBox

        // Firma (oben rechts)
        TextBox txtCompany, txtCompanyEmail, txtCompanyPhone;
        TextBox txtCStreet, txtCHouseNo, txtCZip, txtCCity, txtCState, txtCCountry;

        // Unten – Personal oder Protokoll
        Panel paneBottom;

        // Personal (MA/Lernende)
        TextBox txtAhv, txtNationality, txtGender, txtPrivEmail, txtPrivPhone;
        DateTimePicker dpBirth;
        TextBox txtPStreet, txtPHouseNo, txtPZip, txtPCity, txtPState, txtPCountry;

        // Protokoll (Kunden)
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

            var top = new SplitContainer { Dock = DockStyle.Fill, Orientation = Orientation.Vertical, SplitterDistance = 520 };
            root.Controls.Add(top, 0, 0);

            // -------- Person (links)
            var left = TwoCol();
            txtEmpNo = AddRow(left, "Employee #");
            txtType = AddRow(left, "Type");
            txtStatus = AddRow(left, "Status");
            txtFirst = AddRow(left, "First Name");
            txtLast = AddRow(left, "Last Name");
            txtEmail = AddRow(left, "Email");
            txtPhone = AddRow(left, "Phone");
            txtDept = AddRow(left, "Department");
            txtRole = AddRow(left, "Role");
            dpEntry = AddDateRow(left, "Entry Date");
            dpLeave = AddDateRow(left, "Leave Date (optional)", showCheckBox: true);
            top.Panel1.Controls.Add(left);

            // -------- Firma (rechts)
            var right = TwoCol();
            txtCompany = AddRow(right, "Company");
            txtCompanyEmail = AddRow(right, "Company Email");
            txtCompanyPhone = AddRow(right, "Company Phone");
            txtCStreet = AddRow(right, "Street");
            txtCHouseNo = AddRow(right, "House No");
            txtCZip = AddRow(right, "ZIP");
            txtCCity = AddRow(right, "City");
            txtCState = AddRow(right, "State");
            txtCCountry = AddRow(right, "Country");
            top.Panel2.Controls.Add(right);

            // -------- Unten (wechselnd)
            paneBottom = new Panel { Dock = DockStyle.Fill };
            root.Controls.Add(paneBottom, 0, 1);

            // -------- Footer
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
            var tb = new TextBox { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 300 };
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(tb, 1, tl.RowCount);
            tl.RowCount++;
            return tb;
        }

        private DateTimePicker AddDateRow(TableLayoutPanel tl, string label, bool showCheckBox = false)
        {
            tl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var lbl = new Label { Text = label, AutoSize = true, Anchor = AnchorStyles.Left, Padding = new Padding(0, 6, 0, 0) };
            var dp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                ShowCheckBox = showCheckBox,
                Anchor = AnchorStyles.Left
            };
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(dp, 1, tl.RowCount);
            tl.RowCount++;
            return dp;
        }

        private void BindModel()
        {
            // Person
            txtEmpNo.Text = _model.EmployeeNumber;
            txtType.Text = _model.Type;
            txtStatus.Text = _model.Status;
            txtFirst.Text = _model.FirstName;
            txtLast.Text = _model.LastName;
            txtEmail.Text = _model.Email;
            txtPhone.Text = _model.PhoneNumber;
            txtDept.Text = _model.Department;
            txtRole.Text = _model.Role;
            dpEntry.Value = _model.EntryDate == default ? DateTime.Today : _model.EntryDate;
            dpLeave.Checked = _model.LeaveDate.HasValue;
            dpLeave.Value = _model.LeaveDate ?? DateTime.Today;

            // Firma + Adresse
            txtCompany.Text = _model.Company?.Name;
            txtCompanyEmail.Text = _model.Company?.Email;
            txtCompanyPhone.Text = _model.Company?.PhoneNumber;
            txtCStreet.Text = _model.Company?.Address?.Street;
            txtCHouseNo.Text = _model.Company?.Address?.HouseNumber;
            txtCZip.Text = _model.Company?.Address?.ZipCode;
            txtCCity.Text = _model.Company?.Address?.City;
            txtCState.Text = _model.Company?.Address?.State;
            txtCCountry.Text = _model.Company?.Address?.Country;

            // Unten: abhängig vom Typ
            paneBottom.Controls.Clear();

            if (string.Equals(_model.Type, "Customer", StringComparison.OrdinalIgnoreCase))
            {
                var bottom = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, Padding = new Padding(6) };
                bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55));
                bottom.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45));

                // Liste Protokolle
                var left = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 2 };
                left.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                left.RowStyles.Add(new RowStyle(SizeType.Percent, 100));
                left.Controls.Add(new Label { Text = "Protocol History", AutoSize = true, Font = new Font(Font, FontStyle.Bold) }, 0, 0);

                lstProtocol = new ListBox { Dock = DockStyle.Fill };
                var items = (_model.Protocol ?? Enumerable.Empty<ProtocolDto>())
                    .OrderByDescending(p => p.Date)
                    .Select(p => $"{p.Date:yyyy-MM-dd}  {p.Author}: {p.Message}")
                    .ToArray();
                lstProtocol.Items.AddRange(items);
                left.Controls.Add(lstProtocol, 0, 1);

                // Eingabe rechts – Owner Feld größer
                var right = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 3 };
                right.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                right.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                right.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

                right.Controls.Add(new Label { Text = "Owner (Author)", AutoSize = true }, 0, 0);
                txtOwner = new TextBox { Anchor = AnchorStyles.Left | AnchorStyles.Right, Width = 400 };
                right.Controls.Add(txtOwner, 0, 1);

                txtNote = new TextBox
                {
                    Multiline = true,
                    AcceptsReturn = true,
                    ScrollBars = ScrollBars.Vertical,
                    Dock = DockStyle.Fill,
                    PlaceholderText = "Write a protocol note…"
                };
                right.Controls.Add(txtNote, 0, 2);

                btnAddNote = new Button { Text = "Save Note", AutoSize = true, Anchor = AnchorStyles.Right };
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
                    else
                    {
                        MessageBox.Show(this, res.Error, "Add note failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                };
                // Button unter die Notiz
                right.Controls.Add(btnAddNote);

                bottom.Controls.Add(left, 0, 0);
                bottom.Controls.Add(right, 1, 0);
                paneBottom.Controls.Add(bottom);
            }
            else
            {
                // PersonalData inkl. Adresse
                var grid = TwoCol();

                txtAhv = AddRow(grid, "AHV");
                txtNationality = AddRow(grid, "Nationality");
                txtGender = AddRow(grid, "Gender");
                dpBirth = AddDateRow(grid, "Birth Date");

                txtPrivEmail = AddRow(grid, "Private Email");
                txtPrivPhone = AddRow(grid, "Private Phone");

                grid.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                grid.Controls.Add(new Label { Text = "Personal Address", Font = new Font(Font, FontStyle.Bold), AutoSize = true, Padding = new Padding(0, 12, 0, 0) }, 0, grid.RowCount);
                grid.Controls.Add(new Label { Text = "", AutoSize = true }, 1, grid.RowCount);
                grid.RowCount++;

                txtPStreet = AddRow(grid, "Street");
                txtPHouseNo = AddRow(grid, "House No");
                txtPZip = AddRow(grid, "ZIP");
                txtPCity = AddRow(grid, "City");
                txtPState = AddRow(grid, "State");
                txtPCountry = AddRow(grid, "Country");

                // Bind
                txtAhv.Text = _model.PersonalData?.AHVNumber;
                txtNationality.Text = _model.PersonalData?.Nationality;
                txtGender.Text = _model.PersonalData?.Gender;
                dpBirth.Value = _model.PersonalData?.BirthDate ?? DateTime.Today;
                txtPrivEmail.Text = _model.PersonalData?.Email;
                txtPrivPhone.Text = _model.PersonalData?.Phone;
                txtPStreet.Text = _model.PersonalData?.Address?.Street;
                txtPHouseNo.Text = _model.PersonalData?.Address?.HouseNumber;
                txtPZip.Text = _model.PersonalData?.Address?.ZipCode;
                txtPCity.Text = _model.PersonalData?.Address?.City;
                txtPState.Text = _model.PersonalData?.Address?.State;
                txtPCountry.Text = _model.PersonalData?.Address?.Country;

                paneBottom.Controls.Add(grid);
            }
        }

        private void ToggleEdit(bool on)
        {
            editMode = on;

            // Alle TextBoxen schreibbar/readonly
            void setRO(Control c)
            {
                if (c is TextBox tb) tb.ReadOnly = !on;
                foreach (Control k in c.Controls) setRO(k);
            }
            foreach (Control c in Controls) setRO(c);

            dpEntry.Enabled = on;
            dpLeave.Enabled = on;

            btnEditSave.Text = on ? "Save" : "Edit";
        }

        private async System.Threading.Tasks.Task OnEditSaveAsync()
        {
            if (!editMode)
            {
                ToggleEdit(true);
                return;
            }

            var updatedCompany = new CompanyDto
            {
                Id = _model.Company?.Id ?? 0,
                Name = txtCompany.Text,
                Email = txtCompanyEmail.Text,
                PhoneNumber = txtCompanyPhone.Text,
                Address = new AddressDto
                {
                    Street = txtCStreet.Text,
                    HouseNumber = txtCHouseNo.Text,
                    ZipCode = txtCZip.Text,
                    City = txtCCity.Text,
                    State = txtCState.Text,
                    Country = txtCCountry.Text
                }
            };

            PersonalDataDto updatedPersonal = null;
            if (!string.Equals(_model.Type, "Customer", StringComparison.OrdinalIgnoreCase))
            {
                updatedPersonal = new PersonalDataDto
                {
                    AHVNumber = txtAhv?.Text,
                    BirthDate = dpBirth?.Value.Date,
                    Gender = txtGender?.Text,
                    Nationality = txtNationality?.Text,
                    Email = txtPrivEmail?.Text,
                    Phone = txtPrivPhone?.Text,
                    Address = new AddressDto
                    {
                        Street = txtPStreet?.Text,
                        HouseNumber = txtPHouseNo?.Text,
                        ZipCode = txtPZip?.Text,
                        City = txtPCity?.Text,
                        State = txtPState?.Text,
                        Country = txtPCountry?.Text
                    }
                };
            }

            var update = new ContactDetailsDto
            {
                FirstName = txtFirst.Text,
                LastName = txtLast.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Status = txtStatus.Text,
                Department = txtDept.Text,
                Role = txtRole.Text,
                EntryDate = dpEntry.Value.Date,
                LeaveDate = dpLeave.ShowCheckBox && dpLeave.Checked ? dpLeave.Value.Date : (DateTime?)null,
                Company = updatedCompany,
                PersonalData = updatedPersonal
            };

            var res = await _commands.UpdateContactAsync(_model.Id, update);
            if (!res.Success)
            {
                MessageBox.Show(this, res.Error, "Update failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Lokales Modell refreshen (minimal)
            _model.FirstName = update.FirstName;
            _model.LastName = update.LastName;
            _model.Email = update.Email;
            _model.PhoneNumber = update.PhoneNumber;
            _model.Status = update.Status;
            _model.Department = update.Department;
            _model.Role = update.Role;
            _model.EntryDate = update.EntryDate;
            _model.LeaveDate = update.LeaveDate;
            _model.Company = update.Company;
            _model.PersonalData = update.PersonalData;

            ToggleEdit(false);
            Close(); // UX: nach Save schließen
        }
    }
}
