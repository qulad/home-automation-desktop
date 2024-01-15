using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Queries;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

public class GetMultipleLabels : IQuery
{
    public IList<Guid> Ids { get; set; }

    public IList<string> Texts { get; set; }
}