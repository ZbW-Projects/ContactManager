
namespace ContactManager.Presentation.Forms {
    partial class MitarbeiterForm {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button btnNeu;
        private System.Windows.Forms.Button btnLoeschen;
        private System.Windows.Forms.TextBox txtSuche;
        private System.Windows.Forms.Button btnSuchen;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.btnNeu = new System.Windows.Forms.Button();
            this.btnLoeschen = new System.Windows.Forms.Button();
            this.txtSuche = new System.Windows.Forms.TextBox();
            this.btnSuchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(600, 250);
            this.dataGridView.TabIndex = 0;
            // 
            // btnNeu
            // 
            this.btnNeu.Location = new System.Drawing.Point(12, 310);
            this.btnNeu.Name = "btnNeu";
            this.btnNeu.Size = new System.Drawing.Size(75, 23);
            this.btnNeu.TabIndex = 1;
            this.btnNeu.Text = "Neu";
            this.btnNeu.UseVisualStyleBackColor = true;
            this.btnNeu.Click += new System.EventHandler(this.btnNeu_Click);
            // 
            // btnLoeschen
            // 
            this.btnLoeschen.Location = new System.Drawing.Point(93, 310);
            this.btnLoeschen.Name = "btnLoeschen";
            this.btnLoeschen.Size = new System.Drawing.Size(75, 23);
            this.btnLoeschen.TabIndex = 2;
            this.btnLoeschen.Text = "Löschen";
            this.btnLoeschen.UseVisualStyleBackColor = true;
            this.btnLoeschen.Click += new System.EventHandler(this.btnLoeschen_Click);
            // 
            // txtSuche
            // 
            this.txtSuche.Location = new System.Drawing.Point(12, 12);
            this.txtSuche.Name = "txtSuche";
            this.txtSuche.Size = new System.Drawing.Size(200, 23);
            this.txtSuche.TabIndex = 3;
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(218, 12);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(75, 23);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "Suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // MitarbeiterForm
            // 
            this.ClientSize = new System.Drawing.Size(624, 341);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.txtSuche);
            this.Controls.Add(this.btnLoeschen);
            this.Controls.Add(this.btnNeu);
            this.Controls.Add(this.dataGridView);
            this.Name = "MitarbeiterForm";
            this.Text = "Mitarbeiterverwaltung";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
