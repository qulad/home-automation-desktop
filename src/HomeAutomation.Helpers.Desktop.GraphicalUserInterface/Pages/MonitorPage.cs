using System;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class MonitorPage : UserControl
{
    private readonly BasePage _basePage;

    public MonitorPage(BasePage basePage)
    {
        _basePage = basePage;

        InitializeComponent();
    }

    private void HomePageButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<HomePage>();
    }
}