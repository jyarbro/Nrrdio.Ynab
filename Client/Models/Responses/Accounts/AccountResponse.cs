namespace Nrrdio.Ynab.Client.Models.Responses.Accounts {
    public class AccountResponse {
        public AccountResponseData? Data { get; set; }

        public class AccountResponseData {
            public Account? Account { get; set; }
        }
    }
}
