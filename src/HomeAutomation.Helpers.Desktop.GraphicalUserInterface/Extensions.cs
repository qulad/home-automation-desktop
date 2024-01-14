using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface;

public static class Extensions
{
    public static IServiceCollection UseGraphicalUserInterface(this IServiceCollection services)
    {
        services
            .UseBasePage()
            .UsePages()
            .UseWindows();

        return services;
    }

    public static IServiceCollection UseBasePage(this IServiceCollection services)
    {
        services.AddTransient<BasePage>();

        return services;
    }

    public static IServiceCollection UsePages(this IServiceCollection services)
    {
        services
            .AddSingleton<AboutPage>()
            .AddSingleton<AddPage>()
            .AddSingleton<HomePage>()
            .AddSingleton<MonitorPage>();

        return services;
    }

    public static IServiceCollection UseWindows(this IServiceCollection services)
    {
        services.AddTransient<MainWindow>();

        return services;
    }
}