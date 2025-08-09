using ContactManager.Domain.SharedKernel.ValueObjects;

// Input: string "CH"
// Output: string "CH"

namespace ContactManager.Domain.Contact.BoundedContext.Person.PersonalData
{


    public class Nationality : SingleValueObject<string>
    {
        private static readonly HashSet<string> Allowed = new(StringComparer.OrdinalIgnoreCase)
        {
            // Minimaler liste, entweder kann man es erweitern oder aus einer externe Quelle importieren
            "CH","DE","AT","IT","FR","LI","US","GB","ES","PT","NL","BE","DK","SE","NO","FI",
            "PL","CZ","SK","HU","SI","HR","BA","RS","RO","BG","GR","IE","LU"

        };
        private Nationality(string value) : base(Normalize(value)) { }

        private static string Normalize(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Nationality cannot be empty.", nameof(value));
            }

            var code = value.Trim().ToUpperInvariant();

            if (code.Length != 2)
            {
                throw new ArgumentException("Nationality must be a 2-letter ISO 3166-1 alpha-2 code.", nameof(value));
            }

            if (!Allowed.Contains(code))
            {
                throw new ArgumentException($"Unsupported nationality code '{code}'.", nameof(value));
            }

            return code;
        }

        public static Nationality Create(string value) => new(value);
    }

}
