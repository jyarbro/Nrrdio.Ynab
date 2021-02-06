using Nrrdio.Ynab.Client.Models.Data.Accounts;
using System;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Data.Budgets {
    public class BudgetSummary {
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
        /// The budget accounts (only included if include_accounts=true specified as query parameter)
        /// </summary>
        public List<Account>? Accounts { get; set; }
    }
}
