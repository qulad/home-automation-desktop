using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class DeleteSingleConnectionHandler : IDeleteSingleCommandHandler<DeleteSingleConnection>
{
    private readonly IConnectionRepository<ConnectionEntity, ConnectionDto> _connectionRepository;

    public DeleteSingleConnectionHandler(IConnectionRepository<ConnectionEntity, ConnectionDto> connectionRepository)
    {
        _connectionRepository = connectionRepository;
    }

    public void Handle(DeleteSingleConnection command)
    {
        _connectionRepository.Delete(command.Id);
    }
}