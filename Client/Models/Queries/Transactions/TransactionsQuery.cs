﻿using Nrrdio.Ynab.Client.Helpers.Json;
using Nrrdio.Ynab.Client.Options;
using System;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Queries.Transactions {
    public class TransactionsQuery {
        public string BudgetId { get; set; }

        /// <summary>
        /// If specified, only transactions on or after this date will be included. The date should be ISO formatted (e.g. 2016-12-30).
        /// </summary>
        [JsonConverter(typeof(IsoDateConverter))]
        public DateTime? SinceDate { get; set; }

        /// <summary>
        /// If specified, only transactions of the specified type will be included. “uncategorized” and “unapproved” are currently supported.
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public TransactionCategorizedApproved? Type { get; set; }

        /// <summary>
        /// The starting server knowledge. If provided, only entities that have changed since last_knowledge_of_server will be included.
        /// </summary>
        public long? LastKnowledgeOfServer { get; set; }
    }
}
