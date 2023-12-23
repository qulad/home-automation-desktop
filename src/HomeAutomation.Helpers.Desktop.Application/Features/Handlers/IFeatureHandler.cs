namespace HomeAutomation.Helpers.Desktop.Application.Features.Handlers;

public interface IFeatureHandler<in TFeature> where TFeature : IFeature
{
    void Handle(TFeature feature);
}