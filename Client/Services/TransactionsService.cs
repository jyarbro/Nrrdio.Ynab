using App.Models.Options;
using Microsoft.Extensions.Options;
using Nrrdio.Ynab.Client.Models.Api.Transactions;
using Nrrdio.Ynab.Client.Models.Queries.Transactions;
using Nrrdio.Ynab.Client.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services {
    public class TransactionsService {
        string ResourceUrl { get; init; }
        IYnabApiService Ynab { get; init; }

        public TransactionsService(
            IOptions<YnabHostOptions> hostOptions,
            IYnabApiService apiService
        ) {
            ResourceUrl = $"{hostOptions.Value.EndPoint}/budgets/{hostOptions.Value.BudgetId}/transactions";
            Ynab = apiService;
        }

        public async Task<List<TransactionDetail>> GetTransactions(TransactionsQuery query = null) {
            TransactionsResponse response;

            if (query is null) {
                response = await Ynab.GetRequest<TransactionsResponse>(ResourceUrl);
            }
            else {
                response = await Ynab.GetRequest<TransactionsResponse>(ResourceUrl, query);
            }

            return response?.Data?.Transactions;
        }

        public async Task<TransactionDetail> GetTransaction() {
            var response = await Ynab.GetRequest<TransactionResponse>(ResourceUrl);
            return response.Data.Transaction;
        }
    }
}
