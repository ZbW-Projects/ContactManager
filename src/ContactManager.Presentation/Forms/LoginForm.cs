
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace ContactManager.Presentation.Forms
{
    public partial class LoginForm : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string AusgewaehlterBenutzer { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbBenutzer.SelectedItem == null)
            {
                MessageBox.Show("Bitte Benutzer auswählen.");
                return;
            }

            AusgewaehlterBenutzer = cmbBenutzer.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
