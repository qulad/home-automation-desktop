using HomeAutomation.Helpers.Desktop.Core.Entities.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Entities;

public partial class DeviceEntity : BaseEntity
{
    public string MacAddress { get; set; }
    public string Name { get; set; }
}