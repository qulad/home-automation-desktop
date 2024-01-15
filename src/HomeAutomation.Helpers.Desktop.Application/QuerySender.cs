using System;
using System.Collections;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;
using HomeAutomation.Helpers.Desktop.Application.Queries;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public class QuerySender : IQuerySender
{
    private readonly IServiceProvider _serviceProvider;

    public QuerySender(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public List<TDto> SendGetMultiple<TQuery, TDto>(TQuery command) where TQuery : IQuery where TDto : BaseDataTransferObject
    {
        var handler = _serviceProvider.GetRequiredService<IGetMultipleQueryHandler<TQuery, TDto>>();
        return handler.Handle(command);
    }

    public TDto SendGetSingle<TQuery, TDto>(TQuery command) where TQuery : IQuery where TDto : BaseDataTransferObject
    {
        var handler = _serviceProvider.GetRequiredService<IGetSingleQueryHandler<TQuery, TDto>>();
        return handler.Handle(command);
    }
}