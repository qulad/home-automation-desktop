using System;
using System.Collections;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Application.Repositories.Base;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories;

public class LabelRepository : BaseRepositery<LabelEntity>, ILabelRepository<LabelEntity, LabelDto>
{
    public LabelRepository(DbContext dbContext) : base(dbContext)
    {
    }

    public LabelDto GetById(Guid id)
    {
        var entity = base.GetEntityById(id);

        var dto = new LabelDto(entity.Id)
        {
            Text = entity.Text
        };

        return dto;
    }

    public IList<LabelDto> GetByPredicate(Func<LabelEntity, bool> predicate)
    {
        var allEntites = base.GetEntitesByPredicate(predicate);

        var allDtos = new List<LabelDto>();

        foreach (var entity in allEntites)
        {
            var dto = new LabelDto(entity.Id)
            {
                Text = entity.Text
            };

            allDtos.Add(dto);
        }

        return allDtos;
    }

    public IList<LabelDto> GetAll()
    {
        var allEntites = base.GetAllEntites();

        var allDtos = new List<LabelDto>();

        foreach (var entity in allEntites)
        {
            var dto = new LabelDto(entity.Id)
            {
                Text = entity.Text
            };

            allDtos.Add(dto);
        }

        return allDtos;
    }

}