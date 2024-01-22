using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Context;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories;

public class DeviceRepository : BaseRepositery<DeviceEntity>, IDeviceRepository<DeviceEntity, DeviceDto>
{
    public DeviceRepository(HomeAutomationDesktopHelperDbContext dbContext) : base(dbContext)
    {
    }

    public DeviceDto GetById(Guid id)
    {
        var entity = base.GetEntityById(id);

        var dto = new DeviceDto(entity.Id)
        {
            MacAddress = entity.MacAddress,
            Name = entity.Name
        };

        return dto;
    }

    public IList<DeviceDto> GetByPredicate(Func<DeviceEntity, bool> predicate)
    {
        var allEntites = base.GetEntitesByPredicate(predicate);

        var allDtos = new List<DeviceDto>();

        foreach (var entity in allEntites)
        {
            var dto = new DeviceDto(entity.Id)
            {
                MacAddress = entity.MacAddress,
                Name = entity.Name
            };

            allDtos.Add(dto);
        }

        return allDtos;
    }

    public IList<DeviceDto> GetAll()
    {
        var allEntites = base.GetAllEntites();

        var allDtos = new List<DeviceDto>();

        foreach (var entity in allEntites)
        {
            var dto = new DeviceDto(entity.Id)
            {
                MacAddress = entity.MacAddress,
                Name = entity.Name
            };

            allDtos.Add(dto);
        }

        return allDtos;
    }

}