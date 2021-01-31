using App.Models.Options;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Nrrdio.Utilities.Web.Query;
using Nrrdio.Ynab.Client.Models.Api.Transactions;
using Nrrdio.Ynab.Client.Models.Queries.Transactions;
using Nrrdio.Ynab.Client.Services;
using Nrrdio.Ynab.Client.Services.Contracts;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tests {
    [TestClass]
    public class TransactionsServiceTests {
        [TestMethod]
        public async Task GetTransactions() {
            var response = JsonSerializer.Deserialize<TransactionsResponse>(@"
                {
                    ""data"": {
                    ""transactions"": [
                        {
                            ""id"": ""asdf1234-asdf-1234-asdf-1234asdf1234"",
                            ""date"": ""1999-12-31"",
                            ""amount"": 20,
                            ""memo"": null,
                            ""cleared"": ""reconciled"",
                            ""approved"": true,
                            ""flag_color"": null,
                            ""account_id"": ""asdf1234-asdf-1234-asdf-1234asdf1234"",
                            ""account_name"": ""Asdf 1234"",
                            ""payee_id"": ""asdf1234-asdf-1234-asdf-1234asdf1234"",
                            ""payee_name"": ""Asdf 1234"",
                            ""category_id"": ""asdf1234-asdf-1234-asdf-1234asdf1234"",
                            ""category_name"": ""Asdf 1234"",
                            ""transfer_account_id"": null,
                            ""transfer_transaction_id"": null,
                            ""matched_transaction_id"": null,
                            ""import_id"": ""YNAB:1234:1999-12-31:1"",
                            ""deleted"": false,
                            ""subtransactions"": []
                        },
                        {
                            ""id"": ""asdf1235-asdf-1235-asdf-1235asdf1235"",
                            ""date"": ""1999-12-31"",
                            ""amount"": -12100,
                            ""memo"": null,
                            ""cleared"": ""uncleared"",
                            ""approved"": true,
                            ""flag_color"": null,
                            ""account_id"": ""asdf1235-asdf-1235-asdf-1235asdf1235"",
                            ""account_name"": ""Asdf 1235"",
                            ""payee_id"": ""asdf1235-asdf-1235-asdf-1235asdf1235"",
                            ""payee_name"": ""Asdf 1234"",
                            ""category_id"": ""asdf1235-asdf-1235-asdf-1235asdf1235"",
                            ""category_name"": ""Asdf 1235"",
                            ""transfer_account_id"": null,
                            ""transfer_transaction_id"": null,
                            ""matched_transaction_id"": null,
                            ""import_id"": ""YNAB:1235:1999-12-31:1"",
                            ""deleted"": false,
                            ""subtransactions"": []
                        }
                    ],
                    ""server_knowledge"": 54321
                    }
                }", PascalToSnakeNamingPolicy.Options);

            var mockOptions = new Mock<IOptions<YnabHostOptions>>();
            mockOptions.Setup(mock => mock.Value).Returns(new YnabHostOptions { EndPoint = string.Empty, BudgetId = "zxcv3214-zxcv-3214-zxcv-3214zxcv3214" });

            var mockApiService = new Mock<IYnabApiService>();
            mockApiService.Setup(mock => mock.GetRequest<TransactionsResponse>(It.IsAny<string>())).ReturnsAsync(response);

            var service = new TransactionsService(mockOptions.Object, mockApiService.Object);
            var result = await service.GetTransactions();

            Assert.IsNotNull(result);
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("asdf1234-asdf-1234-asdf-1234asdf1234", result[0].Id);
        }
    }
}
