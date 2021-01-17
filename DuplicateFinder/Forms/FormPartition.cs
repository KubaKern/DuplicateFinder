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
using BrightIdeasSoftware;

namespace DuplicateFinder.Forms
{
    public partial class FormPartition : Form
    {
        String currentDirectory = "::{20D04FE0-3AEA-1069-A2D8-08002B30309D}";

        class FilesInfo
        {
            public String name { get; set; }
            public String path { get; set; }
            public String ext { get; set; }
            public String hash { get; set; }

            public FilesInfo(String Name, String Path, String Ext, String Hash)
            {
                name = Name;
                path = Path;
                ext = Ext;
                hash = Hash;
            }
        }
        class PathsInfo
        {
            public String path { get; set; }

            public PathsInfo(String Path)
            {
                path = Path;
            }
        }

        public FormPartition()
        {
            InitializeComponent();
            labelFileName.Text = "";
            List<PathsInfo> files = new List<PathsInfo>();
            foreach (DriveInfo f in DriveInfo.GetDrives())
            {
                if (f.IsReady) files.Add(new PathsInfo(f.Name));
            }
            partitionList.SetObjects(files);
            fileList.AboutToCreateGroups += delegate (object sender, CreateGroupsEventArgs args) {
                int numer = 0;
                foreach (OLVGroup olvGroup in args.Groups)
                {
                    int totalTime = 0;

                    foreach (OLVListItem item in olvGroup.Items)
                    {
                        String rowObject = item.RowObject as String;
                        totalTime++;
                    }
                    numer++;
                    olvGroup.Header = String.Format("Gr. {0} ({1})", numer, totalTime);
                }
            };
            fileList.AlwaysGroupByColumn = hash;
            fileList.Sort(hash);
        }

        private void buttonSelection_Click(object sender, EventArgs e)
        {
            if (partitionList.CheckedItems.Count == 0)
            {
                partitionList.CheckAll();
            }
            else
            {
                partitionList.UncheckAll();
            }
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

        private Bitmap ResizeBMP(Bitmap bmp, int width, int height)
        {
            Bitmap res = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(res))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }
            return res;
        }

        private void buttonOpenLocation_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", @"/select,""" + currentDirectory + "\"");
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
                currentDirectory = file.FullName;
                labelFileName.Text = file.Name;
                labelFileSize.Text = CalculateFileSize(file.Length);
                buttonOpenLocation.Enabled = true;
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
                    Bitmap bm = ResizeBMP(temp, 111, 111);
                    previewBox.Image = bm;
                    temp.Dispose();
                }
                else
                {
                    previewBox.Image = ResizeBMP(DuplicateFinder.Properties.Resources.previewUnavailable, 111, 111);
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
            if (e.KeyCode == Keys.Delete)
            {
                usuńToolStripMenuItem_Click(sender, e);
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            TextMatchFilter filter1 = TextMatchFilter.Contains(fileList, nameSearch.Text);
            filter1.Columns = new[] { this.name };
            TextMatchFilter filter2 = TextMatchFilter.Contains(fileList, extensionSearch.Text);
            filter2.Columns = new[] { this.ext };

            this.fileList.ModelFilter = new CompositeAllFilter(new List<IModelFilter> { filter1, filter2 });
        }

        private void extensionSearch_TextChanged(object sender, EventArgs e)
        {
            TextMatchFilter filter1 = TextMatchFilter.Contains(fileList, nameSearch.Text);
            filter1.Columns = new[] { this.name };
            TextMatchFilter filter2 = TextMatchFilter.Contains(fileList, extensionSearch.Text);
            filter2.Columns = new[] { this.ext };

            this.fileList.ModelFilter = new CompositeAllFilter(new List<IModelFilter> { filter1, filter2 });
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.WorkerSupportsCancellation = true;
                List<PathsInfo> partitions = new List<PathsInfo>();
                foreach (ListViewItem lvi in partitionList.CheckedItems)
                    partitions.Add(new PathsInfo(lvi.SubItems[0].Text));
                backgroundWorker.RunWorkerAsync(partitions);
            }
        }

        private void buttonCheck_Click(object sender, DoWorkEventArgs e)
        {
            List<PathsInfo> partitions = (List < PathsInfo > )e.Argument;
            Comparer comparer = new Comparer();
            String searchPattern = "*.*";
            
            long totalFiles = 0;
            long[] partitionFiles = new long[partitions.Count() + 1];
            partitionFiles[0] = 0;
            for (int i = 1; i <= partitions.Count(); i++)
            {
                partitionFiles[i] = comparer.fileCount(partitions[i - 1].path, searchPattern);
                totalFiles += partitionFiles[i];

            }

            String[] filesHash = new String[totalFiles + 1];
            String[] filePaths = new String[totalFiles + 1];

            if (partitions.Count() == 1)
            {

                filesHash = comparer.ScanPartition(partitions[0].path, searchPattern);
                filePaths = comparer.getFiles(partitions[0].path, searchPattern);

            }
            else
            {
                String[] tempH = comparer.ScanPartition(partitions[0].path, searchPattern);
                String[] tempP = comparer.getFiles(partitions[0].path, searchPattern);

                tempH.CopyTo(filesHash, 0);
                tempP.CopyTo(filePaths, 0);

                for (int i = 1; i < partitions.Count(); i++)
                {
                    String[] tempHash = comparer.ScanPartition(partitions[i].path, searchPattern);
                    String[] tempPaths = comparer.getFiles(partitions[i].path, searchPattern);

                    tempHash.CopyTo(filesHash, partitionFiles[i]);
                    tempPaths.CopyTo(filePaths, partitionFiles[i]);
                }
            }

            Array.Sort(filesHash, filePaths);
            bool[] exist = comparer.findDuplicates(filesHash);


            List<FilesInfo> files = new List<FilesInfo>();

            long counter = 0;
            for (long i = 0; i < exist.Length; i++)
            {
                if (exist[i] == true)
                {
                    counter++;
                    files.Add(new FilesInfo(Path.GetFileName(filePaths[i]), filePaths[i], Path.GetExtension(filePaths[i]), filesHash[i]));
                }

            }
            fileList.SetObjects(files);

            MessageBox.Show("Znaleziono: " + counter.ToString() + " duplikatów. ");

            this.backgroundWorker.CancelAsync();

        }

        private void labelFileName_Click(object sender, EventArgs e)
        {

        }
        private void labelFileName_MouseHover(object sender, EventArgs e)
        {
            fullName.Show(labelFileName.Text, labelFileName);
        }

        private void labelFileName_MouseLeave(object sender, EventArgs e)
        {
            fullName.Hide(labelFileName);
        }
    }


}
