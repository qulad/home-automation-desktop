using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;

namespace HomeAutomation.Helpers.Desktop.Application.Services;

public interface ITcpService
{
    List<DeviceReadingDto> GetAllDevices(string ipAddress, int port);
    DeviceReadingDto GetSingleDevice(string ipAddress, int port, string mac);
    void SetSingleDevice(string ipAddress, int port, string mac, bool digitalSwitch, int analogRed, int analogGreen, int analogBlue);
}