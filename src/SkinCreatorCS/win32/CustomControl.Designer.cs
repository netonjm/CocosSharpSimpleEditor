namespace SkinCreatorCS
{
    partial class CustomControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnFront = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnDock = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.Picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Image = global::SkinCreatorCS.Properties.Resources.shape_move_backwards;
            this.btnBack.Location = new System.Drawing.Point(31, 60);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(25, 25);
            this.btnBack.TabIndex = 7;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomControl_KeyDown);
            // 
            // btnFront
            // 
            this.btnFront.Image = global::SkinCreatorCS.Properties.Resources.shape_move_forwards;
            this.btnFront.Location = new System.Drawing.Point(3, 60);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(25, 25);
            this.btnFront.TabIndex = 6;
            this.btnFront.UseVisualStyleBackColor = true;
            this.btnFront.Click += new System.EventHandler(this.btnFront_Click);
            this.btnFront.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomControl_KeyDown);
            // 
            // btnImage
            // 
            this.btnImage.Image = global::SkinCreatorCS.Properties.Resources.folder_picture;
            this.btnImage.Location = new System.Drawing.Point(86, 29);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(25, 25);
            this.btnImage.TabIndex = 5;
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            this.btnImage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomControl_KeyDown);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::SkinCreatorCS.Properties.Resources.cancel;
            this.btnDelete.Location = new System.Drawing.Point(123, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(25, 25);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            this.btnDelete.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomControl_KeyDown);
            // 
            // btnResize
            // 
            this.btnResize.Image = global::SkinCreatorCS.Properties.Resources.arrow_out;
            this.btnResize.Location = new System.Drawing.Point(59, 29);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(25, 25);
            this.btnResize.TabIndex = 3;
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            this.btnResize.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomControl_KeyDown);
            // 
            // btnDock
            // 
            this.btnDock.Image = global::SkinCreatorCS.Properties.Resources.layout_content;
            this.btnDock.Location = new System.Drawing.Point(31, 29);
            this.btnDock.Name = "btnDock";
            this.btnDock.Size = new System.Drawing.Size(25, 25);
            this.btnDock.TabIndex = 2;
            this.btnDock.UseVisualStyleBackColor = true;
            this.btnDock.Click += new System.EventHandler(this.btnDock_Click);
            this.btnDock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomControl_KeyDown);
            // 
            // btnLock
            // 
            this.btnLock.Image = global::SkinCreatorCS.Properties.Resources.key;
            this.btnLock.Location = new System.Drawing.Point(3, 29);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(25, 25);
            this.btnLock.TabIndex = 1;
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            this.btnLock.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomControl_KeyDown);
            // 
            // Picture
            // 
            this.Picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Picture.ErrorImage = null;
            this.Picture.Image = global::SkinCreatorCS.Properties.Resources.Location_File_icon;
            this.Picture.InitialImage = null;
            this.Picture.Location = new System.Drawing.Point(0, 0);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(548, 436);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture.TabIndex = 0;
            this.Picture.TabStop = false;
            this.Picture.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDoubleClick);
            this.Picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            this.Picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseMove);
            // 
            // CustomControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnFront);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnResize);
            this.Controls.Add(this.btnDock);
            this.Controls.Add(this.btnLock);
            this.Controls.Add(this.Picture);
            this.Name = "CustomControl";
            this.Size = new System.Drawing.Size(548, 436);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.Button btnDock;
        private System.Windows.Forms.Button btnResize;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnFront;
        private System.Windows.Forms.Button btnBack;
    }
}
