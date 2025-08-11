
namespace ContactManager.Models {
    public abstract class Person {
        public string Anrede { get; set; }
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public System.DateTime Geburtsdatum { get; set; }
        public string Geschlecht { get; set; }
        public string Titel { get; set; }
        public string TelefonnummerGeschaeft { get; set; }
        public string Mobiltelefonnummer { get; set; }
        public string EmailAdresse { get; set; }
        public bool Aktiv { get; set; }
    }
}
