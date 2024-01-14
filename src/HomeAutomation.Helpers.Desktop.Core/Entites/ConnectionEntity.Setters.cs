using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace HomeAutomation.Helpers.Desktop.Core.Entities;

public partial class ConnectionEntity
{
    public ConnectionEntity(Guid id) : base(id)
    {
    }

    public void SetPort(int port)
    {
        if (!IsPortValid(port))
        {
            throw new ArgumentException("Invalid port");
        }

        Port = port;
    }

    public void SetLabels(IList<Guid> labelIds)
    {
        LabelIds = labelIds;
    }

    private static bool IsPortValid(int port)
    {
        var portPattern = @"^(?:0|6553[0-5]|655[0-2]\d|65[0-4]\d{2}|6[0-4]\d{3}|[1-5]\d{4}|[1-9]\d{0,3})$";
        var portValid = Regex.IsMatch(port.ToString(), portPattern);

        return portValid;
    }
}