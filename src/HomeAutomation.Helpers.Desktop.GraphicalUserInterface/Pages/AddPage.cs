using System;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class AddPage : UserControl
{
    private readonly BasePage _basePage;

    public AddPage(BasePage basePage)
    {
        _basePage = basePage;

        InitializeComponent();
    }

    public void HomePageButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<HomePage>();
    }
}