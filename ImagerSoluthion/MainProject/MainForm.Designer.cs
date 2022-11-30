
namespace MainForm
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.iconsForTabs = new System.Windows.Forms.ImageList(this.components);
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lblVersion2 = new System.Windows.Forms.Label();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.closeToTraySwitch = new MaterialSkin.Controls.MaterialSwitch();
            this.switchTheme = new MaterialSkin.Controls.MaterialSwitch();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.lblVersion1 = new System.Windows.Forms.Label();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.lblDroppedFilesURL = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.pbProgress = new MaterialSkin.Controls.MaterialProgressBar();
            this.pnlDropZone = new System.Windows.Forms.Panel();
            this.lblDragDropInfo = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.imagerApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabSettings.SuspendLayout();
            this.materialCard5.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.materialCard1.SuspendLayout();
            this.materialCard3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.pnlDropZone.SuspendLayout();
            this.materialTabControl1.SuspendLayout();
            this.trayIconContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconsForTabs
            // 
            this.iconsForTabs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iconsForTabs.ImageStream")));
            this.iconsForTabs.TransparentColor = System.Drawing.Color.Transparent;
            this.iconsForTabs.Images.SetKeyName(0, "Settings.png");
            this.iconsForTabs.Images.SetKeyName(1, "Upload.png");
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.lblVersion2);
            this.tabSettings.Controls.Add(this.materialLabel3);
            this.tabSettings.Controls.Add(this.materialCard5);
            this.tabSettings.ImageKey = "Settings.png";
            this.tabSettings.Location = new System.Drawing.Point(4, 39);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(888, 355);
            this.tabSettings.TabIndex = 2;
            this.tabSettings.ToolTipText = "Settings tab";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // lblVersion2
            // 
            this.lblVersion2.AutoSize = true;
            this.lblVersion2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblVersion2.Location = new System.Drawing.Point(772, 28);
            this.lblVersion2.Name = "lblVersion2";
            this.lblVersion2.Size = new System.Drawing.Size(52, 16);
            this.lblVersion2.TabIndex = 13;
            this.lblVersion2.Text = "version";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel3.Location = new System.Drawing.Point(401, 16);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(369, 72);
            this.materialLabel3.TabIndex = 12;
            this.materialLabel3.Text = "I  M  A  G  E  R";
            this.materialLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.closeToTraySwitch);
            this.materialCard5.Controls.Add(this.switchTheme);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(14, 14);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(330, 114);
            this.materialCard5.TabIndex = 6;
            // 
            // closeToTraySwitch
            // 
            this.closeToTraySwitch.AutoSize = true;
            this.closeToTraySwitch.Depth = 0;
            this.closeToTraySwitch.Location = new System.Drawing.Point(14, 58);
            this.closeToTraySwitch.Margin = new System.Windows.Forms.Padding(0);
            this.closeToTraySwitch.MouseLocation = new System.Drawing.Point(-1, -1);
            this.closeToTraySwitch.MouseState = MaterialSkin.MouseState.HOVER;
            this.closeToTraySwitch.Name = "closeToTraySwitch";
            this.closeToTraySwitch.Ripple = true;
            this.closeToTraySwitch.Size = new System.Drawing.Size(146, 37);
            this.closeToTraySwitch.TabIndex = 2;
            this.closeToTraySwitch.Text = "Close to tray";
            this.closeToTraySwitch.UseVisualStyleBackColor = true;
            this.closeToTraySwitch.CheckedChanged += new System.EventHandler(this.closeToTraySwitch_CheckedChanged);
            // 
            // switchTheme
            // 
            this.switchTheme.AutoSize = true;
            this.switchTheme.Depth = 0;
            this.switchTheme.Location = new System.Drawing.Point(14, 21);
            this.switchTheme.Margin = new System.Windows.Forms.Padding(0);
            this.switchTheme.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switchTheme.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchTheme.Name = "switchTheme";
            this.switchTheme.Ripple = true;
            this.switchTheme.Size = new System.Drawing.Size(142, 37);
            this.switchTheme.TabIndex = 1;
            this.switchTheme.Text = "Light theme";
            this.switchTheme.UseVisualStyleBackColor = true;
            this.switchTheme.CheckedChanged += new System.EventHandler(this.switchTheme_CheckedChanged);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.lblVersion1);
            this.tabMain.Controls.Add(this.materialCard1);
            this.tabMain.Controls.Add(this.materialCard3);
            this.tabMain.Controls.Add(this.materialCard2);
            this.tabMain.Controls.Add(this.materialLabel1);
            this.tabMain.ImageKey = "Upload.png";
            this.tabMain.Location = new System.Drawing.Point(4, 39);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(888, 355);
            this.tabMain.TabIndex = 1;
            this.tabMain.ToolTipText = "Upload tab";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // lblVersion1
            // 
            this.lblVersion1.AutoSize = true;
            this.lblVersion1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lblVersion1.Location = new System.Drawing.Point(772, 28);
            this.lblVersion1.Name = "lblVersion1";
            this.lblVersion1.Size = new System.Drawing.Size(52, 16);
            this.lblVersion1.TabIndex = 11;
            this.lblVersion1.Text = "version";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialComboBox1);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(14, 14);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(330, 83);
            this.materialCard1.TabIndex = 5;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 122;
            this.materialComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Items.AddRange(new object[] {
            "imgbb.com"});
            this.materialComboBox1.Location = new System.Drawing.Point(14, 14);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(302, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 0;
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.lblDroppedFilesURL);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(14, 276);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(810, 112);
            this.materialCard3.TabIndex = 3;
            // 
            // lblDroppedFilesURL
            // 
            this.lblDroppedFilesURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblDroppedFilesURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDroppedFilesURL.Depth = 0;
            this.lblDroppedFilesURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDroppedFilesURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDroppedFilesURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDroppedFilesURL.Hint = "test";
            this.lblDroppedFilesURL.Location = new System.Drawing.Point(14, 14);
            this.lblDroppedFilesURL.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDroppedFilesURL.Name = "lblDroppedFilesURL";
            this.lblDroppedFilesURL.ReadOnly = true;
            this.lblDroppedFilesURL.Size = new System.Drawing.Size(782, 84);
            this.lblDroppedFilesURL.TabIndex = 0;
            this.lblDroppedFilesURL.Text = "";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.pbProgress);
            this.materialCard2.Controls.Add(this.pnlDropZone);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(14, 102);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(810, 169);
            this.materialCard2.TabIndex = 1;
            // 
            // pbProgress
            // 
            this.pbProgress.Depth = 0;
            this.pbProgress.Location = new System.Drawing.Point(0, 164);
            this.pbProgress.MarqueeAnimationSpeed = 1000;
            this.pbProgress.MouseState = MaterialSkin.MouseState.HOVER;
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(810, 5);
            this.pbProgress.Step = 1;
            this.pbProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbProgress.TabIndex = 1;
            // 
            // pnlDropZone
            // 
            this.pnlDropZone.AllowDrop = true;
            this.pnlDropZone.BackColor = System.Drawing.Color.NavajoWhite;
            this.pnlDropZone.Controls.Add(this.lblDragDropInfo);
            this.pnlDropZone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDropZone.Location = new System.Drawing.Point(14, 14);
            this.pnlDropZone.Name = "pnlDropZone";
            this.pnlDropZone.Size = new System.Drawing.Size(782, 141);
            this.pnlDropZone.TabIndex = 1;
            this.pnlDropZone.Click += new System.EventHandler(this.pnlDropZone_Click);
            this.pnlDropZone.DragDrop += new System.Windows.Forms.DragEventHandler(this.pnlDropZone_DragDropAsync);
            this.pnlDropZone.DragEnter += new System.Windows.Forms.DragEventHandler(this.pnlDropZone_DragEnter);
            this.pnlDropZone.DragLeave += new System.EventHandler(this.pnlDropZone_DragLeave);
            // 
            // lblDragDropInfo
            // 
            this.lblDragDropInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDragDropInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblDragDropInfo.Depth = 0;
            this.lblDragDropInfo.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDragDropInfo.FontType = MaterialSkin.MaterialSkinManager.fontType.Body2;
            this.lblDragDropInfo.Location = new System.Drawing.Point(297, 61);
            this.lblDragDropInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDragDropInfo.Name = "lblDragDropInfo";
            this.lblDragDropInfo.Size = new System.Drawing.Size(173, 17);
            this.lblDragDropInfo.TabIndex = 0;
            this.lblDragDropInfo.Text = "Choose a file or drag it here.";
            this.lblDragDropInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDragDropInfo.Click += new System.EventHandler(this.lblDragDropInfo_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Light", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H2;
            this.materialLabel1.Location = new System.Drawing.Point(401, 16);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(369, 72);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "I  M  A  G  E  R";
            this.materialLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabMain);
            this.materialTabControl1.Controls.Add(this.tabSettings);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.iconsForTabs;
            this.materialTabControl1.Location = new System.Drawing.Point(0, 24);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(896, 398);
            this.materialTabControl1.TabIndex = 3;
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "notifyIcon1";
            this.trayIcon.Visible = true;
            this.trayIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.trayIcon_MouseDoubleClick);
            // 
            // trayIconContextMenu
            // 
            this.trayIconContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imagerApplicationToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.trayIconContextMenu.Name = "trayIconContextMenu";
            this.trayIconContextMenu.Size = new System.Drawing.Size(117, 82);
            // 
            // imagerApplicationToolStripMenuItem
            // 
            this.imagerApplicationToolStripMenuItem.Name = "imagerApplicationToolStripMenuItem";
            this.imagerApplicationToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.imagerApplicationToolStripMenuItem.Text = "Imager";
            this.imagerApplicationToolStripMenuItem.Click += new System.EventHandler(this.imagerApplicationToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(113, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(899, 425);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 24, 3, 3);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Imager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.materialCard1.ResumeLayout(false);
            this.materialCard3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.pnlDropZone.ResumeLayout(false);
            this.materialTabControl1.ResumeLayout(false);
            this.trayIconContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList iconsForTabs;
        private System.Windows.Forms.TabPage tabSettings;
        private MaterialSkin.Controls.MaterialSwitch switchTheme;
        private System.Windows.Forms.TabPage tabMain;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.Panel pnlDropZone;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialLabel lblDragDropInfo;
        private MaterialSkin.Controls.MaterialMultiLineTextBox lblDroppedFilesURL;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialSwitch closeToTraySwitch;
        private MaterialSkin.Controls.MaterialProgressBar pbProgress;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Label lblVersion1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label lblVersion2;
        private System.Windows.Forms.ContextMenuStrip trayIconContextMenu;
        private System.Windows.Forms.ToolStripMenuItem imagerApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

