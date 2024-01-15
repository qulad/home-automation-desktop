using System;
using HomeAutomation.Helpers.Desktop.Application.Queries;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

public class GetSingleConnection : IQuery
{
    public Guid Id { get; set; }
}