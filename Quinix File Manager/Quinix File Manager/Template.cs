using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quinix_File_Manager
{
    public partial class Template : Form
    {
        int TaskBarHeight = 70;

        public Template()
        {
            InitializeComponent();
        }

        private void Template_Load(object sender, EventArgs e)
        {
            Content ContentCtrl = new Content();
            FormContent.Controls.Add(ContentCtrl.Main);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            ExitAmination.Start();
        }

        private void Maximize_Click(object sender, EventArgs e)
        {
            this.MaximumSize = new Size(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height - TaskBarHeight);
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                LeftCorner.Visible = true;
                RightCorner.Visible = true;
            }

            else
            {
                this.WindowState = FormWindowState.Maximized;
                LeftCorner.Visible = false;
                RightCorner.Visible = false;
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            MinimizeAnimation.Start();
        }

        int CurX;
        int CurY;
        Boolean Moving = false;
        
        private void Title_MouseDown(object sender, MouseEventArgs e)
        {
            CurX = e.Location.X;
            CurY = e.Location.Y;
            Moving = true;
        }

        private void Title_MouseMove(object sender, MouseEventArgs e)
        {
            if (Moving == true)
            {
                this.Location = new Point(Cursor.Position.X - CurX, Cursor.Position.Y - CurY);
                this.WindowState = FormWindowState.Normal;
                LeftCorner.Visible = true;
                RightCorner.Visible = true;
            }
        }

        private void Title_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.Location.Y <= 0)
            {
                this.WindowState = FormWindowState.Maximized;
                LeftCorner.Visible = false;
                RightCorner.Visible = false;
            }

            Moving = false;
        }

        private void ExitAmination_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.1)
            {
                this.Opacity = this.Opacity - 0.05;
            }

            else
            {
                Application.Exit();
            }
        }

        private void MinimizeAnimation_Tick(object sender, EventArgs e)
        {
            if (this.Opacity >= 0.1)
            {
                this.Opacity = this.Opacity - 0.05;
            }

            else
            {
                this.WindowState = FormWindowState.Minimized;
                this.Opacity = 1;
                MinimizeAnimation.Stop();
            }
        }

        Boolean Resizing = false;

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Resizing = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Resizing == true)
            {
                this.Size = new Size(Cursor.Position.X - this.Location.X, Cursor.Position.Y - this.Location.Y);
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Resizing = false;
        }

    }
}
