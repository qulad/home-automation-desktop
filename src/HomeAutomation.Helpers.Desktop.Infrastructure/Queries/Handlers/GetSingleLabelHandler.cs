using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetSingleLabelHandler : IGetSingleQueryHandler<GetSingleLabel, LabelDto>
{
    private readonly LabelRepository _labelRepository;

    public GetSingleLabelHandler(LabelRepository labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public LabelDto Handle(GetSingleLabel command)
    {
        return _labelRepository.GetById(command.Id);
    }
}