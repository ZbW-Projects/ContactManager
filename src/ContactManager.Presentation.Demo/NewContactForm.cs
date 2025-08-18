using System;
using System.Drawing;
using System.Windows.Forms;
using ContactManager.Application.Abstractions.Dtos;

namespace ContactManager.Presentation.Demo
{
    public class NewContactForm : Form
    {
        // Person (oben links)
        ComboBox cbType;
        TextBox txtFirst, txtLast, txtEmail, txtPhone, txtStatus, txtRole, txtDept, txtEmpNo;
        DateTimePicker dpEntry, dpLeave;  // dpLeave optional (ShowCheckBox)

        // Firma (oben rechts)
        TextBox txtCompany, txtCompanyEmail, txtCompanyPhone;
        TextBox txtCStreet, txtCHouseNo, txtCZip, txtCCity, txtCState, txtCCountry;

        // Unten: PersonalData ODER Customer-Protokoll
        Panel paneBottom;

        // PersonalData (MA/Lernende)
        TextBox txtAhv, txtNationality, txtGender, txtPrivEmail, txtPrivPhone;
        DateTimePicker dpBirth;
        TextBox txtPStreet, txtPHouseNo, txtPZip, txtPCity, txtPState, txtPCountry;

        // Protokoll (Kunden)
        TextBox txtOwner, txtNote;

        public NewContactForm()
        {
            Text = "New Contact";
            AutoScaleMode = AutoScaleMode.Font;
            WindowState = FormWindowState.Maximized;
            MinimumSize = new Size(900, 600);
            StartPosition = FormStartPosition.CenterParent;

            BuildUi();
            cbType.SelectedIndexChanged += (_, __) => SwitchBottom();
            cbType.SelectedIndex = 0;   // Employee default
            SwitchBottom();
        }

        private void BuildUi()
        {
            var root = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 3, Padding = new Padding(6) };
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Controls.Add(root);

            var top = new SplitContainer { Dock = DockStyle.Fill, SplitterDistance = 520 };
            root.Controls.Add(top, 0, 0);

            // -------- Person (links)
            var left = TwoCol();
            cbType = AddCombo(left, "Type", "Employee", "Trainee", "Customer");
            txtStatus = AddText(left, "Status", "aktive");
            txtEmpNo = AddText(left, "Employee # (optional)");
            txtFirst = AddText(left, "First Name");
            txtLast = AddText(left, "Last Name");
            txtEmail = AddText(left, "Email");
            txtPhone = AddText(left, "Phone");
            txtRole = AddText(left, "Role");
            txtDept = AddText(left, "Department");
            dpEntry = AddDate(left, "Entry Date", DateTime.Today);
            dpLeave = AddDate(left, "Leave Date (optional)", DateTime.Today, showCheckBox: true);
            dpLeave.Checked = false; // -> optional
            top.Panel1.Controls.Add(left);

            // -------- Firma (rechts)
            var right = TwoCol();
            txtCompany = AddText(right, "Company");
            txtCompanyEmail = AddText(right, "Company Email");
            txtCompanyPhone = AddText(right, "Company Phone");
            txtCStreet = AddText(right, "Street");
            txtCHouseNo = AddText(right, "House No");
            txtCZip = AddText(right, "ZIP");
            txtCCity = AddText(right, "City");
            txtCState = AddText(right, "State");
            txtCCountry = AddText(right, "Country");
            top.Panel2.Controls.Add(right);

            // -------- Unten (wechselnd)
            paneBottom = new Panel { Dock = DockStyle.Fill };
            root.Controls.Add(paneBottom, 0, 1);

