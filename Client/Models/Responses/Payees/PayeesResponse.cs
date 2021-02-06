using Nrrdio.Ynab.Client.Models.Data.Payees;
using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Responses.Payees {
    public class PayeesResponse {
        public PayeesResponseData? Data { get; set; }

        public class PayeesResponseData {
            public List<Payee>? Payees { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long? ServerKnowledge { get; set; }
        }
    }

    /*
     * Example:
     * 
         {
           "data": {
             "payees": [
               {
                 "id": "asdf1234-asdf-1234-asdf-1234asdf1234",
                 "name": "Asdf 1234",
                 "transfer_account_id": null,
                 "deleted": false
               },
               {
                 "id": "asdf1235-asdf-1235-asdf-1235asdf1235",
                 "name": "Asdf 1235",
                 "transfer_account_id": null,
                 "deleted": false
               }
            ],
            "server_knowledge": 54321
          }
        }
    */
}
