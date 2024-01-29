using System.Drawing;
using System.Windows.Forms;

namespace HomeAutomation.Helpers.Desktop.GraphicalUserInterface.Windows;

public partial class MainWindow
{
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
        PanelMenu = new Panel();
        AboutPageButton = new FontAwesome.Sharp.IconButton();
        SelectConnectionsButton = new FontAwesome.Sharp.IconButton();
        AddConnectionPageButton = new FontAwesome.Sharp.IconButton();
        PanelLogo = new Panel();
        HomeButton = new PictureBox();
        PanelTitleBar = new Panel();
        IconClose = new FontAwesome.Sharp.IconPictureBox();
        IconMaximize = new FontAwesome.Sharp.IconPictureBox();
        IconMinimize = new FontAwesome.Sharp.IconPictureBox();
        ChildUserControlTitleLabel = new Label();
        IconCurrentUserControl = new FontAwesome.Sharp.IconPictureBox();
        PanelShadow = new Panel();
        PanelDesktop = new Panel();
        PanelMenu.SuspendLayout();
        PanelLogo.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)HomeButton).BeginInit();
        PanelTitleBar.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)IconClose).BeginInit();
        ((System.ComponentModel.ISupportInitialize)IconMaximize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)IconMinimize).BeginInit();
        ((System.ComponentModel.ISupportInitialize)IconCurrentUserControl).BeginInit();
        SuspendLayout();
        // 
        // PanelMenu
        // 
        PanelMenu.BackColor = Color.FromArgb(31, 31, 68);
        PanelMenu.Controls.Add(AboutPageButton);
        PanelMenu.Controls.Add(SelectConnectionsButton);
        PanelMenu.Controls.Add(AddConnectionPageButton);
        PanelMenu.Controls.Add(PanelLogo);
        PanelMenu.Dock = DockStyle.Left;
        PanelMenu.Location = new Point(0, 0);
        PanelMenu.Name = "PanelMenu";
        PanelMenu.Size = new Size(220, 544);
        PanelMenu.TabIndex = 0;
        // 
        // AboutPageButton
        // 
        AboutPageButton.Dock = DockStyle.Top;
        AboutPageButton.FlatAppearance.BorderSize = 0;
        AboutPageButton.FlatStyle = FlatStyle.Flat;
        AboutPageButton.Font = new Font("Century Gothic", 10F);
        AboutPageButton.ForeColor = Color.Gainsboro;
        AboutPageButton.IconChar = FontAwesome.Sharp.IconChar.Capsules;
        AboutPageButton.IconColor = Color.Gainsboro;
        AboutPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
        AboutPageButton.IconSize = 32;
        AboutPageButton.ImageAlign = ContentAlignment.MiddleLeft;
        AboutPageButton.Location = new Point(0, 268);
        AboutPageButton.Name = "AboutPageButton";
        AboutPageButton.Padding = new Padding(10, 0, 20, 0);
        AboutPageButton.Size = new Size(220, 60);
        AboutPageButton.TabIndex = 3;
        AboutPageButton.Text = "About This App";
        AboutPageButton.TextAlign = ContentAlignment.MiddleLeft;
        AboutPageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        AboutPageButton.UseVisualStyleBackColor = true;
        AboutPageButton.Click += AboutPageButtonClick;
        // 
        // SelectConnectionsButton
        // 
        SelectConnectionsButton.Dock = DockStyle.Top;
        SelectConnectionsButton.FlatAppearance.BorderSize = 0;
        SelectConnectionsButton.FlatStyle = FlatStyle.Flat;
        SelectConnectionsButton.Font = new Font("Century Gothic", 10F);
        SelectConnectionsButton.ForeColor = Color.Gainsboro;
        SelectConnectionsButton.IconChar = FontAwesome.Sharp.IconChar.CarBattery;
        SelectConnectionsButton.IconColor = Color.Gainsboro;
        SelectConnectionsButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
        SelectConnectionsButton.IconSize = 32;
        SelectConnectionsButton.ImageAlign = ContentAlignment.MiddleLeft;
        SelectConnectionsButton.Location = new Point(0, 208);
        SelectConnectionsButton.Name = "SelectConnectionsButton";
        SelectConnectionsButton.Padding = new Padding(10, 0, 20, 0);
        SelectConnectionsButton.Size = new Size(220, 60);
        SelectConnectionsButton.TabIndex = 2;
        SelectConnectionsButton.Text = "Connections";
        SelectConnectionsButton.TextAlign = ContentAlignment.MiddleLeft;
        SelectConnectionsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        SelectConnectionsButton.UseVisualStyleBackColor = true;
        SelectConnectionsButton.Click += SelectConnectionsButtonClick;
        // 
        // AddConnectionPageButton
        // 
        AddConnectionPageButton.Dock = DockStyle.Top;
        AddConnectionPageButton.FlatAppearance.BorderSize = 0;
        AddConnectionPageButton.FlatStyle = FlatStyle.Flat;
        AddConnectionPageButton.Font = new Font("Century Gothic", 10F);
        AddConnectionPageButton.ForeColor = Color.Gainsboro;
        AddConnectionPageButton.IconChar = FontAwesome.Sharp.IconChar.Caravan;
        AddConnectionPageButton.IconColor = Color.Gainsboro;
        AddConnectionPageButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
        AddConnectionPageButton.IconSize = 32;
        AddConnectionPageButton.ImageAlign = ContentAlignment.MiddleLeft;
        AddConnectionPageButton.Location = new Point(0, 148);
        AddConnectionPageButton.Name = "AddConnectionPageButton";
        AddConnectionPageButton.Padding = new Padding(10, 0, 20, 0);
        AddConnectionPageButton.Size = new Size(220, 60);
        AddConnectionPageButton.TabIndex = 1;
        AddConnectionPageButton.Text = "Add Connection";
        AddConnectionPageButton.TextAlign = ContentAlignment.MiddleLeft;
        AddConnectionPageButton.TextImageRelation = TextImageRelation.ImageBeforeText;
        AddConnectionPageButton.UseVisualStyleBackColor = true;
        AddConnectionPageButton.Click += AddConnectionPageButtonClick;
        // 
        // PanelLogo
        // 
        PanelLogo.Controls.Add(HomeButton);
        PanelLogo.Dock = DockStyle.Top;
        PanelLogo.Location = new Point(0, 0);
        PanelLogo.Name = "PanelLogo";
        PanelLogo.Size = new Size(220, 148);
        PanelLogo.TabIndex = 0;
        // 
        // HomeButton
        // 
        HomeButton.Image = (Image)resources.GetObject("HomeButton.Image");
        HomeButton.Location = new Point(18, 23);
        HomeButton.Name = "HomeButton";
        HomeButton.Size = new Size(180, 109);
        HomeButton.SizeMode = PictureBoxSizeMode.Zoom;
        HomeButton.TabIndex = 0;
        HomeButton.TabStop = false;
        HomeButton.Click += HomeButtonClick;
        // 
        // PanelTitleBar
        // 
        PanelTitleBar.BackColor = Color.FromArgb(26, 25, 52);
        PanelTitleBar.Controls.Add(IconClose);
        PanelTitleBar.Controls.Add(IconMaximize);
        PanelTitleBar.Controls.Add(IconMinimize);
        PanelTitleBar.Controls.Add(ChildUserControlTitleLabel);
        PanelTitleBar.Controls.Add(IconCurrentUserControl);
        PanelTitleBar.Dock = DockStyle.Top;
        PanelTitleBar.Location = new Point(220, 0);
        PanelTitleBar.Name = "PanelTitleBar";
        PanelTitleBar.Size = new Size(699, 75);
        PanelTitleBar.TabIndex = 1;
        PanelTitleBar.MouseDown += PanelTitleBarMouseDown;
        // 
        // IconClose
        // 
        IconClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        IconClose.BackColor = Color.FromArgb(26, 25, 52);
        IconClose.ForeColor = SystemColors.ControlText;
        IconClose.IconChar = FontAwesome.Sharp.IconChar.RectangleTimes;
        IconClose.IconColor = SystemColors.ControlText;
        IconClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
        IconClose.IconSize = 40;
        IconClose.Location = new Point(647, 19);
        IconClose.Name = "IconClose";
        IconClose.Size = new Size(40, 40);
        IconClose.TabIndex = 4;
        IconClose.TabStop = false;
        IconClose.Click += IconCloseClick;
        // 
        // IconMaximize
        // 
        IconMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        IconMaximize.BackColor = Color.FromArgb(26, 25, 52);
        IconMaximize.ForeColor = SystemColors.ControlText;
        IconMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
        IconMaximize.IconColor = SystemColors.ControlText;
        IconMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
        IconMaximize.IconSize = 40;
        IconMaximize.Location = new Point(601, 19);
        IconMaximize.Name = "IconMaximize";
        IconMaximize.Size = new Size(40, 40);
        IconMaximize.TabIndex = 3;
        IconMaximize.TabStop = false;
        IconMaximize.Click += IconMaximizeClick;
        // 
        // IconMinimize
        // 
        IconMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        IconMinimize.BackColor = Color.FromArgb(26, 25, 52);
        IconMinimize.ForeColor = SystemColors.WindowText;
        IconMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
        IconMinimize.IconColor = SystemColors.WindowText;
        IconMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
        IconMinimize.IconSize = 40;
        IconMinimize.Location = new Point(555, 19);
        IconMinimize.Name = "IconMinimize";
        IconMinimize.Size = new Size(40, 40);
        IconMinimize.TabIndex = 2;
        IconMinimize.TabStop = false;
        IconMinimize.Click += IconMinimizeClick;
        // 
        // ChildUserControlTitleLabel
        // 
        ChildUserControlTitleLabel.AutoSize = true;
        ChildUserControlTitleLabel.Font = new Font("Century Gothic", 10F);
        ChildUserControlTitleLabel.ForeColor = Color.Gainsboro;
        ChildUserControlTitleLabel.Location = new Point(72, 30);
        ChildUserControlTitleLabel.Name = "ChildUserControlTitleLabel";
        ChildUserControlTitleLabel.Size = new Size(59, 21);
        ChildUserControlTitleLabel.TabIndex = 1;
        ChildUserControlTitleLabel.Text = "Home";
        // 
        // IconCurrentUserControl
        // 
        IconCurrentUserControl.BackColor = Color.FromArgb(26, 25, 52);
        IconCurrentUserControl.ForeColor = Color.MediumPurple;
        IconCurrentUserControl.IconChar = FontAwesome.Sharp.IconChar.HomeLgAlt;
        IconCurrentUserControl.IconColor = Color.MediumPurple;
        IconCurrentUserControl.IconFont = FontAwesome.Sharp.IconFont.Auto;
        IconCurrentUserControl.IconSize = 40;
        IconCurrentUserControl.Location = new Point(29, 19);
        IconCurrentUserControl.Name = "IconCurrentUserControl";
        IconCurrentUserControl.Size = new Size(40, 40);
        IconCurrentUserControl.TabIndex = 0;
        IconCurrentUserControl.TabStop = false;
        // 
        // PanelShadow
        // 
        PanelShadow.BackColor = Color.FromArgb(26, 24, 58);
        PanelShadow.Dock = DockStyle.Top;
        PanelShadow.Location = new Point(220, 75);
        PanelShadow.Name = "PanelShadow";
        PanelShadow.Size = new Size(699, 10);
        PanelShadow.TabIndex = 2;
        // 
        // PanelDesktop
        // 
        PanelDesktop.BackColor = Color.FromArgb(34, 33, 74);
        PanelDesktop.Dock = DockStyle.Fill;
        PanelDesktop.Location = new Point(220, 85);
        PanelDesktop.Name = "PanelDesktop";
        PanelDesktop.Size = new Size(699, 459);
        PanelDesktop.TabIndex = 3;
        // 
        // MainWindow
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(919, 544);
        Controls.Add(PanelDesktop);
        Controls.Add(PanelShadow);
        Controls.Add(PanelTitleBar);
        Controls.Add(PanelMenu);
        Name = "MainWindow";
        Text = "Akıllı Ev Otomasyon Sistemi Masaüstü Yardımcısı!";
        Load += MainWindowLoad;
        PanelMenu.ResumeLayout(false);
        PanelLogo.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)HomeButton).EndInit();
        PanelTitleBar.ResumeLayout(false);
        PanelTitleBar.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)IconClose).EndInit();
        ((System.ComponentModel.ISupportInitialize)IconMaximize).EndInit();
        ((System.ComponentModel.ISupportInitialize)IconMinimize).EndInit();
        ((System.ComponentModel.ISupportInitialize)IconCurrentUserControl).EndInit();
        ResumeLayout(false);
    }

    private Panel PanelMenu;
    private Panel PanelLogo;
    private FontAwesome.Sharp.IconButton AddConnectionPageButton;
    private FontAwesome.Sharp.IconButton AboutPageButton;
    private FontAwesome.Sharp.IconButton SelectConnectionsButton;
    private PictureBox HomeButton;
    private Panel PanelTitleBar;
    private FontAwesome.Sharp.IconPictureBox IconCurrentUserControl;
    private Label ChildUserControlTitleLabel;
    private Panel PanelShadow;
    private Panel PanelDesktop;
    private FontAwesome.Sharp.IconPictureBox IconMinimize;
    private FontAwesome.Sharp.IconPictureBox IconClose;
    private FontAwesome.Sharp.IconPictureBox IconMaximize;
}