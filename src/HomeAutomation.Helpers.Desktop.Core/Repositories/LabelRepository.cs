using System;
using System.Collections.Generic;
using System.Linq;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories;

public class LabelRepository : BaseRepositery<LabelEntity>
{
    public LabelRepository(DbContext dbContext) : base(dbContext)
    {
    }
}