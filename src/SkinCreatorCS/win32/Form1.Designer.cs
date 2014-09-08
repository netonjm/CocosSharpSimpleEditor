namespace SkinCreatorCS
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripstatus_info = new System.Windows.Forms.ToolStripStatusLabel();
            this.propertyControl = new System.Windows.Forms.PropertyGrid();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.stripLoad = new System.Windows.Forms.ToolStripButton();
            this.stripSave = new System.Windows.Forms.ToolStripButton();
            this.stripAddButton = new System.Windows.Forms.ToolStripButton();
            this.stripAddImage = new System.Windows.Forms.ToolStripButton();
            this.stripDisplay = new System.Windows.Forms.ToolStripButton();
            this.stripLock = new System.Windows.Forms.ToolStripButton();
            this.stripFill = new System.Windows.Forms.ToolStripButton();
            this.stripResize = new System.Windows.Forms.ToolStripButton();
            this.stripOpenImage = new System.Windows.Forms.ToolStripButton();
            this.stripRemove = new System.Windows.Forms.ToolStripButton();
            this.stripFront = new System.Windows.Forms.ToolStripButton();
            this.stripBack = new System.Windows.Forms.ToolStripButton();
            this.stripProperties = new System.Windows.Forms.ToolStripButton();
            this.strip_play = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripLoad,
            this.stripSave,
            this.toolStripSeparator2,
            this.stripAddButton,
            this.stripAddImage,
            this.stripDisplay,
            this.toolStripSeparator1,
            this.stripLock,
            this.stripFill,
            this.stripResize,
            this.stripOpenImage,
            this.stripRemove,
            this.toolStripSeparator3,
            this.stripFront,
            this.stripBack,
            this.toolStripSeparator4,
            this.stripProperties,
            this.toolStripSeparator5,
            this.strip_play});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1137, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripstatus_info});
            this.statusStrip1.Location = new System.Drawing.Point(0, 614);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1137, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripstatus_info
            // 
            this.stripstatus_info.Name = "stripstatus_info";
            this.stripstatus_info.Size = new System.Drawing.Size(0, 17);
            // 
            // propertyControl
            // 
            this.propertyControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyControl.Location = new System.Drawing.Point(0, 0);
            this.propertyControl.Name = "propertyControl";
            this.propertyControl.Size = new System.Drawing.Size(391, 589);
            this.propertyControl.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer1.Panel1.BackgroundImage = global::SkinCreatorCS.Properties.Resources.maxresdefault;
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.splitContainer1.Panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDoubleClick);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.propertyControl);
            this.splitContainer1.Size = new System.Drawing.Size(1137, 589);
            this.splitContainer1.SplitterDistance = 742;
            this.splitContainer1.TabIndex = 7;
            this.splitContainer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 480);
            this.panel1.TabIndex = 0;
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseClick);
            this.panel1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDoubleClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // stripLoad
            // 
            this.stripLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripLoad.Image = global::SkinCreatorCS.Properties.Resources.folder_table;
            this.stripLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripLoad.Name = "stripLoad";
            this.stripLoad.Size = new System.Drawing.Size(23, 22);
            this.stripLoad.Text = "Open file";
            this.stripLoad.Click += new System.EventHandler(this.stripLoad_Click);
            // 
            // stripSave
            // 
            this.stripSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripSave.Image = global::SkinCreatorCS.Properties.Resources.disk_multiple;
            this.stripSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripSave.Name = "stripSave";
            this.stripSave.Size = new System.Drawing.Size(23, 22);
            this.stripSave.Text = "Save all";
            this.stripSave.Click += new System.EventHandler(this.stripSave_Click);
            // 
            // stripAddButton
            // 
            this.stripAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripAddButton.Image = global::SkinCreatorCS.Properties.Resources.control_stop_blue;
            this.stripAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripAddButton.Name = "stripAddButton";
            this.stripAddButton.Size = new System.Drawing.Size(23, 22);
            this.stripAddButton.Text = "Add button control";
            this.stripAddButton.Click += new System.EventHandler(this.btnAddButton_Click);
            // 
            // stripAddImage
            // 
            this.stripAddImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripAddImage.Image = global::SkinCreatorCS.Properties.Resources.image;
            this.stripAddImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripAddImage.Name = "stripAddImage";
            this.stripAddImage.Size = new System.Drawing.Size(23, 22);
            this.stripAddImage.Text = "Add Background";
            this.stripAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // stripDisplay
            // 
            this.stripDisplay.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripDisplay.Image = global::SkinCreatorCS.Properties.Resources.textfield;
            this.stripDisplay.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripDisplay.Name = "stripDisplay";
            this.stripDisplay.Size = new System.Drawing.Size(23, 22);
            this.stripDisplay.Text = "Add display";
            // 
            // stripLock
            // 
            this.stripLock.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripLock.Image = global::SkinCreatorCS.Properties.Resources.key;
            this.stripLock.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripLock.Name = "stripLock";
            this.stripLock.Size = new System.Drawing.Size(23, 22);
            this.stripLock.Text = "toolStripButton5";
            this.stripLock.Click += new System.EventHandler(this.stripLock_Click);
            // 
            // stripFill
            // 
            this.stripFill.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripFill.Image = global::SkinCreatorCS.Properties.Resources.arrow_out;
            this.stripFill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripFill.Name = "stripFill";
            this.stripFill.Size = new System.Drawing.Size(23, 22);
            this.stripFill.Text = "toolStripButton4";
            this.stripFill.Click += new System.EventHandler(this.stripFill_Click);
            // 
            // stripResize
            // 
            this.stripResize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripResize.Image = global::SkinCreatorCS.Properties.Resources.arrow_inout;
            this.stripResize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripResize.Name = "stripResize";
            this.stripResize.Size = new System.Drawing.Size(23, 22);
            this.stripResize.Text = "toolStripButton2";
            // 
            // stripOpenImage
            // 
            this.stripOpenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripOpenImage.Image = global::SkinCreatorCS.Properties.Resources.folder_picture;
            this.stripOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripOpenImage.Name = "stripOpenImage";
            this.stripOpenImage.Size = new System.Drawing.Size(23, 22);
            this.stripOpenImage.Text = "toolStripButton3";
            // 
            // stripRemove
            // 
            this.stripRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripRemove.Image = global::SkinCreatorCS.Properties.Resources.cancel;
            this.stripRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripRemove.Name = "stripRemove";
            this.stripRemove.Size = new System.Drawing.Size(23, 22);
            this.stripRemove.Text = "toolStripButton1";
            this.stripRemove.Click += new System.EventHandler(this.stripRemove_Click);
            // 
            // stripFront
            // 
            this.stripFront.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripFront.Image = global::SkinCreatorCS.Properties.Resources.shape_move_forwards;
            this.stripFront.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripFront.Name = "stripFront";
            this.stripFront.Size = new System.Drawing.Size(23, 22);
            this.stripFront.Text = "toolStripButton6";
            this.stripFront.Click += new System.EventHandler(this.stripFront_Click);
            // 
            // stripBack
            // 
            this.stripBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripBack.Image = global::SkinCreatorCS.Properties.Resources.shape_move_backwards;
            this.stripBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripBack.Name = "stripBack";
            this.stripBack.Size = new System.Drawing.Size(23, 22);
            this.stripBack.Text = "toolStripButton7";
            this.stripBack.Click += new System.EventHandler(this.stripBack_Click);
            // 
            // stripProperties
            // 
            this.stripProperties.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.stripProperties.Image = global::SkinCreatorCS.Properties.Resources.layout_header;
            this.stripProperties.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stripProperties.Name = "stripProperties";
            this.stripProperties.Size = new System.Drawing.Size(23, 22);
            this.stripProperties.Text = "toolStripButton1";
            this.stripProperties.Click += new System.EventHandler(this.stripProperties_Click);
            // 
            // strip_play
            // 
            this.strip_play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.strip_play.Image = global::SkinCreatorCS.Properties.Resources.resultset_next;
            this.strip_play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_play.Name = "strip_play";
            this.strip_play.Size = new System.Drawing.Size(23, 22);
            this.strip_play.Text = "toolStripButton1";
            this.strip_play.Click += new System.EventHandler(this.strip_play_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 636);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "CocosSharp Mini Editor v0.1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton stripAddButton;
        private System.Windows.Forms.ToolStripButton stripAddImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton stripDisplay;
        private System.Windows.Forms.ToolStripButton stripSave;
        private System.Windows.Forms.ToolStripButton stripLoad;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton stripOpenImage;
        private System.Windows.Forms.ToolStripButton stripRemove;
        private System.Windows.Forms.ToolStripButton stripResize;
        private System.Windows.Forms.ToolStripButton stripFill;
        private System.Windows.Forms.ToolStripButton stripLock;
        private System.Windows.Forms.ToolStripButton stripFront;
        private System.Windows.Forms.ToolStripButton stripBack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripstatus_info;
        private System.Windows.Forms.PropertyGrid propertyControl;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton stripProperties;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton strip_play;
    }
}

