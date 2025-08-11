
using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using ContactManager.Models;

namespace ContactManager.Utils {
    public class PersonConverter : JsonConverter<Person> {
        public override Person Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) {
            using var doc = JsonDocument.ParseValue(ref reader);
            var root = doc.RootElement;
            var isMitarbeiter = root.TryGetProperty("MitarbeitendenNummer", out _);
            return isMitarbeiter
                ? JsonSerializer.Deserialize<Mitarbeiter>(root.GetRawText(), options)
                : JsonSerializer.Deserialize<Kunde>(root.GetRawText(), options);
        }

        public override void Write(Utf8JsonWriter writer, Person value, JsonSerializerOptions options) {
            JsonSerializer.Serialize(writer, (object)value, value.GetType(), options);
        }
    }
}
