using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

partial class HomePage
{
    private IContainer components = null;

    private Button SelectConnectionButton;
    private Button AddButton;
    private Label ApplicationNameLabel;
    private Button AboutButton;

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
        SelectConnectionButton = new Button();
        AddButton = new Button();
        ApplicationNameLabel = new Label();
        AboutButton = new Button();
        SuspendLayout();

        SelectConnectionButton.Location = new Point(84, 161);
        SelectConnectionButton.Name = "SelectConnectionButton";
        SelectConnectionButton.Size = new Size(160, 83);
        SelectConnectionButton.TabIndex = 0;
        SelectConnectionButton.Text = "Bağlantı seç";
        SelectConnectionButton.UseVisualStyleBackColor = true;
        SelectConnectionButton.Click += SelectConnectionButtonClick;

        AddButton.Location = new Point(494, 161);
        AddButton.Name = "AddButton";
        AddButton.Size = new Size(160, 83);
        AddButton.TabIndex = 1;
        AddButton.Text = "Ekle";
        AddButton.UseVisualStyleBackColor = true;
        AddButton.Click += AddButtonClick;

        ApplicationNameLabel.AutoSize = true;
        ApplicationNameLabel.Font = new Font("Segoe UI", 26F);
        ApplicationNameLabel.Location = new Point(27, 31);
        ApplicationNameLabel.Name = "ApplicationNameLabel";
        ApplicationNameLabel.Size = new Size(744, 60);
        ApplicationNameLabel.TabIndex = 2;
        ApplicationNameLabel.Text = "Ev Otomasyonu Masaüstü Uygulması";

        AboutButton.Location = new Point(288, 313);
        AboutButton.Name = "AboutButton";
        AboutButton.Size = new Size(160, 83);
        AboutButton.TabIndex = 3;
        AboutButton.Text = "Hakkında";
        AboutButton.UseVisualStyleBackColor = true;
        AboutButton.Click += AboutButtonClick;

        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(AboutButton);
        Controls.Add(ApplicationNameLabel);
        Controls.Add(AddButton);
        Controls.Add(SelectConnectionButton);
        Name = "HomePage";
        Text = "Hoşgeldin!";
        ResumeLayout(false);
        PerformLayout();
    }
}