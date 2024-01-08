using HomeAutomation.Helpers.Desktop.Application;
using HomeAutomation.Helpers.Desktop.Infrastructure;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface;
using Microsoft.Extensions.Hosting;
using HomeAutomation.Helpers.Desktop.Core;
using System.Runtime.InteropServices;
using HomeAutomation.Helpers.Desktop.Core.Context;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace HomeAutomation.Helpers.Desktop;

public static class Program
{
    [DllImport("kernel32.dll")]
    static extern void FreeConsole();

    static void Main(string[] args)
    {
        var app = Host.CreateApplicationBuilder(args);

        app.Services
            .UseApplication()
            .UseCore()
            .UseGraphicalUserInterface()
            .UseInfrastructure()
            .DoStartupChecks();

        app.Build().RunAsync();
    }

    private static void DoStartupChecks(this IServiceCollection serviceCollection)
    {
        var services = serviceCollection.BuildServiceProvider();

        PrintWelcomeMessage();

        RemoveConsole();

        StartDatabase(services);

        StartGraphicalUserInterface(services);
    }

    private static void PrintWelcomeMessage()
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
    }

    private static void RemoveConsole()
    {
        FreeConsole();
    }

    private static void StartDatabase(IServiceProvider services)
    {
        var dbContext = services.GetRequiredService<HomeAutomationDesktopHelper>();

        dbContext.Database.EnsureCreated();
    }

    private static void StartGraphicalUserInterface(IServiceProvider services)
    {
        var homePage = services.GetRequiredService<HomePage>();

        System.Windows.Forms.Application.Run(homePage);
    }
}