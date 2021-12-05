
namespace Game_of_Life
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hudStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toroidalStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finiteStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pauseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seedStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentSeedStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cellColorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gridColorX10StripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.reloadStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNewButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripOpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripStartButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripPauseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripNextButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.graphicsPanel1 = new Game_of_Life.GraphicsPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cellColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.runToolStripMenuItem,
            this.randomizeToolStripMenuItem,
            this.settingsStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(817, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.importStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.Empty);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openFileDialog1_FileOk);
            // 
            // importStripMenuItem
            // 
            this.importStripMenuItem.Name = "importStripMenuItem";
            this.importStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importStripMenuItem.Text = "Import";
            this.importStripMenuItem.Click += new System.EventHandler(this.importFileDialog1_FileOk);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(221, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveFileDialog1_FileOk);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenu_ItemClicked);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hudStripMenuItem,
            this.countStripMenuItem,
            this.gridStripMenuItem,
            this.toolStripSeparator3,
            this.toroidalStripMenuItem,
            this.finiteStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // hudStripMenuItem
            // 
            this.hudStripMenuItem.Checked = true;
            this.hudStripMenuItem.CheckOnClick = true;
            this.hudStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.hudStripMenuItem.Name = "hudStripMenuItem";
            this.hudStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.hudStripMenuItem.Text = "HUD";
            this.hudStripMenuItem.Click += new System.EventHandler(this.ToggleHUD);
            // 
            // countStripMenuItem
            // 
            this.countStripMenuItem.Checked = true;
            this.countStripMenuItem.CheckOnClick = true;
            this.countStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.countStripMenuItem.Name = "countStripMenuItem";
            this.countStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.countStripMenuItem.Text = "Neighbor Count";
            this.countStripMenuItem.Click += new System.EventHandler(this.ShowDisplayCount);
            // 
            // gridStripMenuItem
            // 
            this.gridStripMenuItem.Checked = true;
            this.gridStripMenuItem.CheckOnClick = true;
            this.gridStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.gridStripMenuItem.Name = "gridStripMenuItem";
            this.gridStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.gridStripMenuItem.Text = "Grid";
            this.gridStripMenuItem.Click += new System.EventHandler(this.ToggleGrid);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(195, 6);
            // 
            // toroidalStripMenuItem
            // 
            this.toroidalStripMenuItem.Checked = true;
            this.toroidalStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toroidalStripMenuItem.Name = "toroidalStripMenuItem";
            this.toroidalStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.toroidalStripMenuItem.Text = "Toroidal";
            this.toroidalStripMenuItem.Click += new System.EventHandler(this.toroidalClick);
            // 
            // finiteStripMenuItem
            // 
            this.finiteStripMenuItem.Name = "finiteStripMenuItem";
            this.finiteStripMenuItem.Size = new System.Drawing.Size(198, 26);
            this.finiteStripMenuItem.Text = "Finite";
            this.finiteStripMenuItem.Click += new System.EventHandler(this.finiteClick);
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startStripMenuItem,
            this.pauseStripMenuItem,
            this.nextStripMenuItem,
            this.toStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // startStripMenuItem
            // 
            this.startStripMenuItem.Name = "startStripMenuItem";
            this.startStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.startStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.startStripMenuItem.Text = "Start";
            this.startStripMenuItem.Click += new System.EventHandler(this.startStripMenu_ItemClicked);
            // 
            // pauseStripMenuItem
            // 
            this.pauseStripMenuItem.Enabled = false;
            this.pauseStripMenuItem.Name = "pauseStripMenuItem";
            this.pauseStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.pauseStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pauseStripMenuItem.Text = "Pause";
            this.pauseStripMenuItem.Click += new System.EventHandler(this.pauseStripMenu_ItemClicked);
            // 
            // nextStripMenuItem
            // 
            this.nextStripMenuItem.Name = "nextStripMenuItem";
            this.nextStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.nextStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.nextStripMenuItem.Text = "Next";
            this.nextStripMenuItem.Click += new System.EventHandler(this.nextStripMenu_ItemClicked);
            // 
            // toStripMenuItem
            // 
            this.toStripMenuItem.Name = "toStripMenuItem";
            this.toStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.toStripMenuItem.Text = "To";
            this.toStripMenuItem.Click += new System.EventHandler(this.toStripMenu_ItemClicked);
            // 
            // randomizeToolStripMenuItem
            // 
            this.randomizeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.randomizeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seedStripMenuItem,
            this.currentSeedStripMenuItem,
            this.timeStripMenuItem});
            this.randomizeToolStripMenuItem.Name = "randomizeToolStripMenuItem";
            this.randomizeToolStripMenuItem.Size = new System.Drawing.Size(98, 24);
            this.randomizeToolStripMenuItem.Text = "Randomize";
            // 
            // seedStripMenuItem
            // 
            this.seedStripMenuItem.Name = "seedStripMenuItem";
            this.seedStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.seedStripMenuItem.Text = "From Seed";
            this.seedStripMenuItem.Click += new System.EventHandler(this.seedStripMenu_ItemClicked);
            // 
            // currentSeedStripMenuItem
            // 
            this.currentSeedStripMenuItem.Name = "currentSeedStripMenuItem";
            this.currentSeedStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.currentSeedStripMenuItem.Text = "From Current Seed";
            this.currentSeedStripMenuItem.Click += new System.EventHandler(this.currentSeedStripMenu_ItemClicked);
            // 
            // timeStripMenuItem
            // 
            this.timeStripMenuItem.Name = "timeStripMenuItem";
            this.timeStripMenuItem.Size = new System.Drawing.Size(215, 26);
            this.timeStripMenuItem.Text = "From Time";
            this.timeStripMenuItem.Click += new System.EventHandler(this.timeStripMenu_ItemClicked);
            // 
            // settingsStripMenuItem1
            // 
            this.settingsStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.settingsStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backColorStripMenuItem,
            this.cellColorStripMenuItem,
            this.gridColorStripMenuItem,
            this.gridColorX10StripMenuItem,
            this.toolStripSeparator2,
            this.optionsStripMenuItem,
            this.toolStripSeparator4,
            this.reloadStripMenuItem,
            this.resetStripMenuItem});
            this.settingsStripMenuItem1.Name = "settingsStripMenuItem1";
            this.settingsStripMenuItem1.Size = new System.Drawing.Size(76, 24);
            this.settingsStripMenuItem1.Text = "Settings";
            // 
            // backColorStripMenuItem
            // 
            this.backColorStripMenuItem.Name = "backColorStripMenuItem";
            this.backColorStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.backColorStripMenuItem.Text = "Back Color";
            this.backColorStripMenuItem.Click += new System.EventHandler(this.backColorDialogue);
            // 
            // cellColorStripMenuItem
            // 
            this.cellColorStripMenuItem.Name = "cellColorStripMenuItem";
            this.cellColorStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.cellColorStripMenuItem.Text = "Cell Color";
            this.cellColorStripMenuItem.Click += new System.EventHandler(this.cellColorDialogue);
            // 
            // gridColorStripMenuItem
            // 
            this.gridColorStripMenuItem.Name = "gridColorStripMenuItem";
            this.gridColorStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.gridColorStripMenuItem.Text = "Grid Color";
            this.gridColorStripMenuItem.Click += new System.EventHandler(this.gridColorDialogue);
            // 
            // gridColorX10StripMenuItem
            // 
            this.gridColorX10StripMenuItem.Name = "gridColorX10StripMenuItem";
            this.gridColorX10StripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.gridColorX10StripMenuItem.Text = "Grid Color x10";
            this.gridColorX10StripMenuItem.Click += new System.EventHandler(this.gridX10ColorDialogue);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(184, 6);
            // 
            // optionsStripMenuItem
            // 
            this.optionsStripMenuItem.Name = "optionsStripMenuItem";
            this.optionsStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.optionsStripMenuItem.Text = "Options";
            this.optionsStripMenuItem.Click += new System.EventHandler(this.optionsDialogue);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(184, 6);
            // 
            // reloadStripMenuItem
            // 
            this.reloadStripMenuItem.Name = "reloadStripMenuItem";
            this.reloadStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.reloadStripMenuItem.Text = "Reload";
            this.reloadStripMenuItem.Click += new System.EventHandler(this.LoadSettings);
            // 
            // resetStripMenuItem
            // 
            this.resetStripMenuItem.Name = "resetStripMenuItem";
            this.resetStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.resetStripMenuItem.Text = "Reset";
            this.resetStripMenuItem.Click += new System.EventHandler(this.ResetClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Menu;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNewButton,
            this.toolStripOpenButton,
            this.toolStripSaveButton,
            this.toolStripSeparator6,
            this.toolStripStartButton,
            this.toolStripPauseButton,
            this.toolStripNextButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(817, 27);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNewButton
            // 
            this.toolStripNewButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripNewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewButton.Name = "toolStripNewButton";
            this.toolStripNewButton.Size = new System.Drawing.Size(43, 24);
            this.toolStripNewButton.Text = "New";
            this.toolStripNewButton.Click += new System.EventHandler(this.Empty);
            // 
            // toolStripOpenButton
            // 
            this.toolStripOpenButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripOpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripOpenButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpenButton.Image")));
            this.toolStripOpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripOpenButton.Name = "toolStripOpenButton";
            this.toolStripOpenButton.Size = new System.Drawing.Size(49, 24);
            this.toolStripOpenButton.Text = "Open";
            this.toolStripOpenButton.Click += new System.EventHandler(this.openFileDialog1_FileOk);
            // 
            // toolStripSaveButton
            // 
            this.toolStripSaveButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripSaveButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSaveButton.Image")));
            this.toolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveButton.Name = "toolStripSaveButton";
            this.toolStripSaveButton.Size = new System.Drawing.Size(44, 24);
            this.toolStripSaveButton.Text = "Save";
            this.toolStripSaveButton.Click += new System.EventHandler(this.saveFileDialog1_FileOk);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripStartButton
            // 
            this.toolStripStartButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripStartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStartButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripStartButton.Image")));
            this.toolStripStartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripStartButton.Name = "toolStripStartButton";
            this.toolStripStartButton.Size = new System.Drawing.Size(44, 24);
            this.toolStripStartButton.Text = "Start";
            this.toolStripStartButton.Click += new System.EventHandler(this.startStripMenu_ItemClicked);
            // 
            // toolStripPauseButton
            // 
            this.toolStripPauseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripPauseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripPauseButton.Enabled = false;
            this.toolStripPauseButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPauseButton.Image")));
            this.toolStripPauseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPauseButton.Name = "toolStripPauseButton";
            this.toolStripPauseButton.Size = new System.Drawing.Size(50, 24);
            this.toolStripPauseButton.Text = "Pause";
            this.toolStripPauseButton.Click += new System.EventHandler(this.pauseStripMenu_ItemClicked);
            // 
            // toolStripNextButton
            // 
            this.toolStripNextButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripNextButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNextButton.Image")));
            this.toolStripNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNextButton.Name = "toolStripNextButton";
            this.toolStripNextButton.Size = new System.Drawing.Size(44, 24);
            this.toolStripNextButton.Text = "Next";
            this.toolStripNextButton.Click += new System.EventHandler(this.nextStripMenu_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(7, 861);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(739, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 16);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 660);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Generations: 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 690);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Alive Cells: 0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 720);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 750);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "label4";
            // 
            // graphicsPanel1
            // 
            this.graphicsPanel1.ContextMenuStrip = this.contextMenuStrip1;
            this.graphicsPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphicsPanel1.Location = new System.Drawing.Point(0, 55);
            this.graphicsPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.graphicsPanel1.Name = "graphicsPanel1";
            this.graphicsPanel1.Size = new System.Drawing.Size(817, 829);
            this.graphicsPanel1.TabIndex = 16;
            this.graphicsPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.graphicsPanel1_Paint);
            this.graphicsPanel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.graphicsPanel1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cellColorToolStripMenuItem,
            this.backColorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 80);
            // 
            // cellColorToolStripMenuItem
            // 
            this.cellColorToolStripMenuItem.Name = "cellColorToolStripMenuItem";
            this.cellColorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cellColorToolStripMenuItem.Text = "Cell Color";
            this.cellColorToolStripMenuItem.Click += new System.EventHandler(this.cellColorToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.backColorToolStripMenuItem.Text = "Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 884);
            this.Controls.Add(this.graphicsPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Game of Life";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNewButton;
        private System.Windows.Forms.ToolStripButton toolStripOpenButton;
        private System.Windows.Forms.ToolStripButton toolStripSaveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripStartButton;
        private System.Windows.Forms.ToolStripButton toolStripPauseButton;
        private System.Windows.Forms.ToolStripButton toolStripNextButton;
        private System.Windows.Forms.ToolStripMenuItem seedStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentSeedStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hudStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toroidalStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finiteStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pauseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cellColorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gridColorX10StripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem optionsStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem reloadStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private GraphicsPanel graphicsPanel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cellColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
    }
}

