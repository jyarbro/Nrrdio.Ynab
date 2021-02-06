using App.Models.Options;
using Microsoft.Extensions.Options;
using Nrrdio.Ynab.Client.Models.Data.Users;
using Nrrdio.Ynab.Client.Models.Responses.Users;
using Nrrdio.Ynab.Client.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services {
    public class UserService {
        string ResourceUrl { get; init; }
        IYnabApiService Ynab { get; init; }

        public UserService(
            IOptions<YnabHostOptions> hostOptions,
            IYnabApiService apiService
        ) {
            ResourceUrl = $"{hostOptions.Value.EndPoint}/user";
            Ynab = apiService;
        }

        public async Task<User> GetUser() {
            var response = await Ynab.GetRequest<UserResponse>(ResourceUrl);

            if (response?.Data?.User is null) {
                throw new Exception("Unexpected response returned from API.");
            }

            return response.Data.User;
        }
    }
}
