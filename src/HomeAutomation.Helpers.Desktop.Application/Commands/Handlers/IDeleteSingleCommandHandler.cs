namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface IDeleteSingleCommandHandler<in TCommand> where TCommand : ICommand 
{
    void Handle(TCommand command);
}