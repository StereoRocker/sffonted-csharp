
namespace _88fonted
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
            this.frmMain_Menu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpLeft = new System.Windows.Forms.GroupBox();
            this.panFontSet = new System.Windows.Forms.Panel();
            this.grpRight = new System.Windows.Forms.GroupBox();
            this.panFontCharacter = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmdSelect = new System.Windows.Forms.ToolStripButton();
            this.cmdPencil = new System.Windows.Forms.ToolStripButton();
            this.cmdEraser = new System.Windows.Forms.ToolStripButton();
            this.cmdLine = new System.Windows.Forms.ToolStripButton();
            this.cmdRectangle = new System.Windows.Forms.ToolStripButton();
            this.frmMain_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpLeft.SuspendLayout();
            this.grpRight.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // frmMain_Menu
            // 
            this.frmMain_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.frmMain_Menu.Location = new System.Drawing.Point(0, 0);
            this.frmMain_Menu.Name = "frmMain_Menu";
            this.frmMain_Menu.Size = new System.Drawing.Size(660, 24);
            this.frmMain_Menu.TabIndex = 0;
            this.frmMain_Menu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToCToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exportToCToolStripMenuItem
            // 
            this.exportToCToolStripMenuItem.Name = "exportToCToolStripMenuItem";
            this.exportToCToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToCToolStripMenuItem.Text = "Export to C";
            this.exportToCToolStripMenuItem.Click += new System.EventHandler(this.exportToCToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.grpLeft);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.grpRight);
            this.splitContainer1.Panel2.Controls.Add(this.toolStrip1);
            this.splitContainer1.Size = new System.Drawing.Size(660, 428);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 1;
            // 
            // grpLeft
            // 
            this.grpLeft.Controls.Add(this.panFontSet);
            this.grpLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpLeft.Location = new System.Drawing.Point(0, 0);
            this.grpLeft.Name = "grpLeft";
            this.grpLeft.Size = new System.Drawing.Size(268, 428);
            this.grpLeft.TabIndex = 0;
            this.grpLeft.TabStop = false;
            this.grpLeft.Text = "Font data";
            // 
            // panFontSet
            // 
            this.panFontSet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFontSet.Location = new System.Drawing.Point(3, 16);
            this.panFontSet.MinimumSize = new System.Drawing.Size(64, 96);
            this.panFontSet.Name = "panFontSet";
            this.panFontSet.Size = new System.Drawing.Size(262, 409);
            this.panFontSet.TabIndex = 0;
            this.panFontSet.Paint += new System.Windows.Forms.PaintEventHandler(this.panFontSet_Paint);
            this.panFontSet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panFontSet_MouseClick);
            this.panFontSet.Resize += new System.EventHandler(this.panFontSet_Resize);
            // 
            // grpRight
            // 
            this.grpRight.Controls.Add(this.panFontCharacter);
            this.grpRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRight.Location = new System.Drawing.Point(0, 38);
            this.grpRight.Name = "grpRight";
            this.grpRight.Size = new System.Drawing.Size(388, 390);
            this.grpRight.TabIndex = 2;
            this.grpRight.TabStop = false;
            this.grpRight.Text = "Font character";
            // 
            // panFontCharacter
            // 
            this.panFontCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panFontCharacter.Location = new System.Drawing.Point(3, 16);
            this.panFontCharacter.MinimumSize = new System.Drawing.Size(8, 8);
            this.panFontCharacter.Name = "panFontCharacter";
            this.panFontCharacter.Size = new System.Drawing.Size(382, 371);
            this.panFontCharacter.TabIndex = 0;
            this.panFontCharacter.Paint += new System.Windows.Forms.PaintEventHandler(this.panFontCharacter_Paint);
            this.panFontCharacter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panFontCharacter_MouseDown);
            this.panFontCharacter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panFontCharacter_MouseMove);
            this.panFontCharacter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panFontCharacter_MouseUp);
            this.panFontCharacter.Resize += new System.EventHandler(this.panFontCharacter_Resize);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmdSelect,
            this.cmdPencil,
            this.cmdEraser,
            this.cmdLine,
            this.cmdRectangle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(388, 38);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmdSelect
            // 
            this.cmdSelect.Checked = true;
            this.cmdSelect.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cmdSelect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdSelect.Image = global::_88fonted.Properties.Resources.hand;
            this.cmdSelect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdSelect.Margin = new System.Windows.Forms.Padding(1);
            this.cmdSelect.Name = "cmdSelect";
            this.cmdSelect.Size = new System.Drawing.Size(36, 36);
            this.cmdSelect.Tag = "";
            this.cmdSelect.Text = "Select";
            this.cmdSelect.Click += new System.EventHandler(this.cmdSelect_Click);
            // 
            // cmdPencil
            // 
            this.cmdPencil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdPencil.Image = global::_88fonted.Properties.Resources.pencil;
            this.cmdPencil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdPencil.Margin = new System.Windows.Forms.Padding(1);
            this.cmdPencil.Name = "cmdPencil";
            this.cmdPencil.Size = new System.Drawing.Size(36, 36);
            this.cmdPencil.Text = "Pencil";
            this.cmdPencil.Click += new System.EventHandler(this.cmdPencil_Click);
            // 
            // cmdEraser
            // 
            this.cmdEraser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdEraser.Image = global::_88fonted.Properties.Resources.eraser;
            this.cmdEraser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdEraser.Margin = new System.Windows.Forms.Padding(1);
            this.cmdEraser.Name = "cmdEraser";
            this.cmdEraser.Size = new System.Drawing.Size(36, 36);
            this.cmdEraser.Text = "Eraser";
            this.cmdEraser.Click += new System.EventHandler(this.cmdEraser_Click);
            // 
            // cmdLine
            // 
            this.cmdLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdLine.Image = ((System.Drawing.Image)(resources.GetObject("cmdLine.Image")));
            this.cmdLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdLine.Margin = new System.Windows.Forms.Padding(1);
            this.cmdLine.Name = "cmdLine";
            this.cmdLine.Size = new System.Drawing.Size(36, 36);
            this.cmdLine.Text = "toolStripButton1";
            this.cmdLine.Click += new System.EventHandler(this.cmdLine_Click);
            // 
            // cmdRectangle
            // 
            this.cmdRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cmdRectangle.Image = ((System.Drawing.Image)(resources.GetObject("cmdRectangle.Image")));
            this.cmdRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cmdRectangle.Margin = new System.Windows.Forms.Padding(1);
            this.cmdRectangle.Name = "cmdRectangle";
            this.cmdRectangle.Size = new System.Drawing.Size(36, 36);
            this.cmdRectangle.Text = "toolStripButton1";
            this.cmdRectangle.Click += new System.EventHandler(this.cmdRectangle_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 452);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.frmMain_Menu);
            this.MainMenuStrip = this.frmMain_Menu;
            this.MinimumSize = new System.Drawing.Size(250, 200);
            this.Name = "frmMain";
            this.Text = "Small Font Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.frmMain_Menu.ResumeLayout(false);
            this.frmMain_Menu.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpLeft.ResumeLayout(false);
            this.grpRight.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip frmMain_Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpLeft;
        private System.Windows.Forms.Panel panFontSet;
        private System.Windows.Forms.GroupBox grpRight;
        private System.Windows.Forms.Panel panFontCharacter;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton cmdSelect;
        private System.Windows.Forms.ToolStripButton cmdPencil;
        private System.Windows.Forms.ToolStripButton cmdEraser;
        private System.Windows.Forms.ToolStripButton cmdLine;
        private System.Windows.Forms.ToolStripButton cmdRectangle;
    }
}

