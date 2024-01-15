using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class DeleteSingleLabelHandler : IDeleteSingleCommandHandler<DeleteSingleLabel>
{
    private readonly ILabelRepository<LabelEntity, LabelDto> _labelRepository;

    public DeleteSingleLabelHandler(ILabelRepository<LabelEntity, LabelDto> labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public void Handle(DeleteSingleLabel command)
    {
        _labelRepository.Delete(command.Id);
    }
}