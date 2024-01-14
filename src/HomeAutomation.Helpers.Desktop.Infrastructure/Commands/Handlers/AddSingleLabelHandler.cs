using System;
using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class AddSingleLabelHandler : IAddSingleCommandHandler<AddSingleLabel>
{
    private readonly LabelRepository _labelRepository;

    public AddSingleLabelHandler(LabelRepository labelRepository)
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