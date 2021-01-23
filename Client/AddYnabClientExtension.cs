using App.Models.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Nrrdio.Utilities.Web.Models.Options;

namespace Nrrdio.Ynab.Client {
    public static class AddYnabClientExtension {
        public static void AddYnabClient(this IServiceCollection services, HostBuilderContext host) {
            services.Configure<YnabHostOptions>((options) => {
                host.Configuration.GetSection(YnabHostOptions.Section).Bind(options);
            });

            services.Configure<GzipWebClientOptions>((options) => {
                host.Configuration.GetSection(GzipWebClientOptions.Section).Bind(options);
            });

            services.AddSingleton<YnabClient>();
        }
    }
}
