using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
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
            .AddTransient<LabelDto>();

        return services;
    }

    private static IServiceCollection UseSenders(this IServiceCollection services)
    {
        services
            .AddSingleton<ICommandSender, CommandSender>()
            .AddSingleton<ICommandSender, CommandSender>();

        return services;
    }
}