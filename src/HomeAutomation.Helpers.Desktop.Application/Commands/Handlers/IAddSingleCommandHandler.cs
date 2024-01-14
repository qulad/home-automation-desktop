namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface IAddSingleCommandHandler<in TCommand> where TCommand : ICommand
{
    void Handle(TCommand command);
}