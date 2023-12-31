using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using HomeAutomation.Helpers.Desktop.Core.Entities.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Entities;

public class ConnectionEntity : BaseEntity
{
    public string IpAddress { get; private set; }
    public int Port { get; private set; }
    public string Name { get; set; }
    public IList<Guid> LabelIds { get; set; }

    public ConnectionEntity(Guid id) : base(id)
    {
    }

    public void SetIpAddress(string ipAddress)
    {
        if (!IsIpAddressValid(ipAddress))
        {
            throw new ArgumentException("Invalid IP address");
        }

        IpAddress = ipAddress;
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

    private static bool IsIpAddressValid(string ipAddress)
    {
        var ipPattern = @"\b(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\b";
        var ipValid = Regex.IsMatch(ipAddress, ipPattern);

        return ipValid;
    }

    private static bool IsPortValid(int port)
    {
        var portPattern = @"^(?:0|6553[0-5]|655[0-2]\d|65[0-4]\d{2}|6[0-4]\d{3}|[1-5]\d{4}|[1-9]\d{0,3})$";
        var portValid = Regex.IsMatch(port.ToString(), portPattern);

        return portValid;
    }
}