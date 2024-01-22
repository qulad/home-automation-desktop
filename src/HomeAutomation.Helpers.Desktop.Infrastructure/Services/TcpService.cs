using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;
using HomeAutomation.Helpers.Desktop.Application.Services;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Services;

public class TcpService : ITcpService
{
    public List<DeviceReadingDto> GetAllDevices(string ipAddress, int port)
    {
        throw new System.NotImplementedException();
    }

    public DeviceReadingDto GetSingleDevice(string ipAddress, int port, string mac)
    {
        throw new System.NotImplementedException();
    }

    public void SetSingleDevice(string ipAddress, int port, string mac, bool digitalSwitch, int analogRed, int analogGreen, int analogBlue)
    {
        throw new System.NotImplementedException();
    }
}