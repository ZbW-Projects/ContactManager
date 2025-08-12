using ContactManager.Presentation.Demo.Models;
using ContactManager.Presentation.Demo.Services;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ContactManager.Presentation.Demo.Forms
{
    public class DetailsForm : Form
    {
        private readonly IContacts _svc;
        private Contact _model;

        // controls
        TextBox txtFirst, txtLast, txtEmail, txtPhone, txtCompany, txtAddress, txtCity, txtZip;
        DateTimePicker dtBirth;
        ComboBox cmbRole;
        CheckBox chkActive;
        Button btnEditSave, btnClose;

        private bool _editMode = false;

        public DetailsForm(IContacts svc, string id)
        {
            _svc = svc;
            _model = _svc.GetById(id).Clone(); // work on a copy
            Text = "Details";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(420, 420);
            FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false;

            BuildUi();
            BindFromModel();
            SetEditMode(false);
        }

        private void BuildUi()
        {
            var grid = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 2, RowCount = 11, Padding = new Padding(12) };
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            grid.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));

            txtFirst = new TextBox(); txtLast = new TextBox(); txtEmail = new TextBox();
            txtPhone = new TextBox(); txtCompany = new TextBox(); txtAddress = new TextBox();
            txtCity = new TextBox(); txtZip = new TextBox();
            dtBirth = new DateTimePicker { Format = DateTimePickerFormat.Short, ShowCheckBox = true };
            cmbRole = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList, DataSource = Enum.GetValues(typeof(ContactRole)) };
            chkActive = new CheckBox { Text = "Aktiv" };

            void row(string label, Control c, int r)
            {
                grid.Controls.Add(new Label { Text = label, AutoSize = true }, 0, r);
                grid.Controls.Add(c, 1, r);
            }

            row("Vorname", txtFirst, 0);
            row("Nachname", txtLast, 1);
            row("Rolle", cmbRole, 2);
            row("E-Mail", txtEmail, 3);
            row("Telefon", txtPhone, 4);
            row("Firma", txtCompany, 5);
            row("Adresse", txtAddress, 6);
            row("PLZ", txtZip, 7);
            row("Ort", txtCity, 8);
            row("Geburtsdatum", dtBirth, 9);
            row("", chkActive, 10);

            var footer = new FlowLayoutPanel { Dock = DockStyle.Bottom, Height = 52, FlowDirection = FlowDirection.RightToLeft, Padding = new Padding(12) };
            btnEditSave = new Button { Text = "Bearbeiten", AutoSize = true };
            btnClose = new Button { Text = "Schliessen", AutoSize = true };
            btnClose.Click += (_, __) => Close();
            btnEditSave.Click += BtnEditSave_Click;
            footer.Controls.AddRange(new Control[] { btnEditSave, btnClose });

            Controls.Add(grid);
            Controls.Add(footer);
        }

        private void BindFromModel()
        {
            txtFirst.Text = _model.FirstName;
            txtLast.Text = _model.LastName;
            cmbRole.SelectedItem = _model.Role;
            txtEmail.Text = _model.Email;
            txtPhone.Text = _model.Phone;
            txtCompany.Text = _model.Company;
            txtAddress.Text = _model.Address;
            txtZip.Text = _model.Zip;
            txtCity.Text = _model.City;
            chkActive.Checked = _model.Active;
            if (_model.Birthdate.HasValue)
            {
                dtBirth.Checked = true;
                dtBirth.Value = _model.Birthdate.Value;
            }
            else dtBirth.Checked = false;
        }

        private void BindToModel()
        {
            _model.FirstName = txtFirst.Text.Trim();
            _model.LastName = txtLast.Text.Trim();
            _model.Role = (ContactRole)cmbRole.SelectedItem;
            _model.Email = txtEmail.Text.Trim();
            _model.Phone = txtPhone.Text.Trim();
            _model.Company = txtCompany.Text.Trim();
            _model.Address = txtAddress.Text.Trim();
            _model.Zip = txtZip.Text.Trim();
            _model.City = txtCity.Text.Trim();
            _model.Active = chkActive.Checked;
            _model.Birthdate = dtBirth.Checked ? dtBirth.Value.Date : (DateTime?)null;
        }

        private void SetEditMode(bool on)
        {
            _editMode = on;
            foreach (Control c in Controls)
                SetEnabledRecursive(c, on);

            // keep footer buttons enabled
            btnEditSave.Enabled = true; btnClose.Enabled = true;
            btnEditSave.Text = on ? "Speichern" : "Bearbeiten";
        }

        private static void SetEnabledRecursive(Control c, bool enabled)
        {
            if (c is TextBox || c is ComboBox || c is DateTimePicker || c is CheckBox)
                c.Enabled = enabled;
            if (c.HasChildren)
                foreach (Control child in c.Controls) SetEnabledRecursive(child, enabled);
        }

        private void BtnEditSave_Click(object sender, EventArgs e)
        {
            if (!_editMode) { SetEditMode(true); return; }

            // save
            BindToModel();
            _svc.Update(_model);
            SetEditMode(false);
            MessageBox.Show("Gespeichert.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
