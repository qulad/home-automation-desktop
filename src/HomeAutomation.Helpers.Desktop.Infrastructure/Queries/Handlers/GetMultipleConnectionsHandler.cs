using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetMultipleConnectionsHandler : IGetMultipleQueryHandler<GetMultipleConnections, ConnectionDto>
{
    private readonly IConnectionRepository<ConnectionEntity, ConnectionDto> _connectionRepository;

    public GetMultipleConnectionsHandler(IConnectionRepository<ConnectionEntity, ConnectionDto> connectionRepository)
    {
        _connectionRepository = connectionRepository;
    }

    public List<ConnectionDto> Handle(GetMultipleConnections command)
    {
        var predicate = GetPredicate(command);

        if (predicate is null)
        {
            return _connectionRepository.GetAll().ToList();
        }
        else
        {
            return _connectionRepository.GetByPredicate(predicate).ToList();
        }
    }

    private static Func<ConnectionEntity, bool> GetPredicate(GetMultipleConnections command)
    {
        Func<ConnectionEntity, bool> predicate = null;

        if (command.Ids is not null && command.Ids.Count > 0)
        {
            if (command.Ids.Count == 1)
            {
                var id = command.Ids[0];

                predicate = label => label.Id == id;
            }
            else
            {
                predicate = label => command.Ids.Contains(label.Id);
            }
        }

        return predicate;
    }
}