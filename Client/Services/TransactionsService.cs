using App.Models.Options;
using Microsoft.Extensions.Options;
using Nrrdio.Ynab.Client.Models.Data.Transactions;
using Nrrdio.Ynab.Client.Models.Requests.Transactions;
using Nrrdio.Ynab.Client.Models.Responses.Transactions;
using Nrrdio.Ynab.Client.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        public async Task<List<TransactionDetail>> GetTransactions(TransactionsRequest? request = null) {
            var url = $"{HostOptions.EndPoint}/budgets/{{0}}/transactions";

            TransactionsResponse? response;

            if (request is null) {
                url = string.Format(url, HostOptions.BudgetId);
                response = await Ynab.Download<TransactionsResponse>(url);
            }
            else {
                if (request.BudgetId is not { Length: > 0 }) {
                    request.BudgetId = HostOptions.BudgetId;
                }

                url = string.Format(url, request.BudgetId);
                response = await Ynab.Download<TransactionsResponse>(url, request);
            }

            if (response?.Data?.Transactions is null) {
                throw new Exception("Unexpected null response returned from API.");
            }

            return response.Data.Transactions;
        }

        public async Task<TransactionDetail> GetTransaction(TransactionRequest request) {
            if (request.TransactionId is not { Length: > 0 }) {
                throw new ArgumentNullException();
            }

            var url = $"{HostOptions.EndPoint}/budgets/{{0}}/transactions/{{1}}";

            if (request.BudgetId is { Length: > 0 }) {
                url = string.Format(url, HostOptions.BudgetId, request.TransactionId);
            }
            else {
                url = string.Format(url, request.BudgetId, request.TransactionId);
            }

            var response = await Ynab.Download<TransactionResponse>(url);

            if (response?.Data is null) {
                throw new Exception("Unexpected null response returned from API.");
            }

            return response.Data;
        }

        public async Task<SaveTransactionsResponse> CreateTransactions(SaveTransactionsRequest request) {
            if (request?.Data is null) {
                throw new ArgumentNullException();
            }

            if (request.Data.Transaction is not null && request.Data.Transactions is not null) {
                throw new ArgumentException($"{nameof(SaveTransactionsWrapper.Transaction)} and {nameof(SaveTransactionsWrapper.Transactions)} cannot both be defined.");
            }

            var url = $"{HostOptions.EndPoint}/budgets/{{0}}/transactions";

            if (request.BudgetId is { Length: > 0 }) {
                url = string.Format(url, request.BudgetId);
            }
            else {
                url = string.Format(url, HostOptions.BudgetId);
            }

            return await Ynab.Upload<SaveTransactionsResponse>(url, request.Data, "POST");
        }

        public async Task<SaveTransactionsResponse> UpdateTransactions(UpdateTransactionsRequest request) {
            if (request?.Data?.Transactions is null) {
                throw new ArgumentNullException();
            }

            var url = $"{HostOptions.EndPoint}/budgets/{{0}}/transactions";

            if (request.BudgetId is { Length: > 0 }) {
                url = string.Format(url, request.BudgetId);
            }
            else {
                url = string.Format(url, HostOptions.BudgetId);
            }

            return await Ynab.Upload<SaveTransactionsResponse>(url, request.Data, "PATCH");
        }
    }
}
