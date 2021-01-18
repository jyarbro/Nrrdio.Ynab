using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Payees {
    public class PayeesResponse {
        public PayeesResponseData Data { get; set; }

        public class PayeesResponseData {
            public List<Payee> Payees { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long ServerKnowledge { get; set; }
        }
    }
}
