namespace Nrrdio.Ynab.Client.Models.Api.Payees {
    public class PayeeLocation {
        public string Id { get; set; }
        public string PayeeId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        /// <summary>
        /// Whether or not the payee location has been deleted.Deleted payee locations will only be included in delta requests.
        /// </summary>
        public bool Deleted { get; set; }
    }
}
