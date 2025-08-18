using ContactManager.Domain.Common;
using System.Collections.Generic;

namespace ContactManager.Domain.Contact.BoundedContext.Person
{
    public class Key : ValueObject
    {
        public string? AhvNumber { get; }
        public string? FirstName { get; }
        public string? LastName { get; }
        public string? Email { get; }

        private Key(string? ahvNumber, string? firstName, string? lastName, string? email)
        {
            AhvNumber = Normalize(ahvNumber);
            FirstName = Normalize(firstName);
            LastName = Normalize(lastName);
            Email = Normalize(email)?.ToLowerInvariant();
        }

        public static Key ForWorkerOrTrainee(string ahvNumber)
            => new Key(ahvNumber, null, null, null);

        public static Key ForCustomer(string firstName, string lastName, string email)
            => new Key(null, firstName, lastName, email);

        private static string? Normalize(string? input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;
            return input.Trim();
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return AhvNumber;
            yield return FirstName;
            yield return LastName;
            yield return Email;
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(AhvNumber))
                return $"AHV:{AhvNumber}";
            return $"{FirstName} {LastName} <{Email}>";
        }
    }
}

