using HomeAutomation.Helpers.Desktop.Application.Commands.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands.Handlers;

public class DeleteSingleConnectionHandler : IDeleteSingleCommandHandler<DeleteSingleConnection>
{
    private readonly ConnectionRepository _connectionRepository;

    public DeleteSingleConnectionHandler(ConnectionRepository connectionRepository)
    {
        _connectionRepository = connectionRepository;
    }

    public void Handle(DeleteSingleConnection command)
    {
        _connectionRepository.Delete(command.Id);
    }
}