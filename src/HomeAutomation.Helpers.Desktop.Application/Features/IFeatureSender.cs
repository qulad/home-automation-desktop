using HomeAutomation.Helpers.Desktop.Application.Features;
using HomeAutomation.Helpers.Desktop.Application.Features.Handlers;

namespace HomeAutomation.Helpers.Desktop;

public interface IFeatureSender
{
    void Send<TFeature>(TFeature feature) where TFeature : IFeature;
}