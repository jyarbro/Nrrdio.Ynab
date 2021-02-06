using Nrrdio.Ynab.Client.Helpers.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Queries.Months {
    public class SaveMonthCategory {
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal? Budgeted { get; set; }
    }
}
