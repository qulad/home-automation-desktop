using System;
using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
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

    public void SendDeleteSingle<TCommand>(TCommand command) where TCommand : ICommand
    {
        var handler = _serviceProvider.GetRequiredService<IDeleteSingleCommandHandler<TCommand>>();

        handler.Handle(command);
    }

    public void SendUpdateSingle<TCommand, TEntity>(TCommand command, TEntity existingEntity) where TCommand : ICommand
    {
        var handler = _serviceProvider.GetRequiredService<IUpdateSingleCommandHandler<TCommand, TEntity>>();

        handler.Handle(command, existingEntity);
    }
}