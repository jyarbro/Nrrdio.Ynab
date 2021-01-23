using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nrrdio.Utilities.Loggers;
using Nrrdio.Ynab.Client;
using System.Threading;
using System.Threading.Tasks;

await Host
    .CreateDefaultBuilder(args)
    .ConfigureHostConfiguration((config) => {
        config.AddEnvironmentVariables("DOTNET_");
    })
    .ConfigureAppConfiguration((host, config) => {
        config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
        config.AddJsonFile($"appsettings.{host.HostingEnvironment.EnvironmentName}.json", optional: true, reloadOnChange: true);

        config.AddEnvironmentVariables();

        if (args is not { Length: > 0 }) {
            config.AddCommandLine(args);
        }
    })
    .ConfigureServices((host, services) => {
        services.AddHostedService<AppHost>();

        services.AddSingleton<ILoggerProvider, ColorConsoleLoggerProvider>();
        services.AddLogging();

        services.AddYnabClient(host);
    })
    .Build()
    .RunAsync();

public class AppHost : IHostedService {
    YnabClient Client { get; init; }

    public AppHost(
        YnabClient client
    ) {
        Client = client;
    }

    public Task StartAsync(CancellationToken cancellationToken) {
        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
