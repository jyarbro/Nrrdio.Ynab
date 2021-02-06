namespace Nrrdio.Ynab.Client.Models.Responses.Payees {
    public class Payee {
        public string Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// If a transfer payee, the account_id to which this payee transfers to
        /// </summary>
        public string TransferAccountId { get; set; }

        /// <summary>
        /// Whether or not the payee has been deleted. Deleted payees will only be included in delta requests.
        /// </summary>
        public bool Deleted { get; set; }
    }
}
