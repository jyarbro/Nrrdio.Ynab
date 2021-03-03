using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nrrdio.Utilities.Web.Requests;
using Nrrdio.Ynab.Client.Models.Responses.Payees;
using Nrrdio.Ynab.Client.Models.Responses.Users;
using System.Text.Json;

namespace Tests {
    [TestClass]
    public class JsonHelperTests {
        [TestMethod]
        public void NamingPolicyNotNull() {
            var userResponse = JsonSerializer.Deserialize<UserResponse>(@"
                {
                    ""data"": {
                        ""user"": {
                            ""id"": ""asdf1234-asdf-1234-asdf-1234asdf1234""
                        }
                    }
                }", PascalToSnakeNamingPolicy.Options);

            Assert.IsNotNull(userResponse.Data);
        }

        [TestMethod]
        public void NamingPolicyCorrectValue() {
            var userResponse = JsonSerializer.Deserialize<UserResponse>(@"
                {
                    ""data"": {
                        ""user"": {
                            ""id"": ""asdf1234-asdf-1234-asdf-1234asdf1234""
                        }
                    }
                }", PascalToSnakeNamingPolicy.Options);

            Assert.AreEqual("asdf1234-asdf-1234-asdf-1234asdf1234", userResponse.Data.User.Id);
        }

        [TestMethod]
        public void NamingPolicyWithUnderscores() {
            var payeeResponse = JsonSerializer.Deserialize<PayeeResponse>(@"
                    {
                      ""data"": {
                        ""payee"": {
                          ""id"": ""asdf1234-asdf-1234-asdf-1234asdf1234"",
                          ""name"": ""Asdf 1234"",
                          ""transfer_account_id"": null,
                          ""deleted"": false
                        }
                      }
                    }
                ", PascalToSnakeNamingPolicy.Options);

            Assert.AreEqual("asdf1234-asdf-1234-asdf-1234asdf1234", payeeResponse.Data.Payee.Id);
        }
    }
}
