namespace Nrrdio.Ynab.Client.Models.Api.Budgets {
    public class BudgetSettingsResponse {
        public BudgetSettingsResponseData Data { get; set; }

        public class BudgetSettingsResponseData {
            public BudgetSettings Settings { get; set; }
        }
    }
}
