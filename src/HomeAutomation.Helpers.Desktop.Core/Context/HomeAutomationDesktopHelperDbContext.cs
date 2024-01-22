using HomeAutomation.Helpers.Desktop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Context;

public class HomeAutomationDesktopHelperDbContext : DbContext
{
    public DbSet<ConnectionEntity> Connections { get; set; }
    public DbSet<DeviceEntity> Devices { get; set; }
    public DbSet<LabelEntity> Labels { get; set; }

    public HomeAutomationDesktopHelperDbContext(DbContextOptions<HomeAutomationDesktopHelperDbContext> opitons) : base(opitons)
    {
    }
}