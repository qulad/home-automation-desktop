using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.Services.Clients;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Services.Clients;

public class CommandLineServiceClient : ICommandLineServiceClient
{
    public string ExecuteCommand(string command, IList<string> args = null, IDictionary<string, string> kwargs = null)
    {
        throw new NotImplementedException();
    }
}