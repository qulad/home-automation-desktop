using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class MonitorPage
{
    private IContainer components = null;

    private Button HomePageButton;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        HomePageButton = new Button();
        DevicesListBox = new ListBox();
        DevicesVerticalScrollBar = new VScrollBar();
        MonitorPageLabel = new Label();
        NoSelectedDeviceLabel = new Label();
        SelectDeviceButton = new Button();
        SelectedDeviceMonitorGroupBox = new GroupBox();
        SelectedAnalogDeviceBlueValueLabel = new Label();
        SelectedAnalogDeviceGreenValueLabel = new Label();
        SelectedAnalogDeviceRedValueLabel = new Label();
        SelectedDigitalDeviceValueLabel = new Label();
        SelectedDeviceTypeLabel = new Label();
        SelectedDeviceMacAddressLabel = new Label();
        SelectedDeviceNameLabel = new Label();
        SelectedAnalogDeviceValuesLabelLabel = new Label();
        SelectedDigitalDeviceLabelLabel = new Label();
        SelectedDeviceTypeLabelLabel = new Label();
        SelectedDeviceMacAddressLabelLabel = new Label();
        SelectedDeviceNameLabelLabel = new Label();
        SelectedDeviceControlGroupBox = new GroupBox();
        SelectedAnalogDeviceNewBlueValueLabel = new Label();
        SelectedAnalogDeviceNewGreenValueLabel = new Label();
        SelectedAnalogDeviceNewRedValueLabel = new Label();
        SelectedDigitalDeviceNewValueLabel = new Label();
        SelectedAnalogDeviceNewBlueValueTextBox = new TextBox();
        SelectedAnalogDeviceNewGreenValueTextBox = new TextBox();
        SelectedAnalogDeviceNewRedValueTextBox = new TextBox();
        SelectedDigitalDeviceNewValueTextBox = new TextBox();
        SelectedDeviceNewNameTextBox = new TextBox();
        SelectedDeviceNewNameLabel = new Label();
        ConnectionGroupBox = new GroupBox();
        ConnectionPortLabel = new Label();
        ConnectionIpAddressLabel = new Label();
        ConnectionPortLabelLabel = new Label();
        ConnectionIpAddressLabelLabel = new Label();
        SelectedDevicesSetDeviceButton = new Button();
        SelectedDeviceMonitorGroupBox.SuspendLayout();
        SelectedDeviceControlGroupBox.SuspendLayout();
        ConnectionGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // HomePageButton
        // 
        HomePageButton.Location = new Point(594, 15);
        HomePageButton.Name = "HomePageButton";
        HomePageButton.Size = new Size(195, 83);
        HomePageButton.TabIndex = 3;
        HomePageButton.Text = "Ana sayfa";
        HomePageButton.UseVisualStyleBackColor = true;
        // 
        // DevicesListBox
        // 
        DevicesListBox.FormattingEnabled = true;
        DevicesListBox.Location = new Point(27, 112);
        DevicesListBox.Name = "DevicesListBox";
        DevicesListBox.Size = new Size(150, 204);
        DevicesListBox.TabIndex = 4;
        // 
        // DevicesVerticalScrollBar
        // 
        DevicesVerticalScrollBar.Location = new Point(151, 112);
        DevicesVerticalScrollBar.Name = "DevicesVerticalScrollBar";
        DevicesVerticalScrollBar.Size = new Size(26, 204);
        DevicesVerticalScrollBar.TabIndex = 5;
        DevicesVerticalScrollBar.Scroll += DevicesVerticalScrollBarScroll;
        // 
        // MonitorPageLabel
        // 
        MonitorPageLabel.AutoSize = true;
        MonitorPageLabel.Font = new Font("Segoe UI", 32F);
        MonitorPageLabel.Location = new Point(24, 15);
        MonitorPageLabel.Name = "MonitorPageLabel";
        MonitorPageLabel.Size = new Size(564, 72);
        MonitorPageLabel.TabIndex = 6;
        MonitorPageLabel.Text = "Monitörle ve Kontol Et";
        // 
        // NoSelectedDeviceLabel
        // 
        NoSelectedDeviceLabel.AutoSize = true;
        NoSelectedDeviceLabel.Location = new Point(356, 182);
        NoSelectedDeviceLabel.Name = "NoSelectedDeviceLabel";
        NoSelectedDeviceLabel.Size = new Size(109, 20);
        NoSelectedDeviceLabel.TabIndex = 7;
        NoSelectedDeviceLabel.Text = "Seçili cihaz yok";
        // 
        // SelectDeviceButton
        // 
        SelectDeviceButton.Location = new Point(27, 351);
        SelectDeviceButton.Name = "SelectDeviceButton";
        SelectDeviceButton.Size = new Size(117, 62);
        SelectDeviceButton.TabIndex = 8;
        SelectDeviceButton.Text = "Cihazı seç";
        SelectDeviceButton.UseVisualStyleBackColor = true;
        SelectDeviceButton.Click += SelectDeviceButtonClick;
        // 
        // SelectedDeviceMonitorGroupBox
        // 
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedAnalogDeviceBlueValueLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedAnalogDeviceGreenValueLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedAnalogDeviceRedValueLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDigitalDeviceValueLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDeviceTypeLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDeviceMacAddressLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDeviceNameLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedAnalogDeviceValuesLabelLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDigitalDeviceLabelLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDeviceTypeLabelLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDeviceMacAddressLabelLabel);
        SelectedDeviceMonitorGroupBox.Controls.Add(SelectedDeviceNameLabelLabel);
        SelectedDeviceMonitorGroupBox.Location = new Point(205, 112);
        SelectedDeviceMonitorGroupBox.Name = "SelectedDeviceMonitorGroupBox";
        SelectedDeviceMonitorGroupBox.Size = new Size(269, 217);
        SelectedDeviceMonitorGroupBox.TabIndex = 9;
        SelectedDeviceMonitorGroupBox.TabStop = false;
        SelectedDeviceMonitorGroupBox.Text = "Monitörle";
        SelectedDeviceMonitorGroupBox.Visible = false;
        // 
        // SelectedAnalogDeviceBlueValueLabel
        // 
        SelectedAnalogDeviceBlueValueLabel.AutoSize = true;
        SelectedAnalogDeviceBlueValueLabel.Location = new Point(189, 180);
        SelectedAnalogDeviceBlueValueLabel.Name = "SelectedAnalogDeviceBlueValueLabel";
        SelectedAnalogDeviceBlueValueLabel.Size = new Size(0, 20);
        SelectedAnalogDeviceBlueValueLabel.TabIndex = 11;
        // 
        // SelectedAnalogDeviceGreenValueLabel
        // 
        SelectedAnalogDeviceGreenValueLabel.AutoSize = true;
        SelectedAnalogDeviceGreenValueLabel.Location = new Point(107, 175);
        SelectedAnalogDeviceGreenValueLabel.Name = "SelectedAnalogDeviceGreenValueLabel";
        SelectedAnalogDeviceGreenValueLabel.Size = new Size(0, 20);
        SelectedAnalogDeviceGreenValueLabel.TabIndex = 10;
        // 
        // SelectedAnalogDeviceRedValueLabel
        // 
        SelectedAnalogDeviceRedValueLabel.AutoSize = true;
        SelectedAnalogDeviceRedValueLabel.Location = new Point(20, 178);
        SelectedAnalogDeviceRedValueLabel.Name = "SelectedAnalogDeviceRedValueLabel";
        SelectedAnalogDeviceRedValueLabel.Size = new Size(0, 20);
        SelectedAnalogDeviceRedValueLabel.TabIndex = 9;
        // 
        // SelectedDigitalDeviceValueLabel
        // 
        SelectedDigitalDeviceValueLabel.AutoSize = true;
        SelectedDigitalDeviceValueLabel.Location = new Point(169, 141);
        SelectedDigitalDeviceValueLabel.Name = "SelectedDigitalDeviceValueLabel";
        SelectedDigitalDeviceValueLabel.Size = new Size(0, 20);
        SelectedDigitalDeviceValueLabel.TabIndex = 8;
        // 
        // SelectedDeviceTypeLabel
        // 
        SelectedDeviceTypeLabel.AutoSize = true;
        SelectedDeviceTypeLabel.Location = new Point(131, 104);
        SelectedDeviceTypeLabel.Name = "SelectedDeviceTypeLabel";
        SelectedDeviceTypeLabel.Size = new Size(0, 20);
        SelectedDeviceTypeLabel.TabIndex = 7;
        // 
        // SelectedDeviceMacAddressLabel
        // 
        SelectedDeviceMacAddressLabel.AutoSize = true;
        SelectedDeviceMacAddressLabel.Location = new Point(183, 75);
        SelectedDeviceMacAddressLabel.Name = "SelectedDeviceMacAddressLabel";
        SelectedDeviceMacAddressLabel.Size = new Size(0, 20);
        SelectedDeviceMacAddressLabel.TabIndex = 6;
        // 
        // SelectedDeviceNameLabel
        // 
        SelectedDeviceNameLabel.AutoSize = true;
        SelectedDeviceNameLabel.Location = new Point(136, 36);
        SelectedDeviceNameLabel.Name = "SelectedDeviceNameLabel";
        SelectedDeviceNameLabel.Size = new Size(0, 20);
        SelectedDeviceNameLabel.TabIndex = 5;
        // 
        // SelectedAnalogDeviceValuesLabelLabel
        // 
        SelectedAnalogDeviceValuesLabelLabel.AutoSize = true;
        SelectedAnalogDeviceValuesLabelLabel.Location = new Point(14, 141);
        SelectedAnalogDeviceValuesLabelLabel.Name = "SelectedAnalogDeviceValuesLabelLabel";
        SelectedAnalogDeviceValuesLabelLabel.Size = new Size(191, 20);
        SelectedAnalogDeviceValuesLabelLabel.TabIndex = 4;
        SelectedAnalogDeviceValuesLabelLabel.Text = "Seçili cihaz değerleri (RGB):";
        SelectedAnalogDeviceValuesLabelLabel.Visible = false;
        // 
        // SelectedDigitalDeviceLabelLabel
        // 
        SelectedDigitalDeviceLabelLabel.AutoSize = true;
        SelectedDigitalDeviceLabelLabel.Location = new Point(14, 141);
        SelectedDigitalDeviceLabelLabel.Name = "SelectedDigitalDeviceLabelLabel";
        SelectedDigitalDeviceLabelLabel.Size = new Size(132, 20);
        SelectedDigitalDeviceLabelLabel.TabIndex = 3;
        SelectedDigitalDeviceLabelLabel.Text = "Seçili cihaz değeri:";
        SelectedDigitalDeviceLabelLabel.Visible = false;
        // 
        // SelectedDeviceTypeLabelLabel
        // 
        SelectedDeviceTypeLabelLabel.AutoSize = true;
        SelectedDeviceTypeLabelLabel.Location = new Point(14, 104);
        SelectedDeviceTypeLabelLabel.Name = "SelectedDeviceTypeLabelLabel";
        SelectedDeviceTypeLabelLabel.Size = new Size(111, 20);
        SelectedDeviceTypeLabelLabel.TabIndex = 2;
        SelectedDeviceTypeLabelLabel.Text = "Seçili cihaz tipi:";
        // 
        // SelectedDeviceMacAddressLabelLabel
        // 
        SelectedDeviceMacAddressLabelLabel.AutoSize = true;
        SelectedDeviceMacAddressLabelLabel.Location = new Point(14, 72);
        SelectedDeviceMacAddressLabelLabel.Name = "SelectedDeviceMacAddressLabelLabel";
        SelectedDeviceMacAddressLabelLabel.Size = new Size(161, 20);
        SelectedDeviceMacAddressLabelLabel.TabIndex = 1;
        SelectedDeviceMacAddressLabelLabel.Text = "Seçili cihaz mac adresi:";
        // 
        // SelectedDeviceNameLabelLabel
        // 
        SelectedDeviceNameLabelLabel.AutoSize = true;
        SelectedDeviceNameLabelLabel.Location = new Point(14, 36);
        SelectedDeviceNameLabelLabel.Name = "SelectedDeviceNameLabelLabel";
        SelectedDeviceNameLabelLabel.Size = new Size(116, 20);
        SelectedDeviceNameLabelLabel.TabIndex = 0;
        SelectedDeviceNameLabelLabel.Text = "Seçili cihaz ismi:";
        // 
        // SelectedDeviceControlGroupBox
        // 
        SelectedDeviceControlGroupBox.Controls.Add(SelectedDevicesSetDeviceButton);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedAnalogDeviceNewBlueValueLabel);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedAnalogDeviceNewGreenValueLabel);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedAnalogDeviceNewRedValueLabel);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedDigitalDeviceNewValueLabel);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedAnalogDeviceNewBlueValueTextBox);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedAnalogDeviceNewGreenValueTextBox);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedAnalogDeviceNewRedValueTextBox);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedDigitalDeviceNewValueTextBox);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedDeviceNewNameTextBox);
        SelectedDeviceControlGroupBox.Controls.Add(SelectedDeviceNewNameLabel);
        SelectedDeviceControlGroupBox.Location = new Point(489, 112);
        SelectedDeviceControlGroupBox.Name = "SelectedDeviceControlGroupBox";
        SelectedDeviceControlGroupBox.Size = new Size(289, 335);
        SelectedDeviceControlGroupBox.TabIndex = 10;
        SelectedDeviceControlGroupBox.TabStop = false;
        SelectedDeviceControlGroupBox.Text = "KontrolEt";
        // 
        // SelectedAnalogDeviceNewBlueValueLabel
        // 
        SelectedAnalogDeviceNewBlueValueLabel.AutoSize = true;
        SelectedAnalogDeviceNewBlueValueLabel.Location = new Point(17, 217);
        SelectedAnalogDeviceNewBlueValueLabel.Name = "SelectedAnalogDeviceNewBlueValueLabel";
        SelectedAnalogDeviceNewBlueValueLabel.Size = new Size(105, 20);
        SelectedAnalogDeviceNewBlueValueLabel.TabIndex = 9;
        SelectedAnalogDeviceNewBlueValueLabel.Text = "Yeni değer (B):";
        // 
        // SelectedAnalogDeviceNewGreenValueLabel
        // 
        SelectedAnalogDeviceNewGreenValueLabel.AutoSize = true;
        SelectedAnalogDeviceNewGreenValueLabel.Location = new Point(11, 178);
        SelectedAnalogDeviceNewGreenValueLabel.Name = "SelectedAnalogDeviceNewGreenValueLabel";
        SelectedAnalogDeviceNewGreenValueLabel.Size = new Size(106, 20);
        SelectedAnalogDeviceNewGreenValueLabel.TabIndex = 8;
        SelectedAnalogDeviceNewGreenValueLabel.Text = "Yeni değer (G):";
        // 
        // SelectedAnalogDeviceNewRedValueLabel
        // 
        SelectedAnalogDeviceNewRedValueLabel.AutoSize = true;
        SelectedAnalogDeviceNewRedValueLabel.Location = new Point(12, 135);
        SelectedAnalogDeviceNewRedValueLabel.Name = "SelectedAnalogDeviceNewRedValueLabel";
        SelectedAnalogDeviceNewRedValueLabel.Size = new Size(105, 20);
        SelectedAnalogDeviceNewRedValueLabel.TabIndex = 7;
        SelectedAnalogDeviceNewRedValueLabel.Text = "Yeni değer (R):";
        // 
        // SelectedDigitalDeviceNewValueLabel
        // 
        SelectedDigitalDeviceNewValueLabel.AutoSize = true;
        SelectedDigitalDeviceNewValueLabel.Location = new Point(12, 91);
        SelectedDigitalDeviceNewValueLabel.Name = "SelectedDigitalDeviceNewValueLabel";
        SelectedDigitalDeviceNewValueLabel.Size = new Size(82, 20);
        SelectedDigitalDeviceNewValueLabel.TabIndex = 6;
        SelectedDigitalDeviceNewValueLabel.Text = "Yeni değer:";
        // 
        // SelectedAnalogDeviceNewBlueValueTextBox
        // 
        SelectedAnalogDeviceNewBlueValueTextBox.Location = new Point(153, 217);
        SelectedAnalogDeviceNewBlueValueTextBox.Name = "SelectedAnalogDeviceNewBlueValueTextBox";
        SelectedAnalogDeviceNewBlueValueTextBox.Size = new Size(125, 27);
        SelectedAnalogDeviceNewBlueValueTextBox.TabIndex = 5;
        // 
        // SelectedAnalogDeviceNewGreenValueTextBox
        // 
        SelectedAnalogDeviceNewGreenValueTextBox.Location = new Point(153, 173);
        SelectedAnalogDeviceNewGreenValueTextBox.Name = "SelectedAnalogDeviceNewGreenValueTextBox";
        SelectedAnalogDeviceNewGreenValueTextBox.Size = new Size(125, 27);
        SelectedAnalogDeviceNewGreenValueTextBox.TabIndex = 4;
        // 
        // SelectedAnalogDeviceNewRedValueTextBox
        // 
        SelectedAnalogDeviceNewRedValueTextBox.Location = new Point(153, 132);
        SelectedAnalogDeviceNewRedValueTextBox.Name = "SelectedAnalogDeviceNewRedValueTextBox";
        SelectedAnalogDeviceNewRedValueTextBox.Size = new Size(125, 27);
        SelectedAnalogDeviceNewRedValueTextBox.TabIndex = 3;
        // 
        // SelectedDigitalDeviceNewValueTextBox
        // 
        SelectedDigitalDeviceNewValueTextBox.Location = new Point(153, 84);
        SelectedDigitalDeviceNewValueTextBox.Name = "SelectedDigitalDeviceNewValueTextBox";
        SelectedDigitalDeviceNewValueTextBox.Size = new Size(125, 27);
        SelectedDigitalDeviceNewValueTextBox.TabIndex = 2;
        // 
        // SelectedDeviceNewNameTextBox
        // 
        SelectedDeviceNewNameTextBox.Location = new Point(153, 32);
        SelectedDeviceNewNameTextBox.Name = "SelectedDeviceNewNameTextBox";
        SelectedDeviceNewNameTextBox.Size = new Size(125, 27);
        SelectedDeviceNewNameTextBox.TabIndex = 1;
        // 
        // SelectedDeviceNewNameLabel
        // 
        SelectedDeviceNewNameLabel.AutoSize = true;
        SelectedDeviceNewNameLabel.Location = new Point(17, 37);
        SelectedDeviceNewNameLabel.Name = "SelectedDeviceNewNameLabel";
        SelectedDeviceNewNameLabel.Size = new Size(70, 20);
        SelectedDeviceNewNameLabel.TabIndex = 0;
        SelectedDeviceNewNameLabel.Text = "Yeni isim:";
        // 
        // ConnectionGroupBox
        // 
        ConnectionGroupBox.Controls.Add(ConnectionPortLabel);
        ConnectionGroupBox.Controls.Add(ConnectionIpAddressLabel);
        ConnectionGroupBox.Controls.Add(ConnectionPortLabelLabel);
        ConnectionGroupBox.Controls.Add(ConnectionIpAddressLabelLabel);
        ConnectionGroupBox.Location = new Point(209, 335);
        ConnectionGroupBox.Name = "ConnectionGroupBox";
        ConnectionGroupBox.Size = new Size(256, 112);
        ConnectionGroupBox.TabIndex = 11;
        ConnectionGroupBox.TabStop = false;
        ConnectionGroupBox.Text = "Bağlantı";
        // 
        // ConnectionPortLabel
        // 
        ConnectionPortLabel.AutoSize = true;
        ConnectionPortLabel.Location = new Point(135, 75);
        ConnectionPortLabel.Name = "ConnectionPortLabel";
        ConnectionPortLabel.Size = new Size(0, 20);
        ConnectionPortLabel.TabIndex = 3;
        // 
        // ConnectionIpAddressLabel
        // 
        ConnectionIpAddressLabel.AutoSize = true;
        ConnectionIpAddressLabel.Location = new Point(151, 28);
        ConnectionIpAddressLabel.Name = "ConnectionIpAddressLabel";
        ConnectionIpAddressLabel.Size = new Size(0, 20);
        ConnectionIpAddressLabel.TabIndex = 2;
        // 
        // ConnectionPortLabelLabel
        // 
        ConnectionPortLabelLabel.AutoSize = true;
        ConnectionPortLabelLabel.Location = new Point(19, 75);
        ConnectionPortLabelLabel.Name = "ConnectionPortLabelLabel";
        ConnectionPortLabelLabel.Size = new Size(99, 20);
        ConnectionPortLabelLabel.TabIndex = 1;
        ConnectionPortLabelLabel.Text = "Bağlantı port:";
        // 
        // ConnectionIpAddressLabelLabel
        // 
        ConnectionIpAddressLabelLabel.AutoSize = true;
        ConnectionIpAddressLabelLabel.Location = new Point(16, 28);
        ConnectionIpAddressLabelLabel.Name = "ConnectionIpAddressLabelLabel";
        ConnectionIpAddressLabelLabel.Size = new Size(84, 20);
        ConnectionIpAddressLabelLabel.TabIndex = 0;
        ConnectionIpAddressLabelLabel.Text = "Bağlantı ip:";
        // 
        // SelectedDevicesSetDeviceButton
        // 
        SelectedDevicesSetDeviceButton.Location = new Point(17, 260);
        SelectedDevicesSetDeviceButton.Name = "SelectedDevicesSetDeviceButton";
        SelectedDevicesSetDeviceButton.Size = new Size(261, 53);
        SelectedDevicesSetDeviceButton.TabIndex = 10;
        SelectedDevicesSetDeviceButton.Text = "Ayarla";
        SelectedDevicesSetDeviceButton.UseVisualStyleBackColor = true;
        // 
        // MonitorPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(ConnectionGroupBox);
        Controls.Add(SelectedDeviceControlGroupBox);
        Controls.Add(SelectedDeviceMonitorGroupBox);
        Controls.Add(SelectDeviceButton);
        Controls.Add(NoSelectedDeviceLabel);
        Controls.Add(MonitorPageLabel);
        Controls.Add(DevicesVerticalScrollBar);
        Controls.Add(DevicesListBox);
        Controls.Add(HomePageButton);
        Name = "MonitorPage";
        Size = new Size(800, 450);
        SelectedDeviceMonitorGroupBox.ResumeLayout(false);
        SelectedDeviceMonitorGroupBox.PerformLayout();
        SelectedDeviceControlGroupBox.ResumeLayout(false);
        SelectedDeviceControlGroupBox.PerformLayout();
        ConnectionGroupBox.ResumeLayout(false);
        ConnectionGroupBox.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private ListBox DevicesListBox;
    private VScrollBar DevicesVerticalScrollBar;
    private Label MonitorPageLabel;
    private Label NoSelectedDeviceLabel;
    private Button SelectDeviceButton;
    private GroupBox SelectedDeviceMonitorGroupBox;
    private Label SelectedDeviceNameLabelLabel;
    private Label SelectedAnalogDeviceValuesLabelLabel;
    private Label SelectedDigitalDeviceLabelLabel;
    private Label SelectedDeviceTypeLabelLabel;
    private Label SelectedDeviceMacAddressLabelLabel;
    private Label SelectedDeviceTypeLabel;
    private Label SelectedDeviceMacAddressLabel;
    private Label SelectedDeviceNameLabel;
    private Label SelectedAnalogDeviceBlueValueLabel;
    private Label SelectedAnalogDeviceGreenValueLabel;
    private Label SelectedAnalogDeviceRedValueLabel;
    private Label SelectedDigitalDeviceValueLabel;
    private GroupBox SelectedDeviceControlGroupBox;
    private TextBox SelectedDigitalDeviceNewValueTextBox;
    private TextBox SelectedDeviceNewNameTextBox;
    private Label SelectedDeviceNewNameLabel;
    private Label SelectedDigitalDeviceNewValueLabel;
    private TextBox SelectedAnalogDeviceNewBlueValueTextBox;
    private TextBox SelectedAnalogDeviceNewGreenValueTextBox;
    private TextBox SelectedAnalogDeviceNewRedValueTextBox;
    private Label SelectedAnalogDeviceNewRedValueLabel;
    private Label SelectedAnalogDeviceNewBlueValueLabel;
    private Label SelectedAnalogDeviceNewGreenValueLabel;
    private GroupBox ConnectionGroupBox;
    private Label ConnectionPortLabelLabel;
    private Label ConnectionIpAddressLabelLabel;
    private Label ConnectionIpAddressLabel;
    private Label ConnectionPortLabel;
    private Button SelectedDevicesSetDeviceButton;
}