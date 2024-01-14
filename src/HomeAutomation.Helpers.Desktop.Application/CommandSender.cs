using System;
using HomeAutomation.Helpers.Desktop.Application.Commands.Base;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Application;

public class CommandSender : ICommandSender
{
    private readonly IServiceProvider _serviceProvider;

    public CommandSender(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Send<TCommand>(TCommand command) where TCommand : ICommand
    {
        var handler = _serviceProvider.GetRequiredService<ICommandHandler<TCommand>>();
        handler.Handle(command);
    }
}