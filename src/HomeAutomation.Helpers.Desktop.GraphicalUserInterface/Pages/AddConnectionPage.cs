using System;
using System.Linq;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.Application.Queries;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;
using HomeAutomation.Helpers.Desktop.Infrastructure.Queries;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class AddConnectionPage : UserControl
{
    private readonly BasePage _basePage;
    private readonly IQuerySender _querySender;

    public AddConnectionPage(BasePage basePage, IQuerySender querySender)
    {
        _basePage = basePage;
        _querySender = querySender;

        InitializeComponent();
    }

    private void HomePageButtonClick(object sender, EventArgs e)
    {
        Hide();

        _basePage.Show<HomePage>();
    }

    private void AddNewLabelButtonClick(object sender, EventArgs e)
    {
        var labelText = NewLabelTextBox.Text;

        if (string.IsNullOrEmpty(labelText))
        {
            MessageBox.Show("Etiket ismi boş olamaz!");

            NewLabelTextBox.Text = "";

            return;
        }

        var query = new GetMultipleLabels();

        var allLabels = _querySender.SendGetMultiple<GetMultipleLabels, LabelDto>(query);

        if (allLabels.Select(x => x.Text).Contains(labelText))
        {
            MessageBox.Show("Bu etiket zaten eklenmiş!");

            NewLabelTextBox.Text = "";

            return;
        }

        if (NewLabelListBox.Items.Contains(labelText))
        {
            MessageBox.Show("Bu etiket zaten eklenmiş!");

            NewLabelTextBox.Text = "";

            return;
        }

        NewLabelListBox.Items.Add(labelText);

        NewLabelTextBox.Text = "";
    }
}