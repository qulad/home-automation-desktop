using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class SelectConnectionPage
{
    private IContainer components = null;

    private Button HomePageButton;
    private Button SelectConnectionButton;
    private ListBox ConnectionsListBox;

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
        SelectConnectionButton = new Button();
        ConnectionsListBox = new ListBox();
        SuspendLayout();
        // 
        // HomePageButton
        // 
        HomePageButton.Location = new Point(144, 278);
        HomePageButton.Name = "HomePageButton";
        HomePageButton.Size = new Size(160, 83);
        HomePageButton.TabIndex = 3;
        HomePageButton.Text = "Ana sayfa";
        HomePageButton.UseVisualStyleBackColor = true;
        HomePageButton.Click += HomePageButtonClick;
        // 
        // SelectConnectionButton
        // 
        SelectConnectionButton.Location = new Point(508, 247);
        SelectConnectionButton.Name = "SelectConnectionButton";
        SelectConnectionButton.Size = new Size(160, 83);
        SelectConnectionButton.TabIndex = 3;
        SelectConnectionButton.Text = "Monitörle";
        SelectConnectionButton.UseVisualStyleBackColor = true;
        SelectConnectionButton.Click += SelectConnectionButtonClick;
        // 
        // ConnectionsListBox
        // 
        ConnectionsListBox.FormattingEnabled = true;
        ConnectionsListBox.Location = new Point(144, 76);
        ConnectionsListBox.Name = "ConnectionsListBox";
        ConnectionsListBox.Size = new Size(173, 124);
        ConnectionsListBox.TabIndex = 0;
        // 
        // SelectConnectionPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(HomePageButton);
        Controls.Add(SelectConnectionButton);
        Controls.Add(ConnectionsListBox);
        Name = "SelectConnectionPage";
        Size = new Size(800, 450);
        VisibleChanged += LoadConnectionListBox;
        ResumeLayout(false);
    }
}