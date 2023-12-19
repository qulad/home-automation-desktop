using HomeAutomation.Helpers.Desktop.Application;
using Microsoft.Extensions.Hosting;

namespace HomeAutomation.Helpers.Desktop;

public class Program
{
    static void Main(string[] args)
    {
        var app = Host.CreateApplicationBuilder(args);

        app.Services.UseApplication();

        app.Build().Run();
    }
}