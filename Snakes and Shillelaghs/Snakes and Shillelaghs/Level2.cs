using System;
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
    public partial class frmLevel2 : Form
    {
        public frmLevel2()
        {
            InitializeComponent();
        }

        private void btnBeginBattle_Click(object sender, EventArgs e)
        {
            btnFire.Visible = true;
            pgbSnakeLife.Visible = true;
            pgbLeprechaunLife.Visible = true;
            btnBeginBattle.Visible = false;
            timer2.Start();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
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
                    timer2.Stop();
                    picYouWon.Visible = true;
                }
            }
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            picSnakeOrb.Visible = true;
            this.SuspendLayout();
            picSnakeOrb.Location = new Point(picSnakeOrb.Location.X - 60, picSnakeOrb.Location.Y);
            this.ResumeLayout();

            if (picSnakeOrb.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                picSnakeOrb.Location = new Point(682, 407);
                pgbLeprechaunLife.Minimum = 0;
                pgbLeprechaunLife.Maximum = frmWeaponChooser.intnum1;
                if ((frmWeaponChooser.damage + pgbLeprechaunLife.Value) >= pgbLeprechaunLife.Maximum)
                {
                    pgbLeprechaunLife.Value += (pgbLeprechaunLife.Maximum - pgbLeprechaunLife.Value);
                }
                else
                {
                    pgbLeprechaunLife.Value += frmWeaponChooser.damage;
                }


                //leprechaun dies
                if (pgbLeprechaunLife.Value == pgbLeprechaunLife.Maximum)
                {
                    btnFire.Visible = false;
                    timer1.Stop();
                    timer2.Stop();
                    picGameOver.Visible = true;
                }
            }
        }

        private void picGameOver_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picYouWon_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}