            // -------- Footer
            var footer = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, AutoSize = true };
            var btnSave = new Button { Text = "Save", AutoSize = true };
            var btnCancel = new Button { Text = "Cancel", AutoSize = true };
            btnCancel.Click += (_, __) => DialogResult = DialogResult.Cancel;
            btnSave.Click += (_, __) => { DialogResult = DialogResult.OK; Close(); };
            footer.Controls.Add(btnSave);
            footer.Controls.Add(btnCancel);
            root.Controls.Add(footer, 0, 2);
        }

        private TableLayoutPanel TwoCol()
        {
            var t = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, AutoSize = true };
            t.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            return t;
        }

        private ComboBox AddCombo(TableLayoutPanel tl, string label, params string[] items)
        {
            tl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var lbl = new Label { Text = label, AutoSize = true, Padding = new Padding(0, 6, 0, 0) };
            var cb = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 240, Anchor = AnchorStyles.Left | AnchorStyles.Right };
            cb.Items.AddRange(items); cb.SelectedIndex = 0;
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(cb, 1, tl.RowCount);
            tl.RowCount++;
            return cb;
        }

        private TextBox AddText(TableLayoutPanel tl, string label, string defaultText = "")
        {
            tl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var lbl = new Label { Text = label, AutoSize = true, Padding = new Padding(0, 6, 0, 0) };
            var tb = new TextBox { Width = 280, Text = defaultText, Anchor = AnchorStyles.Left | AnchorStyles.Right };
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(tb, 1, tl.RowCount);
            tl.RowCount++;
            return tb;
        }

        private DateTimePicker AddDate(TableLayoutPanel tl, string label, DateTime v, bool showCheckBox = false)
        {
            tl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var lbl = new Label { Text = label, AutoSize = true, Padding = new Padding(0, 6, 0, 0) };
            var dp = new DateTimePicker
            {
                Format = DateTimePickerFormat.Short,
                Value = v,
                ShowCheckBox = showCheckBox,
                Anchor = AnchorStyles.Left
            };
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(dp, 1, tl.RowCount);
            tl.RowCount++;
            return dp;
        }

        private void SwitchBottom()
        {
            paneBottom.Controls.Clear();
            var type = (string)cbType.SelectedItem ?? "";

            if (string.Equals(type, "Customer", StringComparison.OrdinalIgnoreCase))
            {
                // Klarer Layout-Container, kein Überlappen -> Text sichtbar
                var t = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 3, Padding = new Padding(6) };
                t.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                t.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
                t.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                t.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                t.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

                t.Controls.Add(new Label { Text = "Owner (Author)", AutoSize = true }, 0, 0);
                txtOwner = new TextBox { Width = 300, Anchor = AnchorStyles.Left | AnchorStyles.Right };
                t.Controls.Add(txtOwner, 1, 0);

                t.Controls.Add(new Label { Text = "Protocol Note", AutoSize = true }, 0, 1);
                txtNote = new TextBox
                {
                    Multiline = true,
                    AcceptsReturn = true,
                    ScrollBars = ScrollBars.Vertical,
                    Dock = DockStyle.Fill,
                    PlaceholderText = "Write the first protocol note…"
                };
                t.Controls.Add(txtNote, 1, 2);

                paneBottom.Controls.Add(t);
            }
            else
            {
                // PersonalData inkl. Adresse
                var t = TwoCol();
                txtAhv = AddText(t, "AHV");
                txtNationality = AddText(t, "Nationality");
                txtGender = AddText(t, "Gender");
                dpBirth = AddDate(t, "Birth Date", DateTime.Today);

                txtPrivEmail = AddText(t, "Private Email");
                txtPrivPhone = AddText(t, "Private Phone");

                t.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                t.Controls.Add(new Label { Text = "Personal Address", Font = new Font(Font, FontStyle.Bold), AutoSize = true, Padding = new Padding(0, 12, 0, 0) }, 0, t.RowCount);
                t.Controls.Add(new Label { Text = "", AutoSize = true }, 1, t.RowCount);
                t.RowCount++;

                txtPStreet = AddText(t, "Street");
                txtPHouseNo = AddText(t, "House No");
                txtPZip = AddText(t, "ZIP");
                txtPCity = AddText(t, "City");
                txtPState = AddText(t, "State");
                txtPCountry = AddText(t, "Country");

                paneBottom.Controls.Add(t);
            }
        }

        public ContactDetailsDto AsContactDetailsDto()
        {
            var dto = new ContactDetailsDto
            {
                Type = (string)cbType.SelectedItem,
                Status = string.IsNullOrWhiteSpace(txtStatus.Text) ? "aktive" : txtStatus.Text.Trim(),
                EmployeeNumber = string.IsNullOrWhiteSpace(txtEmpNo.Text) ? null : txtEmpNo.Text.Trim(),
                FirstName = txtFirst.Text,
                LastName = txtLast.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhone.Text,
                Role = txtRole.Text,
                Department = txtDept.Text,
                EntryDate = dpEntry.Value.Date,
                LeaveDate = dpLeave.ShowCheckBox && dpLeave.Checked ? dpLeave.Value.Date : (DateTime?)null,
                Company = string.IsNullOrWhiteSpace(txtCompany.Text) ? null : new CompanyDto
                {
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
                }
            };

            if (!string.Equals(dto.Type, "Customer", StringComparison.OrdinalIgnoreCase))
            {
                dto.PersonalData = new PersonalDataDto
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
            else if (!string.IsNullOrWhiteSpace(txtNote?.Text))
            {
                dto.Protocol = new System.Collections.Generic.List<ProtocolDto> {
                    new ProtocolDto { Author = string.IsNullOrWhiteSpace(txtOwner?.Text) ? "System" : txtOwner.Text.Trim(),
                                      Date = DateTime.UtcNow,
                                      Message = txtNote.Text }
                };
            }

            return dto;
        }
    }
}
