namespace DuplicateFinder.Forms
{
    partial class FormAbout
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
            this.labelAuthors = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelAbout = new System.Windows.Forms.Panel();
            this.panelAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAuthors
            // 
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelAuthors.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAuthors.Location = new System.Drawing.Point(3, 0);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(92, 26);
            this.labelAuthors.TabIndex = 0;
            this.labelAuthors.Text = "Autorzy:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(20, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dominik Leśniewski";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(20, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kuba Kern";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(20, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rafał Kurzdym";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(3, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Wersja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(20, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "v1.0";
            // 
            // panelAbout
            // 
            this.panelAbout.BackColor = global::DuplicateFinder.Properties.Settings.Default.PanelFileColor;
            this.panelAbout.Controls.Add(this.labelAuthors);
            this.panelAbout.Controls.Add(this.label5);
            this.panelAbout.Controls.Add(this.label2);
            this.panelAbout.Controls.Add(this.label4);
            this.panelAbout.Controls.Add(this.label1);
            this.panelAbout.Controls.Add(this.label3);
            this.panelAbout.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "PanelFileColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelAbout.Location = new System.Drawing.Point(12, 12);
            this.panelAbout.Name = "panelAbout";
            this.panelAbout.Size = new System.Drawing.Size(292, 220);
            this.panelAbout.TabIndex = 21;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::DuplicateFinder.Properties.Settings.Default.FormBackColor;
            this.ClientSize = new System.Drawing.Size(884, 499);
            this.Controls.Add(this.panelAbout);
            this.DataBindings.Add(new System.Windows.Forms.Binding("BackColor", global::DuplicateFinder.Properties.Settings.Default, "FormBackColor", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAbout";
            this.Text = "Informacje";
            this.panelAbout.ResumeLayout(false);
            this.panelAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelAbout;
    }
}