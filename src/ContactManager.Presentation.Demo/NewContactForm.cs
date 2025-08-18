using System;
using System.Drawing;
using System.Windows.Forms;
using ContactManager.Application.Abstractions.Dtos;

namespace ContactManager.Presentation.Demo
{
    public class NewContactForm : Form
    {
        // person (top-left)
        ComboBox cbType; TextBox txtFirst, txtLast, txtEmail, txtPhone, txtStatus, txtRole, txtDept, txtEmpNo;
        DateTimePicker dpEntry, dpLeave;

        // company (top-right)
        TextBox txtCompany, txtCompanyEmail, txtCompanyPhone, txtStreet, txtHouseNo, txtZip, txtCity, txtState, txtCountry;

        // bottom – personal or protocol
        Panel paneBottom;
        // personal
        TextBox txtAhv, txtNationality, txtGender, txtPrivEmail, txtPrivPhone;
        DateTimePicker dpBirth;
        // protocol
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
            cbType.SelectedIndex = 0;  // Employee default
            SwitchBottom();
        }

        private void BuildUi()
        {
            var root = new TableLayoutPanel { Dock = DockStyle.Fill, RowCount = 3, Padding = new Padding(6) };
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            root.RowStyles.Add(new RowStyle(SizeType.Percent, 45));
            root.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            Controls.Add(root);

            var top = new SplitContainer { Dock = DockStyle.Fill, SplitterDistance = 500 };
            root.Controls.Add(top, 0, 0);

            // --- Person (left)
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
            dpLeave = AddDate(left, "Leave Date", DateTime.Today);
            top.Panel1.Controls.Add(left);

            // --- Company (right)
            var right = TwoCol();
            txtCompany = AddText(right, "Company");
            txtCompanyEmail = AddText(right, "Company Email");
            txtCompanyPhone = AddText(right, "Company Phone");
            txtStreet = AddText(right, "Street");
            txtHouseNo = AddText(right, "House No");
            txtZip = AddText(right, "ZIP");
            txtCity = AddText(right, "City");
            txtState = AddText(right, "State");
            txtCountry = AddText(right, "Country");
            top.Panel2.Controls.Add(right);

            // --- Bottom panel where we swap content
            paneBottom = new Panel { Dock = DockStyle.Fill };
            root.Controls.Add(paneBottom, 0, 1);

            // Footer
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
            var cb = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, Width = 220 };
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
            var tb = new TextBox { Width = 260, Text = defaultText };
            tl.Controls.Add(lbl, 0, tl.RowCount);
            tl.Controls.Add(tb, 1, tl.RowCount);
            tl.RowCount++;
            return tb;
        }
        private DateTimePicker AddDate(TableLayoutPanel tl, string label, DateTime v)
        {
            tl.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            var lbl = new Label { Text = label, AutoSize = true, Padding = new Padding(0, 6, 0, 0) };
            var dp = new DateTimePicker { Format = DateTimePickerFormat.Short, Value = v };
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
                var grid = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2 };
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
                grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));

                txtOwner = new TextBox { PlaceholderText = "Owner (Author)", Dock = DockStyle.Top };
                txtNote = new TextBox { Multiline = true, Dock = DockStyle.Fill, PlaceholderText = "First protocol note (optional)" };

                var left = new Panel { Dock = DockStyle.Fill };
                left.Controls.Add(new Label { Text = "Initial Protocol (optional):", Dock = DockStyle.Top, AutoSize = true });
                left.Controls.Add(txtOwner);
                left.Controls.Add(txtNote);

                var right = new Panel { Dock = DockStyle.Fill }; // reserved

                grid.Controls.Add(left, 0, 0);
                grid.Controls.Add(right, 1, 0);
                paneBottom.Controls.Add(grid);
            }
            else
            {
                var t = TwoCol();
                txtAhv = AddText(t, "AHV");
                txtNationality = AddText(t, "Nationality");
                txtGender = AddText(t, "Gender");
                dpBirth = AddDate(t, "Birth Date", DateTime.Today);
                txtPrivEmail = AddText(t, "Private Email");
                txtPrivPhone = AddText(t, "Private Phone");
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
                LeaveDate = dpLeave.Value.Date,
                Company = string.IsNullOrWhiteSpace(txtCompany.Text) ? null : new CompanyDto
                {
                    Name = txtCompany.Text,
                    Email = txtCompanyEmail.Text,
                    PhoneNumber = txtCompanyPhone.Text,
                    Address = new AddressDto
                    {
                        Street = txtStreet.Text,
                        HouseNumber = txtHouseNo.Text,
                        ZipCode = txtZip.Text,
                        City = txtCity.Text,
                        State = txtState.Text,
                        Country = txtCountry.Text
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
                    Phone = txtPrivPhone?.Text
                };
            }
            else if (!string.IsNullOrWhiteSpace(txtNote?.Text))
            {
                dto.Protocol = new System.Collections.Generic.List<ProtocolDto> {
                    new ProtocolDto { Author = string.IsNullOrWhiteSpace(txtOwner?.Text) ? "System" : txtOwner.Text.Trim(), Date = DateTime.UtcNow, Message = txtNote.Text }
                };
            }

            return dto;
        }
    }
}
