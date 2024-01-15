namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface IUpdateSingleCommandHandler<in TCommand, in TEntity> where TCommand : ICommand 
{
    void Handle(TCommand command, TEntity existingEntity);
}