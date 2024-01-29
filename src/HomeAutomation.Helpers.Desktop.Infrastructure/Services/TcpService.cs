using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using HomeAutomation.Helpers.Desktop.Application.Constants;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;
using HomeAutomation.Helpers.Desktop.Application.Services;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Services;

public class TcpService : ITcpService
{
    private const string Digital = "0";
    private readonly TcpClient _tcpClient;

    public TcpService(TcpClient tcpClient)
    {
        _tcpClient = tcpClient;
    }

    public List<DeviceReadingDto> GetAllDevices(string ipAddress, int port)
    {
        _tcpClient.Connect(ipAddress, port);

        var stream = _tcpClient.GetStream();

        var writeData = Encoding.UTF8.GetBytes("0");
        stream.Write(writeData, 0, writeData.Length);

        byte[] readBuffer = new byte[1024];
        int bytesRead;

        var deviceReadings = new List<DeviceReadingDto>();

        while (true)
        {
            bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);
            var readData = Encoding.UTF8.GetString(readBuffer, 0, bytesRead);

            if (readData == "exit")
            {
                break;
            }

            var datas = readData.Split(",").ToList();

            var deviceReading = new DeviceReadingDto
            {
                MacAddress = datas[0]
            };

            if (datas[1] == Digital)
            {
                deviceReading.DeviceType = DeviceTypes.Digital;

                deviceReading.DigitalSwitch = datas[2] == "1";
            }
            else
            {
                deviceReading.DeviceType = DeviceTypes.Analog;

                deviceReading.AnalogRed = Convert.ToInt32(datas[2]);
                deviceReading.AnalogGreen = Convert.ToInt32(datas[3]);
                deviceReading.AnalogBlue = Convert.ToInt32(datas[4]);
            }

            deviceReadings.Add(deviceReading);
        }

        _tcpClient.Close();

        return deviceReadings;
    }

    public DeviceReadingDto GetSingleDevice(string ipAddress, int port, string mac)
    {
        _tcpClient.Connect(ipAddress, port);

        var stream = _tcpClient.GetStream();

        var writeData = Encoding.UTF8.GetBytes("1" + mac);
        stream.Write(writeData, 0, writeData.Length);

        byte[] readBuffer = new byte[1024];
        int bytesRead;

        var deviceReading = new DeviceReadingDto();

        while (true)
        {
            bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);
            var readData = Encoding.UTF8.GetString(readBuffer, 0, bytesRead);

            if (readData == "exit")
            {
                break;
            }

            var datas = readData.Split(",").ToList();

            deviceReading.MacAddress = datas[0];

            if (datas[1] == Digital)
            {
                deviceReading.DeviceType = DeviceTypes.Digital;

                deviceReading.DigitalSwitch = Convert.ToBoolean(datas[2]);
            }
            else
            {
                deviceReading.DeviceType = DeviceTypes.Analog;

                deviceReading.AnalogRed = Convert.ToInt32(datas[2]);
                deviceReading.AnalogGreen = Convert.ToInt32(datas[3]);
                deviceReading.AnalogBlue = Convert.ToInt32(datas[4]);
            }
        }

        _tcpClient.Close();

        return deviceReading;
    }

    public void SetSingleDevice(
        string ipAddress,
        int port,
        string mac,
        string deviceType,
        bool? digitalSwitch,
        int? analogRed,
        int? analogGreen,
        int? analogBlue)
    {
        _tcpClient.Connect(ipAddress, port);

        var stream = _tcpClient.GetStream();

        var message = "2" + mac;

        if (deviceType == DeviceTypes.Digital)
        {
            if (!digitalSwitch.HasValue)
            {
                throw new ArgumentNullException(nameof(digitalSwitch));
            }

            if (digitalSwitch.Value)
            {
                message += "1";
            }
            else
            {
                message += "0";
            }
        }
        else
        {
            if (!analogRed.HasValue)
            {
                throw new ArgumentNullException(nameof(analogRed));
            }

            if (!analogGreen.HasValue)
            {
                throw new ArgumentNullException(nameof(analogGreen));
            }

            if (!analogBlue.HasValue)
            {
                throw new ArgumentNullException(nameof(analogBlue));
            }

            message += analogRed.Value.ToString() + "," + analogGreen.Value.ToString() + "," + analogBlue.Value.ToString();
        }

        var writeData = Encoding.UTF8.GetBytes(message);
        stream.Write(writeData, 0, writeData.Length);

        _tcpClient.Close();
    }
}