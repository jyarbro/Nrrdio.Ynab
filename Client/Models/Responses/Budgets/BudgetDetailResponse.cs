namespace Nrrdio.Ynab.Client.Models.Responses.Budgets {
    public class BudgetDetailResponse {
        public BudgetDetailResponseData? Data { get; set; }

        public class BudgetDetailResponseData {
            public BudgetDetail? Budget { get; set; }
            
            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long? ServerKnowledge { get; set; }
        }
    }
}
