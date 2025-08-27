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


        private static string _storageDir = Path.Combine(AppContext.BaseDirectory, "Data", "Storage");
        private static string _storagePath = Path.Combine(_storageDir, "contacts.json");
        private static readonly JsonSerializerOptions _serializeOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        /*================================
         * Hauptdatenträger von Kontakten
         ==================================*/
        private static Dictionary<Guid, Person> _contacts;

        /*===============================================================
         *
         * Basiert auf dem CRUD-Design
         * 
         ===============================================================*/

        /*================================
         * Accesor auf Kontakte "READ"
         ===============================*/
        public static Dictionary<Guid, Person> Contacts => _contacts;
        public static Dictionary<Guid, Person> SetContacts() => _contacts = FetchData();

        /*===============================
         * "Manipulatoren" CREATE, UPDATE, DELETE 
         * 
         * 1. Der Hauptdatenträger wird manipuliert
         * 2. Eine neue JSON entsteht 
         * 3. Daten werden Local gespeichert
         * 4. Optional: Ereignisse am Controller weiterleiten
         * 
         * ==============================*/

        // CREATE
        public static void StoreContact(Guid Id, Person contact)
        {
            // 1. Schirtt
            _contacts.Add(Id, contact);
            // 2.Schritt
            string payload = ConvertToJSON(_contacts);
            // 3.Schitt
            SaveLocally(payload);
        }

        // UPDATE
        public static void UpdateContact(Guid Id, Person contact)
        {
            //1.Schritt
            _contacts[Id] = contact;
            //2.Schritt
            string payload = ConvertToJSON(_contacts);
            //3.Schritt
            SaveLocally(payload);
        }

        // DELETE
        public static void DeleteContact(Guid Id, Person contact)
        {
            //1.Schritt
            _contacts.Remove(Id);
            //2.Schritt
            string payload = ConvertToJSON(_contacts);
            //3.Schritt
            SaveLocally(payload);
        }


        /*========================================================================
         * 
         * Helper-Methoden, um Daten im JSON-Format umzuwandeln und lokal speichern
         * 
         * ==========================================================================*/
        private static string ConvertToJSON(Dictionary<Guid, Person> contacts)
        {
            return JsonSerializer.Serialize(contacts, _serializeOptions);
        }


        private static void SaveLocally(string payload)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(_storagePath));
            File.WriteAllText(_storagePath, payload);
        }

        private static Dictionary<Guid, Person> FetchData()
        {
            // Sicherstellen das Ordner Sotorage existiert
            Directory.CreateDirectory(_storageDir);
            if (!File.Exists(_storagePath)) return new Dictionary<Guid, Person>(); // Existiert contacts.json

            // Von lokalen Datenträger JSON auslesen und in einer Variable speichern
            string data = File.ReadAllText(_storagePath);
            if (string.IsNullOrWhiteSpace(data)) return new Dictionary<Guid, Person>();

            // JSON in gespeicherte Variable zu eiem Dictionary umwandeln und ausgeben
            return JsonSerializer.Deserialize<Dictionary<Guid, Person>>(data, _serializeOptions);
        }
    }
}
