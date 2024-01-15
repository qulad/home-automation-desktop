using System;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class UpdateSingleConnectionHandler : IUpdateSingleCommandHandler<UpdateSingleConnection, ConnectionEntity>
{
    private readonly ConnectionRepository _connectionRepository;

    public UpdateSingleConnectionHandler(ConnectionRepository connectionRepository)
    {
        _connectionRepository = connectionRepository;
    }

    public void Handle(UpdateSingleConnection command, ConnectionEntity existingEntity)
    {
        var entity = new ConnectionEntity(Guid.NewGuid())
        {
            Name = command.Name
        };
    
        entity.SetPort(command.Port);
        entity.SetLabels(command.LabelIds);

        _connectionRepository.Update(entity);
    }
}