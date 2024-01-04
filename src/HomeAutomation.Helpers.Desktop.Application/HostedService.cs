using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using HomeAutomation.Helpers.Desktop.Core.Context;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface;
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
        PrintWelcomeMessage();

        RemoveConsole();

        StartDatabase();

        StartGraphicalUserInterface();

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    private void PrintWelcomeMessage()
    {
        Console.WriteLine("""
              _   _                           _         _                        _   _               ____            _                _   _      _                 
             | | | | ___  _ __ ___   ___     / \  _   _| |_ ___  _ __ ___   __ _| |_(_) ___  _ __   |  _ \  ___  ___| |_ ___  _ __   | | | | ___| |_ __   ___ _ __ 
             | |_| |/ _ \| '_ ` _ \ / _ \   / _ \| | | | __/ _ \| '_ ` _ \ / _` | __| |/ _ \| '_ \  | | | |/ _ \/ __| __/ _ \| '_ \  | |_| |/ _ \ | '_ \ / _ \ '__|
             |  _  | (_) | | | | | |  __/  / ___ \ |_| | || (_) | | | | | | (_| | |_| | (_) | | | | | |_| |  __/\__ \ || (_) | |_) | |  _  |  __/ | |_) |  __/ |   
             |_| |_|\___/|_| |_| |_|\___| /_/   \_\__,_|\__\___/|_| |_| |_|\__,_|\__|_|\___/|_| |_| |____/ \___||___/\__\___/| .__/  |_| |_|\___|_| .__/ \___|_|   
                                                                                                                             |_|                  |_|              
            """);

        Console.WriteLine("Starting Home Automation Desktop Helper");

        _logger.LogInformation("Printed welcome message");
    }

    private void RemoveConsole()
    {
        FreeConsole();

        _logger.LogInformation("Removed console");
    }

    private void StartDatabase()
    {
        var dbContext = _serviceProvider.GetRequiredService<HomeAutomationDesktopHelper>();

        dbContext.Database.EnsureCreated();

        _logger.LogInformation("Ensured database creation");
    }

    private void StartGraphicalUserInterface()
    {
        var homePage = _serviceProvider.GetRequiredService<HomePage>();

        System.Windows.Forms.Application.Run(homePage);

        _logger.LogInformation("Started graphical user interface");
    }
}