using Nrrdio.Ynab.Client.Helpers.Json;
using Nrrdio.Ynab.Client.Options;
using System;
using System.Text.Json.Serialization;

namespace Nrrdio.Ynab.Client.Models.Responses.Categories {
    public class Category {
        public string? Id { get; set; }
        public string? CategoryGroupId { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// Whether or not the category is hidden
        /// </summary>
        public bool? Hidden { get; set; }

        /// <summary>
        /// If category is hidden this is the id of the category group it originally belonged to before it was hidden.
        /// </summary>
        public string? OriginalCategoryGroupId { get; set; }

        public string? Note { get; set; }

        [JsonConverter(typeof(MilliunitConverter))]
        public decimal? Budgeted { get; set; }

        [JsonConverter(typeof(MilliunitConverter))]
        public decimal? Activity { get; set; }

        [JsonConverter(typeof(MilliunitConverter))]
        public decimal? Balance { get; set; }

        /// <summary>
        /// The type of goal, if the category has a goal (TB=’Target Category Balance’, TBD=’Target Category Balance by Date’, MF=’Monthly Funding’, NEED=’Plan Your Spending’)
        /// </summary>
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public GoalType? GoalType { get; set; }

        /// <summary>
        /// The month a goal was created
        /// </summary>
        public DateTime? GoalCreationMonth { get; set; }

        /// <summary>
        /// The goal target amount
        /// </summary>
        [JsonConverter(typeof(MilliunitConverter))]
        public decimal? GoalTarget { get; set; }

        /// <summary>
        /// The target month for the goal to be completed. Only some goal types specify this date.
        /// </summary>
        public DateTime? GoalTargetMonth { get; set; }

        /// <summary>
        /// The percentage completion of the goal
        /// </summary>
        public int? GoalPercentageComplete { get; set; }

        /// <summary>
        /// Whether or not the category has been deleted. Deleted categories will only be included in delta requests.
        /// </summary>
        public bool? Deleted { get; set; }
    }
}
