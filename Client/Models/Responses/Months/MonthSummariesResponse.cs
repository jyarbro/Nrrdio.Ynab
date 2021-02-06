using Nrrdio.Ynab.Client.Models.Data.Months;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Months {
    public class MonthSummariesResponse {
        public MonthSummariesResponseData? Data { get; set; }

        public class MonthSummariesResponseData {
            public List<MonthSummary>? Months { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long? ServerKnowledge { get; set; }
        }
    }
}
