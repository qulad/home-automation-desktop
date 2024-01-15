using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;

public interface IGetSingleQueryHandler<in TQuery, out TDto> where TQuery : IQuery where TDto : BaseDataTransferObject
{
    TDto Handle(TQuery command);
}