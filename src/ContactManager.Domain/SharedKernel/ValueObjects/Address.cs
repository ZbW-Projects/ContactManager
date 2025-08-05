using ContactManager.Domain.Common;


// Input: Beispielstrasse, 4, 8543, Dietikon, Zürich, Schweiz
// Output: "Beispielstrasse 4, 8543 Dietikon, Zürich"

namespace ContactManager.Domain.SharedKernel.ValueObjects
{
    public class Address : ValueObject
    {
        public string Street { get; }
        public string HouseNumber { get; }
        public string ZipCode { get; }
        public string City { get; }
        public string State { get; }
        public string Country { get; }

        protected Address() { }

        public Address(string street, string houseNumber, string zipCode, string city, string state, string country)
        {
            if (string.IsNullOrWhiteSpace(street)) throw new ArgumentException("Street is required.");
            if (string.IsNullOrWhiteSpace(houseNumber)) throw new ArgumentException("House number is required.");
            if (string.IsNullOrWhiteSpace(zipCode)) throw new ArgumentException("Zip code is required.");
            if (string.IsNullOrWhiteSpace(city)) throw new ArgumentException("City is required.");
            if (string.IsNullOrWhiteSpace(state)) throw new ArgumentException("State is required.");
            if (string.IsNullOrWhiteSpace(country)) throw new ArgumentException("Country is required.");

            Street = street.Trim();
            HouseNumber = houseNumber.Trim();
            ZipCode = zipCode.Trim();
            City = Capitalize(city.Trim());
            State = Capitalize(state.Trim());
            Country = Capitalize(country.Trim());
        }

        private static string Capitalize(string input)
        {
            return string.IsNullOrWhiteSpace(input) ? string.Empty : char.ToUpper(input[0]) + input.Substring(1).ToLower();
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Street;
            yield return HouseNumber;
            yield return ZipCode;
            yield return City;
            yield return State;
            yield return Country;
        }

        public override string ToString() => $"{Street} {HouseNumber}, {ZipCode} {City}, {State}";
    }
}
