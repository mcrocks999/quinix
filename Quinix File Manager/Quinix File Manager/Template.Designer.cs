namespace Quinix_File_Manager
{
    partial class Template
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
            this.TopBar = new System.Windows.Forms.Panel();
            this.Maximize = new System.Windows.Forms.PictureBox();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.LeftCorner = new System.Windows.Forms.PictureBox();
            this.RightCorner = new System.Windows.Forms.PictureBox();
            this.Title = new System.Windows.Forms.Label();
            this.ExitAmination = new System.Windows.Forms.Timer(this.components);
            this.MinimizeAnimation = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FormContent = new System.Windows.Forms.Panel();
            this.TopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCorner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCorner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(215)))));
            this.TopBar.Controls.Add(this.Maximize);
            this.TopBar.Controls.Add(this.Minimize);
            this.TopBar.Controls.Add(this.Exit);
            this.TopBar.Controls.Add(this.LeftCorner);
            this.TopBar.Controls.Add(this.RightCorner);
            this.TopBar.Controls.Add(this.Title);
            this.TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1184, 30);
            this.TopBar.TabIndex = 0;
            // 
            // Maximize
            // 
            this.Maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Maximize.Image = global::Quinix_File_Manager.Properties.Resources.MaximizeButon;
            this.Maximize.Location = new System.Drawing.Point(1120, 2);
            this.Maximize.Margin = new System.Windows.Forms.Padding(0);
            this.Maximize.Name = "Maximize";
            this.Maximize.Size = new System.Drawing.Size(26, 26);
            this.Maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Maximize.TabIndex = 2;
            this.Maximize.TabStop = false;
            this.Maximize.Click += new System.EventHandler(this.Maximize_Click);
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Image = global::Quinix_File_Manager.Properties.Resources.MinimizeButon;
            this.Minimize.Location = new System.Drawing.Point(1091, 2);
            this.Minimize.Margin = new System.Windows.Forms.Padding(0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(26, 26);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 3;
            this.Minimize.TabStop = false;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Exit.Image = global::Quinix_File_Manager.Properties.Resources.ExitButon;
            this.Exit.Location = new System.Drawing.Point(1149, 2);
            this.Exit.Margin = new System.Windows.Forms.Padding(0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(26, 26);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 1;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // LeftCorner
            // 
            this.LeftCorner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LeftCorner.BackColor = System.Drawing.Color.Transparent;
            this.LeftCorner.Image = global::Quinix_File_Manager.Properties.Resources.TopRightRoundedCorner;
            this.LeftCorner.Location = new System.Drawing.Point(1158, 0);
            this.LeftCorner.Margin = new System.Windows.Forms.Padding(0);
            this.LeftCorner.Name = "LeftCorner";
            this.LeftCorner.Size = new System.Drawing.Size(26, 26);
            this.LeftCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LeftCorner.TabIndex = 5;
            this.LeftCorner.TabStop = false;
            // 
            // RightCorner
            // 
            this.RightCorner.Image = global::Quinix_File_Manager.Properties.Resources.TopLeftRoundedCorner;
            this.RightCorner.Location = new System.Drawing.Point(0, 0);
            this.RightCorner.Margin = new System.Windows.Forms.Padding(0);
            this.RightCorner.Name = "RightCorner";
            this.RightCorner.Size = new System.Drawing.Size(26, 26);
            this.RightCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RightCorner.TabIndex = 4;
            this.RightCorner.TabStop = false;
            // 
            // Title
            // 
            this.Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(0, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1184, 30);
            this.Title.TabIndex = 6;
            this.Title.Text = "File Manager";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Title_MouseDown);
            this.Title.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Title_MouseMove);
            this.Title.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Title_MouseUp);
            // 
            // ExitAmination
            // 
            this.ExitAmination.Interval = 1;
            this.ExitAmination.Tick += new System.EventHandler(this.ExitAmination_Tick);
            // 
            // MinimizeAnimation
            // 
            this.MinimizeAnimation.Interval = 1;
            this.MinimizeAnimation.Tick += new System.EventHandler(this.MinimizeAnimation_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Quinix_File_Manager.Properties.Resources.CornerResizer;
            this.pictureBox1.Location = new System.Drawing.Point(1149, 755);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // FormContent
            // 
            this.FormContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormContent.Location = new System.Drawing.Point(0, 30);
            this.FormContent.Name = "FormContent";
            this.FormContent.Size = new System.Drawing.Size(1184, 760);
            this.FormContent.TabIndex = 7;
            // 
            // Template
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 790);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FormContent);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Template";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.Load += new System.EventHandler(this.Template_Load);
            this.TopBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftCorner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightCorner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBar;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Maximize;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox RightCorner;
        private System.Windows.Forms.PictureBox LeftCorner;
        private System.Windows.Forms.Timer ExitAmination;
        private System.Windows.Forms.Timer MinimizeAnimation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel FormContent;
    }
}

