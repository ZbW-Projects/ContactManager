using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;

namespace ContactManager.Core.Model
{

    #region JSON-Deserialisierung "Meta"-Daten

    /*================================================
     * 
     * Deserialisierung bei Polymorphismus
     * 
     * Die Objekte werden in einer zentralen Datenstruktur gespeichert,
     * in diesem Fall ein Dictionary vom Typ Person.
     * Bei der Serialisierung der Objekte vom Typ "Person" 
     * werden "Meta"-Daten (Achtung, kein offizieller Begriff!) erstellt.
     * Diese "Meta"-Daten sind Attribute im JSON, die nach der Klasse bennant sind.
     * 
     * Das ist wichtig, da bei der Deserialisierung erkennbar sein muss, 
     * welche Klasse für welchen "Type" eingesetzt werden soll.
     * 
     * Zum Beispiel:
     * Bei der Umwandlung von JSON zu einem Objekt (Deserialisierung)
     * wird das Attribut "$type" mit dem Wert "customer" gelesen. 
     * Für die Objekt-Erstellung wird entsprechend die Klasse "Customer"
     * verwendet.
     * 
     *===============================================*/

    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$type")]
    [JsonDerivedType(typeof(Customer), "customer")]
    [JsonDerivedType(typeof(Employee), "employee")]
    [JsonDerivedType(typeof(Trainee), "trainee")]


    #endregion
    public abstract class Person
    {
        #region Eigenschaften

        private string _salutation = "";
        private string _firstName = "";
        private string _lastName = "";
        private DateTime _dateOfBirth;
        private string _gender = "";
        private string _title = "";
        private string _socialSecurityNumber = "";
        private string _phoneNumberPrivat = "";
        private string _phoneNumberMobile = "";
        private string _phoneNumberBuisness = "";
        private string _emailPrivat = "";
        private bool _status;
        private string _nationality = "";
        private string _street = "";
        private string _streetNumber = "";
        private string _zipCode = "";
        private string _place = "";
        private string _type = "";


        #endregion

        public Guid Id { get; set; } = Guid.NewGuid();
        public string Salutation { get => _salutation; set => _salutation = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Die Anrede muss vorhanden sein") : Name.Normalize(value); }
        public string FirstName { get => _firstName; set => _firstName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Vorname muss vorhanen sein.") : Name.Normalize(value); }
        public string LastName { get => _lastName; set => _lastName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Nachname muss vorhanden sein.") : Name.Normalize(value); }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value != default && value > DateTime.Now ? throw new ArgumentException("Das Datum muss in der Vergangenheit liegen.") : value; }
        public string Gender { get => _gender; set => _gender = Name.Normalize(value); }
        public string Title { get => _title; set => _title = Name.Normalize(value); }
        public string SocialSecurityNumber { get => _socialSecurityNumber; set => _socialSecurityNumber = !AHV.IsValid(value) ? throw new ArgumentException("Die AHV-Nummer ist nicht gültig.") : AHV.Normalize(value); }
        public string PhoneNumberPrivate { get => _phoneNumberPrivat; set => _phoneNumberPrivat = !Phone.IsValid(value) ? throw new ArgumentException("Die Privatnummer ist nicht gültig.") : Phone.Normalize(value); }
        public string PhoneNumberMobile { get => _phoneNumberMobile; set => _phoneNumberMobile = !Phone.IsValid(value) ? throw new ArgumentException("Die Mobilenummer ist nicht gültig.") : Phone.Normalize(value); }
        public string PhoneNumberBuisness { get => _phoneNumberBuisness; set => _phoneNumberBuisness = !Phone.IsValid(value) ? throw new ArgumentException("Die Geschäftsnummer ist nicht gültig.") : Phone.Normalize(value); }
        public virtual string EmailPrivat { get => _emailPrivat; set => _emailPrivat = !Email.IsValid(value) ? throw new ArgumentException("Die Email ist nicht gültig.") : value.Trim(); }
        public bool Status { get => _status; set => _status = value; }
        public string Nationality { get => _nationality; set => _nationality = Name.Normalize(value); }
        public string Street { get => _street; set => _street = value.Trim(); }
        public string StreetNumber { get => _streetNumber; set => _streetNumber = value.Trim(); }
        public string ZipCode { get => _zipCode; set => _zipCode = value.ToUpper(); }
        public string Place { get => _place; set => _place = Name.Normalize(value); }
        public string Type { get => _type; set => _type = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Typ muss vorhanden sein.") : Name.Normalize(value); }

    }
}