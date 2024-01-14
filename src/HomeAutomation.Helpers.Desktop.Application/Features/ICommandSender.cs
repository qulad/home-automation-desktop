using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

namespace HomeAutomation.Helpers.Desktop;

public interface ICommandSender
{
    void Send<TCommand>(TCommand command) where TCommand : ICommand;
}