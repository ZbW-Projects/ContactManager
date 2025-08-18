using System;
using System.Net.Mail;

namespace ContactManager.Domain.SharedKernel.ValueObjects
{
    public class Email : SingleValueObject<string>
    {
        public Email(string value) : base(Normalize(value)) { }

        private static string Normalize(string input)
        {
            try
            {
                var mail = new MailAddress(input);
                return mail.Address.ToLowerInvariant();
            }
            catch (FormatException)
            {
                throw new ArgumentException("Email format is invalid", nameof(input));
            }
        }

        public static Email Create(string value) => new(value);
    }
}
