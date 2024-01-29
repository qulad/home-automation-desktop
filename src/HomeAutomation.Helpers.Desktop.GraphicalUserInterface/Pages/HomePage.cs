using System;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class HomePage : UserControl
{

    public HomePage()
    {
        InitializeComponent();
    }

    private void HomePageLoad(object sender, EventArgs e)
    {
        TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        TimeLabel.Text = DateTime.Now.ToString("HH:mm:ss");
    }
}