using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class AddSingleLabel : ICommand
{
    public string Text { get; set; }
}