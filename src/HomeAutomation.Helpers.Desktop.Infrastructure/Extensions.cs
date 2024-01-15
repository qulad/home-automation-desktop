using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
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
            .AddSingleton<AddSingleConnectionHandler>()
            .AddSingleton<AddSingleLabelHandler>()
            .AddSingleton<DeleteSingleConnectionHandler>()
            .AddSingleton<DeleteSingleLabelHandler>()
            .AddSingleton<UpdateSingleConnectionHandler>()
            .AddSingleton<UpdateSingleLabelHandler>();

        return services;
    }

    private static IServiceCollection UseCommands(this IServiceCollection services)
    {
        services
            .AddTransient<AddMultipleLabels>()
            .AddTransient<AddSingleConnection>()
            .AddTransient<AddSingleLabel>()
            .AddTransient<DeleteSingleConnection>()
            .AddTransient<DeleteSingleLabel>()
            .AddTransient<UpdateSingleConnection>()
            .AddTransient<UpdateSingleLabel>();

        return services;
    }

    private static IServiceCollection UseQueries(this IServiceCollection services)
    {
        services
            .AddTransient<GetMultipleConnections>()
            .AddTransient<GetMultipleLabels>()
            .AddTransient<GetSingleConnection>()
            .AddTransient<GetSingleLabel>();

        return services;
    }

    private static IServiceCollection UseQueryHandlers(this IServiceCollection services)
    {
        services
            .AddSingleton<IGetMultipleQueryHandler<GetMultipleConnections, ConnectionDto>, GetMultipleConnectionsHandler>()
            .AddSingleton<IGetMultipleQueryHandler<GetMultipleLabels, LabelDto>, GetMultipleLabelsHandler>()
            .AddSingleton<IGetSingleQueryHandler<GetSingleConnection, ConnectionDto>, GetSingleConnectionHandler>()
            .AddSingleton<IGetSingleQueryHandler<GetSingleLabel, LabelDto>, GetSingleLabelHandler>();

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