using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface;

public static class Extensions
{
    public static IServiceCollection UseGraphicalUserInterface(this IServiceCollection services)
    {
        services.UsePages();

        return services;
    }

    public static IServiceCollection UsePages(this IServiceCollection services)
    {
        services.AddTransient<HomePage>();

        return services;
    }
}