using System;
using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class UpdateSingleDevice : ICommand
{
    public Guid Id { get; set; }
    public string MacAddress { get; set; }
    public string Name { get; set; }
}