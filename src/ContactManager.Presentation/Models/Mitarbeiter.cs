
namespace ContactManager.Models {
    public class Mitarbeiter : Person {
        public int MitarbeitendenNummer { get; set; }
        public string Abteilung { get; set; }
        public string AHVNummer { get; set; }
        public string Wohnort { get; set; }
        public string Nationalitaet { get; set; }
        public string Adresse { get; set; }
        public string PLZ { get; set; }
        public string TelefonPrivat { get; set; }
        public System.DateTime Eintrittsdatum { get; set; }
        public System.DateTime? Austrittsdatum { get; set; }
        public int Beschaeftigungsgrad { get; set; }
        public string Rolle { get; set; }
        public int Kaderstufe { get; set; }
        public int Lehrjahre { get; set; }
        public int? AktuellesLehrjahr { get; set; }
    }
}
