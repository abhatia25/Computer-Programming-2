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
        public static int damage = 0;
        public frmWeaponChooser()
        {
            InitializeComponent();
        }
        public static int intnum1 = 0;

        private void picShillelagh_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("shillelagh", "brown", (int)Damage.shillelagh); //constructors passing to method in weapons class
            damage = ActiveWeapon.damage;
            WeaponSelected();
        }

        private void picSword_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("sword", "silver", (int)Damage.sword);
            damage = ActiveWeapon.damage;
            WeaponSelected();
        }

        private void picAxe_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("axe", "brown and silver", (int)Damage.axe);
            damage = ActiveWeapon.damage;
            WeaponSelected();
        }

        private void picKnife_Click(object sender, EventArgs e)
        {
            Weapons ActiveWeapon = new Weapons();
            ActiveWeapon.Declarations("knife", "black", (int)Damage.knife);
            damage = ActiveWeapon.damage;
            WeaponSelected();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random RandomnumGen = new Random();

            intnum1 = RandomnumGen.Next(500, 5000);

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
            if (frmInstructions.level == 1)
            {
                frmLevel2 frmLevel2 = new frmLevel2();
                this.Hide();
                frmLevel2.Show();
            }
            if (frmInstructions.level == 0)
            {
                frmInstructions.level += 1;
                frmLevel1 frmLevel1 = new frmLevel1();
                this.Hide();
                frmLevel1.Show();
            }
        }

        /*private void KeyPressExit(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Environment.Exit(0);
            }
        }*/
    }
}