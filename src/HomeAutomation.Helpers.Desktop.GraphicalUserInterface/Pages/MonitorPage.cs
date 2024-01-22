using System;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
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

    public void ReceiveConnection(ConnectionDto connection)
    {
        MessageBox.Show($"Bağlantı ismi: {connection.Name}");
    }

    private void NoSelectedDeviceLabel_Click(object sender, EventArgs e)
    {

    }
}