using ContactManager.Domain.SharedKernel.ValueObjects;
using System.Text.RegularExpressions;

// Input: string 756.1234.5678.91
// Output: 756.1234.5678.91

namespace ContactManager.Domain.Contact.BoundedContext.Person.PersonalData
{
    public class AHVNumber : SingleValueObject<string>
    {
        private static readonly Regex _ahvFormat = new(@"^756\.\d{4}\.\d{4}\.\d{2}$", RegexOptions.Compiled);
        private AHVNumber(string value) : base(Normalize(value)) { }

        private static string Normalize(string value)
        {
            var cleaned = value.Replace(" ", "").Replace("-", "").Replace(".", "");

            if (cleaned.Length != 13 || !cleaned.StartsWith("756"))
            {
                throw new ArgumentException("AHV number must start with 756 and be 13 digits long.");
            }

            if (!ulong.TryParse(cleaned, out var _))
            {
                throw new ArgumentException("AHV number must contain only digits.");
            }

            if (!IsValidChecksum(cleaned))
            {
                throw new ArgumentException("AHV checksum is invalid.");
            }

            return Format(cleaned);
        }

        private static string Format(string raw)
        {
            return $"{raw.Substring(0, 3)}.{raw.Substring(3, 4)}.{raw.Substring(7, 4)}.{raw.Substring(11, 2)}";
        }

        private static bool IsValidChecksum(string number)
        {
            // Based on Modulo 11 (Swiss AHV)
            int[] weights = { 5, 4, 3, 2, 7, 6, 5, 4, 3, 2, 1 };
            int sum = 0;

            for (int i = 0; i < weights.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                sum += digit * weights[i];
            }

            return sum % 11 == 0;
        }
        public static AHVNumber Create(string value) => new(value);
    }

}
