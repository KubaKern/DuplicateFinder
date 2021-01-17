using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFinder.Forms
{
    public partial class FormFile : Form
    {
        String currentDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
        String currentDirectorySelected = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
        String searchPath = "";
        public FormFile()
        {
            InitializeComponent();
            labelFileName.Text = "";
            labelFileSize.Text = "";
            labelFileNameSelected.Text = "";
            labelFileSizeSelected.Text = "";
            openFileDialog1.InitialDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";
            typesSelectBox.SelectedIndex = 0;
        }
        class FilesInfo
        {
            public String name { get; set; }
            public String path { get; set; }

            public FilesInfo(String Name, String Path)
            {
                name = Name;
                path = Path;
            }
        }

        String path;

        private Bitmap ResizeBMP(Bitmap bmp, int width, int height)
        {
            Bitmap res = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return res;
        }

        private String CalculateFileSize(long bytes)
        {
            if (bytes < 1024)
            {
                return bytes + " B";
            }
            else if (bytes < 1048576)
            {
                return (bytes / 1024.0).ToString("0.##") + " KB";
            }
            else if (bytes < 1073741824)
            {
                return (bytes / 1024.0 / 1024.0).ToString("0.##") + " MB";
            }
            else
            {
                return (bytes / 1024.0 / 1024.0 / 1024.0).ToString("0.##") + " GB";
            }
        }

        private void checkFiles(object sender, EventArgs e)
        {
            String where = searchPath;
            String searchPattern = typesSelectBox.Text;
            if (searchPattern == "" || searchPattern == "Wszystkie") searchPattern = "*.*";

            Comparer test = new Comparer(path);
            String[] directory = test.getFiles(where,searchPattern);
            bool[] exist = test.compareAll(directory);

            List<FilesInfo> files = new List<FilesInfo>();

            int counter = 0;
            for (int i = 0; i < exist.Length; i++)
            {
                if (exist[i] == true)
                {
                    counter++;
                    if (path != directory[i]) files.Add(new FilesInfo(Path.GetFileName(directory[i]), directory[i]));
                }
            }
            fileList.SetObjects(files);
            MessageBox.Show("Liczba wystąpień: " + counter);


        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                var file = new FileInfo(openFileDialog1.FileName);
                labelFileName.Text = file.Name;
                labelFileSize.Text = CalculateFileSize(file.Length);
                currentDirectory = file.FullName;

                path = file.ToString();
                path = Path.GetFullPath(path);

                buttonOpenLocation.Enabled = true;
                if (path != null && searchPath != "")
                {
                    buttonCheck.Enabled = true;
                }
                bool testIsImage;
                try
                {
                    Image.FromFile(openFileDialog1.FileName).Dispose();
                    testIsImage = true;
                }
                catch (OutOfMemoryException)
                {
                    testIsImage = false;
                }

                if (testIsImage)
                {
                    Bitmap temp = new Bitmap(openFileDialog1.FileName, false);
                    Bitmap bm = ResizeBMP(temp, 128, 128);
                    previewBox.Image = bm;
                    temp.Dispose();
                }
                else
                {
                    previewBox.Image = DuplicateFinder.Properties.Resources.previewUnavailable;
                }
            }
        }

        private void buttonOpenLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", @"/select,""" + currentDirectory + "\"");
        }

        private void buttonOpenLocationSelected_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", @"/select,""" + currentDirectorySelected + "\"");
        }

        private void fileList_SelectionChanged(object sender, EventArgs e)
        {
            if (fileList.SelectedItems.Count > 0)
            {
                if (!File.Exists(fileList.SelectedItems[0].SubItems[1].Text))
                {
                    fileList.Items.Remove(fileList.SelectedItems[0]);
                    return;
                }
                var file = new FileInfo(fileList.SelectedItems[0].SubItems[1].Text);
                currentDirectorySelected = file.FullName;
                labelFileNameSelected.Text = file.Name;
                labelFileSizeSelected.Text = CalculateFileSize(file.Length);
                buttonOpenLocationSelected.Enabled = true;
                bool testIsImage = true;
                try
                {
                    Image.FromFile(fileList.SelectedItems[0].SubItems[1].Text).Dispose();
                    testIsImage = true;
                }
                catch (OutOfMemoryException)
                {
                    testIsImage = false;
                }

                if (testIsImage)
                {
                    Bitmap temp = new Bitmap(fileList.SelectedItems[0].SubItems[1].Text, false);
                    Bitmap bm = ResizeBMP(temp, 128, 128);
                    previewBoxSelected.Image = bm;
                    temp.Dispose();
                }
                else
                {
                    previewBoxSelected.Image = DuplicateFinder.Properties.Resources.previewUnavailable;
                }
            }
        }

        private void buttonSelectLocationClick(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                searchPath = fbd.SelectedPath;
                if (path != null && searchPath != "")
                {
                    buttonCheck.Enabled = true;
                    buttonOpenLocation.Enabled = true;
                }
            }

        }

        private void usuńToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < fileList.SelectedItems.Count; i++)
            {
                File.Delete(fileList.SelectedItems[i].SubItems[1].Text);
                fileList.Items.Remove(fileList.SelectedItems[i]);
            }
            fileList.SelectedIndex = -1;
        }
        private void fileList_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (fileList.FocusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }
        private void fileList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                usuńToolStripMenuItem_Click(sender, e);
            }
        }
        private void labelFileName_MouseHover(object sender, EventArgs e)
        {
            fullName.Show(labelFileName.Text, labelFileName);
        }

        private void labelFileName_MouseLeave(object sender, EventArgs e)
        {
            fullName.Hide(labelFileName);
        }

        private void labelFileNameSelected_MouseHover(object sender, EventArgs e)
        {
            fullName.Show(labelFileNameSelected.Text, labelFileNameSelected);
        }

        private void labelFileNameSelected_MouseLeave(object sender, EventArgs e)
        {
            fullName.Hide(labelFileNameSelected);
        }
    }
}
