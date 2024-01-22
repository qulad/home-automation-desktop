using System;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class AddSingleDeviceHandler : IAddSingleCommandHandler<AddSingleDevice>
{
    private readonly IDeviceRepository<DeviceEntity, DeviceDto> _deviceRepository;

    public AddSingleDeviceHandler(IDeviceRepository<DeviceEntity, DeviceDto> deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    public void Handle(AddSingleDevice command)
    {
        var entity = new DeviceEntity(Guid.NewGuid())
        {
            MacAddress = command.MacAddress,
            Name = command.Name
        };

        _deviceRepository.AddSingle(entity);
    }
}