using ContactManager.Core.Data;
using ContactManager.Core.Model;
using ContactManager.Core.Services.features;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
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
        private static Dictionary<Guid, Person> _contacts = [];

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
        public static List<DtoPersonRow> GetList()
        {
            // Mapping von Person zu DTOPersonRow
            return _contacts.Values.Select(MapToDTOPersonRow).ToList();
        }
        public static List<DtoPersonRow> Search(string term)
        {
            if (string.IsNullOrWhiteSpace(term)) return GetList();

            return _contacts.Values.Where(contact => Matches(contact, term)).Select(MapToDTOPersonRow).ToList();
        }

        public static (bool ok, string message) DeleteContact(Guid id)
        {
            try
            {
                // Es wird versucht ein Kontakt zu löschen
                if (!_contacts.TryGetValue(id, out var person)) return (false, "Unbekannte Kontakt-Id.");

                // Daten persistieren 
                LocalStorage.DeleteContact(id);

                // Cache aktualisieren
                UpdateContacts();

                // Erfolgsmeldung
                return (true, "Kontakt wurde erfolgreich gelöscht!");
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

        #region Mapper
        private static DtoPersonRow MapToDTOPersonRow(Person contact)
        {
            return new DtoPersonRow
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

        public static DtoCustomer GetCustomer(Guid id)
        {
            Customer contact = (Customer)_contacts[id];
            return MapToDtoCustomer(contact);
        }
        public static (bool ok, string message) CreateCustomer(DtoCustomer cmd)
        {
            try
            {
                // Es wird versucht Customer zu instanziieren
                Person customer = new Customer
                {
                    Salutation = cmd.Salutation,
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

                // Cache aktualisieren
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
        public static (bool ok, string message) UpdateCustomer(Guid id, DtoCustomer cmd)
        {
            try
            {
                // Es wird versucht Customer zu verändern
                if (!_contacts.TryGetValue(id, out var person)) return (false, "Unbekannte Kontakt-Id.");
                if (person is not Customer customer) return (false, "Ausgewählte Person ist kein Kunde.");

                customer.Salutation = cmd.Salutation;
                customer.FirstName = cmd.FirstName;
                customer.LastName = cmd.LastName;
                customer.Title = cmd.Title;
                customer.PhoneNumberBuisness = cmd.PhoneNumberBuisness;
                customer.Status = cmd.Status;
                customer.Street = cmd.Street;
                customer.StreetNumber = cmd.StreetNumber;
                customer.ZipCode = cmd.ZipCode;
                customer.Place = cmd.Place;
                customer.Type = cmd.Type;
                customer.CompanyName = cmd.CompanyName;
                customer.CustomerType = cmd.CustomerType;
                customer.CompanyContact = cmd.CompanyContact;

                // Daten persistieren 
                LocalStorage.UpdateContact(customer.Id, customer);

                // Cache aktualisieren
                UpdateContacts();

                // Erfolgsmeldung
                return (true, "Kunde wurde erfolgreich geändert!");
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
        public static (bool ok, string message) AddCustomerNote(Guid customerId, string content, string owner)
        {
            try
            {
                if (!_contacts.TryGetValue(customerId, out Person? person)) return (false, "Kunde ist noch nicht vorhanen");

                // Message Einfügen
                if (person is Customer customer)
                {
                    customer.AddMessage(content, owner);
                }
                else
                {
                    return (false, "Diese Person ist kein Kunde");
                }

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

        #region Mapper
        private static DtoCustomer MapToDtoCustomer(Customer customer)
        {
            return new DtoCustomer
            {
                Id = customer.Id,
                Salutation = customer.Salutation,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Title = customer.Title,
                PhoneNumberBuisness = customer.PhoneNumberBuisness,
                Status = customer.Status,
                Street = customer.Street,
                StreetNumber = customer.StreetNumber,
                ZipCode = customer.ZipCode,
                Place = customer.Place,
                Type = customer.Type,
                CompanyName = customer.CompanyName,
                CustomerType = customer.CustomerType,
                CompanyContact = customer.CompanyContact,
                Messages = customer.Messages,
            };
        }

        #endregion

        #endregion

        #region Use Cases für Employee

        public static DtoEmployee GetEmployee(Guid id)
        {
            Employee contact = (Employee)_contacts[id];
            return MapToDtoEmployee(contact);
        }
        public static (bool ok, string message) CreateEmployee(DtoEmployee cmd)
        {
            try
            {
                // EmployeeNummer wird generiert
                int number = NumberSequence.NextEmployeeNumber();
                // Es wird versucht Employee zu instanziieren
                Person employee = new Employee("M", number)
                {
                    Salutation = cmd.Salutation,
                    FirstName = cmd.FirstName,
                    LastName = cmd.LastName,
                    DateOfBirth = cmd.DateOfBirth,
                    Gender = cmd.Gender,
                    Title = cmd.Title,
                    SocialSecurityNumber = cmd.SocialSecurityNumber,
                    PhoneNumberPrivate = cmd.PhoneNumberPrivate,
                    PhoneNumberMobile = cmd.PhoneNumberMobile,
                    PhoneNumberBuisness = cmd.PhoneNumberBuisness,
                    EmailPrivat = cmd.EmailPrivat,
                    Status = cmd.Status,
                    Nationality = cmd.Nationality,
                    Street = cmd.Street,
                    StreetNumber = cmd.StreetNumber,
                    ZipCode = cmd.ZipCode,
                    Place = cmd.Place,
                    Type = cmd.Type,
                    Department = cmd.Department,
                    StartDate = cmd.StartDate,
                    EndDate = cmd.EndDate,
                    Employment = cmd.Employment,
                    Role = cmd.Role,
                    CadreLevel = cmd.CadreLevel
                };

                // Daten persistieren 
                LocalStorage.StoreContact(employee.Id, employee);

                // Cache aktualisieren
                UpdateContacts();

                // Erfolgsmeldung
                return (true, "Mitarbeiter wurde erfolgreich gespeichert!");
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
        public static (bool ok, string message) UpdateEmployee(Guid id, DtoEmployee cmd)
        {
            try
            {
                // Es wird versucht Trainee zu verändern
                if (!_contacts.TryGetValue(id, out var person)) return (false, "Unbekannte Kontakt-Id.");
                if (person is not Employee employee) return (false, "Ausgewählte Person ist kein Mitarbeiter.");

                employee.Salutation = cmd.Salutation;
                employee.FirstName = cmd.FirstName;
                employee.LastName = cmd.LastName;
                employee.DateOfBirth = cmd.DateOfBirth;
                employee.Gender = cmd.Gender;
                employee.Title = cmd.Title;
                employee.SocialSecurityNumber = cmd.SocialSecurityNumber;
                employee.PhoneNumberPrivate = cmd.PhoneNumberPrivate;
                employee.PhoneNumberMobile = cmd.PhoneNumberMobile;
                employee.PhoneNumberBuisness = cmd.PhoneNumberBuisness;
                employee.EmailPrivat = cmd.EmailPrivat;
                employee.Status = cmd.Status;
                employee.Nationality = cmd.Nationality;
                employee.Street = cmd.Street;
                employee.ZipCode = cmd.ZipCode;
                employee.Place = cmd.Place;
                employee.Type = cmd.Type;
                employee.Department = cmd.Department;
                employee.StartDate = cmd.StartDate;
                employee.EndDate = cmd.EndDate;
                employee.Employment = cmd.Employment;
                employee.Role = cmd.Role;
                employee.CadreLevel = cmd.CadreLevel;

                // Daten persistieren 
                LocalStorage.UpdateContact(employee.Id, employee);

                // Cache aktualisieren
                UpdateContacts();

                // Erfolgsmeldung
                return (true, "Employee wurde erfolgreich geändert!");
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

        #region Mapper

        private static DtoEmployee MapToDtoEmployee(Employee employee)
        {
            return new DtoEmployee
            {
                Id = employee.Id,
                Salutation = employee.Salutation,
                FirstName = employee.FirstName,
                LastName = employee.LastName,
                DateOfBirth = employee.DateOfBirth,
                Gender = employee.Gender,
                Title = employee.Title,
                SocialSecurityNumber = employee.SocialSecurityNumber,
                PhoneNumberPrivate = employee.PhoneNumberPrivate,
                PhoneNumberMobile = employee.PhoneNumberMobile,
                PhoneNumberBuisness = employee.PhoneNumberBuisness,
                EmailPrivat = employee.EmailPrivat,
                Status = employee.Status,
                Nationality = employee.Nationality,
                Street = employee.Street,
                StreetNumber = employee.StreetNumber,
                ZipCode = employee.ZipCode,
                Place = employee.Place,
                Type = employee.Type,
                EmployeeNumber = employee.EmployeeNumber,
                Department = employee.Department,
                StartDate = employee.StartDate,
                EndDate = employee.EndDate,
                Employment = employee.Employment,
                Role = employee.Role,
                CadreLevel = employee.CadreLevel
            };
        }

        #endregion

        #endregion

        #region Use Cases für Trainee

        public static DtoTrainee GetTrainee(Guid id)
        {
            Trainee contact = (Trainee)_contacts[id];
            return MapToDtoTrainee(contact);
        }
        public static (bool ok, string message) CreateTrainee(DtoTrainee cmd)
        {
            try
            {
                // EmployeeNummer wird generiert
                int number = NumberSequence.NextEmployeeNumber();
                // Es wird versucht Trainee zu instanziieren
                Person trainee = new Trainee("L", number)
                {
                    Salutation = cmd.Salutation,
                    FirstName = cmd.FirstName,
                    LastName = cmd.LastName,
                    DateOfBirth = cmd.DateOfBirth,
                    Gender = cmd.Gender,
                    Title = cmd.Title,
                    SocialSecurityNumber = cmd.SocialSecurityNumber,
                    PhoneNumberPrivate = cmd.PhoneNumberPrivate,
                    PhoneNumberMobile = cmd.PhoneNumberMobile,
                    PhoneNumberBuisness = cmd.PhoneNumberBuisness,
                    EmailPrivat = cmd.EmailPrivat,
                    Status = cmd.Status,
                    Nationality = cmd.Nationality,
                    Street = cmd.Street,
                    ZipCode = cmd.ZipCode,
                    Place = cmd.Place,
                    Type = cmd.Type,
                    Department = cmd.Department,
                    StartDate = cmd.StartDate,
                    EndDate = cmd.EndDate,
                    Employment = cmd.Employment,
                    Role = cmd.Role,
                    CadreLevel = cmd.CadreLevel,
                    TraineeYears = cmd.TraineeYears,
                };

                // Daten persistieren 
                LocalStorage.StoreContact(trainee.Id, trainee);

                // Cache aktualisieren
                UpdateContacts();

                // Erfolgsmeldung
                return (true, "Lehrling wurde erfolgreich gespeichert!");
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
        public static (bool ok, string message) UpdateTrainee(Guid id, DtoTrainee cmd)
        {
            try
            {
                // Es wird versucht Trainee zu verändern
                if (!_contacts.TryGetValue(id, out var person)) return (false, "Unbekannte Kontakt-Id.");
                if (person is not Trainee trainee) return (false, "Ausgewählte Person ist kein Lehrling.");

                trainee.Salutation = cmd.Salutation;
                trainee.FirstName = cmd.FirstName;
                trainee.LastName = cmd.LastName;
                trainee.DateOfBirth = cmd.DateOfBirth;
                trainee.Gender = cmd.Gender;
                trainee.Title = cmd.Title;
                trainee.SocialSecurityNumber = cmd.SocialSecurityNumber;
                trainee.PhoneNumberPrivate = cmd.PhoneNumberPrivate;
                trainee.PhoneNumberMobile = cmd.PhoneNumberMobile;
                trainee.PhoneNumberBuisness = cmd.PhoneNumberBuisness;
                trainee.EmailPrivat = cmd.EmailPrivat;
                trainee.Status = cmd.Status;
                trainee.Nationality = cmd.Nationality;
                trainee.Street = cmd.Street;
                trainee.ZipCode = cmd.ZipCode;
                trainee.Place = cmd.Place;
                trainee.Type = cmd.Type;
                trainee.Department = cmd.Department;
                trainee.StartDate = cmd.StartDate;
                trainee.EndDate = cmd.EndDate;
                trainee.Employment = cmd.Employment;
                trainee.Role = cmd.Role;
                trainee.CadreLevel = cmd.CadreLevel;
                trainee.CadreLevel = cmd.CadreLevel;
                trainee.TraineeYears = cmd.TraineeYears;

                // Daten persistieren 
                LocalStorage.UpdateContact(trainee.Id, trainee);

                // Cache aktualisieren
                UpdateContacts();

                // Erfolgsmeldung
                return (true, "Lehrling wurde erfolgreich geändert!");
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

        #region Mapper

        private static DtoTrainee MapToDtoTrainee(Trainee trainee)
        {
            return new DtoTrainee
            {
                Id = trainee.Id,
                Salutation = trainee.Salutation,
                FirstName = trainee.FirstName,
                LastName = trainee.LastName,
                DateOfBirth = trainee.DateOfBirth,
                Gender = trainee.Gender,
                Title = trainee.Title,
                SocialSecurityNumber = trainee.SocialSecurityNumber,
                PhoneNumberPrivate = trainee.PhoneNumberPrivate,
                PhoneNumberMobile = trainee.PhoneNumberMobile,
                PhoneNumberBuisness = trainee.PhoneNumberBuisness,
                EmailPrivat = trainee.EmailPrivat,
                Status = trainee.Status,
                Nationality = trainee.Nationality,
                Street = trainee.Street,
                StreetNumber = trainee.StreetNumber,
                ZipCode = trainee.ZipCode,
                Place = trainee.Place,
                Type = trainee.Type,
                EmployeeNumber = trainee.EmployeeNumber,
                Department = trainee.Department,
                StartDate = trainee.StartDate,
                EndDate = trainee.EndDate,
                Employment = trainee.Employment,
                Role = trainee.Role,
                CadreLevel = trainee.CadreLevel,
                TraineeYears = trainee.TraineeYears,
                ActualTraineeYear = trainee.ActualTraineeYear
            };
        }

        #endregion

        #endregion
    }


    /*=======================================================
     * 
     * Die Data Transfer Objects
     * 
     *=======================================================*/

    #region DTO für die Auflistung von Personen Kontakten
    public sealed class DtoPersonRow
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Type { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public string PhoneNumberBuisness { get; set; } = string.Empty;
    }

    #endregion 

    #region DTOEmployee
    public sealed class DtoEmployee
    {
        public Guid Id { get; init; }
        public string Salutation { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public DateTime DateOfBirth { get; init; }
        public string Gender { get; init; } = string.Empty;
        public string Title { get; init; } = string.Empty;
        public string SocialSecurityNumber { get; init; } = string.Empty;
        public string PhoneNumberPrivate { get; init; } = string.Empty;
        public string PhoneNumberMobile { get; init; } = string.Empty;
        public string PhoneNumberBuisness { get; init; } = string.Empty;
        public string EmailPrivat { get; init; } = string.Empty;
        public bool Status { get; init; }
        public string Nationality { get; init; } = string.Empty;
        public string Street { get; init; } = string.Empty;
        public string StreetNumber { get; init; } = string.Empty;
        public string ZipCode { get; init; } = string.Empty;
        public string Place { get; init; } = string.Empty;
        public string Type { get; init; } = string.Empty;
        public string EmployeeNumber { get; init; } = string.Empty;
        public string Department { get; init; } = string.Empty;
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public int Employment { get; init; }
        public string Role { get; init; } = string.Empty;
        public int CadreLevel { get; init; }

    }

    #endregion 

    #region DTOTrainee
    public sealed class DtoTrainee
    {
        public Guid Id { get; init; }
        public string Salutation { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public DateTime DateOfBirth { get; init; }
        public string Gender { get; init; } = string.Empty;
        public string Title { get; init; } = string.Empty;
        public string SocialSecurityNumber { get; init; } = string.Empty;
        public string PhoneNumberPrivate { get; init; } = string.Empty;
        public string PhoneNumberMobile { get; init; } = string.Empty;
        public string PhoneNumberBuisness { get; init; } = string.Empty;
        public string EmailPrivat { get; init; } = string.Empty;
        public bool Status { get; init; }
        public string Nationality { get; init; } = string.Empty;
        public string Street { get; init; } = string.Empty;
        public string StreetNumber { get; init; } = string.Empty;
        public string ZipCode { get; init; } = string.Empty;
        public string Place { get; init; } = string.Empty;
        public string Type { get; init; } = string.Empty;
        public string EmployeeNumber { get; init; } = string.Empty;
        public string Department { get; init; } = string.Empty;
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public int Employment { get; init; }
        public string Role { get; init; } = string.Empty;
        public int CadreLevel { get; init; }
        public int TraineeYears { get; init; }
        public int ActualTraineeYear { get; init; }

    }

    #endregion

    #region DTOCustomer
    public sealed class DtoCustomer
    {
        public Guid Id { get; init; }
        public string Salutation { get; init; } = string.Empty;
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;
        public string Title { get; init; } = string.Empty;
        public string PhoneNumberBuisness { get; init; } = string.Empty;
        public bool Status { get; init; }
        public string Street { get; init; } = string.Empty;
        public string StreetNumber { get; init; } = string.Empty;
        public string ZipCode { get; init; } = string.Empty;
        public string Place { get; init; } = string.Empty;
        public string Type { get; init; } = string.Empty;
        public string CompanyName { get; init; } = string.Empty;
        public char CustomerType { get; init; }
        public string CompanyContact { get; init; } = string.Empty;
        public Protocol? Messages { get; init; }
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
