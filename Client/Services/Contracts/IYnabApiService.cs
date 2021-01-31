using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services.Contracts {
    public interface IYnabApiService {
        Task<T> GetRequest<T>(string url);
        Task<T> GetRequest<T>(string url, object queryParameters);
    }
}