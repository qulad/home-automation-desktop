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

    public void SendAddMultiple<TCommand>(TCommand command) where TCommand : ICommand
    {
        var handler = _serviceProvider.GetRequiredService<IAddMultipleCommandHandler<TCommand>>();

        handler.Handle(command);
    }


    public void SendAddSingle<TCommand>(TCommand command) where TCommand : ICommand
    {
        var handler = _serviceProvider.GetRequiredService<IAddSingleCommandHandler<TCommand>>();

        handler.Handle(command);
    }
}