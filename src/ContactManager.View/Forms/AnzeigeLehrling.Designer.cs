namespace ContactManager.View.Forms
{
    partial class AnzeigeLehrling
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Löschen = new Button();
            button1 = new Button();
            GrpBeschaeftigungsdatenL = new GroupBox();
            CbStatusL = new CheckBox();
            LblBeschaeftigungsgradL = new Label();
            LblStatusL = new Label();
            CmbBeschaeftigungsgradL = new ComboBox();
            lblRolle = new Label();
            DtpEintrittL = new DateTimePicker();
            cmbRolle = new ComboBox();
            DtpAustrittL = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            CmbAbteilungL = new ComboBox();
            LblAbteilungL = new Label();
            LblLehrjahreL = new Label();
            CmbLehrjahreL = new ComboBox();
            BtnSpeichernL = new Button();
            GrpKontaktinformationenL = new GroupBox();
            label5 = new Label();
            LblTelefonprivatL = new Label();
            LblPostleitzahlL = new Label();
            TxtEmailL = new TextBox();
            LblMobiltelefonnummerL = new Label();
            TxtGeschaeftL = new TextBox();
            TxtPostleitzahlL = new TextBox();
            TxtMobiltelefonnummerL = new TextBox();
            TxtHausnummerL = new TextBox();
            lblTelefongeschaeftL = new Label();
            LblHausnummerL = new Label();
            TxtWohnortL = new TextBox();
            TxtTelefonprivatL = new TextBox();
            LblWohnortL = new Label();
            TxtStrasseL = new TextBox();
            LblStrasseL = new Label();
            GrpPersoenlichL = new GroupBox();
            LblAnredeL = new Label();
            DtpGeburtsdatumL = new DateTimePicker();
            CmbAnredeL = new ComboBox();
            CmbNationalitätL = new ComboBox();
            CmbGeschlechtL = new ComboBox();
            TxtAhvnummerL = new TextBox();
            LblVornameL = new Label();
            LblAhvnummerL = new Label();
            LblGeschlechtL = new Label();
            TxtVornameL = new TextBox();
            LblNachnameL = new Label();
            TxtNachnameL = new TextBox();
            LblGeburtsdatumL = new Label();
            TxtNationalitätL = new Label();
            GrpBeschaeftigungsdatenL.SuspendLayout();
            GrpKontaktinformationenL.SuspendLayout();
            GrpPersoenlichL.SuspendLayout();
            SuspendLayout();
            // 
            // Löschen
            // 
            Löschen.Location = new Point(554, 558);
            Löschen.Name = "Löschen";
            Löschen.Size = new Size(77, 30);
            Löschen.TabIndex = 113;
            Löschen.Text = "Löschen";
            Löschen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(639, 558);
            button1.Name = "button1";
            button1.Size = new Size(77, 30);
            button1.TabIndex = 112;
            button1.Text = "Bearbeiten";
            button1.UseVisualStyleBackColor = true;
            // 
            // GrpBeschaeftigungsdatenL
            // 
            GrpBeschaeftigungsdatenL.Controls.Add(CbStatusL);
            GrpBeschaeftigungsdatenL.Controls.Add(LblBeschaeftigungsgradL);
            GrpBeschaeftigungsdatenL.Controls.Add(LblStatusL);
            GrpBeschaeftigungsdatenL.Controls.Add(CmbBeschaeftigungsgradL);
            GrpBeschaeftigungsdatenL.Controls.Add(lblRolle);
            GrpBeschaeftigungsdatenL.Controls.Add(DtpEintrittL);
            GrpBeschaeftigungsdatenL.Controls.Add(cmbRolle);
            GrpBeschaeftigungsdatenL.Controls.Add(DtpAustrittL);
            GrpBeschaeftigungsdatenL.Controls.Add(label6);
            GrpBeschaeftigungsdatenL.Controls.Add(label7);
            GrpBeschaeftigungsdatenL.Controls.Add(CmbAbteilungL);
            GrpBeschaeftigungsdatenL.Controls.Add(LblAbteilungL);
            GrpBeschaeftigungsdatenL.Controls.Add(LblLehrjahreL);
            GrpBeschaeftigungsdatenL.Controls.Add(CmbLehrjahreL);
            GrpBeschaeftigungsdatenL.Location = new Point(100, 386);
            GrpBeschaeftigungsdatenL.Name = "GrpBeschaeftigungsdatenL";
            GrpBeschaeftigungsdatenL.Size = new Size(708, 166);
            GrpBeschaeftigungsdatenL.TabIndex = 117;
            GrpBeschaeftigungsdatenL.TabStop = false;
            GrpBeschaeftigungsdatenL.Text = "Beschäftigungsdaten";
            // 
            // CbStatusL
            // 
            CbStatusL.AutoSize = true;
            CbStatusL.Location = new Point(452, 124);
            CbStatusL.Name = "CbStatusL";
            CbStatusL.Size = new Size(53, 19);
            CbStatusL.TabIndex = 92;
            CbStatusL.Text = "Aktiv";
            CbStatusL.UseVisualStyleBackColor = true;
            // 
            // LblBeschaeftigungsgradL
            // 
            LblBeschaeftigungsgradL.AutoSize = true;
            LblBeschaeftigungsgradL.Location = new Point(15, 131);
            LblBeschaeftigungsgradL.Name = "LblBeschaeftigungsgradL";
            LblBeschaeftigungsgradL.Size = new Size(112, 15);
            LblBeschaeftigungsgradL.TabIndex = 93;
            LblBeschaeftigungsgradL.Text = "Beschäftigungsgrad";
            // 
            // LblStatusL
            // 
            LblStatusL.AutoSize = true;
            LblStatusL.Location = new Point(382, 124);
            LblStatusL.Name = "LblStatusL";
            LblStatusL.Size = new Size(45, 15);
            LblStatusL.TabIndex = 38;
            LblStatusL.Text = "Status :";
            // 
            // CmbBeschaeftigungsgradL
            // 
            CmbBeschaeftigungsgradL.FormattingEnabled = true;
            CmbBeschaeftigungsgradL.Items.AddRange(new object[] { "100", "80", "60", "40", "20" });
            CmbBeschaeftigungsgradL.Location = new Point(141, 126);
            CmbBeschaeftigungsgradL.Name = "CmbBeschaeftigungsgradL";
            CmbBeschaeftigungsgradL.Size = new Size(121, 23);
            CmbBeschaeftigungsgradL.TabIndex = 94;
            // 
            // lblRolle
            // 
            lblRolle.AutoSize = true;
            lblRolle.Location = new Point(14, 95);
            lblRolle.Name = "lblRolle";
            lblRolle.Size = new Size(33, 15);
            lblRolle.TabIndex = 100;
            lblRolle.Text = "Rolle";
            // 
            // DtpEintrittL
            // 
            DtpEintrittL.Location = new Point(454, 22);
            DtpEintrittL.Name = "DtpEintrittL";
            DtpEintrittL.Size = new Size(249, 23);
            DtpEintrittL.TabIndex = 99;
            // 
            // cmbRolle
            // 
            cmbRolle.FormattingEnabled = true;
            cmbRolle.Items.AddRange(new object[] { "System Engineer", "Entwickler", "Projektleiter", "Kaufmännische/r Angestellte/r", "Support" });
            cmbRolle.Location = new Point(141, 91);
            cmbRolle.Name = "cmbRolle";
            cmbRolle.Size = new Size(121, 23);
            cmbRolle.TabIndex = 101;
            // 
            // DtpAustrittL
            // 
            DtpAustrittL.Location = new Point(454, 55);
            DtpAustrittL.Name = "DtpAustrittL";
            DtpAustrittL.Size = new Size(249, 23);
            DtpAustrittL.TabIndex = 98;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(382, 59);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 97;
            label6.Text = "Austritt";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(382, 25);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 96;
            label7.Text = "Eintritt";
            // 
            // CmbAbteilungL
            // 
            CmbAbteilungL.FormattingEnabled = true;
            CmbAbteilungL.Items.AddRange(new object[] { "IT", "Finanzen", "HR", "Verkauf", "Produktion", "Verwaltung" });
            CmbAbteilungL.Location = new Point(141, 56);
            CmbAbteilungL.Name = "CmbAbteilungL";
            CmbAbteilungL.Size = new Size(121, 23);
            CmbAbteilungL.TabIndex = 94;
            // 
            // LblAbteilungL
            // 
            LblAbteilungL.AutoSize = true;
            LblAbteilungL.Location = new Point(14, 61);
            LblAbteilungL.Name = "LblAbteilungL";
            LblAbteilungL.Size = new Size(59, 15);
            LblAbteilungL.TabIndex = 95;
            LblAbteilungL.Text = "Abteilung";
            // 
            // LblLehrjahreL
            // 
            LblLehrjahreL.AutoSize = true;
            LblLehrjahreL.Location = new Point(15, 25);
            LblLehrjahreL.Name = "LblLehrjahreL";
            LblLehrjahreL.Size = new Size(56, 15);
            LblLehrjahreL.TabIndex = 92;
            LblLehrjahreL.Text = "Lehrjahre";
            // 
            // CmbLehrjahreL
            // 
            CmbLehrjahreL.FormattingEnabled = true;
            CmbLehrjahreL.Items.AddRange(new object[] { "1", "2", "3", "4" });
            CmbLehrjahreL.Location = new Point(141, 20);
            CmbLehrjahreL.Name = "CmbLehrjahreL";
            CmbLehrjahreL.Size = new Size(121, 23);
            CmbLehrjahreL.TabIndex = 47;
            // 
            // BtnSpeichernL
            // 
            BtnSpeichernL.Location = new Point(731, 557);
            BtnSpeichernL.Name = "BtnSpeichernL";
            BtnSpeichernL.Size = new Size(77, 30);
            BtnSpeichernL.TabIndex = 114;
            BtnSpeichernL.Text = "Speichern";
            BtnSpeichernL.UseVisualStyleBackColor = true;
            // 
            // GrpKontaktinformationenL
            // 
            GrpKontaktinformationenL.Controls.Add(label5);
            GrpKontaktinformationenL.Controls.Add(LblTelefonprivatL);
            GrpKontaktinformationenL.Controls.Add(LblPostleitzahlL);
            GrpKontaktinformationenL.Controls.Add(TxtEmailL);
            GrpKontaktinformationenL.Controls.Add(LblMobiltelefonnummerL);
            GrpKontaktinformationenL.Controls.Add(TxtGeschaeftL);
            GrpKontaktinformationenL.Controls.Add(TxtPostleitzahlL);
            GrpKontaktinformationenL.Controls.Add(TxtMobiltelefonnummerL);
            GrpKontaktinformationenL.Controls.Add(TxtHausnummerL);
            GrpKontaktinformationenL.Controls.Add(lblTelefongeschaeftL);
            GrpKontaktinformationenL.Controls.Add(LblHausnummerL);
            GrpKontaktinformationenL.Controls.Add(TxtWohnortL);
            GrpKontaktinformationenL.Controls.Add(TxtTelefonprivatL);
            GrpKontaktinformationenL.Controls.Add(LblWohnortL);
            GrpKontaktinformationenL.Controls.Add(TxtStrasseL);
            GrpKontaktinformationenL.Controls.Add(LblStrasseL);
            GrpKontaktinformationenL.Location = new Point(498, 52);
            GrpKontaktinformationenL.Name = "GrpKontaktinformationenL";
            GrpKontaktinformationenL.Size = new Size(310, 320);
            GrpKontaktinformationenL.TabIndex = 116;
            GrpKontaktinformationenL.TabStop = false;
            GrpKontaktinformationenL.Text = "Adresse + Kontakt";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 87);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 29;
            label5.Text = "PLZ";
            // 
            // LblTelefonprivatL
            // 
            LblTelefonprivatL.AutoSize = true;
            LblTelefonprivatL.Location = new Point(6, 266);
            LblTelefonprivatL.Name = "LblTelefonprivatL";
            LblTelefonprivatL.Size = new Size(80, 15);
            LblTelefonprivatL.TabIndex = 13;
            LblTelefonprivatL.Text = "Telefon Mobil";
            // 
            // LblPostleitzahlL
            // 
            LblPostleitzahlL.AutoSize = true;
            LblPostleitzahlL.Location = new Point(8, 241);
            LblPostleitzahlL.Name = "LblPostleitzahlL";
            LblPostleitzahlL.Size = new Size(79, 15);
            LblPostleitzahlL.TabIndex = 9;
            LblPostleitzahlL.Text = "Telefon Privat";
            // 
            // TxtEmailL
            // 
            TxtEmailL.Location = new Point(141, 201);
            TxtEmailL.Name = "TxtEmailL";
            TxtEmailL.Size = new Size(121, 23);
            TxtEmailL.TabIndex = 28;
            // 
            // LblMobiltelefonnummerL
            // 
            LblMobiltelefonnummerL.AutoSize = true;
            LblMobiltelefonnummerL.Location = new Point(8, 205);
            LblMobiltelefonnummerL.Name = "LblMobiltelefonnummerL";
            LblMobiltelefonnummerL.Size = new Size(36, 15);
            LblMobiltelefonnummerL.TabIndex = 14;
            LblMobiltelefonnummerL.Text = "Email";
            // 
            // TxtGeschaeftL
            // 
            TxtGeschaeftL.Location = new Point(141, 290);
            TxtGeschaeftL.Name = "TxtGeschaeftL";
            TxtGeschaeftL.Size = new Size(165, 23);
            TxtGeschaeftL.TabIndex = 26;
            // 
            // TxtPostleitzahlL
            // 
            TxtPostleitzahlL.Location = new Point(141, 83);
            TxtPostleitzahlL.Name = "TxtPostleitzahlL";
            TxtPostleitzahlL.Size = new Size(121, 23);
            TxtPostleitzahlL.TabIndex = 22;
            // 
            // TxtMobiltelefonnummerL
            // 
            TxtMobiltelefonnummerL.Location = new Point(141, 262);
            TxtMobiltelefonnummerL.Name = "TxtMobiltelefonnummerL";
            TxtMobiltelefonnummerL.Size = new Size(165, 23);
            TxtMobiltelefonnummerL.TabIndex = 25;
            // 
            // TxtHausnummerL
            // 
            TxtHausnummerL.Location = new Point(141, 53);
            TxtHausnummerL.Name = "TxtHausnummerL";
            TxtHausnummerL.Size = new Size(165, 23);
            TxtHausnummerL.TabIndex = 84;
            // 
            // lblTelefongeschaeftL
            // 
            lblTelefongeschaeftL.AutoSize = true;
            lblTelefongeschaeftL.Location = new Point(6, 293);
            lblTelefongeschaeftL.Name = "lblTelefongeschaeftL";
            lblTelefongeschaeftL.Size = new Size(95, 15);
            lblTelefongeschaeftL.TabIndex = 12;
            lblTelefongeschaeftL.Text = "Telefon Geschäft";
            // 
            // LblHausnummerL
            // 
            LblHausnummerL.AutoSize = true;
            LblHausnummerL.Location = new Point(6, 57);
            LblHausnummerL.Name = "LblHausnummerL";
            LblHausnummerL.Size = new Size(80, 15);
            LblHausnummerL.TabIndex = 83;
            LblHausnummerL.Text = "Hausnummer";
            // 
            // TxtWohnortL
            // 
            TxtWohnortL.Location = new Point(141, 115);
            TxtWohnortL.Name = "TxtWohnortL";
            TxtWohnortL.Size = new Size(165, 23);
            TxtWohnortL.TabIndex = 19;
            // 
            // TxtTelefonprivatL
            // 
            TxtTelefonprivatL.Location = new Point(141, 238);
            TxtTelefonprivatL.Name = "TxtTelefonprivatL";
            TxtTelefonprivatL.Size = new Size(165, 23);
            TxtTelefonprivatL.TabIndex = 27;
            // 
            // LblWohnortL
            // 
            LblWohnortL.AutoSize = true;
            LblWohnortL.Location = new Point(6, 119);
            LblWohnortL.Name = "LblWohnortL";
            LblWohnortL.Size = new Size(54, 15);
            LblWohnortL.TabIndex = 10;
            LblWohnortL.Text = "Wohnort";
            // 
            // TxtStrasseL
            // 
            TxtStrasseL.Location = new Point(141, 27);
            TxtStrasseL.Name = "TxtStrasseL";
            TxtStrasseL.Size = new Size(165, 23);
            TxtStrasseL.TabIndex = 21;
            // 
            // LblStrasseL
            // 
            LblStrasseL.AutoSize = true;
            LblStrasseL.Location = new Point(6, 31);
            LblStrasseL.Name = "LblStrasseL";
            LblStrasseL.Size = new Size(43, 15);
            LblStrasseL.TabIndex = 8;
            LblStrasseL.Text = "Strasse";
            // 
            // GrpPersoenlichL
            // 
            GrpPersoenlichL.Controls.Add(LblAnredeL);
            GrpPersoenlichL.Controls.Add(DtpGeburtsdatumL);
            GrpPersoenlichL.Controls.Add(CmbAnredeL);
            GrpPersoenlichL.Controls.Add(CmbNationalitätL);
            GrpPersoenlichL.Controls.Add(CmbGeschlechtL);
            GrpPersoenlichL.Controls.Add(TxtAhvnummerL);
            GrpPersoenlichL.Controls.Add(LblVornameL);
            GrpPersoenlichL.Controls.Add(LblAhvnummerL);
            GrpPersoenlichL.Controls.Add(LblGeschlechtL);
            GrpPersoenlichL.Controls.Add(TxtVornameL);
            GrpPersoenlichL.Controls.Add(LblNachnameL);
            GrpPersoenlichL.Controls.Add(TxtNachnameL);
            GrpPersoenlichL.Controls.Add(LblGeburtsdatumL);
            GrpPersoenlichL.Controls.Add(TxtNationalitätL);
            GrpPersoenlichL.Location = new Point(100, 52);
            GrpPersoenlichL.Name = "GrpPersoenlichL";
            GrpPersoenlichL.Size = new Size(372, 320);
            GrpPersoenlichL.TabIndex = 115;
            GrpPersoenlichL.TabStop = false;
            GrpPersoenlichL.Text = "Persönliche Angaben";
            // 
            // LblAnredeL
            // 
            LblAnredeL.AutoSize = true;
            LblAnredeL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAnredeL.Location = new Point(6, 29);
            LblAnredeL.Name = "LblAnredeL";
            LblAnredeL.Size = new Size(50, 17);
            LblAnredeL.TabIndex = 1;
            LblAnredeL.Text = "Anrede";
            // 
            // DtpGeburtsdatumL
            // 
            DtpGeburtsdatumL.Location = new Point(141, 139);
            DtpGeburtsdatumL.Name = "DtpGeburtsdatumL";
            DtpGeburtsdatumL.Size = new Size(227, 23);
            DtpGeburtsdatumL.TabIndex = 25;
            // 
            // CmbAnredeL
            // 
            CmbAnredeL.FormattingEnabled = true;
            CmbAnredeL.Items.AddRange(new object[] { "Divers", "Frau ", "Herr", "(Keine Angabe)" });
            CmbAnredeL.Location = new Point(141, 26);
            CmbAnredeL.Name = "CmbAnredeL";
            CmbAnredeL.Size = new Size(165, 23);
            CmbAnredeL.TabIndex = 16;
            // 
            // CmbNationalitätL
            // 
            CmbNationalitätL.AutoCompleteCustomSource.AddRange(new string[] { "Schweiz", "", "", "Deutschland", "", "", "Liechtenstein", "", "", "Österreich", "", "", "Frankreich", "", "", "Italien", "", "", "Spanien", "", "", "Portugal", "", "", "Belgien", "", "", "Niederlande", "", "", "Luxemburg", "", "", "Dänemark", "", "", "Norwegen", "", "", "Schweden", "", "", "Finnland", "", "", "Island", "", "", "Polen", "", "", "Tschechien", "", "", "Slowakei", "", "", "Ungarn", "", "", "Slowenien", "", "", "Kroatien", "", "", "Griechenland", "", "", "Bulgarien", "", "", "Rumänien", "", "", "Estland", "", "", "Lettland", "", "", "Litauen", "", "", "Irland", "", "", "Vereinigtes Königreich", "", "", "USA", "", "", "Kanada", "", "", "Mexiko", "", "", "Brasilien", "", "", "Argentinien", "", "", "Australien", "", "", "Neuseeland", "", "", "China", "", "", "Japan", "", "", "Südkorea", "", "", "Indien", "", "", "Südafrika", "", "", "Ägypten", "", "", "Marokko", "", "", "Türkei" });
            CmbNationalitätL.FormattingEnabled = true;
            CmbNationalitätL.Items.AddRange(new object[] { "Schweiz", "Deutschland", "Liechtenstein", "Österreich", "Frankreich", "Italien", "Spanien", "Portugal", "Belgien", "Niederlande", "Luxemburg", "Dänemark", "Norwegen", "Schweden", "Finnland", "Island", "Polen", "Tschechien", "Slowakei", "Ungarn", "Slowenien", "Kroatien", "Griechenland", "Bulgarien", "Rumänien", "Estland", "Lettland", "Litauen", "Irland", "Vereinigtes Königreich", "USA", "Kanada", "Mexiko", "Brasilien", "Argentinien", "Australien", "Neuseeland", "China", "Japan", "Südkorea", "Indien", "Südafrika", "Ägypten", "Marokko", "Türkei" });
            CmbNationalitätL.Location = new Point(141, 257);
            CmbNationalitätL.Name = "CmbNationalitätL";
            CmbNationalitätL.Size = new Size(165, 23);
            CmbNationalitätL.TabIndex = 68;
            // 
            // CmbGeschlechtL
            // 
            CmbGeschlechtL.FormattingEnabled = true;
            CmbGeschlechtL.Items.AddRange(new object[] { "Männlich", "Weiblich", "Divers ", "(Keine Angabe)" });
            CmbGeschlechtL.Location = new Point(141, 180);
            CmbGeschlechtL.Name = "CmbGeschlechtL";
            CmbGeschlechtL.Size = new Size(165, 23);
            CmbGeschlechtL.TabIndex = 70;
            // 
            // TxtAhvnummerL
            // 
            TxtAhvnummerL.Location = new Point(141, 220);
            TxtAhvnummerL.Name = "TxtAhvnummerL";
            TxtAhvnummerL.Size = new Size(227, 23);
            TxtAhvnummerL.TabIndex = 63;
            // 
            // LblVornameL
            // 
            LblVornameL.AutoSize = true;
            LblVornameL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblVornameL.Location = new Point(6, 53);
            LblVornameL.Name = "LblVornameL";
            LblVornameL.Size = new Size(60, 17);
            LblVornameL.TabIndex = 80;
            LblVornameL.Text = "Vorname";
            // 
            // LblAhvnummerL
            // 
            LblAhvnummerL.AutoSize = true;
            LblAhvnummerL.Location = new Point(6, 223);
            LblAhvnummerL.Name = "LblAhvnummerL";
            LblAhvnummerL.Size = new Size(84, 15);
            LblAhvnummerL.TabIndex = 59;
            LblAhvnummerL.Text = "AHV-Nummer";
            // 
            // LblGeschlechtL
            // 
            LblGeschlechtL.AutoSize = true;
            LblGeschlechtL.Location = new Point(6, 185);
            LblGeschlechtL.Name = "LblGeschlechtL";
            LblGeschlechtL.Size = new Size(65, 15);
            LblGeschlechtL.TabIndex = 69;
            LblGeschlechtL.Text = "Geschlecht";
            // 
            // TxtVornameL
            // 
            TxtVornameL.Location = new Point(141, 52);
            TxtVornameL.Name = "TxtVornameL";
            TxtVornameL.Size = new Size(165, 23);
            TxtVornameL.TabIndex = 24;
            // 
            // LblNachnameL
            // 
            LblNachnameL.AutoSize = true;
            LblNachnameL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNachnameL.Location = new Point(6, 83);
            LblNachnameL.Name = "LblNachnameL";
            LblNachnameL.Size = new Size(70, 17);
            LblNachnameL.TabIndex = 81;
            LblNachnameL.Text = "Nachname";
            // 
            // TxtNachnameL
            // 
            TxtNachnameL.Location = new Point(141, 82);
            TxtNachnameL.Name = "TxtNachnameL";
            TxtNachnameL.Size = new Size(165, 23);
            TxtNachnameL.TabIndex = 17;
            // 
            // LblGeburtsdatumL
            // 
            LblGeburtsdatumL.AutoSize = true;
            LblGeburtsdatumL.Location = new Point(6, 142);
            LblGeburtsdatumL.Name = "LblGeburtsdatumL";
            LblGeburtsdatumL.Size = new Size(83, 15);
            LblGeburtsdatumL.TabIndex = 6;
            LblGeburtsdatumL.Text = "Geburtsdatum";
            // 
            // TxtNationalitätL
            // 
            TxtNationalitätL.AutoSize = true;
            TxtNationalitätL.Location = new Point(8, 262);
            TxtNationalitätL.Name = "TxtNationalitätL";
            TxtNationalitätL.Size = new Size(69, 15);
            TxtNationalitätL.TabIndex = 7;
            TxtNationalitätL.Text = "Nationalität";
            // 
            // AnzeigeLehrling
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 638);
            Controls.Add(GrpBeschaeftigungsdatenL);
            Controls.Add(BtnSpeichernL);
            Controls.Add(GrpKontaktinformationenL);
            Controls.Add(GrpPersoenlichL);
            Controls.Add(Löschen);
            Controls.Add(button1);
            Name = "AnzeigeLehrling";
            Text = "AnzeigeLehrling";
            GrpBeschaeftigungsdatenL.ResumeLayout(false);
            GrpBeschaeftigungsdatenL.PerformLayout();
            GrpKontaktinformationenL.ResumeLayout(false);
            GrpKontaktinformationenL.PerformLayout();
            GrpPersoenlichL.ResumeLayout(false);
            GrpPersoenlichL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Löschen;
        private Button button1;
        private GroupBox GrpBeschaeftigungsdatenL;
        private CheckBox CbStatusL;
        private Label LblBeschaeftigungsgradL;
        private Label LblStatusL;
        private ComboBox CmbBeschaeftigungsgradL;
        private Label lblRolle;
        private DateTimePicker DtpEintrittL;
        private ComboBox cmbRolle;
        private DateTimePicker DtpAustrittL;
        private Label label6;
        private Label label7;
        private ComboBox CmbAbteilungL;
        private Label LblAbteilungL;
        private Label LblLehrjahreL;
        private ComboBox CmbLehrjahreL;
        private Button BtnSpeichernL;
        private GroupBox GrpKontaktinformationenL;
        private Label label5;
        private Label LblTelefonprivatL;
        private Label LblPostleitzahlL;
        private TextBox TxtEmailL;
        private Label LblMobiltelefonnummerL;
        private TextBox TxtGeschaeftL;
        private TextBox TxtPostleitzahlL;
        private TextBox TxtMobiltelefonnummerL;
        private TextBox TxtHausnummerL;
        private Label lblTelefongeschaeftL;
        private Label LblHausnummerL;
        private TextBox TxtWohnortL;
        private TextBox TxtTelefonprivatL;
        private Label LblWohnortL;
        private TextBox TxtStrasseL;
        private Label LblStrasseL;
        private GroupBox GrpPersoenlichL;
        private Label LblAnredeL;
        private DateTimePicker DtpGeburtsdatumL;
        private ComboBox CmbAnredeL;
        private ComboBox CmbNationalitätL;
        private ComboBox CmbGeschlechtL;
        private TextBox TxtAhvnummerL;
        private Label LblVornameL;
        private Label LblAhvnummerL;
        private Label LblGeschlechtL;
        private TextBox TxtVornameL;
        private Label LblNachnameL;
        private TextBox TxtNachnameL;
        private Label LblGeburtsdatumL;
        private Label TxtNationalitätL;
    }
}