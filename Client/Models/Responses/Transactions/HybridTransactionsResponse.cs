using Nrrdio.Ynab.Client.Models.Data.Transactions;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Transactions {
    public class HybridTransactionsResponse {
        public HybridTransactionsResponseData? Data { get; set; }

        public class HybridTransactionsResponseData {
            public List<HybridTransaction>? Transactions { get; set; }
        }
    }
}
