using Nrrdio.Ynab.Client.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.ScheduledTransactions {
    public class ScheduledSubTransaction {
        public string Id { get; set; }
        public string ScheduledTransactionId { get; set; }

        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Amount { get; set; }

        public string Memo { get; set; }
        public string PayeeId { get; set; }
        public string CategoryId { get; set; }

        /// <summary>
        /// If a transfer, the account_id which the scheduled subtransaction transfers to
        /// </summary>
        public string TransferAccountId { get; set; }

        /// <summary>
        /// Whether or not the scheduled subtransaction has been deleted. Deleted scheduled subtransactions will only be included in delta requests.
        /// </summary>
        public bool Deleted { get; set; }
    }
}
