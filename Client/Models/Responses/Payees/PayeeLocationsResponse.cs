using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Payees {
    public class PayeeLocationsResponse {
        public PayeeLocationsResponseData? Data { get; set; }

        public class PayeeLocationsResponseData {
            public List<PayeeLocation>? PayeeLocations { get; set; }
        }
    }
}
