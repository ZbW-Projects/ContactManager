
using System.Collections.Generic;

namespace ContactManager.Models
{
    public class Kunde : Person
    {
        public string Firmenname { get; set; }
        public string Geschaeftsadresse { get; set; }
        public string Kundentyp { get; set; }
        public string Firmenkontakt { get; set; }
        public List<KontaktNotiz> Notizen { get; set; } = new();
    }
}
