using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class AddConnectionPage
{
    private IContainer components = null;

    private Button HomePageButton;
    private GroupBox ExistingLabelsGroupBox;
    private Label ConnectionNameLabel;
    private Label ConnectionPortLabel;
    private GroupBox NewLabelsGroupBox;
    private Button AddConnectionButton;
    private MaskedTextBox ConnectionPortMaskedTextBox;
    private TextBox ConnectionNameTextBox;
    private GroupBox LabelsGroupBox;
    private Label AddConnectionPageLabel;
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
        HomePageButton = new Button();
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
        AddConnectionPageLabel = new Label();
        ConnectionIpAddressMaskedTextBox = new MaskedTextBox();
        ConnectionIpAddressLabel = new Label();
        ExistingLabelsGroupBox.SuspendLayout();
        NewLabelsGroupBox.SuspendLayout();
        LabelsGroupBox.SuspendLayout();
        SuspendLayout();
        // 
        // HomePageButton
        // 
        HomePageButton.Location = new Point(38, 77);
        HomePageButton.Name = "HomePageButton";
        HomePageButton.Size = new Size(160, 80);
        HomePageButton.TabIndex = 3;
        HomePageButton.Text = "Ana sayfa";
        HomePageButton.UseVisualStyleBackColor = true;
        HomePageButton.Click += HomePageButtonClick;
        // 
        // ExistingLabelsGroupBox
        // 
        ExistingLabelsGroupBox.Controls.Add(ExistingLabelsCheckedListBox);
        ExistingLabelsGroupBox.Location = new Point(6, 17);
        ExistingLabelsGroupBox.Name = "ExistingLabelsGroupBox";
        ExistingLabelsGroupBox.Size = new Size(388, 166);
        ExistingLabelsGroupBox.TabIndex = 4;
        ExistingLabelsGroupBox.TabStop = false;
        ExistingLabelsGroupBox.Text = "Var Olan Etiketler";
        // 
        // ExistingLabelsCheckedListBox
        // 
        ExistingLabelsCheckedListBox.FormattingEnabled = true;
        ExistingLabelsCheckedListBox.Location = new Point(6, 21);
        ExistingLabelsCheckedListBox.Name = "ExistingLabelsCheckedListBox";
        ExistingLabelsCheckedListBox.Size = new Size(376, 136);
        ExistingLabelsCheckedListBox.TabIndex = 0;
        // 
        // ConnectionNameLabel
        // 
        ConnectionNameLabel.AutoSize = true;
        ConnectionNameLabel.Location = new Point(275, 95);
        ConnectionNameLabel.Name = "ConnectionNameLabel";
        ConnectionNameLabel.Size = new Size(98, 20);
        ConnectionNameLabel.TabIndex = 5;
        ConnectionNameLabel.Text = "Bağlantı ismi:";
        // 
        // ConnectionPortLabel
        // 
        ConnectionPortLabel.AutoSize = true;
        ConnectionPortLabel.Location = new Point(463, 133);
        ConnectionPortLabel.Name = "ConnectionPortLabel";
        ConnectionPortLabel.Size = new Size(110, 20);
        ConnectionPortLabel.TabIndex = 6;
        ConnectionPortLabel.Text = "Bağlantı port'u:";
        // 
        // NewLabelsGroupBox
        // 
        NewLabelsGroupBox.Controls.Add(NewLabelLabel);
        NewLabelsGroupBox.Controls.Add(AddNewLabelButton);
        NewLabelsGroupBox.Controls.Add(NewLabelTextBox);
        NewLabelsGroupBox.Controls.Add(NewLabelListBox);
        NewLabelsGroupBox.Location = new Point(400, 17);
        NewLabelsGroupBox.Name = "NewLabelsGroupBox";
        NewLabelsGroupBox.Size = new Size(388, 166);
        NewLabelsGroupBox.TabIndex = 7;
        NewLabelsGroupBox.TabStop = false;
        NewLabelsGroupBox.Text = "Yeni Etiketler";
        // 
        // NewLabelLabel
        // 
        NewLabelLabel.AutoSize = true;
        NewLabelLabel.Font = new Font("Segoe UI", 13F);
        NewLabelLabel.Location = new Point(207, 26);
        NewLabelLabel.Name = "NewLabelLabel";
        NewLabelLabel.Size = new Size(147, 30);
        NewLabelLabel.TabIndex = 3;
        NewLabelLabel.Text = "Yeni etiket adı";
        // 
        // AddNewLabelButton
        // 
        AddNewLabelButton.Location = new Point(207, 107);
        AddNewLabelButton.Name = "AddNewLabelButton";
        AddNewLabelButton.Size = new Size(151, 43);
        AddNewLabelButton.TabIndex = 2;
        AddNewLabelButton.Text = "Yeni etiket ekle";
        AddNewLabelButton.UseVisualStyleBackColor = true;
        AddNewLabelButton.Click += AddNewLabelButtonClick;
        // 
        // NewLabelTextBox
        // 
        NewLabelTextBox.Location = new Point(207, 59);
        NewLabelTextBox.Name = "NewLabelTextBox";
        NewLabelTextBox.Size = new Size(151, 27);
        NewLabelTextBox.TabIndex = 1;
        // 
        // NewLabelListBox
        // 
        NewLabelListBox.FormattingEnabled = true;
        NewLabelListBox.Location = new Point(6, 26);
        NewLabelListBox.Name = "NewLabelListBox";
        NewLabelListBox.Size = new Size(173, 124);
        NewLabelListBox.TabIndex = 0;
        // 
        // AddConnectionButton
        // 
        AddConnectionButton.Location = new Point(9, 371);
        AddConnectionButton.Name = "AddConnectionButton";
        AddConnectionButton.Size = new Size(782, 55);
        AddConnectionButton.TabIndex = 8;
        AddConnectionButton.Text = "Bağlantıyı Ekle";
        AddConnectionButton.UseVisualStyleBackColor = true;
        AddConnectionButton.Click += AddConnectionButtonClick;
        // 
        // ConnectionPortMaskedTextBox
        // 
        ConnectionPortMaskedTextBox.Location = new Point(601, 130);
        ConnectionPortMaskedTextBox.Mask = "00000";
        ConnectionPortMaskedTextBox.Name = "ConnectionPortMaskedTextBox";
        ConnectionPortMaskedTextBox.Size = new Size(125, 27);
        ConnectionPortMaskedTextBox.TabIndex = 9;
        ConnectionPortMaskedTextBox.ValidatingType = typeof(int);
        // 
        // ConnectionNameTextBox
        // 
        ConnectionNameTextBox.Location = new Point(266, 127);
        ConnectionNameTextBox.Name = "ConnectionNameTextBox";
        ConnectionNameTextBox.Size = new Size(125, 27);
        ConnectionNameTextBox.TabIndex = 10;
        // 
        // LabelsGroupBox
        // 
        LabelsGroupBox.Controls.Add(ExistingLabelsGroupBox);
        LabelsGroupBox.Controls.Add(NewLabelsGroupBox);
        LabelsGroupBox.Location = new Point(3, 163);
        LabelsGroupBox.Name = "LabelsGroupBox";
        LabelsGroupBox.Size = new Size(794, 189);
        LabelsGroupBox.TabIndex = 11;
        LabelsGroupBox.TabStop = false;
        LabelsGroupBox.Text = "Etiketler";
        // 
        // AddConnectionPageLabel
        // 
        AddConnectionPageLabel.AutoSize = true;
        AddConnectionPageLabel.Font = new Font("Segoe UI", 26F);
        AddConnectionPageLabel.Location = new Point(228, 13);
        AddConnectionPageLabel.Name = "AddConnectionPageLabel";
        AddConnectionPageLabel.Size = new Size(328, 60);
        AddConnectionPageLabel.TabIndex = 12;
        AddConnectionPageLabel.Text = "BAĞLANTI EKLE";
        // 
        // ConnectionIpAddressMaskedTextBox
        // 
        ConnectionIpAddressMaskedTextBox.Location = new Point(601, 88);
        ConnectionIpAddressMaskedTextBox.Mask = "###.###.###.###";
        ConnectionIpAddressMaskedTextBox.Name = "ConnectionIpAddressMaskedTextBox";
        ConnectionIpAddressMaskedTextBox.Size = new Size(125, 27);
        ConnectionIpAddressMaskedTextBox.TabIndex = 14;
        ConnectionIpAddressMaskedTextBox.ValidatingType = typeof(IPAddress);
        // 
        // ConnectionIpAddressLabel
        // 
        ConnectionIpAddressLabel.AutoSize = true;
        ConnectionIpAddressLabel.Location = new Point(463, 91);
        ConnectionIpAddressLabel.Name = "ConnectionIpAddressLabel";
        ConnectionIpAddressLabel.Size = new Size(97, 20);
        ConnectionIpAddressLabel.TabIndex = 13;
        ConnectionIpAddressLabel.Text = "Bağlantı ip'si:";
        // 
        // AddConnectionPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(ConnectionIpAddressMaskedTextBox);
        Controls.Add(ConnectionIpAddressLabel);
        Controls.Add(AddConnectionPageLabel);
        Controls.Add(LabelsGroupBox);
        Controls.Add(ConnectionNameTextBox);
        Controls.Add(ConnectionPortMaskedTextBox);
        Controls.Add(AddConnectionButton);
        Controls.Add(ConnectionPortLabel);
        Controls.Add(ConnectionNameLabel);
        Controls.Add(HomePageButton);
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