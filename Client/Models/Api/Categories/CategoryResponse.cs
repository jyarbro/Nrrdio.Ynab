namespace Nrrdio.Ynab.Client.Models.Responses.Categories {
    public class CategoryResponse {
        public CategoryResponseData Data { get; set; }

        public class CategoryResponseData {
            public Category Category { get; set; }
        }
    }
}
