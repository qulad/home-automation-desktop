﻿using System;
using System.Linq;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.Constants;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class SelectConnectionPage : UserControl
{
    private readonly BasePage _basePage;
    private readonly IQuerySender _querySender;

    public SelectConnectionPage(BasePage basePage, IQuerySender querySender)
    {
        _basePage = basePage;
        _querySender = querySender;

        InitializeComponent();

        LoadConnectionListBox();
    }

    private void LoadConnectionListBox()
    {
        ConnectionsListBox.Items.Clear();

        var query = new GetMultipleConnections();

        var connectionNames = _querySender.SendGetMultiple<GetMultipleConnections, ConnectionDto>(query).Select(x => x.Name).ToArray();

        ConnectionsListBox.Items.AddRange(connectionNames);
    }

    private void SelectConnectionButtonClick(object sender, EventArgs e)
    {
        var selectedConnectionName = (ConnectionsListBox.SelectedItem ?? "").ToString();

        if (string.IsNullOrEmpty(selectedConnectionName))
        {
            MessageBox.Show(SelectConnectionPageTexts.SelectConnection);

            LoadConnectionListBox();

            return;
        }

        var query = new GetMultipleConnections();

        var connections = _querySender.SendGetMultiple<GetMultipleConnections, ConnectionDto>(query);

        var selectedConnection = connections.Find(x => x.Name == selectedConnectionName);

        if (selectedConnection is null)
        {
            MessageBox.Show(SelectConnectionPageTexts.ConnectionNotFound);

            LoadConnectionListBox();

            return;
        }

        Hide();

        (ParentForm as MainWindow).SendConnectionToMonitorPage(selectedConnection);

        _basePage.Show<MonitorPage>();
    }

    public void HomePageButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<HomePage>();
    }
}