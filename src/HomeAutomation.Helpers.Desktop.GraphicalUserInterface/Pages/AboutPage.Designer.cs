using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class AboutPage
{
    private IContainer components = null;

    private Button HomePageButton;
    private Label AboutLabel;

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
        AboutLabel = new Label();

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

        AboutLabel.AutoSize = true;
        AboutLabel.Location = new Point(430, 84);
        AboutLabel.Name = "AboutLabel";
        AboutLabel.Size = new Size(98, 20);
        AboutLabel.TabIndex = 5;
        AboutLabel.Text = "Bağlantı ismi:";

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(HomePageButton);
        Controls.Add(AboutLabel);

        Name = "A";
        Text = "AAA!";
        ResumeLayout(false);
        PerformLayout();
    }
}