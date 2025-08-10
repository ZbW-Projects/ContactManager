using ContactManager.Domain.Common;

namespace ContactManager.Domain.Contact.BoundedContext.Person
{
    public sealed class Name : ValueObject
    {
        public string SurName { get; }
        public string LastName { get; }
        private Name(string surname, string lastname)
        {
            if (string.IsNullOrWhiteSpace(surname))
            {
                throw new ArgumentException("Surname is required.", nameof(surname));
            }

            if (string.IsNullOrWhiteSpace(lastname))
            {
                throw new ArgumentException("Lastname is required.", nameof(lastname));
            }

            SurName = surname.Trim();
            LastName = lastname.Trim();
        }

        public static Name Create(string surname, string lastname)
        {
            return new Name(surname, lastname);
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return SurName.ToLowerInvariant();
            yield return LastName.ToLowerInvariant();
        }

        public override string ToString() => $"{SurName} {LastName}";
    }
}
