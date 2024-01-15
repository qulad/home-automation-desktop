using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class UpdateSingleLabelHandler : IUpdateSingleCommandHandler<UpdateSingleLabel, LabelEntity>
{
    private readonly LabelRepository _labelRepository;

    public UpdateSingleLabelHandler(LabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public void Handle(UpdateSingleLabel command, LabelEntity existingEntity)
    {
        var entity = new LabelEntity(existingEntity.Id)
        {
            Text = command.Text
        };

        _labelRepository.Update(entity);
    }
}