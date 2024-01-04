using HomeAutomation.Helpers.Desktop.Application;
using HomeAutomation.Helpers.Desktop.Infrastructure;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface;
using Microsoft.Extensions.Hosting;
using HomeAutomation.Helpers.Desktop.Core;

namespace HomeAutomation.Helpers.Desktop;

public static class Program
{
    static void Main(string[] args)
    {
        var app = Host.CreateApplicationBuilder(args);

        app.Services
            .UseApplication()
            .UseGraphicalUserInterface()
            .UseInfrastructure()
            .UseCore();

        app.Build().RunAsync();
    }
}