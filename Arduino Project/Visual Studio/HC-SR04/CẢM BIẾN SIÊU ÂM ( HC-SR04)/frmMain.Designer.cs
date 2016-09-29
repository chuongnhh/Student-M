namespace CẢM_BIẾN_SIÊU_ÂM___HC_SR04_
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveGraph1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConnec1 = new System.Windows.Forms.ToolStripMenuItem();
            this.featureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCurveGraph1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLineGraph1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAbout1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblA = new System.Windows.Forms.ToolStripLabel();
            this.lblAr = new System.Windows.Forms.ToolStripLabel();
            this.lblDAr = new System.Windows.Forms.ToolStripLabel();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageLineGraph = new System.Windows.Forms.TabPage();
            this.tabPageCurveGraph = new System.Windows.Forms.TabPage();
            this.btnLineGraph2 = new System.Windows.Forms.ToolStripButton();
            this.btnCurveGraph2 = new System.Windows.Forms.ToolStripButton();
            this.btnSaveGraph2 = new System.Windows.Forms.ToolStripButton();
            this.btnConnect2 = new System.Windows.Forms.ToolStripButton();
            this.btnAbout2 = new System.Windows.Forms.ToolStripButton();
            this.lblConnection = new System.Windows.Forms.ToolStripLabel();
            this.btnMeasure = new System.Windows.Forms.ToolStripButton();
            this.btnReload = new System.Windows.Forms.ToolStripButton();
            this.lblNumberOfMeasurements = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.featureToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(577, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveGraph1,
            this.btnQuit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(33, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // btnSaveGraph1
            // 
            this.btnSaveGraph1.Name = "btnSaveGraph1";
            this.btnSaveGraph1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.btnSaveGraph1.Size = new System.Drawing.Size(139, 22);
            this.btnSaveGraph1.Text = "Save";
            // 
            // btnQuit
            // 
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.btnQuit.Size = new System.Drawing.Size(139, 22);
            this.btnQuit.Text = "Quit";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnConnec1});
            this.settingToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // btnConnec1
            // 
            this.btnConnec1.Name = "btnConnec1";
            this.btnConnec1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.btnConnec1.Size = new System.Drawing.Size(175, 22);
            this.btnConnec1.Text = "Connection";
            this.btnConnec1.Click += new System.EventHandler(this.btnConnec1_Click);
            // 
            // featureToolStripMenuItem
            // 
            this.featureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCurveGraph1,
            this.btnLineGraph1});
            this.featureToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.featureToolStripMenuItem.Name = "featureToolStripMenuItem";
            this.featureToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.featureToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.featureToolStripMenuItem.Text = "Feature";
            // 
            // btnCurveGraph1
            // 
            this.btnCurveGraph1.Name = "btnCurveGraph1";
            this.btnCurveGraph1.Size = new System.Drawing.Size(139, 22);
            this.btnCurveGraph1.Text = "Curve Graph";
            this.btnCurveGraph1.Click += new System.EventHandler(this.btnCurveGraph1_Click);
            // 
            // btnLineGraph1
            // 
            this.btnLineGraph1.Name = "btnLineGraph1";
            this.btnLineGraph1.Size = new System.Drawing.Size(139, 22);
            this.btnLineGraph1.Text = "Line graph";
            this.btnLineGraph1.Click += new System.EventHandler(this.btnLineGraph1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbout1});
            this.helpToolStripMenuItem.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // btnAbout1
            // 
            this.btnAbout1.Name = "btnAbout1";
            this.btnAbout1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.btnAbout1.Size = new System.Drawing.Size(151, 22);
            this.btnAbout1.Text = "About";
            this.btnAbout1.Click += new System.EventHandler(this.btnAbout1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblConnection,
            this.lblAr,
            this.lblDAr,
            this.lblA,
            this.toolStripSeparator1,
            this.btnMeasure,
            this.btnReload,
            this.toolStripSeparator3,
            this.lblNumberOfMeasurements});
            this.toolStrip1.Location = new System.Drawing.Point(0, 366);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(577, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblA
            // 
            this.lblA.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblA.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblA.Margin = new System.Windows.Forms.Padding(0, 1, 1, 2);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(114, 22);
            this.lblA.Text = "A = 00.00 ± 00.00 cm";
            // 
            // lblAr
            // 
            this.lblAr.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblAr.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblAr.Name = "lblAr";
            this.lblAr.Size = new System.Drawing.Size(77, 22);
            this.lblAr.Text = "A* = 00.00 cm";
            // 
            // lblDAr
            // 
            this.lblDAr.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblDAr.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblDAr.Name = "lblDAr";
            this.lblDAr.Size = new System.Drawing.Size(84, 22);
            this.lblDAr.Text = "ΔA* = 00.00 cm";
            // 
            // toolStrip2
            // 
            this.toolStrip2.AutoSize = false;
            this.toolStrip2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLineGraph2,
            this.btnCurveGraph2,
            this.btnSaveGraph2,
            this.btnConnect2,
            this.btnAbout2});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(577, 45);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(577, 297);
            this.panel1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageLineGraph);
            this.tabControl1.Controls.Add(this.tabPageCurveGraph);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(112, 18);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(577, 297);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 4;
            this.tabControl1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.tabControl1_DrawItem);
            this.tabControl1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tabControl1_MouseClick);
            // 
            // tabPageLineGraph
            // 
            this.tabPageLineGraph.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageLineGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageLineGraph.Name = "tabPageLineGraph";
            this.tabPageLineGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLineGraph.Size = new System.Drawing.Size(569, 271);
            this.tabPageLineGraph.TabIndex = 0;
            this.tabPageLineGraph.Text = "tabPage1";
            // 
            // tabPageCurveGraph
            // 
            this.tabPageCurveGraph.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageCurveGraph.Location = new System.Drawing.Point(4, 22);
            this.tabPageCurveGraph.Name = "tabPageCurveGraph";
            this.tabPageCurveGraph.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCurveGraph.Size = new System.Drawing.Size(523, 248);
            this.tabPageCurveGraph.TabIndex = 1;
            this.tabPageCurveGraph.Text = "tabPage2";
            // 
            // btnLineGraph2
            // 
            this.btnLineGraph2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLineGraph2.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.chart_line;
            this.btnLineGraph2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLineGraph2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLineGraph2.Margin = new System.Windows.Forms.Padding(5, 1, 0, 2);
            this.btnLineGraph2.Name = "btnLineGraph2";
            this.btnLineGraph2.Size = new System.Drawing.Size(36, 47);
            this.btnLineGraph2.Text = "Line Graph";
            this.btnLineGraph2.Click += new System.EventHandler(this.btnLineGraph2_Click);
            // 
            // btnCurveGraph2
            // 
            this.btnCurveGraph2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCurveGraph2.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.chart_curve;
            this.btnCurveGraph2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCurveGraph2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCurveGraph2.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.btnCurveGraph2.Name = "btnCurveGraph2";
            this.btnCurveGraph2.Size = new System.Drawing.Size(36, 47);
            this.btnCurveGraph2.Text = "Curve Graph";
            this.btnCurveGraph2.Click += new System.EventHandler(this.btnCurveGraph2_Click);
            // 
            // btnSaveGraph2
            // 
            this.btnSaveGraph2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSaveGraph2.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.disk;
            this.btnSaveGraph2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSaveGraph2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveGraph2.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.btnSaveGraph2.Name = "btnSaveGraph2";
            this.btnSaveGraph2.Size = new System.Drawing.Size(36, 47);
            this.btnSaveGraph2.Text = "Save Graph";
            this.btnSaveGraph2.Click += new System.EventHandler(this.btnSaveGraph2_Click);
            // 
            // btnConnect2
            // 
            this.btnConnect2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConnect2.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.serialPort;
            this.btnConnect2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnConnect2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect2.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.btnConnect2.Name = "btnConnect2";
            this.btnConnect2.Size = new System.Drawing.Size(36, 47);
            this.btnConnect2.Text = "Connect Serial Port";
            this.btnConnect2.Click += new System.EventHandler(this.btnConnect2_Click);
            // 
            // btnAbout2
            // 
            this.btnAbout2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAbout2.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.information;
            this.btnAbout2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAbout2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbout2.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.btnAbout2.Name = "btnAbout2";
            this.btnAbout2.Size = new System.Drawing.Size(36, 47);
            this.btnAbout2.Text = "Information";
            this.btnAbout2.Click += new System.EventHandler(this.btnAbout2_Click);
            // 
            // lblConnection
            // 
            this.lblConnection.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblConnection.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.port;
            this.lblConnection.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.lblConnection.Name = "lblConnection";
            this.lblConnection.Size = new System.Drawing.Size(97, 22);
            this.lblConnection.Text = "Not connected";
            // 
            // btnMeasure
            // 
            this.btnMeasure.AutoSize = false;
            this.btnMeasure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMeasure.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.transform_crop;
            this.btnMeasure.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMeasure.Name = "btnMeasure";
            this.btnMeasure.Size = new System.Drawing.Size(30, 22);
            this.btnMeasure.Text = "Measure";
            this.btnMeasure.Click += new System.EventHandler(this.btnMeasure_Click);
            // 
            // btnReload
            // 
            this.btnReload.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReload.Image = global::CẢM_BIẾN_SIÊU_ÂM___HC_SR04_.Properties.Resources.update;
            this.btnReload.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(23, 22);
            this.btnReload.Text = "Reload";
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblNumberOfMeasurements
            // 
            this.lblNumberOfMeasurements.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblNumberOfMeasurements.BackColor = System.Drawing.SystemColors.MenuBar;
            this.lblNumberOfMeasurements.Name = "lblNumberOfMeasurements";
            this.lblNumberOfMeasurements.Size = new System.Drawing.Size(41, 22);
            this.lblNumberOfMeasurements.Text = "N = 00";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(577, 391);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IoT - HC SR04 ";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnQuit;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnConnec1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnAbout1;
        private System.Windows.Forms.ToolStripMenuItem featureToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnSaveGraph1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ToolStripLabel lblConnection;
        private System.Windows.Forms.ToolStripMenuItem btnLineGraph1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageLineGraph;
        private System.Windows.Forms.TabPage tabPageCurveGraph;
        private System.Windows.Forms.ToolStripButton btnCurveGraph2;
        private System.Windows.Forms.ToolStripButton btnLineGraph2;
        private System.Windows.Forms.ToolStripButton btnConnect2;
        private System.Windows.Forms.ToolStripButton btnSaveGraph2;
        private System.Windows.Forms.ToolStripButton btnAbout2;
        private System.Windows.Forms.ToolStripMenuItem btnCurveGraph1;
        private System.Windows.Forms.ToolStripLabel lblA;
        private System.Windows.Forms.ToolStripLabel lblAr;
        private System.Windows.Forms.ToolStripLabel lblDAr;
        private System.Windows.Forms.ToolStripButton btnMeasure;
        private System.Windows.Forms.ToolStripButton btnReload;
        private System.Windows.Forms.ToolStripLabel lblNumberOfMeasurements;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

