﻿namespace PixelMagic.GUI
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdStartBot = new System.Windows.Forms.Button();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.lblHotkeyInfo = new System.Windows.Forms.Label();
            this.txtTargetCasting = new System.Windows.Forms.TextBox();
            this.cmdDonate = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtMouseXYClick = new System.Windows.Forms.TextBox();
            this.txtMouseXY = new System.Windows.Forms.TextBox();
            this.chkPlayErrorSounds = new System.Windows.Forms.CheckBox();
            this.chkDisableOverlay = new System.Windows.Forms.CheckBox();
            this.nudPulse = new System.Windows.Forms.NumericUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.cmdRotationSettings = new System.Windows.Forms.Button();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hotkeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spellbookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reloadAddonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptCombatRoutineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToByteArrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transparentLabel3 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.prgTargetHealth = new ColorProgressBar.ColorProgressBar();
            this.transparentLabel12 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.transparentLabel11 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.transparentLabel10 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.transparentLabel9 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.transparentLabel7 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.transparentLabel8 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.transparentLabel6 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.transparentLabel5 = new PixelMagic.GUI.GUI.TransparentLabel();
            this.prgPower = new ColorProgressBar.ColorProgressBar();
            this.prgPlayerHealth = new ColorProgressBar.ColorProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPulse)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdStartBot
            // 
            this.cmdStartBot.Enabled = false;
            this.cmdStartBot.ForeColor = System.Drawing.Color.Black;
            this.cmdStartBot.Location = new System.Drawing.Point(841, 39);
            this.cmdStartBot.Name = "cmdStartBot";
            this.cmdStartBot.Size = new System.Drawing.Size(142, 31);
            this.cmdStartBot.TabIndex = 1;
            this.cmdStartBot.Text = "Start rotation";
            this.cmdStartBot.UseVisualStyleBackColor = false;
            this.cmdStartBot.Click += new System.EventHandler(this.cmdStartBot_Click);
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.White;
            this.rtbLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rtbLog.Location = new System.Drawing.Point(0, 24);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtbLog.Size = new System.Drawing.Size(825, 515);
            this.rtbLog.TabIndex = 2;
            this.rtbLog.Text = "";
            this.rtbLog.TextChanged += new System.EventHandler(this.rtbLog_TextChanged);
            // 
            // lblHotkeyInfo
            // 
            this.lblHotkeyInfo.AutoSize = true;
            this.lblHotkeyInfo.Location = new System.Drawing.Point(476, 312);
            this.lblHotkeyInfo.Name = "lblHotkeyInfo";
            this.lblHotkeyInfo.Size = new System.Drawing.Size(68, 13);
            this.lblHotkeyInfo.TabIndex = 3;
            this.lblHotkeyInfo.Text = "[Hotkey Info]";
            // 
            // txtTargetCasting
            // 
            this.txtTargetCasting.ForeColor = System.Drawing.Color.White;
            this.txtTargetCasting.Location = new System.Drawing.Point(922, 196);
            this.txtTargetCasting.Name = "txtTargetCasting";
            this.txtTargetCasting.ReadOnly = true;
            this.txtTargetCasting.Size = new System.Drawing.Size(61, 20);
            this.txtTargetCasting.TabIndex = 11;
            this.txtTargetCasting.TextChanged += new System.EventHandler(this.txtTargetCasting_TextChanged);
            // 
            // cmdDonate
            // 
            this.cmdDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cmdDonate.BackColor = System.Drawing.Color.White;
            this.cmdDonate.ForeColor = System.Drawing.Color.DimGray;
            this.cmdDonate.Location = new System.Drawing.Point(841, 494);
            this.cmdDonate.Name = "cmdDonate";
            this.cmdDonate.Size = new System.Drawing.Size(142, 31);
            this.cmdDonate.TabIndex = 12;
            this.cmdDonate.Text = "Donate";
            this.cmdDonate.UseVisualStyleBackColor = false;
            this.cmdDonate.Click += new System.EventHandler(this.cmdDonate_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.setupToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(996, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // txtMouseXYClick
            // 
            this.txtMouseXYClick.ForeColor = System.Drawing.Color.White;
            this.txtMouseXYClick.Location = new System.Drawing.Point(922, 250);
            this.txtMouseXYClick.Name = "txtMouseXYClick";
            this.txtMouseXYClick.ReadOnly = true;
            this.txtMouseXYClick.Size = new System.Drawing.Size(61, 20);
            this.txtMouseXYClick.TabIndex = 8;
            // 
            // txtMouseXY
            // 
            this.txtMouseXY.ForeColor = System.Drawing.Color.White;
            this.txtMouseXY.Location = new System.Drawing.Point(922, 223);
            this.txtMouseXY.Name = "txtMouseXY";
            this.txtMouseXY.ReadOnly = true;
            this.txtMouseXY.Size = new System.Drawing.Size(61, 20);
            this.txtMouseXY.TabIndex = 8;
            // 
            // chkPlayErrorSounds
            // 
            this.chkPlayErrorSounds.AutoSize = true;
            this.chkPlayErrorSounds.Checked = true;
            this.chkPlayErrorSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPlayErrorSounds.ForeColor = System.Drawing.Color.Black;
            this.chkPlayErrorSounds.Location = new System.Drawing.Point(969, 304);
            this.chkPlayErrorSounds.Name = "chkPlayErrorSounds";
            this.chkPlayErrorSounds.Size = new System.Drawing.Size(15, 14);
            this.chkPlayErrorSounds.TabIndex = 18;
            this.chkPlayErrorSounds.UseVisualStyleBackColor = false;
            this.chkPlayErrorSounds.CheckedChanged += new System.EventHandler(this.chkPlayErrorSounds_CheckedChanged);
            // 
            // chkDisableOverlay
            // 
            this.chkDisableOverlay.AutoSize = true;
            this.chkDisableOverlay.Checked = true;
            this.chkDisableOverlay.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDisableOverlay.ForeColor = System.Drawing.Color.Black;
            this.chkDisableOverlay.Location = new System.Drawing.Point(969, 325);
            this.chkDisableOverlay.Name = "chkDisableOverlay";
            this.chkDisableOverlay.Size = new System.Drawing.Size(15, 14);
            this.chkDisableOverlay.TabIndex = 19;
            this.chkDisableOverlay.UseVisualStyleBackColor = false;
            this.chkDisableOverlay.CheckedChanged += new System.EventHandler(this.chkDisableOverlay_CheckedChanged);
            // 
            // nudPulse
            // 
            this.nudPulse.ForeColor = System.Drawing.Color.White;
            this.nudPulse.Location = new System.Drawing.Point(922, 277);
            this.nudPulse.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudPulse.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPulse.Name = "nudPulse";
            this.nudPulse.Size = new System.Drawing.Size(61, 20);
            this.nudPulse.TabIndex = 21;
            this.nudPulse.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudPulse.ValueChanged += new System.EventHandler(this.nudPulse_ValueChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(996, 24);
            this.statusStrip1.TabIndex = 23;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(195, 19);
            this.toolStripStatusLabel2.Text = "PixelMagic (developed by WiNiFiX)";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(69, 19);
            this.toolStripStatusLabel3.Text = "Version: {0}";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(85, 19);
            this.toolStripStatusLabel1.Text = "Build Date: {0}";
            // 
            // cmdRotationSettings
            // 
            this.cmdRotationSettings.Enabled = false;
            this.cmdRotationSettings.ForeColor = System.Drawing.Color.Black;
            this.cmdRotationSettings.Location = new System.Drawing.Point(841, 77);
            this.cmdRotationSettings.Name = "cmdRotationSettings";
            this.cmdRotationSettings.Size = new System.Drawing.Size(142, 31);
            this.cmdRotationSettings.TabIndex = 26;
            this.cmdRotationSettings.Text = "Rotation settings...";
            this.cmdRotationSettings.UseVisualStyleBackColor = false;
            this.cmdRotationSettings.Click += new System.EventHandler(this.cmdRotationSettings_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadRotationToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::PixelMagic.GUI.Properties.Resources.Project_16x16;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadRotationToolStripMenuItem
            // 
            this.loadRotationToolStripMenuItem.Name = "loadRotationToolStripMenuItem";
            this.loadRotationToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.loadRotationToolStripMenuItem.Text = "Load Rotation...";
            this.loadRotationToolStripMenuItem.Click += new System.EventHandler(this.loadRotationToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotkeysToolStripMenuItem,
            this.spellbookToolStripMenuItem,
            this.reloadAddonToolStripMenuItem});
            this.setupToolStripMenuItem.Image = global::PixelMagic.GUI.Properties.Resources.PageSetup_16x16;
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // hotkeysToolStripMenuItem
            // 
            this.hotkeysToolStripMenuItem.Name = "hotkeysToolStripMenuItem";
            this.hotkeysToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.hotkeysToolStripMenuItem.Text = "Hotkeys";
            this.hotkeysToolStripMenuItem.Click += new System.EventHandler(this.hotkeysToolStripMenuItem_Click);
            // 
            // spellbookToolStripMenuItem
            // 
            this.spellbookToolStripMenuItem.Enabled = false;
            this.spellbookToolStripMenuItem.Name = "spellbookToolStripMenuItem";
            this.spellbookToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.spellbookToolStripMenuItem.Text = "Spellbook";
            this.spellbookToolStripMenuItem.Click += new System.EventHandler(this.spellbookToolStripMenuItem_Click);
            // 
            // reloadAddonToolStripMenuItem
            // 
            this.reloadAddonToolStripMenuItem.Name = "reloadAddonToolStripMenuItem";
            this.reloadAddonToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.reloadAddonToolStripMenuItem.Text = "Reload Addon";
            this.reloadAddonToolStripMenuItem.Click += new System.EventHandler(this.reloadAddonToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptCombatRoutineToolStripMenuItem,
            this.imageToByteArrayToolStripMenuItem});
            this.toolsToolStripMenuItem.Image = global::PixelMagic.GUI.Properties.Resources.Version_16x16;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // encryptCombatRoutineToolStripMenuItem
            // 
            this.encryptCombatRoutineToolStripMenuItem.Name = "encryptCombatRoutineToolStripMenuItem";
            this.encryptCombatRoutineToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.encryptCombatRoutineToolStripMenuItem.Text = "Encrypt Combat Routine";
            this.encryptCombatRoutineToolStripMenuItem.Click += new System.EventHandler(this.encryptCombatRoutineToolStripMenuItem_Click);
            // 
            // imageToByteArrayToolStripMenuItem
            // 
            this.imageToByteArrayToolStripMenuItem.Name = "imageToByteArrayToolStripMenuItem";
            this.imageToByteArrayToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.imageToByteArrayToolStripMenuItem.Text = "Image to byte array";
            this.imageToByteArrayToolStripMenuItem.Click += new System.EventHandler(this.imageToByteArrayToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem,
            this.submitTicketToolStripMenuItem});
            this.helpToolStripMenuItem.Image = global::PixelMagic.GUI.Properties.Resources.help;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for updates...";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // submitTicketToolStripMenuItem
            // 
            this.submitTicketToolStripMenuItem.Enabled = false;
            this.submitTicketToolStripMenuItem.Name = "submitTicketToolStripMenuItem";
            this.submitTicketToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.submitTicketToolStripMenuItem.Text = "Submit Ticket";
            this.submitTicketToolStripMenuItem.Click += new System.EventHandler(this.submitTicketToolStripMenuItem_Click);
            // 
            // transparentLabel3
            // 
            this.transparentLabel3.ForeColor = System.Drawing.Color.White;
            this.transparentLabel3.Location = new System.Drawing.Point(871, 172);
            this.transparentLabel3.Name = "transparentLabel3";
            this.transparentLabel3.Size = new System.Drawing.Size(69, 15);
            this.transparentLabel3.TabIndex = 32;
            this.transparentLabel3.TabStop = false;
            this.transparentLabel3.Text = "Target Health";
            this.transparentLabel3.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // prgTargetHealth
            // 
            this.prgTargetHealth.BackColor = System.Drawing.Color.White;
            this.prgTargetHealth.BarColor = System.Drawing.Color.Salmon;
            this.prgTargetHealth.BorderColor = System.Drawing.Color.Green;
            this.prgTargetHealth.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.prgTargetHealth.ForeColor = System.Drawing.Color.White;
            this.prgTargetHealth.Location = new System.Drawing.Point(841, 169);
            this.prgTargetHealth.Maximum = 100;
            this.prgTargetHealth.Minimum = 0;
            this.prgTargetHealth.Name = "prgTargetHealth";
            this.prgTargetHealth.Size = new System.Drawing.Size(142, 20);
            this.prgTargetHealth.Step = 10;
            this.prgTargetHealth.TabIndex = 42;
            this.prgTargetHealth.Value = 70;
            // 
            // transparentLabel12
            // 
            this.transparentLabel12.ForeColor = System.Drawing.Color.White;
            this.transparentLabel12.Location = new System.Drawing.Point(878, 145);
            this.transparentLabel12.Name = "transparentLabel12";
            this.transparentLabel12.Size = new System.Drawing.Size(54, 15);
            this.transparentLabel12.TabIndex = 41;
            this.transparentLabel12.TabStop = false;
            this.transparentLabel12.Text = "My Power";
            this.transparentLabel12.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel11
            // 
            this.transparentLabel11.ForeColor = System.Drawing.Color.White;
            this.transparentLabel11.Location = new System.Drawing.Point(878, 118);
            this.transparentLabel11.Name = "transparentLabel11";
            this.transparentLabel11.Size = new System.Drawing.Size(54, 15);
            this.transparentLabel11.TabIndex = 40;
            this.transparentLabel11.TabStop = false;
            this.transparentLabel11.Text = "My Health";
            this.transparentLabel11.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel10
            // 
            this.transparentLabel10.ForeColor = System.Drawing.Color.Black;
            this.transparentLabel10.Location = new System.Drawing.Point(841, 325);
            this.transparentLabel10.Name = "transparentLabel10";
            this.transparentLabel10.Size = new System.Drawing.Size(85, 15);
            this.transparentLabel10.TabIndex = 39;
            this.transparentLabel10.TabStop = false;
            this.transparentLabel10.Text = "Disable Overlay";
            this.transparentLabel10.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel9
            // 
            this.transparentLabel9.ForeColor = System.Drawing.Color.Black;
            this.transparentLabel9.Location = new System.Drawing.Point(841, 304);
            this.transparentLabel9.Name = "transparentLabel9";
            this.transparentLabel9.Size = new System.Drawing.Size(93, 15);
            this.transparentLabel9.TabIndex = 38;
            this.transparentLabel9.TabStop = false;
            this.transparentLabel9.Text = "Play Error Sounds";
            this.transparentLabel9.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel7
            // 
            this.transparentLabel7.ForeColor = System.Drawing.Color.Black;
            this.transparentLabel7.Location = new System.Drawing.Point(841, 252);
            this.transparentLabel7.Name = "transparentLabel7";
            this.transparentLabel7.Size = new System.Drawing.Size(59, 15);
            this.transparentLabel7.TabIndex = 37;
            this.transparentLabel7.TabStop = false;
            this.transparentLabel7.Text = "Click (x,y)";
            this.transparentLabel7.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel8
            // 
            this.transparentLabel8.ForeColor = System.Drawing.Color.Black;
            this.transparentLabel8.Location = new System.Drawing.Point(841, 225);
            this.transparentLabel8.Name = "transparentLabel8";
            this.transparentLabel8.Size = new System.Drawing.Size(59, 15);
            this.transparentLabel8.TabIndex = 36;
            this.transparentLabel8.TabStop = false;
            this.transparentLabel8.Text = "Mouse (x,y)";
            this.transparentLabel8.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel6
            // 
            this.transparentLabel6.ForeColor = System.Drawing.Color.Black;
            this.transparentLabel6.Location = new System.Drawing.Point(841, 280);
            this.transparentLabel6.Name = "transparentLabel6";
            this.transparentLabel6.Size = new System.Drawing.Size(58, 15);
            this.transparentLabel6.TabIndex = 35;
            this.transparentLabel6.TabStop = false;
            this.transparentLabel6.Text = "Pulse (ms)";
            this.transparentLabel6.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // transparentLabel5
            // 
            this.transparentLabel5.ForeColor = System.Drawing.Color.Black;
            this.transparentLabel5.Location = new System.Drawing.Point(841, 198);
            this.transparentLabel5.Name = "transparentLabel5";
            this.transparentLabel5.Size = new System.Drawing.Size(85, 15);
            this.transparentLabel5.TabIndex = 34;
            this.transparentLabel5.TabStop = false;
            this.transparentLabel5.Text = "Target Casting";
            this.transparentLabel5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            // 
            // prgPower
            // 
            this.prgPower.BackColor = System.Drawing.Color.White;
            this.prgPower.BarColor = System.Drawing.Color.PaleTurquoise;
            this.prgPower.BorderColor = System.Drawing.Color.Green;
            this.prgPower.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.prgPower.ForeColor = System.Drawing.Color.White;
            this.prgPower.Location = new System.Drawing.Point(841, 142);
            this.prgPower.Maximum = 100;
            this.prgPower.Minimum = 0;
            this.prgPower.Name = "prgPower";
            this.prgPower.Size = new System.Drawing.Size(142, 20);
            this.prgPower.Step = 10;
            this.prgPower.TabIndex = 25;
            this.prgPower.Value = 70;
            // 
            // prgPlayerHealth
            // 
            this.prgPlayerHealth.BackColor = System.Drawing.Color.White;
            this.prgPlayerHealth.BarColor = System.Drawing.Color.Salmon;
            this.prgPlayerHealth.BorderColor = System.Drawing.Color.Green;
            this.prgPlayerHealth.FillStyle = ColorProgressBar.ColorProgressBar.FillStyles.Solid;
            this.prgPlayerHealth.ForeColor = System.Drawing.Color.White;
            this.prgPlayerHealth.Location = new System.Drawing.Point(841, 115);
            this.prgPlayerHealth.Maximum = 100;
            this.prgPlayerHealth.Minimum = 0;
            this.prgPlayerHealth.Name = "prgPlayerHealth";
            this.prgPlayerHealth.Size = new System.Drawing.Size(142, 20);
            this.prgPlayerHealth.Step = 10;
            this.prgPlayerHealth.TabIndex = 24;
            this.prgPlayerHealth.Value = 70;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(996, 561);
            this.Controls.Add(this.txtTargetCasting);
            this.Controls.Add(this.transparentLabel3);
            this.Controls.Add(this.prgTargetHealth);
            this.Controls.Add(this.transparentLabel12);
            this.Controls.Add(this.transparentLabel11);
            this.Controls.Add(this.transparentLabel10);
            this.Controls.Add(this.transparentLabel9);
            this.Controls.Add(this.transparentLabel7);
            this.Controls.Add(this.transparentLabel8);
            this.Controls.Add(this.nudPulse);
            this.Controls.Add(this.transparentLabel6);
            this.Controls.Add(this.cmdRotationSettings);
            this.Controls.Add(this.chkDisableOverlay);
            this.Controls.Add(this.transparentLabel5);
            this.Controls.Add(this.chkPlayErrorSounds);
            this.Controls.Add(this.txtMouseXYClick);
            this.Controls.Add(this.txtMouseXY);
            this.Controls.Add(this.prgPower);
            this.Controls.Add(this.prgPlayerHealth);
            this.Controls.Add(this.cmdStartBot);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cmdDonate);
            this.Controls.Add(this.rtbLog);
            this.Controls.Add(this.lblHotkeyInfo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPulse)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdStartBot;
        private System.Windows.Forms.Label lblHotkeyInfo;
        public System.Windows.Forms.TextBox txtTargetCasting;
        private System.Windows.Forms.Button cmdDonate;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadRotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptCombatRoutineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hotkeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spellbookToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMouseXY;
        public System.Windows.Forms.CheckBox chkPlayErrorSounds;
        public System.Windows.Forms.CheckBox chkDisableOverlay;
        private System.Windows.Forms.TextBox txtMouseXYClick;
        private System.Windows.Forms.NumericUpDown nudPulse;
        private System.Windows.Forms.ToolStripMenuItem reloadAddonToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripMenuItem submitTicketToolStripMenuItem;
        internal System.Windows.Forms.RichTextBox rtbLog;
        public ColorProgressBar.ColorProgressBar prgPlayerHealth;
        public ColorProgressBar.ColorProgressBar prgPower;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button cmdRotationSettings;
        private GUI.TransparentLabel transparentLabel3;
        private GUI.TransparentLabel transparentLabel5;
        private GUI.TransparentLabel transparentLabel6;
        private GUI.TransparentLabel transparentLabel7;
        private GUI.TransparentLabel transparentLabel8;
        private GUI.TransparentLabel transparentLabel9;
        private GUI.TransparentLabel transparentLabel10;
        private GUI.TransparentLabel transparentLabel11;
        private GUI.TransparentLabel transparentLabel12;
        public ColorProgressBar.ColorProgressBar prgTargetHealth;
        private System.Windows.Forms.ToolStripMenuItem imageToByteArrayToolStripMenuItem;
    }
}

