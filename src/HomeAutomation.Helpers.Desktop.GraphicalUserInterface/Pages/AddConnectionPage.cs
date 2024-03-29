﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.Commands;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries;
using HomeAutomation.Helpers.Desktop.Infrastructure.Commands;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class AddConnectionPage : UserControl
{
    private readonly ICommandSender _commandSender;
    private readonly IQuerySender _querySender;

    private const string IpAddressPattern = @"\b\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}\b";
    private const string PortPattern = @"^(?:0|6553[0-5]|655[0-2]\d|65[0-4]\d{2}|6[0-4]\d{3}|[1-5]\d{4}|[1-9]\d{0,3})$";

    public AddConnectionPage(
        ICommandSender commandSender,
        IQuerySender querySender)
    {
        _commandSender = commandSender;
        _querySender = querySender;

        InitializeComponent();

        LoadExistingLabelsCheckedListBox();
    }

    private void AddConnectionButtonClick(object sender, EventArgs e)
    {
        var connectionName = ConnectionNameTextBox.Text;

        if (string.IsNullOrEmpty(connectionName))
        {
            MessageBox.Show("Please enter a connection name!");

            ConnectionNameTextBox.Text = string.Empty;
            ConnectionPortMaskedTextBox.Text = string.Empty;
            ConnectionIpAddressMaskedTextBox.Text = string.Empty;

            return;
        }

        if (string.IsNullOrEmpty(ConnectionPortMaskedTextBox.Text))
        {
            MessageBox.Show("Invalid port!");

            ConnectionNameTextBox.Text = string.Empty;
            ConnectionPortMaskedTextBox.Text = string.Empty;
            ConnectionIpAddressMaskedTextBox.Text = string.Empty;

            return;
        }

        var port = Convert.ToInt32(ConnectionPortMaskedTextBox.Text);

        if (!IsPortValid(port))
        {
            MessageBox.Show("Invalid port!");

            ConnectionNameTextBox.Text = string.Empty;
            ConnectionPortMaskedTextBox.Text = string.Empty;
            ConnectionIpAddressMaskedTextBox.Text = string.Empty;

            return;
        }

        var ipAddress = new string(ConnectionIpAddressMaskedTextBox.Text.ToCharArray().Where(x => !Char.IsWhiteSpace(x)).ToArray());

        if (!IsIpAddressValid(ipAddress))
        {
            MessageBox.Show("Invalid IP!");

            ConnectionNameTextBox.Text = string.Empty;
            ConnectionPortMaskedTextBox.Text = string.Empty;
            ConnectionIpAddressMaskedTextBox.Text = string.Empty;

            return;
        }

        var newLabels = NewLabelListBox.Items.Cast<string>().ToList();

        if (newLabels.Count > 0)
        {
            var AddMultipleLabelCommand = new AddMultipleLabels()
            {
                Texts = newLabels
            };

            _commandSender.SendAddMultiple(AddMultipleLabelCommand);
        }

        var checkedLabels = ExistingLabelsCheckedListBox.CheckedItems.Cast<string>().ToList();

        var labels = new List<string>();
        labels.AddRange(checkedLabels);
        labels.AddRange(newLabels);

        var labelIds = new List<Guid>();

        if (labels.Count > 0)
        {
            var getMultipleLabelQuery = new GetMultipleLabels
            {
                Texts = labels
            };

            var existingLabelIds = _querySender.SendGetMultiple<GetMultipleLabels, LabelDto>(getMultipleLabelQuery).Select(x => x.Id).ToList();

            labelIds.AddRange(existingLabelIds);
        }

        var addConnectionCommand = new AddSingleConnection
        {
            IpAddress = ipAddress,
            Port = port,
            Name = connectionName
        };

        if (labelIds.Count > 0)
        {
            addConnectionCommand.LabelIds = labelIds;
        }
        else
        {
            addConnectionCommand.LabelIds = new List<Guid>();
        }

        _commandSender.SendAddSingle(addConnectionCommand);

        ConnectionNameTextBox.Text = string.Empty;
        ConnectionPortMaskedTextBox.Text = string.Empty;
        ConnectionIpAddressMaskedTextBox.Text = string.Empty;

        MessageBox.Show("Connection added!");

        LoadExistingLabelsCheckedListBox();
    }

    private void LoadExistingLabelsCheckedListBox()
    {
        ExistingLabelsCheckedListBox.Items.Clear();

        var query = new GetMultipleLabels();

        var labels = _querySender.SendGetMultiple<GetMultipleLabels, LabelDto>(query);

        var labelTexts = labels.Select(x => x.Text).ToArray();

        ExistingLabelsCheckedListBox.Items.AddRange(labelTexts);
    }

    private void AddNewLabelButtonClick(object sender, EventArgs e)
    {
        var labelText = NewLabelTextBox.Text;

        if (string.IsNullOrEmpty(labelText))
        {
            MessageBox.Show("New label name cannot be empty!");

            NewLabelTextBox.Text = string.Empty;

            return;
        }

        var query = new GetMultipleLabels();

        var labels = _querySender.SendGetMultiple<GetMultipleLabels, LabelDto>(query);

        if (labels.Select(x => x.Text).Contains(labelText))
        {
            MessageBox.Show("This label already exists!");

            NewLabelTextBox.Text = string.Empty;

            return;
        }

        if (NewLabelListBox.Items.Contains(labelText))
        {
            MessageBox.Show("This label already exists!");

            NewLabelTextBox.Text = string.Empty;

            return;
        }

        NewLabelListBox.Items.Add(labelText);

        NewLabelTextBox.Text = string.Empty;
    }

    private static bool IsIpAddressValid(string ipAddress)
    {
        var ipAddressValid = Regex.IsMatch(ipAddress, IpAddressPattern);

        return ipAddressValid;
    }

    private static bool IsPortValid(int port)
    {
        var portValid = Regex.IsMatch(port.ToString(), PortPattern);

        return portValid;
    }
}