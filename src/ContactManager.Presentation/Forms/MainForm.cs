
using System;
using System.Windows.Forms;

namespace ContactManager.Presentation.Forms {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void btnMitarbeiter_Click(object sender, EventArgs e) {
            var form = new MitarbeiterForm();
            form.ShowDialog();
        }

        private void btnKunden_Click(object sender, EventArgs e) {
            var form = new KundenForm();
            form.ShowDialog();
        }

        private void btnSuche_Click(object sender, EventArgs e) {
            var form = new SucheForm();
            form.ShowDialog();
        }
    }
}
