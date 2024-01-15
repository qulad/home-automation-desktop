using HomeAutomation.Helpers.Desktop.Application.Services;
using HomeAutomation.Helpers.Desktop.Application.Services.Clients;
using HomeAutomation.Helpers.Desktop.Infrastructure.Commands;
using HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;
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
            .UseCommandHandlers()
            .UseCommands()
            .UseQueries()
            .UseQueryHandlers()
            .UseServiceClients();

        return services;
    }

    private static IServiceCollection UseCommandHandlers(this IServiceCollection services)
    {
        services
            .AddSingleton<AddMultipleLabelsHandler>()
            .AddSingleton<AddSingleLabelHandler>();

        return services;
    }

    private static IServiceCollection UseCommands(this IServiceCollection services)
    {
        services
            .AddTransient<AddMultipleLabels>()
            .AddTransient<AddSingleLabel>();

        return services;
    }

    private static IServiceCollection UseQueries(this IServiceCollection services)
    {
        services
            .AddTransient<GetMultipleLabels>()
            .AddTransient<GetSingleLabel>();

        return services;
    }

    private static IServiceCollection UseQueryHandlers(this IServiceCollection services)
    {
        services
            .AddSingleton<GetMultipleLabelsHandler>()
            .AddSingleton<GetSingleLabelHandler>();

        return services;
    }

    private static IServiceCollection UseServices(this IServiceCollection services)
    {
        services
            .AddSingleton<IPlatformIoService, PlatformIoService>()
            .AddSingleton<IRemoteAccessService, RemoteAccessService>();

        return services;
    }

    private static IServiceCollection UseServiceClients(this IServiceCollection services)
    {
        services
            .AddTransient<IApiGatewayServiceClient, ApiGatewayServiceCLient>()
            .AddTransient<ICommandLineServiceClient, CommandLineServiceClient>();

        return services;
    }
}