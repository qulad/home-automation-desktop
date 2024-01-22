using System;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;

public class DeviceDto : BaseDataTransferObject
{
    public string MacAddress { get; set; }
    public string Name { get; set; }

    public DeviceDto(Guid id) : base(id)
    {
    }
}