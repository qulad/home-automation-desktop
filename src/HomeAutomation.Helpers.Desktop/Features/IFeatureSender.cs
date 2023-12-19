namespace HomeAutomation.Helpers.Desktop.Features;

public interface IFeatureSender
{
    void Send<TCommand>(TCommand command);
}