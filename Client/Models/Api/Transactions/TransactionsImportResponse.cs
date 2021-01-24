using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Api.Transactions {
    public class TransactionsImportResponse {
        public TransactionsImportResponseData Data { get; set; }

        public class TransactionsImportResponseData {
            public List<string> TransactionIds { get; set; }
        }
    }
}
