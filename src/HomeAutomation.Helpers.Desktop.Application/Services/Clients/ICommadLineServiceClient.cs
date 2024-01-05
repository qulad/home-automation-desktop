using System.Collections.Generic;

namespace HomeAutomation.Helpers.Desktop.Application.Services.Clients;

public interface  ICommandLineServiceClient
{
    public string ExecuteCommand(string command, IList<string> args = null, IDictionary<string, string> kwargs = null);
}