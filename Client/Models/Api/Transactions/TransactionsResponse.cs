using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Api.Transactions {
    public class TransactionsResponse {
        public TransactionsResponseData Data { get; set; }

        public class TransactionsResponseData {
            public List<TransactionDetail> Transactions { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long ServerKnowledge { get; set; }
        }
    }
}
