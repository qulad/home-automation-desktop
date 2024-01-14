using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface;

public static class Extensions
{
    public static IServiceCollection UseGraphicalUserInterface(this IServiceCollection services)
    {
        services
            .UsePages()
            .UseWindows();

        return services;
    }

    public static IServiceCollection UsePages(this IServiceCollection services)
    {
        services
            .AddTransient<HomePage>()
            .AddTransient<AboutPage>()
            .AddTransient<MonitorPage>()
            .AddTransient<AddPage>();

        return services;
    }

    public static IServiceCollection UseWindows(this IServiceCollection services)
    {
        services.AddTransient<MainWindow>();

        return services;
    }
}