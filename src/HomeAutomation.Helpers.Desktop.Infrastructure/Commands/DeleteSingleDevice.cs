using System;
using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class DeleteSingleDevice : ICommand
{
    public Guid Id { get; set; }
}