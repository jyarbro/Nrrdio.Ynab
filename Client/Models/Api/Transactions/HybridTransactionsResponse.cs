using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Api.Transactions {
    public class HybridTransactionsResponse {
        public HybridTransactionsResponseData Data { get; set; }

        public class HybridTransactionsResponseData {
            public List<HybridTransaction> Transactions { get; set; }
        }
    }
}
