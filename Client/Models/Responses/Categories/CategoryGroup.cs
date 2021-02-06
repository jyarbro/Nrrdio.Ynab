namespace Nrrdio.Ynab.Client.Models.Responses.Categories {
    public class CategoryGroup {
        public string? Id { get; set; }
        public string? Name { get; set; }

        /// <summary>
        /// Whether or not the category group is hidden
        /// </summary>
        public bool? Hidden { get; set; }

        /// <summary>
        /// Whether or not the category group has been deleted. Deleted category groups will only be included in delta requests.
        /// </summary>
        public bool? Deleted { get; set; }
    }
}
