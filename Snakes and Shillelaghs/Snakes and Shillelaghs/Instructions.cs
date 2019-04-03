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
    public partial class frmInstructions : Form
    {
        public frmInstructions()
        {
            InitializeComponent();
        }
        public static int level = 0;
        private void btnContinue_Click(object sender, EventArgs e) //btnStart
        {
            frmWeaponChooser frmWeaponChooserForm = new frmWeaponChooser();
            this.Hide();
            frmWeaponChooserForm.Show();
        }
    }
}
