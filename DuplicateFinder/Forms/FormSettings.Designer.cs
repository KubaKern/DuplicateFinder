namespace DuplicateFinder.Forms
{
    partial class FormSettings
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
            this.label2 = new System.Windows.Forms.Label();
            this.themeSelectBox = new System.Windows.Forms.ComboBox();
            this.hashSelectBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelSettings = new System.Windows.Forms.Panel();
            this.panelSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Motyw: ";
            // 
            // themeSelectBox
            // 
            this.themeSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.themeSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.themeSelectBox.FormattingEnabled = true;
            this.themeSelectBox.Items.AddRange(new object[] {
            "Day",
            "Night"});
            this.themeSelectBox.Location = new System.Drawing.Point(8, 29);
            this.themeSelectBox.Name = "themeSelectBox";
            this.themeSelectBox.Size = new System.Drawing.Size(121, 23);
            this.themeSelectBox.TabIndex = 3;
            this.themeSelectBox.SelectedIndexChanged += new System.EventHandler(this.themeSelectBox_SelectedIndexChanged);
            // 
            // hashSelectBox
            // 
            this.hashSelectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hashSelectBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hashSelectBox.FormattingEnabled = true;
            this.hashSelectBox.Items.AddRange(new object[] {
            "SHA1",
            "MD5",
            "SHA256",
            "SHA384",
            "SHA512"});
            this.hashSelectBox.Location = new System.Drawing.Point(8, 84);
            this.hashSelectBox.Name = "hashSelectBox";
            this.hashSelectBox.Size = new System.Drawing.Size(121, 23);
            this.hashSelectBox.TabIndex = 4;
            this.hashSelectBox.SelectedIndexChanged += new System.EventHandler(this.hashSelectBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(3, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Hash:";
            // 
            // panelSettings
            // 
            this.panelSettings.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelFileColor;
            this.panelSettings.Controls.Add(this.label2);
            this.panelSettings.Controls.Add(this.hashSelectBox);
            this.panelSettings.Controls.Add(this.label3);
            this.panelSettings.Controls.Add(this.themeSelectBox);
            this.panelSettings.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelFileColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelSettings.Location = new System.Drawing.Point(12, 12);
            this.panelSettings.Name = "panelSettings";
            this.panelSettings.Size = new System.Drawing.Size(292, 220);
            this.panelSettings.TabIndex = 22;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DuplicateFinder.Properties.Settings.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.panelSettings);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "Ustawienia";
            this.panelSettings.ResumeLayout(false);
            this.panelSettings.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox themeSelectBox;
        private System.Windows.Forms.ComboBox hashSelectBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelSettings;
    }
}