using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Queries;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

public class GetMultipleConnections : IQuery
{
    public IList<Guid> Ids { get; set; }
}