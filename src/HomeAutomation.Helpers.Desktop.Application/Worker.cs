using HomeAutomation.Helpers.Desktop.UserInterface;

namespace HomeAutomation.Helpers.Desktop.Application;

public class Worker : IHostedService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);

        GraphicalUserInterface.Main();

        return Task.CompletedTask;
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}