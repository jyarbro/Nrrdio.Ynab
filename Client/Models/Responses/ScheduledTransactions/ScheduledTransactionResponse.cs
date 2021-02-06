namespace Nrrdio.Ynab.Client.Models.Responses.ScheduledTransactions {
    public class ScheduledTransactionResponse {
        public ScheduledTransactionResponseData? Data { get; set; }

        public class ScheduledTransactionResponseData {
            public ScheduledTransactionDetail? ScheduledTransaction { get; set; }
        }
    }
}
