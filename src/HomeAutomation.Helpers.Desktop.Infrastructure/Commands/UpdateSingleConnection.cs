using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class UpdateSingleConnection : ICommand
{
    public Guid Id { get; set; }

    public int Port { get; set; }

    public string Name { get; set; }

    public IList<Guid> LabelIds { get; set; }
}