using System;
using System.Linq;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.Constants;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;
using HomeAutomation.Helpers.Desktop.Application.Queries;
using HomeAutomation.Helpers.Desktop.Application.Services;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class MonitorPage : UserControl
{
    private readonly BasePage _basePage;
    private readonly IQuerySender _querySender;
    private readonly ITcpService _tcpService;

    private ConnectionDto _connection { get; set; }

    public MonitorPage(
        BasePage basePage,
        IQuerySender querySender,
        ITcpService tcpService)
    {
        _basePage = basePage;
        _querySender = querySender;
        _tcpService = tcpService;

        InitializeComponent();
    }

    public void ReceiveConnection(ConnectionDto connection)
    {
        MessageBox.Show($"Bağlantı ismi: {connection.Name}");

        _connection = connection;

        LoadConnectionGroupBox();
        LoadDevicesListBox();
    }

    private void WriteSelectedDevice(string deviceName, DeviceReadingDto deviceReading)
    {
        SelectedDeviceMonitorGroupBox.Visible = true;

        SelectedDeviceNameLabel.Text = deviceName;
        SelectedDeviceMacAddressLabel.Text = deviceReading.MacAddress;
        SelectedDeviceTypeLabel.Text = (deviceReading.DeviceType == DeviceTypes.Digital) ? "Dijital" : "Analog";

        if (deviceReading.DeviceType == DeviceTypes.Digital)
        {
            SelectedAnalogDeviceValuesLabelLabel.Visible = false;
            SelectedDigitalDeviceLabelLabel.Visible = true;

            SelectedAnalogDeviceRedValueLabel.Text = string.Empty;
            SelectedAnalogDeviceGreenValueLabel.Text = string.Empty;
            SelectedAnalogDeviceBlueValueLabel.Text = string.Empty;

            SelectedDigitalDeviceLabelLabel.Visible = true;
            SelectedDigitalDeviceValueLabel.Text = deviceReading.DigitalSwitch.ToString();
        }
        else
        {
            SelectedDigitalDeviceLabelLabel.Visible = false;
            SelectedAnalogDeviceValuesLabelLabel.Visible = true;

            SelectedDigitalDeviceLabelLabel.Visible = false;
            SelectedDigitalDeviceValueLabel.Text = string.Empty;

            SelectedAnalogDeviceRedValueLabel.Text = deviceReading.AnalogRed.ToString();
            SelectedAnalogDeviceGreenValueLabel.Text = deviceReading.AnalogGreen.ToString();
            SelectedAnalogDeviceBlueValueLabel.Text = deviceReading.AnalogBlue.ToString();
        }
    }

    public void SelectDeviceButtonClick(object sender, EventArgs e)
    {
        var selectedDeviceName = (DevicesListBox.SelectedItem ?? "").ToString();

        if (string.IsNullOrEmpty(selectedDeviceName))
        {
            MessageBox.Show("Lütfen cihaz seçiniz!");

            return;
        }

        var allDevicesQuery = new GetMultipleDevices();

        var allDevices = _querySender.SendGetMultiple<GetMultipleDevices, DeviceDto>(allDevicesQuery);

        if (allDevices.Select(x => x.Name).Contains(selectedDeviceName))
        {
            selectedDeviceName = allDevices.First(x => x.Name == selectedDeviceName).MacAddress;
        }

        var deviceReading = _tcpService.GetSingleDevice(_connection.IpAddress, _connection.Port, selectedDeviceName);

        WriteSelectedDevice(selectedDeviceName, deviceReading);

        SelectedDeviceControlGroupBox.Visible = true;
    }

    private void LoadDevicesListBox()
    {
        var deviceReadings = _tcpService.GetAllDevices(_connection.IpAddress, _connection.Port);

        var deviceMacAddresses = deviceReadings.Select(x => x.MacAddress).ToList();

        var query = new GetMultipleDevices
        {
            MacAddresses = deviceMacAddresses
        };

        var devices = _querySender.SendGetMultiple<GetMultipleDevices, DeviceDto>(query);

        foreach (var device in deviceReadings)
        {
            if (devices.Select(x => x.MacAddress).Contains(device.MacAddress))
            {
                DevicesListBox.Items.Add(devices.Where(x => x.MacAddress == device.MacAddress).Select(x => x.Name).First().ToString());
            }
            else
            {
                DevicesListBox.Items.Add(device.MacAddress);
            }
        }
    }

    private void DevicesVerticalScrollBarScroll(object sender, ScrollEventArgs e)
    {
        DevicesListBox.TopIndex = DevicesVerticalScrollBar.Value;
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