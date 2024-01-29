using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class MonitorPage
{
    private IContainer components = null;

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
        DevicesListBox = new ListBox();
        DevicesVerticalScrollBar = new VScrollBar();
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
        SelectedDevicesSetDeviceButton = new Button();
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
        SelectedDeviceMonitorGroupBox.SuspendLayout();
        SelectedDeviceControlGroupBox.SuspendLayout();
        ConnectionGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // DevicesListBox
        // 
        DevicesListBox.Anchor = AnchorStyles.None;
        DevicesListBox.FormattingEnabled = true;
        DevicesListBox.Location = new Point(27, 112);
        DevicesListBox.Name = "DevicesListBox";
        DevicesListBox.Size = new Size(150, 204);
        DevicesListBox.TabIndex = 4;
        // 
        // DevicesVerticalScrollBar
        // 
        DevicesVerticalScrollBar.Anchor = AnchorStyles.None;
        DevicesVerticalScrollBar.Location = new Point(151, 112);
        DevicesVerticalScrollBar.Name = "DevicesVerticalScrollBar";
        DevicesVerticalScrollBar.Size = new Size(26, 204);
        DevicesVerticalScrollBar.TabIndex = 5;
        DevicesVerticalScrollBar.Scroll += DevicesVerticalScrollBarScroll;
        // 
        // NoSelectedDeviceLabel
        // 
        NoSelectedDeviceLabel.Anchor = AnchorStyles.None;
        NoSelectedDeviceLabel.AutoSize = true;
        NoSelectedDeviceLabel.Font = new Font("Century Gothic", 10.2F);
        NoSelectedDeviceLabel.ForeColor = Color.Gainsboro;
        NoSelectedDeviceLabel.Location = new Point(356, 182);
        NoSelectedDeviceLabel.Name = "NoSelectedDeviceLabel";
        NoSelectedDeviceLabel.Size = new Size(130, 21);
        NoSelectedDeviceLabel.TabIndex = 7;
        NoSelectedDeviceLabel.Text = "Seçili cihaz yok";
        NoSelectedDeviceLabel.Visible = false;
        // 
        // SelectDeviceButton
        // 
        SelectDeviceButton.Anchor = AnchorStyles.None;
        SelectDeviceButton.BackColor = Color.FromArgb(31, 31, 68);
        SelectDeviceButton.FlatStyle = FlatStyle.Flat;
        SelectDeviceButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SelectDeviceButton.ForeColor = Color.Gainsboro;
        SelectDeviceButton.Location = new Point(27, 351);
        SelectDeviceButton.Name = "SelectDeviceButton";
        SelectDeviceButton.Size = new Size(137, 62);
        SelectDeviceButton.TabIndex = 8;
        SelectDeviceButton.Text = "Select device";
        SelectDeviceButton.UseVisualStyleBackColor = false;
        SelectDeviceButton.Click += SelectDeviceButtonClick;
        // 
        // SelectedDeviceMonitorGroupBox
        // 
        SelectedDeviceMonitorGroupBox.Anchor = AnchorStyles.None;
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
        SelectedDeviceMonitorGroupBox.Font = new Font("Century Gothic", 10.2F);
        SelectedDeviceMonitorGroupBox.ForeColor = Color.Gainsboro;
        SelectedDeviceMonitorGroupBox.Location = new Point(205, 112);
        SelectedDeviceMonitorGroupBox.Name = "SelectedDeviceMonitorGroupBox";
        SelectedDeviceMonitorGroupBox.Size = new Size(269, 217);
        SelectedDeviceMonitorGroupBox.TabIndex = 9;
        SelectedDeviceMonitorGroupBox.TabStop = false;
        SelectedDeviceMonitorGroupBox.Text = "Monitor";
        SelectedDeviceMonitorGroupBox.Visible = false;
        // 
        // SelectedAnalogDeviceBlueValueLabel
        // 
        SelectedAnalogDeviceBlueValueLabel.AutoSize = true;
        SelectedAnalogDeviceBlueValueLabel.Location = new Point(189, 180);
        SelectedAnalogDeviceBlueValueLabel.Name = "SelectedAnalogDeviceBlueValueLabel";
        SelectedAnalogDeviceBlueValueLabel.Size = new Size(0, 21);
        SelectedAnalogDeviceBlueValueLabel.TabIndex = 11;
        // 
        // SelectedAnalogDeviceGreenValueLabel
        // 
        SelectedAnalogDeviceGreenValueLabel.AutoSize = true;
        SelectedAnalogDeviceGreenValueLabel.Location = new Point(107, 175);
        SelectedAnalogDeviceGreenValueLabel.Name = "SelectedAnalogDeviceGreenValueLabel";
        SelectedAnalogDeviceGreenValueLabel.Size = new Size(0, 21);
        SelectedAnalogDeviceGreenValueLabel.TabIndex = 10;
        // 
        // SelectedAnalogDeviceRedValueLabel
        // 
        SelectedAnalogDeviceRedValueLabel.AutoSize = true;
        SelectedAnalogDeviceRedValueLabel.Location = new Point(20, 178);
        SelectedAnalogDeviceRedValueLabel.Name = "SelectedAnalogDeviceRedValueLabel";
        SelectedAnalogDeviceRedValueLabel.Size = new Size(0, 21);
        SelectedAnalogDeviceRedValueLabel.TabIndex = 9;
        // 
        // SelectedDigitalDeviceValueLabel
        // 
        SelectedDigitalDeviceValueLabel.AutoSize = true;
        SelectedDigitalDeviceValueLabel.Location = new Point(169, 141);
        SelectedDigitalDeviceValueLabel.Name = "SelectedDigitalDeviceValueLabel";
        SelectedDigitalDeviceValueLabel.Size = new Size(0, 21);
        SelectedDigitalDeviceValueLabel.TabIndex = 8;
        // 
        // SelectedDeviceTypeLabel
        // 
        SelectedDeviceTypeLabel.AutoSize = true;
        SelectedDeviceTypeLabel.Location = new Point(131, 104);
        SelectedDeviceTypeLabel.Name = "SelectedDeviceTypeLabel";
        SelectedDeviceTypeLabel.Size = new Size(0, 21);
        SelectedDeviceTypeLabel.TabIndex = 7;
        // 
        // SelectedDeviceMacAddressLabel
        // 
        SelectedDeviceMacAddressLabel.AutoSize = true;
        SelectedDeviceMacAddressLabel.Location = new Point(183, 75);
        SelectedDeviceMacAddressLabel.Name = "SelectedDeviceMacAddressLabel";
        SelectedDeviceMacAddressLabel.Size = new Size(0, 21);
        SelectedDeviceMacAddressLabel.TabIndex = 6;
        // 
        // SelectedDeviceNameLabel
        // 
        SelectedDeviceNameLabel.AutoSize = true;
        SelectedDeviceNameLabel.Location = new Point(136, 36);
        SelectedDeviceNameLabel.Name = "SelectedDeviceNameLabel";
        SelectedDeviceNameLabel.Size = new Size(0, 21);
        SelectedDeviceNameLabel.TabIndex = 5;
        // 
        // SelectedAnalogDeviceValuesLabelLabel
        // 
        SelectedAnalogDeviceValuesLabelLabel.AutoSize = true;
        SelectedAnalogDeviceValuesLabelLabel.Location = new Point(14, 141);
        SelectedAnalogDeviceValuesLabelLabel.Name = "SelectedAnalogDeviceValuesLabelLabel";
        SelectedAnalogDeviceValuesLabelLabel.Size = new Size(186, 21);
        SelectedAnalogDeviceValuesLabelLabel.TabIndex = 4;
        SelectedAnalogDeviceValuesLabelLabel.Text = "Device values (RGB):";
        SelectedAnalogDeviceValuesLabelLabel.Visible = false;
        // 
        // SelectedDigitalDeviceLabelLabel
        // 
        SelectedDigitalDeviceLabelLabel.AutoSize = true;
        SelectedDigitalDeviceLabelLabel.Location = new Point(14, 141);
        SelectedDigitalDeviceLabelLabel.Name = "SelectedDigitalDeviceLabelLabel";
        SelectedDigitalDeviceLabelLabel.Size = new Size(160, 21);
        SelectedDigitalDeviceLabelLabel.TabIndex = 3;
        SelectedDigitalDeviceLabelLabel.Text = "Seçili cihaz değeri:";
        SelectedDigitalDeviceLabelLabel.Visible = false;
        // 
        // SelectedDeviceTypeLabelLabel
        // 
        SelectedDeviceTypeLabelLabel.AutoSize = true;
        SelectedDeviceTypeLabelLabel.Location = new Point(14, 104);
        SelectedDeviceTypeLabelLabel.Name = "SelectedDeviceTypeLabelLabel";
        SelectedDeviceTypeLabelLabel.Size = new Size(118, 21);
        SelectedDeviceTypeLabelLabel.TabIndex = 2;
        SelectedDeviceTypeLabelLabel.Text = "Device type:";
        // 
        // SelectedDeviceMacAddressLabelLabel
        // 
        SelectedDeviceMacAddressLabelLabel.AutoSize = true;
        SelectedDeviceMacAddressLabelLabel.Location = new Point(14, 72);
        SelectedDeviceMacAddressLabelLabel.Name = "SelectedDeviceMacAddressLabelLabel";
        SelectedDeviceMacAddressLabelLabel.Size = new Size(59, 21);
        SelectedDeviceMacAddressLabelLabel.TabIndex = 1;
        SelectedDeviceMacAddressLabelLabel.Text = "MAC:";
        // 
        // SelectedDeviceNameLabelLabel
        // 
        SelectedDeviceNameLabelLabel.AutoSize = true;
        SelectedDeviceNameLabelLabel.Location = new Point(14, 36);
        SelectedDeviceNameLabelLabel.Name = "SelectedDeviceNameLabelLabel";
        SelectedDeviceNameLabelLabel.Size = new Size(66, 21);
        SelectedDeviceNameLabelLabel.TabIndex = 0;
        SelectedDeviceNameLabelLabel.Text = "Name:";
        // 
        // SelectedDeviceControlGroupBox
        // 
        SelectedDeviceControlGroupBox.Anchor = AnchorStyles.None;
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
        SelectedDeviceControlGroupBox.Font = new Font("Century Gothic", 10.2F);
        SelectedDeviceControlGroupBox.ForeColor = Color.Gainsboro;
        SelectedDeviceControlGroupBox.Location = new Point(489, 112);
        SelectedDeviceControlGroupBox.Name = "SelectedDeviceControlGroupBox";
        SelectedDeviceControlGroupBox.Size = new Size(289, 335);
        SelectedDeviceControlGroupBox.TabIndex = 10;
        SelectedDeviceControlGroupBox.TabStop = false;
        SelectedDeviceControlGroupBox.Text = "Control";
        SelectedDeviceControlGroupBox.Visible = false;
        // 
        // SelectedDevicesSetDeviceButton
        // 
        SelectedDevicesSetDeviceButton.BackColor = Color.FromArgb(31, 31, 68);
        SelectedDevicesSetDeviceButton.FlatStyle = FlatStyle.Flat;
        SelectedDevicesSetDeviceButton.Location = new Point(17, 260);
        SelectedDevicesSetDeviceButton.Name = "SelectedDevicesSetDeviceButton";
        SelectedDevicesSetDeviceButton.Size = new Size(261, 53);
        SelectedDevicesSetDeviceButton.TabIndex = 10;
        SelectedDevicesSetDeviceButton.Text = "Apply new values";
        SelectedDevicesSetDeviceButton.UseVisualStyleBackColor = false;
        SelectedDevicesSetDeviceButton.Click += SelectedDevicesSetDeviceButtonClick;
        // 
        // SelectedAnalogDeviceNewBlueValueLabel
        // 
        SelectedAnalogDeviceNewBlueValueLabel.AutoSize = true;
        SelectedAnalogDeviceNewBlueValueLabel.Location = new Point(17, 217);
        SelectedAnalogDeviceNewBlueValueLabel.Name = "SelectedAnalogDeviceNewBlueValueLabel";
        SelectedAnalogDeviceNewBlueValueLabel.Size = new Size(98, 21);
        SelectedAnalogDeviceNewBlueValueLabel.TabIndex = 9;
        SelectedAnalogDeviceNewBlueValueLabel.Text = "Value Blue";
        // 
        // SelectedAnalogDeviceNewGreenValueLabel
        // 
        SelectedAnalogDeviceNewGreenValueLabel.AutoSize = true;
        SelectedAnalogDeviceNewGreenValueLabel.Location = new Point(11, 178);
        SelectedAnalogDeviceNewGreenValueLabel.Name = "SelectedAnalogDeviceNewGreenValueLabel";
        SelectedAnalogDeviceNewGreenValueLabel.Size = new Size(121, 21);
        SelectedAnalogDeviceNewGreenValueLabel.TabIndex = 8;
        SelectedAnalogDeviceNewGreenValueLabel.Text = "Value Green:";
        // 
        // SelectedAnalogDeviceNewRedValueLabel
        // 
        SelectedAnalogDeviceNewRedValueLabel.AutoSize = true;
        SelectedAnalogDeviceNewRedValueLabel.Location = new Point(12, 135);
        SelectedAnalogDeviceNewRedValueLabel.Name = "SelectedAnalogDeviceNewRedValueLabel";
        SelectedAnalogDeviceNewRedValueLabel.Size = new Size(102, 21);
        SelectedAnalogDeviceNewRedValueLabel.TabIndex = 7;
        SelectedAnalogDeviceNewRedValueLabel.Text = "Value Red:";
        // 
        // SelectedDigitalDeviceNewValueLabel
        // 
        SelectedDigitalDeviceNewValueLabel.AutoSize = true;
        SelectedDigitalDeviceNewValueLabel.Location = new Point(12, 91);
        SelectedDigitalDeviceNewValueLabel.Name = "SelectedDigitalDeviceNewValueLabel";
        SelectedDigitalDeviceNewValueLabel.Size = new Size(64, 21);
        SelectedDigitalDeviceNewValueLabel.TabIndex = 6;
        SelectedDigitalDeviceNewValueLabel.Text = "Value:";
        // 
        // SelectedAnalogDeviceNewBlueValueTextBox
        // 
        SelectedAnalogDeviceNewBlueValueTextBox.Location = new Point(153, 217);
        SelectedAnalogDeviceNewBlueValueTextBox.Name = "SelectedAnalogDeviceNewBlueValueTextBox";
        SelectedAnalogDeviceNewBlueValueTextBox.Size = new Size(125, 28);
        SelectedAnalogDeviceNewBlueValueTextBox.TabIndex = 5;
        // 
        // SelectedAnalogDeviceNewGreenValueTextBox
        // 
        SelectedAnalogDeviceNewGreenValueTextBox.Location = new Point(153, 173);
        SelectedAnalogDeviceNewGreenValueTextBox.Name = "SelectedAnalogDeviceNewGreenValueTextBox";
        SelectedAnalogDeviceNewGreenValueTextBox.Size = new Size(125, 28);
        SelectedAnalogDeviceNewGreenValueTextBox.TabIndex = 4;
        // 
        // SelectedAnalogDeviceNewRedValueTextBox
        // 
        SelectedAnalogDeviceNewRedValueTextBox.Location = new Point(153, 132);
        SelectedAnalogDeviceNewRedValueTextBox.Name = "SelectedAnalogDeviceNewRedValueTextBox";
        SelectedAnalogDeviceNewRedValueTextBox.Size = new Size(125, 28);
        SelectedAnalogDeviceNewRedValueTextBox.TabIndex = 3;
        // 
        // SelectedDigitalDeviceNewValueTextBox
        // 
        SelectedDigitalDeviceNewValueTextBox.Location = new Point(153, 84);
        SelectedDigitalDeviceNewValueTextBox.Name = "SelectedDigitalDeviceNewValueTextBox";
        SelectedDigitalDeviceNewValueTextBox.Size = new Size(125, 28);
        SelectedDigitalDeviceNewValueTextBox.TabIndex = 2;
        // 
        // SelectedDeviceNewNameTextBox
        // 
        SelectedDeviceNewNameTextBox.Location = new Point(153, 32);
        SelectedDeviceNewNameTextBox.Name = "SelectedDeviceNewNameTextBox";
        SelectedDeviceNewNameTextBox.Size = new Size(125, 28);
        SelectedDeviceNewNameTextBox.TabIndex = 1;
        // 
        // SelectedDeviceNewNameLabel
        // 
        SelectedDeviceNewNameLabel.AutoSize = true;
        SelectedDeviceNewNameLabel.Location = new Point(17, 37);
        SelectedDeviceNewNameLabel.Name = "SelectedDeviceNewNameLabel";
        SelectedDeviceNewNameLabel.Size = new Size(66, 21);
        SelectedDeviceNewNameLabel.TabIndex = 0;
        SelectedDeviceNewNameLabel.Text = "Name:";
        // 
        // ConnectionGroupBox
        // 
        ConnectionGroupBox.Anchor = AnchorStyles.None;
        ConnectionGroupBox.Controls.Add(ConnectionPortLabel);
        ConnectionGroupBox.Controls.Add(ConnectionIpAddressLabel);
        ConnectionGroupBox.Controls.Add(ConnectionPortLabelLabel);
        ConnectionGroupBox.Controls.Add(ConnectionIpAddressLabelLabel);
        ConnectionGroupBox.Font = new Font("Century Gothic", 10.2F);
        ConnectionGroupBox.ForeColor = Color.Gainsboro;
        ConnectionGroupBox.Location = new Point(209, 335);
        ConnectionGroupBox.Name = "ConnectionGroupBox";
        ConnectionGroupBox.Size = new Size(256, 112);
        ConnectionGroupBox.TabIndex = 11;
        ConnectionGroupBox.TabStop = false;
        ConnectionGroupBox.Text = "Connection";
        // 
        // ConnectionPortLabel
        // 
        ConnectionPortLabel.AutoSize = true;
        ConnectionPortLabel.Location = new Point(135, 75);
        ConnectionPortLabel.Name = "ConnectionPortLabel";
        ConnectionPortLabel.Size = new Size(0, 21);
        ConnectionPortLabel.TabIndex = 3;
        // 
        // ConnectionIpAddressLabel
        // 
        ConnectionIpAddressLabel.AutoSize = true;
        ConnectionIpAddressLabel.Location = new Point(151, 28);
        ConnectionIpAddressLabel.Name = "ConnectionIpAddressLabel";
        ConnectionIpAddressLabel.Size = new Size(0, 21);
        ConnectionIpAddressLabel.TabIndex = 2;
        // 
        // ConnectionPortLabelLabel
        // 
        ConnectionPortLabelLabel.AutoSize = true;
        ConnectionPortLabelLabel.Location = new Point(19, 75);
        ConnectionPortLabelLabel.Name = "ConnectionPortLabelLabel";
        ConnectionPortLabelLabel.Size = new Size(48, 21);
        ConnectionPortLabelLabel.TabIndex = 1;
        ConnectionPortLabelLabel.Text = "Port:";
        // 
        // ConnectionIpAddressLabelLabel
        // 
        ConnectionIpAddressLabelLabel.AutoSize = true;
        ConnectionIpAddressLabelLabel.Location = new Point(16, 28);
        ConnectionIpAddressLabelLabel.Name = "ConnectionIpAddressLabelLabel";
        ConnectionIpAddressLabelLabel.Size = new Size(30, 21);
        ConnectionIpAddressLabelLabel.TabIndex = 0;
        ConnectionIpAddressLabelLabel.Text = "IP:";
        // 
        // MonitorPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(34, 33, 75);
        Controls.Add(ConnectionGroupBox);
        Controls.Add(SelectedDeviceControlGroupBox);
        Controls.Add(SelectedDeviceMonitorGroupBox);
        Controls.Add(SelectDeviceButton);
        Controls.Add(NoSelectedDeviceLabel);
        Controls.Add(DevicesVerticalScrollBar);
        Controls.Add(DevicesListBox);
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