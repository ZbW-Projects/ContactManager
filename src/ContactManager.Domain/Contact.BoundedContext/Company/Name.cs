using ContactManager.Domain.SharedKernel.ValueObjects;
using System;

// Input: string Acme Corp
// Output: string Acme Corp

namespace ContactManager.Domain.Contact.BoundedContext.Company
{

    public class Name : SingleValueObject<string>
    {
        public Name(string value) : base(Normalize(value)) { }

        private static string Normalize(string value)
        {
            var trimmed = value.Trim();

            if (trimmed.Length < 3)
            {
                throw new ArgumentException("Enterprise name must be at least 3 characters.");
            }

            if (trimmed.Length > 100)
            {
                throw new ArgumentException("Enterprise name must be less than 100 characters.");
            }
            return value.Trim();
        }

        public static Name Create(string value) => new(value);
    }

}
