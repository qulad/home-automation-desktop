using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
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

    private static IServiceCollection UseDbContext(this IServiceCollection services)
    {
        services.AddDbContext<DbContext, HomeAutomationDesktopHelperDbContext>(options =>
            options.UseSqlite("Data Source=sqlite.db"));

        return services;
    }

    private static IServiceCollection UseEntities(this IServiceCollection services)
    {
        services
            .AddTransient<ConnectionEntity>()
            .AddTransient<DeviceEntity>()
            .AddTransient<LabelEntity>();

        return services;
    }

    private static IServiceCollection UseRepositories(this IServiceCollection services)
    {
        services
            .AddTransient<IConnectionRepository<ConnectionEntity, ConnectionDto>, ConnectionRepository>()
            .AddTransient<IDeviceRepository<DeviceEntity, DeviceDto>, DeviceRepository>()
            .AddTransient<ILabelRepository<LabelEntity, LabelDto>, LabelRepository>();

        return services;
    }
}