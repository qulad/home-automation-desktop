using System;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class AddSingleLabelHandler : IAddSingleCommandHandler<AddSingleLabel>
{
    private readonly ILabelRepository<LabelEntity, LabelDto> _labelRepository;

    public AddSingleLabelHandler(ILabelRepository<LabelEntity, LabelDto> labelRepository)
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
}