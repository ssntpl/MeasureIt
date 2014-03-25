
using System.Threading;
using System.Collections;
namespace mit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProjecttoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separatorToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAstoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.separator2ToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPriviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setscaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.areaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeasureITOnScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Open_tool = new System.Windows.Forms.ToolStripButton();
            this.Save_tool = new System.Windows.Forms.ToolStripButton();
            this.AddImage_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SetScale_tool = new System.Windows.Forms.ToolStripButton();
            this.ZoomIn_tool = new System.Windows.Forms.ToolStripButton();
            this.Normal_tool = new System.Windows.Forms.ToolStripButton();
            this.Zoomout_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.position_StatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus_scale = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.Line_tool = new System.Windows.Forms.ToolStripButton();
            this.Area_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.OK_tool = new System.Windows.Forms.ToolStripButton();
            this.Cancel_tool = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.LineStyle_tool = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.projectToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(660, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProjectToolStripMenuItem,
            this.openProjectToolStripMenuItem,
            this.closeProjecttoolStripMenuItem,
            this.separatorToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAstoolStripMenuItem,
            this.addImageToolStripMenuItem,
            this.separator2ToolStripMenuItem,
            this.printToolStripMenuItem,
            this.printPriviewToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newProjectToolStripMenuItem
            // 
            this.newProjectToolStripMenuItem.Image = global::mit.Properties.Resources.New_24x24;
            this.newProjectToolStripMenuItem.Name = "newProjectToolStripMenuItem";
            this.newProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.N)));
            this.newProjectToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.newProjectToolStripMenuItem.Text = "&New Project...";
            this.newProjectToolStripMenuItem.Click += new System.EventHandler(this.newProjectToolStripMenuItem_Click);
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Image = global::mit.Properties.Resources.Open_24x24;
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift)
                        | System.Windows.Forms.Keys.O)));
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.openProjectToolStripMenuItem.Text = "&Open Project...";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // closeProjecttoolStripMenuItem
            // 
            this.closeProjecttoolStripMenuItem.Name = "closeProjecttoolStripMenuItem";
            this.closeProjecttoolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.closeProjecttoolStripMenuItem.Text = "Close Project";
            this.closeProjecttoolStripMenuItem.Click += new System.EventHandler(this.closeProjecttoolStripMenuItem_Click);
            // 
            // separatorToolStripMenuItem
            // 
            this.separatorToolStripMenuItem.Name = "separatorToolStripMenuItem";
            this.separatorToolStripMenuItem.Size = new System.Drawing.Size(224, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::mit.Properties.Resources.Save_24x24;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAstoolStripMenuItem
            // 
            this.saveAstoolStripMenuItem.Name = "saveAstoolStripMenuItem";
            this.saveAstoolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.saveAstoolStripMenuItem.Text = "Save As...";
            // 
            // addImageToolStripMenuItem
            // 
            this.addImageToolStripMenuItem.Name = "addImageToolStripMenuItem";
            this.addImageToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.addImageToolStripMenuItem.Text = "Add Image...";
            // 
            // separator2ToolStripMenuItem
            // 
            this.separator2ToolStripMenuItem.Name = "separator2ToolStripMenuItem";
            this.separator2ToolStripMenuItem.Size = new System.Drawing.Size(224, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.printToolStripMenuItem.Text = "&Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // printPriviewToolStripMenuItem
            // 
            this.printPriviewToolStripMenuItem.Image = global::mit.Properties.Resources.Preview_24x24;
            this.printPriviewToolStripMenuItem.Name = "printPriviewToolStripMenuItem";
            this.printPriviewToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.printPriviewToolStripMenuItem.Text = "Print Pre&view";
            this.printPriviewToolStripMenuItem.Click += new System.EventHandler(this.printPriviewToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // projectToolStripMenuItem
            // 
            this.projectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setscaleToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.areaToolStripMenuItem,
            this.generateSummaryToolStripMenuItem});
            this.projectToolStripMenuItem.Name = "projectToolStripMenuItem";
            this.projectToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.projectToolStripMenuItem.Text = "&Project";
            // 
            // setscaleToolStripMenuItem
            // 
            this.setscaleToolStripMenuItem.Name = "setscaleToolStripMenuItem";
            this.setscaleToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.setscaleToolStripMenuItem.Text = "Set Scale";
            this.setscaleToolStripMenuItem.Click += new System.EventHandler(this.SetScale_tool_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.lineToolStripMenuItem.Text = "Line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.Line_tool_Click);
            // 
            // areaToolStripMenuItem
            // 
            this.areaToolStripMenuItem.Name = "areaToolStripMenuItem";
            this.areaToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.areaToolStripMenuItem.Text = "Area";
            this.areaToolStripMenuItem.Click += new System.EventHandler(this.Area_tool_Click);
            // 
            // generateSummaryToolStripMenuItem
            // 
            this.generateSummaryToolStripMenuItem.Name = "generateSummaryToolStripMenuItem";
            this.generateSummaryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.generateSummaryToolStripMenuItem.Text = "Generate Summary";
            this.generateSummaryToolStripMenuItem.Click += new System.EventHandler(this.generateSummaryToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeasureITOnScreenToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutMeasureITOnScreenToolStripMenuItem
            // 
            this.aboutMeasureITOnScreenToolStripMenuItem.Name = "aboutMeasureITOnScreenToolStripMenuItem";
            this.aboutMeasureITOnScreenToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.aboutMeasureITOnScreenToolStripMenuItem.Text = "About MeasureIT onScreen";
            this.aboutMeasureITOnScreenToolStripMenuItem.Click += new System.EventHandler(this.aboutMeasureITOnScreenToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open_tool,
            this.Save_tool,
            this.AddImage_tool,
            this.toolStripSeparator2,
            this.SetScale_tool,
            this.ZoomIn_tool,
            this.Normal_tool,
            this.Zoomout_tool,
            this.toolStripSeparator3});
            this.toolStrip1.Location = new System.Drawing.Point(3, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(353, 25);
            this.toolStrip1.TabIndex = 0;
            // 
            // Open_tool
            // 
            this.Open_tool.Image = ((System.Drawing.Image)(resources.GetObject("Open_tool.Image")));
            this.Open_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open_tool.Name = "Open_tool";
            this.Open_tool.Size = new System.Drawing.Size(54, 22);
            this.Open_tool.Text = "open";
            this.Open_tool.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // Save_tool
            // 
            this.Save_tool.Image = ((System.Drawing.Image)(resources.GetObject("Save_tool.Image")));
            this.Save_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Save_tool.Name = "Save_tool";
            this.Save_tool.Size = new System.Drawing.Size(51, 22);
            this.Save_tool.Text = "Save";
            this.Save_tool.Click += new System.EventHandler(this.Save_tool_Click);
            // 
            // AddImage_tool
            // 
            this.AddImage_tool.Image = ((System.Drawing.Image)(resources.GetObject("AddImage_tool.Image")));
            this.AddImage_tool.ImageTransparentColor = System.Drawing.Color.White;
            this.AddImage_tool.Name = "AddImage_tool";
            this.AddImage_tool.Size = new System.Drawing.Size(85, 22);
            this.AddImage_tool.Text = "Add Image";
            this.AddImage_tool.Click += new System.EventHandler(this.AddImage_tool_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SetScale_tool
            // 
            this.SetScale_tool.Image = ((System.Drawing.Image)(resources.GetObject("SetScale_tool.Image")));
            this.SetScale_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SetScale_tool.Name = "SetScale_tool";
            this.SetScale_tool.Size = new System.Drawing.Size(70, 22);
            this.SetScale_tool.Text = "SetScale";
            this.SetScale_tool.Click += new System.EventHandler(this.SetScale_tool_Click);
            // 
            // ZoomIn_tool
            // 
            this.ZoomIn_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ZoomIn_tool.Image = ((System.Drawing.Image)(resources.GetObject("ZoomIn_tool.Image")));
            this.ZoomIn_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ZoomIn_tool.Name = "ZoomIn_tool";
            this.ZoomIn_tool.Size = new System.Drawing.Size(23, 22);
            this.ZoomIn_tool.Text = "ZoomIn";
            this.ZoomIn_tool.Click += new System.EventHandler(this.ZoomIn_tool_Click);
            // 
            // Normal_tool
            // 
            this.Normal_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Normal_tool.Image = ((System.Drawing.Image)(resources.GetObject("Normal_tool.Image")));
            this.Normal_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Normal_tool.Name = "Normal_tool";
            this.Normal_tool.Size = new System.Drawing.Size(23, 22);
            this.Normal_tool.Text = "Normal";
            this.Normal_tool.Click += new System.EventHandler(this.Normal_tool_Click);
            // 
            // Zoomout_tool
            // 
            this.Zoomout_tool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Zoomout_tool.Image = ((System.Drawing.Image)(resources.GetObject("Zoomout_tool.Image")));
            this.Zoomout_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Zoomout_tool.Name = "Zoomout_tool";
            this.Zoomout_tool.Size = new System.Drawing.Size(23, 22);
            this.Zoomout_tool.Text = "ZoomOut";
            this.Zoomout_tool.Click += new System.EventHandler(this.Zoomout_tool_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.AutoScroll = true;
            this.ContentPanel.Size = new System.Drawing.Size(660, 496);
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.AutoScroll = true;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitContainer1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.splitter1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.statusStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(660, 422);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(660, 496);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip2);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(657, 400);
            this.splitContainer1.SplitterDistance = 156;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.treeView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 398);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(150, 394);
            this.treeView1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(495, 398);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 400);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.position_StatusStrip,
            this.toolStripStatus_scale});
            this.statusStrip1.Location = new System.Drawing.Point(0, 400);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(660, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // position_StatusStrip
            // 
            this.position_StatusStrip.Name = "position_StatusStrip";
            this.position_StatusStrip.Size = new System.Drawing.Size(50, 17);
            this.position_StatusStrip.Text = "position";
            // 
            // toolStripStatus_scale
            // 
            this.toolStripStatus_scale.Name = "toolStripStatus_scale";
            this.toolStripStatus_scale.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatus_scale.Text = "Scale not set";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Line_tool,
            this.Area_tool,
            this.toolStripSeparator5,
            this.OK_tool,
            this.Cancel_tool,
            this.toolStripSeparator4,
            this.LineStyle_tool});
            this.toolStrip2.Location = new System.Drawing.Point(3, 49);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(304, 25);
            this.toolStrip2.TabIndex = 1;
            // 
            // Line_tool
            // 
            this.Line_tool.Image = ((System.Drawing.Image)(resources.GetObject("Line_tool.Image")));
            this.Line_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Line_tool.Name = "Line_tool";
            this.Line_tool.Size = new System.Drawing.Size(49, 22);
            this.Line_tool.Text = "Line";
            this.Line_tool.Click += new System.EventHandler(this.Line_tool_Click);
            // 
            // Area_tool
            // 
            this.Area_tool.Image = ((System.Drawing.Image)(resources.GetObject("Area_tool.Image")));
            this.Area_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Area_tool.Name = "Area_tool";
            this.Area_tool.Size = new System.Drawing.Size(51, 22);
            this.Area_tool.Text = "Area";
            this.Area_tool.Click += new System.EventHandler(this.Area_tool_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // OK_tool
            // 
            this.OK_tool.Image = ((System.Drawing.Image)(resources.GetObject("OK_tool.Image")));
            this.OK_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OK_tool.Name = "OK_tool";
            this.OK_tool.Size = new System.Drawing.Size(43, 22);
            this.OK_tool.Text = "OK";
            this.OK_tool.Click += new System.EventHandler(this.OK_tool_Click);
            // 
            // Cancel_tool
            // 
            this.Cancel_tool.Image = ((System.Drawing.Image)(resources.GetObject("Cancel_tool.Image")));
            this.Cancel_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Cancel_tool.Name = "Cancel_tool";
            this.Cancel_tool.Size = new System.Drawing.Size(63, 22);
            this.Cancel_tool.Text = "Cancel";
            this.Cancel_tool.Click += new System.EventHandler(this.Cancel_tool_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // LineStyle_tool
            // 
            this.LineStyle_tool.Image = ((System.Drawing.Image)(resources.GetObject("LineStyle_tool.Image")));
            this.LineStyle_tool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LineStyle_tool.Name = "LineStyle_tool";
            this.LineStyle_tool.Size = new System.Drawing.Size(74, 22);
            this.LineStyle_tool.Text = "LineStyle";
            this.LineStyle_tool.Click += new System.EventHandler(this.LineStyle_tool_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(660, 496);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MeasureIT On Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeProjecttoolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator separator2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPriviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Open_tool;
        private System.Windows.Forms.ToolStripButton Save_tool;
        private System.Windows.Forms.ToolStripButton AddImage_tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SetScale_tool;
        private System.Windows.Forms.ToolStripButton ZoomIn_tool;
        private System.Windows.Forms.ToolStripButton Normal_tool;
        private System.Windows.Forms.ToolStripButton Zoomout_tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton Line_tool;
        private System.Windows.Forms.ToolStripButton Area_tool;
        private System.Windows.Forms.ToolStripButton OK_tool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton LineStyle_tool;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton Cancel_tool;

       
        #region   //this region contains declaration of forms created.
        //LineDetails Form declaration
        LineDetails form_linedetails;
        AreaDetails form_areadetails;
        ScaleDetails form_scaledetails;
        CountDetails form_countdetails;
        LineStyleDetails form_linestyledetails;
        //Thread to detect if the caluclation thread is finished
        public Thread calculationfinish_Thread;
        //delegate to handle safe cross thread calla
        delegate void Invoker();//this is a delegate made for run function
        private float zoomfactor=1.0f;
        #endregion

        #region //this region contains declarations made by user
        System.Drawing.Pen currentpen;
        Line line_class;//object to store values of current line drawn
        Area area_class;//object to store values of current area drawn
        //LineCalculation_Thread line_thread;//responsible for interactive linedrawing
        LineCalculation_Thread scaleline_thread;//responsible for interactive linedrawing
        AreaCalculation_Thread multipointline_thread;//responsible for interactive linedrawing
        AreaCalculation_Thread area_thread;//responsible for interactive area drawing
        float scale_value;//this stores image scale value loaded in picture box
        public ArrayList vector_lines;//stores the lines drawn on form.
        public ArrayList vector_areas;//stores the area drawn on form.
        public System.Windows.Forms.TreeNode area_list;
        public System.Windows.Forms.TreeNode line_list;

        //public static Line scale_class;//this is an object which contains scale value
                                   //during load the values get filled in project class
        //ImagePropertiesClass currentImageLoaded;mking this static

        #endregion
        public  System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem saveAstoolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel position_StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus_scale;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem projectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeasureITOnScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setscaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem areaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateSummaryToolStripMenuItem;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;


    }
}

