using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public static class Extensions
{
    public static IServiceCollection UseApplication(this IServiceCollection services)
    {
        services
            .UseCommandSender()
            .UseDataTransferObjects();

        return services;
    }

    private static IServiceCollection UseCommandSender(this IServiceCollection services)
    {
        services.AddSingleton<ICommandSender, CommandSender>();

        return services;
    }

    private static IServiceCollection UseDataTransferObjects(this IServiceCollection services)
    {
        services
            .AddTransient<ConnectionDto>()
            .AddTransient<LabelDto>();

        return services;
    }
}