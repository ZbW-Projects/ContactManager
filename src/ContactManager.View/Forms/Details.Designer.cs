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
            LblAnredeL = new Label();
            LblTitelL = new Label();
            LblGeburtsdatumL = new Label();
            TxtNationalitätL = new Label();
            LblAdresseL = new Label();
            LblPostleitzahlL = new Label();
            LblWohnortL = new Label();
            lblTelefongeschaeftL = new Label();
            LblTelefonprivatL = new Label();
            LblMobiltelefonnummerL = new Label();
            LblEmailadresseL = new Label();
            CmbAnredeL = new ComboBox();
            TxtNachnameL = new TextBox();
            TxtWohnortL = new TextBox();
            TxtAdresseL = new TextBox();
            TxtPostleitzahlL = new TextBox();
            TxtVornameL = new TextBox();
            TxtMobiltelefonnummerL = new TextBox();
            TxtGeschaeftL = new TextBox();
            TxtTelefonprivatL = new TextBox();
            TxtEmailL = new TextBox();
            lblFirmenname = new Label();
            lblGeschaeftsadresse = new Label();
            lblEintritt = new Label();
            lblAustritt = new Label();
            lblFirmenkontakt = new Label();
            lblRolle = new Label();
            lblKaderstufe = new Label();
            LblStatusL = new Label();
            btnSpeichern = new Button();
            txtFirmenkontakt = new TextBox();
            dtpAustritt = new DateTimePicker();
            dtpEintritt = new DateTimePicker();
            cmbAbteilung = new ComboBox();
            CmbLehrjahreL = new ComboBox();
            cmbRolle = new ComboBox();
            txtPersoenlichenotiz = new RichTextBox();
            lblPersoenlichenotiz = new Label();
            LblAktuelleslehrjahrL = new Label();
            CmdAktuellesLehrjahrL = new ComboBox();
            lblTyp = new Label();
            cmbTyp = new ComboBox();
            lblAbteilung = new Label();
            LblAhvnummerL = new Label();
            lblBeschaeftigungsgrad = new Label();
            cmbBeschaeftigungsgrad = new ComboBox();
            cmbKaderstufe = new ComboBox();
            TxtAhvnummerL = new TextBox();
            txtGeschaeftsadresse = new TextBox();
            txtFirmenname = new TextBox();
            cmbStatus = new ComboBox();
            lblStatus = new Label();
            CmbNationalitätL = new ComboBox();
            LblGeschlechtL = new Label();
            CmbGeschlechtL = new ComboBox();
            lblFirmaKunde = new Label();
            DtpGeburtsdatumL = new DateTimePicker();
            PERSON = new TabControl();
            tabKunde = new TabPage();
            dateTimePicker2 = new DateTimePicker();
            label1 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            tabMitarbeiter = new TabPage();
            tabLehrling = new TabPage();
            CmbStatusL = new ComboBox();
            GrpBeschaeftigungsdatenL = new GroupBox();
            LblLehrjahreL = new Label();
            GrpKontaktinformationenL = new GroupBox();
            GrpPersoenlichL = new GroupBox();
            LblVornameL = new Label();
            LblNachnameL = new Label();
            TxtTitelL = new TextBox();
            BtnSpeichernL = new Button();
            PERSON.SuspendLayout();
            tabKunde.SuspendLayout();
            tabMitarbeiter.SuspendLayout();
            tabLehrling.SuspendLayout();
            GrpBeschaeftigungsdatenL.SuspendLayout();
            GrpKontaktinformationenL.SuspendLayout();
            GrpPersoenlichL.SuspendLayout();
            SuspendLayout();
            // 
            // LblAnredeL
            // 
            LblAnredeL.AutoSize = true;
            LblAnredeL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblAnredeL.Location = new Point(25, 36);
            LblAnredeL.Name = "LblAnredeL";
            LblAnredeL.Size = new Size(50, 17);
            LblAnredeL.TabIndex = 1;
            LblAnredeL.Text = "Anrede";
            LblAnredeL.Click += LblAnrede;
            // 
            // LblTitelL
            // 
            LblTitelL.AutoSize = true;
            LblTitelL.Location = new Point(25, 191);
            LblTitelL.Name = "LblTitelL";
            LblTitelL.Size = new Size(30, 15);
            LblTitelL.TabIndex = 2;
            LblTitelL.Text = "Titel";
            LblTitelL.Click += LblTitel;
            // 
            // LblGeburtsdatumL
            // 
            LblGeburtsdatumL.AutoSize = true;
            LblGeburtsdatumL.Location = new Point(25, 133);
            LblGeburtsdatumL.Name = "LblGeburtsdatumL";
            LblGeburtsdatumL.Size = new Size(83, 15);
            LblGeburtsdatumL.TabIndex = 6;
            LblGeburtsdatumL.Text = "Geburtsdatum";
            LblGeburtsdatumL.Click += LblGeburtsdatum;
            // 
            // TxtNationalitätL
            // 
            TxtNationalitätL.AutoSize = true;
            TxtNationalitätL.Location = new Point(25, 250);
            TxtNationalitätL.Name = "TxtNationalitätL";
            TxtNationalitätL.Size = new Size(69, 15);
            TxtNationalitätL.TabIndex = 7;
            TxtNationalitätL.Text = "Nationalität";
            TxtNationalitätL.Click += LblNatonalität;
            // 
            // LblAdresseL
            // 
            LblAdresseL.AutoSize = true;
            LblAdresseL.Location = new Point(27, 279);
            LblAdresseL.Name = "LblAdresseL";
            LblAdresseL.Size = new Size(48, 15);
            LblAdresseL.TabIndex = 8;
            LblAdresseL.Text = "Adresse";
            LblAdresseL.Click += LblAdresse;
            // 
            // LblPostleitzahlL
            // 
            LblPostleitzahlL.AutoSize = true;
            LblPostleitzahlL.Location = new Point(25, 337);
            LblPostleitzahlL.Name = "LblPostleitzahlL";
            LblPostleitzahlL.Size = new Size(67, 15);
            LblPostleitzahlL.TabIndex = 9;
            LblPostleitzahlL.Text = "Postleitzahl";
            LblPostleitzahlL.Click += LblPostpleitzah;
            // 
            // LblWohnortL
            // 
            LblWohnortL.AutoSize = true;
            LblWohnortL.Location = new Point(25, 305);
            LblWohnortL.Name = "LblWohnortL";
            LblWohnortL.Size = new Size(54, 15);
            LblWohnortL.TabIndex = 10;
            LblWohnortL.Text = "Wohnort";
            LblWohnortL.Click += LblWohnort;
            // 
            // lblTelefongeschaeftL
            // 
            lblTelefongeschaeftL.AutoSize = true;
            lblTelefongeschaeftL.Location = new Point(14, 68);
            lblTelefongeschaeftL.Name = "lblTelefongeschaeftL";
            lblTelefongeschaeftL.Size = new Size(95, 15);
            lblTelefongeschaeftL.TabIndex = 12;
            lblTelefongeschaeftL.Text = "Telefon Geschäft";
            // 
            // LblTelefonprivatL
            // 
            LblTelefonprivatL.AutoSize = true;
            LblTelefonprivatL.Location = new Point(14, 39);
            LblTelefonprivatL.Name = "LblTelefonprivatL";
            LblTelefonprivatL.Size = new Size(79, 15);
            LblTelefonprivatL.TabIndex = 13;
            LblTelefonprivatL.Text = "Telefon Privat";
            LblTelefonprivatL.Click += LblTelefonprivatL_Click;
            // 
            // LblMobiltelefonnummerL
            // 
            LblMobiltelefonnummerL.AutoSize = true;
            LblMobiltelefonnummerL.Location = new Point(14, 97);
            LblMobiltelefonnummerL.Name = "LblMobiltelefonnummerL";
            LblMobiltelefonnummerL.Size = new Size(121, 15);
            LblMobiltelefonnummerL.TabIndex = 14;
            LblMobiltelefonnummerL.Text = "Mobiltelefonnummer";
            LblMobiltelefonnummerL.Click += LblMobiltelefonnummerL_Click;
            // 
            // LblEmailadresseL
            // 
            LblEmailadresseL.AutoSize = true;
            LblEmailadresseL.Location = new Point(14, 126);
            LblEmailadresseL.Name = "LblEmailadresseL";
            LblEmailadresseL.Size = new Size(85, 15);
            LblEmailadresseL.TabIndex = 15;
            LblEmailadresseL.Text = "E-Mail Adresse";
            LblEmailadresseL.Click += LblEmailadresseL_Click;
            // 
            // CmbAnredeL
            // 
            CmbAnredeL.FormattingEnabled = true;
            CmbAnredeL.Items.AddRange(new object[] { "Divers", "Frau ", "Herr", "Keine Angabe" });
            CmbAnredeL.Location = new Point(146, 35);
            CmbAnredeL.Name = "CmbAnredeL";
            CmbAnredeL.Size = new Size(121, 23);
            CmbAnredeL.TabIndex = 16;
            CmbAnredeL.SelectedIndexChanged += CmbAnredeL_SelectedIndexChanged;
            // 
            // TxtNachnameL
            // 
            TxtNachnameL.Location = new Point(146, 95);
            TxtNachnameL.Name = "TxtNachnameL";
            TxtNachnameL.Size = new Size(121, 23);
            TxtNachnameL.TabIndex = 17;
            TxtNachnameL.TextChanged += TxtNachnameL_TextChanged;
            // 
            // TxtWohnortL
            // 
            TxtWohnortL.Location = new Point(146, 305);
            TxtWohnortL.Name = "TxtWohnortL";
            TxtWohnortL.Size = new Size(121, 23);
            TxtWohnortL.TabIndex = 19;
            TxtWohnortL.TextChanged += TxtWohnortL_TextChanged;
            // 
            // TxtAdresseL
            // 
            TxtAdresseL.Location = new Point(146, 276);
            TxtAdresseL.Name = "TxtAdresseL";
            TxtAdresseL.Size = new Size(121, 23);
            TxtAdresseL.TabIndex = 21;
            TxtAdresseL.TextChanged += TxtAdresseL_TextChanged;
            // 
            // TxtPostleitzahlL
            // 
            TxtPostleitzahlL.Location = new Point(146, 334);
            TxtPostleitzahlL.Name = "TxtPostleitzahlL";
            TxtPostleitzahlL.Size = new Size(121, 23);
            TxtPostleitzahlL.TabIndex = 22;
            TxtPostleitzahlL.TextChanged += TxtPostleitzahlL_TextChanged;
            // 
            // TxtVornameL
            // 
            TxtVornameL.Location = new Point(146, 64);
            TxtVornameL.Name = "TxtVornameL";
            TxtVornameL.Size = new Size(121, 23);
            TxtVornameL.TabIndex = 24;
            TxtVornameL.TextChanged += TxtVornameL_TextChanged;
            // 
            // TxtMobiltelefonnummerL
            // 
            TxtMobiltelefonnummerL.Location = new Point(141, 94);
            TxtMobiltelefonnummerL.Name = "TxtMobiltelefonnummerL";
            TxtMobiltelefonnummerL.Size = new Size(121, 23);
            TxtMobiltelefonnummerL.TabIndex = 25;
            TxtMobiltelefonnummerL.TextChanged += TxtMobiltelefonnummerL_TextChanged;
            // 
            // TxtGeschaeftL
            // 
            TxtGeschaeftL.Location = new Point(141, 65);
            TxtGeschaeftL.Name = "TxtGeschaeftL";
            TxtGeschaeftL.Size = new Size(121, 23);
            TxtGeschaeftL.TabIndex = 26;
            TxtGeschaeftL.TextChanged += TxtGeschaeftL_TextChanged;
            // 
            // TxtTelefonprivatL
            // 
            TxtTelefonprivatL.Location = new Point(141, 36);
            TxtTelefonprivatL.Name = "TxtTelefonprivatL";
            TxtTelefonprivatL.Size = new Size(121, 23);
            TxtTelefonprivatL.TabIndex = 27;
            TxtTelefonprivatL.TextChanged += TxtTelefonprivatL_TextChanged;
            // 
            // TxtEmailL
            // 
            TxtEmailL.Location = new Point(141, 123);
            TxtEmailL.Name = "TxtEmailL";
            TxtEmailL.Size = new Size(121, 23);
            TxtEmailL.TabIndex = 28;
            TxtEmailL.TextChanged += TxtEmailL_TextChanged;
            // 
            // lblFirmenname
            // 
            lblFirmenname.AutoSize = true;
            lblFirmenname.Location = new Point(44, 302);
            lblFirmenname.Name = "lblFirmenname";
            lblFirmenname.Size = new Size(74, 15);
            lblFirmenname.TabIndex = 31;
            lblFirmenname.Text = "Firmenname";
            lblFirmenname.Click += label17_Click;
            // 
            // lblGeschaeftsadresse
            // 
            lblGeschaeftsadresse.AutoSize = true;
            lblGeschaeftsadresse.Location = new Point(45, 360);
            lblGeschaeftsadresse.Name = "lblGeschaeftsadresse";
            lblGeschaeftsadresse.Size = new Size(97, 15);
            lblGeschaeftsadresse.TabIndex = 32;
            lblGeschaeftsadresse.Text = "Geschäftsadresse";
            // 
            // lblEintritt
            // 
            lblEintritt.AutoSize = true;
            lblEintritt.Location = new Point(89, 305);
            lblEintritt.Name = "lblEintritt";
            lblEintritt.Size = new Size(42, 15);
            lblEintritt.TabIndex = 33;
            lblEintritt.Text = "Eintritt";
            // 
            // lblAustritt
            // 
            lblAustritt.AutoSize = true;
            lblAustritt.Location = new Point(89, 340);
            lblAustritt.Name = "lblAustritt";
            lblAustritt.Size = new Size(46, 15);
            lblAustritt.TabIndex = 34;
            lblAustritt.Text = "Austritt";
            // 
            // lblFirmenkontakt
            // 
            lblFirmenkontakt.AutoSize = true;
            lblFirmenkontakt.Location = new Point(45, 328);
            lblFirmenkontakt.Name = "lblFirmenkontakt";
            lblFirmenkontakt.Size = new Size(84, 15);
            lblFirmenkontakt.TabIndex = 35;
            lblFirmenkontakt.Text = "Firmenkontakt";
            // 
            // lblRolle
            // 
            lblRolle.AutoSize = true;
            lblRolle.Location = new Point(57, 84);
            lblRolle.Name = "lblRolle";
            lblRolle.Size = new Size(33, 15);
            lblRolle.TabIndex = 36;
            lblRolle.Text = "Rolle";
            // 
            // lblKaderstufe
            // 
            lblKaderstufe.AutoSize = true;
            lblKaderstufe.Location = new Point(57, 172);
            lblKaderstufe.Name = "lblKaderstufe";
            lblKaderstufe.Size = new Size(63, 15);
            lblKaderstufe.TabIndex = 37;
            lblKaderstufe.Text = "Kaderstufe";
            // 
            // LblStatusL
            // 
            LblStatusL.AutoSize = true;
            LblStatusL.Location = new Point(346, 378);
            LblStatusL.Name = "LblStatusL";
            LblStatusL.Size = new Size(45, 15);
            LblStatusL.TabIndex = 38;
            LblStatusL.Text = "Status :";
            LblStatusL.Click += LblStatusL_Click;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(400, 276);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(77, 30);
            btnSpeichern.TabIndex = 39;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            // 
            // txtFirmenkontakt
            // 
            txtFirmenkontakt.Location = new Point(144, 328);
            txtFirmenkontakt.Name = "txtFirmenkontakt";
            txtFirmenkontakt.Size = new Size(121, 23);
            txtFirmenkontakt.TabIndex = 41;
            // 
            // dtpAustritt
            // 
            dtpAustritt.Location = new Point(141, 334);
            dtpAustritt.Name = "dtpAustritt";
            dtpAustritt.Size = new Size(199, 23);
            dtpAustritt.TabIndex = 43;
            // 
            // dtpEintritt
            // 
            dtpEintritt.Location = new Point(141, 299);
            dtpEintritt.Name = "dtpEintritt";
            dtpEintritt.Size = new Size(199, 23);
            dtpEintritt.TabIndex = 44;
            // 
            // cmbAbteilung
            // 
            cmbAbteilung.FormattingEnabled = true;
            cmbAbteilung.Items.AddRange(new object[] { "IT", "Finanzen", "HR", "Verkauf", "Produktion", "Verwaltung" });
            cmbAbteilung.Location = new Point(184, 110);
            cmbAbteilung.Name = "cmbAbteilung";
            cmbAbteilung.Size = new Size(121, 23);
            cmbAbteilung.TabIndex = 46;
            // 
            // CmbLehrjahreL
            // 
            CmbLehrjahreL.FormattingEnabled = true;
            CmbLehrjahreL.Items.AddRange(new object[] { "1. Lehrjahre", "2. Lehrjahre", "3. Lehrjahre", "4. Lehrjahre" });
            CmbLehrjahreL.Location = new Point(141, 37);
            CmbLehrjahreL.Name = "CmbLehrjahreL";
            CmbLehrjahreL.Size = new Size(121, 23);
            CmbLehrjahreL.TabIndex = 47;
            CmbLehrjahreL.SelectedIndexChanged += CmbLehrjahreL_SelectedIndexChanged;
            // 
            // cmbRolle
            // 
            cmbRolle.FormattingEnabled = true;
            cmbRolle.Items.AddRange(new object[] { "System Engineer", "Entwickler", "Projektleiter", "Kaufmännische/r Angestellte/r", "Support" });
            cmbRolle.Location = new Point(184, 81);
            cmbRolle.Name = "cmbRolle";
            cmbRolle.Size = new Size(121, 23);
            cmbRolle.TabIndex = 48;
            // 
            // txtPersoenlichenotiz
            // 
            txtPersoenlichenotiz.Location = new Point(342, 414);
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
            lblPersoenlichenotiz.Location = new Point(342, 365);
            lblPersoenlichenotiz.Name = "lblPersoenlichenotiz";
            lblPersoenlichenotiz.Size = new Size(104, 15);
            lblPersoenlichenotiz.TabIndex = 50;
            lblPersoenlichenotiz.Text = "Persönliche Notiz";
            // 
            // LblAktuelleslehrjahrL
            // 
            LblAktuelleslehrjahrL.AutoSize = true;
            LblAktuelleslehrjahrL.Location = new Point(14, 79);
            LblAktuelleslehrjahrL.Name = "LblAktuelleslehrjahrL";
            LblAktuelleslehrjahrL.Size = new Size(101, 15);
            LblAktuelleslehrjahrL.TabIndex = 54;
            LblAktuelleslehrjahrL.Text = "Aktuelles Lehrjahr";
            LblAktuelleslehrjahrL.Click += label27_Click;
            // 
            // CmdAktuellesLehrjahrL
            // 
            CmdAktuellesLehrjahrL.Items.AddRange(new object[] { "1. Lehrjahr", "2. Lehrjahr", "3. Lehrjahr", "4. Lehrjahr" });
            CmdAktuellesLehrjahrL.Location = new Point(141, 76);
            CmdAktuellesLehrjahrL.Name = "CmdAktuellesLehrjahrL";
            CmdAktuellesLehrjahrL.Size = new Size(121, 23);
            CmdAktuellesLehrjahrL.TabIndex = 93;
            CmdAktuellesLehrjahrL.SelectedIndexChanged += CmdAktuellesLehrjahrL_SelectedIndexChanged;
            // 
            // lblTyp
            // 
            lblTyp.AutoSize = true;
            lblTyp.Location = new Point(57, 60);
            lblTyp.Name = "lblTyp";
            lblTyp.Size = new Size(26, 15);
            lblTyp.TabIndex = 56;
            lblTyp.Text = "Typ";
            // 
            // cmbTyp
            // 
            cmbTyp.FormattingEnabled = true;
            cmbTyp.Items.AddRange(new object[] { "Mitarbeiter", "Lernender", "", "", "", "", "Extern" });
            cmbTyp.Location = new Point(184, 52);
            cmbTyp.Name = "cmbTyp";
            cmbTyp.Size = new Size(121, 23);
            cmbTyp.TabIndex = 57;
            cmbTyp.SelectedIndexChanged += comboBox9_SelectedIndexChanged;
            // 
            // lblAbteilung
            // 
            lblAbteilung.AutoSize = true;
            lblAbteilung.Location = new Point(57, 113);
            lblAbteilung.Name = "lblAbteilung";
            lblAbteilung.Size = new Size(59, 15);
            lblAbteilung.TabIndex = 58;
            lblAbteilung.Text = "Abteilung";
            // 
            // LblAhvnummerL
            // 
            LblAhvnummerL.AutoSize = true;
            LblAhvnummerL.Location = new Point(25, 221);
            LblAhvnummerL.Name = "LblAhvnummerL";
            LblAhvnummerL.Size = new Size(84, 15);
            LblAhvnummerL.TabIndex = 59;
            LblAhvnummerL.Text = "AHV-Nummer";
            LblAhvnummerL.Click += LblAhvnummerL_Click;
            // 
            // lblBeschaeftigungsgrad
            // 
            lblBeschaeftigungsgrad.AutoSize = true;
            lblBeschaeftigungsgrad.Location = new Point(57, 142);
            lblBeschaeftigungsgrad.Name = "lblBeschaeftigungsgrad";
            lblBeschaeftigungsgrad.Size = new Size(112, 15);
            lblBeschaeftigungsgrad.TabIndex = 60;
            lblBeschaeftigungsgrad.Text = "Beschäftigungsgrad";
            // 
            // cmbBeschaeftigungsgrad
            // 
            cmbBeschaeftigungsgrad.FormattingEnabled = true;
            cmbBeschaeftigungsgrad.Items.AddRange(new object[] { "100 %", "80 %", "60 %", "40 %", "20%" });
            cmbBeschaeftigungsgrad.Location = new Point(184, 139);
            cmbBeschaeftigungsgrad.Name = "cmbBeschaeftigungsgrad";
            cmbBeschaeftigungsgrad.Size = new Size(121, 23);
            cmbBeschaeftigungsgrad.TabIndex = 61;
            // 
            // cmbKaderstufe
            // 
            cmbKaderstufe.FormattingEnabled = true;
            cmbKaderstufe.Items.AddRange(new object[] { "0 = keine Kaderfunktion", "1 = Teamleiter", "2 = Abteilungsleiter", "3 = Bereichsleiter", "4 = Geschäftsleitung ", "5 = Direktion" });
            cmbKaderstufe.Location = new Point(184, 169);
            cmbKaderstufe.Name = "cmbKaderstufe";
            cmbKaderstufe.Size = new Size(121, 23);
            cmbKaderstufe.TabIndex = 62;
            // 
            // TxtAhvnummerL
            // 
            TxtAhvnummerL.Location = new Point(146, 218);
            TxtAhvnummerL.Name = "TxtAhvnummerL";
            TxtAhvnummerL.Size = new Size(121, 23);
            TxtAhvnummerL.TabIndex = 63;
            TxtAhvnummerL.TextChanged += TxtAhvnummerL_TextChanged;
            // 
            // txtGeschaeftsadresse
            // 
            txtGeschaeftsadresse.Location = new Point(144, 357);
            txtGeschaeftsadresse.Name = "txtGeschaeftsadresse";
            txtGeschaeftsadresse.Size = new Size(121, 23);
            txtGeschaeftsadresse.TabIndex = 64;
            // 
            // txtFirmenname
            // 
            txtFirmenname.Location = new Point(144, 299);
            txtFirmenname.Name = "txtFirmenname";
            txtFirmenname.Size = new Size(121, 23);
            txtFirmenname.TabIndex = 65;
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "Aktiv", "Passiv" });
            cmbStatus.Location = new Point(198, 265);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 66;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(89, 268);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(39, 15);
            lblStatus.TabIndex = 67;
            lblStatus.Text = "Status";
            // 
            // CmbNationalitätL
            // 
            CmbNationalitätL.AutoCompleteCustomSource.AddRange(new string[] { "Schweiz", "", "", "Deutschland", "", "", "Liechtenstein", "", "", "Österreich", "", "", "Frankreich", "", "", "Italien", "", "", "Spanien", "", "", "Portugal", "", "", "Belgien", "", "", "Niederlande", "", "", "Luxemburg", "", "", "Dänemark", "", "", "Norwegen", "", "", "Schweden", "", "", "Finnland", "", "", "Island", "", "", "Polen", "", "", "Tschechien", "", "", "Slowakei", "", "", "Ungarn", "", "", "Slowenien", "", "", "Kroatien", "", "", "Griechenland", "", "", "Bulgarien", "", "", "Rumänien", "", "", "Estland", "", "", "Lettland", "", "", "Litauen", "", "", "Irland", "", "", "Vereinigtes Königreich", "", "", "USA", "", "", "Kanada", "", "", "Mexiko", "", "", "Brasilien", "", "", "Argentinien", "", "", "Australien", "", "", "Neuseeland", "", "", "China", "", "", "Japan", "", "", "Südkorea", "", "", "Indien", "", "", "Südafrika", "", "", "Ägypten", "", "", "Marokko", "", "", "Türkei" });
            CmbNationalitätL.FormattingEnabled = true;
            CmbNationalitätL.Items.AddRange(new object[] { "Dr.", "Prof." });
            CmbNationalitätL.Location = new Point(146, 247);
            CmbNationalitätL.Name = "CmbNationalitätL";
            CmbNationalitätL.Size = new Size(121, 23);
            CmbNationalitätL.TabIndex = 68;
            CmbNationalitätL.SelectedIndexChanged += CmbNationalitätL_SelectedIndexChanged;
            // 
            // LblGeschlechtL
            // 
            LblGeschlechtL.AutoSize = true;
            LblGeschlechtL.Location = new Point(25, 162);
            LblGeschlechtL.Name = "LblGeschlechtL";
            LblGeschlechtL.Size = new Size(65, 15);
            LblGeschlechtL.TabIndex = 69;
            LblGeschlechtL.Text = "Geschlecht";
            LblGeschlechtL.Click += LblGeshlecht;
            // 
            // CmbGeschlechtL
            // 
            CmbGeschlechtL.FormattingEnabled = true;
            CmbGeschlechtL.Items.AddRange(new object[] { "Männlich", "Weiblich", "Divers ", "Keine Angabe" });
            CmbGeschlechtL.Location = new Point(146, 159);
            CmbGeschlechtL.Name = "CmbGeschlechtL";
            CmbGeschlechtL.Size = new Size(121, 23);
            CmbGeschlechtL.TabIndex = 70;
            CmbGeschlechtL.SelectedIndexChanged += CmbGeschlechtL_SelectedIndexChanged;
            // 
            // lblFirmaKunde
            // 
            lblFirmaKunde.AutoSize = true;
            lblFirmaKunde.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblFirmaKunde.Location = new Point(43, 276);
            lblFirmaKunde.Name = "lblFirmaKunde";
            lblFirmaKunde.Size = new Size(85, 15);
            lblFirmaKunde.TabIndex = 71;
            lblFirmaKunde.Text = "Firma / Kunde";
            lblFirmaKunde.Click += label33_Click;
            // 
            // DtpGeburtsdatumL
            // 
            DtpGeburtsdatumL.Location = new Point(146, 127);
            DtpGeburtsdatumL.Name = "DtpGeburtsdatumL";
            DtpGeburtsdatumL.Size = new Size(119, 23);
            DtpGeburtsdatumL.TabIndex = 25;
            DtpGeburtsdatumL.ValueChanged += DtpGeburtsdatumL_ValueChanged;
            // 
            // PERSON
            // 
            PERSON.Controls.Add(tabKunde);
            PERSON.Controls.Add(tabMitarbeiter);
            PERSON.Controls.Add(tabLehrling);
            PERSON.Location = new Point(12, 12);
            PERSON.Name = "PERSON";
            PERSON.SelectedIndex = 0;
            PERSON.Size = new Size(638, 449);
            PERSON.TabIndex = 76;
            // 
            // tabKunde
            // 
            tabKunde.Controls.Add(dateTimePicker2);
            tabKunde.Controls.Add(label1);
            tabKunde.Controls.Add(lblPersoenlichenotiz);
            tabKunde.Controls.Add(txtPersoenlichenotiz);
            tabKunde.Controls.Add(lblFirmaKunde);
            tabKunde.Controls.Add(textBox1);
            tabKunde.Controls.Add(comboBox1);
            tabKunde.Controls.Add(txtFirmenname);
            tabKunde.Controls.Add(label2);
            tabKunde.Controls.Add(txtGeschaeftsadresse);
            tabKunde.Controls.Add(label3);
            tabKunde.Controls.Add(textBox2);
            tabKunde.Controls.Add(label4);
            tabKunde.Controls.Add(btnSpeichern);
            tabKunde.Controls.Add(lblFirmenname);
            tabKunde.Controls.Add(txtFirmenkontakt);
            tabKunde.Controls.Add(lblGeschaeftsadresse);
            tabKunde.Controls.Add(lblFirmenkontakt);
            tabKunde.Location = new Point(4, 24);
            tabKunde.Name = "tabKunde";
            tabKunde.Padding = new Padding(3);
            tabKunde.Size = new Size(630, 421);
            tabKunde.TabIndex = 0;
            tabKunde.Text = "Kunde";
            tabKunde.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(235, 164);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(119, 23);
            dateTimePicker2.TabIndex = 76;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 42);
            label1.Name = "label1";
            label1.Size = new Size(60, 17);
            label1.TabIndex = 71;
            label1.Text = "Vorname";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(76, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 75;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Männlich", "Weiblich", "Divers ", "Keine Angabe" });
            comboBox1.Location = new Point(233, 193);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 78;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 63);
            label2.Name = "label2";
            label2.Size = new Size(70, 17);
            label2.TabIndex = 72;
            label2.Text = "Nachname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 196);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 77;
            label3.Text = "Geschlecht";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(233, 135);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(121, 23);
            textBox2.TabIndex = 74;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 161);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 73;
            label4.Text = "Geburtsdatum";
            // 
            // tabMitarbeiter
            // 
            tabMitarbeiter.Controls.Add(lblBeschaeftigungsgrad);
            tabMitarbeiter.Controls.Add(lblRolle);
            tabMitarbeiter.Controls.Add(lblStatus);
            tabMitarbeiter.Controls.Add(lblKaderstufe);
            tabMitarbeiter.Controls.Add(cmbStatus);
            tabMitarbeiter.Controls.Add(cmbAbteilung);
            tabMitarbeiter.Controls.Add(cmbRolle);
            tabMitarbeiter.Controls.Add(dtpEintritt);
            tabMitarbeiter.Controls.Add(lblTyp);
            tabMitarbeiter.Controls.Add(dtpAustritt);
            tabMitarbeiter.Controls.Add(cmbTyp);
            tabMitarbeiter.Controls.Add(lblAustritt);
            tabMitarbeiter.Controls.Add(cmbKaderstufe);
            tabMitarbeiter.Controls.Add(lblEintritt);
            tabMitarbeiter.Controls.Add(lblAbteilung);
            tabMitarbeiter.Controls.Add(cmbBeschaeftigungsgrad);
            tabMitarbeiter.Location = new Point(4, 24);
            tabMitarbeiter.Name = "tabMitarbeiter";
            tabMitarbeiter.Padding = new Padding(3);
            tabMitarbeiter.Size = new Size(630, 421);
            tabMitarbeiter.TabIndex = 1;
            tabMitarbeiter.Text = "Mitarbeiter";
            tabMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // tabLehrling
            // 
            tabLehrling.Controls.Add(CmbStatusL);
            tabLehrling.Controls.Add(LblStatusL);
            tabLehrling.Controls.Add(GrpBeschaeftigungsdatenL);
            tabLehrling.Controls.Add(GrpKontaktinformationenL);
            tabLehrling.Controls.Add(GrpPersoenlichL);
            tabLehrling.Controls.Add(BtnSpeichernL);
            tabLehrling.Location = new Point(4, 24);
            tabLehrling.Name = "tabLehrling";
            tabLehrling.Padding = new Padding(3);
            tabLehrling.Size = new Size(630, 421);
            tabLehrling.TabIndex = 2;
            tabLehrling.Text = "Lehrling";
            tabLehrling.UseVisualStyleBackColor = true;
            tabLehrling.Click += tabLehrling_Click;
            // 
            // CmbStatusL
            // 
            CmbStatusL.FormattingEnabled = true;
            CmbStatusL.Items.AddRange(new object[] { "Aktiv", "Inaktiv" });
            CmbStatusL.Location = new Point(413, 375);
            CmbStatusL.Name = "CmbStatusL";
            CmbStatusL.Size = new Size(102, 23);
            CmbStatusL.TabIndex = 91;
            CmbStatusL.SelectedIndexChanged += CmbStatusL_SelectedIndexChanged;
            // 
            // GrpBeschaeftigungsdatenL
            // 
            GrpBeschaeftigungsdatenL.Controls.Add(LblLehrjahreL);
            GrpBeschaeftigungsdatenL.Controls.Add(CmbLehrjahreL);
            GrpBeschaeftigungsdatenL.Controls.Add(LblAktuelleslehrjahrL);
            GrpBeschaeftigungsdatenL.Controls.Add(CmdAktuellesLehrjahrL);
            GrpBeschaeftigungsdatenL.Location = new Point(332, 232);
            GrpBeschaeftigungsdatenL.Name = "GrpBeschaeftigungsdatenL";
            GrpBeschaeftigungsdatenL.Size = new Size(280, 115);
            GrpBeschaeftigungsdatenL.TabIndex = 90;
            GrpBeschaeftigungsdatenL.TabStop = false;
            GrpBeschaeftigungsdatenL.Text = "Beschäftigungsdaten";
            GrpBeschaeftigungsdatenL.Enter += GrpBeschaeftigungsdatenL_Enter;
            // 
            // LblLehrjahreL
            // 
            LblLehrjahreL.AutoSize = true;
            LblLehrjahreL.Location = new Point(14, 40);
            LblLehrjahreL.Name = "LblLehrjahreL";
            LblLehrjahreL.Size = new Size(56, 15);
            LblLehrjahreL.TabIndex = 92;
            LblLehrjahreL.Text = "Lehrjahre";
            LblLehrjahreL.Click += LblLehrjahreL_Click;
            // 
            // GrpKontaktinformationenL
            // 
            GrpKontaktinformationenL.Controls.Add(LblTelefonprivatL);
            GrpKontaktinformationenL.Controls.Add(TxtMobiltelefonnummerL);
            GrpKontaktinformationenL.Controls.Add(TxtGeschaeftL);
            GrpKontaktinformationenL.Controls.Add(LblEmailadresseL);
            GrpKontaktinformationenL.Controls.Add(TxtTelefonprivatL);
            GrpKontaktinformationenL.Controls.Add(LblMobiltelefonnummerL);
            GrpKontaktinformationenL.Controls.Add(TxtEmailL);
            GrpKontaktinformationenL.Controls.Add(lblTelefongeschaeftL);
            GrpKontaktinformationenL.Location = new Point(332, 34);
            GrpKontaktinformationenL.Name = "GrpKontaktinformationenL";
            GrpKontaktinformationenL.Size = new Size(280, 163);
            GrpKontaktinformationenL.TabIndex = 89;
            GrpKontaktinformationenL.TabStop = false;
            GrpKontaktinformationenL.Text = "Kontaktinformationen";
            GrpKontaktinformationenL.Enter += GrpKontaktinformationenL_Enter;
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
            GrpPersoenlichL.Controls.Add(LblTitelL);
            GrpPersoenlichL.Controls.Add(LblNachnameL);
            GrpPersoenlichL.Controls.Add(TxtNachnameL);
            GrpPersoenlichL.Controls.Add(TxtTitelL);
            GrpPersoenlichL.Controls.Add(LblGeburtsdatumL);
            GrpPersoenlichL.Controls.Add(TxtNationalitätL);
            GrpPersoenlichL.Controls.Add(LblAdresseL);
            GrpPersoenlichL.Controls.Add(TxtAdresseL);
            GrpPersoenlichL.Controls.Add(LblWohnortL);
            GrpPersoenlichL.Controls.Add(TxtWohnortL);
            GrpPersoenlichL.Controls.Add(LblPostleitzahlL);
            GrpPersoenlichL.Controls.Add(TxtPostleitzahlL);
            GrpPersoenlichL.Location = new Point(18, 27);
            GrpPersoenlichL.Name = "GrpPersoenlichL";
            GrpPersoenlichL.Size = new Size(290, 376);
            GrpPersoenlichL.TabIndex = 88;
            GrpPersoenlichL.TabStop = false;
            GrpPersoenlichL.Text = "Persönliche Angaben";
            GrpPersoenlichL.Enter += GrpPersoenlichL_Enter;
            // 
            // LblVornameL
            // 
            LblVornameL.AutoSize = true;
            LblVornameL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblVornameL.Location = new Point(25, 67);
            LblVornameL.Name = "LblVornameL";
            LblVornameL.Size = new Size(60, 17);
            LblVornameL.TabIndex = 80;
            LblVornameL.Text = "Vorname";
            LblVornameL.Click += LblVornameL_Click;
            // 
            // LblNachnameL
            // 
            LblNachnameL.AutoSize = true;
            LblNachnameL.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LblNachnameL.Location = new Point(25, 97);
            LblNachnameL.Name = "LblNachnameL";
            LblNachnameL.Size = new Size(70, 17);
            LblNachnameL.TabIndex = 81;
            LblNachnameL.Text = "Nachname";
            LblNachnameL.Click += LblNachnameL_Click;
            // 
            // TxtTitelL
            // 
            TxtTitelL.Location = new Point(146, 188);
            TxtTitelL.Name = "TxtTitelL";
            TxtTitelL.Size = new Size(121, 23);
            TxtTitelL.TabIndex = 84;
            TxtTitelL.TextChanged += TxtTitelL_TextChanged;
            // 
            // BtnSpeichernL
            // 
            BtnSpeichernL.Location = new Point(535, 373);
            BtnSpeichernL.Name = "BtnSpeichernL";
            BtnSpeichernL.Size = new Size(77, 30);
            BtnSpeichernL.TabIndex = 79;
            BtnSpeichernL.Text = "Speichern";
            BtnSpeichernL.UseVisualStyleBackColor = true;
            BtnSpeichernL.Click += btnSpeichernL_Click;
            // 
            // Details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 467);
            Controls.Add(PERSON);
            Name = "Details";
            Text = "Details";
            PERSON.ResumeLayout(false);
            tabKunde.ResumeLayout(false);
            tabKunde.PerformLayout();
            tabMitarbeiter.ResumeLayout(false);
            tabMitarbeiter.PerformLayout();
            tabLehrling.ResumeLayout(false);
            tabLehrling.PerformLayout();
            GrpBeschaeftigungsdatenL.ResumeLayout(false);
            GrpBeschaeftigungsdatenL.PerformLayout();
            GrpKontaktinformationenL.ResumeLayout(false);
            GrpKontaktinformationenL.PerformLayout();
            GrpPersoenlichL.ResumeLayout(false);
            GrpPersoenlichL.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label LblAnredeL;
        private Label LblTitelL;
        private Label LblGeburtsdatumL;
        private Label TxtNationalitätL;
        private Label LblAdresseL;
        private Label LblPostleitzahlL;
        private Label LblWohnortL;
        private Label lblTelefongeschaeftL;
        private Label LblTelefonprivatL;
        private Label LblMobiltelefonnummerL;
        private Label LblEmailadresseL;
        private ComboBox CmbAnredeL;
        private TextBox TxtNachnameL;
        private TextBox TxtWohnortL;
 
        private TextBox TxtAdresseL;
        private TextBox TxtPostleitzahlL;
        private TextBox TxtVornameL;
        private TextBox TxtMobiltelefonnummerL;
        private TextBox TxtGeschaeftL;
        private TextBox TxtTelefonprivatL;
        private TextBox TxtEmailL;
        private Label lblFirmenname;
        private Label lblGeschaeftsadresse;
        private Label lblEintritt;
        private Label lblAustritt;
        private Label lblFirmenkontakt;
        private Label lblRolle;
        private Label lblKaderstufe;
        private Label LblStatusL;
        private Button btnSpeichern;
        private TextBox txtFirmenkontakt;
        private DateTimePicker dtpAustritt;
        private DateTimePicker dtpEintritt;
        private ComboBox cmbAbteilung;
        private ComboBox CmbLehrjahreL;
        private ComboBox cmbRolle;
        private RichTextBox txtPersoenlichenotiz;
        private Label lblPersoenlichenotiz;
        private Label LblAktuelleslehrjahrL;
        private ComboBox CmdAktuellesLehrjahrL;
        private Label lblTyp;
        private ComboBox cmbTyp;
        private Label lblAbteilung;
        private Label LblAhvnummerL;
        private Label lblBeschaeftigungsgrad;
        private ComboBox cmbBeschaeftigungsgrad;
        private ComboBox cmbKaderstufe;
        private TextBox TxtAhvnummerL;
        private TextBox txtGeschaeftsadresse;
        private TextBox txtFirmenname;
        private ComboBox cmbStatus;
        private Label lblStatus;
        private ComboBox CmbNationalitätL;
        private Label LblGeschlechtL;
        private ComboBox CmbGeschlechtL;
        private Label lblFirmaKunde;
        private DateTimePicker DtpGeburtsdatumL;
        private TabControl PERSON;
        private TabPage tabKunde;
        private TabPage tabMitarbeiter;
        private TabPage tabLehrling;
        private DateTimePicker dateTimePicker2;
        private Label label1;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private Label LblVornameL;
        private TextBox TxtTitelL;
        private Label LblNachnameL;
        private Button BtnSpeichernL;
        private GroupBox GrpKontaktinformationenL;
        private GroupBox GrpPersoenlichL;
        private Label LblLehrjahreL;
        private ComboBox CmbStatusL;
        private GroupBox GrpBeschaeftigungsdatenL;
    }
}
