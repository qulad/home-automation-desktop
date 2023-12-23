using HomeAutomation.Helpers.Desktop.Application;
using HomeAutomation.Helpers.Desktop.Infrastructure;
using HomeAutomation.Helpers.Desktop.UserInterface;
using Microsoft.Extensions.Hosting;

namespace HomeAutomation.Helpers.Desktop;

public static class Program
{
    static void Main(string[] args)
    {
        var app = Host.CreateApplicationBuilder(args);

        app.Services
            .UseApplication()
            .UseGraphicalUserInterface()
            .UseInfrastructure();

        app.Build().Run();
    }
}