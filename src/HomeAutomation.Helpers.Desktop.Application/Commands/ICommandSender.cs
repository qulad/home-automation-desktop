using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Commands;

public interface ICommandSender
{
    TDto SendGetSingle<TCommand, TDto>(TCommand command) where TCommand : ICommand where TDto : BaseDataTransferObject;
    List<TDto> SendGetMultiple<TCommand, TDto>(TCommand command) where TCommand : ICommand where TDto : BaseDataTransferObject;
}