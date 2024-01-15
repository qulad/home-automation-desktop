using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Commands;

public interface ICommandSender
{
    void SendAddMultiple<TCommand>(TCommand command) where TCommand : ICommand;
    void SendAddSingle<TCommand>(TCommand command) where TCommand : ICommand;
}