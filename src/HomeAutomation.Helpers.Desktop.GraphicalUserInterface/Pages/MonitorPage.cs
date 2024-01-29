using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.Constants;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects.External;
using HomeAutomation.Helpers.Desktop.Application.Queries;
using HomeAutomation.Helpers.Desktop.Application.Services;
using HomeAutomation.Helpers.Desktop.Core.Entities;
using HomeAutomation.Helpers.Desktop.Infrastructure.Commands;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class MonitorPage : UserControl
{
    private readonly ICommandSender _commandSender;
    private readonly IQuerySender _querySender;
    private readonly ITcpService _tcpService;

    private ConnectionDto _connection { get; set; }

    public MonitorPage(
        ICommandSender commandSender,
        IQuerySender querySender,
        ITcpService tcpService)
    {
        _commandSender = commandSender;
        _querySender = querySender;
        _tcpService = tcpService;

        InitializeComponent();
    }

    public void ReceiveConnection(ConnectionDto connection)
    {
        _connection = connection;

        LoadConnectionGroupBox();
        LoadDevicesListBox();
    }

    private void SelectedDevicesSetDeviceButtonClick(object sender, EventArgs e)
    {
        var macAddress = SelectedDeviceMacAddressLabel.Text;

        var deviceName = SelectedDeviceNameLabel.Text;
        var newDeviceName = SelectedDeviceNewNameTextBox.Text;

        var newValues = new List<string>();

        if (SelectedDeviceTypeLabel.Text == DeviceTypes.Digital)
        {
            var newDigitalValue = SelectedDigitalDeviceNewValueTextBox.Text;

            if (string.IsNullOrEmpty(newDigitalValue))
            {
                MessageBox.Show("Please enter a digital value!");

                return;
            }

            newValues.Add(newDigitalValue);
        }
        else
        {
            var newAnalogRedValue = SelectedAnalogDeviceNewRedValueTextBox.Text;

            if (string.IsNullOrEmpty(newAnalogRedValue))
            {
                MessageBox.Show("Please enter analog red value!");

                return;
            }

            newValues.Add(newAnalogRedValue);

            var newAnalogGreenValue = SelectedAnalogDeviceNewGreenValueTextBox.Text;

            if (string.IsNullOrEmpty(newAnalogGreenValue))
            {
                MessageBox.Show("Please enter analog green value!");

                return;
            }

            newValues.Add(newAnalogGreenValue);

            var newAnalogBlueValue = SelectedAnalogDeviceNewBlueValueTextBox.Text;

            if (string.IsNullOrEmpty(newAnalogBlueValue))
            {
                MessageBox.Show("Please enter analog blue value!");

                return;
            }

            newValues.Add(newAnalogBlueValue);
        }

        try
        {
            _tcpService.SetSingleDevice(
                _connection.IpAddress,
                _connection.Port,
                macAddress,
                SelectedDeviceTypeLabel.Text,
                newValues[0] == "1",
                newValues.Count == 3 ? Convert.ToInt32(newValues[0]) : 0,
                newValues.Count == 3 ? Convert.ToInt32(newValues[1]) : 0,
                newValues.Count == 3 ? Convert.ToInt32(newValues[2]) : 0);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occured, try again.\nError message: {ex.Message}");

            return;
        }

        if (string.IsNullOrEmpty(deviceName))
        {
            var command = new AddSingleDevice
            {
                MacAddress = macAddress,
                Name = newDeviceName
            };

            _commandSender.SendAddSingle(command);
        }

        SelectedDeviceNewNameTextBox.Text = string.Empty;
        SelectedDigitalDeviceNewValueTextBox.Text = string.Empty;
        SelectedAnalogDeviceNewRedValueTextBox.Text = string.Empty;
        SelectedAnalogDeviceNewGreenValueTextBox.Text = string.Empty;
        SelectedAnalogDeviceNewBlueValueTextBox.Text = string.Empty;

        LoadConnectionGroupBox();
        LoadDevicesListBox();
        SelectDeviceButtonClick(sender, e);

        MessageBox.Show("Changed!");
    }

    private void WriteSelectedDevice(string deviceName, DeviceReadingDto deviceReading)
    {
        SelectedDeviceMonitorGroupBox.Visible = true;
        SelectedDeviceControlGroupBox.Visible = true;

        SelectedDeviceNameLabel.Text = deviceName;
        SelectedDeviceMacAddressLabel.Text = deviceReading.MacAddress;
        SelectedDeviceTypeLabel.Text = deviceReading.DeviceType;

        if (deviceReading.DeviceType == DeviceTypes.Digital)
        {
            SelectedAnalogDeviceValuesLabelLabel.Visible = false;
            SelectedDigitalDeviceLabelLabel.Visible = true;

            SelectedAnalogDeviceRedValueLabel.Text = string.Empty;
            SelectedAnalogDeviceGreenValueLabel.Text = string.Empty;
            SelectedAnalogDeviceBlueValueLabel.Text = string.Empty;

            SelectedDigitalDeviceLabelLabel.Visible = true;
            SelectedDigitalDeviceValueLabel.Text = deviceReading.DigitalSwitch.ToString();

            SelectedDigitalDeviceNewValueLabel.Visible = true;
            SelectedDigitalDeviceNewValueTextBox.Visible = true;

            SelectedAnalogDeviceNewRedValueLabel.Visible = false;
            SelectedAnalogDeviceNewRedValueTextBox.Visible = false;
            SelectedAnalogDeviceNewGreenValueLabel.Visible = false;
            SelectedAnalogDeviceNewGreenValueTextBox.Visible = false;
            SelectedAnalogDeviceNewBlueValueLabel.Visible = false;
            SelectedAnalogDeviceNewBlueValueTextBox.Visible = false;
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

            SelectedDigitalDeviceNewValueLabel.Visible = false;
            SelectedDigitalDeviceNewValueTextBox.Visible = false;

            SelectedAnalogDeviceNewRedValueLabel.Visible = true;
            SelectedAnalogDeviceNewRedValueTextBox.Visible = true;
            SelectedAnalogDeviceNewGreenValueLabel.Visible = true;
            SelectedAnalogDeviceNewGreenValueTextBox.Visible = true;
            SelectedAnalogDeviceNewBlueValueLabel.Visible = true;
            SelectedAnalogDeviceNewBlueValueTextBox.Visible = true;
        }
    }

    public void SelectDeviceButtonClick(object sender, EventArgs e)
    {
        var selectedDeviceName = (DevicesListBox.SelectedItem ?? "").ToString();

        if (string.IsNullOrEmpty(selectedDeviceName))
        {
            MessageBox.Show("Please select device!");

            return;
        }

        var allDevicesQuery = new GetMultipleDevices();

        var allDevices = _querySender.SendGetMultiple<GetMultipleDevices, DeviceDto>(allDevicesQuery);

        var name = string.Empty;

        if (allDevices.Select(x => x.Name).Contains(selectedDeviceName))
        {
            var device = allDevices.First(x => x.Name == selectedDeviceName);

            selectedDeviceName = device.MacAddress;
            name = device.Name;
        }

        try
        {
            var deviceReading =
                _tcpService.GetSingleDevice(
                    _connection.IpAddress,
                    _connection.Port,
                    selectedDeviceName);

            WriteSelectedDevice(name, deviceReading);
        }
        catch (Exception ex)
        {
            MessageBox.Show($"An error occured, try again.\nError message: {ex.Message}");
        }
    }

    private void LoadDevicesListBox()
    {
        try
        {
            DevicesListBox.Items.Clear();

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
        catch (Exception ex)
        {
            MessageBox.Show($"An error occured, try again.\nError message: {ex.Message}");
        }
    }

    private void DevicesVerticalScrollBarScroll(object sender, ScrollEventArgs e)
    {
        DevicesListBox.TopIndex = DevicesVerticalScrollBar.Value;
    }

    private void LoadConnectionGroupBox()
    {
        ConnectionIpAddressLabel.Text = _connection.IpAddress;
        ConnectionPortLabel.Text = _connection.Port.ToString();
    }
}