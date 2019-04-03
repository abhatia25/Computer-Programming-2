using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

enum Damage { shillelagh = 500, sword = 300,  axe = 100, knife = 50} //enum to hold damage values

namespace Snakes_and_Shillelaghs
{
    public partial class frmWeaponChooser : Form
    {
        public frmWeaponChooser()
        {
            InitializeComponent();
        }

        private void picShillelagh_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("shillelagh", "brown", (int)Damage.shillelagh); //constructors passing to method in weapons class
            WeaponSelected();
        }

        private void picSword_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("sword", "silver", (int)Damage.sword);
            WeaponSelected();
        }

        private void picAxe_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("axe", "brown and silver", (int)Damage.axe);
            WeaponSelected();
        }

        private void picKnife_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("knife", "black", (int)Damage.knife);
            WeaponSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int intnum1 = 0;

            Random RandomnumGen = new Random();

            intnum1 = RandomnumGen.Next(0, 1000);

            LeprechaunStruct.health = intnum1;
        }

        private void WeaponSelected()
        {
            picAxe.Visible = false;
            picKnife.Visible = false;
            picShillelagh.Visible = false;
            picSword.Visible = false;
            btnAdvance.Visible = true;
        }

        private void btnAdvance_Click(object sender, EventArgs e)
        {
            //add code here to advance the forms when both projects are combined
            Animation.frmBATTLElvl1 frmBATTLElvl1Form = new Animaiton.frmBATTLElvl1();
            this.Hide();
            Animation.frmBATTLElvl1.Show();
        }

        private void KeyPressExit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Environment.Exit(0);
            }
        }
    }
}