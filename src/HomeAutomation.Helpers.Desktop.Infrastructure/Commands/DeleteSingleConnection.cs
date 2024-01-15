using System;
using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class DeleteSingleConnection : ICommand
{
    public Guid Id { get; set; }
}