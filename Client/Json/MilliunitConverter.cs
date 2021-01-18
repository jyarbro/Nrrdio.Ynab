using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Json {
    public class MilliunitConverter : JsonConverter<decimal> {
        public override decimal Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) {

            var valueString = reader.GetString();
            var value = Convert.ToInt64(valueString);

            return value / 1000m;
        }

        public override void Write(
            Utf8JsonWriter writer, 
            decimal value, 
            JsonSerializerOptions options) {

            var milliunitValue = Convert.ToInt64(value * 1000);

            writer.WriteStringValue(milliunitValue.ToString(CultureInfo.InvariantCulture));
        }
    }
}
