namespace HomeAutomation.Helpers.Desktop.Features.Handlers;

public interface IFeatureHandler<in TCommand>
{
    void Handle(TCommand command);
}