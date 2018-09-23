using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int speed = 5;
        int slide_speed = 10;

        bool game_over = false;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        int hdir = +1;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Ball.Left < 0)
            {
                hdir = +1;
            }
            else if (Ball.Left > (this.Width - Ball.Width))
            {
                hdir = -1;
            }
            
             Ball.Left += (hdir* speed);
            
        }

        int vdir = +1;
        private void Vert_Tick(object sender, EventArgs e)
        {
            if(Ball.Top < 0)
            {
                vdir = +1;
            }
            else if (Ball.Top > (this.Height - Ball.Height-Slider.Height))
            {

                if(Ball.Left < Slider.Left || ((Ball.Left + Ball.Width ) > (Slider.Left + Slider.Width)))
                {
                    Vert.Enabled = Horz.Enabled = false;
                    game_over = true;
                    pblpause.Visible = true;
                    pblpause.BackColor = Color.DarkRed;
                    pblpause.Text = "Game Over !";
                    speed = 5;
                    //MessageBox.Show('Game Over'); 
                }
                else
                {
                    speed++;
                }
                vdir = -1;
            }
           
            Ball.Top += (vdir* speed);
            
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        bool _left = false, _right = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // active
            if (e.KeyCode == Keys.Right)
            {
                _right = true;
            }
            else if(e.KeyCode == Keys.Left)
            {
                _left = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // pause game 
                pblpause.BackColor = Color.Black;
                pblpause.Text = "Game Paused";
                Vert.Enabled = Horz.Enabled = paused = false;

            }
            else if (e.KeyCode == Keys.Enter)
            {
                // resume game
                Vert.Enabled = Horz.Enabled = paused = true;
            }
        }
        bool paused
        {
            get {
                return !pblpause.Visible;
            }
            set {
                pblpause.Visible = !value;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            // inactive
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                _right = _left = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void key_watch_Tick(object sender, EventArgs e)
        {
            if (_right && Slider.Left<(this.Width - Slider.Width))
            {
                Slider.Left = Slider.Left + 20;
            }
            else if(_left && Slider.Left > 0)
            {
                Slider.Left = Slider.Left - 20;
            }
        }

       
    }
}
