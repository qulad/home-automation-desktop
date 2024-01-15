using System;
using HomeAutomation.Helpers.Desktop.Application.Queries;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

public class GetSingleLabel : IQuery
{
    public Guid Id { get; set; }
}