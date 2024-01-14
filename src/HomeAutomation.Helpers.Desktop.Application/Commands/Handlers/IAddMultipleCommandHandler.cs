using System.Collections.Generic;

namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface IAddMultipleCommandHandler<in TCommand> where TCommand : ICommand
{
    void Handle(TCommand command);
}