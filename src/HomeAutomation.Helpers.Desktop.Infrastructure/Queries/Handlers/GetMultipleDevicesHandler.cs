using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetMultipleDevicesHandler : IGetMultipleQueryHandler<GetMultipleDevices, DeviceDto>
{
    private readonly IDeviceRepository<DeviceEntity, DeviceDto> _deviceRepository;

    public GetMultipleDevicesHandler(IDeviceRepository<DeviceEntity, DeviceDto> deviceRepository)
    {
        _deviceRepository = deviceRepository;
    }

    public List<DeviceDto> Handle(GetMultipleDevices command)
    {
        var predicate = GetPredicate(command);

        if (predicate is null)
        {
            return _deviceRepository.GetAll().ToList();
        }
        else
        {
            return _deviceRepository.GetByPredicate(predicate).ToList();
        }
    }

    private static Func<DeviceEntity, bool> GetPredicate(GetMultipleDevices command)
    {
        Func<DeviceEntity, bool> predicate = null;

        if (command.Ids is not null && command.Ids.Count > 0)
        {
            if (command.Ids.Count == 1)
            {
                var id = command.Ids[0];

                predicate = device => device.Id == id;
            }
            else
            {
                predicate = device => command.Ids.Contains(device.Id);
            }
        }

        if (command.MacAddresses is not null && command.MacAddresses.Count > 0)
        {
            if (command.MacAddresses.Count == 1)
            {
                var text = command.MacAddresses[0];

                if (predicate == null)
                {
                    predicate = device => device.MacAddress == text;
                }
                else
                {
                    var existingPredicate = predicate;

                    predicate = device => existingPredicate(device) && device.MacAddress == text;
                }
            }
            else
            {
                if (predicate == null)
                {
                    predicate = device => command.MacAddresses.Contains(device.MacAddress);
                }
                else
                {
                    var existingPredicate = predicate;

                    predicate = device => existingPredicate(device) && command.MacAddresses.Contains(device.MacAddress);
                }
            }
        }

        return predicate;
    }
}