using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;
using HomeAutomation.Helpers.Desktop.Application.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public static class Extensions
{
    public static IServiceCollection UseApplication(this IServiceCollection services)
    {
        services
            .UseDataTransferObjects()
            .UseSenders();

        return services;
    }

    private static IServiceCollection UseDataTransferObjects(this IServiceCollection services)
    {
        services
            .AddTransient<ConnectionDto>()
            .AddTransient<DeviceDto>()
            .AddTransient<LabelDto>();

        services.AddTransient<DeviceReadingDto>();

        return services;
    }

    private static IServiceCollection UseSenders(this IServiceCollection services)
    {
        services
            .AddSingleton<ICommandSender, CommandSender>()
            .AddSingleton<IQuerySender, QuerySender>();

        return services;
    }
}