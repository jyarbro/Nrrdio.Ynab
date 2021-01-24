using App.Models.Options;
using Microsoft.Extensions.Options;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Nrrdio.Ynab.Client.JsonHelpers;
using Nrrdio.Ynab.Client.Models.Users;
using Nrrdio.Ynab.Client.Services;
using Nrrdio.Ynab.Client.Services.Contracts;
using System.Text.Json;

namespace Tests {
    [TestClass]
    public class UserServiceTests {
        [TestMethod]
        public void TestMethod1() {
            var userResponse = JsonSerializer.Deserialize<UserResponse>(@"
                {
                    ""data"": {
                        ""user"": {
                            ""id"": ""asdf1234-asdf-1234-asdf-1234asdf1234""
                        }
                    }
                }", SnakeToPascalNamingPolicy.Options);

            var mockOptions = new Mock<IOptions<YnabHostOptions>>();
            mockOptions.Setup(mock => mock.Value).Returns(new YnabHostOptions { EndPoint = string.Empty });

            var mockApiService = new Mock<IYnabApiService>();
            mockApiService.Setup(mock => mock.GetRequest<UserResponse>(It.IsAny<string>())).ReturnsAsync(userResponse);

            var userService = new UserService(mockOptions.Object, mockApiService.Object);
            var user = userService.GetUser();

            Assert.AreEqual("asdf1234-asdf-1234-asdf-1234asdf1234", user.Result.Id);
        }
    }
}
