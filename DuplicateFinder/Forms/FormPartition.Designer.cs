using System;
using BrightIdeasSoftware;

namespace DuplicateFinder.Forms
{
    partial class FormPartition
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
            this.buttonSelection = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.extensionSearch = new System.Windows.Forms.TextBox();
            this.fileList = new BrightIdeasSoftware.ObjectListView();
            this.name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pathh = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.ext = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.hash = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.panelOriginalFile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.buttonOpenLocation = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.partitionList = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nameSearch = new System.Windows.Forms.TextBox();
            this.checkStateRenderer1 = new BrightIdeasSoftware.CheckStateRenderer();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.fullName = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            this.panelOriginalFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelection
            // 
            this.buttonSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSelection.Location = new System.Drawing.Point(12, 464);
            this.buttonSelection.Name = "buttonSelection";
            this.buttonSelection.Size = new System.Drawing.Size(89, 23);
            this.buttonSelection.TabIndex = 23;
            this.buttonSelection.Text = "Wszystko";
            this.buttonSelection.UseVisualStyleBackColor = true;
            this.buttonSelection.Click += new System.EventHandler(this.buttonSelection_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonCheck.Location = new System.Drawing.Point(109, 464);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 24;
            this.buttonCheck.Text = "Sprawdź";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // extensionSearch
            // 
            this.extensionSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.extensionSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.extensionSearch.Location = new System.Drawing.Point(374, 0);
            this.extensionSearch.Name = "extensionSearch";
            this.extensionSearch.Size = new System.Drawing.Size(170, 22);
            this.extensionSearch.TabIndex = 25;
            this.extensionSearch.TextChanged += new System.EventHandler(this.extensionSearch_TextChanged);
            // 
            // fileList
            // 
            this.fileList.AllColumns.Add(this.name);
            this.fileList.AllColumns.Add(this.pathh);
            this.fileList.AllColumns.Add(this.ext);
            this.fileList.AllColumns.Add(this.hash);
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.CellEditUseWholeCell = false;
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.pathh,
            this.ext,
            this.hash});
            this.fileList.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileList.FullRowSelect = true;
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(190, 12);
            this.fileList.Name = "fileList";
            this.fileList.Size = new System.Drawing.Size(547, 444);
            this.fileList.TabIndex = 28;
            this.fileList.UseCompatibleStateImageBehavior = false;
            this.fileList.UseFiltering = true;
            this.fileList.View = System.Windows.Forms.View.Details;
            this.fileList.SelectionChanged += new System.EventHandler(this.fileList_SelectionChanged);
            this.fileList.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileList_KeyDown);
            this.fileList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fileList_MouseClick);
            // 
            // name
            // 
            this.name.AspectName = "name";
            this.name.Text = "Nazwa pliku";
            this.name.Width = 198;
            // 
            // pathh
            // 
            this.pathh.AspectName = "path";
            this.pathh.Text = "Ścieżka";
            this.pathh.Width = 298;
            // 
            // ext
            // 
            this.ext.AspectName = "ext";
            this.ext.Text = "Rozszerzenie";
            this.ext.Width = 0;
            // 
            // hash
            // 
            this.hash.AspectName = "hash";
            this.hash.Width = 0;
            // 
            // panelOriginalFile
            // 
            this.panelOriginalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOriginalFile.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelFileColor;
            this.panelOriginalFile.Controls.Add(this.label1);
            this.panelOriginalFile.Controls.Add(this.previewBox);
            this.panelOriginalFile.Controls.Add(this.buttonOpenLocation);
            this.panelOriginalFile.Controls.Add(this.labelFileName);
            this.panelOriginalFile.Controls.Add(this.labelFileSize);
            this.panelOriginalFile.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelFileColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelOriginalFile.Location = new System.Drawing.Point(743, 12);
            this.panelOriginalFile.Name = "panelOriginalFile";
            this.panelOriginalFile.Size = new System.Drawing.Size(117, 220);
            this.panelOriginalFile.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Wybrany plik";
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(3, 23);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(111, 111);
            this.previewBox.TabIndex = 4;
            this.previewBox.TabStop = false;
            // 
            // buttonOpenLocation
            // 
            this.buttonOpenLocation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOpenLocation.Enabled = false;
            this.buttonOpenLocation.FlatAppearance.BorderSize = 0;
            this.buttonOpenLocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonOpenLocation.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenLocation.Location = new System.Drawing.Point(0, 191);
            this.buttonOpenLocation.Name = "buttonOpenLocation";
            this.buttonOpenLocation.Size = new System.Drawing.Size(117, 29);
            this.buttonOpenLocation.TabIndex = 18;
            this.buttonOpenLocation.Text = "Lokalizacja";
            this.buttonOpenLocation.UseVisualStyleBackColor = true;
            this.buttonOpenLocation.Click += new System.EventHandler(this.buttonOpenLocation_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFileName.Location = new System.Drawing.Point(3, 154);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(51, 17);
            this.labelFileName.TabIndex = 14;
            this.labelFileName.Text = "default";
            this.labelFileName.Click += new System.EventHandler(this.labelFileName_Click);
            this.labelFileName.MouseLeave += new System.EventHandler(this.labelFileName_MouseLeave);
            this.labelFileName.MouseHover += new System.EventHandler(this.labelFileName_MouseHover);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFileSize.Location = new System.Drawing.Point(3, 171);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(0, 17);
            this.labelFileSize.TabIndex = 15;
            // 
            // partitionList
            // 
            this.partitionList.AllColumns.Add(this.olvColumn1);
            this.partitionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.partitionList.CellEditUseWholeCell = false;
            this.partitionList.CheckBoxes = true;
            this.partitionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1});
            this.partitionList.Cursor = System.Windows.Forms.Cursors.Default;
            this.partitionList.FullRowSelect = true;
            this.partitionList.HideSelection = false;
            this.partitionList.Location = new System.Drawing.Point(12, 12);
            this.partitionList.Name = "partitionList";
            this.partitionList.ShowGroups = false;
            this.partitionList.ShowImagesOnSubItems = true;
            this.partitionList.Size = new System.Drawing.Size(172, 444);
            this.partitionList.TabIndex = 32;
            this.partitionList.UseCompatibleStateImageBehavior = false;
            this.partitionList.UseSubItemCheckBoxes = true;
            this.partitionList.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "path";
            this.olvColumn1.Text = "Partycja";
            this.olvColumn1.Width = 168;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = global::DuplicateFinder.Properties.Settings.Default.FormBackColor;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nameSearch);
            this.panel1.Controls.Add(this.extensionSearch);
            this.panel1.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panel1.Location = new System.Drawing.Point(190, 464);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 23);
            this.panel1.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Wyszukiwanie: ";
            // 
            // nameSearch
            // 
            this.nameSearch.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.nameSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameSearch.Location = new System.Drawing.Point(198, 0);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(170, 22);
            this.nameSearch.TabIndex = 26;
            this.nameSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.buttonCheck_Click);
            // 
            // FormPartition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(800, 0);
            this.BackColor = global::DuplicateFinder.Properties.Settings.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.partitionList);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonSelection);
            this.Controls.Add(this.panelOriginalFile);
            this.Controls.Add(this.fileList);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPartition";
            this.Text = "Sprawdź Partycję";
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            this.panelOriginalFile.ResumeLayout(false);
            this.panelOriginalFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partitionList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSelection;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.TextBox extensionSearch;
        private BrightIdeasSoftware.ObjectListView fileList;
        private BrightIdeasSoftware.OLVColumn name;
        private BrightIdeasSoftware.OLVColumn pathh;
        private System.Windows.Forms.Panel panelOriginalFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Button buttonOpenLocation;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private BrightIdeasSoftware.ObjectListView partitionList;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private BrightIdeasSoftware.OLVColumn hash;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox nameSearch;
        private System.Windows.Forms.Label label2;
        private OLVColumn ext;
        private CheckStateRenderer checkStateRenderer1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.ToolTip fullName;
    }
}