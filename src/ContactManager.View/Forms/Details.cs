using System;
using System.Windows.Forms;

namespace ContactManager.View.Forms
{
    public partial class Details : Form
    {
        public Details()
        {
            InitializeComponent();
        }


        // =====================================================================
        // TAB: Lehrling
        // =====================================================================

        // =====================================================================
        // Gruppen 
        // =====================================================================
        private void GrpPersoenlichL_Enter(object sender, EventArgs e) { }
        private void GrpKontaktinformationenL_Enter(object sender, EventArgs e) { }
        private void GrpBeschaeftigungsdatenL_Enter(object sender, EventArgs e) { }


        // ---------------------------------------------------------------------
        // Gruppe: Persönliche Angaben
        // ---------------------------------------------------------------------
        private void CmbAnredeL_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TxtVornameL_TextChanged(object sender, EventArgs e) { }
        private void TxtNachnameL_TextChanged(object sender, EventArgs e) { }
        private void DtpGeburtsdatumL_ValueChanged(object sender, EventArgs e) { }
        private void CmbGeschlechtL_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TxtTitelL_TextChanged(object sender, EventArgs e) { }
        private void TxtAhvnummerL_TextChanged(object sender, EventArgs e) { }
        private void CmbNationalitätL_SelectedIndexChanged(object sender, EventArgs e) { }
        private void TxtAdresseL_TextChanged(object sender, EventArgs e) { }
        private void TxtWohnortL_TextChanged(object sender, EventArgs e) { }
        private void TxtPostleitzahlL_TextChanged(object sender, EventArgs e) { }

        // (Label-Clicks – falls im Designer verdrahtet, bleiben sie hier)
        private void LblVornameL_Click(object sender, EventArgs e) { }
        private void LblNachnameL_Click(object sender, EventArgs e) { }
        private void LblAhvnummerL_Click(object sender, EventArgs e) { }

        // ---------------------------------------------------------------------
        // Gruppe: Kontaktinformationen
        // ---------------------------------------------------------------------
        private void TxtTelefonprivatL_TextChanged(object sender, EventArgs e) { }
        private void TxtGeschaeftL_TextChanged(object sender, EventArgs e) { }
        private void TxtMobiltelefonnummerL_TextChanged(object sender, EventArgs e) { }
        private void TxtEmailL_TextChanged(object sender, EventArgs e) { }

        private void LblTelefonprivatL_Click(object sender, EventArgs e) { }
        private void LblMobiltelefonnummerL_Click(object sender, EventArgs e) { }
        private void LblEmailadresseL_Click(object sender, EventArgs e) { }

        // ---------------------------------------------------------------------
        // Gruppe: Beschäftigungsdaten (Lehrling)
        // ---------------------------------------------------------------------
        private void CmbLehrjahreL_SelectedIndexChanged(object sender, EventArgs e) { }
        private void CmdAktuellesLehrjahrL_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LblLehrjahreL_Click(object sender, EventArgs e) { }

        // ---------------------------------------------------------------------
        // Gruppe: Status & Aktionen
        // ---------------------------------------------------------------------
        private void CmbStatusL_SelectedIndexChanged(object sender, EventArgs e) { }
        private void LblStatusL_Click(object sender, EventArgs e) { }
        private void btnSpeichernL_Click(object sender, EventArgs e) { }

        // =====================================================================
        // Allgemeine/sonstige Handler (ohne Tab-Bezug, vom Designer erzeugt)
        // =====================================================================
        private void LblAnrede(object sender, EventArgs e) { }
        private void LblTitel(object sender, EventArgs e) { }
        private void LblTitelPersoendlicheAngaben(object sender, EventArgs e) { }
        private void LblVorname(object sender, EventArgs e) { }
        private void LblNachname(object sender, EventArgs e) { }
        private void LblGeburtsdatum(object sender, EventArgs e) { }
        private void LblGeshlecht(object sender, EventArgs e) { }
        private void LblNatonalität(object sender, EventArgs e) { }
        private void LblAdresse(object sender, EventArgs e) { }
        private void LblWohnort(object sender, EventArgs e) { }
        private void LblPostpleitzah(object sender, EventArgs e) { }
        private void label17_Click(object sender, EventArgs e) { }
        private void label27_Click(object sender, EventArgs e) { }
        private void label33_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }

        // ---------------------------------------------------------------------
        // Sonstige TextBox-/Combo-/RichText-Handler (nicht tab-spezifisch)
        // ---------------------------------------------------------------------
        private void TxtGeburtsdatum_TextChanged(object sender, EventArgs e) { }
        private void cmbTitel(object sender, EventArgs e) { }
        private void cmbLehrjahre_SelectedIndexChanged(object sender, EventArgs e) { }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e) { }
        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e) { }
        private void richTextBox1_TextChanged(object sender, EventArgs e) { }

        private void tabLehrling_Click(object sender, EventArgs e)
        {

        }
    }
}
