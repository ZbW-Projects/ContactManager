using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Core.Services.features
{
    public class ContactLogger
    {
        private static string _storageDir = Path.Combine(AppContext.BaseDirectory, "logs");
        private static string _storagePath = Path.Combine(_storageDir, "contact_changes.log");

        /*====================================================
         * 
         * Loggers:
         * Im Moment werden nur geänderte Kontakte geloggt.
         * 
         *====================================================*/

        #region  Exponierte Methode / Öffentliche Schnittstellen

        public static bool LogIfChanged<TDto>(Guid contactId, string entityName, TDto oldDto, TDto newDto, params string[] ignoreProperties)
        {
            Directory.CreateDirectory(_storageDir);

            if (oldDto == null || newDto == null) return false;

            var changes = GetChangedValues(oldDto, newDto, ignoreProperties);
            if (changes.Count == 0) return false;

            WriteChangedLog(contactId, entityName, oldDto, changes);
            return true;
        }

        #region Helper Methoden

        // Jede Einzelne Eigenschaft wird verglichen
        private static Dictionary<string, object?> GetChangedValues<TDto>(TDto oldDto, TDto newDto, string[] ignoreProperties)
        {
            var ignore = new HashSet<string>(ignoreProperties ?? Array.Empty<string>(), StringComparer.OrdinalIgnoreCase);
            var result = new Dictionary<string, object?>();
            var properties = typeof(TDto).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var p in properties)
            {
                if (!p.CanRead) continue;
                if (ignore.Contains(p.Name)) continue;

                var oldProp = p.GetValue(oldDto);
                var newProp = p.GetValue(newDto);

                if (!Equals(oldProp, newProp))
                {
                    result[p.Name] = newProp;
                }
            }
            return result;
        }

        // ChangeLogs werden Geschrieben und Persistiert als logdatei

        private static void WriteChangedLog<TDto>(Guid contactId, string entityName, TDto oldDto, Dictionary<string, object?> newValues)
        {
            var sb = new StringBuilder();
            sb.AppendLine("================================");
            sb.AppendLine("Start");
            sb.AppendLine("================================");
            sb.AppendLine($"TimeStamp: {DateTime.Now: dd-MM-yyyy HH:mm:ss.fff}");
            sb.AppendLine($"ContactId: {contactId}");
            sb.AppendLine($"Entity: {entityName}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Changed Values (Display new):");
            foreach (var kv in newValues)
                sb.AppendLine($"{kv.Key}: {kv.Value}");
            sb.AppendLine("--------------------------------");
            sb.AppendLine("Old Contact Data:");
            foreach (var p in typeof(TDto).GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                var val = p.GetValue(oldDto);
                sb.AppendLine($"{p.Name}: {val}");
            }
            sb.AppendLine("================================");
            sb.AppendLine("================================");
            sb.AppendLine();

            File.AppendAllText(_storagePath, sb.ToString(), Encoding.UTF8);
        }

        #endregion 

        #endregion

    }
}
