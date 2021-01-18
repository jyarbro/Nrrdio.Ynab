using Nrrdio.Ynab.Client.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Transactions {
    public class SaveSubTransaction {
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Amount { get; set; }

        /// <summary>
        /// The payee for the subtransaction.
        /// </summary>
        public string PayeeId { get; set; }

        /// <summary>
        /// The payee name. If a payee_name value is provided and payee_id has a null value, the payee_name value will be used to resolve the payee by either (1) a matching payee rename rule (only if import_id is also specified on parent transaction) or (2) a payee with the same name or (3) creation of a new payee.
        /// maxLength: 50
        /// </summary>
        public string PayeeName { get; set; }

        /// <summary>
        /// The category for the subtransaction. Credit Card Payment categories are not permitted and will be ignored if supplied.
        /// </summary>
        public string CategoryId { get; set; }

        /// <summary>
        /// maxLength: 200
        /// </summary>
        public string Memo { get; set; }
    }
}
