using Nrrdio.Ynab.Client.Helpers.Json;
using Nrrdio.Ynab.Client.Options;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Responses.Transactions {
    public class TransactionDetail {
        public string? Id { get; set; }

        /// <summary>
        /// The transaction date in ISO format (e.g. 2016-12-01)
        /// </summary>
        public DateTime? Date { get; set; }

        [JsonConverter(typeof(MilliunitConverter))]
        public decimal? Amount { get; set; }

        public string? Memo { get; set; }

        /// <summary>
        /// The cleared status of the transaction
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public ClearedState? Cleared { get; set; }

        /// <summary>
        /// Whether or not the transaction is approved
        /// </summary>
        public bool? Approved { get; set; }

        /// <summary>
        /// The transaction flag
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public FlagColor? FlagColor { get; set; }

        public string? AccountId { get; set; }
        public string? PayeeId { get; set; }
        public string? CategoryId { get; set; }

        /// <summary>
        /// If a transfer transaction, the account to which it transfers
        /// </summary>
        public string? TransferAccountId { get; set; }

        /// <summary>
        /// If a transfer transaction, the id of transaction on the other side of the transfer
        /// </summary>
        public string? TransferTransactionId { get; set; }

        /// <summary>
        /// If transaction is matched, the id of the matched transaction
        /// </summary>
        public string? MatchedTransactionId { get; set; }

        /// <summary>
        /// If the Transaction was imported, this field is a unique (by account) import identifier. If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: 'YNAB:[milliunit_amount]:[iso_date]:[occurrence]'. For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of 'YNAB:-294230:2015-12-30:1’. If a second transaction on the same account was imported and had the same date and same amount, its import_id would be 'YNAB:-294230:2015-12-30:2’.
        /// </summary>
        public string? ImportId { get; set; }

        /// <summary>
        /// Whether or not the transaction has been deleted. Deleted transactions will only be included in delta requests.
        /// </summary>
        public bool? Deleted { get; set; }

        public string? AccountName { get; set; }

        public string? PayeeName { get; set; }

        public string? CategoryName { get; set; }

        /// <summary>
        /// If a split transaction, the subtransactions.
        /// </summary>
        public List<SubTransaction>? Subtransactions { get; set; }
    }
}
