﻿using Nrrdio.Ynab.Client.Models.Data.Budgets;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Budgets {
    public class BudgetSummaryResponse {
        public BudgetSummaryResponseData? Data { get; set; }

        public class BudgetSummaryResponseData {
            public List<BudgetSummary>? Budgets { get; set; }
            public BudgetSummary? DefaultBudget { get; set; }
        }
    }
}
