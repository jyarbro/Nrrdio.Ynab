using Nrrdio.Utilities.Web;
using Nrrdio.Utilities.Web.Models.Errors;
using Nrrdio.Ynab.Client.Models.Errors;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services {
    public class YnabApiService {
        GzipWebClient WebClient { get; init; }

        public YnabApiService(
            GzipWebClient webClient
        ) {
            WebClient = webClient;
        }

        public async Task<T> GetRequest<T>(string url) {
            var result = await WebClient.DownloadStringSafe(url);
            try {
                return JsonSerializer.Deserialize<T>(result);
            }
            // Assume that a JSON exception means the result is of an ErrorResponse model instead.
            catch (JsonException) {
                var error = JsonSerializer.Deserialize<ErrorResponse>(result);

                var httpErrorType = HttpErrorSelector.Get(error.Error.Id);

                var httpError = Activator.CreateInstance(httpErrorType, $"{error.Error.Name} ({error.Error.Id}): {error.Error.Detail}");

                if (httpError is HttpException) {
                    throw httpError as HttpException;
                }

                throw new Exception("No suitable HttpException type matched the request error.", new Exception($"{error.Error.Name} ({error.Error.Id}): {error.Error.Detail}"));
            }
        }
    }
}
