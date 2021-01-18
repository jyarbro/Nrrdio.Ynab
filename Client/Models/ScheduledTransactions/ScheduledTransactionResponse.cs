namespace Nrrdio.Ynab.Client.Models.ScheduledTransactions {
    public class ScheduledTransactionResponse {
        public ScheduledTransactionResponseData Data { get; set; }

        public class ScheduledTransactionResponseData {
            public ScheduledTransactionDetail ScheduledTransaction { get; set; }
        }
    }
}
