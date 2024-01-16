using System;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class AboutPage : UserControl
{
    private readonly BasePage _basePage;

    public AboutPage(BasePage basePage)
    {
        _basePage = basePage;

        InitializeComponent();

        LoadAboutLabelText();
    }

    private void LoadAboutLabelText()
    {
        AboutLabel.Text = "Bu uygulama bitirme projemizin bir parçaşıdır.\nAhmet Ertuğrul KAYA ve Eren AY";
    }

    private void HomePageButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<HomePage>();
    }
}