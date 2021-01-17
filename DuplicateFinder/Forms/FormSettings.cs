using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFinder.Forms
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            themeSelectBox.SelectedIndex = themeSelectBox.Items.IndexOf(Properties.Settings.Default.Theme);
            hashSelectBox.SelectedIndex = hashSelectBox.Items.IndexOf(Properties.Settings.Default.Hash);
        }

        private void themeSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Theme = themeSelectBox.Text;
            
            if (themeSelectBox.Text == "Day")
            {
                Properties.Settings.Default.FormBackColor = Color.Gainsboro;
                Properties.Settings.Default.PanelTopColor = Color.FromArgb(54, 79, 123);
                Properties.Settings.Default.PanelLogoColor = Color.FromArgb(32, 34, 41);
                Properties.Settings.Default.PanelLeftMenuColor = Color.FromArgb(62, 75, 97);
                Properties.Settings.Default.ButtonFileColor = Color.FromArgb(62, 75, 97);
                Properties.Settings.Default.ButtonPartitionColor = Color.FromArgb(62, 75, 97);
                
                if (this.Visible)
                {
                    Properties.Settings.Default.ButtonSettingsColor = Color.FromArgb(54, 79, 123);
                }
                else
                {
                    Properties.Settings.Default.ButtonSettingsColor = Color.FromArgb(62, 75, 97);
                }

                Properties.Settings.Default.ButtonAboutColor = Color.FromArgb(62, 75, 97);
                Properties.Settings.Default.PanelFileColor = Color.FromArgb(62, 75, 97);
            }
            if (themeSelectBox.Text == "Night")
            {
                Properties.Settings.Default.FormBackColor = Color.FromArgb(108, 117, 125);
                Properties.Settings.Default.PanelTopColor = Color.FromArgb(73, 80, 87);
                Properties.Settings.Default.PanelLogoColor = Color.FromArgb(33, 37, 41);
                Properties.Settings.Default.PanelLeftMenuColor = Color.FromArgb(52, 58, 64);
                Properties.Settings.Default.ButtonFileColor = Color.FromArgb(52, 58, 64);
                Properties.Settings.Default.ButtonPartitionColor = Color.FromArgb(52, 58, 64);
                
                if (this.Visible)
                {
                    Properties.Settings.Default.ButtonSettingsColor = Color.FromArgb(73, 80, 87);
                }
                else
                {
                    Properties.Settings.Default.ButtonSettingsColor = Color.FromArgb(52, 58, 64);
                }

                Properties.Settings.Default.ButtonAboutColor = Color.FromArgb(52, 58, 64);
                Properties.Settings.Default.PanelFileColor = Color.FromArgb(52, 58, 64);
            }

            Properties.Settings.Default.Save();
        }

        private void hashSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Hash = hashSelectBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
