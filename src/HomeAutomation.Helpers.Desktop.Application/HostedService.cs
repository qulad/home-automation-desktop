using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomation.Helpers.Desktop.UserInterface;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HomeAutomation.Helpers.Desktop.Application;

public class HostedService : IHostedService
{
    [DllImport("kernel32.dll")]
    static extern void FreeConsole();

    private readonly IServiceProvider _serviceProvider;
    private readonly ILogger<HostedService> _logger;

    public HostedService(
        IServiceProvider serviceProvider,
        ILogger<HostedService> logger)
    {
        _serviceProvider = serviceProvider;
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Hosted service running at: {time}", DateTimeOffset.Now);

        //? Print 'Starting App' etc. to make the pause less annoying.

        FreeConsole();

        var homePage = _serviceProvider.GetRequiredService<HomePage>();

        System.Windows.Forms.Application.Run(homePage);

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}