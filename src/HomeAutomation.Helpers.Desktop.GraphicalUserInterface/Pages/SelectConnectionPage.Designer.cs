using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class SelectConnectionPage
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

        this.components = new Container();
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Text = "MonitorPage";

        HomePageButton.Location = new Point(288, 313);
        HomePageButton.Name = "HomePage";
        HomePageButton.Size = new Size(160, 83);
        HomePageButton.TabIndex = 3;
        HomePageButton.Text = "Ana sayfa";
        HomePageButton.UseVisualStyleBackColor = true;
        HomePageButton.Click += HomePageButtonClick;

        SelectConnectionButton.Location = new Point(488, 313);
        SelectConnectionButton.Name = "SelectConnectionButton";
        SelectConnectionButton.Size = new Size(160, 83);
        SelectConnectionButton.TabIndex = 3;
        SelectConnectionButton.Text = "Monitörle";
        SelectConnectionButton.UseVisualStyleBackColor = true;
        SelectConnectionButton.Click += SelectConnectionButtonClick;

        ConnectionsListBox.FormattingEnabled = true;
        ConnectionsListBox.Location = new Point(6, 26);
        ConnectionsListBox.Name = "ConnectionsListBox";
        ConnectionsListBox.Size = new Size(173, 124);
        ConnectionsListBox.TabIndex = 0;

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(HomePageButton);
        Controls.Add(SelectConnectionButton);
        Controls.Add(ConnectionsListBox);

        Name = "A";
        Text = "AAA!";
        ResumeLayout(false);
        PerformLayout();
    }
}