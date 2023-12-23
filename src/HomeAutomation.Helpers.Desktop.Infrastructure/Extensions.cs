using HomeAutomation.Helpers.Desktop.Application.Services;
using HomeAutomation.Helpers.Desktop.Application.Services.Clients;
using HomeAutomation.Helpers.Desktop.Infrastructure.Services;
using HomeAutomation.Helpers.Desktop.Infrastructure.Services.Clients;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Infrastructure;

public static class Extensions
{
    public static IServiceCollection UseInfrastructure(this IServiceCollection services)
    {
        services
            .UseServices()
            .UseServiceClients();

        return services;
    }

    public static IServiceCollection UseServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IPlatformIoService, PlatformIoService>()
            .AddSingleton<IRemoteAccessService, RemoteAccessService>();

        return services;
    }

    public static IServiceCollection UseServiceClients(this IServiceCollection services)
    {
        services
            .AddTransient<IApiGatewayServiceClient, ApiGatewayServiceCLient>()
            .AddTransient<ICommandLineServiceClient, CommandLineServiceClient>();

        return services;
    }
}