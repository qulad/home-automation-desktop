using HomeAutomation.Helpers.Desktop.Features;

namespace HomeAutomation.Helpers.Desktop;

public interface IFeatureSender
{
    void Send<TFeature>(TFeature command) where TFeature : IFeature;
}