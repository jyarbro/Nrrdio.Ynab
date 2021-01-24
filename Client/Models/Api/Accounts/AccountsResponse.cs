using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Api.Accounts {
    public class AccountsResponse {
        public AccountsResponseData Data { get; set; }

        public class AccountsResponseData {
            public List<Account> Accounts { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long ServerKnowledge { get; set; }
        }
    }
}
