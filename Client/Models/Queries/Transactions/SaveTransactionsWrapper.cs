﻿using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Queries.Transactions {
    public class SaveTransactionsWrapper {
        public SaveTransaction? Transaction { get; set; }
        public List<SaveTransaction>? Transactions { get; set; }
    }
}