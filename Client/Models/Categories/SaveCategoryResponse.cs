namespace Nrrdio.Ynab.Client.Models.Categories {
    public class SaveCategoryResponse {
        public SaveCategoryResponseData Data { get; set; }

        public class SaveCategoryResponseData {
            public Category Category { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long ServerKnowledge { get; set; }
        }
    }
}
