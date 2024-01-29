using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using HomeAutomation.Helpers.Desktop.Application.Constants;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;
using HomeAutomation.Helpers.Desktop.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Services;

public class TcpService : ITcpService
{
    private const string Digital = "0";
    private readonly IServiceProvider _serviceProvider;

    public TcpService(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public List<DeviceReadingDto> GetAllDevices(string ipAddress, int port)
    {
        try
        {            
            var tcpClient = _serviceProvider.GetRequiredService<TcpClient>();

            tcpClient.Connect(ipAddress, port);

            var stream = tcpClient.GetStream();

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

            tcpClient.Close();

            return deviceReadings;
        }
        catch(Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }

    public DeviceReadingDto GetSingleDevice(string ipAddress, int port, string mac)
    {
        try
        {
            var tcpClient = _serviceProvider.GetRequiredService<TcpClient>();

            tcpClient.Connect(ipAddress, port);

            var stream = tcpClient.GetStream();

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

                    deviceReading.DigitalSwitch = datas[2] == "1";
                }
                else
                {
                    deviceReading.DeviceType = DeviceTypes.Analog;

                    deviceReading.AnalogRed = Convert.ToInt32(datas[2]);
                    deviceReading.AnalogGreen = Convert.ToInt32(datas[3]);
                    deviceReading.AnalogBlue = Convert.ToInt32(datas[4]);
                }
            }

            tcpClient.Close();

            return deviceReading;
        }
        catch(Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
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
        try
        {
            var tcpClient = _serviceProvider.GetRequiredService<TcpClient>();

            tcpClient.Connect(ipAddress, port);

            var stream = tcpClient.GetStream();

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

                message += analogRed.Value.ToString("000") + analogGreen.Value.ToString("000") + analogBlue.Value.ToString("000");
            }

            var writeData = Encoding.UTF8.GetBytes(message);
            stream.Write(writeData, 0, writeData.Length);

            tcpClient.Close();
        }
        catch(Exception ex)
        {
            throw new ArgumentException(ex.Message);
        }
    }
}