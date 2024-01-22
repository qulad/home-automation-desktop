using System;
using System.Collections.Generic;

namespace HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;

public class DeviceReadingDto
{
    public string MacAddress { get; set; }
    public string DeviceType { get; set; }
    public bool DigitalSwitch { get; set; }
    public int AnalogRed { get; set; }
    public int AnalogGreen { get; set; }
    public int AnalogBlue { get; set; }

    public DeviceReadingDto()
    {
    }
}