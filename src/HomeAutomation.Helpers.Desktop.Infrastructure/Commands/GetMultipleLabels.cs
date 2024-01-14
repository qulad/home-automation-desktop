using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class GetMultipleLabels : ICommand
{
    public IList<Guid> Ids { get; set; }

    public IList<string> Texts { get; set; }
}