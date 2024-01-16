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
        SuspendLayout();

        this.components = new Container();
        this.AutoScaleMode = AutoScaleMode.Font;
        this.ClientSize = new Size(800, 450);
        this.Text = "HomePage";

        HomePageButton.Location = new Point(288, 313);
        HomePageButton.Name = "HomePage";
        HomePageButton.Size = new Size(160, 83);
        HomePageButton.TabIndex = 3;
        HomePageButton.Text = "Ana sayfa";
        HomePageButton.UseVisualStyleBackColor = true;
        HomePageButton.Click += HomePageButtonClick;

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(HomePageButton);

        Name = "A";
        Text = "AAA!";
        ResumeLayout(false);
        PerformLayout();
    }
}