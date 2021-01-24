using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Api.Categories {
    public class CategoryGroupWithCategories {
        public string Id { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Whether or not the category group is hidden
        /// </summary>
        public bool Hidden { get; set; }

        /// <summary>
        /// Whether or not the category group has been deleted. Deleted category groups will only be included in delta requests.
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// Category group categories. Amounts (budgeted, activity, balance, etc.) are specific to the current budget month (UTC).
        /// </summary>
        public List<Category> Categories { get; set; }
    }
}
