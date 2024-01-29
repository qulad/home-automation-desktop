using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using HomeAutomation.Helpers.Desktop.Application.Constants;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class AboutPage
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
        AboutLabel = new Label();
        SuspendLayout();
        // 
        // AboutLabel
        // 
        AboutLabel.Anchor = AnchorStyles.None;
        AboutLabel.AutoSize = true;
        AboutLabel.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
        AboutLabel.ForeColor = Color.Gainsboro;
        AboutLabel.Location = new Point(356, 159);
        AboutLabel.Name = "AboutLabel";
        AboutLabel.Size = new Size(0, 21);
        AboutLabel.TabIndex = 5;
        // 
        // AboutPage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(34, 33, 74);
        Controls.Add(AboutLabel);
        Name = "AboutPage";
        Size = new Size(800, 450);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label AboutLabel;
}