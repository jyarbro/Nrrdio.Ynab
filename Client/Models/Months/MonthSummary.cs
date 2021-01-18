﻿using Nrrdio.Ynab.Client.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Models.Months {
    public class MonthSummary {
        public DateTime Month { get; set; }
        public string Note { get; set; }

        /// <summary>
        /// The total amount of transactions categorized to ‘Inflow: To be Budgeted’ in the month
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Income { get; set; }

        /// <summary>
        /// The total amount budgeted in the month
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Budgeted { get; set; }

        /// <summary>
        /// The total amount of transactions in the month, excluding those categorized to ‘Inflow: To be Budgeted’
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal Activity { get; set; }

        /// <summary>
        /// The available amount for ‘To be Budgeted’
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal ToBeBudgeted { get; set; }

        /// <summary>
        /// The Age of Money as of the month
        /// </summary>
        public int AgeOfMoney { get; set; }

        /// <summary>
        /// Whether or not the month has been deleted. Deleted months will only be included in delta requests.
        /// </summary>
        public bool Deleted { get; set; }
    }
}
