using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core.Model
{
    public abstract class Person
    {
        #region Eigenschaften

        private string _salutation;
        private string _firstName;
        private string _lastName;
        private DateTime _dateOfBirth;
        private string _gender;
        private string _title;
        private string _socialSecurityNumber;
        private string _phoneNumberPrivat;
        private string _phoneNumberMobile;
        private string _phoneNumberBuisness;
        private string _emailPrivat;
        private bool _status;
        private string _nationality;
        private string _street;
        private string _streetNumber;
        private string _zipCode;
        private string _place;
        private string _type;


        #endregion


        public Guid Id { get; set; } = Guid.NewGuid();
        public string Salutation { get => _salutation; set => _salutation = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string FirstName { get => _firstName; set => _firstName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string LastName { get => _lastName; set => _lastName = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value == default || value > DateTime.Now ? throw new ArgumentException("Das Datum muss in der Vergangenheit liegen.", nameof(value)) : value; }
        public string Gender { get => _gender; set => _gender = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string Title { get => _title; set => _title = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string SocialSecuritynumber { get => _socialSecurityNumber; set => _socialSecurityNumber = !AHV.IsValid(value) ? throw new ArgumentException("Die AHV-Nummer ist nicht gültig.", nameof(value)) : AHV.Normalize(value); }
        public string PhoneNumberPrivat { get => _phoneNumberPrivat; set => _phoneNumberPrivat = !Phone.IsValid(value) ? throw new ArgumentException("Die Nummer ist nicht gültig.", nameof(value)) : Phone.Normalize(value); }
        public string PhoneNumberMobile { get => _phoneNumberMobile; set => _phoneNumberMobile = !Phone.IsValid(value) ? throw new ArgumentException("Die Nummer ist nicht gültig.", nameof(value)) : Phone.Normalize(value); }
        public string PhoneNumberBuisness { get => _phoneNumberBuisness; set => _phoneNumberBuisness = !Phone.IsValid(value) ? throw new ArgumentException("Die Nummer ist nicht gültig.", nameof(value)) : Phone.Normalize(value); }
        public string EmailPrivat { get => _emailPrivat; set => _emailPrivat = !Email.IsValid(value) ? throw new ArgumentException("Die Email ist nicht gültig.", nameof(value)) : value.Trim(); }
        public bool Status { get => _status; set => _status = value; }
        public string Nationality { get => _nationality; set => _nationality = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string Street { get => _street; set => _street = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string StreetNumber { get => _streetNumber; set => _streetNumber = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string ZipCode { get => _zipCode; set => _zipCode = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string Place { get => _place; set => _place = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }
        public string Type { get => _type; set => _type = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Der Wert kann nicht leer sein.", nameof(value)) : char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower(); }

    }
}