namespace Nrrdio.Ynab.Client.Models.Requests.Transactions {
    public class SaveTransactionsQuery {
        public string? BudgetId { get; set; }
        public SaveTransactionsWrapper? Data { get; set; }
    }
}
