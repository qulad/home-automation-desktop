using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;

public partial class MainWindow
{
    private void InitializeComponent()
    {
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Name = "HomePage";
        Text = "Akıllı Ev Otomasyon Sistemi Masaüstü Yardımcısı!";
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        ResumeLayout(false);
        PerformLayout();
    }
}