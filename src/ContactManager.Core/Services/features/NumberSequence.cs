using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContactManager.Core.Services.features
{
    public static class NumberSequence
    {
        private static readonly string _dir = Path.Combine(AppContext.BaseDirectory, "Data", "Storage");
        private static readonly string _path = Path.Combine(_dir, "counter.json");
        private static object _lock = new();


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
    }


    public class Payload
    {
        public int counter { get; set; }
    }
}