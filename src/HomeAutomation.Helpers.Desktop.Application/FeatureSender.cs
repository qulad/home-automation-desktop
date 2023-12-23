using System;
using HomeAutomation.Helpers.Desktop.Application.Features;
using HomeAutomation.Helpers.Desktop.Application.Features.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public class FeatureSender : IFeatureSender
{
    private readonly IServiceProvider _serviceProvider;

    public FeatureSender(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Send<TFeature>(TFeature feature) where TFeature : IFeature
    {
        var handler = _serviceProvider.GetRequiredService<IFeatureHandler<TFeature>>();
        handler.Handle(feature);
    }
}