using System;

namespace HomeAutomation.Helpers.Desktop.Core.Entities.Base;

public class BaseEntity
{
    public Guid Id { get; set; }

    protected BaseEntity(Guid id)
    {
        Id = id;
    }
}