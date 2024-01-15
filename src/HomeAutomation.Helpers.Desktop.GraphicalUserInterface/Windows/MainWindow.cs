using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;
using Microsoft.Extensions.DependencyInjection;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;

public partial class MainWindow : Form
{
    private readonly BasePage _basePage;

    public MainWindow(BasePage basePage, IServiceProvider serviceProvider)
    {
        _basePage = basePage;

        var aboutPage = basePage.Get<AboutPage>();
        var addPage = basePage.Get<AddConnectionPage>();
        var homePage = basePage.Get<HomePage>();
        var monitorPage = basePage.Get<MonitorPage>();
        var selectConnectionPage = basePage.Get<SelectConnectionPage>();

        InitializeComponent();

        Controls.Add(aboutPage);
        Controls.Add(addPage);
        Controls.Add(homePage);
        Controls.Add(monitorPage);
        Controls.Add(selectConnectionPage);

        ShowPage(homePage);
    }

    public void SendConnectionToMonitorPage(ConnectionDto connection)
    {
        var monitorPage = _basePage.Get<MonitorPage>() as MonitorPage;

        monitorPage.ReceiveConnection(connection);
    } 

    private void ShowPage(UserControl pageToShow)
    {
        foreach (Control control in Controls)
        {
            if (control is UserControl userControl)
            {
                userControl.Hide();
            }
        }

        pageToShow.Show();
    }
}