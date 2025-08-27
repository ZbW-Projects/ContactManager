namespace ContactManager.View.Forms
{
    partial class Details
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
            lblPersoenlicheangaben = new Label();
            lblAnrede = new Label();
            lblTitel = new Label();
            lblVorname = new Label();
            lblNachname = new Label();
            lblGeburtsdatum = new Label();
            txtNationalität = new Label();
            lblAdresse = new Label();
            lblPostleitzahl = new Label();
            lblWohnort = new Label();
            label12 = new Label();
            lblTelefongeschaeft = new Label();
            lblTelefonprivat = new Label();
            lblMobiltelefonnummer = new Label();
            lblEmailadresse = new Label();
            cmbAnrede = new ComboBox();
            txtNachname = new TextBox();
            txtWohnort = new TextBox();
          
            txtAdresse = new TextBox();
            txtPostleitzahl = new TextBox();
            txtGeburtsdatum = new TextBox();
            textVorname = new TextBox();
            txtMobiltelefonnummer = new TextBox();
            txtGeschaeft = new TextBox();
            txtTelefonprivat = new TextBox();
            txtEmail = new TextBox();
            lblBeschaeftigungsdaten = new Label();
            lblFirmenname = new Label();
            lblGeschaeftsadresse = new Label();
            lblEintritt = new Label();
            lblAustritt = new Label();
            lblFirmenkontakt = new Label();
            lblRolle = new Label();
            lblKaderstufe = new Label();
            lblLehrjahre = new Label();
            btnSpeichern = new Button();
            txtFirmenkontakt = new TextBox();
            dtpAustritt = new DateTimePicker();
            dtpEintritt = new DateTimePicker();
            cmbAbteilung = new ComboBox();
            cmbLehrjahre = new ComboBox();
            cmbRolle = new ComboBox();
            txtPersoenlichenotiz = new RichTextBox();
            lblPersoenlichenotiz = new Label();
            lblAktuelleslehrjahr = new Label();
            cmdAktlehrjahr = new ComboBox();
            lblTyp = new Label();
            cmbTyp = new ComboBox();
            lblAbteilung = new Label();
            lblAhvnummer = new Label();
            lblBeschaeftigungsgrad = new Label();
            cmbBeschaeftigungsgrad = new ComboBox();
            cmbKaderstufe = new ComboBox();
            txtAhvnummer = new TextBox();
            txtGeschaeftsadresse = new TextBox();
            txtFirmenname = new TextBox();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            cmbNationalität = new ComboBox();
            txtGeschlecht = new Label();
            cmbGeschlecht = new ComboBox();
            lblFirmaKunde = new Label();
            lblAdministratives = new Label();
            SuspendLayout();
            // 
            // lblPersoenlicheangaben
            // 
            lblPersoenlicheangaben.AutoSize = true;
            lblPersoenlicheangaben.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPersoenlicheangaben.Location = new Point(21, 24);
            lblPersoenlicheangaben.Name = "lblPersoenlicheangaben";
            lblPersoenlicheangaben.Size = new Size(123, 15);
            lblPersoenlicheangaben.TabIndex = 0;
            lblPersoenlicheangaben.Text = "Persönliche Angaben";
            lblPersoenlicheangaben.Click += LblTitelPersoendlicheAngaben;
            // 
            // lblAnrede
            // 
            lblAnrede.AutoSize = true;
            lblAnrede.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAnrede.Location = new Point(21, 60);
            lblAnrede.Name = "lblAnrede";
            lblAnrede.Size = new Size(50, 17);
            lblAnrede.TabIndex = 1;
            lblAnrede.Text = "Anrede";
            lblAnrede.Click += LblAnrede;
            // 
            // lblTitel
            // 
            lblTitel.AutoSize = true;
            lblTitel.Location = new Point(21, 91);
            lblTitel.Name = "lblTitel";
            lblTitel.Size = new Size(30, 15);
            lblTitel.TabIndex = 2;
            lblTitel.Text = "Titel";
            lblTitel.Click += LblTitel;
            // 
            // lblVorname
            // 
            lblVorname.AutoSize = true;
            lblVorname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblVorname.Location = new Point(19, 113);
            lblVorname.Name = "lblVorname";
            lblVorname.Size = new Size(60, 17);
            lblVorname.TabIndex = 3;
            lblVorname.Text = "Vorname";
            lblVorname.Click += LblVorname;
            // 
            // lblNachname
            // 
            lblNachname.AutoSize = true;
            lblNachname.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNachname.Location = new Point(19, 142);
            lblNachname.Name = "lblNachname";
            lblNachname.Size = new Size(70, 17);
            lblNachname.TabIndex = 4;
            lblNachname.Text = "Nachname";
            lblNachname.Click += LblNachname;
            // 
            // lblGeburtsdatum
            // 
            lblGeburtsdatum.AutoSize = true;
            lblGeburtsdatum.Location = new Point(19, 173);
            lblGeburtsdatum.Name = "lblGeburtsdatum";
            lblGeburtsdatum.Size = new Size(83, 15);
            lblGeburtsdatum.TabIndex = 6;
            lblGeburtsdatum.Text = "Geburtsdatum";
            lblGeburtsdatum.Click += LblGeburtsdatum;
            // 
            // txtNationalität
            // 
            txtNationalität.AutoSize = true;
            txtNationalität.Location = new Point(19, 231);
            txtNationalität.Name = "txtNationalität";
            txtNationalität.Size = new Size(69, 15);
            txtNationalität.TabIndex = 7;
            txtNationalität.Text = "Nationalität";
            txtNationalität.Click += LblNatonalität;
            // 
            // lblAdresse
            // 
            lblAdresse.AutoSize = true;
            lblAdresse.Location = new Point(19, 260);
            lblAdresse.Name = "lblAdresse";
            lblAdresse.Size = new Size(48, 15);
            lblAdresse.TabIndex = 8;
            lblAdresse.Text = "Adresse";
            lblAdresse.Click += LblAdresse;
            // 
            // lblPostleitzahl
            // 
            lblPostleitzahl.AutoSize = true;
            lblPostleitzahl.Location = new Point(17, 318);
            lblPostleitzahl.Name = "lblPostleitzahl";
            lblPostleitzahl.Size = new Size(67, 15);
            lblPostleitzahl.TabIndex = 9;
            lblPostleitzahl.Text = "Postleitzahl";
            lblPostleitzahl.Click += LblPostpleitzah;
            // 
            // lblWohnort
            // 
            lblWohnort.AutoSize = true;
            lblWohnort.Location = new Point(19, 289);
            lblWohnort.Name = "lblWohnort";
            lblWohnort.Size = new Size(54, 15);
            lblWohnort.TabIndex = 10;
            lblWohnort.Text = "Wohnort";
            lblWohnort.Click += LblWohnort;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label12.Location = new Point(546, 24);
            label12.Name = "label12";
            label12.Size = new Size(132, 15);
            label12.TabIndex = 11;
            label12.Text = "Kontaktinformationen";
            // 
            // lblTelefongeschaeft
            // 
            lblTelefongeschaeft.AutoSize = true;
            lblTelefongeschaeft.Location = new Point(546, 85);
            lblTelefongeschaeft.Name = "lblTelefongeschaeft";
            lblTelefongeschaeft.Size = new Size(95, 15);
            lblTelefongeschaeft.TabIndex = 12;
            lblTelefongeschaeft.Text = "Telefon Geschäft";
            // 
            // lblTelefonprivat
            // 
            lblTelefonprivat.AutoSize = true;
            lblTelefonprivat.Location = new Point(546, 56);
            lblTelefonprivat.Name = "lblTelefonprivat";
            lblTelefonprivat.Size = new Size(79, 15);
            lblTelefonprivat.TabIndex = 13;
            lblTelefonprivat.Text = "Telefon Privat";
            // 
            // lblMobiltelefonnummer
            // 
            lblMobiltelefonnummer.AutoSize = true;
            lblMobiltelefonnummer.Location = new Point(546, 114);
            lblMobiltelefonnummer.Name = "lblMobiltelefonnummer";
            lblMobiltelefonnummer.Size = new Size(121, 15);
            lblMobiltelefonnummer.TabIndex = 14;
            lblMobiltelefonnummer.Text = "Mobiltelefonnummer";
            // 
            // lblEmailadresse
            // 
            lblEmailadresse.AutoSize = true;
            lblEmailadresse.Location = new Point(546, 143);
            lblEmailadresse.Name = "lblEmailadresse";
            lblEmailadresse.Size = new Size(85, 15);
            lblEmailadresse.TabIndex = 15;
            lblEmailadresse.Text = "E-Mail Adresse";
            // 
            // cmbAnrede
            // 
            cmbAnrede.FormattingEnabled = true;
            cmbAnrede.Items.AddRange(new object[] { "Divers", "Frau ", "Herr", "Keine Angabe" });
            cmbAnrede.Location = new Point(115, 59);
            cmbAnrede.Name = "cmbAnrede";
            cmbAnrede.Size = new Size(121, 23);
            cmbAnrede.TabIndex = 16;
            cmbAnrede.SelectedIndexChanged += CmbAnrede_SelectedIndexChanged;
            // 
            // txtNachname
            // 
            txtNachname.Location = new Point(113, 141);
            txtNachname.Name = "txtNachname";
            txtNachname.Size = new Size(121, 23);
            txtNachname.TabIndex = 17;
            txtNachname.TextChanged += TxtNachname_TextChanged;
            // 
            // txtWohnort
            // 
            txtWohnort.Location = new Point(113, 286);
            txtWohnort.Name = "txtWohnort";
            txtWohnort.Size = new Size(121, 23);
            txtWohnort.TabIndex = 19;
            txtWohnort.TextChanged += TxtWohnort_TextChanged;
            // 
            // cmbTitel
            // 
       
            // 
            // txtAdresse
            // 
            txtAdresse.Location = new Point(113, 257);
            txtAdresse.Name = "txtAdresse";
            txtAdresse.Size = new Size(121, 23);
            txtAdresse.TabIndex = 21;
            txtAdresse.TextChanged += TxtAresse_TextChanged;
            // 
            // txtPostleitzahl
            // 
            txtPostleitzahl.Location = new Point(113, 315);
            txtPostleitzahl.Name = "txtPostleitzahl";
            txtPostleitzahl.Size = new Size(121, 23);
            txtPostleitzahl.TabIndex = 22;
            txtPostleitzahl.TextChanged += TxtPLZ_TextChanged;
            // 
            // txtGeburtsdatum
            // 
            txtGeburtsdatum.Location = new Point(113, 170);
            txtGeburtsdatum.Name = "txtGeburtsdatum";
            txtGeburtsdatum.Size = new Size(121, 23);
            txtGeburtsdatum.TabIndex = 23;
            txtGeburtsdatum.TextChanged += TxtGeburtsdatum_TextChanged;
            // 
            // textVorname
            // 
            textVorname.Location = new Point(113, 112);
            textVorname.Name = "textVorname";
            textVorname.Size = new Size(121, 23);
            textVorname.TabIndex = 24;
            textVorname.TextChanged += TxtVorname_TextChanged;
            // 
            // txtMobiltelefonnummer
            // 
            txtMobiltelefonnummer.Location = new Point(673, 111);
            txtMobiltelefonnummer.Name = "txtMobiltelefonnummer";
            txtMobiltelefonnummer.Size = new Size(121, 23);
            txtMobiltelefonnummer.TabIndex = 25;
            // 
            // txtGeschaeft
            // 
            txtGeschaeft.Location = new Point(673, 82);
            txtGeschaeft.Name = "txtGeschaeft";
            txtGeschaeft.Size = new Size(121, 23);
            txtGeschaeft.TabIndex = 26;
            // 
            // txtTelefonprivat
            // 
            txtTelefonprivat.Location = new Point(673, 53);
            txtTelefonprivat.Name = "txtTelefonprivat";
            txtTelefonprivat.Size = new Size(121, 23);
            txtTelefonprivat.TabIndex = 27;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(673, 140);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(121, 23);
            txtEmail.TabIndex = 28;
            // 
            // lblBeschaeftigungsdaten
            // 
            lblBeschaeftigungsdaten.AutoSize = true;
            lblBeschaeftigungsdaten.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblBeschaeftigungsdaten.Location = new Point(268, 24);
            lblBeschaeftigungsdaten.Name = "lblBeschaeftigungsdaten";
            lblBeschaeftigungsdaten.Size = new Size(124, 15);
            lblBeschaeftigungsdaten.TabIndex = 30;
            lblBeschaeftigungsdaten.Text = "Beschäftigungsdaten";
            lblBeschaeftigungsdaten.Click += label6_Click;
            // 
            // lblFirmenname
            // 
            lblFirmenname.AutoSize = true;
            lblFirmenname.Location = new Point(21, 376);
            lblFirmenname.Name = "lblFirmenname";
            lblFirmenname.Size = new Size(74, 15);
            lblFirmenname.TabIndex = 31;
            lblFirmenname.Text = "Firmenname";
            lblFirmenname.Click += label17_Click;
            // 
            // lblGeschaeftsadresse
            // 
            lblGeschaeftsadresse.AutoSize = true;
            lblGeschaeftsadresse.Location = new Point(22, 434);
            lblGeschaeftsadresse.Name = "lblGeschaeftsadresse";
            lblGeschaeftsadresse.Size = new Size(97, 15);
            lblGeschaeftsadresse.TabIndex = 32;
            lblGeschaeftsadresse.Text = "Geschäftsadresse";
            // 
            // lblEintritt
            // 
            lblEintritt.AutoSize = true;
            lblEintritt.Location = new Point(268, 398);
            lblEintritt.Name = "lblEintritt";
            lblEintritt.Size = new Size(42, 15);
            lblEintritt.TabIndex = 33;
            lblEintritt.Text = "Eintritt";
            // 
            // lblAustritt
            // 
            lblAustritt.AutoSize = true;
            lblAustritt.Location = new Point(268, 433);
            lblAustritt.Name = "lblAustritt";
            lblAustritt.Size = new Size(46, 15);
            lblAustritt.TabIndex = 34;
            lblAustritt.Text = "Austritt";
            // 
            // lblFirmenkontakt
            // 
            lblFirmenkontakt.AutoSize = true;
            lblFirmenkontakt.Location = new Point(22, 402);
            lblFirmenkontakt.Name = "lblFirmenkontakt";
            lblFirmenkontakt.Size = new Size(84, 15);
            lblFirmenkontakt.TabIndex = 35;
            lblFirmenkontakt.Text = "Firmenkontakt";
            // 
            // lblRolle
            // 
            lblRolle.AutoSize = true;
            lblRolle.Location = new Point(268, 86);
            lblRolle.Name = "lblRolle";
            lblRolle.Size = new Size(33, 15);
            lblRolle.TabIndex = 36;
            lblRolle.Text = "Rolle";
            // 
            // lblKaderstufe
            // 
            lblKaderstufe.AutoSize = true;
            lblKaderstufe.Location = new Point(268, 174);
            lblKaderstufe.Name = "lblKaderstufe";
            lblKaderstufe.Size = new Size(63, 15);
            lblKaderstufe.TabIndex = 37;
            lblKaderstufe.Text = "Kaderstufe";
            // 
            // lblLehrjahre
            // 
            lblLehrjahre.AutoSize = true;
            lblLehrjahre.Location = new Point(268, 203);
            lblLehrjahre.Name = "lblLehrjahre";
            lblLehrjahre.Size = new Size(56, 15);
            lblLehrjahre.TabIndex = 38;
            lblLehrjahre.Text = "Lehrjahre";
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(718, 451);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(77, 30);
            btnSpeichern.TabIndex = 39;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // txtFirmenkontakt
            // 
            txtFirmenkontakt.Location = new Point(121, 402);
            txtFirmenkontakt.Name = "txtFirmenkontakt";
            txtFirmenkontakt.Size = new Size(121, 23);
            txtFirmenkontakt.TabIndex = 41;
            // 
            // dtpAustritt
            // 
            dtpAustritt.Location = new Point(320, 427);
            dtpAustritt.Name = "dtpAustritt";
            dtpAustritt.Size = new Size(199, 23);
            dtpAustritt.TabIndex = 43;
            // 
            // dtpEintritt
            // 
            dtpEintritt.Location = new Point(320, 392);
            dtpEintritt.Name = "dtpEintritt";
            dtpEintritt.Size = new Size(199, 23);
            dtpEintritt.TabIndex = 44;
            // 
            // cmbAbteilung
            // 
            cmbAbteilung.FormattingEnabled = true;
            cmbAbteilung.Items.AddRange(new object[] { "IT", "Finanzen", "HR", "Verkauf", "Produktion", "Verwaltung" });
            cmbAbteilung.Location = new Point(395, 112);
            cmbAbteilung.Name = "cmbAbteilung";
            cmbAbteilung.Size = new Size(121, 23);
            cmbAbteilung.TabIndex = 46;
            // 
            // cmbLehrjahre
            // 
            cmbLehrjahre.FormattingEnabled = true;
            cmbLehrjahre.Items.AddRange(new object[] { "1. Lehrjahre", "2. Lehrjahre", "3. Lehrjahre ", "4. Lehrjahre ", "" });
            cmbLehrjahre.Location = new Point(395, 200);
            cmbLehrjahre.Name = "cmbLehrjahre";
            cmbLehrjahre.Size = new Size(121, 23);
            cmbLehrjahre.TabIndex = 47;
            // 
            // cmbRolle
            // 
            cmbRolle.FormattingEnabled = true;
            cmbRolle.Items.AddRange(new object[] { "System Engineer", "Entwickler", "Projektleiter", "Kaufmännische/r Angestellte/r", "Support" });
            cmbRolle.Location = new Point(395, 83);
            cmbRolle.Name = "cmbRolle";
            cmbRolle.Size = new Size(121, 23);
            cmbRolle.TabIndex = 48;
            // 
            // txtPersoenlichenotiz
            // 
            txtPersoenlichenotiz.Location = new Point(546, 249);
            txtPersoenlichenotiz.Name = "txtPersoenlichenotiz";
            txtPersoenlichenotiz.Size = new Size(230, 84);
            txtPersoenlichenotiz.TabIndex = 49;
            txtPersoenlichenotiz.Text = "";
            txtPersoenlichenotiz.TextChanged += richTextBox1_TextChanged;
            // 
            // lblPersoenlichenotiz
            // 
            lblPersoenlichenotiz.AutoSize = true;
            lblPersoenlichenotiz.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblPersoenlichenotiz.Location = new Point(546, 200);
            lblPersoenlichenotiz.Name = "lblPersoenlichenotiz";
            lblPersoenlichenotiz.Size = new Size(104, 15);
            lblPersoenlichenotiz.TabIndex = 50;
            lblPersoenlichenotiz.Text = "Persönliche Notiz";
            // 
            // lblAktuelleslehrjahr
            // 
            lblAktuelleslehrjahr.AutoSize = true;
            lblAktuelleslehrjahr.Location = new Point(268, 232);
            lblAktuelleslehrjahr.Name = "lblAktuelleslehrjahr";
            lblAktuelleslehrjahr.Size = new Size(101, 15);
            lblAktuelleslehrjahr.TabIndex = 54;
            lblAktuelleslehrjahr.Text = "Aktuelles Lehrjahr";
            lblAktuelleslehrjahr.Click += label27_Click;
            // 
            // cmdAktlehrjahr
            // 
            cmdAktlehrjahr.FormattingEnabled = true;
            cmdAktlehrjahr.Items.AddRange(new object[] { "1. Lehrjahr", "2. Lehrjahr", "3. Lehrjahr ", "4. Lehrjahr " });
            cmdAktlehrjahr.Location = new Point(395, 229);
            cmdAktlehrjahr.Name = "cmdAktlehrjahr";
            cmdAktlehrjahr.Size = new Size(121, 23);
            cmdAktlehrjahr.TabIndex = 55;
            // 
            // lblTyp
            // 
            lblTyp.AutoSize = true;
            lblTyp.Location = new Point(268, 62);
            lblTyp.Name = "lblTyp";
            lblTyp.Size = new Size(26, 15);
            lblTyp.TabIndex = 56;
            lblTyp.Text = "Typ";
            // 
            // cmbTyp
            // 
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Items.AddRange(new object[] { "Mitarbeiter", "Lernender", "", "", "", "", "Extern" });
            cmbTyp.Location = new Point(395, 54);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(121, 23);
            cmbTyp.TabIndex = 57;
            cmbTyp.SelectedIndexChanged += comboBox9_SelectedIndexChanged;
            // 
            // lblAbteilung
            // 
            lblAbteilung.AutoSize = true;
            lblAbteilung.Location = new Point(268, 115);
            lblAbteilung.Name = "lblAbteilung";
            lblAbteilung.Size = new Size(59, 15);
            lblAbteilung.TabIndex = 58;
            lblAbteilung.Text = "Abteilung";
            // 
            // lblAhvnummer
            // 
            lblAhvnummer.AutoSize = true;
            lblAhvnummer.Location = new Point(268, 332);
            lblAhvnummer.Name = "lblAhvnummer";
            lblAhvnummer.Size = new Size(84, 15);
            lblAhvnummer.TabIndex = 59;
            lblAhvnummer.Text = "AHV-Nummer";
            // 
            // lblBeschaeftigungsgrad
            // 
            lblBeschaeftigungsgrad.AutoSize = true;
            lblBeschaeftigungsgrad.Location = new Point(268, 144);
            lblBeschaeftigungsgrad.Name = "lblBeschaeftigungsgrad";
            lblBeschaeftigungsgrad.Size = new Size(112, 15);
            lblBeschaeftigungsgrad.TabIndex = 60;
            lblBeschaeftigungsgrad.Text = "Beschäftigungsgrad";
            // 
            // cmbBeschaeftigungsgrad
            // 
            cmbBeschaeftigungsgrad.FormattingEnabled = true;
            cmbBeschaeftigungsgrad.Items.AddRange(new object[] { "100 %", "80 %", "60 %", "40 %", "20%" });
            cmbBeschaeftigungsgrad.Location = new Point(395, 141);
            cmbBeschaeftigungsgrad.Name = "cmbBeschaeftigungsgrad";
            cmbBeschaeftigungsgrad.Size = new Size(121, 23);
            cmbBeschaeftigungsgrad.TabIndex = 61;
            // 
            // cmbKaderstufe
            // 
            cmbKaderstufe.FormattingEnabled = true;
            cmbKaderstufe.Items.AddRange(new object[] { "0 = keine Kaderfunktion", "1 = Teamleiter", "2 = Abteilungsleiter", "3 = Bereichsleiter", "4 = Geschäftsleitung ", "5 = Direktion" });
            cmbKaderstufe.Location = new Point(395, 171);
            cmbKaderstufe.Name = "cmbKaderstufe";
            cmbKaderstufe.Size = new Size(121, 23);
            cmbKaderstufe.TabIndex = 62;
            // 
            // txtAhvnummer
            // 
            txtAhvnummer.Location = new Point(377, 329);
            txtAhvnummer.Name = "txtAhvnummer";
            txtAhvnummer.Size = new Size(121, 23);
            txtAhvnummer.TabIndex = 63;
            txtAhvnummer.TextChanged += textBox13_TextChanged;
            // 
            // txtGeschaeftsadresse
            // 
            txtGeschaeftsadresse.Location = new Point(121, 431);
            txtGeschaeftsadresse.Name = "txtGeschaeftsadresse";
            txtGeschaeftsadresse.Size = new Size(121, 23);
            txtGeschaeftsadresse.TabIndex = 64;
            // 
            // txtFirmenname
            // 
            txtFirmenname.Location = new Point(121, 373);
            txtFirmenname.Name = "txtFirmenname";
            txtFirmenname.Size = new Size(121, 23);
            txtFirmenname.TabIndex = 65;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aktiv", "Passiv" });
            cmbStatus.Location = new Point(377, 358);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 66;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(268, 361);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 67;
            lblStatus.Text = "Status";
            // 
            // cmbNationalität
            // 
            cmbNationalität.FormattingEnabled = true;
            cmbNationalität.Items.AddRange(new object[] { "Dr.", "Prof." });
            cmbNationalität.Location = new Point(113, 228);
            cmbNationalität.Name = "cmbNationalität";
            cmbNationalität.Size = new Size(121, 23);
            cmbNationalität.TabIndex = 68;
            cmbNationalität.SelectedIndexChanged += CmbNationalität_SelectedIndexChanged;
            // 
            // txtGeschlecht
            // 
            txtGeschlecht.AutoSize = true;
            txtGeschlecht.Location = new Point(19, 202);
            txtGeschlecht.Name = "txtGeschlecht";
            txtGeschlecht.Size = new Size(65, 15);
            txtGeschlecht.TabIndex = 69;
            txtGeschlecht.Text = "Geschlecht";
            txtGeschlecht.Click += LblGeshlecht;
            // 
            // cmbGeschlecht
            // 
            cmbGeschlecht.FormattingEnabled = true;
            cmbGeschlecht.Items.AddRange(new object[] { "Männlich", "Weiblich", "Divers ", "Keine Angabe" });
            cmbGeschlecht.Location = new Point(113, 199);
            cmbGeschlecht.Name = "cmbGeschlecht";
            cmbGeschlecht.Size = new Size(121, 23);
            cmbGeschlecht.TabIndex = 70;
            cmbGeschlecht.SelectedIndexChanged += CmbGeschlecht_SelectedIndexChanged;
            // 
            // lblFirmaKunde
            // 
            lblFirmaKunde.AutoSize = true;
            lblFirmaKunde.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFirmaKunde.Location = new Point(20, 350);
            lblFirmaKunde.Name = "lblFirmaKunde";
            lblFirmaKunde.Size = new Size(85, 15);
            lblFirmaKunde.TabIndex = 71;
            lblFirmaKunde.Text = "Firma / Kunde";
            lblFirmaKunde.Click += label33_Click;
            // 
            // lblAdministratives
            // 
            lblAdministratives.AutoSize = true;
            lblAdministratives.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblAdministratives.Location = new Point(268, 294);
            lblAdministratives.Name = "lblAdministratives";
            lblAdministratives.Size = new Size(94, 15);
            lblAdministratives.TabIndex = 72;
            lblAdministratives.Text = "Administratives";
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 493);
            Controls.Add(lblAdministratives);
            Controls.Add(lblFirmaKunde);
            Controls.Add(cmbGeschlecht);
            Controls.Add(txtGeschlecht);
            Controls.Add(cmbNationalität);
            Controls.Add(lblStatus);
            Controls.Add(cmbStatus);
            Controls.Add(txtFirmenname);
            Controls.Add(txtGeschaeftsadresse);
            Controls.Add(txtAhvnummer);
            Controls.Add(cmbKaderstufe);
            Controls.Add(cmbBeschaeftigungsgrad);
            Controls.Add(lblBeschaeftigungsgrad);
            Controls.Add(lblAhvnummer);
            Controls.Add(lblAbteilung);
            Controls.Add(cmbTyp);
            Controls.Add(lblTyp);
            Controls.Add(cmdAktlehrjahr);
            Controls.Add(lblAktuelleslehrjahr);
            Controls.Add(lblPersoenlichenotiz);
            Controls.Add(txtPersoenlichenotiz);
            Controls.Add(cmbRolle);
            Controls.Add(cmbLehrjahre);
            Controls.Add(cmbAbteilung);
            Controls.Add(dtpEintritt);
            Controls.Add(dtpAustritt);
            Controls.Add(txtFirmenkontakt);
            Controls.Add(btnSpeichern);
            Controls.Add(lblLehrjahre);
            Controls.Add(lblKaderstufe);
            Controls.Add(lblRolle);
            Controls.Add(lblFirmenkontakt);
            Controls.Add(lblAustritt);
            Controls.Add(lblEintritt);
            Controls.Add(lblGeschaeftsadresse);
            Controls.Add(lblFirmenname);
            Controls.Add(lblBeschaeftigungsdaten);
            Controls.Add(txtEmail);
            Controls.Add(txtTelefonprivat);
            Controls.Add(txtGeschaeft);
            Controls.Add(txtMobiltelefonnummer);
            Controls.Add(textVorname);
            Controls.Add(txtGeburtsdatum);
            Controls.Add(txtPostleitzahl);
            Controls.Add(txtAdresse);
           
            Controls.Add(txtWohnort);
            Controls.Add(txtNachname);
            Controls.Add(cmbAnrede);
            Controls.Add(lblEmailadresse);
            Controls.Add(lblMobiltelefonnummer);
            Controls.Add(lblTelefonprivat);
            Controls.Add(lblTelefongeschaeft);
            Controls.Add(label12);
            Controls.Add(lblWohnort);
            Controls.Add(lblPostleitzahl);
            Controls.Add(lblAdresse);
            Controls.Add(txtNationalität);
            Controls.Add(lblGeburtsdatum);
            Controls.Add(lblNachname);
            Controls.Add(lblVorname);
            Controls.Add(lblTitel);
            Controls.Add(lblAnrede);
            Controls.Add(lblPersoenlicheangaben);
            Name = "Details";
            Text = "Details";
            Load += Details_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPersoenlicheangaben;
        private Label lblAnrede;
        private Label lblTitel;
        private Label lblVorname;
        private Label lblNachname;
        private Label lblGeburtsdatum;
        private Label txtNationalität;
        private Label lblAdresse;
        private Label lblPostleitzahl;
        private Label lblWohnort;
        private Label label12;
        private Label lblTelefongeschaeft;
        private Label lblTelefonprivat;
        private Label lblMobiltelefonnummer;
        private Label lblEmailadresse;
        private ComboBox cmbAnrede;
        private TextBox txtNachname;
        private TextBox txtWohnort;
 
        private TextBox txtAdresse;
        private TextBox txtPostleitzahl;
        private TextBox txtGeburtsdatum;
        private TextBox textVorname;
        private TextBox txtMobiltelefonnummer;
        private TextBox txtGeschaeft;
        private TextBox txtTelefonprivat;
        private TextBox txtEmail;
        private Label lblBeschaeftigungsdaten;
        private Label lblFirmenname;
        private Label lblGeschaeftsadresse;
        private Label lblEintritt;
        private Label lblAustritt;
        private Label lblFirmenkontakt;
        private Label lblRolle;
        private Label lblKaderstufe;
        private Label lblLehrjahre;
        private Button btnSpeichern;
        private TextBox txtFirmenkontakt;
        private DateTimePicker dtpAustritt;
        private DateTimePicker dtpEintritt;
        private ComboBox cmbAbteilung;
        private ComboBox cmbLehrjahre;
        private ComboBox cmbRolle;
        private RichTextBox txtPersoenlichenotiz;
        private Label lblPersoenlichenotiz;
        private Label lblAktuelleslehrjahr;
        private ComboBox cmdAktlehrjahr;
        private Label lblTyp;
        private ComboBox cmbTyp;
        private Label lblAbteilung;
        private Label lblAhvnummer;
        private Label lblBeschaeftigungsgrad;
        private ComboBox cmbBeschaeftigungsgrad;
        private ComboBox cmbKaderstufe;
        private TextBox txtAhvnummer;
        private TextBox txtGeschaeftsadresse;
        private TextBox txtFirmenname;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private ComboBox cmbNationalität;
        private Label txtGeschlecht;
        private ComboBox cmbGeschlecht;
        private Label lblFirmaKunde;
        private Label lblAdministratives;
    }
}
