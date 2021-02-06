using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Transactions {
    public class TransactionsImportResponse {
        public TransactionsImportResponseData? Data { get; set; }

        public class TransactionsImportResponseData {
            public List<string>? TransactionIds { get; set; }
        }
    }
}
