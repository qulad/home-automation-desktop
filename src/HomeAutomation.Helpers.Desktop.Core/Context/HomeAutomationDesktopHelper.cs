using HomeAutomation.Helpers.Desktop.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Context;

public class HomeAutomationDesktopHelper : DbContext
{
    public DbSet<ConnectionEntity> Connections { get; set; }
    public DbSet<LabelEntity> Labels { get; set; }

    public HomeAutomationDesktopHelper(DbContextOptions<HomeAutomationDesktopHelper> opitons) : base(opitons)
    {
    }
}