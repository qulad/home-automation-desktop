using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class UpdateSingleLabelHandler : IUpdateSingleCommandHandler<UpdateSingleLabel, LabelEntity>
{
    private readonly ILabelRepository<LabelEntity, LabelDto> _labelRepository;

    public UpdateSingleLabelHandler(ILabelRepository<LabelEntity, LabelDto> labelRepository)
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