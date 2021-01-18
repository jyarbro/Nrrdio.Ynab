﻿using Nrrdio.Ynab.Client.Json;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Accounts {
    public class SaveAccount {
        /// <summary>
        /// The name of the account
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The account type
        /// </summary>
        public AccountType Type { get; set; }

        /// <summary>
        /// The current balance of the account
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Balance { get; set; }
    }
}
