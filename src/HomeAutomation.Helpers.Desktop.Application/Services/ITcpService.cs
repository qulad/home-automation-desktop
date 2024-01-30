using System.Collections.Generic;
using System.Threading.Tasks;
using HomeAutomation.Helpers.Desktop.Application.Constants;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;

namespace HomeAutomation.Helpers.Desktop.Application.Services;

public interface ITcpService
{
    Task<List<DeviceReadingDto>> GetAllDevicesAsync(string ipAddress, int port);
    Task<DeviceReadingDto> GetSingleDeviceAsync(string ipAddress, int port, string mac);
    Task SetSingleDeviceAsync(
        string ipAddress,
        int port,
        string mac,
        string deviceType,
        bool? digitalSwitch,
        int? analogRed,
        int? analogGreen,
        int? analogBlue);
}