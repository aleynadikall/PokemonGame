using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonGame
{
    public partial class Form1 : Form
    {
        bool Ash_Front = true;
        bool Ash_Back = false;
        bool Ash_Left = false;
        bool Ash_Right = false;
        bool Ash_Stop = true;
        bool Ash_First_Movement = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                Ash_Front = false;
                Ash_Back = false;
                Ash_Left = false;
                Ash_Right = false;
                Ash_Movement_timer1.Enabled = true;
                Ash_Stop = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                Ash_Back = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                Ash_Front = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                Ash_Left = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                Ash_Right = true;
            }

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                Ash_Stop = true;
            }
        }

        private void Ash_Movement_timer1_Tick(object sender, EventArgs e)
        {
            Image img = null;

            if(!Ash_Stop)
            {
                if(Ash_First_Movement)
                {
                    if (Ash_Front)
                    {
                        img = Properties.Resources.Ash_Front_2;
                    }
                    else if (Ash_Back)
                    {
                        img = Properties.Resources.Ash_Back_2;

                    }
                    else if (Ash_Left)
                    {
                        img = Properties.Resources.Ash_Left_2;

                    }
                    else if (Ash_Right)
                    {
                        img = Properties.Resources.Ash_Right_2;

                    }
                    Ash_First_Movement = false;
                }
                else
                {
                    if (Ash_Front)
                    {
                        img = Properties.Resources.Ash_Front_3;
                    }
                    else if (Ash_Back)
                    {
                        img = Properties.Resources.Ash_Back_3;

                    }
                    else if (Ash_Left)
                    {
                        img = Properties.Resources.Ash_Left_1;

                    }
                    else if (Ash_Right)
                    {
                        img = Properties.Resources.Ash_Right_1;

                    }
                    Ash_First_Movement = true;

                }

                if(Ash_Front)
                {
                    Ash_pictureBox1.Top = Ash_pictureBox1.Top + 80;
                }
                else if(Ash_Back)
                {
                    Ash_pictureBox1.Top = Ash_pictureBox1.Top - 80;

                }
                else if (Ash_Left)
                {
                    Ash_pictureBox1.Left = Ash_pictureBox1.Left - 80;

                }
                else if (Ash_Right)
                {
                    Ash_pictureBox1.Left = Ash_pictureBox1.Left + 80;

                }
            }
            else
            {
                Ash_First_Movement = true;
                Ash_Movement_timer1.Enabled = false;
                if (Ash_Front)
                {
                    img = Properties.Resources.Ash_Front_1;
                }
                else if (Ash_Back)
                {
                    img = Properties.Resources.Ash_Back_1;

                }
                else if (Ash_Left)
                {
                    img = Properties.Resources.Ash_Left_1;

                }
                else if (Ash_Right)
                {
                    img = Properties.Resources.Ash_Right_1;

                }
            }
            Ash_pictureBox1.BackgroundImage = img;
        }
    }
}
