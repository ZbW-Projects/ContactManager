
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ContactManager.Models;
using ContactManager.Utils;

namespace ContactManager.Presentation.Forms {
    public partial class SucheForm : Form {
        private List<Person> alleDaten;

        public SucheForm() {
            InitializeComponent();
            InitializeCustomComponents();
        }

        private void InitializeCustomComponents() {
            this.Text = "Suche";
            this.Width = 800;
            this.Height = 400;

            var lbl = new Label { Text = "Suchbegriff:", Left = 10, Top = 20 };
            var txt = new TextBox { Left = 100, Top = 20, Width = 200 };
            var btn = new Button { Text = "Suchen", Left = 310, Top = 20, Width = 80 };
            var list = new ListBox { Top = 60, Left = 10, Width = 760, Height = 300 };

            this.Controls.Add(lbl);
            this.Controls.Add(txt);
            this.Controls.Add(btn);
            this.Controls.Add(list);

            alleDaten = DataHandler.Load();

            btn.Click += (s, e) => {
                string suchbegriff = txt.Text.ToLower();
                var result = alleDaten.Where(p =>
                    (p.Vorname != null && p.Vorname.ToLower().Contains(suchbegriff)) ||
                    (p.Nachname != null && p.Nachname.ToLower().Contains(suchbegriff)) ||
                    (p is Mitarbeiter m && m.MitarbeitendenNummer.ToString().Contains(suchbegriff))
                ).ToList();

                list.Items.Clear();
                foreach (var p in result)
                    list.Items.Add($"{p.Vorname} {p.Nachname} ({(p is Mitarbeiter ? "Mitarbeiter" : "Kunde")})");
            };
        }
    }
}
