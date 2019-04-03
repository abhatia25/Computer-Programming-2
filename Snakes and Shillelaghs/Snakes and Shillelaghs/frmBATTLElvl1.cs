using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation
{
    public partial class frmBATTLElvl1 : Form
    {
        public frmBATTLElvl1()
        {
            InitializeComponent();
        }

        private void btnBeginBattle_Click(object sender, EventArgs e)
        {
            btnFire.Visible = true;
            pgbSnakeLife.Visible = true;
            btnBeginBattle.Visible = false;
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
                pgbSnakeLife.Value += 10;

                //snake dies
                if (pgbSnakeLife.Value == 100)
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

        private void btnFire_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pgbSnakeLife_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}