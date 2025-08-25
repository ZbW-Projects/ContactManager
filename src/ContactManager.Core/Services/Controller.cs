using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactManager.Core.Data;
using ContactManager.Core.Model;

namespace ContactManager.Core.Services
{
    public class Controller
    {
        /*===================================================
         * 
         * Logic, um die Daten am Controller verfügbar zu stellen.
         * 
         *===================================================*/
        private static readonly Dictionary<Guid, Person> _contacts;
        static Controller()
        {
            // Setze lokale Daten zum "Spin" ein 
            LocalStorage.SetContacts();
            // Binde Daten zu Controller
            _contacts = LocalStorage.Contacts;
        }

        /*====================================================
         * 
         *
         * Use Cases der Anwendung
         * 
         * Data Transfer Objects (DTOs), sowie die 
         * entsprechenden Mappings befinden sich unten
         * 
         * ===================================================*/

        // GET

        public static List<DTOPersonRow> GetList()
        {
            // Mapping von Person zu DTOPersonRow
            return _contacts.Values.Select(MapToDTOPersonRow).ToList();
        }






        /*======================================================
         *  
         *  Mappers
         * 
         * =====================================================*/


        private static DTOPersonRow MapToDTOPersonRow(Person contact)
        {
            return new DTOPersonRow
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Type = contact.Type,
                Status = contact.Status,
                PhoneNumberBuisness = contact.PhoneNumberBuisness
            };
        }


    }


    /*=======================================================
     * 
     * Die Data Transfer Objects
     * 
     *=======================================================*/

    // DTO für die Auflistung von Personen Kontakten
    public class DTOPersonRow
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public bool Status { get; set; }
        public string PhoneNumberBuisness { get; set; }

    }
}
