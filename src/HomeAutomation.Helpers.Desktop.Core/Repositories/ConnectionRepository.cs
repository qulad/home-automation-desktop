using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Repositories;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories;

public class ConnectionRepository : BaseRepositery<ConnectionEntity, ConnectionDto>, IConnectionRepository<ConnectionEntity, ConnectionDto>
{
    public ConnectionRepository(DbContext dbContext) : base(dbContext)
    {
    }
}