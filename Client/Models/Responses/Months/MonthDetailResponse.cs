namespace Nrrdio.Ynab.Client.Models.Responses.Months {
    public class MonthDetailResponse {
        public MonthDetailResponseData? Data { get; set; }

        public class MonthDetailResponseData {
            public MonthDetail? Month { get; set; }
        }
    }
}
