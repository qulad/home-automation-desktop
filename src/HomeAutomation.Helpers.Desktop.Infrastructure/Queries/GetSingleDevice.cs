using System;
using HomeAutomation.Helpers.Desktop.Application.Queries;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

public class GetSingleDevice : IQuery
{
    public Guid Id { get; set; }

    public string MacAddress { get; set; }
}