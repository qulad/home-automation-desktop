namespace HomeAutomation.Helpers.Desktop.Features.Handlers;

public interface IFeatureHandler
{
    void Handle<TFeature>(TFeature feature) where TFeature : IFeature;
}