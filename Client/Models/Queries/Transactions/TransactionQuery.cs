namespace Nrrdio.Ynab.Client.Models.Queries.Transactions {
    public class TransactionQuery {
        /// <summary>
        /// The id of the budget. “last-used” can be used to specify the last used budget and “default” can be used if default budget selection is enabled (see: https://api.youneedabudget.com/#oauth-default-budget).
        /// </summary>
        public string? BudgetId { get; set; }

        /// <summary>
        /// The id of the transaction
        /// </summary>
        public string TransactionId { get; set; } = "";
    }
}
