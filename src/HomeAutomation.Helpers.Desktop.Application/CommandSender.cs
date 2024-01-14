using System;
using System.Collections;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public class CommandSender : ICommandSender
{
    private readonly IServiceProvider _serviceProvider;

    public CommandSender(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public TDto SendGetSingle<TCommand, TDto>(TCommand command) where TCommand : ICommand where TDto : BaseDataTransferObject
    {
        var handler = _serviceProvider.GetRequiredService<IGetSingleCommandHandler<TCommand, TDto>>();
        return handler.Handle(command);
    }

    public List<TDto> SendGetMultiple<TCommand, TDto>(TCommand command) where TCommand : ICommand where TDto : BaseDataTransferObject
    {
        var handler = _serviceProvider.GetRequiredService<IGetMultipleCommandHandler<TCommand, TDto>>();
        return handler.Handle(command);
    }
}