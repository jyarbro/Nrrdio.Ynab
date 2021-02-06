using App.Models.Options;
using Microsoft.Extensions.Options;
using Nrrdio.Ynab.Client.Models.Responses.Transactions;
using Nrrdio.Ynab.Client.Models.Queries.Transactions;
using Nrrdio.Ynab.Client.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Nrrdio.Ynab.Client.Models.Data.Transactions;

namespace Nrrdio.Ynab.Client.Services {
    public class TransactionsService {
        YnabHostOptions HostOptions { get; init; }
        IYnabApiService Ynab { get; init; }

        public TransactionsService(
            IOptions<YnabHostOptions> hostOptions,
            IYnabApiService apiService
        ) {
            HostOptions = hostOptions.Value;
            Ynab = apiService;
        }

        public async Task<List<TransactionDetail>> GetTransactions(TransactionsQuery? query = null) {
            var url = $"{HostOptions.EndPoint}/budgets/{{0}}/transactions";
            
            TransactionsResponse response;

            if (query is null) {
                url = string.Format(url, HostOptions.BudgetId);
                response = await Ynab.GetRequest<TransactionsResponse>(url);
            }
            else {
                if (query.BudgetId is not { Length: >0 }) {
                    query.BudgetId = HostOptions.BudgetId;
                }

                url = string.Format(url, query.BudgetId);
                response = await Ynab.GetRequest<TransactionsResponse>(url, query);
            }

            if (response?.Data?.Transactions is null) {
                throw new Exception("Unexpected null response returned from API.");
            }

            return response.Data.Transactions;
        }

        public async Task<TransactionDetail> GetTransaction(TransactionQuery query) {
            if (query.TransactionId is not { Length: >0 }) {
                throw new ArgumentNullException();
            }

            var url = $"{HostOptions.EndPoint}/budgets/{{0}}/transactions/{{1}}";

            if (query.BudgetId is { Length: >0 }) {
                url = string.Format(url, HostOptions.BudgetId, query.TransactionId);
            }
            else {
                url = string.Format(url, query.BudgetId, query.TransactionId);
            }

            var response = await Ynab.GetRequest<TransactionResponse>(url);

            if (response?.Data is null) {
                throw new Exception("Unexpected null response returned from API.");
            }

            return response.Data;
        }
    }
}
