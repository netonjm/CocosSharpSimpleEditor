using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkinCreatorCS
{

    public enum CustomControlType
    {
        Image = 1,
        Button = 2,
        Label = 3,
    }

    public partial class CustomControl : UserControl
    {

		public Bitmap InitialImage { get; set; }

        #region Events

        public Action<CustomControl> OnDelete { get; set; }
        public Action<CustomControl, bool> OnActivate { get; set; }
        public Action<CustomControl, bool> OnSelected { get; set; }
        public Action<CustomControl, bool> OnControlResize { get; set; }
        public Action OnPropertyRefresh { get; set; }

        #endregion

        #region Properties

        private bool _isResizing;
        private bool _isSelected;

        public CustomElement Element { get; set; }


        public CustomControlType ControlType
        {
            get
            {
                return (CustomControlType)Element.TypeId;
            }

            set
            {
                Element.TypeId = (int)value;
            }
        }

        public string ID
        {
            get { return Element.ID; }
            set
            {
                Element.ID = value;
                if (OnPropertyRefresh != null)
                    OnPropertyRefresh();
            }
        }

        public bool IsResizing
        {
            get { return _isResizing; }
            set
            {
                _isResizing = value;

                ActivateColorButton(btnResize, value);

                if (OnControlResize != null)
                    OnControlResize(this, IsResizing);

                if (OnPropertyRefresh != null)
                    OnPropertyRefresh();
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {

                btnLock.Visible = btnDock.Visible = btnDelete.Visible = btnImage.Visible = btnResize.Visible = btnBack.Visible = btnFront.Visible
                    = _isSelected = value;

                if (value)
                {
                    if (OnSelected != null)
                        OnSelected(this, true);
                }

                if (OnPropertyRefresh != null)
                    OnPropertyRefresh();
            }
        }

        public bool CanMove { get { return !IsLocked && !IsDocket; } }

        public bool IsLocked
        {
            get { return Element.IsLocked; }
            set
            {
                Element.IsLocked = value;
                ActivateColorButton(btnLock, value);

                if (OnPropertyRefresh != null)
                    OnPropertyRefresh();
            }
        }

        public bool IsDocket
        {
            get { return Element.IsDocked; }
            set
            {

                Element.IsDocked = value;

                ActivateColorButton(btnDock, value);

                if (OnActivate != null)
                    OnActivate(this, value);

                if (OnPropertyRefresh != null)
                    OnPropertyRefresh();
            }
        }

        public string FileName
        {
            get { return Element.FileName; }
            set
            {

                Element.FileName = value;

                if (OnPropertyRefresh != null)
                    OnPropertyRefresh();

            }
        }

        public int X { get { return Element.X; } set { Element.X = value; Location = new Point(value, Location.X); } }

        public int Y { get { return Element.Y; } set { Element.Y = value; Location = new Point(Location.X, value); } }

        public int Width
        {
            get
            {

                return Element.Width;

            }
            set
            {
                Element.Width = value;
                base.Width = value;
            }
        }

        public int Height
        {
            get
            {
                return Element.Height;
            }
            set
            {
                Element.Height = value;
                base.Height = value;
            }
        }

        #endregion

        public CustomControl()
        {
            InitializeComponent();
            Element = new CustomElement();
        }

        public void OpenImageFile()
        {
            OpenFileDialog fileSelected = new OpenFileDialog();
            fileSelected.Title = "Select a image";
            fileSelected.Multiselect = false;
            fileSelected.ShowDialog();
            LoadImageFile(fileSelected.FileName);
        }

        public void LoadImageFile(string filename)
        {
            if (!string.IsNullOrEmpty(filename))
            {
                FileName = filename;
				InitialImage = new Bitmap(FileName);
				Picture.Image = (Bitmap)InitialImage.Clone();
            }
        }

        public void ActivateColorButton(Button sender, bool active)
        {
            if (active)
                (sender as Button).BackColor = Color.Gray;
            else
                (sender as Button).BackColor = Color.Transparent;
        }

        #region Form events

        private void btnLock_Click(object sender, EventArgs e)
        {
            IsLocked = !IsLocked;
        }

        private void btnDock_Click(object sender, EventArgs e)
        {
            IsDocket = !IsDocket;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            IsResizing = !IsResizing;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (OnDelete != null)
                OnDelete(this);
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenImageFile();
        }

        private void btnFront_Click(object sender, EventArgs e)
        {
            BringToFront();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SendToBack();
        }

        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            IsSelected = true;
            this.OnMouseDown(e);
        }

        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            this.OnMouseMove(e);
        }

        private void PictureBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.OnMouseDoubleClick(e);
        }

        #endregion

        private void CustomControl_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        public void SetData(CustomElement item)
        {

            X = item.X;
            Y = item.Y;
            ID = item.ID;
            IsDocket = item.IsDocked;
            IsLocked = item.IsLocked;
            ControlType = (CustomControlType)item.TypeId;
            Width = item.Width;
            Height = item.Height;
            FileName = item.FileName;
            if (!string.IsNullOrEmpty(FileName))
            LoadImageFile(FileName);

        }
    }
}
