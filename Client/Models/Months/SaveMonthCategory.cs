using Nrrdio.Ynab.Client.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Months {
    public class SaveMonthCategory {
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Budgeted { get; set; }
    }
}
