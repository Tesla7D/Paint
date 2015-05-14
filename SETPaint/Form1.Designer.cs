namespace SETPaint
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.toolCircleButton = new System.Windows.Forms.ToolStripButton();
            this.toolRectangleButton = new System.Windows.Forms.ToolStripButton();
            this.toolLineButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolBorderColor = new System.Windows.Forms.ToolStripButton();
            this.toolFillColor = new System.Windows.Forms.ToolStripButton();
            this.toolLineWidth = new System.Windows.Forms.ToolStripDropDownButton();
            this.pxTool1px = new System.Windows.Forms.ToolStripMenuItem();
            this.pxTool3px = new System.Windows.Forms.ToolStripMenuItem();
            this.pxTool5px = new System.Windows.Forms.ToolStripMenuItem();
            this.pxTool8px = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newFileButton = new System.Windows.Forms.ToolStripMenuItem();
            this.openButton = new System.Windows.Forms.ToolStripMenuItem();
            this.saveButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitButton = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.drawArea = new System.Windows.Forms.PictureBox();
            this.toolBar.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).BeginInit();
            this.SuspendLayout();
            // 
            // toolBar
            // 
            this.toolBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCircleButton,
            this.toolRectangleButton,
            this.toolLineButton,
            this.toolStripSeparator1,
            this.toolBorderColor,
            this.toolFillColor,
            this.toolLineWidth});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Size = new System.Drawing.Size(30, 523);
            this.toolBar.TabIndex = 0;
            this.toolBar.Text = "toolStrip1";
            // 
            // toolCircleButton
            // 
            this.toolCircleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCircleButton.Image = ((System.Drawing.Image)(resources.GetObject("toolCircleButton.Image")));
            this.toolCircleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCircleButton.Name = "toolCircleButton";
            this.toolCircleButton.Size = new System.Drawing.Size(27, 20);
            this.toolCircleButton.Text = "Circle";
            this.toolCircleButton.Click += new System.EventHandler(this.toolCircleButton_Click);
            // 
            // toolRectangleButton
            // 
            this.toolRectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolRectangleButton.Image = ((System.Drawing.Image)(resources.GetObject("toolRectangleButton.Image")));
            this.toolRectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolRectangleButton.Name = "toolRectangleButton";
            this.toolRectangleButton.Size = new System.Drawing.Size(27, 20);
            this.toolRectangleButton.Text = "Rectangle";
            this.toolRectangleButton.Click += new System.EventHandler(this.toolRectangleButton_Click);
            // 
            // toolLineButton
            // 
            this.toolLineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLineButton.Image = ((System.Drawing.Image)(resources.GetObject("toolLineButton.Image")));
            this.toolLineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLineButton.Name = "toolLineButton";
            this.toolLineButton.Size = new System.Drawing.Size(27, 20);
            this.toolLineButton.Text = "Line";
            this.toolLineButton.Click += new System.EventHandler(this.toolLineButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(27, 6);
            // 
            // toolBorderColor
            // 
            this.toolBorderColor.AutoSize = false;
            this.toolBorderColor.BackColor = System.Drawing.Color.Black;
            this.toolBorderColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolBorderColor.Image = ((System.Drawing.Image)(resources.GetObject("toolBorderColor.Image")));
            this.toolBorderColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolBorderColor.Name = "toolBorderColor";
            this.toolBorderColor.Size = new System.Drawing.Size(25, 25);
            this.toolBorderColor.Text = "Border Color";
            this.toolBorderColor.Click += new System.EventHandler(this.toolBorderColor_Click);
            // 
            // toolFillColor
            // 
            this.toolFillColor.AutoSize = false;
            this.toolFillColor.BackColor = System.Drawing.Color.White;
            this.toolFillColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolFillColor.Image = ((System.Drawing.Image)(resources.GetObject("toolFillColor.Image")));
            this.toolFillColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFillColor.Name = "toolFillColor";
            this.toolFillColor.Size = new System.Drawing.Size(25, 25);
            this.toolFillColor.Text = "Fill Color";
            this.toolFillColor.Click += new System.EventHandler(this.toolFillColor_Click);
            // 
            // toolLineWidth
            // 
            this.toolLineWidth.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolLineWidth.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pxTool1px,
            this.pxTool3px,
            this.pxTool5px,
            this.pxTool8px});
            this.toolLineWidth.Image = ((System.Drawing.Image)(resources.GetObject("toolLineWidth.Image")));
            this.toolLineWidth.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolLineWidth.Name = "toolLineWidth";
            this.toolLineWidth.Size = new System.Drawing.Size(27, 20);
            this.toolLineWidth.Text = "Line Width";
            // 
            // pxTool1px
            // 
            this.pxTool1px.Name = "pxTool1px";
            this.pxTool1px.Size = new System.Drawing.Size(95, 22);
            this.pxTool1px.Text = "1 px";
            this.pxTool1px.Click += new System.EventHandler(this.pxTool1px_Click);
            // 
            // pxTool3px
            // 
            this.pxTool3px.Name = "pxTool3px";
            this.pxTool3px.Size = new System.Drawing.Size(95, 22);
            this.pxTool3px.Text = "3 px";
            this.pxTool3px.Click += new System.EventHandler(this.pxTool3px_Click);
            // 
            // pxTool5px
            // 
            this.pxTool5px.Name = "pxTool5px";
            this.pxTool5px.Size = new System.Drawing.Size(95, 22);
            this.pxTool5px.Text = "5 px";
            this.pxTool5px.Click += new System.EventHandler(this.pxTool5px_Click);
            // 
            // pxTool8px
            // 
            this.pxTool8px.Name = "pxTool8px";
            this.pxTool8px.Size = new System.Drawing.Size(95, 22);
            this.pxTool8px.Text = "8 px";
            this.pxTool8px.Click += new System.EventHandler(this.pxTool8px_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(1167, 24);
            this.menuBar.TabIndex = 1;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFileButton,
            this.openButton,
            this.saveButton,
            this.toolStripSeparator2,
            this.exitButton});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newFileButton
            // 
            this.newFileButton.Name = "newFileButton";
            this.newFileButton.Size = new System.Drawing.Size(103, 22);
            this.newFileButton.Text = "New";
            this.newFileButton.Click += new System.EventHandler(this.newFileButton_Click);
            // 
            // openButton
            // 
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(103, 22);
            this.openButton.Text = "Open";
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(103, 22);
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(100, 6);
            // 
            // exitButton
            // 
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(103, 22);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutButton});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.aboutToolStripMenuItem.Text = "Help";
            // 
            // aboutButton
            // 
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(107, 22);
            this.aboutButton.Text = "About";
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusBar.Location = new System.Drawing.Point(30, 525);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1137, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // drawArea
            // 
            this.drawArea.BackColor = System.Drawing.SystemColors.Window;
            this.drawArea.Location = new System.Drawing.Point(29, 28);
            this.drawArea.Name = "drawArea";
            this.drawArea.Size = new System.Drawing.Size(1138, 494);
            this.drawArea.TabIndex = 3;
            this.drawArea.TabStop = false;
            this.drawArea.Paint += new System.Windows.Forms.PaintEventHandler(this.drawArea_Paint);
            this.drawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseDown);
            this.drawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseMove);
            this.drawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.drawArea_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 547);
            this.Controls.Add(this.drawArea);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "SET Paint";
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drawArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton toolCircleButton;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.PictureBox drawArea;
        private System.Windows.Forms.ToolStripButton toolRectangleButton;
        private System.Windows.Forms.ToolStripButton toolLineButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolBorderColor;
        private System.Windows.Forms.ToolStripButton toolFillColor;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newFileButton;
        private System.Windows.Forms.ToolStripMenuItem openButton;
        private System.Windows.Forms.ToolStripMenuItem saveButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitButton;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutButton;
        private System.Windows.Forms.ToolStripDropDownButton toolLineWidth;
        private System.Windows.Forms.ToolStripMenuItem pxTool1px;
        private System.Windows.Forms.ToolStripMenuItem pxTool3px;
        private System.Windows.Forms.ToolStripMenuItem pxTool5px;
        private System.Windows.Forms.ToolStripMenuItem pxTool8px;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}

