using PhoneNumbers;
using System;

namespace ContactManager.Domain.SharedKernel.ValueObjects
{
    public class PhoneNumber : SingleValueObject<string>
    {

        private static readonly PhoneNumberUtil _phoneUtil = PhoneNumberUtil.GetInstance();
        public PhoneNumber(string number, string region = "CH") : base(Normalize(number, region)) { }

        private static string Normalize(string input, string region)
        {
            try
            {
                var parsed = _phoneUtil.Parse(input, region);

                if (!_phoneUtil.IsValidNumber(parsed))
                {
                    throw new ArgumentException("Invalid phone number");
                }
                return _phoneUtil.Format(parsed, PhoneNumberFormat.E164); // +41781234567

            }
            catch (NumberParseException ex)
            {
                throw new ArgumentException("Malformed phone number", nameof(ex));
            }
        }
        public static PhoneNumber Create(string number, string region = "CH") => new(number, region);
    }
}
