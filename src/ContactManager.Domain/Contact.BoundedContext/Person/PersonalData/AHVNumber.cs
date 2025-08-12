using ContactManager.Domain.SharedKernel.ValueObjects;

// Input: string 756.9217.0769.85
// Output: 756.9217.0769.85

namespace ContactManager.Domain.Contact.BoundedContext.Person.PersonalData
{
    public class AHVNumber : SingleValueObject<string>
    {
        private AHVNumber(string value) : base(Normalize(value)) { }

        private static string Normalize(string value)
        {
            if (value is null)
            {
                throw new ArgumentNullException(nameof(value), "AHV number is required.");
            }

            var cleaned = value.Replace(" ", "").Replace("-", "").Replace(".", "");

            if (cleaned.Length != 13 || !cleaned.StartsWith("756"))
            {
                throw new ArgumentException("AHV number must start with 756 and be 13 digits long.", nameof(value));
            }

            if (!ulong.TryParse(cleaned, out var _))
            {
                throw new ArgumentException("AHV number must contain only digits.", nameof(value));
            }

            if (!HasValidEan13Checksum(cleaned))
            {
                throw new ArgumentException("AHV checksum is invalid.", nameof(value));
            }

            return Format(cleaned);
        }

        private static string Format(string raw)
        {
            return $"{raw.Substring(0, 3)}.{raw.Substring(3, 4)}.{raw.Substring(7, 4)}.{raw.Substring(11, 2)}";
        }

        private static bool HasValidEan13Checksum(string ahvNumber)
        {
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int d = ahvNumber[i] - '0';
                sum += (i % 2 == 0) ? d : (3 * d); // index 0 is leftmost digit
            }
            int check = (10 - (sum % 10)) % 10;
            return check == (ahvNumber[12] - '0');
        }

        public static AHVNumber Create(string value) => new(value);
    }

}
