using ContactManager.Domain.Common;
using System.Net.Mail;

namespace ContactManager.Domain.SharedKernel.ValueObjects
{
    public class Email : ValueObject
    {
        public string Value { get; }

        protected Email() { } // For EF or serialization
        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Email cannot be empty", nameof(value));
            }

            try
            {
                var email = new MailAddress(value);
                Value = email.Address;
            }
            catch (FormatException)
            {
                throw new ArgumentException("Email format is invalid", nameof(value));
            }
        }
        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Value.ToLowerInvariant(); // Normailze for comparison
        }

        public override string ToString() => Value;
    }
}
