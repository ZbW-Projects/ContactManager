namespace ContactManager.View.Forms
{
    partial class Contacts
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
            btnSearch = new Button();
            txtSearch = new TextBox();
            grdContacts = new DataGridView();
            Vorname = new DataGridViewTextBoxColumn();
            Nachname = new DataGridViewTextBoxColumn();
            Typ = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            btnSearch1 = new Button();
            btnloeschen = new Button();
            ((System.ComponentModel.ISupportInitialize)grdContacts).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(309, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(76, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Suche";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(58, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(235, 23);
            txtSearch.TabIndex = 1;
            // 
            // grdContacts
            // 
            grdContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContacts.Columns.AddRange(new DataGridViewColumn[] { Vorname, Nachname, Typ, Status, Tel });
            grdContacts.Location = new Point(58, 71);
            grdContacts.Name = "grdContacts";
            grdContacts.RowHeadersWidth = 62;
            grdContacts.Size = new Size(570, 312);
            grdContacts.TabIndex = 4;
            grdContacts.CellContentClick += grdContacts_CellContentClick;
            // 
            // Vorname
            // 
            Vorname.HeaderText = "Vorname";
            Vorname.MinimumWidth = 8;
            Vorname.Name = "Vorname";
            Vorname.ReadOnly = true;
            Vorname.Width = 150;
            // 
            // Nachname
            // 
            Nachname.HeaderText = "Nachname";
            Nachname.MinimumWidth = 8;
            Nachname.Name = "Nachname";
            Nachname.ReadOnly = true;
            Nachname.Width = 150;
            // 
            // Typ
            // 
            Typ.HeaderText = "Typ";
            Typ.MinimumWidth = 8;
            Typ.Name = "Typ";
            Typ.ReadOnly = true;
            Typ.Width = 150;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 8;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // Tel
            // 
            Tel.HeaderText = "Tel";
            Tel.MinimumWidth = 8;
            Tel.Name = "Tel";
            Tel.ReadOnly = true;
            Tel.Width = 150;
            // 
            // btnSearch1
            // 
            btnSearch1.Location = new Point(495, 26);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(106, 23);
            btnSearch1.TabIndex = 3;
            btnSearch1.Text = "Neuer Kontakt";
            btnSearch1.UseVisualStyleBackColor = true;
            btnSearch1.Click += btnSearch1_Click;
            // 
            // btnloeschen
            // 
            btnloeschen.Location = new Point(525, 403);
            btnloeschen.Name = "btnloeschen";
            btnloeschen.Size = new Size(76, 23);
            btnloeschen.TabIndex = 5;
            btnloeschen.Text = "Löschen";
            btnloeschen.UseVisualStyleBackColor = true;
            btnloeschen.Click += btnloeschen_Click;
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnloeschen);
            Controls.Add(btnSearch1);
            Controls.Add(grdContacts);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Name = "Contacts";
            Text = "Contacts";
            ((System.ComponentModel.ISupportInitialize)grdContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView grdContacts;
        private Button btnSearch1;
        private Button btnloeschen;
        private DataGridViewTextBoxColumn Vorname;
        private DataGridViewTextBoxColumn Nachname;
        private DataGridViewTextBoxColumn Typ;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Tel;
    }
}
