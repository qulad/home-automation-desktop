using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

public class BasePage
{
    private readonly IServiceProvider _serviceProvider;

    public BasePage(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public void Show<TPage>() where TPage : UserControl
    {
        var page = _serviceProvider.GetRequiredService<TPage>();

        page.Show();
    }

    public void Hide<TPage>() where TPage : UserControl
    {
        var page = _serviceProvider.GetRequiredService<TPage>();

        page.Hide();
    }
}