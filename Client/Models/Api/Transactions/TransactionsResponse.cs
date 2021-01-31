using System.Collections.Generic;

namespace Nrrdio.Ynab.Client.Models.Api.Transactions {
    public class TransactionsResponse {
        public TransactionsResponseData Data { get; set; }

        public class TransactionsResponseData {
            public List<TransactionDetail> Transactions { get; set; }

            /// <summary>
            /// Used for delta requests
            /// </summary>
            public long ServerKnowledge { get; set; }
        }
    }
}

/*
 * Example
{
  "data": {
    "transactions": [
      {
        "id": "asdf1234-asdf-1234-asdf-1234asdf1234",
        "date": "1999-12-31",
        "amount": 20,
        "memo": null,
        "cleared": "reconciled",
        "approved": true,
        "flag_color": null,
        "account_id": "asdf1234-asdf-1234-asdf-1234asdf1234",
        "account_name": "Asdf 1234",
        "payee_id": "asdf1234-asdf-1234-asdf-1234asdf1234",
        "payee_name": "Asdf 1234",
        "category_id": "asdf1234-asdf-1234-asdf-1234asdf1234",
        "category_name": "Asdf 1234",
        "transfer_account_id": null,
        "transfer_transaction_id": null,
        "matched_transaction_id": null,
        "import_id": "YNAB:1234:1999-12-31:1",
        "deleted": false,
        "subtransactions": []
      },
      {
        "id": "asdf1235-asdf-1235-asdf-1235asdf1235",
        "date": "1999-12-31",
        "amount": -12100,
        "memo": null,
        "cleared": "uncleared",
        "approved": true,
        "flag_color": null,
        "account_id": "asdf1235-asdf-1235-asdf-1235asdf1235",
        "account_name": "Asdf 1235",
        "payee_id": "asdf1235-asdf-1235-asdf-1235asdf1235",
        "payee_name": "Asdf 1234",
        "category_id": "asdf1235-asdf-1235-asdf-1235asdf1235",
        "category_name": "Asdf 1235",
        "transfer_account_id": null,
        "transfer_transaction_id": null,
        "matched_transaction_id": null,
        "import_id": "YNAB:1235:1999-12-31:1",
        "deleted": false,
        "subtransactions": []
      }
    ],
    "server_knowledge": 54321
  }
}

 */
