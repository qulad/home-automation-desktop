using System;

namespace HomeAutomation.Helpers.Desktop.Core.Entities.Base;

public class BaseEntity
{
    public Guid Id { get; set; }

    public BaseEntity(Guid id)
    {
        Id = id;
    }
}