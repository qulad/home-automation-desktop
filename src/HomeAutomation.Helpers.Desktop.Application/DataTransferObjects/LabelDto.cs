using System;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

namespace HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;

public class LabelDto : BaseDataTransferObject
{
    public string Text { get; set; }

    public LabelDto(Guid id) : base(id)
    {
    }
}