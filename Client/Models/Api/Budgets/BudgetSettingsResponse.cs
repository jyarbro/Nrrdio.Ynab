namespace Nrrdio.Ynab.Client.Models.Responses.Budgets {
    public class BudgetSettingsResponse {
        public BudgetSettingsResponseData? Data { get; set; }

        public class BudgetSettingsResponseData {
            public BudgetSettings? Settings { get; set; }
        }
    }
}
