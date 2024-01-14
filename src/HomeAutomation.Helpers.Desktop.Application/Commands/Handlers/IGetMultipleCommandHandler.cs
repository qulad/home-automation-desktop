using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface IGetMultipleCommandHandler<in TCommand, TDto> where TCommand : ICommand where TDto : BaseDataTransferObject
{
    List<TDto> Handle(TCommand command);
}