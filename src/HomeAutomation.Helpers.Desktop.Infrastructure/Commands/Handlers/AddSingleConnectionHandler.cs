using System;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class AddSingleConnectionHandler : IAddSingleCommandHandler<AddSingleConnection>
{
    private readonly IConnectionRepository<ConnectionEntity, ConnectionDto> _connectionRepository;

    public AddSingleConnectionHandler(IConnectionRepository<ConnectionEntity, ConnectionDto> connectionRepository)
    {
        _connectionRepository = connectionRepository;
    }

    public void Handle(AddSingleConnection command)
    {
        var entity = new ConnectionEntity(Guid.NewGuid())
        {
            Name = command.Name
        };
        entity.SetIpAddress(command.IpAddress);
        entity.SetPort(command.Port);
        entity.SetLabels(command.LabelIds);

        _connectionRepository.AddSingle(entity);
    }
}