using System;
using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Helpers.Json {
    public class MilliunitConverter : JsonConverter<decimal> {
        public override decimal Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options) {

            long value;

            try {
                value = reader.GetInt64();
            }
            catch (InvalidOperationException) {
                var valueString = reader.GetString();
                value = Convert.ToInt64(valueString);
            }

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
