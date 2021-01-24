namespace Nrrdio.Ynab.Client.Models.Api.Payees {
    public class PayeeLocationResponse {
        public PayeeLocationResponseData Data { get; set; }

        public class PayeeLocationResponseData {
            public PayeeLocation PayeeLocation { get; set; }
        }
    }
}
