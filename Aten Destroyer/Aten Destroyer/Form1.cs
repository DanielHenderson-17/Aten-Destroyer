using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aten_Destroyer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lbl_over.Visible = false;
        }
        int score, kill;

        void Game_Result()
        {
            foreach(Control j in this.Controls)
            {
                if(j is PictureBox && j.Tag=="enemy")
                {
                    if (bullet.Bounds.IntersectsWith(j.Bounds))
                    {
                        score += 5;
                        kill++;
                        lbl_kill.Text = "Killed :" + kill;
                        lbl_score.Text = "Score :" + score;
                        j.Left = 1500;
                        bullet.Image = Properties.Resources.explosion2;
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\djhin\Desktop\C#\Aten Destroyer\Aten Destroyer\Aten Destroyer\Resources\explosion_sound.wav");
                        sound.Play();
                    }

                    if (player.Bounds.IntersectsWith(j.Bounds))
                    {
                        lbl_over.Visible = true;
                        player.Image = Properties.Resources.explosion;
                        timer1.Stop();
                        System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\djhin\Desktop\C#\Aten Destroyer\Aten Destroyer\Aten Destroyer\Resources\game_over_sound.wav");
                        sound.Play();
                    }
                }
            }
        }

        void Bullet()
        {
            bullet.Left += 100;
            if(bullet.Left > 600)
            {
                bullet.Image = Properties.Resources.bullet;
                bullet.Left = player.Left + 20;
                bullet.Top = player.Top + 15;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(@"C:\Users\djhin\Desktop\C#\Aten Destroyer\Aten Destroyer\Aten Destroyer\Resources\explosion_sound.wav");
                sound.Play();
            }

            e_1_bullet.Left -= 20;
            if(e_1_bullet.Left<0)
            {
                e_1_bullet.Left = e_1.Left;
                e_1_bullet.Top = e_1.Top + 15;
            }

            e_2_bullet.Left -= 20;
            if (e_2_bullet.Left < 0)
            {
                e_2_bullet.Left = e_2.Left;
                e_2_bullet.Top = e_2.Top + 15;
            }

            e_3_bullet.Left -= 20;
            if (e_3_bullet.Left < 0)
            {
                e_3_bullet.Left = e_3.Left;
                e_3_bullet.Top = e_3.Top + 15;
            }
        }

        void Stars()
        {
            foreach(Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag=="star")
                {
                    x.Left -= 5;
                    if (x.Left < 0)
                    {
                        x.Left = 800;
                    }
                }
            }
        }

        void Rocks()
        {
            Random rnd = new Random();
            int x, y;
            rock_1.Left -= 2;
            if(rock_1.Left<0)
            {
                x = rnd.Next(0, 400);
                rock_1.Location = new Point(800, x);
            }
            rock_2.Left-= 2;
            if (rock_2.Left< 0)
            {
               y = rnd.Next(0, 500);
                rock_2.Location= new Point(800, y);
            }

        }

        void enemy()
        {
            Random rnd = new Random();
            int a, b, c;
            e_1.Left -= 10;
            if(e_1.Left<0)
            {
                a = rnd.Next(0, 200);
                e_1.Location = new Point(800, a);
            }
            e_2.Left -= 10;
            if (e_2.Left < 0)
            {
                b = rnd.Next(0, 400);
                e_2.Location = new Point(800, b);
            }
            e_3.Left -= 10;
            if (e_3.Left < 0)
            {
                c = rnd.Next(0, 500);
                e_3.Location = new Point(800, c);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Up)
            {
                if(player.Top>20)
                {
                    player.Top -= 10;
                }
            }
            if (e.KeyCode == Keys.Down)
            {
                if (player.Top < 350)
                {
                    player.Top += 10;
                }
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Bullet();
            Stars();
            Rocks();
            enemy();
            Game_Result();
        }
    }
}
