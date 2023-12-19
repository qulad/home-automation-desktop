using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomation.Helpers.Desktop.UserInterface;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HomeAutomation.Helpers.Desktop.Application;

public class HostedService : IHostedService
{
    [DllImport("kernel32.dll")]
    static extern void FreeConsole();

    private readonly ILogger<HostedService> _logger;

    public HostedService(ILogger<HostedService> logger)
    {
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Hosted service running at: {time}", DateTimeOffset.Now);

        //? Print 'Starting App' etc. to make the pause less annoying.

        FreeConsole();

        GraphicalUserInterface.Main();

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}