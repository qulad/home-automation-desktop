using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;
using HomeAutomation.Helpers.Desktop.Application.Services;

namespace HomeAutomation.Helpers.Desktop.Infrastructure.Services;

public class TcpService : ITcpService
{
    private const int Digital = 0;
    private readonly TcpClient _tcpClient;

    public TcpService(TcpClient tcpClient)
    {
        _tcpClient = tcpClient;
    }

    public List<DeviceReadingDto> GetAllDevices(string ipAddress, int port)
    {
        _tcpClient.Connect(ipAddress, port);

        var stream = _tcpClient.GetStream();

        var writeData = Encoding.ASCII.GetBytes("0");
        stream.Write(writeData, 0, writeData.Length);

        byte[] readBuffer = new byte[1024];
        int bytesRead;

        var deviceReadings = new List<DeviceReadingDto>();

        while (true)
        {
            bytesRead = stream.Read(readBuffer, 0, readBuffer.Length);
            var readData = Encoding.ASCII.GetString(readBuffer, 0, bytesRead);
            
            if (readData == "exit")
            {
                break;
            }

            var datas = readData.Split(",").ToList();

            var deviceReading = new DeviceReadingDto
            {
                MacAddress = datas[0],
                DeviceType = Convert.ToInt32(datas[1])
            };

            if (deviceReading.DeviceType == Digital)
            {
                deviceReading.DigitalSwitch = Convert.ToBoolean(datas[2]);
            }
            else
            {
                deviceReading.AnalogRed = Convert.ToInt32(datas[2]);
                deviceReading.AnalogGreen = Convert.ToInt32(datas[3]);
                deviceReading.AnalogBlue = Convert.ToInt32(datas[4]);
            }
        }

        _tcpClient.Close();

        return deviceReadings;
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