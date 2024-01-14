using System;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class HomePage : UserControl
{
    private readonly BasePage _basePage;

    public HomePage(BasePage basePage)
    {
        _basePage = basePage;

        InitializeComponent();
    }

    private void AboutButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<AboutPage>();
    }

    private void AddButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<AddPage>();
    }

    private void MonitorButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<MonitorPage>();
    }
}