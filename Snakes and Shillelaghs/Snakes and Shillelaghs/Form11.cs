using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBeginBattle_Click_1(object sender, EventArgs e)
        {
            btnFire.Visible = true;
            pgbSnakeLife.Visible = true;
            pgbLeprechaunLife.Visible = true;
            btnBeginBattle.Visible = false;
            timer2.Start();
        }

        private void btnFire_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
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
                    timer2.Stop();
                    picYouWon.Visible = true;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            picSnakeOrb.Visible = true;
            this.SuspendLayout();
            picSnakeOrb.Location = new Point(picSnakeOrb.Location.X - 60, picSnakeOrb.Location.Y);
            this.ResumeLayout();

            if (picSnakeOrb.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                picSnakeOrb.Location = new Point(682, 407);
                pgbLeprechaunLife.Value += 10;

                if (pgbLeprechaunLife.Value == 70)
                {
                    btnFire.Visible = false;
                    timer1.Stop();
                    timer2.Stop();
                    picGameOver.Visible = true;
                }
            }
        }

        private void pgbLeprechaunLife_Click(object sender, EventArgs e)
        {

        }
    }
}
