namespace Nrrdio.Ynab.Client.Models.Transactions {
    public class TransactionResponse {
        public TransactionResponseData Data { get; set; }

        public class TransactionResponseData {
            public TransactionDetail Transaction { get; set; }
        }
    }
}
