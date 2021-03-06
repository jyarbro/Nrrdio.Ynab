﻿using Nrrdio.Ynab.Client.Models.Data.ScheduledTransactions;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.ScheduledTransactions {
    public class ScheduledTransactionsResponse {
        public ScheduledTransactionsResponseData? Data { get; set; }

        public class ScheduledTransactionsResponseData {
            public List<ScheduledTransactionDetail>? ScheduledTransactions { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long? ServerKnowledge { get; set; }
        }
    }
}
