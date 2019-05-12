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

        //declare public variables/objects
        public static int level = 0;
        public static int randomnumber = 0;
        public static List<int> Distractor = new List<int>() { 1, 2, 3, 4};
        public static int index = 0;
        public static int[][] array = new int[][] { new int [] { 1, 2, 3, 4, 5 }, new int[] { 2, 3, 4, 5, 6 } };
        public static int[] array1 = new int[5];
        public static int[] array2 = new int[5];

        private void btnContinue_Click(object sender, EventArgs e) //btnStart
        {
            frmWeaponChooser frmWeaponChooserForm = new frmWeaponChooser();
            this.Hide();
            frmWeaponChooserForm.Show();
        }

        private void frmInstructions_Load(object sender, EventArgs e)
        {
            //not being used
        }

        private void lblInstructions_Click(object sender, EventArgs e)
        {
            //not being used
        }
    }
}