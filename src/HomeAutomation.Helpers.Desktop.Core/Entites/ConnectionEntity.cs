using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Core.Entities.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Entities;

public partial class ConnectionEntity : BaseEntity
{
    public int Port { get; private set; }
    public string Name { get; set; }
    public IList<Guid> LabelIds { get; set; }
}