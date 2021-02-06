namespace Nrrdio.Ynab.Client.Models.Data.Errors {
    public class ErrorDetail {
        // Note: While the API refers to this ID as being a string, so far it appears that all results are HTTP status code integers.
        public int? Id { get; set; }
        public string? Name { get; set; }
        public string? Detail { get; set; }
    }

    /*
     * Example:
     * 
        {
          "error": {
            "id": "401",
            "name": "unauthorized",
            "detail": "Unauthorized"
          }
        }
     */
}
