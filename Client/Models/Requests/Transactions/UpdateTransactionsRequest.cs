namespace Nrrdio.Ynab.Client.Models.Requests.Transactions {
    public class UpdateTransactionsRequest {
        public string? BudgetId { get; set; }
        public UpdateTransactionsWrapper? Data { get; set; }
    }
}
