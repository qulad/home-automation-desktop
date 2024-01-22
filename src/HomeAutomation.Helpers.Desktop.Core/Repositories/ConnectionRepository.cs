using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Context;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories;

public class ConnectionRepository : BaseRepositery<ConnectionEntity>, IConnectionRepository<ConnectionEntity, ConnectionDto>
{
    public ConnectionRepository(HomeAutomationDesktopHelperDbContext dbContext) : base(dbContext)
    {
    }

    public IList<ConnectionDto> GetAll()
    {
        var allEntites = base.GetAllEntites();

        var allDtos = new List<ConnectionDto>();

        foreach (var entity in allEntites)
        {
            var dto = new ConnectionDto(entity.Id)
            {
                IpAddress = entity.IpAddress,
                Port = entity.Port,
                Name = entity.Name,
                LabelIds = entity.LabelIds
            };

            allDtos.Add(dto);
        }

        return allDtos;
    }

    public ConnectionDto GetById(Guid id)
    {
        var entity = base.GetEntityById(id);

        var dto = new ConnectionDto(entity.Id)
        {
            Port = entity.Port,
            Name = entity.Name,
            LabelIds = entity.LabelIds
        };

        return dto;
    }

    public IList<ConnectionDto> GetByPredicate(Func<ConnectionEntity, bool> predicate)
    {
        var allEntites = base.GetEntitesByPredicate(predicate);

        var allDtos = new List<ConnectionDto>();

        foreach (var entity in allEntites)
        {
            var dto = new ConnectionDto(entity.Id)
            {
                Port = entity.Port,
                Name = entity.Name,
                LabelIds = entity.LabelIds
            };

            allDtos.Add(dto);
        }

        return allDtos;
    }
}