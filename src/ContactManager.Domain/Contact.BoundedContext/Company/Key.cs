using ContactManager.Domain.Common;


namespace ContactManager.Domain.Contact.BoundedContext.Company
{
    public class Key : ValueObject
    {
        public string Name { get; }
        public string Address { get; }
        public string? Email { get; }

        private Key(string name, string address, string? email)
        {
            Name = Normalize(name) ?? throw new ArgumentException("Company name is required.", nameof(name));
            Address = Normalize(address) ?? throw new ArgumentException("Company address is required.", nameof(address));
            Email = Normalize(email)?.ToLowerInvariant();
        }

        public static Key Create(string name, string address, string? email)
            => new Key(name, address, email);

        private static string? Normalize(string? input)
        {
            if (string.IsNullOrWhiteSpace(input)) return null;
            return input.Trim();
        }

        protected override IEnumerable<object?> GetEqualityComponents()
        {
            yield return Name;
            yield return Address;
            yield return Email;
        }

        public override string ToString()
            => $"{Name}, {Address}{(Email != null ? $" <{Email}>" : string.Empty)}";
    }
}
