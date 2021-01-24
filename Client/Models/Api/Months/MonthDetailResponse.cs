namespace Nrrdio.Ynab.Client.Models.Api.Months {
    public class MonthDetailResponse {
        public MonthDetailResponseData Data { get; set; }

        public class MonthDetailResponseData {
            public MonthDetail Month { get; set; }
        }
    }
}
