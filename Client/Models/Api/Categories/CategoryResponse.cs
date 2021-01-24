namespace Nrrdio.Ynab.Client.Models.Api.Categories {
    public class CategoryResponse {
        public CategoryResponseData Data { get; set; }

        public class CategoryResponseData {
            public Category Category { get; set; }
        }
    }
}
