using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries.Handlers;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries.Handlers;

public class GetMultipleConnectionsHandler : IGetMultipleQueryHandler<GetMultipleConnections, ConnectionDto>
{
    private readonly ConnectionRepository _connectionRepository;

    public GetMultipleConnectionsHandler(ConnectionRepository connectionRepository)
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

        if (command.Ids.Count > 0)
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