using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Commands;

public interface ICommandSender
{
    void SendAddMultiple<TCommand>(IList<TCommand> command) where TCommand : ICommand;
    void SendAddSingle<TCommand>(TCommand command) where TCommand : ICommand;
    List<TDto> SendGetMultiple<TCommand, TDto>(TCommand command) where TCommand : ICommand where TDto : BaseDataTransferObject;
    TDto SendGetSingle<TCommand, TDto>(TCommand command) where TCommand : ICommand where TDto : BaseDataTransferObject;
}