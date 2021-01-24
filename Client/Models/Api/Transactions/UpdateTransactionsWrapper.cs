using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Api.Transactions {
    public class UpdateTransactionsWrapper {
        public List<UpdateTransaction> Transactions { get; set; }
    }
}
