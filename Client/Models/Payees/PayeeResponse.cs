namespace Nrrdio.Ynab.Client.Models.Payees {
    public class PayeeResponse {
        public PayeeResponseData Data { get; set; }

        public class PayeeResponseData {
            public Payee Payee { get; set; }
        }
    }
}
