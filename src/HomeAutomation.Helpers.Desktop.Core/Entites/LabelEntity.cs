using System;
using HomeAutomation.Helpers.Desktop.Core.Entities.Base;

namespace HomeAutomation.Helpers.Desktop.Core.Entities;

public class LabelEntity : BaseEntity
{
    public string Text { get; set; }

    public LabelEntity(Guid id) : base(id)
    {
    }
}