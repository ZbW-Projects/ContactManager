
namespace ContactManager.Presentation.Forms {
    partial class LoginForm {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbBenutzer;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent() {
            this.cmbBenutzer = new System.Windows.Forms.ComboBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbBenutzer
            // 
            this.cmbBenutzer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBenutzer.FormattingEnabled = true;
            this.cmbBenutzer.Items.AddRange(new object[] {
            "admin",
            "Max Muster"});
            this.cmbBenutzer.Location = new System.Drawing.Point(12, 12);
            this.cmbBenutzer.Name = "cmbBenutzer";
            this.cmbBenutzer.Size = new System.Drawing.Size(260, 23);
            this.cmbBenutzer.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 50);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(260, 30);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Einloggen";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 101);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.cmbBenutzer);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
        }
    }
}
