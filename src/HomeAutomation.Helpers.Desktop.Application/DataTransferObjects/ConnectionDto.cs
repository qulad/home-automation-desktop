using System;
using System.Collections.Generic;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;

public class ConnectionDto : BaseDataTransferObject
{
    public int Port { get; set; }
    public string Name { get; set; }
    public IList<Guid> LabelIds { get; set; }

    public ConnectionDto(Guid id) : base(id)
    {
    }
}