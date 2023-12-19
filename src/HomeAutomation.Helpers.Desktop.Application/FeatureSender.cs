using System;
using HomeAutomation.Helpers.Desktop.Features;
using HomeAutomation.Helpers.Desktop.Features.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public class FeatureSender : IFeatureSender
{
    private readonly IServiceProvider _serviceProvider;

    public FeatureSender(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Send<TCommand>(TCommand command)
    {
        var handler = _serviceProvider.GetRequiredService<IFeatureHandler<TCommand>>();
        handler.Handle(command);
    }
}