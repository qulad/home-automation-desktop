using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class AddConnectionPage
{
    private IContainer components = null;
    private GroupBox ExistingLabelsGroupBox;
    private Label ConnectionNameLabel;
    private Label ConnectionPortLabel;
    private GroupBox NewLabelsGroupBox;
    private Button AddConnectionButton;
    private MaskedTextBox ConnectionPortMaskedTextBox;
    private TextBox ConnectionNameTextBox;
    private GroupBox LabelsGroupBox;
    private CheckedListBox ExistingLabelsCheckedListBox;
    private Button AddNewLabelButton;
    private TextBox NewLabelTextBox;
    private ListBox NewLabelListBox;
    private Label NewLabelLabel;

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
        ExistingLabelsGroupBox = new GroupBox();
        ExistingLabelsCheckedListBox = new CheckedListBox();
        ConnectionNameLabel = new Label();
        ConnectionPortLabel = new Label();
        NewLabelsGroupBox = new GroupBox();
        NewLabelLabel = new Label();
        AddNewLabelButton = new Button();
        NewLabelTextBox = new TextBox();
        NewLabelListBox = new ListBox();
        AddConnectionButton = new Button();
        ConnectionPortMaskedTextBox = new MaskedTextBox();
        ConnectionNameTextBox = new TextBox();
        LabelsGroupBox = new GroupBox();
        ConnectionIpAddressMaskedTextBox = new MaskedTextBox();
        ConnectionIpAddressLabel = new Label();
        ExistingLabelsGroupBox.SuspendLayout();
        NewLabelsGroupBox.SuspendLayout();
        LabelsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // ExistingLabelsGroupBox
        // 
        ExistingLabelsGroupBox.Controls.Add(ExistingLabelsCheckedListBox);
        ExistingLabelsGroupBox.ForeColor = Color.Gainsboro;
        ExistingLabelsGroupBox.Location = new Point(6, 17);
        ExistingLabelsGroupBox.Name = "ExistingLabelsGroupBox";
        ExistingLabelsGroupBox.Size = new Size(388, 166);
        ExistingLabelsGroupBox.TabIndex = 4;
        ExistingLabelsGroupBox.TabStop = false;
        ExistingLabelsGroupBox.Text = "Existing Tags";
        // 
        // ExistingLabelsCheckedListBox
        // 
        ExistingLabelsCheckedListBox.FormattingEnabled = true;
        ExistingLabelsCheckedListBox.Location = new Point(6, 21);
        ExistingLabelsCheckedListBox.Name = "ExistingLabelsCheckedListBox";
        ExistingLabelsCheckedListBox.Size = new Size(376, 119);
        ExistingLabelsCheckedListBox.TabIndex = 0;
        // 
        // ConnectionNameLabel
        // 
        ConnectionNameLabel.Anchor = AnchorStyles.None;
        ConnectionNameLabel.AutoSize = true;
        ConnectionNameLabel.Font = new Font("Century Gothic", 10.2F);
        ConnectionNameLabel.ForeColor = Color.Gainsboro;
        ConnectionNameLabel.Location = new Point(65, 112);
        ConnectionNameLabel.Name = "ConnectionNameLabel";
        ConnectionNameLabel.Size = new Size(169, 21);
        ConnectionNameLabel.TabIndex = 5;
        ConnectionNameLabel.Text = "Connection Name:";
        // 
        // ConnectionPortLabel
        // 
        ConnectionPortLabel.Anchor = AnchorStyles.None;
        ConnectionPortLabel.AutoSize = true;
        ConnectionPortLabel.Font = new Font("Century Gothic", 10.2F);
        ConnectionPortLabel.ForeColor = Color.Gainsboro;
        ConnectionPortLabel.Location = new Point(442, 133);
        ConnectionPortLabel.Name = "ConnectionPortLabel";
        ConnectionPortLabel.Size = new Size(153, 21);
        ConnectionPortLabel.TabIndex = 6;
        ConnectionPortLabel.Text = "Connection port:";
        // 
        // NewLabelsGroupBox
        // 
        NewLabelsGroupBox.Controls.Add(NewLabelLabel);
        NewLabelsGroupBox.Controls.Add(AddNewLabelButton);
        NewLabelsGroupBox.Controls.Add(NewLabelTextBox);
        NewLabelsGroupBox.Controls.Add(NewLabelListBox);
        NewLabelsGroupBox.ForeColor = Color.Gainsboro;
        NewLabelsGroupBox.Location = new Point(400, 17);
        NewLabelsGroupBox.Name = "NewLabelsGroupBox";
        NewLabelsGroupBox.Size = new Size(388, 166);
        NewLabelsGroupBox.TabIndex = 7;
        NewLabelsGroupBox.TabStop = false;
        NewLabelsGroupBox.Text = "New Tags";
        // 
        // NewLabelLabel
        // 
        NewLabelLabel.AutoSize = true;
        NewLabelLabel.Font = new Font("Segoe UI", 13F);
        NewLabelLabel.Location = new Point(207, 26);
        NewLabelLabel.Name = "NewLabelLabel";
        NewLabelLabel.Size = new Size(103, 30);
        NewLabelLabel.TabIndex = 3;
        NewLabelLabel.Text = "New tags";
        // 
        // AddNewLabelButton
        // 
        AddNewLabelButton.BackColor = Color.FromArgb(31, 31, 68);
        AddNewLabelButton.Location = new Point(207, 107);
        AddNewLabelButton.Name = "AddNewLabelButton";
        AddNewLabelButton.Size = new Size(151, 43);
        AddNewLabelButton.TabIndex = 2;
        AddNewLabelButton.Text = "Add new tags";
        AddNewLabelButton.UseVisualStyleBackColor = false;
        AddNewLabelButton.Click += AddNewLabelButtonClick;
        // 
        // NewLabelTextBox
        // 
        NewLabelTextBox.Location = new Point(207, 59);
        NewLabelTextBox.Name = "NewLabelTextBox";
        NewLabelTextBox.Size = new Size(151, 28);
        NewLabelTextBox.TabIndex = 1;
        // 
        // NewLabelListBox
        // 
        NewLabelListBox.FormattingEnabled = true;
        NewLabelListBox.ItemHeight = 21;
        NewLabelListBox.Location = new Point(6, 26);
        NewLabelListBox.Name = "NewLabelListBox";
        NewLabelListBox.Size = new Size(173, 109);
        NewLabelListBox.TabIndex = 0;
        // 
        // AddConnectionButton
        // 
        AddConnectionButton.Anchor = AnchorStyles.None;
        AddConnectionButton.BackColor = Color.FromArgb(31, 31, 68);
        AddConnectionButton.FlatStyle = FlatStyle.Flat;
        AddConnectionButton.Font = new Font("Century Gothic", 10.2F);
        AddConnectionButton.ForeColor = Color.Gainsboro;
        AddConnectionButton.Location = new Point(9, 371);
        AddConnectionButton.Name = "AddConnectionButton";
        AddConnectionButton.Size = new Size(782, 55);
        AddConnectionButton.TabIndex = 8;
        AddConnectionButton.Text = "Add Connection";
        AddConnectionButton.UseVisualStyleBackColor = false;
        AddConnectionButton.Click += AddConnectionButtonClick;
        // 
        // ConnectionPortMaskedTextBox
        // 
        ConnectionPortMaskedTextBox.Anchor = AnchorStyles.None;
        ConnectionPortMaskedTextBox.Font = new Font("Century Gothic", 10.2F);
        ConnectionPortMaskedTextBox.ForeColor = Color.Gainsboro;
        ConnectionPortMaskedTextBox.Location = new Point(601, 130);
        ConnectionPortMaskedTextBox.Mask = "00000";
        ConnectionPortMaskedTextBox.Name = "ConnectionPortMaskedTextBox";
        ConnectionPortMaskedTextBox.Size = new Size(125, 28);
        ConnectionPortMaskedTextBox.TabIndex = 9;
        ConnectionPortMaskedTextBox.ValidatingType = typeof(int);
        // 
        // ConnectionNameTextBox
        // 
        ConnectionNameTextBox.Anchor = AnchorStyles.None;
        ConnectionNameTextBox.Font = new Font("Century Gothic", 10.2F);
        ConnectionNameTextBox.ForeColor = Color.Gainsboro;
        ConnectionNameTextBox.Location = new Point(250, 109);
        ConnectionNameTextBox.Name = "ConnectionNameTextBox";
        ConnectionNameTextBox.Size = new Size(125, 28);
        ConnectionNameTextBox.TabIndex = 10;
        // 
        // LabelsGroupBox
        // 
        LabelsGroupBox.Anchor = AnchorStyles.None;
        LabelsGroupBox.Controls.Add(ExistingLabelsGroupBox);
        LabelsGroupBox.Controls.Add(NewLabelsGroupBox);
        LabelsGroupBox.Font = new Font("Century Gothic", 10.2F);
        LabelsGroupBox.ForeColor = Color.Gainsboro;
        LabelsGroupBox.Location = new Point(3, 163);
        LabelsGroupBox.Name = "LabelsGroupBox";
        LabelsGroupBox.Size = new Size(794, 189);
        LabelsGroupBox.TabIndex = 11;
        LabelsGroupBox.TabStop = false;
        LabelsGroupBox.Text = "Tags";
        // 
        // ConnectionIpAddressMaskedTextBox
        // 
        ConnectionIpAddressMaskedTextBox.Anchor = AnchorStyles.None;
        ConnectionIpAddressMaskedTextBox.Font = new Font("Century Gothic", 10.2F);
        ConnectionIpAddressMaskedTextBox.ForeColor = Color.Gainsboro;
        ConnectionIpAddressMaskedTextBox.Location = new Point(601, 88);
        ConnectionIpAddressMaskedTextBox.Mask = "###.###.###.###";
        ConnectionIpAddressMaskedTextBox.Name = "ConnectionIpAddressMaskedTextBox";
        ConnectionIpAddressMaskedTextBox.Size = new Size(125, 28);
        ConnectionIpAddressMaskedTextBox.TabIndex = 14;
        ConnectionIpAddressMaskedTextBox.ValidatingType = typeof(IPAddress);
        // 
        // ConnectionIpAddressLabel
        // 
        ConnectionIpAddressLabel.Anchor = AnchorStyles.None;
        ConnectionIpAddressLabel.AutoSize = true;
        ConnectionIpAddressLabel.Font = new Font("Century Gothic", 10.2F);
        ConnectionIpAddressLabel.ForeColor = Color.Gainsboro;
        ConnectionIpAddressLabel.Location = new Point(463, 91);
        ConnectionIpAddressLabel.Name = "ConnectionIpAddressLabel";
        ConnectionIpAddressLabel.Size = new Size(133, 21);
        ConnectionIpAddressLabel.TabIndex = 13;
        ConnectionIpAddressLabel.Text = "Connection IP:";
        // 
        // AddConnectionPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(34, 33, 74);
        Controls.Add(ConnectionIpAddressMaskedTextBox);
        Controls.Add(ConnectionIpAddressLabel);
        Controls.Add(LabelsGroupBox);
        Controls.Add(ConnectionNameTextBox);
        Controls.Add(ConnectionPortMaskedTextBox);
        Controls.Add(AddConnectionButton);
        Controls.Add(ConnectionPortLabel);
        Controls.Add(ConnectionNameLabel);
        Name = "AddConnectionPage";
        Size = new Size(800, 450);
        ExistingLabelsGroupBox.ResumeLayout(false);
        NewLabelsGroupBox.ResumeLayout(false);
        NewLabelsGroupBox.PerformLayout();
        LabelsGroupBox.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private MaskedTextBox ConnectionIpAddressMaskedTextBox;
    private Label ConnectionIpAddressLabel;
}