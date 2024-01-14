using HomeAutomation.Helpers.Desktop.Application.Commands.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public static class Extensions
{
    public static IServiceCollection UseApplication(this IServiceCollection services)
    {
        services.UseCommandSender();

        return services;
    }

    public static IServiceCollection UseCommandSender(this IServiceCollection services)
    {
        services.AddSingleton<ICommandSender, CommandSender>();

        return services;
    }
}