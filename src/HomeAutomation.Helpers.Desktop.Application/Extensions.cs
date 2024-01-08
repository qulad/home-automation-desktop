using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public static class Extensions
{
    public static IServiceCollection UseApplication(this IServiceCollection services)
    {
        services.UseFeatureSender();

        return services;
    }

    public static IServiceCollection UseFeatureSender(this IServiceCollection services)
    {
        services.AddSingleton<IFeatureSender, FeatureSender>();

        return services;
    }
}