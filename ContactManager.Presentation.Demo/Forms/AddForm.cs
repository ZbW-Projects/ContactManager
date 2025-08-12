using ContactManager.Presentation.Demo.Models;
using System;
using System.Drawing;
using System.Windows.Forms;


namespace ContactManager.Presentation.Demo.Forms
{
    public class AddForm : Form
    {
        TextBox txtFirst, txtLast, txtEmail, txtPhone, txtCompany, txtAddress, txtCity, txtZip;
        DateTimePicker dtBirth;
        ComboBox cmbRole;
        CheckBox chkActive;
        Button btnSave, btnCancel;

        public Contact Result { get; private set; }

        public AddForm()
        {
            Text = "Kontakt hinzufügen";
            StartPosition = FormStartPosition.CenterParent;
            ClientSize = new Size(420, 420);
            FormBorderStyle = FormBorderStyle.FixedDialog; MaximizeBox = false; MinimizeBox = false;

            BuildUi();
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
            chkActive = new CheckBox { Text = "Aktiv", Checked = true };

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
            btnSave = new Button { Text = "Speichern", AutoSize = true };
            btnCancel = new Button { Text = "Abbrechen", AutoSize = true };
            btnCancel.Click += (_, __) => DialogResult = DialogResult.Cancel;
            btnSave.Click += (_, __) =>
            {
                if (ValidateInput())
                {
                    Result = new Contact
                    {
                        FirstName = txtFirst.Text.Trim(),
                        LastName = txtLast.Text.Trim(),
                        Role = (ContactRole)cmbRole.SelectedItem,
                        Email = txtEmail.Text.Trim(),
                        Phone = txtPhone.Text.Trim(),
                        Company = txtCompany.Text.Trim(),
                        Address = txtAddress.Text.Trim(),
                        Zip = txtZip.Text.Trim(),
                        City = txtCity.Text.Trim(),
                        Active = chkActive.Checked,
                        Birthdate = dtBirth.Checked ? dtBirth.Value.Date : (DateTime?)null
                    };
                    DialogResult = DialogResult.OK;
                }
            };

            footer.Controls.AddRange(new Control[] { btnSave, btnCancel });
            Controls.Add(grid);
            Controls.Add(footer);
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtFirst.Text)) { MessageBox.Show("Vorname ist erforderlich."); return false; }
            if (string.IsNullOrWhiteSpace(txtLast.Text)) { MessageBox.Show("Nachname ist erforderlich."); return false; }
            return true;
        }
    }
}
