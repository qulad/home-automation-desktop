using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using HomeAutomation.Helpers.Desktop.Features;

namespace HomeAutomation.Helpers.Desktop.Application;

public static class Extensions
{
    public static IServiceCollection UseApplication(this IServiceCollection services)
    {
        services
            .UseHostedService()
            .UseFeatureSender();

        return services;
    }

    public static IServiceCollection UseHostedService(this IServiceCollection services)
    {
        services.AddHostedService<HostedService>();

        return services;
    }

    public static IServiceCollection UseFeatureSender(this IServiceCollection services)
    {
        services.AddSingleton<IFeatureSender, FeatureSender>();

        return services;
    }
}