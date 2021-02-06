using Nrrdio.Ynab.Client.Models.Data.Accounts;
using Nrrdio.Ynab.Client.Models.Data.Categories;
using Nrrdio.Ynab.Client.Models.Data.Months;
using Nrrdio.Ynab.Client.Models.Data.Payees;
using Nrrdio.Ynab.Client.Models.Data.ScheduledTransactions;
using Nrrdio.Ynab.Client.Models.Data.Transactions;
using System;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Data.Budgets {
    public class BudgetDetail {
        public string? Id { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// The last time any changes were made to the budget from either a web or mobile client
        /// </summary>
        public DateTime? LastModifiedOn { get; set; }

        /// <summary>
        /// The earliest budget month
        /// </summary>
        public DateTime? FirstMonth { get; set; }

        /// <summary>
        /// The latest budget month
        /// </summary>
        public DateTime? LastMonth { get; set; }

        public DateFormat? DateFormat { get; set; }
        public CurrencyFormat? CurrencyFormat { get; set; }

        /// <summary>
        /// The budget accounts(only included if include_accounts = true specified as query parameter)
        /// </summary>
        public List<Account>? Accounts { get; set; }
        public Account? Account { get; set; }
        public List<Payee>? Payees { get; set; }
        public List<PayeeLocation>? PayeeLocations { get; set; }
        public List<CategoryGroup>? CategoryGroups { get; set; }
        public List<Category>? Categories { get; set; }
        public List<MonthDetail>? Months { get; set; }
        public List<TransactionSummary>? Transactions { get; set; }
        public List<SubTransaction>? Subtransactions { get; set; }
        public List<ScheduledTransactionSummary>? ScheduledTransactions { get; set; }
        public List<ScheduledSubTransaction>? ScheduledSubtransactions { get; set; }
    }
}
