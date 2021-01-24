namespace Nrrdio.Ynab.Client.Models.Api.Transactions {
    public class TransactionResponse {
        public TransactionResponseData Data { get; set; }

        public class TransactionResponseData {
            public TransactionDetail Transaction { get; set; }
        }
    }
}
