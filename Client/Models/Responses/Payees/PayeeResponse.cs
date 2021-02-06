using Nrrdio.Ynab.Client.Models.Data.Payees;

namespace Nrrdio.Ynab.Client.Models.Responses.Payees {
    public class PayeeResponse {
        public PayeeResponseData? Data { get; set; }

        public class PayeeResponseData {
            public Payee? Payee { get; set; }
        }
    }

    /*
     * Example:
     * 
        {
          "data": {
            "payee": {
              "id": "asdf1234-asdf-1234-asdf-1234asdf1234",
              "name": "Asdf 1234",
              "transfer_account_id": null,
              "deleted": false
            }
          }
        }
    */
}
