using System.Globalization;
using System.Text.Json;

namespace Nrrdio.Ynab.Client.Json {
    class SnakeToPascalNamingPolicy : JsonNamingPolicy {
        public override string ConvertName(string name) => new CultureInfo("en-US", false).TextInfo.ToTitleCase(name).Replace("_", string.Empty);
    }
}
