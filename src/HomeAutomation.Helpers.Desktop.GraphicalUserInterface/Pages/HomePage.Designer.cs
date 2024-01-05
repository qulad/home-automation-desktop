namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface;

partial class HomePage
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        MonitorButton = new System.Windows.Forms.Button();
        AddButton = new System.Windows.Forms.Button();
        ApplicationNameLabel = new System.Windows.Forms.Label();
        AboutButton = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // MonitorButton
        // 
        MonitorButton.Location = new System.Drawing.Point(84, 161);
        MonitorButton.Name = "MonitorButton";
        MonitorButton.Size = new System.Drawing.Size(160, 83);
        MonitorButton.TabIndex = 0;
        MonitorButton.Text = "Monitörle";
        MonitorButton.UseVisualStyleBackColor = true;
        // 
        // AddButton
        // 
        AddButton.Location = new System.Drawing.Point(494, 161);
        AddButton.Name = "AddButton";
        AddButton.Size = new System.Drawing.Size(160, 83);
        AddButton.TabIndex = 1;
        AddButton.Text = "Ekle";
        AddButton.UseVisualStyleBackColor = true;
        // 
        // ApplicationNameLabel
        // 
        ApplicationNameLabel.AutoSize = true;
        ApplicationNameLabel.Font = new System.Drawing.Font("Segoe UI", 26F);
        ApplicationNameLabel.Location = new System.Drawing.Point(27, 31);
        ApplicationNameLabel.Name = "ApplicationNameLabel";
        ApplicationNameLabel.Size = new System.Drawing.Size(744, 60);
        ApplicationNameLabel.TabIndex = 2;
        ApplicationNameLabel.Text = "Ev Otomasyonu Masaüstü Uygulması";
        // 
        // AboutButton
        // 
        AboutButton.Location = new System.Drawing.Point(288, 313);
        AboutButton.Name = "AboutButton";
        AboutButton.Size = new System.Drawing.Size(160, 83);
        AboutButton.TabIndex = 3;
        AboutButton.Text = "Hakkında";
        AboutButton.UseVisualStyleBackColor = true;
        // 
        // HomePage
        // 
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

    #endregion

    private System.Windows.Forms.Button MonitorButton;
    private System.Windows.Forms.Button AddButton;
    private System.Windows.Forms.Label ApplicationNameLabel;
    private System.Windows.Forms.Button AboutButton;
}
