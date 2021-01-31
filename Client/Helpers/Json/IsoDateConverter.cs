using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Helpers.Json {
    public class IsoDateConverter : JsonConverter<DateTime> {
        public override DateTime Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) {

            var valueString = reader.GetString();
            return Convert.ToDateTime(valueString);
        }

        public override void Write(
            Utf8JsonWriter writer, 
            DateTime value, 
            JsonSerializerOptions options) {

            writer.WriteStringValue(value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
        }
    }
}
