using Nrrdio.Ynab.Client.JsonHelpers;
using Nrrdio.Ynab.Client.Options;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Api.Accounts {
    public class SaveAccount {
        /// <summary>
        /// The name of the account
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The account type
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public AccountType Type { get; set; }

        /// <summary>
        /// The current balance of the account
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Balance { get; set; }
    }
}
