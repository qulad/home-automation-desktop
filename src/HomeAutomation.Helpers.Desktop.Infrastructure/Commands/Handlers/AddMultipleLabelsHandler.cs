using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class AddMultipleLabelsHandler : IAddMultipleCommandHandler<AddMultipleLabels>
{
    private readonly ILabelRepository<LabelEntity, LabelDto> _labelRepository;

    public AddMultipleLabelsHandler(ILabelRepository<LabelEntity, LabelDto> labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public void Handle(AddSingleLabel command)
    {
        var entity = new LabelEntity(Guid.NewGuid())
        {
            Text = command.Text
        };

        _labelRepository.AddSingle(entity);
    }

    public void Handle(AddMultipleLabels command)
    {
        var entities = new List<LabelEntity>();

        foreach (var text in command.Texts)
        {
            var entity = new LabelEntity(Guid.NewGuid())
            {
                Text = text
            };

            entities.Add(entity);
        }

        _labelRepository.AddMultiple(entities);
    }
}