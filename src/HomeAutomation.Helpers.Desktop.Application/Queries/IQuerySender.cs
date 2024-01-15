using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.Queries;

public interface IQuerySender
{
    List<TDto> SendGetMultiple<TQuery, TDto>(TQuery command) where TQuery : IQuery where TDto : BaseDataTransferObject;
    TDto SendGetSingle<TQuery, TDto>(TQuery command) where TQuery : IQuery where TDto : BaseDataTransferObject;
}