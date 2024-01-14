using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class AddMultipleLabels : ICommand
{
    public IList<string> Texts { get; set; }
}