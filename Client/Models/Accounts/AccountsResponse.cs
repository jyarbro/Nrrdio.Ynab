using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Accounts {
    public class AccountsResponse {
        public AccountsResponseData Data { get; set; }

        public class AccountsResponseData {
            public List<Account> Accounts { get; set; }

            /// <summary>
            /// The knowledge of the server
            /// </summary>
            public long ServerKnowledge { get; set; }
        }
    }
}
