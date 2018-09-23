namespace Simple_Game
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Ball = new System.Windows.Forms.PictureBox();
            this.Slider = new System.Windows.Forms.PictureBox();
            this.Vert = new System.Windows.Forms.Timer(this.components);
            this.Horz = new System.Windows.Forms.Timer(this.components);
            this.ExitApp = new System.Windows.Forms.PictureBox();
            this.key_watch = new System.Windows.Forms.Timer(this.components);
            this.pblpause = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).BeginInit();
            this.SuspendLayout();
            // 
            // Ball
            // 
            this.Ball.Enabled = false;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(7, 91);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(66, 61);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ball.TabIndex = 0;
            this.Ball.TabStop = false;
            this.Ball.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Slider
            // 
            this.Slider.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Slider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Slider.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Slider.Location = new System.Drawing.Point(46, 439);
            this.Slider.Name = "Slider";
            this.Slider.Size = new System.Drawing.Size(153, 13);
            this.Slider.TabIndex = 1;
            this.Slider.TabStop = false;
            this.Slider.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Vert
            // 
            this.Vert.Enabled = true;
            this.Vert.Interval = 1;
            this.Vert.Tick += new System.EventHandler(this.Vert_Tick);
            // 
            // Horz
            // 
            this.Horz.Enabled = true;
            this.Horz.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ExitApp
            // 
            this.ExitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitApp.Image = ((System.Drawing.Image)(resources.GetObject("ExitApp.Image")));
            this.ExitApp.Location = new System.Drawing.Point(899, 3);
            this.ExitApp.Name = "ExitApp";
            this.ExitApp.Size = new System.Drawing.Size(19, 22);
            this.ExitApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ExitApp.TabIndex = 3;
            this.ExitApp.TabStop = false;
            this.ExitApp.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // key_watch
            // 
            this.key_watch.Enabled = true;
            this.key_watch.Tick += new System.EventHandler(this.key_watch_Tick);
            // 
            // pblpause
            // 
            this.pblpause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pblpause.BackColor = System.Drawing.Color.Black;
            this.pblpause.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pblpause.ForeColor = System.Drawing.Color.White;
            this.pblpause.Location = new System.Drawing.Point(1, 3);
            this.pblpause.Name = "pblpause";
            this.pblpause.Size = new System.Drawing.Size(917, 64);
            this.pblpause.TabIndex = 1;
            this.pblpause.Text = "Game Paused";
            this.pblpause.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pblpause.Visible = false;
            this.pblpause.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(42)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(917, 454);
            this.Controls.Add(this.ExitApp);
            this.Controls.Add(this.pblpause);
            this.Controls.Add(this.Slider);
            this.Controls.Add(this.Ball);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.PictureBox Slider;
        private System.Windows.Forms.Timer Vert;
        private System.Windows.Forms.Timer Horz;
        private System.Windows.Forms.PictureBox ExitApp;
        private System.Windows.Forms.Timer key_watch;
        private System.Windows.Forms.Label pblpause;
    }
}

