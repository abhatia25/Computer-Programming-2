using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jagged_Arrays
{
    public partial class frmJagArray : Form
    {
        public frmJagArray()
        {
            InitializeComponent();
        }

        public int counter = 0;
        public static string[][] jagged = new string[3][];
        public static int size = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click_1(object sender, EventArgs e)
        {
            // Print out all elements in the jagged array.
            for (int i = 0; i < jagged.Length; i++)
            {
                string[] innerArray = jagged[i];
                for (int a = 0; a < innerArray.Length; a++)
                {
                    lblOutput.Text += innerArray[a] + " ";
                }
                lblOutput.Text += "\n";
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            // Create a new array in the jagged array, and assign it.
            jagged[counter] = new string[4];
            jagged[counter][0] = txtName.Text;
            jagged[counter][1] = txtAct1.Text;
            jagged[counter][2] = txtAct2.Text;
            jagged[counter][3] = txtAct3.Text;

            //reset form
            txtAct1.Text = "";
            txtAct2.Text = "";
            txtAct3.Text = "";
            txtName.Text = "";
            counter += 1;
        }
    }
}
