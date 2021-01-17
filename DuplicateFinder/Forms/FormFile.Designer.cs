namespace DuplicateFinder.Forms
{
    partial class FormFile
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.fileList = new BrightIdeasSoftware.ObjectListView();
            this.name = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.pathh = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.buttonLocation = new System.Windows.Forms.Button();
            this.buttonOpenLocation = new System.Windows.Forms.Button();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.previewBox = new System.Windows.Forms.PictureBox();
            this.panelOriginalFile = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelectedFile = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.previewBoxSelected = new System.Windows.Forms.PictureBox();
            this.labelNameSelected = new System.Windows.Forms.Label();
            this.buttonOpenLocationSelected = new System.Windows.Forms.Button();
            this.labelSizeSelected = new System.Windows.Forms.Label();
            this.labelFileNameSelected = new System.Windows.Forms.Label();
            this.labelFileSizeSelected = new System.Windows.Forms.Label();
            this.buttonSearchLocation = new System.Windows.Forms.Button();
            this.typesSelectBox = new System.Windows.Forms.ComboBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullName = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).BeginInit();
            this.panelOriginalFile.SuspendLayout();
            this.panelSelectedFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBoxSelected)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelName.Location = new System.Drawing.Point(3, 154);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(54, 17);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Nazwa:";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSize.Location = new System.Drawing.Point(3, 171);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(64, 17);
            this.labelSize.TabIndex = 13;
            this.labelSize.Text = "Rozmiar:";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileName.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFileName.Location = new System.Drawing.Point(63, 154);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(51, 17);
            this.labelFileName.TabIndex = 14;
            this.labelFileName.Text = "default";
            this.labelFileName.MouseLeave += new System.EventHandler(this.labelFileName_MouseLeave);
            this.labelFileName.MouseHover += new System.EventHandler(this.labelFileName_MouseHover);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileSize.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFileSize.Location = new System.Drawing.Point(63, 171);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(51, 17);
            this.labelFileSize.TabIndex = 15;
            this.labelFileSize.Text = "default";
            // 
            // fileList
            // 
            this.fileList.AllColumns.Add(this.name);
            this.fileList.AllColumns.Add(this.pathh);
            this.fileList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileList.CellEditUseWholeCell = false;
            this.fileList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.pathh});
            this.fileList.Cursor = System.Windows.Forms.Cursors.Default;
            this.fileList.FullRowSelect = true;
            this.fileList.HideSelection = false;
            this.fileList.Location = new System.Drawing.Point(12, 12);
            this.fileList.Name = "fileList";
            this.fileList.ShowGroups = false;
            this.fileList.Size = new System.Drawing.Size(547, 444);
            this.fileList.TabIndex = 16;
            this.fileList.UseCompatibleStateImageBehavior = false;
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
            // buttonLocation
            // 
            this.buttonLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLocation.Location = new System.Drawing.Point(12, 464);
            this.buttonLocation.Name = "buttonLocation";
            this.buttonLocation.Size = new System.Drawing.Size(75, 23);
            this.buttonLocation.TabIndex = 17;
            this.buttonLocation.Text = "Wybierz plik";
            this.buttonLocation.UseVisualStyleBackColor = true;
            this.buttonLocation.Click += new System.EventHandler(this.buttonLocation_Click);
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
            this.buttonOpenLocation.Size = new System.Drawing.Size(292, 29);
            this.buttonOpenLocation.TabIndex = 18;
            this.buttonOpenLocation.Text = "Otwórz lokalizację pliku";
            this.buttonOpenLocation.UseVisualStyleBackColor = true;
            this.buttonOpenLocation.Click += new System.EventHandler(this.buttonOpenLocation_Click);
            // 
            // buttonCheck
            // 
            this.buttonCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheck.Enabled = false;
            this.buttonCheck.Location = new System.Drawing.Point(484, 464);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(75, 23);
            this.buttonCheck.TabIndex = 19;
            this.buttonCheck.Text = "Sprawdź";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.checkFiles);
            // 
            // previewBox
            // 
            this.previewBox.Location = new System.Drawing.Point(82, 23);
            this.previewBox.Name = "previewBox";
            this.previewBox.Size = new System.Drawing.Size(128, 128);
            this.previewBox.TabIndex = 4;
            this.previewBox.TabStop = false;
            // 
            // panelOriginalFile
            // 
            this.panelOriginalFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelOriginalFile.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelFileColor;
            this.panelOriginalFile.Controls.Add(this.label1);
            this.panelOriginalFile.Controls.Add(this.previewBox);
            this.panelOriginalFile.Controls.Add(this.labelName);
            this.panelOriginalFile.Controls.Add(this.buttonOpenLocation);
            this.panelOriginalFile.Controls.Add(this.labelSize);
            this.panelOriginalFile.Controls.Add(this.labelFileName);
            this.panelOriginalFile.Controls.Add(this.labelFileSize);
            this.panelOriginalFile.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelFileColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelOriginalFile.Location = new System.Drawing.Point(568, 12);
            this.panelOriginalFile.Name = "panelOriginalFile";
            this.panelOriginalFile.Size = new System.Drawing.Size(292, 220);
            this.panelOriginalFile.TabIndex = 20;
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
            // panelSelectedFile
            // 
            this.panelSelectedFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSelectedFile.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelFileColor;
            this.panelSelectedFile.Controls.Add(this.label2);
            this.panelSelectedFile.Controls.Add(this.previewBoxSelected);
            this.panelSelectedFile.Controls.Add(this.labelNameSelected);
            this.panelSelectedFile.Controls.Add(this.buttonOpenLocationSelected);
            this.panelSelectedFile.Controls.Add(this.labelSizeSelected);
            this.panelSelectedFile.Controls.Add(this.labelFileNameSelected);
            this.panelSelectedFile.Controls.Add(this.labelFileSizeSelected);
            this.panelSelectedFile.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelFileColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelSelectedFile.Location = new System.Drawing.Point(568, 238);
            this.panelSelectedFile.Name = "panelSelectedFile";
            this.panelSelectedFile.Size = new System.Drawing.Size(292, 220);
            this.panelSelectedFile.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Zaznaczony plik";
            // 
            // previewBoxSelected
            // 
            this.previewBoxSelected.Location = new System.Drawing.Point(82, 23);
            this.previewBoxSelected.Name = "previewBoxSelected";
            this.previewBoxSelected.Size = new System.Drawing.Size(128, 128);
            this.previewBoxSelected.TabIndex = 4;
            this.previewBoxSelected.TabStop = false;
            // 
            // labelNameSelected
            // 
            this.labelNameSelected.AutoSize = true;
            this.labelNameSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNameSelected.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNameSelected.Location = new System.Drawing.Point(3, 154);
            this.labelNameSelected.Name = "labelNameSelected";
            this.labelNameSelected.Size = new System.Drawing.Size(54, 17);
            this.labelNameSelected.TabIndex = 12;
            this.labelNameSelected.Text = "Nazwa:";
            // 
            // buttonOpenLocationSelected
            // 
            this.buttonOpenLocationSelected.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonOpenLocationSelected.Enabled = false;
            this.buttonOpenLocationSelected.FlatAppearance.BorderSize = 0;
            this.buttonOpenLocationSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOpenLocationSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonOpenLocationSelected.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonOpenLocationSelected.Location = new System.Drawing.Point(0, 191);
            this.buttonOpenLocationSelected.Name = "buttonOpenLocationSelected";
            this.buttonOpenLocationSelected.Size = new System.Drawing.Size(292, 29);
            this.buttonOpenLocationSelected.TabIndex = 18;
            this.buttonOpenLocationSelected.Text = "Otwórz lokalizację pliku";
            this.buttonOpenLocationSelected.UseVisualStyleBackColor = true;
            this.buttonOpenLocationSelected.Click += new System.EventHandler(this.buttonOpenLocationSelected_Click);
            // 
            // labelSizeSelected
            // 
            this.labelSizeSelected.AutoSize = true;
            this.labelSizeSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSizeSelected.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSizeSelected.Location = new System.Drawing.Point(3, 171);
            this.labelSizeSelected.Name = "labelSizeSelected";
            this.labelSizeSelected.Size = new System.Drawing.Size(64, 17);
            this.labelSizeSelected.TabIndex = 13;
            this.labelSizeSelected.Text = "Rozmiar:";
            // 
            // labelFileNameSelected
            // 
            this.labelFileNameSelected.AutoSize = true;
            this.labelFileNameSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileNameSelected.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFileNameSelected.Location = new System.Drawing.Point(63, 154);
            this.labelFileNameSelected.Name = "labelFileNameSelected";
            this.labelFileNameSelected.Size = new System.Drawing.Size(51, 17);
            this.labelFileNameSelected.TabIndex = 14;
            this.labelFileNameSelected.Text = "default";
            this.labelFileNameSelected.MouseLeave += new System.EventHandler(this.labelFileNameSelected_MouseLeave);
            this.labelFileNameSelected.MouseHover += new System.EventHandler(this.labelFileNameSelected_MouseHover);
            // 
            // labelFileSizeSelected
            // 
            this.labelFileSizeSelected.AutoSize = true;
            this.labelFileSizeSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelFileSizeSelected.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelFileSizeSelected.Location = new System.Drawing.Point(63, 171);
            this.labelFileSizeSelected.Name = "labelFileSizeSelected";
            this.labelFileSizeSelected.Size = new System.Drawing.Size(51, 17);
            this.labelFileSizeSelected.TabIndex = 15;
            this.labelFileSizeSelected.Text = "default";
            // 
            // buttonSearchLocation
            // 
            this.buttonSearchLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSearchLocation.Location = new System.Drawing.Point(93, 464);
            this.buttonSearchLocation.Name = "buttonSearchLocation";
            this.buttonSearchLocation.Size = new System.Drawing.Size(100, 23);
            this.buttonSearchLocation.TabIndex = 22;
            this.buttonSearchLocation.Text = "Wybierz folder";
            this.buttonSearchLocation.UseVisualStyleBackColor = true;
            this.buttonSearchLocation.Click += new System.EventHandler(this.buttonSelectLocationClick);
            // 
            // typesSelectBox
            // 
            this.typesSelectBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.typesSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typesSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.typesSelectBox.FormattingEnabled = true;
            this.typesSelectBox.Items.AddRange(new object[] {
            "Wszystkie",
            "*.txt",
            "*.doc",
            "*.jpg",
            "*.png",
            "*.jpg",
            "*.jpeg",
            "*.gif",
            "*.avi",
            "*.mp3",
            "*.mp4",
            "*.exe"});
            this.typesSelectBox.Location = new System.Drawing.Point(199, 464);
            this.typesSelectBox.Name = "typesSelectBox";
            this.typesSelectBox.Size = new System.Drawing.Size(121, 23);
            this.typesSelectBox.TabIndex = 23;
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
            // FormFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMinSize = new System.Drawing.Size(800, 0);
            this.BackColor = global::DuplicateFinder.Properties.Settings.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.typesSelectBox);
            this.Controls.Add(this.buttonSearchLocation);
            this.Controls.Add(this.panelSelectedFile);
            this.Controls.Add(this.panelOriginalFile);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.buttonLocation);
            this.Controls.Add(this.fileList);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFile";
            this.Text = "Duplikaty Pliku";
            ((System.ComponentModel.ISupportInitialize)(this.fileList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.previewBox)).EndInit();
            this.panelOriginalFile.ResumeLayout(false);
            this.panelOriginalFile.PerformLayout();
            this.panelSelectedFile.ResumeLayout(false);
            this.panelSelectedFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previewBoxSelected)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox previewBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private BrightIdeasSoftware.ObjectListView fileList;
        private BrightIdeasSoftware.OLVColumn name;
        private BrightIdeasSoftware.OLVColumn pathh;
        private System.Windows.Forms.Button buttonLocation;
        private System.Windows.Forms.Button buttonOpenLocation;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panelOriginalFile;
        private System.Windows.Forms.Panel panelSelectedFile;
        private System.Windows.Forms.PictureBox previewBoxSelected;
        private System.Windows.Forms.Label labelNameSelected;
        private System.Windows.Forms.Button buttonOpenLocationSelected;
        private System.Windows.Forms.Label labelSizeSelected;
        private System.Windows.Forms.Label labelFileNameSelected;
        private System.Windows.Forms.Label labelFileSizeSelected;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearchLocation;
        private System.Windows.Forms.ComboBox typesSelectBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuńToolStripMenuItem;
        private System.Windows.Forms.ToolTip fullName;
    }
}