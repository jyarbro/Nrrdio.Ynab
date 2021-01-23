using Nrrdio.Ynab.Client.JsonHelpers;
using Nrrdio.Ynab.Client.Options;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Accounts {
    public class Account {
        public string Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// The type of account. Note: payPal, merchantAccount, investmentAccount, and mortgage types have been deprecated and will be removed in the future.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public AccountType Type { get; set; }

        /// <summary>
        /// Whether this account is on budget or not
        /// </summary>
        public bool OnBudget { get; set; }

        /// <summary>
        /// Whether this account is closed or not
        /// </summary>
        public bool Closed { get; set; }

        public string Note { get; set; }

        /// <summary>
        /// The current balance of the account
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Balance { get; set; }

        /// <summary>
        /// The current cleared balance of the account
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal ClearedBalance { get; set; }

        /// <summary>
        /// The current uncleared balance of the account
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal UnclearedBalance { get; set; }

        /// <summary>
        /// The payee id which should be used when transferring to this account
        /// </summary>
        public string TransferPayeeId { get; set; }

        /// <summary>
        /// Whether or not the account has been deleted. Deleted accounts will only be included in delta requests.
        /// </summary>
        public bool Deleted { get; set; }
    }
}
