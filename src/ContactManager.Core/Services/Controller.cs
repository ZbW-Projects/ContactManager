using ContactManager.Core.Data;
using ContactManager.Core.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core.Services
{
    public class Controller
    {
        /*===================================================
         * 
         * Logic, um die Daten am Controller verfügbar zu stellen.
         * 
         *===================================================*/
        private static Dictionary<Guid, Person> _contacts;

        public static void SpinData()
        {
            // Setze lokale Daten zum "Spin" ein 
            LocalStorage.SetContacts();
            // Binde Daten zu Controller
            _contacts = LocalStorage.Contacts;

        }

        private static void UpdateContacts() => _contacts = LocalStorage.Contacts;


        /*====================================================
         * 
         *
         * Use Cases der Anwendung
         * 
         * Data Transfer Objects (DTOs), sowie die 
         * entsprechenden Mappings und Fromatierungen befinden sich unten
         * 
         * ===================================================*/


        #region Generelle Use Cases
        public static List<DTOPersonRow> GetList()
        {
            // Mapping von Person zu DTOPersonRow
            return _contacts.Values.Select(MapToDTOPersonRow).ToList();
        }

        public static List<DTOPersonRow> Search(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) return GetList();

            return _contacts.Values.Where(contact => Matches(contact, term)).Select(MapToDTOPersonRow).ToList();
        }

        #region Mappers
        private static DTOPersonRow MapToDTOPersonRow(Person contact)
        {
            return new DTOPersonRow
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Type = UiFormat.Type(contact.Type),
                Status = UiFormat.BoolToStatus(contact.Status),
                PhoneNumberBuisness = contact.PhoneNumberBuisness
            };
        }

        #endregion

        #region Tools
        private static bool Matches(Person contact, string term)
        {


            // Formatierung zu string für den Contains
            string dateOfBirth = UiFormat.Date(contact.DateOfBirth);
            string status = UiFormat.BoolToStatus(contact.Status);

            return Contains(contact.FirstName, term)
                || Contains(contact.LastName, term)
                || Contains(dateOfBirth, term)
                || Contains(status, term)
                || Contains(contact.PhoneNumberBuisness, term)
                || Contains(contact.Type, term);

        }

        private static bool Contains(string property, string term)
        {
            var cmp = StringComparison.OrdinalIgnoreCase;
            return property.Contains(term, cmp);
        }

        #endregion


        #endregion

        #region Use Cases für Customer

        public static (bool ok, string message) CreateCustomer(DtoCustomer cmd)
        {
            try
            {
                // Es wird versucht Customer zu instanziieren
                Person customer = new Customer
                {
                    Salutation = cmd.Salutaion,
                    FirstName = cmd.FirstName,
                    LastName = cmd.LastName,
                    Title = cmd.Title,
                    PhoneNumberBuisness = cmd.PhoneNumberBuisness,
                    Status = cmd.Status,
                    Street = cmd.Street,
                    StreetNumber = cmd.StreetNumber,
                    ZipCode = cmd.ZipCode,
                    Place = cmd.Place,
                    Type = cmd.Type,
                    CompanyName = cmd.CompanyName,
                    CustomerType = cmd.CustomerType,
                    CompanyContact = cmd.CompanyContact

                };

                // Daten persistieren 
                LocalStorage.StoreContact(customer.Id, customer);

                // Daten aktualisieren
                UpdateContacts();

                // Erfolgsmeldung
                return (true, "Kunde wurde erfolgreich gespeichert!");
            }
            catch (ArgumentException ex)
            {
                return (false, $"Eingabefehler; {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Technischer Fehler beim Speichern: {ex.Message}");
            }
        }

        public static (bool ok, string message) AddCustomerNote(Guid customerId, Customer customer, string content, string owner)
        {
            try
            {
                if (!_contacts.TryGetValue(customerId, out var p)) return (false, "Kunde ist noch nicht vorhanden");

                customer.AddMessage(content);
                var last = customer.Messages.Messages[^1];
                last.Owner = owner;

                // Daten persistieren 
                LocalStorage.UpdateContact(customer.Id, customer);
                // Daten aktualisieren
                UpdateContacts();

                return (true, "Notiz gespeichert!");
            }
            catch (ArgumentException ex)
            {
                return (false, $"Eingabefehler: {ex.Message}");
            }
            catch (Exception ex)
            {
                return (false, $"Technischer Fehler: {ex.Message}");
            }

        }

        #endregion
    }



    /*=======================================================
     * 
     * Die Data Transfer Objects
     * 
     *=======================================================*/

    #region DTO für die Auflistung von Personen Kontakten
    public sealed class DTOPersonRow
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string PhoneNumberBuisness { get; set; }
    }

    #endregion 

    #region DTOEmployee
    public sealed class DTOEmployee
    {
        public Guid Id { get; init; }
        public string Salutation { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string DateOfBirth { get; init; }
        public string Gender { get; init; }
        public string Title { get; init; }
        public string SocialSecurityNumber { get; init; }
        public string PhoneNumberPrivate { get; init; }
        public string PhoneNumberMobile { get; init; }
        public string PhoneNumberBuisness { get; init; }
        public string EmailPrivat { get; init; }
        public bool Status { get; init; }
        public string Nationality { get; init; }
        public string Street { get; init; }
        public string ZipCode { get; init; }
        public string Place { get; init; }
        public string Type { get; init; }
        public string EmployeeNumber { get; init; }
        public string Department { get; init; }
        public string StartDate { get; init; }
        public string EndDate { get; init; }
        public string Employment { get; init; }
        public string Role { get; init; }
        public int CadreLevel { get; init; }

    }

    #endregion 

    #region DTOTrainee
    public sealed class DTOTrainee
    {
        public Guid Id { get; init; }
        public string Salutation { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string DateOfBirth { get; init; }
        public string Gender { get; init; }
        public string Title { get; init; }
        public string SocialSecurityNumber { get; init; }
        public string PhoneNumberPrivate { get; init; }
        public string PhoneNumberMobile { get; init; }
        public string PhoneNumberBuisness { get; init; }
        public string EmailPrivat { get; init; }
        public bool Status { get; init; }
        public string Nationality { get; init; }
        public string Street { get; init; }
        public string ZipCode { get; init; }
        public string Place { get; init; }
        public string Type { get; init; }
        public string EmployeeNumber { get; init; }
        public string Department { get; init; }
        public string StartDate { get; init; }
        public string EndDate { get; init; }
        public string Employment { get; init; }
        public string Role { get; init; }
        public int CadreLevel { get; init; }
        public int TraineeYears { get; init; }
        public int ActualTraineeYear { get; init; }

    }

    #endregion

    #region DTOCustomer
    public sealed class DtoCustomer
    {
        public Guid Id { get; init; }
        public string Salutaion { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Title { get; init; }
        public string PhoneNumberBuisness { get; init; }
        public bool Status { get; init; }
        public string Street { get; init; }
        public string StreetNumber { get; init; }
        public string ZipCode { get; init; }
        public string Place { get; init; }
        public string Type { get; init; }
        public string CompanyName { get; init; }
        public char CustomerType { get; init; }
        public string CompanyContact { get; init; }
        public Protocol Messages { get; init; } = new();
    }

    #endregion


    /*===========================================================
     * 
     * Formaters
     * 
     *===========================================================*/

    #region Formaters
    public static class UiFormat
    {
        private static readonly CultureInfo DeCh = CultureInfo.GetCultureInfo("de-CH");

        public static string Name(string? first, string? last)
            => $"{(first ?? "").Trim()} {(last ?? "").Trim()}".Trim();

        public static string Date(DateTime value)
            => value == default ? "" : value.ToString("dd.MM.yyyy", DeCh);


        public static string BoolToStatus(bool active)
            => active ? "Aktiv" : "Inaktiv";

        public static string Type(string? t)
            => string.IsNullOrWhiteSpace(t) ? "Unbekannt" : t;
    }
    #endregion

}
