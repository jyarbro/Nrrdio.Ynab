using App.Models.Options;
using Microsoft.Extensions.Options;
using Nrrdio.Ynab.Client.Models.Users;
using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services {
    public class UserService {
        string ResourceUrl { get; init; }
        YnabApiService Ynab { get; init; }

        public UserService(
            IOptions<YnabHostOptions> hostOptions,
            YnabApiService apiService
        ) {
            ResourceUrl = $"{hostOptions.Value.EndPoint}/user";
            Ynab = apiService;
        }

        public async Task<User> GetUser() => await Ynab.GetRequest<User>(ResourceUrl);
    }
}
