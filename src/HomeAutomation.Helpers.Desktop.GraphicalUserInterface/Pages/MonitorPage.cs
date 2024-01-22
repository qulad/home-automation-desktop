using System;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class MonitorPage : UserControl
{
    private readonly BasePage _basePage;

    private ConnectionDto _connection { get; set; }

    public MonitorPage(BasePage basePage)
    {
        _basePage = basePage;

        InitializeComponent();
    }

    public void ReceiveConnection(ConnectionDto connection)
    {
        MessageBox.Show($"Bağlantı ismi: {connection.Name}");

        _connection = connection;

        LoadConnectionGroupBox();
    }

    private void HomePageButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<HomePage>();
    }

    private void LoadConnectionGroupBox()
    {
        ConnectionIpAddressLabel.Text = _connection.IpAddress;
        ConnectionPortLabel.Text = _connection.Port.ToString();
    }
}