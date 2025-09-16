using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Net.Mail;
using System.Threading.Tasks;

/*=================================================================================
 * 
 * Unterstützungs-Tools für die Validierung und Normalisierung komplexerer Werte.
 * 
 * =================================================================================*/

namespace ContactManager.Core.Model
{
    #region Name

    public class Name
    {
        public static string Normalize(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "";
            return char.ToUpper(value.Trim()[0]) + value.Trim()[1..].ToLower();
        }
    }

    #endregion 

    #region AHV
    public class AHV
    {
        public static bool IsValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return true;

            var cleaned = Clean(value);

            if (cleaned.Length != 13 || !cleaned.StartsWith("756")) return false;

            // Controliert ob die AHVNummer Keine Buchataben hat
            if (!ulong.TryParse(cleaned, out var _)) return false;

            if (!HasValidEan13Checksum(cleaned)) return false;

            return true;
        }

        public static string Normalize(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "";
            var cleaned = Clean(value);
            return $"{cleaned.Substring(0, 3)}.{cleaned.Substring(3, 4)}.{cleaned.Substring(7, 4)}.{cleaned.Substring(11, 2)}";
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

        private static string Clean(string value)
        {
            return value.Replace(" ", "").Replace("-", "").Replace(".", "");
        }
    }

    #endregion

    #region Phone
    public class Phone
    {
        public static bool IsValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return true;

            var cleaned = Clean(value);

            // Controliert ob die Tel.Nummer keine Buchataben hat
            if (cleaned?.StartsWith('+') == true)
            {

                if (!ulong.TryParse(cleaned[1..], out var _)) return false;
            }

            // Controliert ob die Tel.Nummer keine Buchataben hat
            if (!ulong.TryParse(cleaned, out var _)) return false;

            if (!HasValidPhoneNumber(cleaned)) return false;

            return true;
        }

        public static string Normalize(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return "";

            var cleaned = Clean(value);

            // Output als +41 79 123 45 67
            if (cleaned?.StartsWith('+') == true) return $"{cleaned.Substring(0, 3)} {cleaned.Substring(3, 2)} {cleaned.Substring(5, 3)} {cleaned.Substring(8, 2)} {cleaned.Substring(10, 2)}";

            // Output als 079 123 45 67
            return $"{cleaned?.Substring(0, 3)} {cleaned?.Substring(3, 3)} {cleaned?.Substring(6, 2)} {cleaned?.Substring(8, 2)}";
        }

        private static bool HasValidPhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, @"^\+41[1-9]\d{8}$") || Regex.IsMatch(phoneNumber, @"^0\d{9}$");
        }


        private static string Clean(string value)
        {
            return Regex.Replace(value, @"[^\d+]", "");
        }
    }

    #endregion

    #region Email
    public class Email
    {
        public static bool IsValid(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return false;

            var cleaned = value.Trim();

            if (!MailAddress.TryCreate(cleaned, out var email)) return false;

            // Position von @ darf nicht am Anfang oder Ende sein
            var at = email.Address.IndexOf('@');
            if (at <= 0 || at == email.Address.Length - 1) return false;
            return true;
        }
    }

    #endregion

}