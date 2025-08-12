
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using ContactManager.Models;

namespace ContactManager.Utils
{
    public static class DataHandler
    {
        private static string path = "./data/contacts.json";

        public static void Save(List<Person> people)
        {
            Directory.CreateDirectory("data");
            string json = JsonSerializer.Serialize(people, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(path, json);
        }

        public static List<Person> Load()
        {
            if (!File.Exists(path)) return new List<Person>();
            string json = File.ReadAllText(path);
            return JsonSerializer.Deserialize<List<Person>>(json, new JsonSerializerOptions
            {
                Converters = { new PersonConverter() }
            });
        }
    }
}
