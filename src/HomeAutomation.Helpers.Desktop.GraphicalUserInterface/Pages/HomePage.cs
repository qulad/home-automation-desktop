using System;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class HomePage : UserControl
{
    private readonly AboutPage _aboutPage;
    private readonly AddPage _addPage;
    private readonly MonitorPage _monitorPage;

    public HomePage(
        AboutPage aboutPage,
        AddPage addPage,
        MonitorPage monitorPage)
    {
        _aboutPage = aboutPage;
        _addPage = addPage;
        _monitorPage = monitorPage;

        InitializeComponent();
    }

    private void AboutButtonClick(object sender, EventArgs e)
    {
        Hide();

        _aboutPage.Show();
    }

    private void AddButtonClick(object sender, EventArgs e)
    {
        Hide();

        _addPage.Show();
    }

    private void MonitorButtonClick(object sender, EventArgs e)
    {
        Hide();

        _monitorPage.Show();
    }
}