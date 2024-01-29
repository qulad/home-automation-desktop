using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class HomePage
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
        components = new Container();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(HomePage));
        pictureBox1 = new PictureBox();
        TimeLabel = new Label();
        timer = new Timer(components);
        ((ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // pictureBox1
        // 
        pictureBox1.Anchor = AnchorStyles.None;
        pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
        pictureBox1.Location = new Point(259, 105);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new Size(256, 153);
        pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
        pictureBox1.TabIndex = 0;
        pictureBox1.TabStop = false;
        // 
        // TimeLabel
        // 
        TimeLabel.Anchor = AnchorStyles.None;
        TimeLabel.AutoSize = true;
        TimeLabel.Font = new Font("Century Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
        TimeLabel.ForeColor = Color.Gainsboro;
        TimeLabel.Location = new Point(244, 261);
        TimeLabel.Name = "TimeLabel";
        TimeLabel.Size = new Size(214, 74);
        TimeLabel.TabIndex = 1;
        TimeLabel.Text = "label1";
        // 
        // timer
        // 
        timer.Enabled = true;
        timer.Tick += timer_Tick;
        // 
        // HomePage
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(34, 33, 74);
        Controls.Add(TimeLabel);
        Controls.Add(pictureBox1);
        Name = "HomePage";
        Size = new Size(800, 450);
        Load += HomePageLoad;
        ((ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private PictureBox pictureBox1;
    private Label TimeLabel;
    private Timer timer;
}