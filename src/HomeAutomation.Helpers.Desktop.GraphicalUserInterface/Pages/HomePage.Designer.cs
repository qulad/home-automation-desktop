namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class HomePage
{
    private System.ComponentModel.IContainer components = null;

    private System.Windows.Forms.Button MonitorButton;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Label ApplicationNameLabel;
    private System.Windows.Forms.Button AboutButton;

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
        MonitorButton = new System.Windows.Forms.Button();
        AddButton = new System.Windows.Forms.Button();
        ApplicationNameLabel = new System.Windows.Forms.Label();
        AboutButton = new System.Windows.Forms.Button();
        SuspendLayout();

        MonitorButton.Location = new System.Drawing.Point(84, 161);
        MonitorButton.Name = "MonitorButton";
        MonitorButton.Size = new System.Drawing.Size(160, 83);
        MonitorButton.TabIndex = 0;
        MonitorButton.Text = "Monitörle";
        MonitorButton.UseVisualStyleBackColor = true;

        AddButton.Location = new System.Drawing.Point(494, 161);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(160, 83);
        AddButton.TabIndex = 1;
        AddButton.Text = "Ekle";
        AddButton.UseVisualStyleBackColor = true;

        ApplicationNameLabel.AutoSize = true;
        ApplicationNameLabel.Font = new System.Drawing.Font("Segoe UI", 26F);
        ApplicationNameLabel.Location = new System.Drawing.Point(27, 31);
        ApplicationNameLabel.Name = "ApplicationNameLabel";
        ApplicationNameLabel.Size = new System.Drawing.Size(744, 60);
        ApplicationNameLabel.TabIndex = 2;
        ApplicationNameLabel.Text = "Ev Otomasyonu Masaüstü Uygulması";

        AboutButton.Location = new System.Drawing.Point(288, 313);
        AboutButton.Name = "AboutButton";
        AboutButton.Size = new System.Drawing.Size(160, 83);
        AboutButton.TabIndex = 3;
        AboutButton.Text = "Hakkında";
        AboutButton.UseVisualStyleBackColor = true;
        AboutButton.Click += AboutButtonClick;

        AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 450);
        Controls.Add(AboutButton);
        Controls.Add(ApplicationNameLabel);
        Controls.Add(AddButton);
        Controls.Add(MonitorButton);
        Name = "HomePage";
        Text = "Hoşgeldin!";
        ResumeLayout(false);
        PerformLayout();
    }
}
