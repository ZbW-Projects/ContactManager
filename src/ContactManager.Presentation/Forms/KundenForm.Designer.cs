
namespace ContactManager.Presentation.Forms {
    partial class KundenForm {
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

        private void InitializeComponent()
        {
            dataGridView = new DataGridView();
            btnNeu = new Button();
            btnLoeschen = new Button();
            txtSuche = new TextBox();
            btnSuchen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(12, 50);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(600, 250);
            dataGridView.TabIndex = 0;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            // 
            // btnNeu
            // 
            btnNeu.Location = new Point(12, 310);
            btnNeu.Name = "btnNeu";
            btnNeu.Size = new Size(75, 23);
            btnNeu.TabIndex = 1;
            btnNeu.Text = "Neu";
            btnNeu.UseVisualStyleBackColor = true;
            btnNeu.Click += btnNeu_Click;
            // 
            // btnLoeschen
            // 
            btnLoeschen.Location = new Point(93, 310);
            btnLoeschen.Name = "btnLoeschen";
            btnLoeschen.Size = new Size(75, 23);
            btnLoeschen.TabIndex = 2;
            btnLoeschen.Text = "Löschen";
            btnLoeschen.UseVisualStyleBackColor = true;
            btnLoeschen.Click += btnLoeschen_Click;
            // 
            // txtSuche
            // 
            txtSuche.Location = new Point(12, 12);
            txtSuche.Name = "txtSuche";
            txtSuche.Size = new Size(200, 23);
            txtSuche.TabIndex = 3;
            // 
            // btnSuchen
            // 
            btnSuchen.Location = new Point(326, 11);
            btnSuchen.Name = "btnSuchen";
            btnSuchen.Size = new Size(75, 23);
            btnSuchen.TabIndex = 4;
            btnSuchen.Text = "Suchen";
            btnSuchen.UseVisualStyleBackColor = true;
            btnSuchen.Click += btnSuchen_Click;
            // 
            // KundenForm
            // 
            ClientSize = new Size(624, 341);
            Controls.Add(btnSuchen);
            Controls.Add(txtSuche);
            Controls.Add(btnLoeschen);
            Controls.Add(btnNeu);
            Controls.Add(dataGridView);
            Name = "KundenForm";
            Text = "Mitarbeiterverwaltung";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
