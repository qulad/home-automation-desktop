using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;

public partial class MainWindow : Form
{
    public MainWindow(
        AboutPage aboutPage,
        AddPage addPage,
        HomePage homePage)
    {
        InitializeComponent();

        Controls.Add(aboutPage);
        Controls.Add(addPage);
        Controls.Add(homePage);

        ShowPage(homePage);
    }

    private void ShowPage(UserControl pageToShow)
    {
        // Tüm sayfaları gizle
        foreach (Control control in Controls)
        {
            if (control is UserControl userControl)
            {
                userControl.Hide();
            }
        }

        // Belirli sayfayı göster
        pageToShow.Show();
    }
}