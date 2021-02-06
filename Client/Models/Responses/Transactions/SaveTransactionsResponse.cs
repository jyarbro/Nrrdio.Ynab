using Nrrdio.Ynab.Client.Models.Data.Transactions;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Transactions {
    public class SaveTransactionsResponse {
        public SaveTransactionsResponseData? Data { get; set; }
        
        public class SaveTransactionsResponseData {
            /// <summary>
            /// The transaction ids that were saved
            /// </summary>
            public List<string>? TransactionIds { get; set; }

            public TransactionDetail? Transaction { get; set; }

            /// <summary>
            /// If multiple transactions were specified, the transactions that were saved
            /// </summary>
            public List<TransactionDetail>? Transactions { get; set; }

            /// <summary>
            /// If multiple transactions were specified, a list of import_ids that were not created because of an existing import_id found on the same account
            /// </summary>
            public List<string>? DuplicateImportIds { get; set; }
            
            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long? ServerKnowledge { get; set; }
        }
    }
}
