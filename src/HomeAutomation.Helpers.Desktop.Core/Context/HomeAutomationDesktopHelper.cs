using Microsoft.EntityFrameworkCore;

namespace HomeAutomation.Helpers.Desktop.Core.Context;

public class HomeAutomationDesktopHelper : DbContext
{
    public HomeAutomationDesktopHelper(DbContextOptions<HomeAutomationDesktopHelper> opitons) : base(opitons)
    {
    }
}