using System;
using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class UpdateSingleLabel : ICommand
{
    public Guid Id { get; set; }

    public string Text { get; set; }
}