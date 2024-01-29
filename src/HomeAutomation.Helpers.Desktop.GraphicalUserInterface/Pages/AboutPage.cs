using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class AboutPage : UserControl
{
    public AboutPage(BasePage basePage)
    {
        InitializeComponent();

        LoadAboutLabelText();
    }

    private void LoadAboutLabelText()
    {
        AboutLabel.Text = "This app is a part of our graduation project.\nAhmet Ertuğrul KAYA and Eren AY";
    }
}