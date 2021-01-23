namespace Nrrdio.Ynab.Client.Models.Errors {
    public class ErrorDetail {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
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
