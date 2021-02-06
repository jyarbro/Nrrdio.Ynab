using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Categories {
    public class CategoriesResponse {
        public CategoriesResponse Data { get; set; }

        public class CategoriesResponseData {
            public List<CategoryGroupWithCategories> CategoryGroups { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long ServerKnowledge { get; set; }
        }
    }
}
