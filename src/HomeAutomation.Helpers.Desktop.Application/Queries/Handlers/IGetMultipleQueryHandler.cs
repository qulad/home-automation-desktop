using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;

public interface IGetMultipleQueryHandler<in TQuery, TDto> where TQuery : IQuery where TDto : BaseDataTransferObject
{
    List<TDto> Handle(TQuery command);
}