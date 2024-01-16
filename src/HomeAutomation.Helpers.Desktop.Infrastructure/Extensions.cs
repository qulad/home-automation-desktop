using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Application.Services;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Infrastructure.Commands;
using HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Infrastructure.Services;
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
            .UseQueryHandlers();

        return services;
    }

    private static IServiceCollection UseCommandHandlers(this IServiceCollection services)
    {
        services
            .AddTransient<IAddMultipleCommandHandler<AddMultipleLabels>, AddMultipleLabelsHandler>()
            .AddTransient<IAddSingleCommandHandler<AddSingleConnection>, AddSingleConnectionHandler>()
            .AddTransient<IAddSingleCommandHandler<AddSingleLabel>, AddSingleLabelHandler>()
            .AddTransient<IDeleteSingleCommandHandler<DeleteSingleConnection>, DeleteSingleConnectionHandler>()
            .AddTransient<IDeleteSingleCommandHandler<DeleteSingleLabel>, DeleteSingleLabelHandler>()
            .AddTransient<IUpdateSingleCommandHandler<UpdateSingleConnection, ConnectionEntity>, UpdateSingleConnectionHandler>()
            .AddTransient<IUpdateSingleCommandHandler<UpdateSingleLabel, LabelEntity>, UpdateSingleLabelHandler>();

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
            .AddTransient<IGetMultipleQueryHandler<GetMultipleConnections, ConnectionDto>, GetMultipleConnectionsHandler>()
            .AddTransient<IGetMultipleQueryHandler<GetMultipleLabels, LabelDto>, GetMultipleLabelsHandler>()
            .AddTransient<IGetSingleQueryHandler<GetSingleConnection, ConnectionDto>, GetSingleConnectionHandler>()
            .AddTransient<IGetSingleQueryHandler<GetSingleLabel, LabelDto>, GetSingleLabelHandler>();

        return services;
    }

    private static IServiceCollection UseServices(this IServiceCollection services)
    {
        services.AddSingleton<IRespApiService, RespApiService>();

        return services;
    }
}