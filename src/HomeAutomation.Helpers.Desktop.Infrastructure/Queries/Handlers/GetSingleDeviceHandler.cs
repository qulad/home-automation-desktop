using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetSingleDeviceHandler : IGetSingleQueryHandler<GetSingleDevice, DeviceDto>
{
    private readonly IDeviceRepository<DeviceEntity, DeviceDto> _deviceRepository;

    public GetSingleDeviceHandler(IDeviceRepository<DeviceEntity, DeviceDto> deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    public DeviceDto Handle(GetSingleDevice command)
    {
        return _deviceRepository.GetById(command.Id);
    }
}