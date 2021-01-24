using Nrrdio.Ynab.Client.JsonHelpers;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Api.Transactions {
    public class SubTransaction {
        public string Id { get; set; }
        public string TransactionId { get; set; }

        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Amount { get; set; }

        public string Memo { get; set; }
        public string PayeeId { get; set; }
        public string PayeeName { get; set; }
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }

        /// <summary>
        /// If a transfer, the account_id which the subtransaction transfers to
        /// </summary>
        public string TransferAccountId { get; set; }

        /// <summary>
        /// If a transfer, the id of transaction on the other side of the transfer
        /// </summary>
        public string TransferTransactionId { get; set; }

        /// <summary>
        /// Whether or not the subtransaction has been deleted. Deleted scheduled subtransactions will only be included in delta requests.
        /// </summary>
        public bool Deleted { get; set; }
    }
}
