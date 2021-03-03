using App.Models.Options;
using Microsoft.Extensions.Options;
using Nrrdio.Ynab.Client.Models.Data.Users;
using Nrrdio.Ynab.Client.Models.Responses.Users;
using Nrrdio.Ynab.Client.Services.Contracts;
using System;
using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services {
    public class UserService {
        YnabHostOptions HostOptions { get; init; }
        IYnabApiService Ynab { get; init; }

        public UserService(
            IOptions<YnabHostOptions> hostOptions,
            IYnabApiService apiService
        ) {
            HostOptions = hostOptions.Value;
            Ynab = apiService;
        }

        public async Task<User> GetUser() {
            var url = $"{HostOptions.EndPoint}/user";
            var response = await Ynab.Download<UserResponse>(url);

            if (response?.Data?.User is null) {
                throw new Exception("Unexpected null response returned from API.");
            }

            return response.Data.User;
        }
    }
}
