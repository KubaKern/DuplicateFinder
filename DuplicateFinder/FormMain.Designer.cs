namespace DuplicateFinder
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPartition = new System.Windows.Forms.Button();
            this.buttonFile = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonLogo = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelLeftMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelLeftMenuColor;
            this.panelLeftMenu.Controls.Add(this.buttonAbout);
            this.panelLeftMenu.Controls.Add(this.buttonSettings);
            this.panelLeftMenu.Controls.Add(this.buttonPartition);
            this.panelLeftMenu.Controls.Add(this.buttonFile);
            this.panelLeftMenu.Controls.Add(this.panelLogo);
            this.panelLeftMenu.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelLeftMenuColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelLeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(251, 542);
            this.panelLeftMenu.TabIndex = 2;
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = global::DuplicateFinder.Properties.Settings.Default.ButtonAboutColor;
            this.buttonAbout.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "ButtonAboutColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonAbout.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAbout.FlatAppearance.BorderSize = 0;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonAbout.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAbout.Image = global::DuplicateFinder.Properties.Resources.about;
            this.buttonAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAbout.Location = new System.Drawing.Point(0, 240);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(251, 60);
            this.buttonAbout.TabIndex = 4;
            this.buttonAbout.Text = "Informacje";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = global::DuplicateFinder.Properties.Settings.Default.ButtonSettingsColor;
            this.buttonSettings.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "ButtonSettingsColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Image = global::DuplicateFinder.Properties.Resources.settings;
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 180);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(251, 60);
            this.buttonSettings.TabIndex = 3;
            this.buttonSettings.Text = "Ustawienia";
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonPartition
            // 
            this.buttonPartition.BackColor = global::DuplicateFinder.Properties.Settings.Default.ButtonPartitionColor;
            this.buttonPartition.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "ButtonPartitionColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonPartition.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPartition.FlatAppearance.BorderSize = 0;
            this.buttonPartition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPartition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonPartition.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPartition.Image = global::DuplicateFinder.Properties.Resources.partition;
            this.buttonPartition.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPartition.Location = new System.Drawing.Point(0, 120);
            this.buttonPartition.Name = "buttonPartition";
            this.buttonPartition.Size = new System.Drawing.Size(251, 60);
            this.buttonPartition.TabIndex = 2;
            this.buttonPartition.Text = "Sprawdź Partycję";
            this.buttonPartition.UseVisualStyleBackColor = false;
            this.buttonPartition.Click += new System.EventHandler(this.buttonPartition_Click);
            // 
            // buttonFile
            // 
            this.buttonFile.BackColor = global::DuplicateFinder.Properties.Settings.Default.ButtonFileColor;
            this.buttonFile.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "ButtonFileColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.buttonFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonFile.FlatAppearance.BorderSize = 0;
            this.buttonFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonFile.Image = global::DuplicateFinder.Properties.Resources.file;
            this.buttonFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFile.Location = new System.Drawing.Point(0, 60);
            this.buttonFile.Name = "buttonFile";
            this.buttonFile.Size = new System.Drawing.Size(251, 60);
            this.buttonFile.TabIndex = 1;
            this.buttonFile.Text = "Duplikaty Pliku";
            this.buttonFile.UseVisualStyleBackColor = false;
            this.buttonFile.Click += new System.EventHandler(this.buttonFile_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelLogoColor;
            this.panelLogo.Controls.Add(this.buttonLogo);
            this.panelLogo.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelLogoColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(251, 60);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // buttonLogo
            // 
            this.buttonLogo.FlatAppearance.BorderSize = 0;
            this.buttonLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogo.Font = new System.Drawing.Font("Liberation Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.buttonLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLogo.Image = global::DuplicateFinder.Properties.Resources.logo;
            this.buttonLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLogo.Location = new System.Drawing.Point(50, 0);
            this.buttonLogo.Name = "buttonLogo";
            this.buttonLogo.Size = new System.Drawing.Size(151, 60);
            this.buttonLogo.TabIndex = 0;
            this.buttonLogo.Text = "Duplicate Finder";
            this.buttonLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonLogo.UseVisualStyleBackColor = true;
            this.buttonLogo.Click += new System.EventHandler(this.buttonLogo_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelTopColor;
            this.panelTop.Controls.Add(this.buttonMinimize);
            this.panelTop.Controls.Add(this.buttonMaximize);
            this.panelTop.Controls.Add(this.buttonClose);
            this.panelTop.Controls.Add(this.labelTitle);
            this.panelTop.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelTopColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(251, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(853, 60);
            this.panelTop.TabIndex = 14;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.buttonMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMinimize.Image = global::DuplicateFinder.Properties.Resources.minimize;
            this.buttonMinimize.Location = new System.Drawing.Point(673, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(60, 60);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.buttonMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMaximize.Image = global::DuplicateFinder.Properties.Resources.maximize;
            this.buttonMaximize.Location = new System.Drawing.Point(733, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(60, 60);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Reem Kufi", 15F, System.Drawing.FontStyle.Bold);
            this.buttonClose.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonClose.Image = ((System.Drawing.Image)(resources.GetObject("buttonClose.Image")));
            this.buttonClose.Location = new System.Drawing.Point(793, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(60, 60);
            this.buttonClose.TabIndex = 2;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(341, 18);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(0, 29);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.labelTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.labelTitle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // panelContent
            // 
            this.panelContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContent.BackColor = global::DuplicateFinder.Properties.Settings.Default.FormBackColor;
            this.panelContent.BackgroundImage = global::DuplicateFinder.Properties.Resources.logoBig;
            this.panelContent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelContent.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelContent.Location = new System.Drawing.Point(251, 60);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(837, 466);
            this.panelContent.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DuplicateFinder.Properties.Settings.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(1104, 542);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelLeftMenu);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(431, 360);
            this.Name = "FormMain";
            this.Text = "Duplicate Finder";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelLeftMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Button buttonPartition;
        private System.Windows.Forms.Button buttonFile;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Button buttonLogo;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
    }
}

