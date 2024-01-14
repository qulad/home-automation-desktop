using System.Collections.Generic;

namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface IAddMultipleCommandHandler<TCommand> where TCommand : ICommand
{
    void Handle(IList<TCommand> commands);
}