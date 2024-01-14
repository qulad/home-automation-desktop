namespace HomeAutomation.Helpers.Desktop.Application.Commands.Base;

public interface ICommandSender
{
    void Send<TCommand>(TCommand command) where TCommand : ICommand;
}