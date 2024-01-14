namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface ICommandHandler<in TCommand> where TCommand : ICommand
{
    void Handle(TCommand command);
}