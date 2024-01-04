using HomeAutomation.Helpers.Desktop.Core.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Core;

public static class Extensions
{
    public static IServiceCollection UseCore(this IServiceCollection services)
    {
        services.UseDbContext();

        return services;
    }

    public static IServiceCollection UseDbContext(this IServiceCollection services)
    {
        services.AddDbContext<HomeAutomationDesktopHelper>(options =>
            options.UseSqlite("Data Source=sqlite.db"));

        return services;
    }
}