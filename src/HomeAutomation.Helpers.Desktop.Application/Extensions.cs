using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public static class Extensions
{
    public static IServiceCollection UseApplication(this IServiceCollection services)
    {
        services.AddHostedService<HostedService>();

        return services;
    }
}