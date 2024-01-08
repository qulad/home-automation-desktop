using System;

namespace HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.Base;

public abstract class BaseDataTransferObject
{
    public Guid Id { get; set; }

    protected BaseDataTransferObject(Guid id)
    {
        Id = id;
    }
}