using Nrrdio.Ynab.Client.Models.Data.Transactions;

namespace Nrrdio.Ynab.Client.Models.Responses.Transactions {
    public class TransactionResponse {
        public TransactionResponseData? Data { get; set; }

        public class TransactionResponseData {
            public TransactionDetail? Transaction { get; set; }
        }
    }
}
