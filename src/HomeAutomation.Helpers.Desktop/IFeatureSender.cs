namespace HomeAutomation.Helpers.Desktop;

public interface IFeatureSender
{
    void Send<TCommand>(TCommand command);
}