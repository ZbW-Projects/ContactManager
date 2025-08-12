
namespace ContactManager.Presentation.Forms {
    partial class KundenEditForm {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.CheckBox chkAktiv;
        private System.Windows.Forms.Button btnSpeichern;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtVorname = new TextBox();
            txtNachname = new TextBox();
            txtFirma = new TextBox();
            chkAktiv = new CheckBox();
            btnSpeichern = new Button();
            SuspendLayout();
            // 
            // txtVorname
            // 
            txtVorname.Location = new Point(12, 12);
            txtVorname.Name = "txtVorname";
            txtVorname.PlaceholderText = "Vorname";
            txtVorname.Size = new Size(260, 23);
            txtVorname.TabIndex = 0;
            // 
            // txtNachname
            // 
            txtNachname.Location = new Point(12, 41);
            txtNachname.Name = "txtNachname";
            txtNachname.PlaceholderText = "Nachname";
            txtNachname.Size = new Size(260, 23);
            txtNachname.TabIndex = 1;
            txtNachname.TextChanged += txtNachname_TextChanged;
            // 
            // txtFirma
            // 
            txtFirma.Location = new Point(12, 70);
            txtFirma.Name = "txtFirma";
            txtFirma.PlaceholderText = "Firmenname";
            txtFirma.Size = new Size(260, 23);
            txtFirma.TabIndex = 2;
            // 
            // chkAktiv
            // 
            chkAktiv.AutoSize = true;
            chkAktiv.Location = new Point(12, 99);
            chkAktiv.Name = "chkAktiv";
            chkAktiv.Size = new Size(58, 19);
            chkAktiv.TabIndex = 3;
            chkAktiv.Text = "Aktiv?";
            chkAktiv.UseVisualStyleBackColor = true;
            // 
            // btnSpeichern
            // 
            btnSpeichern.Location = new Point(12, 124);
            btnSpeichern.Name = "btnSpeichern";
            btnSpeichern.Size = new Size(260, 30);
            btnSpeichern.TabIndex = 4;
            btnSpeichern.Text = "Speichern";
            btnSpeichern.UseVisualStyleBackColor = true;
            btnSpeichern.Click += btnSpeichern_Click;
            // 
            // KundenEditForm
            // 
            ClientSize = new Size(348, 299);
            Controls.Add(btnSpeichern);
            Controls.Add(chkAktiv);
            Controls.Add(txtFirma);
            Controls.Add(txtNachname);
            Controls.Add(txtVorname);
            Name = "KundenEditForm";
            Text = "Neuer Kunde";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
