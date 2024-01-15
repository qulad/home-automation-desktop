using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetSingleLabelHandler : IGetSingleQueryHandler<GetSingleLabel, LabelDto>
{
    private readonly ILabelRepository<LabelEntity, LabelDto> _labelRepository;

    public GetSingleLabelHandler(ILabelRepository<LabelEntity, LabelDto> labelRepository)
    {
        _labelRepository = labelRepository;
    }

    public LabelDto Handle(GetSingleLabel command)
    {
        return _labelRepository.GetById(command.Id);
    }
}