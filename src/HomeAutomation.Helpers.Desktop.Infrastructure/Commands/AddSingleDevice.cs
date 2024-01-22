using HomeAutomation.Helpers.Desktop.Application.Commands;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Commands;

public class AddSingleDevice : ICommand
{
    public string MacAddress { get; set; }
    public string Name { get; set; }
}