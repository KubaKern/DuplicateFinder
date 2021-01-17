using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DuplicateFinder
{
    public partial class FormMain : Form
    {
        //gui
        private Button currentButton;
        private Form activeForm;
        private bool mouseDown;
        private Point lastLocation;

        public FormMain()
        {/*
            if (Properties.Settings.Default.Theme == String.Empty)
            {
                Properties.Settings.Default.Theme = "Day";
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.Hash == String.Empty)
            {
                Properties.Settings.Default.Hash = "SHA1";
                Properties.Settings.Default.Save();
            }*/
            InitializeComponent();
            this.Icon = DuplicateFinder.Properties.Resources.icon;
            //System.IO.DirectoryInfo di = new System.IO.DirectoryInfo("c:\\");
            //System.IO.FileSystemInfo[] files = di.GetFileSystemInfos();
            //checkedListBox.Items.AddRange(files); 
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }
        //resize
        private const int gripSize = 16;

        private void FormMain_Load(object sender, EventArgs e)
        {
            int c = 0;
            foreach (var form in Program.formsList)
            {
                if (c != 0)
                {
                    form.TopLevel = false;
                    form.FormBorderStyle = FormBorderStyle.None;
                    form.Dock = DockStyle.Fill;
                    this.panelContent.Controls.Add(form);
                    this.panelContent.Tag = form;
                    form.BringToFront();
                    //labelTitle.Text = form.Text;
                    form.Hide();
                }
                c++;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - gripSize, this.ClientSize.Height - gripSize, gripSize, gripSize);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.X >= this.ClientSize.Width - gripSize && pos.Y >= this.ClientSize.Height - gripSize)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }
            }
            base.WndProc(ref m);
        }

        //domoGUI
        private void ActivateButton(object sender)
        {
            if(sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    DisableButton();
                    currentButton = (Button)sender;
                    //currentButton.BackColor = Color.FromArgb(54, 79, 123);
                    currentButton.BackColor = Properties.Settings.Default.PanelTopColor;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousButton in panelLeftMenu.Controls)
            {
                if(previousButton.GetType() == typeof(Button))
                {
                    //previousButton.BackColor = Color.FromArgb(62, 75, 97);
                    previousButton.BackColor = Properties.Settings.Default.PanelLeftMenuColor;
                    previousButton.ForeColor = Color.Gainsboro;
                    previousButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
                }
            }
        }

        private void buttonLogo_Click(object sender, EventArgs e)
        {
            if(activeForm != null)
            {
                activeForm.Hide();
                DisableButton();
                currentButton = (Button)sender;
                labelTitle.Text = "";

            }
        }

        private void buttonFile_Click(object sender, EventArgs e)
        {
            LoadForm(Program.formsList[1], sender);
        }

        private void buttonPartition_Click(object sender, EventArgs e)
        {
            LoadForm(Program.formsList[2], sender);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            LoadForm(Program.formsList[3], sender);
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            LoadForm(Program.formsList[4], sender);
        }

        private void LoadForm(Form content, object sender)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            ActivateButton(sender);
            content.Show();
            activeForm = content;
            /*content.TopLevel = false;
            content.FormBorderStyle = FormBorderStyle.None;
            content.Dock = DockStyle.Fill;
            this.panelContent.Controls.Add(content);
            this.panelContent.Tag = content;
            content.BringToFront();
            content.Show();
            */
            labelTitle.Text = content.Text;
        }

        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
