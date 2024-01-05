using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Core.Repositories.Base;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Repositories;

public class ConnectionRepository : BaseRepositery<Connection>
{
    public ConnectionRepository(DbContext dbContext) : base(dbContext)
    {
    }
}