using Nrrdio.Ynab.Client.Helpers.Json;
using Nrrdio.Ynab.Client.Options;
using System;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Responses.ScheduledTransactions {
    public class ScheduledTransactionSummary {
        public string? Id { get; set; }

        /// <summary>
        /// The first date for which the Scheduled Transaction was scheduled.
        /// </summary>
        public DateTime? DateFirst { get; set; }

        /// <summary>
        /// The next date for which the Scheduled Transaction is scheduled.
        /// </summary>
        public DateTime? DateNext { get; set; }

        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public Frequency? Frequency { get; set; }

        /// <summary>
        /// The scheduled transaction amount
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal? Amount { get; set; }

        public string? Memo { get; set; }

        /// <summary>
        /// The scheduled transaction flag
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public FlagColor? FlagColor { get; set; }

        public string? AccountId { get; set; }
        public string? PayeeId { get; set; }
        public string? CategoryId { get; set; }

        /// <summary>
        /// If a transfer, the account_id which the scheduled transaction transfers to
        /// </summary>
        public string? TransferAccountId { get; set; }

        /// <summary>
        /// Whether or not the scheduled transaction has been deleted. Deleted scheduled transactions will only be included in delta requests.
        /// </summary>
        public bool? Deleted { get; set; }
    }
}
