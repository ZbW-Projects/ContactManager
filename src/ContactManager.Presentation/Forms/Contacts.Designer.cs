namespace ContactManager.Presentation.Forms
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
            Mail = new DataGridViewTextBoxColumn();
            btnSearch1 = new Button();
            ((System.ComponentModel.ISupportInitialize)grdContacts).BeginInit();
            SuspendLayout();
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(309, 25);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(106, 24);
            btnSearch.TabIndex = 0;
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
            txtSearch.TextChanged += txtSearch_TextChanged_1;
            // 
            // grdContacts
            // 
            grdContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdContacts.Columns.AddRange(new DataGridViewColumn[] { Vorname, Nachname, Typ, Status, Mail });
            grdContacts.Location = new Point(58, 94);
            grdContacts.Name = "grdContacts";
            grdContacts.Size = new Size(543, 247);
            grdContacts.TabIndex = 2;
            grdContacts.CellContentClick += grdContacts_CellContentClick;
            // 
            // Vorname
            // 
            Vorname.HeaderText = "Vorname";
            Vorname.Name = "Vorname";
            // 
            // Nachname
            // 
            Nachname.HeaderText = "Nachname";
            Nachname.Name = "Nachname";
            // 
            // Typ
            // 
            Typ.HeaderText = "Typ";
            Typ.Name = "Typ";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            // 
            // Mail
            // 
            Mail.HeaderText = "Mail";
            Mail.Name = "Mail";
            // 
            // btnSearch1
            // 
            btnSearch1.Location = new Point(495, 24);
            btnSearch1.Name = "btnSearch1";
            btnSearch1.Size = new Size(106, 23);
            btnSearch1.TabIndex = 3;
            btnSearch1.Text = "Neuer Kontakt";
            btnSearch1.UseVisualStyleBackColor = true;
            btnSearch1.Click += btnSearch1_Click;
            // 
            // Contacts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
        private DataGridViewTextBoxColumn Vorname;
        private DataGridViewTextBoxColumn Nachname;
        private DataGridViewTextBoxColumn Typ;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Mail;
        private Button btnSearch1;
    }
}
