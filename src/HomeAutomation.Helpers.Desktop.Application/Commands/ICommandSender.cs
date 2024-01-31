namespace HomeAutomation.Helpers.Desktop.Application.Commands;

public interface ICommandSender
{
    void SendAddMultiple<TCommand>(TCommand command) where TCommand : ICommand;
    void SendAddSingle<TCommand>(TCommand command) where TCommand : ICommand;
    void SendDeleteSingle<TCommand>(TCommand command) where TCommand : ICommand;
    void SendUpdateSingle<TCommand, TEntity>(TCommand command, TEntity existingEntity) where TCommand : ICommand;
}