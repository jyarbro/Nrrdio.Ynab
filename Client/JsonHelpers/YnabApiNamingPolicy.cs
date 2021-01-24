using System.Globalization;
using System.Linq;
using System.Text.Json;

namespace Nrrdio.Ynab.Client.JsonHelpers {
    public class SnakeToPascalNamingPolicy : JsonNamingPolicy {
        public override string ConvertName(string name) => new CultureInfo("en-US", false).TextInfo.ToTitleCase(name).Replace("_", string.Empty);

        public static JsonSerializerOptions Options => new JsonSerializerOptions {
            PropertyNamingPolicy = new SnakeToPascalNamingPolicy()
        };
    }

    public class PascalToSnakeNamingPolicy : JsonNamingPolicy {
        public override string ConvertName(string name) => string.Concat(name.Select((x, i) => i > 0 && char.IsUpper(x) ? "_" + x.ToString() : x.ToString())).ToLower();

        public static JsonSerializerOptions Options => new JsonSerializerOptions {
            PropertyNamingPolicy = new PascalToSnakeNamingPolicy()
        };
    }
}
