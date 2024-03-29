using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetSingleConnectionHandler : IGetSingleQueryHandler<GetSingleConnection, ConnectionDto>
{
    private readonly IConnectionRepository<ConnectionEntity, ConnectionDto> _connectionRepository;

    public GetSingleConnectionHandler(IConnectionRepository<ConnectionEntity, ConnectionDto> connectionRepository)
    {
        _connectionRepository = connectionRepository;
    }

    public ConnectionDto Handle(GetSingleConnection command)
    {
        return _connectionRepository.GetById(command.Id);
    }
}