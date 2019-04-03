﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_and_Shillelaghs
{
    public partial class frmLevel1 : Form
    {

        public frmLevel1()
        {
            InitializeComponent();
        }

        private void frmLevel1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBeginBattle_Click_1(object sender, EventArgs e)
        {
            btnFire.Visible = true;
            pgbSnakeLife.Visible = true;
            btnBeginBattle.Visible = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        { //add loop here instead of nested if statements
            //timer moves picture across screen
            this.SuspendLayout();
            picOrb.Location = new Point(picOrb.Location.X + 60, picOrb.Location.Y);
            this.ResumeLayout();

            //progressbar increases when pictureboxes collide
            if (picOrb.Bounds.IntersectsWith(picLiveSnake.Bounds))
            {
                picOrb.Location = new Point(280, 482);
                timer1.Stop();
                pgbSnakeLife.Minimum = 0;
                pgbSnakeLife.Maximum = frmWeaponChooser.intnum1;
                if ((frmWeaponChooser.damage + pgbSnakeLife.Value) >= pgbSnakeLife.Maximum)
                {
                    pgbSnakeLife.Value += (pgbSnakeLife.Maximum - pgbSnakeLife.Value);
                }
                else
                {
                    pgbSnakeLife.Value += frmWeaponChooser.damage;
                }
                    

                //snake dies
                if (pgbSnakeLife.Value == pgbSnakeLife.Maximum)
                {
                    picLiveSnake.Visible = false;
                    picDeadSnake.Visible = true;
                    btnFire.Visible = false;
                    timer1.Stop();
                    picYouWon.Visible = true;
                }
            }
            /*int width = this.Width; // get the width of Form.
            if (picOrb.Location.X > width - picOrb.Width) //to check condition if pic box is touch the boundroy of form width
            {
                picOrb.Location = new Point(1, picOrb.Location.Y); // pic box is set to the new point. here 1 is indicate of X coordinate.
            }
            else
            {
                picOrb.Location = new Point(picOrb.Location.X + 30, picOrb.Location.Y); // to move picture box from x coordinate by 100 Point.
            }*/
        }

        private void btnFire_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void picYouWon_Click(object sender, EventArgs e)
        {
            frmWeaponChooser frmWeaponChooser = new frmWeaponChooser();
            this.Hide();
            frmWeaponChooser.Show();
        }
    }
}
