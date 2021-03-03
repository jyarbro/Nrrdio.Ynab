using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services.Contracts {
    public interface IYnabApiService {
        Task<T?> Download<T>(string url);
        Task<T?> Download<T>(string url, object queryParameters);
        Task<T> Upload<T>(string url, object requestData, string method);
    }
}