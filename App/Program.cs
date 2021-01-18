using App.Models.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Nrrdio.Utilities.Loggers;
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

        services.Configure<YnabOptions>((options) => {
            host.Configuration.GetSection(YnabOptions.Section).Bind(options);
        });

        services.AddSingleton<ILoggerProvider, ColorConsoleLoggerProvider>();
        services.AddLogging();
    })
    .Build()
    .RunAsync();

public class AppHost : IHostedService {
    public AppHost(
    ) {
    }

    public Task StartAsync(CancellationToken cancellationToken) => Task.CompletedTask;

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
}
