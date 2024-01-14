using HomeAutomation.Helpers.Desktop.Application.Commands.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers.Base;

public interface ICommandHandler<in TCommand> where TCommand : ICommand
{
    void Handle(TCommand command);
}