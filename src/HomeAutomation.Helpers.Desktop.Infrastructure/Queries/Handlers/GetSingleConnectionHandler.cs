using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetSingleConnectionHandler : IGetSingleQueryHandler<GetSingleConnection, ConnectionDto>
{
    private readonly ConnectionRepository _connectionRepository;

    public GetSingleConnectionHandler(ConnectionRepository connectionRepository)
    {
        _connectionRepository = connectionRepository;
    }

    public ConnectionDto Handle(GetSingleConnection command)
    {
        return _connectionRepository.GetById(command.Id);
    }
}