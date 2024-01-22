using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class UpdateSingleDeviceHandler : IUpdateSingleCommandHandler<UpdateSingleDevice, DeviceEntity>
{
    private readonly IDeviceRepository<DeviceEntity, DeviceDto> _deviceRepository;

    public UpdateSingleDeviceHandler(IDeviceRepository<DeviceEntity, DeviceDto> deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    public void Handle(UpdateSingleDevice command, DeviceEntity existingEntity)
    {
        var entity = new DeviceEntity(existingEntity.Id)
        {
            MacAddress = command.MacAddress,
            Name = command.Name
        };

        _deviceRepository.Update(entity);
    }
}