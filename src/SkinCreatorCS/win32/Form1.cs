using SkinCreatorCS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkinCreatorCS
{
    public partial class frmMain : Form
    {

        private Point MouseDownLocation;
        private CustomControl SelectedControl;

        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select the skin to save";
            dialog.ShowDialog();
            MessageBox.Show(dialog.FileName);
        }

        public void InfoElement(CustomControl control)
        {

            //stripstatus_info.Text = control.Name;
            stripstatus_info.Text = string.Format("Position: ({0},{1})", control.Left, control.Top);
        }

        public void SelectControl(CustomControl s)
        {
            if (SelectedControl != null && SelectedControl != s)
            {
                SelectedControl.IsSelected = false;
            }
            FillProperties(s);
            SelectedControl = s;

        }

        public void FillProperties(CustomControl s)
        {
            if (s != null)
            {
                propertyControl.SelectedObject = s.Element;
            }
            else
            {
                propertyControl.SelectedObject = null;
            }

        }

        #region Image Utils

        public void ControlActivate(CustomControl control, bool value)
        {
            control.Focus();
            control.BringToFront();
            control.Dock = (value) ? DockStyle.Fill : DockStyle.None;
        }
        public void ControlSelected(CustomControl control, bool value)
        {
            SelectControl(value ? control : null);
        }

        public void ControlRemoveSelected()
        {
            if (SelectedControl != null)
            {

                PanelContainer.Controls.Remove(SelectedControl);
                SelectedControl = null;
            }
        }

        #endregion

        public CustomControl AddCustomControl(int x, int y)
        {
            //Add new cimage control
            CustomControl picture = new CustomControl();

            picture.ControlType = CustomControlType.Button;

            picture.OnActivate = ControlActivate;
            picture.OnSelected = ControlSelected;
            picture.KeyDown += (s, e) => OnKeyDown(e);

            picture.OnDelete += (s) => ControlRemoveSelected();
            picture.MouseDoubleClick += (s, e) => OnMouseDoubleClick(e);


            picture.OnPropertyRefresh += OnPropertyRefresh;

            picture.MouseDown += (s, even) =>
            {
                var element = (s as CustomControl);
                if (even.Button == System.Windows.Forms.MouseButtons.Left && element.CanMove)
                    MouseDownLocation = even.Location;

                InfoElement(element);

                element.Focus();

            };

            picture.MouseMove += (s, even) =>
            {
                var element = (s as CustomControl);
                if (even.Button == System.Windows.Forms.MouseButtons.Left && element.CanMove)
                {
                    element.Left = element.Element.X = even.X + element.Left - MouseDownLocation.X;
                    element.Top = element.Element.Y = even.Y + element.Top - MouseDownLocation.Y;
                }

                InfoElement(element);
            };

            picture.X = x;
            picture.Y = y;

            picture.Width = 300;
            picture.Height = 300;
            picture.BackColor = Color.Black;
            PanelContainer.Controls.Add(picture);
            picture.BringToFront();

            return picture;
        }

        public Control PanelContainer { get { return splitContainer1.Panel1.Controls[0]; } }

        private void OnPropertyRefresh()
        {
            FillProperties(SelectedControl);
        }

        private void btnAddButton_Click(object sender, EventArgs e)
        {
            stripAddImage.Checked = false;
            stripAddButton.Checked = !stripAddButton.Checked;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            stripAddButton.Checked = false;
            stripAddImage.Checked = !stripAddImage.Checked;
        }

        private void frmMain_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (stripAddImage.Checked)
                AddCustomControl(e.X, e.Y);
            else if (stripAddButton.Checked)
                AddCustomControl(e.X, e.Y);
        }

        private void frmMain_MouseClick(object sender, MouseEventArgs e)
        {
            //SelectControl(null);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                ControlRemoveSelected();
            }
        }

        private void stripFront_Click(object sender, EventArgs e)
        {
            if (SelectedControl != null)
                SelectedControl.BringToFront();
        }

        private void stripBack_Click(object sender, EventArgs e)
        {
            if (SelectedControl != null)
                SelectedControl.SendToBack();
        }

        private void stripLock_Click(object sender, EventArgs e)
        {
            if (SelectedControl != null)
                SelectedControl.IsLocked = !SelectedControl.IsLocked;
        }

        private void stripFill_Click(object sender, EventArgs e)
        {
            if (SelectedControl != null)
                SelectedControl.IsDocket = !SelectedControl.IsDocket;
        }

        private void stripRemove_Click(object sender, EventArgs e)
        {
            ControlRemoveSelected();
        }

        public void ConvertToControls(FileData fileData)
        {

            PanelContainer.Controls.Clear();

            PanelContainer.Height = fileData.ResolutionHeight;
            PanelContainer.Width = fileData.ResolutionWidth;

            foreach (var item in fileData.Elements)
            {
                AddCustomControl(item.X, item.Y).SetData(item);
            }
        }

        public FileData ConvertToFileData()
        {
            FileData fileData = new FileData();

            fileData.ResolutionHeight = PanelContainer.Height;
            fileData.ResolutionWidth = PanelContainer.Width;

            fileData.Elements = new CustomElement[PanelContainer.Controls.Count];
            for (int i = 0; i < PanelContainer.Controls.Count; i++)
            {
                fileData.Elements[i] = (PanelContainer.Controls[i] as CustomControl).Element;
            }
            return fileData;
        }

        public void CopyResourcesToDirectory(string directory)
        {
            FileInfo fInfo;
            for (int i = 0; i < PanelContainer.Controls.Count; i++)
            {
                fInfo = new FileInfo((PanelContainer.Controls[i] as CustomControl).FileName);
                if (fInfo.Exists)
                {
                    if (Path.Combine(directory, fInfo.Name) != fInfo.FullName)
                        fInfo.CopyTo(Path.Combine(directory, fInfo.Name), true);
                }
            }
        }

        private void stripSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Select file name to save";
            dialog.Filter = "Files|*.skin";
            dialog.ShowDialog();
            FileInfo finfo = new FileInfo(dialog.FileName);

            if (finfo.Exists)
                finfo.Delete();

            CopyResourcesToDirectory(finfo.Directory.FullName);
            FileData fileData = ConvertToFileData();

            fileData.WriteToFile<FileData>(finfo.FullName);
        }

        private void stripLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Select file name to load";
            dialog.Filter = "Files|*.skin";
            dialog.ShowDialog();

            var filename = dialog.FileName;

            if (!string.IsNullOrEmpty(filename))
            {

                FileData fileData = XmlSerialization.ReadFromFile<FileData>(filename);
                //Load all data into form
                ConvertToControls(fileData);
                MessageBox.Show("Finished load");
            }


        }

        private void stripProperties_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = !splitContainer1.Panel2Collapsed;
        }

        public bool IsProjectLoaded { get; set; }
        public string ProjectFileName { get; set; }
        public string ProjectName { get; set; }


        Process exeProcess;

        private void strip_play_Click(object sender, EventArgs e)
        {

            if (!IsProjectLoaded)
            {

            }


            //ProjectFileName = @"C:\Users\Jose\Documents\GitHub\ClassicCalculator2\src\ClassicCalculator\win32\bin\WindowsDX\Debug\Content\pruebas.skin";

            try
            {
                if (exeProcess != null)
                    exeProcess.Kill();
            }
            catch (Exception)
            {
            }

            FileInfo fInfoProject = new FileInfo(ProjectFileName);
            FileInfo fInfoTestDemo = new FileInfo(Settings.Default.TestDemoExecutable);
            ProcessStartInfo startInfo = new ProcessStartInfo(fInfoTestDemo.FullName);
            startInfo.WorkingDirectory = fInfoTestDemo.Directory.FullName;
            startInfo.UseShellExecute = true;
            startInfo.Arguments = fInfoProject.Name;

            try
            {
                // Start the process with the info we specified.
                // Call WaitForExit and then the using statement will close.
                exeProcess = Process.Start(startInfo);
                //exeProcess.WaitForExit();
            }
            catch
            {
                // Log error.
            }
        }

    }
}
