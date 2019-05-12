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
        //declare global variable
        public static int result = 0;
        private void btnBeginBattle_Click(object sender, EventArgs e)
        {
            //show controls for battle and begin the battle
            btnFire.Visible = true;
            pgbSnakeLife.Visible = true;
            pgbLeprechaunLife.Visible = true;
            btnBeginBattle.Visible = false;
            timer2.Start();
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            //start timer
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
            //same as with leprechaun orb but this is used for snake attacking the leprechaun back
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
            //stop all timers and display the randomly generated magic number
            timer1.Stop();
            timer2.Stop();
            SortClass.SortMethod();
            SearchClass.Search();
            MessageBox.Show("Your magic number is " + result);
            Environment.Exit(0);
        }

        private void picYouWon_Click(object sender, EventArgs e)
        {
            //stop all timers and display the randomly generated magic number
            timer1.Stop();
            timer2.Stop();
            SortClass.SortMethod();
            SearchClass.Search();
            MessageBox.Show("Your magic number is " + result);
            picGameOver.Visible = false;
            picLiveSnake.Visible = false;
            pgbLeprechaunLife.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pgbSnakeLife.Visible = false;
            btnFire.Visible = false;
            picOrb.Visible = false;
            picSnakeOrb.Visible = false;
            picDeadSnake.Visible = false;
            textBox1.Visible = true;
            button1.Visible = true;
            label1.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //enable distraction and change bird image in distraction picture box
            Distraction.NumberGen();
            Distraction.Search();
            lblDistraction.Visible = true;
            picDistraction1.Visible = true;
            timer4.Start();
            if (frmInstructions.index == 0)
            {
                picDistraction1.BackgroundImage = Snakes_and_Shillelaghs.Properties.Resources.bird1;
            }
            else if (frmInstructions.index == 1)
            {
                picDistraction1.BackgroundImage = Snakes_and_Shillelaghs.Properties.Resources.bird2;
            }
            else if (frmInstructions.index == 2)
            {
                picDistraction1.BackgroundImage = Snakes_and_Shillelaghs.Properties.Resources.bird3;
            }
            else if (frmInstructions.index == 3)
            {
                picDistraction1.BackgroundImage = Snakes_and_Shillelaghs.Properties.Resources.bird4;
            }
            timer2.Enabled = false;
            timer3.Start();
        }

        private void frmLevel2_Load(object sender, EventArgs e)
        {
            //not being used
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            //get rid of distraction picture box and continue battle
            timer3.Stop();
            picDistraction1.Visible = false;
            lblDistraction.Visible = false;
            timer2.Enabled = true;
        }

        float angle = 0;
        float rotSpeed = 90;
        Point origin = new Point(716, 93);
        int distance = 20;

        private void timer4_Tick(object sender, EventArgs e)
        {
            angle += rotSpeed;
            int x = (int)(origin.X + distance * Math.Sin(angle * Math.PI / 180f));
            int y = (int)(origin.Y + distance * Math.Cos(angle * Math.PI / 180f));
            picDistraction1.Location = new Point(x, y);
        }

        private void picGold_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int return1 = 0;
            Int32.TryParse(textBox1.Text, out return1);

            textBox1.Visible = false;
            button1.Visible = false;
            label1.Visible = false;

            if ( result ==  return1)
            {
                picGold.Visible = true;
                pictureBox4.Visible = true;
            }
            else
            {
                MessageBox.Show("You entered your magic number incorrectly. You did not get the prize.");
                Environment.Exit(0);
            }
        }
    }
}