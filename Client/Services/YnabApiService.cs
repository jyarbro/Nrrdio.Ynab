using Nrrdio.Utilities.Web;
using Nrrdio.Utilities.Web.Models.Errors;
using Nrrdio.Utilities.Web.Requests;
using Nrrdio.Ynab.Client.Models.Responses.Errors;
using Nrrdio.Ynab.Client.Services.Contracts;
using System;
using System.Text.Json;
using System.Threading.Tasks;

namespace Nrrdio.Ynab.Client.Services {
    public class YnabApiService : IYnabApiService {
        GzipWebClient WebClient { get; init; }

        public YnabApiService(
            GzipWebClient webClient
        ) {
            WebClient = webClient;
        }

        public async Task<T?> GetRequest<T>(string url) {
            var result = await WebClient.DownloadStringSafe(url);

            try {
                return JsonSerializer.Deserialize<T>(result);
            }
            // Assume that a JSON exception means the result is of an ErrorResponse model instead.
            catch (JsonException) {
                var error = JsonSerializer.Deserialize<ErrorResponse>(result);

                if (error?.Error is null) {
                    error = new ErrorResponse {
                        Error = new Models.Data.Errors.ErrorDetail {
                            Id = 500,
                            Detail = "An unexpected error occurred",
                            Name = "Error processing API error details"
                        }
                    };
                }

                var httpErrorType = HttpErrorSelector.Get(error.Error.Id ?? 500);

                var httpError = Activator.CreateInstance(httpErrorType, $"{error.Error.Name} ({error.Error.Id}): {error.Error.Detail}");

                if (httpError is HttpException) {
                    throw (HttpException) httpError;
                }

                throw new Exception("No suitable HttpException type matched the request error.", new Exception($"{error.Error.Name} ({error.Error.Id}): {error.Error.Detail}"));
            }
        }

        public async Task<T?> GetRequest<T>(string url, object queryParameters) {
            if (queryParameters is not null) {
                var query = QuerySerializer.Serialize(queryParameters, new PascalToSnakeNamingPolicy());

                if (url.Contains('?')) {
                    url = $"{url}&{query}";
                }
                else {
                    url = $"{url}?{query}";
                }
            }

            return await GetRequest<T>(url);
        }

        public async Task<T> PostRequest<T>(string url, object requestData) {
            var response = await WebClient.UploadJSObject(url, "POST", requestData);
            var result = JsonSerializer.Deserialize<T>(response);

            if (result is null) {
                if (response.Length > 0) {
                    throw new Exception("Unexpected error when posting request.");
                }
                else {
                    throw new Exception("API returned an unexpected empty response.");
                }
            }

            return result;
        }
    }
}
