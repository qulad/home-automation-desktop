using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class DeleteSingleLabelHandler : IDeleteSingleCommandHandler<DeleteSingleLabel>
{
    private readonly LabelRepository _labelRepository;

    public DeleteSingleLabelHandler(LabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public void Handle(DeleteSingleLabel command)
    {
        _labelRepository.Delete(command.Id);
    }
}