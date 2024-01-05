using HomeAutomation.Helpers.Desktop.Core.Context;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Core;

public static class Extensions
{
    public static IServiceCollection UseCore(this IServiceCollection services)
    {
        services
            .UseDbContext()
            .UseEntities()
            .UseRepositories();

        return services;
    }

    public static IServiceCollection UseDbContext(this IServiceCollection services)
    {
        services.AddDbContext<HomeAutomationDesktopHelper>(options =>
            options.UseSqlite("Data Source=sqlite.db"));

        return services;
    }

    public static IServiceCollection UseEntities(this IServiceCollection services)
    {
        services
            .AddSingleton<ConnectionEntity>()
            .AddSingleton<LabelEntity>();

        return services;
    }

    public static IServiceCollection UseRepositories(this IServiceCollection services)
    {
        services
            .AddTransient<ConnectionRepository>()
            .AddTransient<LabelRepository>();

        return services;
    }
}