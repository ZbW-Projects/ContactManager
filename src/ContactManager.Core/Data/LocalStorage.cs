using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using ContactManager.Core.Model;

namespace ContactManager.Core.Data
{
    public class LocalStorage
    {


        private static string _storagePath = @"\storage\contacts.json";

        /*================================
         * Hauptdatenträger von Kontakten
         ==================================*/
        private static Dictionary<Guid, Person> _contacts;


        /*================================
         * Accesor auf Kontakte
         ===============================*/
        public static Dictionary<Guid, Person> Contacts
        {
            get => _contacts;
            private set => _contacts = FetchData();
        }


        /*===============================
         * Manipulatoren
         * 
         * 1. Der Hauptdatenträger wird manipuliert
         * 2. Eine neue JSON entsteht 
         * 3. Daten werden Local gespeichert
         * 
         * ==============================*/
        public static void StoreContact(Guid Id, Person contact)
        {
            // 1. Schirtt
            _contacts.Add(Id, contact);
            // 2.Schritt
            string payload = ConvertToJSON(_contacts);
            // 3.Schitt
            SaveLocally(payload);
        }

        public static void UpdateContact(Guid Id, Person contact)
        {
            //1.Schritt
            _contacts[Id] = contact;
            //2.Schritt
            string payload = ConvertToJSON(_contacts);
            //3.Schritt
            SaveLocally(payload);
        }

        public static void DeleteContact(Guid Id, Person contact)
        {
            //1.Schritt
            _contacts.Remove(Id);
            //2.Schritt
            string payload = ConvertToJSON(_contacts);
            //3.Schritt
            SaveLocally(payload);
        }

        // Helper-Methoden, um Daten im JSON-Format umzuwandeln und lokal speichern

        private static string ConvertToJSON(Dictionary<Guid, Person> contacts)
        {
            return JsonSerializer.Serialize(contacts);
        }

        private static void SaveLocally(string payload)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_storagePath));
            File.WriteAllText(_storagePath, payload);
        }

        private static Dictionary<Guid, Person> FetchData()
        {
            // Von lokalen Datenträger JSON auslesen und in einer Variable speichern
            string data = File.ReadAllText(_storagePath);

            // JSON in gespeicherte Variable zu eiem Dictionary umwandeln und ausgeben
            return JsonSerializer.Deserialize<Dictionary<Guid, Person>>(data);
        }
    }
}
