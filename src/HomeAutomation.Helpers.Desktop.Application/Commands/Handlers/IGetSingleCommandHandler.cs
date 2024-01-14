using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;

public interface IGetSingleCommandHandler<in TCommand, out TDto> where TCommand : ICommand where TDto : BaseDataTransferObject
{
    TDto Handle(TCommand command);
}