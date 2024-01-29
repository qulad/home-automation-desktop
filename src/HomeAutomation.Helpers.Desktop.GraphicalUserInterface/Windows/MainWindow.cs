using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using FontAwesome.Sharp;
using HomeAutomation.Helpers.Desktop.Application.DataTransferObjects;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;
using HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages.Base;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;

public partial class MainWindow : Form
{
    private readonly BasePage _basePage;

    private IconButton currentButton;
    private Panel leftBorderPanelButton;
    private UserControl currentChildUserControl;

    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private extern static void ReleaseCapture();
    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


    public MainWindow(BasePage basePage)
    {
        _basePage = basePage;

        var aboutPage = basePage.Get<AboutPage>();
        var addPage = basePage.Get<AddConnectionPage>();
        var homePage = basePage.Get<HomePage>();
        var monitorPage = basePage.Get<MonitorPage>();
        var selectConnectionPage = basePage.Get<SelectConnectionPage>();

        InitializeComponent();

        leftBorderPanelButton = new Panel();
        leftBorderPanelButton.Size = new Size(7, 60);
        PanelMenu.Controls.Add(leftBorderPanelButton);

        Text = string.Empty;
        ControlBox = false;
        DoubleBuffered = true;
        MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

        Controls.Add(aboutPage);
        Controls.Add(addPage);
        Controls.Add(homePage);
        Controls.Add(monitorPage);
        Controls.Add(selectConnectionPage);

        ShowPage(homePage);
    }

    private void MainWindowLoad(object sender, EventArgs e)
    {
        currentButton = new IconButton();
        currentButton.Text = "Home";
        OpenChildUserControl(_basePage.Get<HomePage>());
    }

    private void OpenChildUserControl(UserControl userControl)
    {
        if (currentChildUserControl != null)
        {
            currentChildUserControl.Hide();
        }

        currentChildUserControl = userControl;
        userControl.BorderStyle = BorderStyle.None;
        userControl.Dock = DockStyle.Fill;

        PanelDesktop.Controls.Add(userControl);
        PanelDesktop.Tag = userControl;
        userControl.BringToFront();
        userControl.Show();
        ChildUserControlTitleLabel.Text = currentButton.Text;
    }

    private void IconCloseClick(object sender, EventArgs e)
    {
        Close();
    }

    private void IconMaximizeClick(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
            WindowState = FormWindowState.Maximized;
        else
            WindowState = FormWindowState.Normal;
    }

    private void IconMinimizeClick(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void PanelTitleBarMouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void Reset()
    {
        DisableButton();
        leftBorderPanelButton.Visible = false;
        IconCurrentUserControl.IconChar = IconChar.Home;
        IconCurrentUserControl.IconColor = Color.MediumPurple;
        ChildUserControlTitleLabel.Text = "Home";
    }

    private void HomeButtonClick(object sender, EventArgs e)
    {
        Reset();
        currentButton = new IconButton();
        currentButton.Text = "Home";
        OpenChildUserControl(_basePage.Get<HomePage>());
    }

    private void AddConnectionPageButtonClick(object sender, EventArgs e)
    {
        ActivateButton(sender, Color.FromArgb(172, 126, 241));
        OpenChildUserControl(_basePage.Get<AddConnectionPage>());
    }

    private void SelectConnectionsButtonClick(object sender, EventArgs e)
    {
        ActivateButton(sender, Color.FromArgb(249, 118, 176));
        OpenChildUserControl(_basePage.Get<SelectConnectionPage>());
    }

    private void AboutPageButtonClick(object sender, EventArgs e)
    {
        ActivateButton(sender, Color.FromArgb(253, 138, 114));
        OpenChildUserControl(_basePage.Get<AboutPage>());
    }

    private void ActivateButton(object senderBtn, Color color)
    {
        if (senderBtn != null)
        {
            DisableButton();
            //Button
            currentButton = (IconButton)senderBtn;
            currentButton.BackColor = Color.FromArgb(37, 36, 81);
            currentButton.ForeColor = color;
            currentButton.TextAlign = ContentAlignment.MiddleCenter;
            currentButton.IconColor = color;
            currentButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            currentButton.ImageAlign = ContentAlignment.MiddleRight;
            //Left border button
            leftBorderPanelButton.BackColor = color;
            leftBorderPanelButton.Location = new Point(0, currentButton.Location.Y);
            leftBorderPanelButton.Visible = true;
            leftBorderPanelButton.BringToFront();
            //Current Child Form Icon
            IconCurrentUserControl.IconChar = currentButton.IconChar;
            IconCurrentUserControl.IconColor = color;
        }
    }

    private void DisableButton()
    {
        if (currentButton != null)
        {
            currentButton.BackColor = Color.FromArgb(31, 30, 68);
            currentButton.ForeColor = Color.Gainsboro;
            currentButton.TextAlign = ContentAlignment.MiddleLeft;
            currentButton.IconColor = Color.Gainsboro;
            currentButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            currentButton.ImageAlign = ContentAlignment.MiddleLeft;
        }
    }

    public void SendConnectionToMonitorPage(ConnectionDto connection)
    {
        var monitorPage = _basePage.Get<MonitorPage>() as MonitorPage;

        monitorPage.ReceiveConnection(connection);
    }

    private void ShowPage(UserControl pageToShow)
    {
        foreach (Control control in Controls)
        {
            if (control is UserControl userControl)
            {
                userControl.Hide();
            }
        }

        pageToShow.Show();
    }
}