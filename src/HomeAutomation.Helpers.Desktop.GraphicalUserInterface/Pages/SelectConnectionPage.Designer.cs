using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Pages;

public partial class SelectConnectionPage
{
    private IContainer components = null;
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
        SelectConnectionButton = new Button();
        ConnectionsListBox = new ListBox();
        SuspendLayout();
        // 
        // SelectConnectionButton
        // 
        SelectConnectionButton.Anchor = AnchorStyles.None;
        SelectConnectionButton.BackColor = Color.FromArgb(31, 31, 68);
        SelectConnectionButton.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SelectConnectionButton.ForeColor = Color.Gainsboro;
        SelectConnectionButton.Location = new Point(264, 255);
        SelectConnectionButton.Name = "SelectConnectionButton";
        SelectConnectionButton.Size = new Size(160, 83);
        SelectConnectionButton.TabIndex = 3;
        SelectConnectionButton.Text = "Monitörle";
        SelectConnectionButton.UseVisualStyleBackColor = false;
        SelectConnectionButton.Click += SelectConnectionButtonClick;
        // 
        // ConnectionsListBox
        // 
        ConnectionsListBox.Anchor = AnchorStyles.None;
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
        BackColor = Color.FromArgb(34, 33, 74);
        Controls.Add(SelectConnectionButton);
        Controls.Add(ConnectionsListBox);
        Name = "SelectConnectionPage";
        Size = new Size(800, 450);
        VisibleChanged += LoadConnectionListBox;
        ResumeLayout(false);
    }
}