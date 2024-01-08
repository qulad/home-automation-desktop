using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories;

public class LabelRepository : BaseRepositery<LabelEntity, LabelDto>, ILabelRepository<LabelEntity, LabelDto>
{
    public LabelRepository(DbContext dbContext) : base(dbContext)
    {
    }
}