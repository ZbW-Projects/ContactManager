
using System;

namespace ContactManager.Presentation.Forms{
    partial class MainForm {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnMitarbeiter;
        private System.Windows.Forms.Button btnKunden;
        private System.Windows.Forms.Button btnLogout;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.btnMitarbeiter = new System.Windows.Forms.Button();
            this.btnKunden = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMitarbeiter
            // 
            this.btnMitarbeiter.Location = new System.Drawing.Point(30, 30);
            this.btnMitarbeiter.Name = "btnMitarbeiter";
            this.btnMitarbeiter.Size = new System.Drawing.Size(200, 50);
            this.btnMitarbeiter.TabIndex = 0;
            this.btnMitarbeiter.Text = "Mitarbeiter verwalten";
            this.btnMitarbeiter.UseVisualStyleBackColor = true;
            this.btnMitarbeiter.Click += new System.EventHandler(this.btnMitarbeiter_Click);
            // 
            // btnKunden
            // 
            this.btnKunden.Location = new System.Drawing.Point(30, 100);
            this.btnKunden.Name = "btnKunden";
            this.btnKunden.Size = new System.Drawing.Size(200, 50);
            this.btnKunden.TabIndex = 1;
            this.btnKunden.Text = "Kunden verwalten";
            this.btnKunden.UseVisualStyleBackColor = true;
            this.btnKunden.Click += new System.EventHandler(this.btnKunden_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(30, 170);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(200, 50);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 261);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnKunden);
            this.Controls.Add(this.btnMitarbeiter);
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.ResumeLayout(false);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
