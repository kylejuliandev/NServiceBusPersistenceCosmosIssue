using Microsoft.Extensions.Hosting;
using NServiceBus;
using NServiceBus.Logging;

var host = Host.CreateDefaultBuilder()
    .UseNServiceBus(context =>
    {
        var defaultLogger = LogManager.Use<DefaultFactory>();
        defaultLogger.Level(LogLevel.Debug);

        var config = new EndpointConfiguration("Shipping");
        config.UseTransport<LearningTransport>();

        return config;
    });

await host.RunConsoleAsync();