
namespace ContactManager.Presentation.Forms {
    partial class MitarbeiterEditForm {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtVorname;
        private System.Windows.Forms.TextBox txtNachname;
        private System.Windows.Forms.DateTimePicker dtpEintritt;
        private System.Windows.Forms.CheckBox chkAktiv;
        private System.Windows.Forms.Button btnSpeichern;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.txtVorname = new System.Windows.Forms.TextBox();
            this.txtNachname = new System.Windows.Forms.TextBox();
            this.dtpEintritt = new System.Windows.Forms.DateTimePicker();
            this.chkAktiv = new System.Windows.Forms.CheckBox();
            this.btnSpeichern = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVorname
            // 
            this.txtVorname.Location = new System.Drawing.Point(12, 12);
            this.txtVorname.Name = "txtVorname";
            this.txtVorname.PlaceholderText = "Vorname";
            this.txtVorname.Size = new System.Drawing.Size(260, 23);
            this.txtVorname.TabIndex = 0;
            // 
            // txtNachname
            // 
            this.txtNachname.Location = new System.Drawing.Point(12, 41);
            this.txtNachname.Name = "txtNachname";
            this.txtNachname.PlaceholderText = "Nachname";
            this.txtNachname.Size = new System.Drawing.Size(260, 23);
            this.txtNachname.TabIndex = 1;
            // 
            // dtpEintritt
            // 
            this.dtpEintritt.Location = new System.Drawing.Point(12, 70);
            this.dtpEintritt.Name = "dtpEintritt";
            this.dtpEintritt.Size = new System.Drawing.Size(260, 23);
            this.dtpEintritt.TabIndex = 2;
            // 
            // chkAktiv
            // 
            this.chkAktiv.AutoSize = true;
            this.chkAktiv.Location = new System.Drawing.Point(12, 100);
            this.chkAktiv.Name = "chkAktiv";
            this.chkAktiv.Size = new System.Drawing.Size(55, 19);
            this.chkAktiv.TabIndex = 3;
            this.chkAktiv.Text = "Aktiv?";
            this.chkAktiv.UseVisualStyleBackColor = true;
            // 
            // btnSpeichern
            // 
            this.btnSpeichern.Location = new System.Drawing.Point(12, 130);
            this.btnSpeichern.Name = "btnSpeichern";
            this.btnSpeichern.Size = new System.Drawing.Size(260, 30);
            this.btnSpeichern.TabIndex = 4;
            this.btnSpeichern.Text = "Speichern";
            this.btnSpeichern.UseVisualStyleBackColor = true;
            this.btnSpeichern.Click += new System.EventHandler(this.btnSpeichern_Click);
            // 
            // MitarbeiterEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.btnSpeichern);
            this.Controls.Add(this.chkAktiv);
            this.Controls.Add(this.dtpEintritt);
            this.Controls.Add(this.txtNachname);
            this.Controls.Add(this.txtVorname);
            this.Name = "MitarbeiterEditForm";
            this.Text = "Neuer Mitarbeiter";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
