namespace Nrrdio.Ynab.Client.Models.Requests.Transactions {
    public class SaveTransactionsRequest {
        public string? BudgetId { get; set; }
        public SaveTransactionsWrapper? Data { get; set; }
    }
}
