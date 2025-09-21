using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContactManager.Core.Services.features
{

    /* =======================================================================
     * 
     * Die Number Sequence wird hier vor allem für die Aufzählung der Mitarbeiter bzw.
     * Lehrlingsnummern eingesetzt.
     * Die Aufzählung wird als JSON fest gespeichert.
     * Dadurch wird sichergestellt, dass immer eine neue Integer-Zahl erstellt wird.
     * 
     *=======================================================================*/
    public static class NumberSequence
    {
        private static readonly string _dir = Path.Combine(AppContext.BaseDirectory, "Data", "Storage");
        private static readonly string _path = Path.Combine(_dir, "counter.json");
        private static object _lock = new();

        #region JSON Daten holen / speichern bzw. umwandeln
        private static Payload Load()
        {
            Directory.CreateDirectory(_dir);
            if (!File.Exists(_path)) return new Payload { counter = 0 };
            var json = File.ReadAllText(_path);

            var payload = JsonSerializer.Deserialize<Payload>(json);

            if (payload is null)
                throw new InvalidDataException($"Invalid payload in '{_path}'.");

            return payload;
        }

        private static void Save(Payload p)
        {
            var json = JsonSerializer.Serialize(p, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(_path, json);
        }

        #endregion

        #region Exponierte Methode / Öffentliche Schnittstelle
        public static int NextEmployeeNumber()
        {
            lock (_lock)
            {
                var p = Load();
                p.counter++;
                Save(p);
                return p.counter;
            }
        }

        #endregion
    }

    /*=============================================================
     * 
     * Die Klasse "Payload" ist hier dafür zuständig, aus den 
     * JSON-Daten ein Objekt zu erstellen.
     * 
     *=============================================================*/

    public class Payload
    {
        public int counter { get; set; }
    }

}