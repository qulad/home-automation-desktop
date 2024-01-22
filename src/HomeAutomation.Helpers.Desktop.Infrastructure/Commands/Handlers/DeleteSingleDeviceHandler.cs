using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class DeleteSingleDeviceHandler : IDeleteSingleCommandHandler<DeleteSingleDevice>
{
    private readonly IDeviceRepository<DeviceEntity, DeviceDto> _deviceRepository;

    public DeleteSingleDeviceHandler(IDeviceRepository<DeviceEntity, DeviceDto> deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    public void Handle(DeleteSingleDevice command)
    {
        _deviceRepository.Delete(command.Id);
    }
}