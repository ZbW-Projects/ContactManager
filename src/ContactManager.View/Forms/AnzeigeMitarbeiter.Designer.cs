namespace ContactManager.View.Forms
{
    partial class AnzeigeMitarbeiter
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
            groupBox1 = new GroupBox();
            CbStatusM = new CheckBox();
            label3 = new Label();
            label8 = new Label();
            CmbBeschaeftigungsgradM = new ComboBox();
            label9 = new Label();
            DtpEintrittM = new DateTimePicker();
            CmbRolleM = new ComboBox();
            DtpAustrittM = new DateTimePicker();
            label10 = new Label();
            label11 = new Label();
            CmbAbteilungM = new ComboBox();
            label12 = new Label();
            label13 = new Label();
            CmbKaderstufenM = new ComboBox();
            BtnErstelleMitarbeiter = new Button();
            groupBox2 = new GroupBox();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            TxtEmailM = new TextBox();
            label18 = new Label();
            TxtGeschaeftM = new TextBox();
            TxtPostleitzahlM = new TextBox();
            TxtMobiltelefonnummerM = new TextBox();
            TxtHausnummerM = new TextBox();
            label19 = new Label();
            label20 = new Label();
            TxtWohnortM = new TextBox();
            TxtTelefonprivatM = new TextBox();
            label21 = new Label();
            TxtStrasseM = new TextBox();
            label22 = new Label();
            groupBox3 = new GroupBox();
            label30 = new Label();
            CmbTitelM = new ComboBox();
            label23 = new Label();
            DtpGeburtsdatumM = new DateTimePicker();
            CmbAnredeM = new ComboBox();
            CmbNationalitätM = new ComboBox();
            CmbGeschlechtM = new ComboBox();
            TxtAhvnummerM = new TextBox();
            label24 = new Label();
            label25 = new Label();
            label26 = new Label();
            TxtVornameM = new TextBox();
            label27 = new Label();
            TxtNachnameM = new TextBox();
            label28 = new Label();
            label29 = new Label();
            button1 = new Button();
            Löschen = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(CbStatusM);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(CmbBeschaeftigungsgradM);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(DtpEintrittM);
            groupBox1.Controls.Add(CmbRolleM);
            groupBox1.Controls.Add(DtpAustrittM);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(CmbAbteilungM);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(CmbKaderstufenM);
            groupBox1.Location = new Point(49, 377);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(708, 166);
            groupBox1.TabIndex = 98;
            groupBox1.TabStop = false;
            groupBox1.Text = "Beschäftigungsdaten";
            // 
            // CbStatusM
            // 
            CbStatusM.AutoSize = true;
            CbStatusM.Location = new Point(453, 125);
            CbStatusM.Name = "CbStatusM";
            CbStatusM.Size = new Size(53, 19);
            CbStatusM.TabIndex = 22;
            CbStatusM.Text = "Aktiv";
            CbStatusM.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 132);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 93;
            label3.Text = "Beschäftigungsgrad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(383, 125);
            label8.Name = "label8";
            label8.Size = new Size(45, 15);
            label8.TabIndex = 38;
            label8.Text = "Status :";
            // 
            // CmbBeschaeftigungsgradM
            // 
            CmbBeschaeftigungsgradM.FormattingEnabled = true;
            CmbBeschaeftigungsgradM.Items.AddRange(new object[] { "100", "80", "60", "40", "20" });
            CmbBeschaeftigungsgradM.Location = new Point(141, 126);
            CmbBeschaeftigungsgradM.Name = "CmbBeschaeftigungsgradM";
            CmbBeschaeftigungsgradM.Size = new Size(121, 23);
            CmbBeschaeftigungsgradM.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 97);
            label9.Name = "label9";
            label9.Size = new Size(33, 15);
            label9.TabIndex = 100;
            label9.Text = "Rolle";
            // 
            // DtpEintrittM
            // 
            DtpEintrittM.Location = new Point(454, 22);
            DtpEintrittM.Name = "DtpEintrittM";
            DtpEintrittM.Size = new Size(249, 23);
            DtpEintrittM.TabIndex = 20;
            // 
            // CmbRolleM
            // 
            CmbRolleM.FormattingEnabled = true;
            CmbRolleM.Items.AddRange(new object[] { "System Engineer", "Entwickler", "Projektleiter", "Kaufmännische/r Angestellte/r", "Support" });
            CmbRolleM.Location = new Point(141, 92);
            CmbRolleM.Name = "CmbRolleM";
            CmbRolleM.Size = new Size(121, 23);
            CmbRolleM.TabIndex = 18;
            // 
            // DtpAustrittM
            // 
            DtpAustrittM.Location = new Point(454, 55);
            DtpAustrittM.Name = "DtpAustrittM";
            DtpAustrittM.Size = new Size(249, 23);
            DtpAustrittM.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(382, 60);
            label10.Name = "label10";
            label10.Size = new Size(46, 15);
            label10.TabIndex = 97;
            label10.Text = "Austritt";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(383, 26);
            label11.Name = "label11";
            label11.Size = new Size(42, 15);
            label11.TabIndex = 96;
            label11.Text = "Eintritt";
            // 
            // CmbAbteilungM
            // 
            CmbAbteilungM.FormattingEnabled = true;
            CmbAbteilungM.Items.AddRange(new object[] { "IT", "Finanzen", "HR", "Verkauf", "Produktion", "Verwaltung" });
            CmbAbteilungM.Location = new Point(141, 56);
            CmbAbteilungM.Name = "CmbAbteilungM";
            CmbAbteilungM.Size = new Size(121, 23);
            CmbAbteilungM.TabIndex = 17;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 62);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 95;
            label12.Text = "Abteilung";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(16, 26);
            label13.Name = "label13";
            label13.Size = new Size(70, 15);
            label13.TabIndex = 92;
            label13.Text = "Kaderstufen";
            // 
            // CmbKaderstufenM
            // 
            CmbKaderstufenM.FormattingEnabled = true;
            CmbKaderstufenM.Items.AddRange(new object[] { "1", "2", "3", "4" });
            CmbKaderstufenM.Location = new Point(141, 20);
            CmbKaderstufenM.Name = "CmbKaderstufenM";
            CmbKaderstufenM.Size = new Size(121, 23);
            CmbKaderstufenM.TabIndex = 16;
            // 
            // BtnErstelleMitarbeiter
            // 
            BtnErstelleMitarbeiter.Location = new Point(679, 548);
            BtnErstelleMitarbeiter.Name = "BtnErstelleMitarbeiter";
            BtnErstelleMitarbeiter.Size = new Size(77, 30);
            BtnErstelleMitarbeiter.TabIndex = 95;
            BtnErstelleMitarbeiter.Text = "Speichern";
            BtnErstelleMitarbeiter.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(label16);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(TxtEmailM);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(TxtGeschaeftM);
            groupBox2.Controls.Add(TxtPostleitzahlM);
            groupBox2.Controls.Add(TxtMobiltelefonnummerM);
            groupBox2.Controls.Add(TxtHausnummerM);
            groupBox2.Controls.Add(label19);
            groupBox2.Controls.Add(label20);
            groupBox2.Controls.Add(TxtWohnortM);
            groupBox2.Controls.Add(TxtTelefonprivatM);
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(TxtStrasseM);
            groupBox2.Controls.Add(label22);
            groupBox2.Location = new Point(446, 43);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(310, 320);
            groupBox2.TabIndex = 97;
            groupBox2.TabStop = false;
            groupBox2.Text = "Adresse + Kontakt";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(6, 88);
            label15.Name = "label15";
            label15.Size = new Size(27, 15);
            label15.TabIndex = 29;
            label15.Text = "PLZ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 267);
            label16.Name = "label16";
            label16.Size = new Size(80, 15);
            label16.TabIndex = 13;
            label16.Text = "Telefon Mobil";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(8, 242);
            label17.Name = "label17";
            label17.Size = new Size(79, 15);
            label17.TabIndex = 9;
            label17.Text = "Telefon Privat";
            // 
            // TxtEmailM
            // 
            TxtEmailM.Location = new Point(141, 201);
            TxtEmailM.Name = "TxtEmailM";
            TxtEmailM.Size = new Size(121, 23);
            TxtEmailM.TabIndex = 12;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(8, 206);
            label18.Name = "label18";
            label18.Size = new Size(36, 15);
            label18.TabIndex = 14;
            label18.Text = "Email";
            // 
            // TxtGeschaeftM
            // 
            TxtGeschaeftM.Location = new Point(141, 290);
            TxtGeschaeftM.Name = "TxtGeschaeftM";
            TxtGeschaeftM.Size = new Size(165, 23);
            TxtGeschaeftM.TabIndex = 15;
            // 
            // TxtPostleitzahlM
            // 
            TxtPostleitzahlM.Location = new Point(141, 83);
            TxtPostleitzahlM.Name = "TxtPostleitzahlM";
            TxtPostleitzahlM.Size = new Size(121, 23);
            TxtPostleitzahlM.TabIndex = 10;
            // 
            // TxtMobiltelefonnummerM
            // 
            TxtMobiltelefonnummerM.Location = new Point(141, 262);
            TxtMobiltelefonnummerM.Name = "TxtMobiltelefonnummerM";
            TxtMobiltelefonnummerM.Size = new Size(165, 23);
            TxtMobiltelefonnummerM.TabIndex = 14;
            // 
            // TxtHausnummerM
            // 
            TxtHausnummerM.Location = new Point(141, 53);
            TxtHausnummerM.Name = "TxtHausnummerM";
            TxtHausnummerM.Size = new Size(165, 23);
            TxtHausnummerM.TabIndex = 9;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(7, 295);
            label19.Name = "label19";
            label19.Size = new Size(95, 15);
            label19.TabIndex = 12;
            label19.Text = "Telefon Geschäft";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(7, 58);
            label20.Name = "label20";
            label20.Size = new Size(80, 15);
            label20.TabIndex = 83;
            label20.Text = "Hausnummer";
            // 
            // TxtWohnortM
            // 
            TxtWohnortM.Location = new Point(141, 115);
            TxtWohnortM.Name = "TxtWohnortM";
            TxtWohnortM.Size = new Size(165, 23);
            TxtWohnortM.TabIndex = 11;
            // 
            // TxtTelefonprivatM
            // 
            TxtTelefonprivatM.Location = new Point(141, 238);
            TxtTelefonprivatM.Name = "TxtTelefonprivatM";
            TxtTelefonprivatM.Size = new Size(165, 23);
            TxtTelefonprivatM.TabIndex = 13;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(6, 120);
            label21.Name = "label21";
            label21.Size = new Size(54, 15);
            label21.TabIndex = 10;
            label21.Text = "Wohnort";
            // 
            // TxtStrasseM
            // 
            TxtStrasseM.Location = new Point(141, 27);
            TxtStrasseM.Name = "TxtStrasseM";
            TxtStrasseM.Size = new Size(165, 23);
            TxtStrasseM.TabIndex = 8;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(6, 32);
            label22.Name = "label22";
            label22.Size = new Size(43, 15);
            label22.TabIndex = 8;
            label22.Text = "Strasse";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label30);
            groupBox3.Controls.Add(CmbTitelM);
            groupBox3.Controls.Add(label23);
            groupBox3.Controls.Add(DtpGeburtsdatumM);
            groupBox3.Controls.Add(CmbAnredeM);
            groupBox3.Controls.Add(CmbNationalitätM);
            groupBox3.Controls.Add(CmbGeschlechtM);
            groupBox3.Controls.Add(TxtAhvnummerM);
            groupBox3.Controls.Add(label24);
            groupBox3.Controls.Add(label25);
            groupBox3.Controls.Add(label26);
            groupBox3.Controls.Add(TxtVornameM);
            groupBox3.Controls.Add(label27);
            groupBox3.Controls.Add(TxtNachnameM);
            groupBox3.Controls.Add(label28);
            groupBox3.Controls.Add(label29);
            groupBox3.Location = new Point(49, 43);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(372, 320);
            groupBox3.TabIndex = 96;
            groupBox3.TabStop = false;
            groupBox3.Text = "Persönliche Angaben";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.Location = new Point(8, 59);
            label30.Name = "label30";
            label30.Size = new Size(32, 17);
            label30.TabIndex = 83;
            label30.Text = "Titel";
            // 
            // CmbTitelM
            // 
            CmbTitelM.FormattingEnabled = true;
            CmbTitelM.Items.AddRange(new object[] { "Dr.", "Prof.", "(Keine Angabe)" });
            CmbTitelM.Location = new Point(141, 56);
            CmbTitelM.Name = "CmbTitelM";
            CmbTitelM.Size = new Size(165, 23);
            CmbTitelM.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.Location = new Point(8, 30);
            label23.Name = "label23";
            label23.Size = new Size(50, 17);
            label23.TabIndex = 1;
            label23.Text = "Anrede";
            // 
            // DtpGeburtsdatumM
            // 
            DtpGeburtsdatumM.Location = new Point(141, 139);
            DtpGeburtsdatumM.Name = "DtpGeburtsdatumM";
            DtpGeburtsdatumM.Size = new Size(227, 23);
            DtpGeburtsdatumM.TabIndex = 5;
            // 
            // CmbAnredeM
            // 
            CmbAnredeM.FormattingEnabled = true;
            CmbAnredeM.Items.AddRange(new object[] { "Divers", "Frau ", "Herr", "(Keine Angabe)" });
            CmbAnredeM.Location = new Point(141, 27);
            CmbAnredeM.Name = "CmbAnredeM";
            CmbAnredeM.Size = new Size(165, 23);
            CmbAnredeM.TabIndex = 1;
            // 
            // CmbNationalitätM
            // 
            CmbNationalitätM.AutoCompleteCustomSource.AddRange(new string[] { "Schweiz", "", "", "Deutschland", "", "", "Liechtenstein", "", "", "Österreich", "", "", "Frankreich", "", "", "Italien", "", "", "Spanien", "", "", "Portugal", "", "", "Belgien", "", "", "Niederlande", "", "", "Luxemburg", "", "", "Dänemark", "", "", "Norwegen", "", "", "Schweden", "", "", "Finnland", "", "", "Island", "", "", "Polen", "", "", "Tschechien", "", "", "Slowakei", "", "", "Ungarn", "", "", "Slowenien", "", "", "Kroatien", "", "", "Griechenland", "", "", "Bulgarien", "", "", "Rumänien", "", "", "Estland", "", "", "Lettland", "", "", "Litauen", "", "", "Irland", "", "", "Vereinigtes Königreich", "", "", "USA", "", "", "Kanada", "", "", "Mexiko", "", "", "Brasilien", "", "", "Argentinien", "", "", "Australien", "", "", "Neuseeland", "", "", "China", "", "", "Japan", "", "", "Südkorea", "", "", "Indien", "", "", "Südafrika", "", "", "Ägypten", "", "", "Marokko", "", "", "Türkei" });
            CmbNationalitätM.FormattingEnabled = true;
            CmbNationalitätM.Items.AddRange(new object[] { "Schweiz", "Deutschland", "Liechtenstein", "Österreich", "Frankreich", "Italien", "Spanien", "Portugal", "Belgien", "Niederlande", "Luxemburg", "Dänemark", "Norwegen", "Schweden", "Finnland", "Island", "Polen", "Tschechien", "Slowakei", "Ungarn", "Slowenien", "Kroatien", "Griechenland", "Bulgarien", "Rumänien", "Estland", "Lettland", "Litauen", "Irland", "Vereinigtes Königreich", "USA", "Kanada", "Mexiko", "Brasilien", "Argentinien", "Australien", "Neuseeland", "China", "Japan", "Südkorea", "Indien", "Südafrika", "Ägypten", "Marokko", "Türkei" });
            CmbNationalitätM.Location = new Point(141, 257);
            CmbNationalitätM.Name = "CmbNationalitätM";
            CmbNationalitätM.Size = new Size(165, 23);
            CmbNationalitätM.TabIndex = 8;
            // 
            // CmbGeschlechtM
            // 
            CmbGeschlechtM.FormattingEnabled = true;
            CmbGeschlechtM.Items.AddRange(new object[] { "Männlich", "Weiblich", "Divers ", "(Keine Angabe)" });
            CmbGeschlechtM.Location = new Point(141, 180);
            CmbGeschlechtM.Name = "CmbGeschlechtM";
            CmbGeschlechtM.Size = new Size(165, 23);
            CmbGeschlechtM.TabIndex = 6;
            // 
            // TxtAhvnummerM
            // 
            TxtAhvnummerM.Location = new Point(141, 220);
            TxtAhvnummerM.Name = "TxtAhvnummerM";
            TxtAhvnummerM.Size = new Size(227, 23);
            TxtAhvnummerM.TabIndex = 7;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(8, 86);
            label24.Name = "label24";
            label24.Size = new Size(60, 17);
            label24.TabIndex = 80;
            label24.Text = "Vorname";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(7, 224);
            label25.Name = "label25";
            label25.Size = new Size(84, 15);
            label25.TabIndex = 59;
            label25.Text = "AHV-Nummer";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(7, 186);
            label26.Name = "label26";
            label26.Size = new Size(65, 15);
            label26.TabIndex = 69;
            label26.Text = "Geschlecht";
            // 
            // TxtVornameM
            // 
            TxtVornameM.Location = new Point(141, 82);
            TxtVornameM.Name = "TxtVornameM";
            TxtVornameM.Size = new Size(165, 23);
            TxtVornameM.TabIndex = 3;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.Location = new Point(8, 109);
            label27.Name = "label27";
            label27.Size = new Size(70, 17);
            label27.TabIndex = 81;
            label27.Text = "Nachname";
            // 
            // TxtNachnameM
            // 
            TxtNachnameM.Location = new Point(141, 107);
            TxtNachnameM.Name = "TxtNachnameM";
            TxtNachnameM.Size = new Size(165, 23);
            TxtNachnameM.TabIndex = 4;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(7, 143);
            label28.Name = "label28";
            label28.Size = new Size(83, 15);
            label28.TabIndex = 6;
            label28.Text = "Geburtsdatum";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(8, 263);
            label29.Name = "label29";
            label29.Size = new Size(69, 15);
            label29.TabIndex = 7;
            label29.Text = "Nationalität";
            // 
            // button1
            // 
            button1.Location = new Point(587, 549);
            button1.Name = "button1";
            button1.Size = new Size(77, 30);
            button1.TabIndex = 99;
            button1.Text = "Bearbeiten";
            button1.UseVisualStyleBackColor = true;
            // 
            // Löschen
            // 
            Löschen.Location = new Point(502, 549);
            Löschen.Name = "Löschen";
            Löschen.Size = new Size(77, 30);
            Löschen.TabIndex = 100;
            Löschen.Text = "Löschen";
            Löschen.UseVisualStyleBackColor = true;
            // 
            // AnzeigeMitarbeiter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 637);
            Controls.Add(Löschen);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(BtnErstelleMitarbeiter);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Name = "AnzeigeMitarbeiter";
            Text = "AnzeigeMitarbeiter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox CbStatusM;
        private Label label3;
        private Label label8;
        private ComboBox CmbBeschaeftigungsgradM;
        private Label label9;
        private DateTimePicker DtpEintrittM;
        private ComboBox CmbRolleM;
        private DateTimePicker DtpAustrittM;
        private Label label10;
        private Label label11;
        private ComboBox CmbAbteilungM;
        private Label label12;
        private Label label13;
        private ComboBox CmbKaderstufenM;
        private Button BtnErstelleMitarbeiter;
        private GroupBox groupBox2;
        private Label label15;
        private Label label16;
        private Label label17;
        private TextBox TxtEmailM;
        private Label label18;
        private TextBox TxtGeschaeftM;
        private TextBox TxtPostleitzahlM;
        private TextBox TxtMobiltelefonnummerM;
        private TextBox TxtHausnummerM;
        private Label label19;
        private Label label20;
        private TextBox TxtWohnortM;
        private TextBox TxtTelefonprivatM;
        private Label label21;
        private TextBox TxtStrasseM;
        private Label label22;
        private GroupBox groupBox3;
        private Label label30;
        private ComboBox CmbTitelM;
        private Label label23;
        private DateTimePicker DtpGeburtsdatumM;
        private ComboBox CmbAnredeM;
        private ComboBox CmbNationalitätM;
        private ComboBox CmbGeschlechtM;
        private TextBox TxtAhvnummerM;
        private Label label24;
        private Label label25;
        private Label label26;
        private TextBox TxtVornameM;
        private Label label27;
        private TextBox TxtNachnameM;
        private Label label28;
        private Label label29;
        private Button button1;
        private Button Löschen;
    }
}