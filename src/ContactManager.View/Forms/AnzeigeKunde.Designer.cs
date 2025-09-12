namespace ContactManager.View.Forms
{
    partial class AnzeigeKunde
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
            groupBox5 = new GroupBox();
            ProtokollListeK = new RichTextBox();
            Administrativ = new GroupBox();
            CmbKundentypK = new ComboBox();
            label34 = new Label();
            CmbStatusK = new CheckBox();
            label43 = new Label();
            Notiz = new GroupBox();
            TxtOwnerK = new TextBox();
            label35 = new Label();
            TxtNotizK = new RichTextBox();
            BtnNotizSpeichernK = new Button();
            GrpFirmaK = new GroupBox();
            TxtWohnortK = new TextBox();
            TxtHausnummerK = new TextBox();
            label4 = new Label();
            lblFirmenkontakt = new Label();
            label33 = new Label();
            TxtGeschaeftK = new TextBox();
            label36 = new Label();
            lblFirmenname = new Label();
            TxtFirmennameK = new TextBox();
            TxtStrasseK = new TextBox();
            label32 = new Label();
            TxtPostleitzahlK = new TextBox();
            groupBox4 = new GroupBox();
            TxtTelefoneK = new TextBox();
            label37 = new Label();
            CmbTitelK = new ComboBox();
            label1 = new Label();
            CmbAnredeK = new ComboBox();
            label2 = new Label();
            TxtVornameK = new TextBox();
            label14 = new Label();
            label31 = new Label();
            TxtNachnameK = new TextBox();
            BtnSpeichernK = new Button();
            Löschen = new Button();
            button1 = new Button();
            groupBox5.SuspendLayout();
            Administrativ.SuspendLayout();
            Notiz.SuspendLayout();
            GrpFirmaK.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ProtokollListeK);
            groupBox5.Location = new Point(103, 266);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(334, 178);
            groupBox5.TabIndex = 109;
            groupBox5.TabStop = false;
            groupBox5.Text = "Protokoll";
            // 
            // ProtokollListeK
            // 
            ProtokollListeK.Location = new Point(6, 27);
            ProtokollListeK.Name = "ProtokollListeK";
            ProtokollListeK.Size = new Size(323, 146);
            ProtokollListeK.TabIndex = 101;
            ProtokollListeK.Text = "";
            // 
            // Administrativ
            // 
            Administrativ.Controls.Add(CmbKundentypK);
            Administrativ.Controls.Add(label34);
            Administrativ.Controls.Add(CmbStatusK);
            Administrativ.Controls.Add(label43);
            Administrativ.Location = new Point(459, 324);
            Administrativ.Name = "Administrativ";
            Administrativ.Size = new Size(344, 113);
            Administrativ.TabIndex = 108;
            Administrativ.TabStop = false;
            Administrativ.Text = "Administrativ";
            // 
            // CmbKundentypK
            // 
            CmbKundentypK.FormattingEnabled = true;
            CmbKundentypK.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            CmbKundentypK.Location = new Point(156, 62);
            CmbKundentypK.Name = "CmbKundentypK";
            CmbKundentypK.Size = new Size(162, 23);
            CmbKundentypK.TabIndex = 12;
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(6, 64);
            label34.Name = "label34";
            label34.Size = new Size(65, 15);
            label34.TabIndex = 99;
            label34.Text = "Kundentyp";
            // 
            // CmbStatusK
            // 
            CmbStatusK.AutoSize = true;
            CmbStatusK.Location = new Point(71, 29);
            CmbStatusK.Name = "CmbStatusK";
            CmbStatusK.Size = new Size(53, 19);
            CmbStatusK.TabIndex = 11;
            CmbStatusK.Text = "Aktiv";
            CmbStatusK.UseVisualStyleBackColor = true;
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Location = new Point(6, 29);
            label43.Name = "label43";
            label43.Size = new Size(45, 15);
            label43.TabIndex = 95;
            label43.Text = "Status :";
            // 
            // Notiz
            // 
            Notiz.Controls.Add(TxtOwnerK);
            Notiz.Controls.Add(label35);
            Notiz.Controls.Add(TxtNotizK);
            Notiz.Controls.Add(BtnNotizSpeichernK);
            Notiz.Location = new Point(103, 458);
            Notiz.Name = "Notiz";
            Notiz.Size = new Size(700, 104);
            Notiz.TabIndex = 107;
            Notiz.TabStop = false;
            Notiz.Text = "Notiz";
            // 
            // TxtOwnerK
            // 
            TxtOwnerK.Location = new Point(450, 38);
            TxtOwnerK.Name = "TxtOwnerK";
            TxtOwnerK.Size = new Size(224, 23);
            TxtOwnerK.TabIndex = 14;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(450, 20);
            label35.Name = "label35";
            label35.Size = new Size(42, 15);
            label35.TabIndex = 100;
            label35.Text = "Owner";
            // 
            // TxtNotizK
            // 
            TxtNotizK.Location = new Point(6, 20);
            TxtNotizK.Name = "TxtNotizK";
            TxtNotizK.Size = new Size(426, 67);
            TxtNotizK.TabIndex = 15;
            TxtNotizK.Text = "";
            // 
            // BtnNotizSpeichernK
            // 
            BtnNotizSpeichernK.Location = new Point(598, 70);
            BtnNotizSpeichernK.Name = "BtnNotizSpeichernK";
            BtnNotizSpeichernK.Size = new Size(75, 23);
            BtnNotizSpeichernK.TabIndex = 15;
            BtnNotizSpeichernK.Text = "Speichern";
            BtnNotizSpeichernK.UseVisualStyleBackColor = true;
            // 
            // GrpFirmaK
            // 
            GrpFirmaK.Controls.Add(TxtWohnortK);
            GrpFirmaK.Controls.Add(TxtHausnummerK);
            GrpFirmaK.Controls.Add(label4);
            GrpFirmaK.Controls.Add(lblFirmenkontakt);
            GrpFirmaK.Controls.Add(label33);
            GrpFirmaK.Controls.Add(TxtGeschaeftK);
            GrpFirmaK.Controls.Add(label36);
            GrpFirmaK.Controls.Add(lblFirmenname);
            GrpFirmaK.Controls.Add(TxtFirmennameK);
            GrpFirmaK.Controls.Add(TxtStrasseK);
            GrpFirmaK.Controls.Add(label32);
            GrpFirmaK.Controls.Add(TxtPostleitzahlK);
            GrpFirmaK.Location = new Point(459, 62);
            GrpFirmaK.Name = "GrpFirmaK";
            GrpFirmaK.Size = new Size(344, 238);
            GrpFirmaK.TabIndex = 106;
            GrpFirmaK.TabStop = false;
            GrpFirmaK.Text = "Kontakt + Firma";
            // 
            // TxtWohnortK
            // 
            TxtWohnortK.Location = new Point(156, 202);
            TxtWohnortK.Name = "TxtWohnortK";
            TxtWohnortK.Size = new Size(162, 23);
            TxtWohnortK.TabIndex = 10;
            // 
            // TxtHausnummerK
            // 
            TxtHausnummerK.Location = new Point(156, 136);
            TxtHausnummerK.Name = "TxtHausnummerK";
            TxtHausnummerK.Size = new Size(162, 23);
            TxtHausnummerK.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 203);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 86;
            label4.Text = "Wohnort";
            // 
            // lblFirmenkontakt
            // 
            lblFirmenkontakt.AutoSize = true;
            lblFirmenkontakt.Location = new Point(6, 36);
            lblFirmenkontakt.Name = "lblFirmenkontakt";
            lblFirmenkontakt.Size = new Size(66, 15);
            lblFirmenkontakt.TabIndex = 35;
            lblFirmenkontakt.Text = "Firmaemail";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(6, 138);
            label33.Name = "label33";
            label33.Size = new Size(55, 15);
            label33.TabIndex = 89;
            label33.Text = "Nummer";
            // 
            // TxtGeschaeftK
            // 
            TxtGeschaeftK.Location = new Point(156, 32);
            TxtGeschaeftK.Name = "TxtGeschaeftK";
            TxtGeschaeftK.Size = new Size(162, 23);
            TxtGeschaeftK.TabIndex = 5;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(6, 172);
            label36.Name = "label36";
            label36.Size = new Size(67, 15);
            label36.TabIndex = 9;
            label36.Text = "Postleitzahl";
            // 
            // lblFirmenname
            // 
            lblFirmenname.AutoSize = true;
            lblFirmenname.Location = new Point(6, 65);
            lblFirmenname.Name = "lblFirmenname";
            lblFirmenname.Size = new Size(74, 15);
            lblFirmenname.TabIndex = 31;
            lblFirmenname.Text = "Firmenname";
            // 
            // TxtFirmennameK
            // 
            TxtFirmennameK.Location = new Point(156, 63);
            TxtFirmennameK.Name = "TxtFirmennameK";
            TxtFirmennameK.Size = new Size(162, 23);
            TxtFirmennameK.TabIndex = 6;
            // 
            // TxtStrasseK
            // 
            TxtStrasseK.Location = new Point(156, 105);
            TxtStrasseK.Name = "TxtStrasseK";
            TxtStrasseK.Size = new Size(162, 23);
            TxtStrasseK.TabIndex = 7;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(6, 109);
            label32.Name = "label32";
            label32.Size = new Size(43, 15);
            label32.TabIndex = 85;
            label32.Text = "Strasse";
            // 
            // TxtPostleitzahlK
            // 
            TxtPostleitzahlK.Location = new Point(156, 169);
            TxtPostleitzahlK.Name = "TxtPostleitzahlK";
            TxtPostleitzahlK.Size = new Size(162, 23);
            TxtPostleitzahlK.TabIndex = 9;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(TxtTelefoneK);
            groupBox4.Controls.Add(label37);
            groupBox4.Controls.Add(CmbTitelK);
            groupBox4.Controls.Add(label1);
            groupBox4.Controls.Add(CmbAnredeK);
            groupBox4.Controls.Add(label2);
            groupBox4.Controls.Add(TxtVornameK);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(label31);
            groupBox4.Controls.Add(TxtNachnameK);
            groupBox4.Location = new Point(103, 62);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(334, 187);
            groupBox4.TabIndex = 105;
            groupBox4.TabStop = false;
            groupBox4.Text = "Persönliche Angaben";
            // 
            // TxtTelefoneK
            // 
            TxtTelefoneK.Location = new Point(144, 155);
            TxtTelefoneK.Name = "TxtTelefoneK";
            TxtTelefoneK.Size = new Size(162, 23);
            TxtTelefoneK.TabIndex = 90;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.Location = new Point(6, 157);
            label37.Name = "label37";
            label37.Size = new Size(104, 15);
            label37.TabIndex = 90;
            label37.Text = "Geschäftsnummer";
            // 
            // CmbTitelK
            // 
            CmbTitelK.FormattingEnabled = true;
            CmbTitelK.Items.AddRange(new object[] { "Dr.", "Prof.", "-------" });
            CmbTitelK.Location = new Point(144, 62);
            CmbTitelK.Name = "CmbTitelK";
            CmbTitelK.Size = new Size(162, 23);
            CmbTitelK.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(6, 34);
            label1.Name = "label1";
            label1.Size = new Size(50, 17);
            label1.TabIndex = 1;
            label1.Text = "Anrede";
            // 
            // CmbAnredeK
            // 
            CmbAnredeK.FormattingEnabled = true;
            CmbAnredeK.Items.AddRange(new object[] { "Divers", "Frau ", "Herr", "(Keine Angabe)" });
            CmbAnredeK.Location = new Point(144, 33);
            CmbAnredeK.Name = "CmbAnredeK";
            CmbAnredeK.Size = new Size(162, 23);
            CmbAnredeK.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 92);
            label2.Name = "label2";
            label2.Size = new Size(60, 17);
            label2.TabIndex = 80;
            label2.Text = "Vorname";
            // 
            // TxtVornameK
            // 
            TxtVornameK.Location = new Point(144, 91);
            TxtVornameK.Name = "TxtVornameK";
            TxtVornameK.Size = new Size(162, 23);
            TxtVornameK.TabIndex = 3;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(6, 65);
            label14.Name = "label14";
            label14.Size = new Size(30, 15);
            label14.TabIndex = 2;
            label14.Text = "Titel";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.Location = new Point(6, 120);
            label31.Name = "label31";
            label31.Size = new Size(70, 17);
            label31.TabIndex = 81;
            label31.Text = "Nachname";
            // 
            // TxtNachnameK
            // 
            TxtNachnameK.Location = new Point(144, 120);
            TxtNachnameK.Name = "TxtNachnameK";
            TxtNachnameK.Size = new Size(162, 23);
            TxtNachnameK.TabIndex = 4;
            // 
            // BtnSpeichernK
            // 
            BtnSpeichernK.Location = new Point(726, 568);
            BtnSpeichernK.Name = "BtnSpeichernK";
            BtnSpeichernK.Size = new Size(77, 30);
            BtnSpeichernK.TabIndex = 104;
            BtnSpeichernK.Text = "Speichern";
            BtnSpeichernK.UseVisualStyleBackColor = true;
            // 
            // Löschen
            // 
            Löschen.Location = new Point(530, 568);
            Löschen.Name = "Löschen";
            Löschen.Size = new Size(77, 30);
            Löschen.TabIndex = 111;
            Löschen.Text = "Löschen";
            Löschen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(615, 568);
            button1.Name = "button1";
            button1.Size = new Size(77, 30);
            button1.TabIndex = 110;
            button1.Text = "Bearbeiten";
            button1.UseVisualStyleBackColor = true;
            // 
            // AnzeigeKunde
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 660);
            Controls.Add(Löschen);
            Controls.Add(button1);
            Controls.Add(groupBox5);
            Controls.Add(Administrativ);
            Controls.Add(Notiz);
            Controls.Add(GrpFirmaK);
            Controls.Add(groupBox4);
            Controls.Add(BtnSpeichernK);
            Name = "AnzeigeKunde";
            Text = "AnzeigeKunde";
            groupBox5.ResumeLayout(false);
            Administrativ.ResumeLayout(false);
            Administrativ.PerformLayout();
            Notiz.ResumeLayout(false);
            Notiz.PerformLayout();
            GrpFirmaK.ResumeLayout(false);
            GrpFirmaK.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox5;
        private RichTextBox ProtokollListeK;
        private GroupBox Administrativ;
        private ComboBox CmbKundentypK;
        private Label label34;
        private CheckBox CmbStatusK;
        private Label label43;
        private GroupBox Notiz;
        private TextBox TxtOwnerK;
        private Label label35;
        private RichTextBox TxtNotizK;
        private Button BtnNotizSpeichernK;
        private GroupBox GrpFirmaK;
        private TextBox TxtWohnortK;
        private TextBox TxtHausnummerK;
        private Label label4;
        private Label lblFirmenkontakt;
        private Label label33;
        private TextBox TxtGeschaeftK;
        private Label label36;
        private Label lblFirmenname;
        private TextBox TxtFirmennameK;
        private TextBox TxtStrasseK;
        private Label label32;
        private TextBox TxtPostleitzahlK;
        private GroupBox groupBox4;
        private TextBox TxtTelefoneK;
        private Label label37;
        private ComboBox CmbTitelK;
        private Label label1;
        private ComboBox CmbAnredeK;
        private Label label2;
        private TextBox TxtVornameK;
        private Label label14;
        private Label label31;
        private TextBox TxtNachnameK;
        private Button BtnSpeichernK;
        private Button Löschen;
        private Button button1;
    }
}